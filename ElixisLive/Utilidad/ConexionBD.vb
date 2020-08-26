Imports System.Data.SqlClient
Public Class ConexionBD
    Public Property cnxbd As New SqlConnection

    Public Sub conectar()
        Try
            cnxbd.ConnectionString = "Server=xandarDB.mssql.somee.com;User=poseidon_SQLLogin_1;Password=ke5a7fa57r;Database=xandarDB"
            cnxbd.Open()
        Catch ex As SqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    'Public Sub conectar()
    '    Try
    '        cnxbd.ConnectionString = "Server=xandarDB.mssql.somee.com;Initial Catalog=softbd;integrated security=true"
    '        cnxbd.Open()
    '    Catch ex As SqlException
    '        EstiloMensajes.mostrarMensajeError(ex.Message)
    '    End Try
    'End Sub
    Public Sub desconectar()
        cnxbd.Close()
    End Sub
End Class
