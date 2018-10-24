Public Class FormCerrarSesion
    Private Sub PicCerrarSesion_Click(sender As Object, e As EventArgs) Handles PicCerrarSesion.Click
        FormPrincipal.Close()
        FormInicioSesion.Show()
        FormInicioSesion.txtContraseña.Clear()
        FormInicioSesion.txtContraseña.Focus()
    End Sub

    Private Sub PicSalir_Click(sender As Object, e As EventArgs) Handles PicSalir.Click
        Application.Exit()
    End Sub

    Private Sub PicRegresar_Click(sender As Object, e As EventArgs) Handles PicRegresar.Click
        Me.Close()
    End Sub

    Private Sub FormCerrarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 750
        y = Screen.PrimaryScreen.WorkingArea.Height - 450
        Me.Location = New Point(x, y)
    End Sub
End Class