Public Class FormNotaInterna
    Dim dtCuentas As New DataTable
    Dim identificador As String
    Dim codigoPuc, codigoDocumento, idTercero As Integer
    Private Sub FormCualquierNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDtCuentas()
        codigoPuc = FuncionesContables.obtenerPucActivo()
        Generales.deshabilitarControles(Me)
        codigoDocumento = Constantes.NOTA_INTERNA_DE_CONTABILIDAD
        Generales.asignarPermiso(Me)
    End Sub
    Private Sub base_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles base.KeyPress, txtPorcentaje.KeyPress
        ValidacionDigitacion.validarSoloNumerosPositivo(e)
    End Sub
    Private Sub bloquearColumnas()
        With dgvCuentas
            .Columns("Naturaleza").ReadOnly = True
            .Columns("Descripcion").ReadOnly = True
        End With
    End Sub
    Private Sub llenarDtCuentas()
        Dim cuenta, descripcion, naturaleza, debito, credito As New DataColumn

        cuenta.ColumnName = "Cuenta"
        cuenta.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(cuenta)

        descripcion.ColumnName = "Descripcion"
        descripcion.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(descripcion)

        naturaleza.ColumnName = "Naturaleza"
        naturaleza.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(naturaleza)

        debito.ColumnName = "Debito"
        debito.DataType = Type.GetType("System.Double")
        dtCuentas.Columns.Add(debito)
        dtCuentas.Columns("Debito").DefaultValue = "0,00"

        credito.ColumnName = "Credito"
        credito.DataType = Type.GetType("System.Double")
        dtCuentas.Columns.Add(credito)
        dtCuentas.Columns("Credito").DefaultValue = "0,00"

        dgvCuentas.DataSource = dtCuentas
        dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvCuentas.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)

        With dgvCuentas
            .Columns("Cuenta").ReadOnly = True
            .Columns("Cuenta").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Cuenta").DataPropertyName = "Cuenta"
            .Columns("Cuenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Descripcion").ReadOnly = True
            .Columns("Descripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Descripcion").DataPropertyName = "Descripcion"
            .Columns("Descripcion").HeaderText = "Descripción"
            .Columns("Naturaleza").ReadOnly = True
            .Columns("Naturaleza").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Naturaleza").DataPropertyName = "Naturaleza"
            .Columns("Naturaleza").Visible = False
            .Columns("Debito").ReadOnly = True
            .Columns("Debito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Debito").DataPropertyName = "Debito"
            .Columns("Credito").ReadOnly = True
            .Columns("Credito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Credito").DataPropertyName = "Credito"
            .Columns("anular").ReadOnly = True
            .Columns("anular").DisplayIndex = CInt(dgvCuentas.ColumnCount - 1)
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        End With

    End Sub

    Private Sub dgvCuentas_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvCuentas.CellFormatting
        If e.ColumnIndex = 4 Or e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), "c2")
            Else
                e.Value = Format(Val(e.Value), "c2")
            End If
        End If
    End Sub
    Private Sub formatoDgv()
        dgvCuentas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCuentas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvCuentas.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
    End Sub
    Private Sub llenardgvCuentas(pCodigo As String)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtcodigo.Text = pCodigo
        Generales.llenarTabla(Consultas.NOTA_INTERNA_DETALLE_CARGAR, params, dtCuentas)
        formatoDgv()

        If dtCuentas.Rows.Count > 0 Then
            calcularTotales()
        Else
            textvalorcredito.Text = FormatCurrency(0, 2)
            textvalordebito.Text = FormatCurrency(0, 2)
            textdiferencia.Text = FormatCurrency(0, 2)
        End If
    End Sub
    Private Sub bttercero_Click(sender As Object, e As EventArgs) Handles bttercero.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Generales.buscarElemento(Consultas.CONTA_TERCERO_BUSCAR,
                            params,
                            AddressOf cargarTercero,
                            TitulosForm.BUSQUEDA_TERCERO,
                            True, True)
    End Sub
    Private Sub cargarDatos(pCodigo As String)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtcodigo.Text = pCodigo
        Generales.llenarTabla(Consultas.NOTA_INTERNA_CARGAR, params, dt)
        If dt.Rows.Count > 0 Then
            Textsigla.Text = Constantes.SIGLA_NOTA_INTERNA
            cargarDocumento(Textsigla.Text)
            fechadoc.Value = dt.Rows(0).Item("Fecha_Recibo").ToString()
            textnombreproveedor.Text = dt.Rows(0).Item("Tercero").ToString()
            textCodigoCliente.Text = dt.Rows(0).Item("Nit").ToString()
            textobserva.Text = dt.Rows(0).Item("detalle_mov").ToString()
            idTercero = dt.Rows(0).Item("id_tercero").ToString()
            llenardgvCuentas(pCodigo)
            calcularTotales()
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
            If FuncionesContables.verificarFecha(fechadoc.Value) Then
                mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.FromArgb(252, 249, 169))
                btEditar.Enabled = False
            Else
                mostrarInfo(Nothing, Nothing, Nothing, True)
                PnlInfo.Visible = False
            End If
            If FuncionesContables.verificarComprobante(pCodigo) Then
                mostrarInfo(String.Format(MensajeSistema.COMPROBANTE_ANULADO), Color.White, Color.FromArgb(252, 249, 169))
                Generales.deshabilitarBotones(ToolStrip1)
                btBuscar.Enabled = True
                btNuevo.Enabled = True
            End If
        End If
    End Sub
    Sub mostrarInfo(pSmg As String, pColorFuenteLetra As Color, pColorFondoPanel As Color, Optional pOcultar As Boolean = False)
        If InvokeRequired Then
            Invoke(New MethodInvoker(Sub() mostrarInfo(pSmg, pColorFuenteLetra, pColorFondoPanel, pOcultar)))
        Else
            If pOcultar Then
                PnlInfo.Visible = False
            Else
                'lbinfo.Text = pSmg.ToUpper : lbinfo.ForeColor = pColorFuenteLetra : PictureBox2.Image = My.Resources.atencion
                PnlInfo.BackColor = pColorFondoPanel : PnlInfo.BringToFront() : PnlInfo.Visible = True

            End If
        End If
    End Sub
    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBusqueda.Click
        Generales.buscarElemento(Consultas.NOTA_INTERNA_BUSCAR,
                              Nothing,
                              AddressOf cargarDatos,
                              TitulosForm.BUSQUEDA_NOTA_INTERNA,
                              False, True)

    End Sub
    Private Sub dgvcuentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellDoubleClick
        Dim params As New List(Of String)
        params.Add(codigoPuc)
        params.Add("")
        Try
            If btRegistrar.Enabled = False Then
                Exit Sub
            End If
            If dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(0).ToString.StartsWith("22") Then
                EstiloMensajes.mostrarMensajeAdvertencia("No puede eliminar una cuenta de proveedores")
                Exit Sub
            End If

            If (dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Cuenta").Selected = True Or dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Descripcion").Selected = True) Then
                Generales.busquedaItems(Consultas.BUSQUEDA_CUENTAS_DETALLE_PUC, params, TitulosForm.BUSQUEDA_CUENTAS_PUC, dgvCuentas, dtCuentas, 0, 2, 0, 0, 0, 0, 1)
            ElseIf dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("anular").Selected = True And dtCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Item("Cuenta").ToString <> "" Then
                dtCuentas.Rows.RemoveAt(e.RowIndex)
            End If
            formatoDgv()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub dgvcuentas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellEndEdit
        If dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(0).ToString <> "" Then
            Dim params As New List(Of String)
            params.Add(codigoPuc)
            params.Add(dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(0).ToString)
            Dim fila As DataRow
            fila = FuncionesContables.digitarCuenta(params)
            If Not IsNothing(fila) Then

                If dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(0).ToString <> "" And dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(1).ToString = "" Then
                    dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(1) = fila(2)
                    dtCuentas.Rows.Add()
                Else
                    dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(1) = fila(2)
                End If
            Else
                dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Cuenta").Value = String.Empty
                dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Descripcion").Value = String.Empty

                If dtCuentas.Rows.Count > 1 And dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Cuenta").Value = String.Empty And e.RowIndex <> dgvCuentas.Rows.Count - 1 Then
                    dtCuentas.Rows.RemoveAt(e.RowIndex)
                    calcularTotales()
                End If

            End If
            If dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(1).ToString = "" Then
                dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Cuenta").Value = String.Empty
                Exit Sub
            Else
                Dim paramsRetencion As New List(Of String)
                paramsRetencion.Add(codigoPuc)
                paramsRetencion.Add(dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(0).ToString)
                Dim filaRetencion As DataRow
                filaRetencion = FuncionesContables.llenarRetencion(paramsRetencion)
                If Not IsNothing(filaRetencion) Then
                    lblivarete.Text = filaRetencion("Cuenta").ToString()
                    txtPorcentaje.Text = filaRetencion("tasa").ToString()
                    txtPorcentaje.Text = Replace(txtPorcentaje.Text, ".", ",")
                    txtNaturaleza.Text = filaRetencion("naturaleza").ToString()
                    Panel3.Visible = True
                    base.Focus()
                End If
            End If

            If dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item("Debito").ToString = "" Then
                dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Debito").Value = 0
            ElseIf dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item("Credito").ToString = "" Then
                dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Credito").Value = 0
            End If
            formatoDgv()
        End If
    End Sub

    Public Sub cargarTercero(pCodigo)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add(pCodigo)
        idTercero = pCodigo
        Generales.llenarTabla(Consultas.CONTA_TERCERO_CARGAR, params, dt)
        If dt.Rows.Count > 0 Then
            textCodigoCliente.Text = dt.Rows(0).Item("Nit").ToString()
            textnombreproveedor.Text = dt.Rows(0).Item("Tercero").ToString()
        End If
    End Sub
    Private Sub btBusquedaDocumento_Click(sender As Object, e As EventArgs) Handles btBusquedaDocumento.Click
        Generales.buscarElemento(Consultas.DOCUMENTOS_SIGLA_BUSCAR,
                              Nothing,
                              AddressOf cargarDocumento,
                              TitulosForm.BUSQUEDA_DOCUMENTOS_CONTABLES,
                              False)
    End Sub
    Private Sub dgvCuentas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCuentas.EditingControlShowing,
            dgvCuentas.EditingControlShowing
        If dgvCuentas.CurrentCell.ColumnIndex = 3 Or dgvCuentas.CurrentCell.ColumnIndex = 4 Or dgvCuentas.CurrentCell.ColumnIndex = 1 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.limpiarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        txtcodigo.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        Textsigla.Text = Constantes.SIGLA_NOTA_INTERNA
        Textsigla_Leave(sender, e)
        dtCuentas.Rows.Add()
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        identificador = String.Empty
        textvalorcredito.Text = FormatCurrency(0, 2)
        textvalordebito.Text = FormatCurrency(0, 2)
        textdiferencia.Text = FormatCurrency(0, 2)
        PnlInfo.Visible = False
        bttercero.Focus()
        bloquearColumnas()
    End Sub
    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            dtCuentas.Rows.Add()
            bttercero.Enabled = False
            bloquearColumnas()
            identificador = txtcodigo.Text
            base.ReadOnly = False
        End If
    End Sub
    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub
    Private Sub Textsigla_Leave(sender As Object, e As EventArgs) Handles Textsigla.Leave
        If Textsigla.Text <> "" Then
            cargarDocumento(Textsigla.Text)
        End If
    End Sub
    Private Sub cargarDocumento(codigo As String)
        Dim objDocumentoContable As DocumentoContable = FuncionesContables.cargarDocumento(codigo)
        If objDocumentoContable IsNot Nothing Then
            codigoDocumento = objDocumentoContable.codigo
            Textsigla.Text = codigo
        End If
    End Sub

    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub dgvCuentas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellEnter
        calcularTotales()
        If e.ColumnIndex = 4 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 5 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        bloquearColumnas()
    End Sub
    Private Sub dgvcuentas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCuentas.DataError

    End Sub
    Private Sub dgvCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
        If e.ColumnIndex = 4 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 5 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        bloquearColumnas()
    End Sub

    Private Sub calcularTotales()
        Try
            Dim valorDebito, sumaDebito, sumaCredito, valorCredito As Double

            If dgvCuentas.Rows.Count > 1 Then
                For indicedgvCuentas = 0 To dgvCuentas.Rows.Count - 1
                    If dgvCuentas.Rows(indicedgvCuentas).Cells("Descripcion").Value.ToString <> "" Then
                        sumaDebito = CDbl(dgvCuentas.Rows(indicedgvCuentas).Cells(4).Value)
                        sumaCredito = CDbl(dgvCuentas.Rows(indicedgvCuentas).Cells(5).Value)
                        valorDebito = valorDebito + sumaDebito
                        valorCredito = valorCredito + sumaCredito
                    End If
                Next
                textdiferencia.Text = FormatCurrency((CDbl(valorDebito) - CDbl(valorCredito)), 2)
                textvalordebito.Text = CDbl(valorDebito).ToString("C2")
                textvalorcredito.Text = CDbl(valorCredito).ToString("C2")

            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub dgvcuentas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCuentas.KeyDown
        Dim params As New List(Of String)
        params.Add(codigoPuc)
        params.Add("")
        If e.KeyCode = Keys.F3 And btRegistrar.Enabled = True Then
            Generales.busquedaItems(Consultas.BUSQUEDA_CUENTAS_DETALLE_PUC, params, TitulosForm.BUSQUEDA_CUENTAS_PUC, dgvCuentas, dtCuentas, 0, 2, 0, 0, 0, 0, 1)
            Dim paramsRetencion As New List(Of String)
            paramsRetencion.Add(codigoPuc)
            paramsRetencion.Add(dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(0).ToString)
            Dim filaRetencion As DataRow
            filaRetencion = FuncionesContables.llenarRetencion(paramsRetencion)
            If Not IsNothing(filaRetencion) Then
                lblivarete.Text = filaRetencion("Cuenta").ToString()
                txtPorcentaje.Text = filaRetencion("tasa").ToString()
                txtPorcentaje.Text = Replace(txtPorcentaje.Text, ".", ",")
                txtNaturaleza.Text = filaRetencion("naturaleza").ToString()
                Panel3.Visible = True
                base.Focus()
            End If
        End If
    End Sub
    Private Function validarInformacion() As Boolean
        dgvCuentas.EndEdit()
        Dim vDebito, vCredito As Double
        vDebito = CDbl(textvalordebito.Text)
        vCredito = CDbl(textvalorcredito.Text)
        If textCodigoCliente.Text = "" Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por Favor Elija el proveedor")
            bttercero.Focus()
        ElseIf dtCuentas.Rows.Count <= 1 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por favor corrija el movimiento,elija una cuenta ")
        ElseIf CDbl(textdiferencia.Text) <> 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por favor corrija el movimiento, los saldos debito y credito no son iguales")
            dgvCuentas.Focus()
        ElseIf vCredito = 0 Or vDebito = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por favor corrija el movimiento, los saldos debito y credito no son iguales o estan en cero")
            dgvCuentas.Focus()
        Else
            Return True
        End If
        If FuncionesContables.verificarFecha(fechadoc.Value) Then
            mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.FromArgb(252, 249, 169))
            Return False
        Else
            mostrarInfo(Nothing, Nothing, Nothing, True)
            PnlInfo.Visible = False
        End If

        If FuncionesContables.validarFechaFutura(fechadoc) = False Then
            Return False
        End If
        Return True
    End Function
    Private Sub fechadoc_Leave(sender As Object, e As EventArgs) Handles fechadoc.Leave
        FuncionesContables.validarFechaFutura(fechadoc)
    End Sub
    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarInformacion() Then
            If FuncionesContables.validardgv(dtCuentas) Then
                codigoPuc = FuncionesContables.obtenerPucActivo()
                calcularTotales()
                dgvCuentas.EndEdit()
                dtCuentas.AcceptChanges()
                Dim objCualquierNotaBll As New CualquierNotaBLL
                Try
                    objCualquierNotaBll.guardarCualquierNota(crearCualquierNota(), SesionActual.idUsuario)
                    Generales.deshabilitarControles(Me)
                    Generales.habilitarBotones(ToolStrip1)
                    llenardgvCuentas(txtcodigo.Text)
                Catch ex As Exception
                    EstiloMensajes.mostrarMensajeError(ex.Message)
                End Try
            End If
        End If
    End Sub
    Public Function crearCualquierNota() As NotaInterna
        Dim objCualquierNota As New NotaInterna
        Dim valorDebito, valorCredito As Double
        valorDebito = textvalordebito.Text
        valorCredito = textvalorcredito.Text
        objCualquierNota.codigoDocumento = codigoDocumento
        objCualquierNota.comprobante = txtcodigo.Text
        objCualquierNota.idProveedor = idTercero
        objCualquierNota.fechaRecibo = fechadoc.Value
        objCualquierNota.detalleMov = textobserva.Text
        objCualquierNota.identificador = identificador

        Dim Index As Integer = 0
        For Each drFila As DataRow In dtCuentas.Rows
            If drFila.Item("Cuenta").ToString <> "" Then
                Dim drCuenta As DataRow = objCualquierNota.dtCuentas.NewRow
                drCuenta.Item("comprobante") = txtcodigo.Text
                drCuenta.Item("codigo_puc") = codigoPuc
                drCuenta.Item("codigoCuenta") = drFila.Item("Cuenta")
                drCuenta.Item("debito") = drFila.Item("debito")
                drCuenta.Item("credito") = drFila.Item("credito")
                drCuenta.Item("orden") = Index
                objCualquierNota.dtCuentas.Rows.Add(drCuenta)
                Index += 1
            End If
        Next
        Return objCualquierNota
    End Function
    Private Sub formCualquierNota_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) And Panel3.Visible = True Then
            Panel3.Visible = False
            base.Text = ""
            txtTotal.Text = ""
            dgvCuentas.Focus()
        ElseIf Panel3.Visible = True And e.KeyChar = Chr(13) Then
            If base.Focused() = True Then
                If base.Text <> "" Then
                    If base.Text <> 0 Then
                        txtPorcentaje.Text = Replace(txtPorcentaje.Text, ".", ",")
                        txtTotal.Text = CDbl(base.Text) * CDbl(txtPorcentaje.Text) / 100
                        txtTotal.Focus()
                    Else
                        EstiloMensajes.mostrarMensajeAdvertencia("La cantidad base no puede ser cero")
                        base.Focus()
                    End If
                Else
                    EstiloMensajes.mostrarMensajeAdvertencia("Digite cantidad base")
                    base.Focus()
                End If
            ElseIf txttotal.text <> "" Then
                Panel3.Visible = False
                dgvCuentas.Enabled = True
                bttercero.Enabled = True

                ToolStrip1.Enabled = True
                If base.Text <> "" Then
                    If txtNaturaleza.Text = Constantes.PUC_NATURALEZA_DEBITO Then
                        dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(3) = txtTotal.Text
                    Else
                        dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(4) = txtTotal.Text
                    End If
                End If
                base.Text = ""
                txtTotal.Text = ""
                dgvCuentas.Focus()
            End If

        End If
    End Sub
End Class