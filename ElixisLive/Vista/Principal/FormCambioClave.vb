Public Class FormCambioClave
    Dim objClave As New CambioClave
    Private Sub FormCambiarClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If SesionActual.idUsuario = 0 Then
        'txtContraseña.ReadOnly = True
        '    txtClaveNueva.ReadOnly = True
        '    txtConfirmarClave.ReadOnly = True
        '    btRegistrar.Enabled = False
        '    Exit Sub
        'End If
        txtUsuario.Text = SesionActual.usuario
        Generales.tabularConEnter(Me)
    End Sub

    Private Sub txtContraseña_Leave(sender As Object, e As EventArgs) Handles txtContraseña.Leave
        objClave.claveActual = txtContraseña.Text
        If String.IsNullOrEmpty(objClave.claveActual) Then Exit Sub
        If Not objClave.verificarClave() Then
            ErrorIcono.SetError(txtContraseña, "Clave incorrecta")
            txtContraseña.Focus()
            txtContraseña.ResetText()
        Else
            ErrorIcono.SetError(txtContraseña, "")
            txtContraseña.ReadOnly = True
        End If
    End Sub

    Private Sub FormCambiarClave_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub txtClaveNueva_Leave(sender As Object, e As EventArgs) Handles txtClaveNueva.Leave
        If String.IsNullOrEmpty(txtClaveNueva.Text) Then Exit Sub
        If txtClaveNueva.Text = txtContraseña.Text Then
            ErrorIcono.SetError(txtClaveNueva, "la clave no puede ser igual a la actual")
            txtClaveNueva.ResetText()
            txtClaveNueva.Focus()
        ElseIf txtClaveNueva.Text = "" Then
            ErrorIcono.SetError(txtClaveNueva, "Digite una nueva clave")
            txtClaveNueva.Focus()
        ElseIf (txtClaveNueva.Text.Length < 4 Or txtClaveNueva.Text.Length > 15) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Por favor digite una clave de usuario válida (entre 6-15 caracteres)!")
            txtClaveNueva.Focus()
        Else
            ErrorIcono.SetError(txtClaveNueva, "")
            ErrorIcono.SetError(txtClaveNueva, "")
        End If
    End Sub
    Public Function validarControles()
        objClave.claveActual = txtContraseña.Text
        If Not objClave.verificarClave Then
            ErrorIcono.SetError(txtContraseña, "Clave incorrecta")
            txtContraseña.ResetText()
            txtContraseña.Focus()
        ElseIf String.IsNullOrEmpty(txtConfirmarClave.Text) Then
            ErrorIcono.SetError(txtConfirmarClave, "Confirme su clave")
            txtConfirmarClave.Focus()
        ElseIf txtConfirmarClave.Text <> txtClaveNueva.Text Then
            txtConfirmarClave.ResetText()
            ErrorIcono.SetError(txtConfirmarClave, "La clave no coincide")
            txtConfirmarClave.Focus()
        ElseIf String.IsNullOrEmpty(txtClaveNueva.Text) Then
            ErrorIcono.SetError(txtClaveNueva, "Digite una clave nueva")
            txtClaveNueva.Focus()
        Else
            ErrorIcono.SetError(txtClaveNueva, "")
            ErrorIcono.SetError(txtContraseña, "")
            ErrorIcono.SetError(txtConfirmarClave, "")
            Return True
        End If
        Return False
    End Function

    Public Sub guardar()
        Try
            objClave.nombreUsuario = txtUsuario.Text
            objClave.confirmarClave = txtConfirmarClave.Text
            objClave.guardarClave()
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            txtContraseña.Focus()
            txtContraseña.ReadOnly = False
            txtContraseña.Clear()
            txtClaveNueva.Clear()
            txtConfirmarClave.Clear()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarControles() Then
            guardar()
        End If
    End Sub

End Class