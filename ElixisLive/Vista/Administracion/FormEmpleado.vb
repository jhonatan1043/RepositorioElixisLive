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
        objEmpleado = New Empleado
        Try
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            combosIniciales()
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarParametros()
        Dim params As New List(Of String)
        If dgvParametro.ColumnCount <> 0 Then
            params.Add(ElementoMenu.codigo)
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoDGV(dgvParametro)
            Generales.diseñoGrillaParametros(dgvParametro)
        End If
    End Sub
    Private Sub combosIniciales()
        EmpleadoBLL.cargarComboFormaPago(cbFormaPago)
        EmpleadoBLL.cargarComboCuenta(cbTipoCuenta)
        Generales.cargarCombo("[SP_CONSULTAR_PERFIL]", Nothing, "Nombre", "Codigo", cbPerfil)
        Generales.cargarCombo("[SP_CONSULTAR_BANCO]", Nothing, "Nombre", "Codigo_Banco", cbBanco)
        Generales.cargarCombo("[SP_CONSULTAR_CARGO]", Nothing, "Nombre", "Codigo", cbCargo)
        Generales.cargarCombo("[SP_CONSULTAR_DEPARTAMENTO_TRABAJO]", Nothing, "Nombre", "Codigo", cbDepartamento)
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
                cbCargo.SelectedValue = dfila("Codigo_Cargo")
                cbDepartamento.SelectedValue = dfila("Codigo_deaprt")
                cbFormaPago.SelectedValue = dfila("codigo_Banco")
                cbBanco.SelectedValue = If(String.IsNullOrEmpty(dfila("codigo_Banco")), -1, dfila("codigo_Banco"))
                cbTipoCuenta.SelectedValue = If(String.IsNullOrEmpty(dfila("Tipo_Cuenta_Banco")), -1, dfila("Tipo_Cuenta_Banco"))
                txtCuenta.Text = If(cbFormaPago.SelectedIndex = 1, String.Empty, dfila("Numero_Cuenta"))
                crearImagen(If(IsDBNull(dfila("Foto")), Nothing, dfila("Foto")))
                params.Add(ElementoMenu.codigo)
                Generales.llenardgv(objEmpleado.sqlCargarDetalle, dgvParametro, params)
                Generales.diseñoDGV(dgvParametro)
                Generales.diseñoGrillaParametros(dgvParametro)
                controlVerificar()
            End If
            Generales.habilitarBotones(ToolStrip1)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
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
        txtUsuario.Text = dfila("Usuario")
        cbPerfil.SelectedValue = If(String.IsNullOrEmpty(dfila("Codigo_Perfil")), -1, dfila("Codigo_Perfil"))
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
        Generales.deshabilitarControles(gpUsuario)
        Generales.limpiarControles(Me)
        cargarParametros()
        objEmpleado.codigo = Nothing
        btBuscarPersona.Enabled = True
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If IsNothing(objEmpleado.codigo) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe Seleccionar una persona!")
        ElseIf cbFormaPago.SelectedIndex = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe seleccionar una forma de pago!")
        ElseIf cbCargo.SelectedIndex = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe Seleccionar un cargo!")
        ElseIf cbDepartamento.SelectedIndex = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe Seleccionar un departamento de trabajo!")
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
        objEmpleado.codigoBanco = cbBanco.SelectedValue.ToString
        objEmpleado.codigoCuenta = cbTipoCuenta.SelectedValue.ToString
        objEmpleado.Cuenta = txtCuenta.Text
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
            Generales.deshabilitarControles(gpUsuario)
            btBuscarPersona.Enabled = False
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

    Private Sub dgvParametro_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles dgvParametro.Validating
        Dim dt As DataTable = DirectCast(ErrorIcono.DataSource, DataTable)
        If CBool(dgvParametro.Rows(dgvParametro.CurrentCell.RowIndex).Cells(1).Value) = True Then
            dt.Rows(dgvParametro.CurrentCell.RowIndex).SetColumnError(1, "Este campo es obligatorio")
        End If
    End Sub
    Private Sub cbFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFormaPago.SelectedIndexChanged
        validarFormaPago()
    End Sub
    Private Sub validarFormaPago()
        If cbFormaPago.SelectedIndex = 1 Then
            gpPago.Enabled = False
            Generales.limpiarControles(gpPago)
        Else
            gpPago.Enabled = True
        End If
    End Sub
    Private Sub listaSucursales(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim tabla As New DataTable
        params.Add(pcodigo)
        Generales.llenarTabla("[SP_ADMIN_EMPLEADO_SUCURSALES]", params, tabla)
    End Sub
End Class