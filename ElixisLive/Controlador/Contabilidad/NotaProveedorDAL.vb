
Imports System.Data.SqlClient

Public Class NotaProveedorDAL
    Dim conexion As New ConexionBD
    Public Sub crearNotaProveedor(ByVal objNotaProveedor As NotaProveedor, pUSuario As Integer)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_NOTA_PROVEEDOR_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@Comprobante", SqlDbType.NVarChar)).Value = objNotaProveedor.comprobante
                dbCommand.Parameters.Add(New SqlParameter("@id_tercero", SqlDbType.Int)).Value = objNotaProveedor.idProveedor
                dbCommand.Parameters.Add(New SqlParameter("@Fecha_Recibo", SqlDbType.Date)).Value = objNotaProveedor.fechaRecibo
                dbCommand.Parameters.Add(New SqlParameter("@Observacion", SqlDbType.NVarChar)).Value = objNotaProveedor.detalleMov
                dbCommand.Parameters.Add(New SqlParameter("@valor_debito", SqlDbType.Decimal)).Value = objNotaProveedor.valorDebito
                dbCommand.Parameters.Add(New SqlParameter("@valor_credito", SqlDbType.Decimal)).Value = objNotaProveedor.valorCredito
                dbCommand.Parameters.Add(New SqlParameter("@valor_sub", SqlDbType.Decimal)).Value = objNotaProveedor.valorSubtotal
                dbCommand.Parameters.Add(New SqlParameter("@detalleNotaProveedor", SqlDbType.Structured)).Value = objNotaProveedor.dtCuentas
                dbCommand.Parameters.Add(New SqlParameter("@Usuario_Creacion", SqlDbType.Int)).Value = pUSuario
                dbCommand.ExecuteNonQuery()
                FuncionesContables.aumentarConsecutivo(objNotaProveedor.codigoDocumento)
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try

    End Sub

    Public Sub actualizarNotaProveedor(ByVal objNotaProveedor As NotaProveedor, pUSuario As Integer)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_NOTA_PROVEEDOR_ACTUALIZAR"
                dbCommand.Parameters.Add(New SqlParameter("@comprobante", SqlDbType.NVarChar)).Value = objNotaProveedor.identificador
                dbCommand.Parameters.Add(New SqlParameter("@Fecha_Recibo", SqlDbType.Date)).Value = objNotaProveedor.fechaRecibo
                dbCommand.Parameters.Add(New SqlParameter("@Observacion", SqlDbType.NVarChar)).Value = objNotaProveedor.detalleMov
                dbCommand.Parameters.Add(New SqlParameter("@valor_debito", SqlDbType.Decimal)).Value = objNotaProveedor.valorDebito
                dbCommand.Parameters.Add(New SqlParameter("@valor_credito", SqlDbType.Decimal)).Value = objNotaProveedor.valorCredito
                dbCommand.Parameters.Add(New SqlParameter("@detalleNotaProveedor", SqlDbType.Structured)).Value = objNotaProveedor.dtCuentas
                dbCommand.Parameters.Add(New SqlParameter("@Usuario_Creacion", SqlDbType.Int)).Value = pUSuario
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
