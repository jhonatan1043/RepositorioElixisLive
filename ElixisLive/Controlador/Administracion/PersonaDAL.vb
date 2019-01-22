Imports System.Data.SqlClient
Public Class PersonaDAL
    Public Shared Function guardar(objPersona As persona) As persona
        Dim objConexio As New ConexionBD
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
                    comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objPersona.nombre
                    comando.Parameters.Add(New SqlParameter("@telefono", SqlDbType.NVarChar)).Value = objPersona.telefono
                    comando.Parameters.Add(New SqlParameter("@celular", SqlDbType.NVarChar)).Value = objPersona.celular
                    comando.Parameters.Add(New SqlParameter("@direccion", SqlDbType.NVarChar)).Value = objPersona.direccion
                    comando.Parameters.Add(New SqlParameter("@codigo_Departamento", SqlDbType.NVarChar)).Value = objPersona.codigoDepartamento
                    comando.Parameters.Add(New SqlParameter("@codigo_ciudad", SqlDbType.NVarChar)).Value = objPersona.codigoCiudad
                    comando.Parameters.Add(New SqlParameter("@codigo_Tipo_Identificacion", SqlDbType.Int)).Value = objPersona.codigoTipoIdentificacion
                    comando.Parameters.Add(New SqlParameter("@correo", SqlDbType.NVarChar)).Value = objPersona.correo
                    comando.Parameters.Add(New SqlParameter("@CodigoPerfil", SqlDbType.Int)).Value = objPersona.codigoPerfil
                    comando.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar)).Value = objPersona.usuario
                    comando.Parameters.Add(New SqlParameter("@Asignar", SqlDbType.Bit)).Value = objPersona.asignar
                    comando.Parameters.Add(New SqlParameter("@Empleado", SqlDbType.Bit)).Value = objPersona.chEmpleado
                    comando.Parameters.Add(New SqlParameter("@Cliente", SqlDbType.Bit)).Value = objPersona.chCliente
                    comando.Parameters.Add(New SqlParameter("@Proveedor", SqlDbType.Bit)).Value = objPersona.chProveedor
                    comando.Parameters.Add(New SqlParameter("@codigoEmpleado", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@TablaSucursal", SqlDbType.Structured)).Value = extrarColumna(objPersona)
                    objPersona.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desconectar()
        End Try
        Return objPersona
    End Function
    Private Shared Function extrarColumna(objPersona As persona) As DataTable
        Dim tabla As New DataTable
        tabla = objPersona.dtSucursal.Copy
        tabla.Columns.Remove("Nombre")
        tabla.Columns.Remove("Realizado")
        Return tabla
    End Function
End Class
