Imports System.Data.SqlClient
Public Class ConfiguracionConceptosDianDAL
    Public Sub crearConfiguracion(ByVal objConceptoDian As ConfiguracionConceptosDian)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CONFIGURACION_CONCEPTOS_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@codigoConcepto", SqlDbType.NVarChar)).Value = objConceptoDian.codigoConcepto
                dbCommand.Parameters.Add(New SqlParameter("@Conceptos", SqlDbType.Structured)).Value = objConceptoDian.dtCuentas
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
