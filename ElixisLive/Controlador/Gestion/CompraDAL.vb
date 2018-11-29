Imports System.Data.SqlClient
Public Class CompraDAL
    Public Shared Function guardarCompra(objCompra As Compra) As Compra
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objCompra.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objCompra.codigo
                    comando.Parameters.Add(New SqlParameter("@Codigo_persona", SqlDbType.Int)).Value = objCompra.codigoPersona
                    comando.Parameters.Add(New SqlParameter("@Fecha_Compra", SqlDbType.DateTime)).Value = objCompra.fechaCompra
                    comando.Parameters.Add(New SqlParameter("@Numero_Factura", SqlDbType.NVarChar)).Value = objCompra.numeroFactura
                    comando.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objCompra.dtCompra
                    objCompra.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objCompra
    End Function
End Class
