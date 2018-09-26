Imports System.Data.SqlClient
Public Class ProveedorDAL
    Public Shared Function guardar(objProveedor As Proveedor) As Proveedor
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objProveedor.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objProveedor.codigoProducto
                    comando.Parameters.Add(New SqlParameter("@Foto", SqlDbType.VarBinary)).Value = objProveedor.foto
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objProveedor.dtParametro
                    objProveedor.codigoProducto = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objProveedor
    End Function
End Class
