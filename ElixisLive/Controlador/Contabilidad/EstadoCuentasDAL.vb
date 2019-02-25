Imports System.Data.SqlClient

Public Class EstadoCuentasDAL
    Public Sub crearEstadoCuentas(ByVal objEstadoCuentas As EstadoDeCuentas)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_ESTADO_CUENTAS_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@EstadoCuentas", SqlDbType.Structured)).Value = objEstadoCuentas.dtCuentas
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
