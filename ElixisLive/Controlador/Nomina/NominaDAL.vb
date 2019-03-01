Imports System.Data.SqlClient
Public Class NominaDAL
    Public Shared Function guardarNomina(nomina As Nomina)
        Dim objConexio As New ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = "SP_NOMINA_CREAR"
                    comando.Parameters.Add(New SqlParameter("@fechaInicio", SqlDbType.Date)).Value = nomina.fechaInicio
                    comando.Parameters.Add(New SqlParameter("@fechaFinal", SqlDbType.Date)).Value = nomina.fechaFin
                    comando.Parameters.Add(New SqlParameter("@usuario", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@nomina", SqlDbType.Structured)).Value = nomina.dtNomina
                    nomina.codigoNomina = CType(comando.ExecuteScalar, Integer)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            objConexio.desconectar()
        End Try
        Return nomina.codigoNomina
    End Function
End Class
