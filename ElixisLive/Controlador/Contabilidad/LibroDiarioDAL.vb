Imports System.Data.SqlClient

Public Class LibroDiarioDAL


    Public Sub calcularLibroDiario(params As LibroDiarioParams)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_E_LIBRO_DIARIO_CARGAR"

                dbCommand.Parameters.Add(New SqlParameter("@id_empresa", SqlDbType.Int)).Value = params.idEmpresa
                dbCommand.Parameters.Add(New SqlParameter("@fecha_inicio", SqlDbType.DateTime)).Value = params.fechaInicio
                dbCommand.Parameters.Add(New SqlParameter("@fecha_fin", SqlDbType.Date)).Value = params.fechaFin
                dbCommand.Parameters.Add(New SqlParameter("@resultado", SqlDbType.Bit))
                dbCommand.Parameters("@resultado").Direction = ParameterDirection.Output
                dbCommand.ExecuteNonQuery()

                params.resultado = dbCommand.Parameters("@resultado").Value
            End Using

        Catch ex As Exception
            Throw
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
