Imports System.Data.SqlClient
Public Class CarteraCuentaPorPagarDAL
    Dim conexion As New ConexionBD
    Public Sub crearCarteraCXP(ByVal objcarteraCXP As CarteraCXP)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CARTERA_CXP_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@carteracxp", SqlDbType.Structured)).Value = objcarteraCXP.dtCarteraP
                dbCommand.Parameters.Add(New SqlParameter("@detalle_carteracxp", SqlDbType.Structured)).Value = objcarteraCXP.dtCartera
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try

    End Sub

    Public Sub actualizarCarteraCXP(ByVal objcarteraCXP As CarteraCXP)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CARTERA_CXP_ACTUALIZAR"
                dbCommand.Parameters.Add(New SqlParameter("@comprobante", SqlDbType.NVarChar)).Value = objcarteraCXP.identificador
                dbCommand.Parameters.Add(New SqlParameter("@detalle_carteracxp", SqlDbType.Structured)).Value = objcarteraCXP.dtCartera
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
