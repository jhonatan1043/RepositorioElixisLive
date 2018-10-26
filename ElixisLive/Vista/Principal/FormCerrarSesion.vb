Imports System.Threading

Public Class FormCerrarSesion
    Dim formulario As New vForm
    Private Sub PicCerrarSesion_Click(sender As Object, e As EventArgs) Handles PicCerrarSesion.Click
        Generales.desvanecer(Me)
        FormPrincipal.Close()
        FormInicioSesion.Show()
        FormInicioSesion.txtContraseña.Clear()
        FormInicioSesion.txtContraseña.Focus()
    End Sub

    Private Sub PicSalir_Click(sender As Object, e As EventArgs) Handles PicSalir.Click
        Generales.desvanecer(Me)
        FormInicioSesion.Close()
    End Sub

    Private Sub PicRegresar_Click(sender As Object, e As EventArgs) Handles PicRegresar.Click
        Generales.desvanecer(Me)
        Me.Close()
    End Sub
    Private Sub FormCerrarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 100
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 750
        y = Screen.PrimaryScreen.WorkingArea.Height - 450
        Me.Location = New Point(x, y)
        formulario.ventana = Me '' se indica el formulario que usara el efecto
        formulario.redondear() '' se redondean los bordes del formulario
    End Sub
End Class