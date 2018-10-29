Imports System.Data.SqlClient
Public Class PersonaDAL
    Public Shared Function guardar(objPersona As persona) As persona
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objPersona.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objPersona.codigo
                    comando.Parameters.Add(New SqlParameter("@Nit", SqlDbType.NVarChar)).Value = objPersona.identificacion
                    comando.Parameters.Add(New SqlParameter("@Codigo_Empresa", SqlDbType.Int)).Value = SesionActual.codigoSucursal
                    comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objPersona.nombre
                    comando.Parameters.Add(New SqlParameter("@telefono", SqlDbType.NVarChar)).Value = objPersona.telefono
                    comando.Parameters.Add(New SqlParameter("@celular", SqlDbType.NVarChar)).Value = objPersona.celular
                    comando.Parameters.Add(New SqlParameter("@direccion", SqlDbType.NVarChar)).Value = objPersona.direccion
                    comando.Parameters.Add(New SqlParameter("@codigo_ciudad", SqlDbType.NVarChar)).Value = objPersona.codigoCiudad
                    comando.Parameters.Add(New SqlParameter("@codigo_Tipo_Identificacion", SqlDbType.Int)).Value = objPersona.codigoTipoIdentificacion
                    comando.Parameters.Add(New SqlParameter("@correo", SqlDbType.NVarChar)).Value = objPersona.correo
                    objPersona.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objPersona
    End Function
End Class
