Imports System.Data.SqlClient
Public Class CostoServicioDAL
    Public Shared Function guardarCostoServicio(objCostoServicio As CostoServicio) As CostoServicio
        Dim objConexio As New  ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                comando.Connection = objConexio.cnxbd
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Clear()
                comando.CommandText = objCostoServicio.sqlGuardar
                comando.Parameters.Add(New SqlParameter("@CodigoServicio", SqlDbType.NVarChar)).Value = objCostoServicio.codigoServicio
                comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objCostoServicio.dtRegistro
                comando.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            objConexio.desconectar()
        End Try
        Return objCostoServicio
    End Function
End Class
