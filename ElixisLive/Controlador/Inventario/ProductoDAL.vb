Imports System.Data.SqlClient
Public Class ProductoDAL
    Public Shared Function guardar(objProducto As producto) As producto
        Dim objConexio As New  ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objProducto.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objProducto.codigo
                    comando.Parameters.Add(New SqlParameter("@Codigo_Marca", SqlDbType.Int)).Value = objProducto.codigoMarca
                    comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objProducto.nombre
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objProducto.dtParametro
                    objProducto.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objProducto
    End Function
End Class
