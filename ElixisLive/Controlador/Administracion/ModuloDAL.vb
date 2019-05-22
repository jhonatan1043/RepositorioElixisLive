Imports System.Data.SqlClient
Public Class ModuloDAL
    Dim conexion As New ConexionBD
    Public Sub guardarModulo(ByVal modulo As Modulo)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_ADMIN_MENU_SUCURSAL_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@codigoSucursal", SqlDbType.Int)).Value = SesionActual.codigoSucursal
                dbCommand.Parameters.Add(New SqlParameter("@tablaSucursal", SqlDbType.Structured)).Value = modulo.dtModulo
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try

    End Sub
End Class
