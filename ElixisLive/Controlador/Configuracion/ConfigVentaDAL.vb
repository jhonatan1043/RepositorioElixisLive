Imports System.Data.SqlClient
Public Class ConfigVentaDAL
    Public Shared Function guardar(objConfig As ConfigVenta) As ConfigVenta
        Dim objConexio As New  ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                comando.Connection = objConexio.cnxbd
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Clear()
                comando.CommandText = objConfig.sqlGuardar
                comando.Parameters.Add(New SqlParameter("@codigo_Empresa", SqlDbType.Int)).Value = SesionActual.codigoEmpresa
                comando.Parameters.Add(New SqlParameter("@Codigo_Lista_Producto", SqlDbType.Int)).Value = objConfig.codigoListaProducto
                comando.Parameters.Add(New SqlParameter("@Codigo_Lista_Servicio", SqlDbType.Int)).Value = objConfig.codigoListaServicio
                comando.Parameters.Add(New SqlParameter("@Indice", SqlDbType.Int)).Value = objConfig.indice
                comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objConfig.dtEvento
                comando.ExecuteNonQuery()
            End Using
            objConexio.desconectar()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
        Return objConfig
    End Function
End Class
