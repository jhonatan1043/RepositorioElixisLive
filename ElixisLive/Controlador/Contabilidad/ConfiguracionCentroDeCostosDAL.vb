Imports System.Data.SqlClient
Public Class ConfiguracionCentroDeCostosDAL
    Public Sub crearConfiguracion(ByVal objCentroCosto As ConfiguracionCentroDeCostos)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_CONFIGURACION_CENTROS_COSTO_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@CentroCostos", SqlDbType.Structured)).Value = objCentroCosto.dtCuentas
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
