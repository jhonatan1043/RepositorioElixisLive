Imports System.Data.SqlClient
Public Class EmpresaDAL
    Public Shared Function guardar(objEmpresa As Empresa) As Empresa
        Dim objConexio As New ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objEmpresa.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objEmpresa.codigo
                    comando.Parameters.Add(New SqlParameter("@Nit", SqlDbType.NVarChar)).Value = objEmpresa.identificacion
                    comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objEmpresa.nombre
                    comando.Parameters.Add(New SqlParameter("@telefono", SqlDbType.NVarChar)).Value = objEmpresa.telefono
                    comando.Parameters.Add(New SqlParameter("@celular", SqlDbType.NVarChar)).Value = objEmpresa.celular
                    comando.Parameters.Add(New SqlParameter("@direccion", SqlDbType.NVarChar)).Value = objEmpresa.direccion
                    comando.Parameters.Add(New SqlParameter("@codigo_Departamento", SqlDbType.NVarChar)).Value = objEmpresa.codigoDepartamento
                    comando.Parameters.Add(New SqlParameter("@codigo_ciudad", SqlDbType.NVarChar)).Value = objEmpresa.codigoCiudad
                    comando.Parameters.Add(New SqlParameter("@correo", SqlDbType.NVarChar)).Value = objEmpresa.correo
                    comando.Parameters.Add(New SqlParameter("@encabezado", SqlDbType.NVarChar)).Value = objEmpresa.encabezado
                    comando.Parameters.Add(New SqlParameter("@pie", SqlDbType.NVarChar)).Value = objEmpresa.pie
                    comando.Parameters.Add(New SqlParameter("@Foto", SqlDbType.VarBinary)).Value = objEmpresa.imagenEmpresa
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objEmpresa.dtParametro
                    objEmpresa.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objEmpresa
    End Function
End Class
