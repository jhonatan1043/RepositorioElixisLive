Public Class FormCerrarSesion
    Dim formulario As New vForm
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        formulario.ventana = Me '' se indica el formulario que usara el efecto
        formulario.redondear() '' se redondean los bordes del formulario

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                Handles MyBase.MouseMove '' aca puedes agregar mas controles que quieras usar para mover el formulario ej: label1.MouseMove

        If e.Button = MouseButtons.Left Then
            formulario.moverForm() '' se llama la función que da el efecto
        End If

    End Sub
End Class