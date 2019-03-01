Imports System.Data.SqlClient

Public Class PucDAL
    Dim conexion As New ConexionBD
    Public Sub crearPUC(objPUC As Puc, pUsuario As Integer)

        Dim codigoPUC As String = Nothing

        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_PUC_CREAR"

                dbCommand.Parameters.Add(New SqlParameter("@ano", SqlDbType.Int)).Value = objPUC.ano
                dbCommand.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar)).Value = objPUC.descripcion
                dbCommand.Parameters.Add(New SqlParameter("@activo", SqlDbType.Bit)).Value = objPUC.activo
                dbCommand.Parameters.Add(New SqlParameter("@Usuario_creacion", SqlDbType.Int)).Value = pUsuario
                objPUC.codigo = CType(dbCommand.ExecuteScalar, String)

            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try

    End Sub

    Public Sub actualizarPUC(objPUC As Puc, pUsuario As Integer)

        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_PUC_ACTUALIZAR"
                'Parametros
                dbCommand.Parameters.Add(New SqlParameter("@codigo_puc", SqlDbType.Int)).Value = objPUC.codigo
                dbCommand.Parameters.Add(New SqlParameter("@ano", SqlDbType.Int)).Value = objPUC.ano
                dbCommand.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.NVarChar)).Value = objPUC.descripcion
                dbCommand.Parameters.Add(New SqlParameter("@activo", SqlDbType.Bit)).Value = objPUC.activo
                dbCommand.Parameters.Add(New SqlParameter("@Usuario_actualizacion", SqlDbType.Int)).Value = pUsuario
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try

    End Sub

End Class
