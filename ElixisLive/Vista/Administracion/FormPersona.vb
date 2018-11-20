Imports System.ComponentModel
Public Class FormPersona
    Dim objPersona As persona
    Private Sub cargarObjeto()
        objPersona.identificacion = TextIdentificacion.Text
        objPersona.nombre = TextNombre.Text
        objPersona.telefono = TextTelefono.Text
        objPersona.celular = TextCelular.Text
        objPersona.correo = TextEmail.Text
        objPersona.direccion = TextDireccion.Text
        objPersona.codigoSede = cbSede.SelectedValue
        objPersona.codigoDepartamento = cbDepartamento.SelectedValue
        objPersona.codigoCiudad = ComboMunicipio.SelectedValue
        objPersona.codigoTipoIdentificacion = CombotipoIdentificacion.SelectedValue
    End Sub
    Private Function validarCampos() As Boolean
        If String.IsNullOrEmpty(TextIdentificacion.Text) Or
                    CombotipoIdentificacion.SelectedIndex = 0 Or
                    String.IsNullOrEmpty(TextNombre.Text) Or
                    String.IsNullOrEmpty(TextCelular.Text) Or
                   cbSede.SelectedIndex = 0 Or
                   cbDepartamento.SelectedIndex = 0 Or
                   ComboMunicipio.SelectedIndex = 0 Or
                    String.IsNullOrEmpty(TextDireccion.Text) Then
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub mostrarIconoError()
        If CombotipoIdentificacion.SelectedIndex = 0 Then
            ErrorIcono.SetError(CombotipoIdentificacion, " Error")
        Else
            ErrorIcono.SetError(CombotipoIdentificacion, "")
        End If
        If TextIdentificacion.Text.Length = 0 Then
            ErrorIcono.SetError(TextIdentificacion, " Error")
        Else
            ErrorIcono.SetError(TextIdentificacion, "")
        End If
        If TextNombre.Text.Length = 0 Then
            ErrorIcono.SetError(TextNombre, " Error")
        Else
            ErrorIcono.SetError(TextNombre, "")
        End If
        If TextTelefono.Text.Length = 0 Then
            ErrorIcono.SetError(TextTelefono, " Error")
        Else
            ErrorIcono.SetError(TextTelefono, "")
        End If
        If cbSede.SelectedIndex = 0 Then
            ErrorIcono.SetError(cbSede, " Error")
        Else
            ErrorIcono.SetError(cbSede, "")
        End If
        If cbDepartamento.SelectedIndex = 0 Then
            ErrorIcono.SetError(cbDepartamento, " Error")
        Else
            ErrorIcono.SetError(cbDepartamento, "")
        End If
        If ComboMunicipio.SelectedIndex = 0 Then
            ErrorIcono.SetError(ComboMunicipio, " Error")
        Else
            ErrorIcono.SetError(ComboMunicipio, "")
        End If
        If TextDireccion.Text.Length = 0 Then
            ErrorIcono.SetError(TextDireccion, " Error")
        Else
            ErrorIcono.SetError(TextDireccion, "")
        End If
    End Sub
    Private Sub cbDepartamento_Validating(sender As Object, e As CancelEventArgs) Handles cbDepartamento.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe escoger un departamento")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub ComboMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles ComboMunicipio.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe escoger un municipio")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub cbSede_Validating(sender As Object, e As CancelEventArgs) Handles cbSede.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe escoger una sede")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub CombotipoIdentificacion_Validating(sender As Object, e As CancelEventArgs) Handles CombotipoIdentificacion.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe escoger el tipo de identificación")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub TextIdentificacion_Validating(sender As Object, e As CancelEventArgs) Handles TextIdentificacion.Validating
        If DirectCast(sender, TextBox).Text.Length = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe digitar la identificación")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub TextNombre_Validating(sender As Object, e As CancelEventArgs) Handles TextNombre.Validating
        If DirectCast(sender, TextBox).Text.Length = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe digitar el nombre de la persona")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub TextCelular_Validating(sender As Object, e As CancelEventArgs) Handles TextCelular.Validating
        If DirectCast(sender, TextBox).Text.Length = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe digitar un número de teéfono")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub TextDireccion_Validating(sender As Object, e As CancelEventArgs) Handles TextDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe digitar una dirección")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objPersona = New persona
        Try
            cargarComboDepartamento()
            cargarComboCiudad()
            Generales.cargarCombo("[SP_CONFI_SUCURSAL_CONSULTAR] ''", Nothing, "Nombre", "Código", cbSede)
            Generales.cargarCombo("[SP_CONSULTAR_TIPO_IDENT]", Nothing, "Nombre", "Codigo", CombotipoIdentificacion)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarComboDepartamento()
        Generales.cargarCombo("[SP_CONSULTAR_DEPARTAMENTO]", Nothing, "descripcion", "Codigo_Departamento", cbDepartamento)
    End Sub
    Private Sub cargarComboCiudad()
        Dim params As New List(Of String)
        If Not String.IsNullOrEmpty(cbDepartamento.ValueMember) Then
            params.Add(cbDepartamento.SelectedValue)
            Generales.cargarCombo("[SP_CONSULTAR_CIUDAD]", params, "descripcion", "Codigo_Municipio", ComboMunicipio)
        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.deshabilitarControles(GroupBox1)
        Generales.limpiarControles(Me)
        TextDV.Enabled = False
        objPersona.codigo = Nothing
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
        CombotipoIdentificacion.Focus()
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarCampos() = True Then
            Try
                cargarObjeto()
                PersonaBLL.guardar(objPersona)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btRegistrar.Enabled = False
                btCancelar.Enabled = False
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        Else
            EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.VALIDAR_CAMPOS)
        End If
        mostrarIconoError()
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            objPersona.codigo = Nothing
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            mostrarIconoError()
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objPersona.sqlAnular & objPersona.codigo) = True Then
                    Generales.limpiarControles(Me)
                    Generales.deshabilitarBotones(ToolStrip1)
                    btNuevo.Enabled = True
                    btBuscar.Enabled = True
                    EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Generales.buscarElemento(objPersona.sqlConsulta,
                                   params,
                                   AddressOf cargarInfomacion,
                                   "Busqueda de persona",
                                   True, True)
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objPersona.codigo = pcodigo
        params.Add(pcodigo)
        dfila = Generales.cargarItem(objPersona.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                TextIdentificacion.Text = dfila.Item("Identificacion")
                TextNombre.Text = dfila.Item("Nombre")
                TextTelefono.Text = If(IsDBNull(dfila("Telefono")), Nothing, dfila("Telefono"))
                TextCelular.Text = dfila("Celular")
                TextDireccion.Text = dfila("Direccion")
                TextEmail.Text = If(IsDBNull(dfila("Email")), Nothing, dfila("Email"))
                CombotipoIdentificacion.SelectedValue = dfila("Tipo_Identificacion")
                cbSede.SelectedValue = dfila("Codigo_Sucursal")
                cbDepartamento.SelectedValue = dfila("Codigo_Departamento")
                ComboMunicipio.SelectedValue = dfila("Codigo_Ciudad")
            End If
            Generales.habilitarBotones(ToolStrip1)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        cargarComboCiudad()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Generales.cargarForm(FormPerfil)
    End Sub
    Private Sub chUsuario_Click(sender As Object, e As EventArgs) Handles chUsuario.Click
        If chUsuario.Checked = True Then
            If Not String.IsNullOrWhiteSpace(TextNombre.Text) Then
                txtUsuario.ReadOnly = False
                btBuscarPerfil.Enabled = True
            Else
                EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el nombre de la persona !")
                TextNombre.Focus()
            End If
        Else
            btBuscarPerfil.Enabled = False
            txtPerfil.Clear()
            txtUsuario.Clear()
        End If
    End Sub
    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.TextChanged
        If Funciones.consultarUsuario(txtUsuario.Text) = True Then
            ErrorIcono.SetError(txtUsuario, "Usuario Existente")
        Else
            ErrorIcono.SetError(txtUsuario, "")
        End If
    End Sub
End Class