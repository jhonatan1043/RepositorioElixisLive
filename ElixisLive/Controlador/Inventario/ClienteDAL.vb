Imports System.Data.SqlClient
Public Class ClienteDAL
    Public Shared Function guardar(objCliente As Cliente) As Cliente
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objCliente.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objCliente.codigoProducto
                    comando.Parameters.Add(New SqlParameter("@Foto", SqlDbType.VarBinary)).Value = objCliente.foto
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objCliente.dtParametro
                    objCliente.codigoProducto = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objCliente
    End Function
End Class
