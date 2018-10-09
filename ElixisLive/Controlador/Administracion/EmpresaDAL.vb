Imports System.Data.SqlClient
Public Class EmpresaDAL
    Public Shared Function guardar(objEmpresa As Empresa) As Empresa
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
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
                    comando.Parameters.Add(New SqlParameter("@Codigo_Empresa", SqlDbType.Int)).Value = SesionActual.idEmpresa
                    comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objEmpresa.nombre
                    comando.Parameters.Add(New SqlParameter("@Foto", SqlDbType.VarBinary)).Value = objEmpresa.foto
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
