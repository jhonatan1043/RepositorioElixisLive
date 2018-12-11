Imports System.Data.SqlClient
Public Class EntradaInventarioDAL
    Public Shared Function guardarEntrada(objEntrada As EntradaInventario) As EntradaInventario
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objEntrada.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo_Compra", SqlDbType.Int)).Value = objEntrada.codigoCompra
                    comando.Parameters.Add(New SqlParameter("@Codigo_Movimiento", SqlDbType.Int)).Value = objEntrada.codigoMovimiento
                    comando.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objEntrada.dtEntrada
                    objEntrada.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objEntrada
    End Function
End Class
