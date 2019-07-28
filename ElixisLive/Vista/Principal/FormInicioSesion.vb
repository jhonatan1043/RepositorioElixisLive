Imports System.ComponentModel
Public Class FormInicioSesion
    Dim formulario As New vForm
    Dim objInicioSesionBLL As New InicioSesionBLL
    Property respuesta As Boolean
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If validarCampos() = True Then
            cargarObjeto()
            If objInicioSesionBLL.inicioSesionCargar() = True Then
                Hide()
            End If
        Else
            EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.VALIDAR_CAMPOS)
        End If
    End Sub
    Private Sub cargarEmpresa()
        Dim params As New List(Of String)
        Dim dfila As DataRow
        Dim formEmpresa As FormEmpresa
        params.Add(Constantes.CADENA_VACIA)
        dfila = Generales.cargarItem(Sentencias.EMPRESA_CONSULTAR, params)
        Try
            If IsNothing(dfila) Then
                respuesta = True
                formEmpresa = New FormEmpresa
                formEmpresa.inicioSesion = Me
                formEmpresa.ShowDialog()
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Function validarCampos() As Boolean
        If String.IsNullOrEmpty(txtUsuario.Text) Or String.IsNullOrEmpty(txtContraseña.Text) Or CbEmpresa.SelectedIndex > 0 Then
            Return True
        End If
        Return False
    End Function
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Generales.desvanecerForm(Me)
        Me.Close()
    End Sub
    Private Sub cargarObjeto()
        objInicioSesionBLL.usuario = txtUsuario.Text
        objInicioSesionBLL.contrasena = txtContraseña.Text
        objInicioSesionBLL.codigoSucursal = CbEmpresa.SelectedValue
    End Sub
    Private Sub TxtUsuario_Validating(sender As Object, e As EventArgs) Handles txtUsuario.LostFocus
        If DirectCast(sender, TextBox).Text.Length = 0 Then
            Me.ErrorIcono.SetError(txtUsuario, "Debe Ingresar el usuario")
        Else
            Me.ErrorIcono.SetError(txtUsuario, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub TxtContraseña_Validating(sender As Object, e As EventArgs) Handles txtContraseña.LostFocus
        If DirectCast(sender, TextBox).Text.Length = 0 Then
            Me.ErrorIcono.SetError(sender, "Debe ingresar la contraseña")
        Else
            Me.ErrorIcono.SetError(sender, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub CbEmpresa_Validating(sender As Object, e As EventArgs) Handles CbEmpresa.LostFocus
        If DirectCast(sender, ComboBox).SelectedIndex = 0 Then
            Me.ErrorIcono.SetError(sender, "Debe Escoger la empresa")
        Else
            Me.ErrorIcono.SetError(sender, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub FormInicioSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarEmpresa()
        If respuesta = False Then
            cargarComboEmpresa()
            formulario.ventana = Me '' se indica el formulario que usara el efecto
            formulario.redondear() '' se redondean los bordes del formulario
        Else
            Close()
        End If
        Generales.tabularConEnter(Me)
        txtUsuario.Focus()
    End Sub
    Private Function cargarComboEmpresa() As Boolean
        Dim params As New List(Of String)
        Dim resultado As Boolean
        Try
            params.Add(txtUsuario.Text)
            resultado = Generales.cargarCombo(Sentencias.SUCURSALES_CONSULTAR, params, "Nombre", "codigo", CbEmpresa)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
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
        EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.USUARIO_NO_EXISTE)
        Generales.limpiarControles(Me)
        txtUsuario.Focus()
    End Sub
End Class



