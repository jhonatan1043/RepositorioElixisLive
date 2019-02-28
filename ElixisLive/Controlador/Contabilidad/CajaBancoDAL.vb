Imports System.Data.SqlClient
Public Class CajaBancoDAL
    Public Function crearCajaBanco(ByVal objcajaBanco As CajaBanco, pUSuario As Integer) As String
        Dim objConexio As New ConexionBD
        objConexio.conectar()
        Try
            Using dbCommand As New SqlCommand
                objcajaBanco.comprobante = FuncionesContables.verificarConsecutivo(objcajaBanco.codigoDocumento)
                dbCommand.Connection = objConexio.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CAJA_BANCO_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@Comprobante", SqlDbType.NVarChar)).Value = objcajaBanco.comprobante
                dbCommand.Parameters.Add(New SqlParameter("@id_tercero", SqlDbType.Int)).Value = objcajaBanco.idTercero
                dbCommand.Parameters.Add(New SqlParameter("@Fecha_Recibo", SqlDbType.Date)).Value = objcajaBanco.fechaRecibo
                dbCommand.Parameters.Add(New SqlParameter("@detalle_mov", SqlDbType.NVarChar)).Value = objcajaBanco.detalleMov
                dbCommand.Parameters.Add(New SqlParameter("@detalle_cajaBanco", SqlDbType.Structured)).Value = objcajaBanco.dtCuentas
                dbCommand.Parameters.Add(New SqlParameter("@Usuario_Creacion", SqlDbType.Int)).Value = pUSuario
                objcajaBanco.comprobante = CType(dbCommand.ExecuteScalar, String)
                FuncionesContables.aumentarConsecutivo(objcajaBanco.codigoDocumento)
            End Using
            objConexio.desconectar()
        Catch ex As Exception
            Throw ex
        End Try
        Return objcajaBanco.comprobante
    End Function

    Public Sub actualizarCajaBanco(ByVal objcajaBanco As CajaBanco, pUSuario As Integer)
        Dim objConexio As New ConexionBD
        objConexio.conectar()
        Try
            Using dbCommand As New SqlCommand
                dbCommand.Connection = objConexio.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CAJA_BANCO_ACTUALIZAR"
                dbCommand.Parameters.Add(New SqlParameter("@Comprobante", SqlDbType.NVarChar)).Value = objcajaBanco.comprobante
                dbCommand.Parameters.Add(New SqlParameter("@Fecha_Recibo", SqlDbType.Date)).Value = objcajaBanco.fechaRecibo
                dbCommand.Parameters.Add(New SqlParameter("@detalle_mov", SqlDbType.NVarChar)).Value = objcajaBanco.detalleMov
                dbCommand.Parameters.Add(New SqlParameter("@detalle_cajaBanco", SqlDbType.Structured)).Value = objcajaBanco.dtCuentas
                dbCommand.Parameters.Add(New SqlParameter("@Usuario_Actualizacion", SqlDbType.Int)).Value = pUSuario
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

End Class
