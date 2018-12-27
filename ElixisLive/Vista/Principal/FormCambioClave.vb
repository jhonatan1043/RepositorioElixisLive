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
        txtUsuario.Text = "admin"
        Generales.tabularConEnter(Me)
    End Sub

    Private Sub txtContraseña_Leave(sender As Object, e As EventArgs) Handles txtContraseña.Leave
        objClave.claveActual = txtContraseña.Text
        If String.IsNullOrEmpty(objClave.claveActual) Then Exit Sub
        If Not objClave.verificarClave() Then
            ErrorIcono.SetError(txtContraseña, "Clave incorrecta")
            txtContraseña.Focus()
            erroractual.Visible = True
            erroractual.Image = My.Resources.rojo
            txtContraseña.ResetText()
        Else
            ErrorIcono.SetError(txtContraseña, "")
            erroractual.Visible = True
            erroractual.Image = My.Resources.verde
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
            nuevo.Visible = True
            nuevo.Image = My.Resources.rojo
        ElseIf txtClaveNueva.Text = "" Then
            ErrorIcono.SetError(txtClaveNueva, "Digite una nueva clave")
            txtClaveNueva.Focus()
            nuevo.Visible = True
        ElseIf (txtClaveNueva.Text.Length < 4 Or txtClaveNueva.Text.Length > 15) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Por favor digite una clave de usuario válida (entre 6-15 caracteres)!")
            nuevo.Visible = True
            txtClaveNueva.Focus()
        Else
            ErrorIcono.SetError(txtClaveNueva, "")
            ErrorIcono.SetError(txtClaveNueva, "")
            nuevo.Visible = True
            nuevo.Image = My.Resources.verde
        End If
    End Sub
    Public Function validarControles()
        objClave.claveActual = txtContraseña.Text
        If Not objClave.verificarClave Then
            erroractual.Visible = True
            erroractual.Image = My.Resources.rojo
            txtContraseña.ResetText()
            txtContraseña.Focus()
        ElseIf String.IsNullOrEmpty(txtConfirmarClave.Text) Then
            MsgBox("Confirme su clave", MsgBoxStyle.Exclamation)
            txtConfirmarClave.Focus()
        ElseIf txtConfirmarClave.Text <> txtClaveNueva.Text Then
            MsgBox("La clave no coincide", MsgBoxStyle.Exclamation)
            txtConfirmarClave.ResetText()
            confirmar.Visible = True
            txtConfirmarClave.Focus()
        ElseIf String.IsNullOrEmpty(txtClaveNueva.Text) Then
            MsgBox("Digite una clave nueva", MsgBoxStyle.Exclamation)
            txtClaveNueva.Focus()
        Else
            confirmar.Image = My.Resources.verde
            confirmar.Visible = True
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
            nuevo.Visible = False
            confirmar.Visible = False
            erroractual.Visible = False
            txtContraseña.Clear()
            txtClaveNueva.Clear()
            erroractual.Visible = False
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

    Private Sub txtClaveNueva_TextChanged(sender As Object, e As EventArgs) Handles txtClaveNueva.TextChanged
        If txtClaveNueva.Text = "" Then
            nuevo.Visible = False
        End If
    End Sub

End Class