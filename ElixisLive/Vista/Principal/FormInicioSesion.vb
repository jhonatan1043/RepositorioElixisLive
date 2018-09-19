Public Class FormInicioSesion
    Dim objInicioSesionBLL As New InicioSesionBLL
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        cargarObjeto()
        If objInicioSesionBLL.inicioSesionCargar() = True Then
            Hide()
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
    Private Sub cargarObjeto()
        objInicioSesionBLL.usuario = txtUsuario.Text
        objInicioSesionBLL.contrasena = txtContraseña.Text
        objInicioSesionBLL.idEmpresa = CbEmpresa.SelectedValue
    End Sub

    Private Sub FormInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboEmpresa()
    End Sub
    Private Function cargarComboEmpresa() As Boolean
        Dim params As New List(Of String)
        Dim resultado As Boolean
        Try
            params.Add(txtUsuario.Text)
            resultado = Generales.cargarCombo("[SP_ADMIN_CONSULTAR_EMPRESA]", params, "Nombre", "codigo_empresa", CbEmpresa)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return resultado
    End Function
    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If Not String.IsNullOrEmpty(txtUsuario.Text) Then
            If cargarComboEmpresa() = False Then
                validarExistencia()
            End If
        End If
    End Sub
    Private Sub validarExistencia()
        MsgBox(MensajeSistema.USUARIO_NO_EXISTE, MsgBoxStyle.Exclamation)
        Generales.limpiarControles(Me)
        txtUsuario.Focus()
    End Sub

End Class
