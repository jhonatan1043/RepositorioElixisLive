Imports System.Data.SqlClient
Public Class ProductoUbicacionDAL
    Public Shared Sub guardar(objUbicacionProducto As UbicacionProducto)
        Dim objConexio As New ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                comando.Connection = objConexio.cnxbd
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Clear()
                comando.CommandText = objUbicacionProducto.sqlGuardar
                comando.Parameters.Add(New SqlParameter("@TablaP", SqlDbType.Structured)).Value = objUbicacionProducto.dtProducto
                comando.Parameters.Add(New SqlParameter("@TablaL", SqlDbType.Structured)).Value = objUbicacionProducto.dtLote
                comando.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
    End Sub
End Class
