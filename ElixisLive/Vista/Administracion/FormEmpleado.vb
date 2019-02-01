Imports System.ComponentModel
Public Class FormEmpleado
    Dim objEmpleado As Empleado
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.cargarPermiso(Me)
        objEmpleado = New Empleado
        Try
            formatMoneda()
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            combosIniciales()
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Generales.tabularConEnter(Me)
    End Sub
    Private Sub cargarParametros()
        Dim params As New List(Of String)
        Try
            If dgvParametro.ColumnCount = 0 Then
                params.Add(ElementoMenu.codigo)
                Generales.llenardgv(Sentencias.PARAMETROS_CONSULTAR, dgvParametro, params)
                Generales.diseñoDGV(dgvParametro)
                Generales.diseñoGrillaParametros(dgvParametro)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub combosIniciales()
        EmpleadoBLL.cargarComboFormaPago(cbFormaPago)
        EmpleadoBLL.cargarComboCuenta(cbTipoCuenta)
        EmpleadoBLL.cargarComboTipoSalario(cbTipoSalario)
        Generales.cargarCombo(Sentencias.PERFIL_CONSULTAR, Nothing, "Nombre", "Codigo", cbPerfil)
        Generales.cargarCombo(Sentencias.BANCO_CONSULTAR, Nothing, "Nombre", "Codigo_Banco", cbBanco)
        Generales.cargarCombo(Sentencias.CARGO_CONSULTAR, Nothing, "Nombre", "Codigo", cbCargo)
        Generales.cargarCombo(Sentencias.DEPARTAMENTO_TRABAJO_CONSULTAR, Nothing, "Nombre", "Codigo", cbDepartamento)
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
                cbFormaPago.SelectedValue = dfila("Forma_Pago")
                cbBanco.SelectedValue = If(IsDBNull(dfila("codigo_Banco")), -1, dfila("codigo_Banco"))
                cbTipoCuenta.SelectedValue = If(String.IsNullOrEmpty(dfila("Tipo_Cuenta_Banco")), -1, dfila("Tipo_Cuenta_Banco"))
                txtCuenta.Text = If(cbFormaPago.SelectedIndex = 1, String.Empty, dfila("Numero_Cuenta"))
                cbTipoSalario.SelectedValue = dfila("Codigo_Tipo_Pagare")
                NumComision.Value = dfila("Porcentaje")
                txtSalario.Text = Format(dfila("salario"), Constantes.FORMATO_MONEDA)
                crearImagen(dfila)
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
    Private Sub crearImagen(dImagen As DataRow)
        Dim almImagen As New IO.MemoryStream
        Dim bytes() As Byte = Funciones.castFromDbItem(dImagen.Item("foto"))
        If bytes IsNot Nothing Then
            pictImagen.Image = Image.FromStream(New IO.MemoryStream(bytes))
            objEmpleado.banderaImagen = False
        Else
            pictImagen.Image = My.Resources.usuario
        End If
    End Sub
    Private Sub cargarCampos(dfila As DataRow)
        txtIdentificacion.Text = dfila("Identificacion")
        txtTelefono.Text = If(IsDBNull(dfila("Telefono")), Nothing, dfila("Telefono"))
        txtCelular.Text = dfila("Celular")
        txtNombre.Text = dfila("Nombre")
        txtDireccion.Text = If(IsDBNull(dfila("Direccion")), Nothing, dfila("Direccion"))
        txtEmail.Text = If(IsDBNull(dfila("Email")), Nothing, dfila("Email"))
        txtUsuario.Text = If(IsDBNull(dfila("Usuario")), Nothing, dfila("Usuario"))
        cbPerfil.SelectedValue = If(IsDBNull(dfila("Codigo_Perfil")), -1, dfila("Codigo_Perfil"))
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
                                   Titulo.BUSQUEDA_EMPLEADO,
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btBuscarPersona_Click(sender As Object, e As EventArgs) Handles btBuscarPersona.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento(Sentencias.PERSONA_EMPLEADO_CONSULTAR,
                                   params,
                                   AddressOf cargarPersona,
                                   Titulo.BUSQUEDA_PERSONA,
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
            dfila = Generales.cargarItem(Sentencias.PERSONA_CARGAR, params)
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
        Generales.deshabilitarControles(gpPagare)
        Generales.limpiarControles(Me)
        pictImagen.Image = My.Resources.usuario
        limpiarLabel()
        cargarParametros()
        formatMoneda()
        cbTipoSalario.Enabled = True
        objEmpleado.codigo = Nothing
        btBuscarPersona.Enabled = True
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub
    Private Function validarCampos() As Boolean
        If IsNothing(objEmpleado.codigo) Or
         cbFormaPago.SelectedIndex = 0 Or
         cbCargo.SelectedIndex = 0 Or
         cbDepartamento.SelectedIndex = 0 Or
         cbTipoSalario.SelectedIndex = 0 Or cbTipoSalario.SelectedIndex = 1 And txtSalario.Text = 0 _
          Or cbTipoSalario.SelectedIndex = 2 And NumComision.Value = 0 Then
        Else
            Return True
        End If
        Return False
    End Function
    Private Sub cargarObjeto()
        Dim almImagen As New IO.MemoryStream
        If objEmpleado.banderaImagen = True Then
            pictImagen.Image.Save(almImagen, Imaging.ImageFormat.Png)
            objEmpleado.imagenEmpleado = almImagen.GetBuffer
        Else
            objEmpleado.imagenEmpleado = Nothing
        End If
        objEmpleado.usuario = txtUsuario.Text
        objEmpleado.codigoFormaPago = cbFormaPago.SelectedValue
        objEmpleado.codigoBanco = If(cbBanco.SelectedValue.ToString = -1, Nothing, cbBanco.SelectedValue)
        objEmpleado.codigoCuenta = If(cbTipoCuenta.SelectedValue.ToString = -1, Nothing, cbTipoCuenta.SelectedValue)
        objEmpleado.Cuenta = If(txtCuenta.Text = String.Empty, Nothing, txtCuenta.Text)
        objEmpleado.cargo = cbCargo.SelectedValue
        objEmpleado.deparTrabajo = cbDepartamento.SelectedValue
        objEmpleado.codigoTipoPagare = cbTipoSalario.SelectedValue
        objEmpleado.salario = txtSalario.Text
        objEmpleado.Comision = NumComision.Value
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
            Else
                EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.VALIDAR_CAMPOS)
            End If
            mostrarIconoError()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            pictImagen.Image = My.Resources.usuario
            limpiarLabel()
            objEmpleado.codigo = Nothing
            formatMoneda()
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            quitarIcono()
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            Generales.deshabilitarControles(gbInform)
            Generales.deshabilitarControles(gpUsuario)
            Generales.deshabilitarControles(gpPagare)
            If cbTipoSalario.SelectedValue = 1 Then
                txtSalario.ReadOnly = False
            ElseIf cbTipoSalario.SelectedValue = 2
                NumComision.Enabled = True
                NumComision.ReadOnly = False
            End If
            cbTipoSalario.Enabled = True
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
                    limpiarLabel()
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
        objEmpleado.banderaImagen = Generales.subirimagen(pictImagen, open)
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

    Private Sub mostrarIconoError()
        If cbDepartamento.SelectedIndex = 0 Then
            Me.ErrorIcono.SetError(cbDepartamento, "Debe escoger un departamento")
        Else
            Me.ErrorIcono.SetError(cbDepartamento, Constantes.CADENA_VACIA)
        End If
        If cbFormaPago.SelectedIndex = 0 Then
            Me.ErrorIcono.SetError(cbFormaPago, "Debe escoger una forma de pago")
        Else
            Me.ErrorIcono.SetError(cbFormaPago, Constantes.CADENA_VACIA)
        End If
        If cbCargo.SelectedIndex = 0 Then
            Me.ErrorIcono.SetError(cbCargo, "Debe escoger un cargo")
        Else
            Me.ErrorIcono.SetError(cbCargo, Constantes.CADENA_VACIA)
        End If
        If txtNombre.Text.Length = 0 Then
            Me.ErrorIcono.SetError(txtNombre, "Debe escoger una persona")
        Else
            Me.ErrorIcono.SetError(txtNombre, Constantes.CADENA_VACIA)
        End If
        If cbTipoSalario.SelectedIndex = 0 Then
            Me.ErrorIcono.SetError(cbTipoSalario, "Debe escoger un tipo de salario")
        Else
            Me.ErrorIcono.SetError(cbTipoSalario, Constantes.CADENA_VACIA)
        End If
        If cbTipoSalario.SelectedIndex = 1 And (txtSalario.Text = 0 Or txtSalario.Text = String.Empty) Then
            Me.ErrorIcono.SetError(txtSalario, "Debe digitar el salario")
        Else
            Me.ErrorIcono.SetError(txtSalario, Constantes.CADENA_VACIA)
        End If
        If cbTipoSalario.SelectedIndex = 2 And NumComision.Value = 0 Then
            Me.ErrorIcono.SetError(NumComision, "Debe digitar la comision")
        Else
            Me.ErrorIcono.SetError(NumComision, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub quitarIcono()
        Me.ErrorIcono.SetError(txtNombre, Constantes.CADENA_VACIA)
        Me.ErrorIcono.SetError(cbFormaPago, Constantes.CADENA_VACIA)
        Me.ErrorIcono.SetError(cbCargo, Constantes.CADENA_VACIA)
        Me.ErrorIcono.SetError(cbDepartamento, Constantes.CADENA_VACIA)
        Me.ErrorIcono.SetError(cbTipoSalario, Constantes.CADENA_VACIA)
        Me.ErrorIcono.SetError(txtSalario, Constantes.CADENA_VACIA)
        Me.ErrorIcono.SetError(NumComision, Constantes.CADENA_VACIA)
    End Sub
    Private Sub cbFormaPago_Validating(sender As Object, e As EventArgs) Handles cbFormaPago.LostFocus
        If cbCargo.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(cbFormaPago, "Debe escoger una forma de pago")
        Else
            Me.ErrorIcono.SetError(cbFormaPago, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub cbDepartamento_Validating(sender As Object, e As EventArgs) Handles cbDepartamento.LostFocus
        If cbDepartamento.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(cbDepartamento, "Debe escoger un departamento")
        Else
            Me.ErrorIcono.SetError(cbDepartamento, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub cbCargo_Validating(sender As Object, e As EventArgs) Handles cbCargo.LostFocus
        If cbCargo.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(cbCargo, "Debe escoger un cargo")
        Else
            Me.ErrorIcono.SetError(cbCargo, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub cbTipoSalario_Validating(sender As Object, e As EventArgs) Handles cbTipoSalario.LostFocus
        If cbTipoSalario.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(cbTipoSalario, "Debe escoger el tipo pagare")
        Else
            Me.ErrorIcono.SetError(cbTipoSalario, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub btBuscarPersona_Validating(sender As Object, e As EventArgs) Handles btBuscarPersona.LostFocus
        If txtNombre.Text = "" And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(txtNombre, "Debe escoger una persona")
        Else
            Me.ErrorIcono.SetError(txtNombre, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub txtSalario_Validating(sender As Object, e As EventArgs) Handles txtSalario.LostFocus
        Try
            If cbTipoSalario.SelectedIndex = 1 And txtSalario.Text = String.Empty Then
                txtSalario.Text = 0
            End If
            If cbTipoSalario.SelectedIndex = 1 And txtSalario.Text = 0 And btRegistrar.Enabled = True Then
                Me.ErrorIcono.SetError(txtSalario, "Debe digitar el salario")
            Else
                Me.ErrorIcono.SetError(txtSalario, Constantes.CADENA_VACIA)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub NumComision_Validating(sender As Object, e As EventArgs) Handles NumComision.LostFocus
        If cbTipoSalario.SelectedIndex = 2 And NumComision.Value = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(NumComision, "Debe digitar la comision")
        Else
            Me.ErrorIcono.SetError(NumComision, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub cbTipoSalario_TextChanged(sender As Object, e As EventArgs) Handles cbTipoSalario.TextChanged
        If btRegistrar.Enabled = False Then Exit Sub
        desHabilitarTxtSalario()
        formatMoneda()
        NumComision.Value = 0
        If cbTipoSalario.SelectedValue = 1 Then
            txtSalario.ReadOnly = False
        ElseIf cbTipoSalario.SelectedValue = 2
            NumComision.Enabled = True
            NumComision.ReadOnly = False
        End If
    End Sub
    Private Sub desHabilitarTxtSalario()
        NumComision.ReadOnly = True
        txtSalario.ReadOnly = True
    End Sub
    Private Sub txtSalario_Leave(sender As Object, e As EventArgs) Handles txtSalario.Leave
        If btRegistrar.Enabled = False Then Exit Sub
        txtSalario.Text = Format(CInt(txtSalario.Text), Constantes.FORMATO_MONEDA)
    End Sub
    Private Sub formatMoneda()
        txtSalario.Text = Format(0, Constantes.FORMATO_MONEDA)
    End Sub
    Private Sub limpiarLabel()
        txtIdentificacion.Text = Nothing
        txtTelefono.Text = Nothing
        txtCelular.Text = Nothing
        txtNombre.Text = Nothing
        txtDireccion.Text = Nothing
        txtEmail.Text = Nothing
    End Sub
End Class



