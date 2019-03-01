Public Class FormCuentasPuc
    Private objCuentaPucBLL As New CuentaPucBLL
    Private dsCuentas As DataSet
    Private codigoPUC As String
    Private descripcionPUC As String
    Private anoPUC As String
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        Generales.habilitarControles(gbDetalleCuenta)
        cargarInfoPUC(codigoPUC, anoPUC, descripcionPUC)
        txtCodigoCuenta.ReadOnly = False
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btBuscar.Enabled = True
            btNuevo.Enabled = True
            cargarInfoPUC(codigoPUC, anoPUC, descripcionPUC)
        End If
    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
            Generales.habilitarControles(gbDetalleCuenta)
        End If
    End Sub

    Private Sub Form_CuentasPUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboPUC(cbTipo, llenarSlTipoCuenta())
        cargarComboPUC(cbNaturaleza, llenarSlNaturaleza())
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
        Generales.deshabilitarBotones(ToolStrip1)
    End Sub

    Private Function llenarSlTipoCuenta() As SortedList
        Dim slTipoCuenta As New SortedList

        slTipoCuenta.Add(Constantes.COMBO_TEXTO_PREDETERMINADO, Constantes.COMBO_VALOR_PREDETERMINADO)
        slTipoCuenta.Add(FuncionesContables.getTipoCuentaPUC(Constantes.PUC_TIPO_DETALLE), Constantes.PUC_TIPO_DETALLE)
        slTipoCuenta.Add(FuncionesContables.getTipoCuentaPUC(Constantes.PUC_TIPO_TITULO), Constantes.PUC_TIPO_TITULO)

        Return slTipoCuenta
    End Function


    Private Function llenarSlNaturaleza() As SortedList
        Dim slNaturaleza As New SortedList

        slNaturaleza.Add(Constantes.COMBO_TEXTO_PREDETERMINADO, Constantes.COMBO_VALOR_PREDETERMINADO)
        slNaturaleza.Add(FuncionesContables.getNaturalezaCuenta(Constantes.PUC_NATURALEZA_DEBITO), Constantes.PUC_NATURALEZA_DEBITO)
        slNaturaleza.Add(FuncionesContables.getNaturalezaCuenta(Constantes.PUC_NATURALEZA_CREDITO), Constantes.PUC_NATURALEZA_CREDITO)

        Return slNaturaleza
    End Function

    Private Sub cargarComboPUC(ByRef comboPUC As ComboBox, ByVal dtPUC As SortedList)
        Dim bsCombo As New BindingSource

        bsCombo.DataSource = dtPUC

        comboPUC.Items.Clear()
        comboPUC.DataSource = bsCombo
        comboPUC.ValueMember = "value"
        comboPUC.DisplayMember = "key"
    End Sub

    Public Sub cargarInfoPUC(ByVal pCodigoPUC As String,
                             ByVal pAnoPUC As String,
                             ByVal pDescripcionPUC As String)

        codigoPUC = pCodigoPUC
        descripcionPUC = pDescripcionPUC
        anoPUC = pAnoPUC

        txtCodigoPUC.Text = codigoPUC
        txtDescripcionPUC.Text = descripcionPUC
        txtAnoPUC.Text = anoPUC

    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarFormulario() Then
            Dim objCuentaPUC = crearCuentaPUC()
            guardarCuentaPUC(objCuentaPUC)
        End If

    End Sub

    Private Sub guardarCuentaPUC(ByVal objCuentaPUC As CuentaPUC)
        Try
            objCuentaPucBLL.guardarCuentaPUC(objCuentaPUC, SesionActual.idUsuario)
            Generales.deshabilitarControles(Me)
            Generales.habilitarBotones(ToolStrip1)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Function crearCuentaPUC() As CuentaPUC
        Dim objCuentaPUC = New CuentaPUC()

        objCuentaPUC.setCodigoPUC(txtCodigoPUC.Text)
        objCuentaPUC.setCodigo(txtCodigoCuenta.Text)
        objCuentaPUC.setDescripcion(txtCuentaPUC.Text)
        objCuentaPUC.setTipo(cbTipo.SelectedValue)
        objCuentaPUC.setNaturalea(cbNaturaleza.SelectedValue)
        objCuentaPUC.setClasifiacion(txtClasificacion.Text)
        objCuentaPUC.setCuentaPadre(txtCodigoPadre.Text)
        Return objCuentaPUC
    End Function

    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(txtCodigoPUC.Text)
        params.Add(Nothing)

        Generales.buscarElemento(Consultas.BUSQUEDA_CUENTAS_PUC,
                               params,
                               AddressOf cargarCuentaPUC,
                               TitulosForm.BUSQUEDA_CUENTAS_PUC,
                               False, True)

    End Sub

    Public Sub cargarCuentaPUC(ByVal pCodigoCuenta As String)
        Dim dtCuentasPUC As New DataTable

        Dim params As New List(Of String)
        params.Add(txtCodigoPUC.Text)
        params.Add(pCodigoCuenta)

        Generales.llenarTabla(Consultas.CUENTAS_PUC_CARGAR,
                            params,
                            dtCuentasPUC)

        Dim objCuentaPUC As New CuentaPUC(dtCuentasPUC.Rows(0))

        txtCodigoCuenta.Text = objCuentaPUC.getCodigo
        txtCuentaPUC.Text = objCuentaPUC.getDescripcion
        cbTipo.SelectedValue = objCuentaPUC.getTipo
        cbNaturaleza.SelectedValue = objCuentaPUC.getNaturaleza
        txtClasificacion.Text = objCuentaPUC.getClasificacion
        txtCodigoPadre.Text = objCuentaPUC.getCuentaPadre
        txtNombreCuentaPadre.Text = dtCuentasPUC.Rows(0).Item("NOMBRE_CUENTA_PADRE")
        Generales.deshabilitarControles(Me)
        Generales.habilitarBotones(ToolStrip1)
        btRegistrar.Enabled = False
        btCancelar.Enabled = False
        cargarArbolPUC("padre", "codigo_cuenta", "nombre")

    End Sub

    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Function validarFormulario()
        If String.IsNullOrEmpty(txtCodigoCuenta.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor digitar codigo de la cuenta")
            txtCodigoCuenta.Focus()
        ElseIf String.IsNullOrEmpty(txtCuentaPUC.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor digitar el nombre de la cuenta")
            txtCuentaPUC.Focus()
        ElseIf cbTipo.SelectedValue = Constantes.COMBO_VALOR_PREDETERMINADO Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor seleccionar el tipo de la cuenta")
            cbTipo.Focus()
        ElseIf cbNaturaleza.SelectedValue = Constantes.COMBO_VALOR_PREDETERMINADO Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor seleccionar la naturaleza de la cuenta")
            cbNaturaleza.Focus()
        Else
            Return True
        End If
        Return False
    End Function

    Private Sub txtCodigoCuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoCuenta.KeyPress
        ValidacionDigitacion.validarSoloNumerosPositivo(e)
    End Sub

    Public Sub cargarArbolPUC(campoPadre As String,
                              campoHijo As String,
                              campoMostrado As String)
        Dim nodo As TreeNode
        Dim drCuentaPadre As DataRow()
        tvCuentasPUC.Enabled = True
        tvCuentasPUC.Nodes.Clear()
        tvCuentasPUC.ExpandAll()
        Try
            dsCuentas = New DataSet
            objCuentaPucBLL.cargarCuentas(txtCodigoPUC.Text, dsCuentas)
            drCuentaPadre = dsCuentas.Tables(campoPadre).Select()
            'Se recorren las cuentas Padre
            For Each drFila As DataRow In drCuentaPadre
                nodo = New TreeNode
                nodo.Name = drFila(campoHijo).ToString()
                nodo.Text = nodo.Name & "." & "  " & drFila(campoMostrado).ToString()
                tvCuentasPUC.Nodes.Add(nodo)
                'Se recorren las cuentas hijas
                crearSubcuentas(nodo, campoHijo)
            Next
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
        dsCuentas.Dispose()
    End Sub
    Private Sub crearSubcuentas(ByRef nodoPade As TreeNode, campoHijo As String)
        Dim expr As String = "padre ='" & nodoPade.Name & "'"
        Dim subnodo As TreeNode
        Try
            Dim aDrFilas As DataRow()
            aDrFilas = dsCuentas.Tables("Hijas").Select(expr, campoHijo)

            For Each drFila As DataRow In aDrFilas
                subnodo = New TreeNode
                subnodo.Name = drFila(campoHijo).ToString()
                subnodo.Text = subnodo.Name & "." & "  " & drFila("nombre").ToString()
                nodoPade.Nodes.Add(subnodo)
                crearSubcuentas(subnodo, campoHijo)
            Next
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try

    End Sub

    Private Sub btanular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        Try
            If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
                Dim params As New List(Of String)
                params.Add(txtCodigoPUC.Text)
                params.Add(txtCodigoCuenta.Text)
                params.Add(SesionActual.idUsuario)
                Generales.ejecutarSQL(Consultas.ANULAR_CUENTA_PUC, params)
                EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                Generales.deshabilitarBotones(ToolStrip1)
                btBuscar.Enabled = True
                btNuevo.Enabled = True
                Generales.limpiarControles(Me)
                cargarInfoPUC(codigoPUC, anoPUC, descripcionPUC)
                cargarArbolPUC("padre", "codigo_cuenta", "nombre")
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub txtCodigoCuenta_Leave(sender As Object, e As EventArgs) Handles txtCodigoCuenta.Leave
        If txtCodigoCuenta.Text <> String.Empty Then
            validarCuenta(txtCodigoCuenta.Text)
        End If
    End Sub
    Public Sub validarCuenta(codigoCuenta As String)
        Dim pucActivo As Integer = FuncionesContables.obtenerPucActivo()
        Dim validaCuentaPuc As Integer
        validaCuentaPuc = FuncionesContables.validarCuentaPuc(pucActivo, txtCodigoCuenta.Text)
        If validaCuentaPuc = FuncionesContables.estadoCuentaPuc.invalida Then
            MsgBox("Cuenta invalida!", MsgBoxStyle.Exclamation)
            txtCodigoCuenta.Text = String.Empty
            txtCodigoPadre.Text = String.Empty
            txtNombreCuentaPadre.Text = String.Empty
            txtClasificacion.Text = String.Empty
            txtCodigoCuenta.Focus()
        ElseIf validaCuentaPuc = FuncionesContables.estadoCuentaPuc.existente Then
            Dim drCuentaPuc As DataRow
            Dim params As New List(Of String)
            params.Add(pucActivo)
            params.Add(codigoCuenta)
            drCuentaPuc = FuncionesContables.digitarCuenta(params)
            If Not IsNothing(drCuentaPuc) Then
                txtCuentaPUC.Text = drCuentaPuc("descripcion")
                txtCodigoPadre.Text = drCuentaPuc("padre")
                txtNombreCuentaPadre.Text = drCuentaPuc("nombre_cuenta_padre")
                txtClasificacion.Text = drCuentaPuc("clasificacion")
            End If
        Else
            Dim drCuentaPadre As DataRow
            Dim params As New List(Of String)
            params.Add(pucActivo)
            params.Add(codigoCuenta)
            drCuentaPadre = Generales.cargarItem("SP_PUC_DETALLE_CARGAR_PADRE", params)
            txtCodigoPadre.Text = drCuentaPadre("codigo_cuenta")
            txtNombreCuentaPadre.Text = drCuentaPadre("descripcion")
            txtClasificacion.Text = drCuentaPadre("clasificacion")
        End If
    End Sub
End Class