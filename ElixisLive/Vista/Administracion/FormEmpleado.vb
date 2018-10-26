﻿Public Class FormEmpleado
    Dim objEmpleado As Empleado
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objEmpleado = New Empleado
        Try
            params.Add(ElementoMenu.codigo)
            params.Add(SesionActual.idEmpresa)
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoDGV(dgvParametro)
            Generales.diseñoGrillaParametros(dgvParametro)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.cargarCombo("[SP_CONSULTAR_PERFIL]", Nothing, "Nombre", "codigo_Perfil", cbPerfil)
            Generales.cargarCombo("[SP_CONSULTAR_BANCO]", Nothing, "Nombre", "Codigo_Banco", cbBanco)
            Generales.cargarCombo("[SP_CONSULTAR_TIPO_CUENTA]", Nothing, "Nombre", "Codigo_Tipo_Cuenta", cbTipoCuenta)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objEmpleado.codigo = pcodigo
        params.Add(objEmpleado.codigo)
        dfila = Generales.cargarItem(objEmpleado.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                cargarCampos(dfila)
                txtUsuario.Text = dfila("usuario")
                txtContraseña.Text = dfila("Contraseña")
                cbPerfil.SelectedValue = dfila("codigo_perfil")
                cbBanco.SelectedValue = dfila("codigo_Banco")
                cbTipoCuenta.SelectedValue = dfila("Codigo_Tipo_Cuenta")
                txtCuenta.Text = dfila("N_Cuenta")
                chbActivo.Checked = dfila("Activo")
                crearImagen(If(IsDBNull(dfila("Foto")), Nothing, dfila("Foto")))
                params.Add(ElementoMenu.codigo)
                Generales.llenardgv(objEmpleado.sqlCargarDetalle, dgvParametro, params)
                Generales.diseñoDGV(dgvParametro)
                Generales.diseñoGrillaParametros(dgvParametro)
                controlVerificar()
            End If
            Generales.habilitarBotones(ToolStrip1)
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub crearImagen(imagen As Byte())

    End Sub
    Private Sub cargarCampos(dfila As DataRow)
        txtIdentificacion.Text = dfila("Identificacion")
        txtTelefono.Text = If(IsDBNull(dfila("Telefono")), Nothing, dfila("Telefono"))
        txtCelular.Text = dfila("Celular")
        txtNombre.Text = dfila("Nombre")
        txtDireccion.Text = dfila("Direccion")
        txtEmail.Text = dfila("Email")
    End Sub
    Private Sub controlVerificar()
        For posicion = 0 To dgvParametro.Rows.Count - 1
            Generales.consultarTipoControl(dgvParametro, posicion)
        Next
    End Sub
    Private Sub dgvParametro_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametro.CellEnter
        If btRegistrar.Enabled = False Then Exit Sub
        Try
            Generales.consultarTipoControl(dgvParametro, dgvParametro.CurrentCell.RowIndex)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(SesionActual.idEmpresa)
        Try
            Generales.buscarElemento(objEmpleado.sqlConsulta,
                                   params,
                                   AddressOf cargarInfomacion,
                                   "Busqueda de Empleado",
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btBuscarPersona_Click(sender As Object, e As EventArgs) Handles btBuscarPersona.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(SesionActual.idEmpresa)
        Try
            Generales.buscarElemento("[SP_PERSONA_EMPLEADO_CONSULTAR]",
                                   params,
                                   AddressOf cargarPersona,
                                   "Busqueda de persona",
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarPersona(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objEmpleado.codigo = pCodigo
        params.Add(pCodigo)
        Try
            dfila = Generales.cargarItem("SP_PERSONA_CARGAR", params)
            cargarCampos(dfila)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.deshabilitarControles(gbInform)
        Generales.limpiarControles(Me)
        objEmpleado.codigo = Nothing
        btBuscarPersona.Enabled = True
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If IsNothing(objEmpleado.codigo) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe Seleccionar una persona!")
        ElseIf String.IsNullOrEmpty(txtUsuario.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar un usuario!")
        ElseIf String.IsNullOrEmpty(txtContraseña.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar la contraseña!")
        ElseIf cbPerfil.SelectedIndex = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe Seleccionar un perfil!")
        ElseIf cbBanco.SelectedIndex = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe Seleccionar un banco!")
        ElseIf cbTipoCuenta.SelectedIndex = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe Seleccionar un tipo de cuenta!")
        ElseIf String.IsNullOrEmpty(txtCuenta.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el numero de cuenta!")
        Else
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub cargarObjeto()
        Dim almImagen As New IO.MemoryStream
        If Not IsNothing(pictImagen.Image) Then
            pictImagen.Image.Save(almImagen, Imaging.ImageFormat.Png)
            objEmpleado.imagenEmpleado = almImagen.GetBuffer
        Else
            objEmpleado.imagenEmpleado = Nothing
        End If
        objEmpleado.usuario = txtUsuario.Text
        objEmpleado.clave = txtContraseña.Text
        objEmpleado.codigoPerfil = cbPerfil.SelectedValue.ToString
        objEmpleado.codigoBanco = cbBanco.SelectedValue.ToString
        objEmpleado.codigoCuenta = cbTipoCuenta.SelectedValue.ToString
        objEmpleado.Cuenta = txtCuenta.Text
        objEmpleado.activo = chbActivo.Checked
        objEmpleado.dtParametro = dgvParametro.DataSource
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvParametro.EndEdit()
        Try
            If validarCampos() = True Then
                cargarObjeto()
                EmpleadoBLL.guardar(objEmpleado)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btCancelar.Enabled = False
                btRegistrar.Enabled = False
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            Generales.deshabilitarControles(gbInform)
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objEmpleado.sqlAnular & objEmpleado.codigo) = True Then
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
    Private Sub pictImagen_Click(sender As Object, e As EventArgs) Handles pictImagen.Click
        If btRegistrar.Enabled = False Then Exit Sub
        Dim open As New OpenFileDialog
        Generales.subirimagen(pictImagen, open)
    End Sub

End Class