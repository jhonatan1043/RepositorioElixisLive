Imports System.Data.SqlClient
Public Class ConexionBD
    Public Property cnxbd As New SqlConnection
    Public Sub conectar()
        Try
            cnxbd.ConnectionString = "Server=LocalHost;User=AdminSoftPrueba;Password=AdminSoftPrueba;Database=softbd"
            cnxbd.Open()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub desConectar()
        cnxbd.Close()
    End Sub
End Class
