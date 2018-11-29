Imports System.Data.SqlClient
Public Class ListaPrecioDAL
    Public Shared Function guardarLista(objLista As ListaPrecio) As ListaPrecio
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objLista.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objLista.codigo
                    comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objLista.nombre
                    comando.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@Codigo_Tipo", SqlDbType.Int)).Value = objLista.codigoTipoLista
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objLista.dtPrecio
                    objLista.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objLista
    End Function
End Class
