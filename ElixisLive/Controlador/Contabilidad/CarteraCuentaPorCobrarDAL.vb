Imports System.Data.SqlClient
Public Class CarteraCuentaPorCobrarDAL
    Dim conexion As New ConexionBD
    Public Sub crearCarteraCXC(ByVal objCarteraCXC As CarteraCXC)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CARTERA_CXC_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@CarteraCXP", SqlDbType.Structured)).Value = objCarteraCXC.dtCarteraP
                dbCommand.Parameters.Add(New SqlParameter("@detalle_CarteraCXP", SqlDbType.Structured)).Value = objCarteraCXC.dtCartera
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            conexion.desconectar()
        End Try

    End Sub

    Public Sub actualizarCarteraCXC(ByVal objCarteraCXC As CarteraCXC)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CARTERA_CXC_ACTUALIZAR"
                dbCommand.Parameters.Add(New SqlParameter("@comprobante", SqlDbType.NVarChar)).Value = objCarteraCXC.identificador
                dbCommand.Parameters.Add(New SqlParameter("@detalle_CarteraCXP", SqlDbType.Structured)).Value = objCarteraCXC.dtCartera
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
