Imports System.Data.SqlClient
Public Class ProgramacionPagoProveedorDAL

    Public Shared Sub guardarProgramacion(programacion As ProgramacionPagoProveedor, fechaCorte As Date, fechaDoc As Date)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_PROGRAMACION_PROVEEDOR_GUARDAR"

                'Parametros
                dbCommand.Parameters.Add(New SqlParameter("@fechaCorte", SqlDbType.Date))
                dbCommand.Parameters.Add(New SqlParameter("@fechaDoc", SqlDbType.Date))
                dbCommand.Parameters.Add(New SqlParameter("@codigoProgramacion", SqlDbType.Int))
                dbCommand.Parameters.Add(New SqlParameter("@tblProgramacion", SqlDbType.Structured))
                dbCommand.Parameters.Add(New SqlParameter("@pCodigoCuenta", SqlDbType.NVarChar))
                dbCommand.Parameters.Add(New SqlParameter("@pNumcheque", SqlDbType.NVarChar))
                dbCommand.Parameters.Add(New SqlParameter("@pUsuario", SqlDbType.Int))

                'Valores
                dbCommand.Parameters("@fechaCorte").Value = fechaCorte
                dbCommand.Parameters("@fechaDoc").Value = fechaDoc
                dbCommand.Parameters("@codigoProgramacion").Direction = ParameterDirection.Output
                dbCommand.Parameters("@tblProgramacion").Value = programacion.detalleProgramacion
                dbCommand.Parameters("@pCodigoCuenta").Value = programacion.codigoCuentaCredito
                dbCommand.Parameters("@pNumcheque").Value = programacion.numeroCheque
                dbCommand.Parameters("@pUsuario").Value = SesionActual.idUsuario

                dbCommand.ExecuteNonQuery()

                programacion.codigoProgramacion = dbCommand.Parameters("@codigoProgramacion").Value

            End Using
        Catch ex As Exception
            Throw ex
        Finally
            conexion.desconectar()
        End Try
    End Sub

End Class
