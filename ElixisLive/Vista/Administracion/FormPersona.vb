﻿Public Class FormPersona
    Dim objPersona As persona
    Private Sub cargarObjeto()
        objPersona.identificacion = TextIdentificacion.Text
        objPersona.nombre = TextNombre.Text
        objPersona.telefono = TextTelefono.Text
        objPersona.celular = TextCelular.Text
        objPersona.correo = TextEmail.Text
        objPersona.direccion = TextDireccion.Text
        objPersona.codigoCiudad = ComboMunicipio.SelectedValue
        objPersona.codigoTipoIdentificacion = CombotipoIdentificacion.SelectedValue
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(TextIdentificacion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar la identificación de la persona!")
        ElseIf CombotipoIdentificacion.SelectedIndex = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe seleccionar el tipo de identificación!")
        ElseIf String.IsNullOrEmpty(TextNombre.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el nombre de la persona!")
        ElseIf String.IsNullOrEmpty(TextCelular.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el Numero de celular de la persona!")
        ElseIf String.IsNullOrEmpty(ComboMunicipio.SelectedIndex) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe seleccionar la ciudad de la persona!")
        ElseIf String.IsNullOrEmpty(TextDireccion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar la dirección de la persona!")
        Else
            resultado = True
        End If
        Return resultado
    End Function
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
            Generales.cargarCombo("[SP_CONSULTAR_CIUDAD]", Nothing, "descripcion", "Codigo_Municipio", ComboMunicipio)
            Generales.cargarCombo("[SP_CONSULTAR_TIPO_IDENT]", Nothing, "Nombre", "Codigo", CombotipoIdentificacion)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        objPersona.codigo = Nothing
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarCampos() = True Then
            Try
                cargarObjeto()
                PersonaBLL.guardar(objPersona)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btRegistrar.Enabled = False
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
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
            btNuevo.Enabled = True
            btBuscar.Enabled = True
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
        params.Add(SesionActual.codigoSucursal)
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
                ComboMunicipio.SelectedValue = dfila("Ciudad")
            End If
            Generales.habilitarBotones(ToolStrip1)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FormPerfil.MdiParent = FormPrincipal
        FormPerfil.Show()
        FormPerfil.Focus()
        If FormPerfil.WindowState = FormWindowState.Minimized Then
            FormPerfil.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class