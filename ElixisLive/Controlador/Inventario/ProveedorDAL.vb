Imports System.Data.SqlClient
Public Class ProveedorDAL
    Public Shared Function guardar(objProveedor As Proveedor) As Proveedor
        Dim objConexio As New ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objProveedor.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objProveedor.codigo
                    comando.Parameters.Add(New SqlParameter("@Codigo_Regime", SqlDbType.Int)).Value = objProveedor.codigoRegimen
                    comando.Parameters.Add(New SqlParameter("@Codigo_Forma_pago", SqlDbType.Int)).Value = objProveedor.codigoFormaPago
                    comando.Parameters.Add(New SqlParameter("@Codigo_Banco", SqlDbType.Int)).Value = objProveedor.codigoBanco
                    comando.Parameters.Add(New SqlParameter("@Codigo_Tipo_Cuenta", SqlDbType.Int)).Value = objProveedor.codigoCuenta
                    comando.Parameters.Add(New SqlParameter("@Codigo_Tipo_Pago", SqlDbType.Int)).Value = objProveedor.CodigoTipoPago
                    comando.Parameters.Add(New SqlParameter("@Numero_Cuenta", SqlDbType.NVarChar)).Value = objProveedor.Cuenta
                    comando.Parameters.Add(New SqlParameter("@Usuario_Creacion", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objProveedor.dtParametro
                    objProveedor.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            objConexio.desconectar()
        End Try
        Return objProveedor
    End Function
End Class
