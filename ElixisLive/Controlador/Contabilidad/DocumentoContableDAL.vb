Imports System.Data.SqlClient

Public Class DocumentoContableDAL
    Dim conexion As New ConexionBD
    Public Sub crearDocumentoContable(objDocumentoContable As DocumentoContable, pUsuario As Integer)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_DOCUMENTO_CONTABLE_CREAR"

                dbCommand.Parameters.Add(New SqlParameter("@sigla", SqlDbType.NVarChar)).Value = objDocumentoContable.sigla
                dbCommand.Parameters.Add(New SqlParameter("@descripcion_documento", SqlDbType.NVarChar)).Value = objDocumentoContable.descripcion
                dbCommand.Parameters.Add(New SqlParameter("@usuario", SqlDbType.Int)).Value = pUsuario

                objDocumentoContable.codigo = CType(dbCommand.ExecuteScalar, String)
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try

    End Sub

    Public Sub actualizarDocumentoContable(objDocumentoContable As DocumentoContable, pUsuario As Integer)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_DOCUMENTO_CONTABLE_ACTUALIZAR"
                dbCommand.Parameters.Add(New SqlParameter("@codigo_documento", SqlDbType.Int)).Value = objDocumentoContable.codigo
                dbCommand.Parameters.Add(New SqlParameter("@sigla", SqlDbType.NVarChar)).Value = objDocumentoContable.sigla
                dbCommand.Parameters.Add(New SqlParameter("@descripcion_documento", SqlDbType.NVarChar)).Value = objDocumentoContable.descripcion
                dbCommand.Parameters.Add(New SqlParameter("@usuario", SqlDbType.Int)).Value = pUsuario
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try

    End Sub

End Class
