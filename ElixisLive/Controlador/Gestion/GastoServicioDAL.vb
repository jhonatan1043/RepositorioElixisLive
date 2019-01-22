Imports System.Data.SqlClient
Public Class GastoServicioDAL
    Public Shared Function guardar(objGastoServicio As GastoServicio) As GastoServicio
        Dim objConexio As New ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objGastoServicio.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objGastoServicio.codigo
                    comando.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime)).Value = objGastoServicio.fecha
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objGastoServicio.dtGasto
                    objGastoServicio.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desconectar()
        End Try
        Return objGastoServicio
    End Function

End Class
