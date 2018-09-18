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
    Private Sub cargarComboEmpresa()
        Dim params As New List(Of String)
        params.Add(txtUsuario.Text)
        Generales.cargarCombo("[SP_ADMIN_CONSULTAR_EMPRESA]", params, "Nombre", "codigo_empresa", CbEmpresa)
    End Sub

    Private Sub txtUsuario_Leave(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If Not String.IsNullOrEmpty(txtUsuario.Text) Then
            cargarComboEmpresa()
        Else
            Generales.limpiarControles(Me)
            MsgBox("¡ Usuario no Existete !", MsgBoxStyle.Exclamation)
        End If
    End Sub
End Class
