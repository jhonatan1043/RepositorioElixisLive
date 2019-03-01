Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class RetiroDocumentoContaDAL

    Public Shared Sub guardarDocumento(objDocumento As RetiroDocumento)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using comando = New SqlCommand
                comando.CommandType = CommandType.StoredProcedure
                comando.Connection = conexion.cnxbd
                comando.CommandText = "SP_RETIRO_DOCUMENTO_GUARDAR_ANULADO"
                comando.Parameters.Add(New SqlParameter("@observacion", SqlDbType.NVarChar)).Value = objDocumento.observacion
                comando.Parameters.Add(New SqlParameter("@comprobante", SqlDbType.NVarChar)).Value = objDocumento.comprobante
                comando.Parameters.Add(New SqlParameter("@usuario", SqlDbType.Int)).Value = objDocumento.usuario
                comando.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try
    End Sub

End Class
