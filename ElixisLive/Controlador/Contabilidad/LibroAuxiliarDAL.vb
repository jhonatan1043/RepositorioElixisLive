﻿Imports System.Data.SqlClient

Public Class LibroAuxiliarDAL

    Public Shared Sub calcularLibroAuxiliar(params As LibroAuxiliarParams)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "[SP_LIBRO_AUX_CALCULAR]"

                dbCommand.Parameters.Add(New SqlParameter("@codigo_puc", SqlDbType.Int)).Value = params.codigoPUC
                dbCommand.Parameters.Add(New SqlParameter("@codigo_cuenta", SqlDbType.NVarChar)).Value = params.codigoCuenta
                dbCommand.Parameters.Add(New SqlParameter("@id_tercero", SqlDbType.Int)).Value = IIf(params.idTercero = Nothing,
                                                                                                        DBNull.Value,
                                                                                                        params.idTercero)
                dbCommand.Parameters.Add(New SqlParameter("@fecha_inicio", SqlDbType.DateTime)).Value = params.fechaInicio
                dbCommand.Parameters.Add(New SqlParameter("@fecha_fin", SqlDbType.DateTime)).Value = params.fechaFin
                dbCommand.Parameters.Add(New SqlParameter("@resultado", SqlDbType.Bit))
                dbCommand.Parameters("@resultado").Direction = ParameterDirection.Output

                dbCommand.ExecuteNonQuery()

                params.resultado = dbCommand.Parameters("@resultado").Value

            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try
    End Sub

End Class
