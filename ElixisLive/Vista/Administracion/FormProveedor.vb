'Imports System.ComponentModel
Public Class FormProveedor

    Dim objProveedor As Proveedor
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objProveedor = New Proveedor
        Try
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
        If dgvParametro.ColumnCount <> 0 Then
            params.Add(ElementoMenu.codigo)
            Generales.llenardgv(Sentencias.PARAMETROS_CONSULTAR, dgvParametro, params)
            Generales.diseñoDGV(dgvParametro)
            Generales.diseñoGrillaParametros(dgvParametro)
        End If
    End Sub
    Private Sub combosIniciales()
        EmpleadoBLL.cargarComboFormaPago(cbFormaPago)
        EmpleadoBLL.cargarComboCuenta(cbTipoCuenta)
        ProveedorBLL.cargarComboTipoPago(cbTipoPago)
        Generales.cargarCombo(Sentencias.REGIMEN_CONSULTAR, Nothing, "Nombre", "Codigo", cbRegimen)
        Generales.cargarCombo(Sentencias.BANCO_CONSULTAR, Nothing, "Nombre", "Codigo_Banco", cbBanco)
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objProveedor.codigo = pcodigo
        params.Add(objProveedor.codigo)
        dfila = Generales.cargarItem(objProveedor.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                cargarCampos(dfila)
                cbFormaPago.SelectedValue = dfila("Forma_pago")
                cbRegimen.SelectedValue = dfila("Codigo_Regimen")
                cbTipoPago.SelectedValue = dfila("Tipo_Pago")
                cbBanco.SelectedValue = If(String.IsNullOrEmpty(dfila("codigo_Banco")), -1, dfila("codigo_Banco"))
                cbTipoCuenta.SelectedValue = If(String.IsNullOrEmpty(dfila("Tipo_Cuenta_Banco")), -1, dfila("Tipo_Cuenta_Banco"))
                txtCuenta.Text = If(cbFormaPago.SelectedValue = 0, String.Empty, dfila("Numero_Cuenta"))
                params.Add(ElementoMenu.codigo)
                Generales.llenardgv(objProveedor.sqlCargarDetalle, dgvParametro, params)
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
    Private Sub cargarCampos(dfila As DataRow)
        txtIdentificacion.Text = dfila("Identificacion")
        txtTelefono.Text = If(IsDBNull(dfila("Telefono")), Nothing, dfila("Telefono"))
        txtCelular.Text = dfila("Celular")
        txtNombre.Text = dfila("Nombre")
        txtDireccion.Text = If(IsDBNull(dfila("Direccion")), Nothing, dfila("Direccion"))
        txtEmail.Text = If(IsDBNull(dfila("Email")), Nothing, dfila("Email"))
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
            Generales.buscarElemento(objProveedor.sqlConsulta,
                                   params,
                                   AddressOf cargarInfomacion,
                                   Titulo.BUSQUEDA_PROVEEDOR,
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btBuscarPersona_Click(sender As Object, e As EventArgs) Handles btBuscarPersona.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento(Sentencias.PERSONA_PROVEEDOR_CONSULTAR,
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
        objProveedor.codigo = pCodigo
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
        Generales.limpiarControles(Me)
        cargarParametros()
        objProveedor.codigo = Nothing
        btBuscarPersona.Enabled = True
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub
    Private Function validarCampos() As Boolean
        If IsNothing(objProveedor.codigo) Or
           cbFormaPago.SelectedIndex = 0 Or
           cbRegimen.SelectedIndex = 0 Then
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub cargarObjeto()
        objProveedor.codigoRegimen = cbRegimen.SelectedValue
        objProveedor.CodigoTipoPago = cbTipoPago.SelectedValue
        objProveedor.codigoFormaPago = cbFormaPago.SelectedValue
        objProveedor.codigoBanco = If(cbBanco.SelectedValue.ToString = -1, Nothing, cbBanco.SelectedValue.ToString)
        objProveedor.codigoCuenta = If(cbTipoCuenta.SelectedValue.ToString = -1, Nothing, cbTipoCuenta.SelectedValue.ToString)
        objProveedor.Cuenta = If(txtCuenta.Text = String.Empty, Nothing, txtCuenta.Text)
        objProveedor.dtParametro = dgvParametro.DataSource
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvParametro.EndEdit()
        Try
            If validarCampos() = True Then
                cargarObjeto()
                ProveedorBLL.guardar(objProveedor)
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
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            Generales.deshabilitarControles(gbInform)
            btBuscarPersona.Enabled = False
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objProveedor.sqlAnular & objProveedor.codigo) = True Then
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
    Private Sub cbFormaPago_Validating(sender As Object, e As EventArgs) Handles cbFormaPago.LostFocus
        If cbFormaPago.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(cbFormaPago, "Debe escoger una forma de pago")
        Else
            Me.ErrorIcono.SetError(cbFormaPago, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub btBuscarPersona_Validating(sender As Object, e As EventArgs) Handles btBuscarPersona.LostFocus
        If txtNombre.Text = "" And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(txtNombre, "Debe escoger una persona")
        Else
            Me.ErrorIcono.SetError(txtNombre, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub cbRegimen_Validating(sender As Object, e As EventArgs) Handles cbRegimen.LostFocus
        If cbRegimen.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(cbRegimen, "Debe escoger una regimen")
        Else
            Me.ErrorIcono.SetError(cbRegimen, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub cbTipoPago_Validating(sender As Object, e As EventArgs) Handles cbTipoPago.LostFocus
        If cbTipoPago.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(cbTipoPago, "Debe escoger un tipo de pago")
        Else
            Me.ErrorIcono.SetError(cbTipoPago, Constantes.CADENA_VACIA)
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
    Private Sub mostrarIconoError()
        If cbRegimen.SelectedIndex = 0 Then
            Me.ErrorIcono.SetError(cbRegimen, "Debe escoger un regimen")
        Else
            Me.ErrorIcono.SetError(cbRegimen, Constantes.CADENA_VACIA)
        End If
        If cbFormaPago.SelectedIndex = 0 Then
            Me.ErrorIcono.SetError(cbFormaPago, "Debe escoger una forma de pago")
        Else
            Me.ErrorIcono.SetError(cbFormaPago, Constantes.CADENA_VACIA)
        End If
        If cbTipoPago.SelectedIndex = 0 Then
            Me.ErrorIcono.SetError(cbTipoPago, "Debe escoger un tipo de pago")
        Else
            Me.ErrorIcono.SetError(cbTipoPago, Constantes.CADENA_VACIA)
        End If
        If txtNombre.Text.Length = 0 Then
            Me.ErrorIcono.SetError(txtNombre, "Debe escoger una persona")
        Else
            Me.ErrorIcono.SetError(txtNombre, Constantes.CADENA_VACIA)
        End If
    End Sub
    Private Sub quitarIcono()
        Me.ErrorIcono.SetError(txtNombre, Constantes.CADENA_VACIA)
        Me.ErrorIcono.SetError(cbFormaPago, Constantes.CADENA_VACIA)
        Me.ErrorIcono.SetError(cbTipoPago, Constantes.CADENA_VACIA)
        Me.ErrorIcono.SetError(cbRegimen, Constantes.CADENA_VACIA)
    End Sub

End Class
