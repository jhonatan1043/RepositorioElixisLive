Imports System.Data.SqlClient
Public Class ConfigDAL
    Public Shared Function guardar(objConfig As Configuracion) As Configuracion
        Dim objConexio As New ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objConfig.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objConfig.codigo
                    comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objConfig.descripcion
                    objConfig.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
            objConexio.desconectar()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
        Return objConfig
    End Function
End Class
