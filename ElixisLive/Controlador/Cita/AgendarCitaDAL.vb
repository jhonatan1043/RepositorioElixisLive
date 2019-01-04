Imports System.Data.SqlClient
Public Class AgendarCitaDAL
    Public Shared Function guardarCita(objCita As AgendarCita) As AgendarCita
        Dim objConexio As New ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objCita.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objCita.codigo
                    comando.Parameters.Add(New SqlParameter("@Codigo_Persona", SqlDbType.Int)).Value = objCita.codigoPersona
                    comando.Parameters.Add(New SqlParameter("@Observacion", SqlDbType.NVarChar)).Value = objCita.observacion
                    comando.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@Fecha_Cita", SqlDbType.DateTime)).Value = objCita.dtFechaCita
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objCita.dtServicio
                    objCita.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objCita
    End Function
End Class
