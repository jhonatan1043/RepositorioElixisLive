Imports System.Data.SqlClient
Public Class ConexionBD
    Public Property cnxbd As New SqlConnection

    'Public Sub conectar()
    '    Try
    '        cnxbd.ConnectionString = "Server=LocalHost;User=" & Constantes.USUARIOBD & ";Password=" & Constantes.CONTRASENABD & ";Database=softbd"
    '        cnxbd.Open()
    '    Catch ex As SqlException
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Public Sub conectar()
        Try
            cnxbd.ConnectionString = "Server=DESKTOP-DAPP7UA\SISTEMA;Initial Catalog=softbd;integrated security=true"
            cnxbd.Open()
        Catch ex As SqlException
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub desconectar()
        cnxbd.Close()
    End Sub
End Class
