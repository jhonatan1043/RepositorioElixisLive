Imports System.Data.SqlClient
Public Class CambioClaveDAL
    Public Shared Sub guardarClave(objClave As CambioClave)
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = "SP_CAMBIAR_CLAVE_GUARDAR"
                    comando.Parameters.Add(New SqlParameter("@contranueva", SqlDbType.NVarChar)).Value = objClave.confirmarClave
                    comando.Parameters.Add(New SqlParameter("@usuario", SqlDbType.NVarChar)).Value = objClave.nombreUsuario
                    comando.ExecuteNonQuery()
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try

    End Sub
End Class
