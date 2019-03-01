Imports System.Data.SqlClient
Public Class CambioClaveDAL
    Public Shared Sub guardarClave(objClave As CambioClave)
        Dim objConexio As New ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = "SP_CAMBIAR_CLAVE_GUARDAR"
                    comando.Parameters.Add(New SqlParameter("@clave", SqlDbType.NVarChar)).Value = objClave.confirmarClave
                    comando.Parameters.Add(New SqlParameter("@codigoPersona", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.ExecuteNonQuery()
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            objConexio.desconectar()
        End Try

    End Sub
End Class
