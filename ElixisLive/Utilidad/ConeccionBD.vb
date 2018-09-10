Imports System.Data.SqlClient
Public Class ConeccionBD
    Public Shared cnxion As New SqlConnection

    Public Shared Sub conectarBD()
        Try
            cnxion.ConnectionString = "Server=LocalHost;User=AdminSoftLive;Password=AdminSoftLive;Database=softbd"
            cnxion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Shared Sub desConectarBD()
        Try
            cnxion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
