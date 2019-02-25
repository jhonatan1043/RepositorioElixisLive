Imports System.Data.SqlClient
Public Class ProgramacionPagoNominaDAL
    Public Sub crearProgramacionPagoNomina(ByVal objProgramacionPagoNomina As ProgramacionPagoNomina)
        Dim conexion As New ConexionBD
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_PROGRAMACION_NOMINA_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@programacionNomina", SqlDbType.Structured)).Value = objProgramacionPagoNomina.dtNomina
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
