Imports System.Data.SqlClient
Public Class ClienteDAL
    Public Shared Function guardar(objCliente As Cliente) As Cliente
        Dim objConexio As New  ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                comando.Connection = objConexio.cnxbd
                comando.CommandType = CommandType.StoredProcedure
                comando.Parameters.Clear()
                comando.CommandText = objCliente.sqlGuardar
                comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objCliente.dtCliente
                comando.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desconectar()
        End Try
        Return objCliente
    End Function
End Class
