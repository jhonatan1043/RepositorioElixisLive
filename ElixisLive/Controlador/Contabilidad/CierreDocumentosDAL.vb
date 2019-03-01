Imports System.Data.SqlClient

Public Class CierreDocumentosDAL
    Dim conexion As New ConexionBD
    Public Sub crearCierreDocumento(ByVal objCierreDocumento As CierreDocumentos, pUSuario As Integer)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CIERRE_DOCUMENTOS_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@Comprobante", SqlDbType.NVarChar)).Value = objCierreDocumento.comprobante
                dbCommand.Parameters.Add(New SqlParameter("@Fecha_Inicio", SqlDbType.Date)).Value = objCierreDocumento.fechaInicio
                dbCommand.Parameters.Add(New SqlParameter("@Fecha_Fin", SqlDbType.Date)).Value = objCierreDocumento.fechaFin
                dbCommand.Parameters.Add(New SqlParameter("@valor_debito", SqlDbType.Decimal)).Value = objCierreDocumento.valorDebito
                dbCommand.Parameters.Add(New SqlParameter("@valor_credito", SqlDbType.Decimal)).Value = objCierreDocumento.valorCredito
                dbCommand.Parameters.Add(New SqlParameter("@detalle_carteracxp", SqlDbType.Structured)).Value = objCierreDocumento.dtCierre
                dbCommand.Parameters.Add(New SqlParameter("@Usuario_Creacion", SqlDbType.Int)).Value = pUSuario
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try

    End Sub

    Public Sub actualizarCierreDocumento(ByVal objCierreDocumento As CierreDocumentos, pUSuario As Integer)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CIERRE_DOCUMENTOS_ACTUALIZAR"
                dbCommand.Parameters.Add(New SqlParameter("@comprobante", SqlDbType.NVarChar)).Value = objCierreDocumento.comprobante
                dbCommand.Parameters.Add(New SqlParameter("@detalle_carteracxp", SqlDbType.Structured)).Value = objCierreDocumento.dtCierre
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
