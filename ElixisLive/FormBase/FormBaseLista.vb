Public Class FormBaseLista
    Private Sub Label1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        If btRegistrar.Enabled = True Then
            Close()
        End If
    End Sub

    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class