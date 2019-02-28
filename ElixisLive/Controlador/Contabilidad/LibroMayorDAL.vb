Imports System.Data.SqlClient

Public Class LibroMayorDAL
    Public Sub calcularLibroMayor(params As LibroMayorParams)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandTimeout = 60
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_E_LIBRO_MAYOR_CARGAR_PADRES"
                dbCommand.Parameters.Add(New SqlParameter("@fecha_inicio", SqlDbType.DateTime)).Value = params.fechaInicio
                dbCommand.Parameters.Add(New SqlParameter("@fecha_fin", SqlDbType.DateTime)).Value = params.fechaFin
                dbCommand.Parameters.Add(New SqlParameter("@resultado", SqlDbType.Bit))
                dbCommand.Parameters("@resultado").Direction = ParameterDirection.Output

                dbCommand.ExecuteNonQuery()
                params.resultado = dbCommand.Parameters("@resultado").Value
            End Using

        Catch ex As Exception
            Throw
        Finally
            conexion.desconectar()
        End Try
    End Sub

End Class
