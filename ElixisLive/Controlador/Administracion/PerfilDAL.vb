Imports System.Data.SqlClient
Public Class PerfilDAL
    Public Shared Function guardarPerfil(objPerfil As Perfil) As Perfil
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objPerfil.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objPerfil.codigo
                    comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objPerfil.nombre
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objPerfil.dtPerfil
                    objPerfil.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objPerfil
    End Function
End Class
