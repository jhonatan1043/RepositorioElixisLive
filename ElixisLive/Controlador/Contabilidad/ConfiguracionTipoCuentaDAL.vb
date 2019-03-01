Imports System.Data.SqlClient
Public Class ConfiguracionTipoCuentaDAL
    Public Sub crearConfiguracion(ByVal objConfiguracionTipoCuenta As ConfiguracionTipoCuenta)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand

                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_TIPO_CUENTA_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@TipoCuenta", SqlDbType.Structured)).Value = objConfiguracionTipoCuenta.dtCuentas
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
