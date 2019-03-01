Imports System.Data.SqlClient

Public Class BalanceComprobacionDAL

    Public Sub calcularBalanceComprobacion(params As BalanceComprobacionParams)
        Dim objConexio As New ConexionBD
        objConexio.conectar()
        Try
            Using dbCommand As New SqlCommand
                dbCommand.Connection = objConexio.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_E_BALANCE_COMPROBACION_CARGAR"

                dbCommand.Parameters.Add(New SqlParameter("@detalle", SqlDbType.Bit)).Value = params.detalle
                dbCommand.Parameters.Add(New SqlParameter("@clasificacion", SqlDbType.NChar)).Value = IIf(params.clasificacion = Nothing,
                                                                                                       DBNull.Value,
                                                                                                       params.clasificacion)
                dbCommand.Parameters.Add(New SqlParameter("@fecha_inicio", SqlDbType.DateTime)).Value = params.fechaInicio
                dbCommand.Parameters.Add(New SqlParameter("@fecha_fin", SqlDbType.DateTime)).Value = params.fechaFin
                dbCommand.Parameters.Add(New SqlParameter("@resultado", SqlDbType.Bit))
                dbCommand.Parameters("@resultado").Direction = ParameterDirection.Output

                dbCommand.ExecuteNonQuery()
                params.resultado = dbCommand.Parameters("@resultado").Value

            End Using
            objConexio.desconectar()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

End Class
