Public Class FormNotaProveedor
    Dim dtCuentas, dtComprobantes As New DataTable
    Dim identificador As String
    Dim codigoPuc, codigoDocumento, idTercero As Integer
    Private Sub FormNotaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarDtCuentas()
        codigoPuc = FuncionesContables.obtenerPucActivo()
        Generales.deshabilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.asignarPermiso(Me)
        codigoDocumento = Constantes.NOTA_A_PROVEEDOR
        ocultarControles()
    End Sub
    Private Sub diseñoDgv()
        dgvCuentas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvCuentas.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub base_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles base.KeyPress, txtPorcentaje.KeyPress
        ValidacionDigitacion.validarSoloNumerosPositivo(e)
    End Sub
    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub dgvComprobantes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvComprobantes.CellDoubleClick
        textdocumento.Text = ""
        textfactura.Text = ""
        tfecha.Text = ""
        textsaldoactual.Text = ""
        tsaldon.Text = ""
        dgvCuentas.DataSource = Nothing
        If dgvComprobantes.RowCount > 0 Then
            textdocumento.Text = dgvComprobantes.Rows(dgvComprobantes.CurrentRow.Index).Cells(0).Value
            textfactura.Text = dgvComprobantes.Rows(dgvComprobantes.CurrentRow.Index).Cells(1).Value
            tfecha.Text = dgvComprobantes.Rows(dgvComprobantes.CurrentRow.Index).Cells(2).Value
            textsaldoactual.Text = dgvComprobantes.Rows(dgvComprobantes.CurrentRow.Index).Cells(3).Value
            textsaldoactual.Text = CDbl(textsaldoactual.Text).ToString("C2")
            tsaldon.Text = ""
            mostrarControles()
            cargaCuentaProveedor(idTercero)
        End If
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
        dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvCuentas.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
    End Sub
    Private Sub cargaCuentaProveedor(idproveedor As Integer)
        Dim params As New List(Of String)
        params.Add(idproveedor)
        dgvCuentas.EndEdit()
        Generales.llenarTabla(Consultas.CUENTA_POR_PAGAR_CREAR, params, dtCuentas)
        dgvCuentas.DataSource = dtCuentas
        dtCuentas.Rows.Add()
        With dgvCuentas
            .Columns("anular").ReadOnly = True
            .Columns("anular").DisplayIndex = CInt(dgvCuentas.ColumnCount - 1)
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
        End With
        diseñoDgv()
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
    Private Sub dgvComprobantes_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvComprobantes.CellFormatting
        If e.ColumnIndex = 3 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), "c2")
            Else
                e.Value = Format(Val(e.Value), "c2")
            End If
        End If
    End Sub

    Private Sub llenardgvComprobantes(pCodigo As String)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        idTercero = pCodigo
        Generales.llenarTabla(Consultas.CUENTAS_POR_PAGAR_CARGAR, params, dtComprobantes)
        If dtComprobantes.Rows.Count = 0 Then
            MsgBox("Este Proveedor no tiene cuentas por pagar", MsgBoxStyle.Information)
            dtCuentas.Clear()
        End If
        dgvComprobantes.DataSource = dtComprobantes
        dgvComprobantes.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvComprobantes.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvComprobantes.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvComprobantes.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvComprobantes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvComprobantes.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
    End Sub
    Private Sub llenardgvCuentas(pCodigo As String)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtcodigo.Text = pCodigo
        Generales.llenarTabla(Consultas.NOTA_PROVEEDOR_DETALLE_CARGAR, params, dtCuentas)
        If dtCuentas.Rows.Count > 0 Then
            calcularTotales()
            textdocumento.Text = dtCuentas.Rows(0).Item("Comprobante_A").ToString()
        Else
            textdiferencia.Text = FormatCurrency(0, 2)
        End If
        diseñoDgv()
    End Sub
    Private Sub bttercero_Click(sender As Object, e As EventArgs) Handles bttercero.Click
        Dim params As New List(Of String)
        params.Add("")
        Generales.buscarElemento(Sentencias.PERSONA_PROVEEDOR_CONSULTAR,
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
        Generales.llenarTabla(Consultas.NOTA_PROVEEDOR_CARGAR, params, dt)
        If dt.Rows.Count > 0 Then
            Textsigla.Text = Constantes.SIGLA_NOTA_PROVEEDOR
            cargarDocumento(Textsigla.Text)
            fechadoc.Value = dt.Rows(0).Item("Fecha_Recibo").ToString()
            textnombreproveedor.Text = dt.Rows(0).Item("Tercero").ToString()
            textCodigoCliente.Text = dt.Rows(0).Item("Nit").ToString()
            textvalordebito.Text = dt.Rows(0).Item("valor_debito").ToString()
            textvalorcredito.Text = dt.Rows(0).Item("valor_credito").ToString()
            idTercero = dt.Rows(0).Item("Id_Proveedor").ToString()
            llenardgvCuentas(pCodigo)
            mostrarControles()
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
            If FuncionesContables.verificarFecha(fechadoc.Value) Then
                mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.Red)
                btEditar.Enabled = False
            Else
                mostrarInfo(Nothing, Nothing, Nothing, True)
                PnlInfo.Visible = False
            End If
            If FuncionesContables.verificarComprobante(pCodigo) Then
                mostrarInfo(String.Format(MensajeSistema.COMPROBANTE_ANULADO), Color.White, Color.Red)
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
                lbinfo.Text = pSmg.ToUpper : lbinfo.ForeColor = pColorFuenteLetra : PictureBox2.Image = My.Resources.atencion
                PnlInfo.BackColor = pColorFondoPanel : PnlInfo.BringToFront() : PnlInfo.Visible = True

            End If
        End If
    End Sub
    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        Generales.buscarElemento(Consultas.NOTA_PROVEEDOR_BUSCAR,
                               params,
                               AddressOf cargarDatos,
                               TitulosForm.BUSQUEDA_NOTA_PROVEEDOR,
                               False, True)
    End Sub
    Private Sub dgvcuentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellDoubleClick
        If dgvCuentas.Rows.Count > 0 Then
            Dim params As New List(Of String)
            params.Add(codigoPuc)
            params.Add("")
            Try
                If btRegistrar.Enabled = False Then
                    Exit Sub
                End If
                If dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("anular").Selected = True And dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(0).ToString.StartsWith("22") Then
                    MsgBox("No puede eliminar una cuenta de proveedores", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If

                If (dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Cuenta").Selected = True Or dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Descripcion").Selected = True) Then
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
                ElseIf dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("anular").Selected = True And dtCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Item("Cuenta").ToString <> "" Then
                    dtCuentas.Rows.RemoveAt(e.RowIndex)
                End If
            Catch ex As Exception
                Throw ex
            End Try
            diseñoDgv()
        End If
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
                    dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(2) = fila(5)
                    dtCuentas.Rows.Add()
                Else
                    dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(1) = fila(2)
                    dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(2) = fila(5)
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
            diseñoDgv()
        End If
    End Sub
    Public Sub cargarTercero(pCodigo)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add(pCodigo)
        idTercero = pCodigo
        Generales.llenarTabla(Consultas.CONTA_PROVEEDOR_CARGAR, params, dt)
        If dt.Rows.Count > 0 Then
            textCodigoCliente.Text = dt.Rows(0).Item("Nit").ToString()
            textnombreproveedor.Text = dt.Rows(0).Item("Proveedor").ToString()
            llenardgvComprobantes(idTercero)
            dtCuentas.Clear()
        End If
    End Sub
    Private Sub dgvCuentas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCuentas.EditingControlShowing,
            dgvCuentas.EditingControlShowing
        If dgvCuentas.CurrentCell.ColumnIndex = 4 Or dgvCuentas.CurrentCell.ColumnIndex = 5 Or dgvCuentas.CurrentCell.ColumnIndex = 1 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.limpiarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        txtcodigo.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        Textsigla.Text = Constantes.SIGLA_NOTA_PROVEEDOR
        Textsigla_Leave(sender, e)
        ocultarControles()
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        identificador = String.Empty
        bttercero.Focus()
        dgvComprobantes.ReadOnly = True
        textvalorcredito.Text = FormatCurrency(0, 2)
        textvalordebito.Text = FormatCurrency(0, 2)
        textdiferencia.Text = FormatCurrency(0, 2)
        deshabilitarColumnas()
        PnlInfo.Visible = False
    End Sub
    Private Sub deshabilitarColumnas()
        With dgvCuentas
            .Columns("Naturaleza").ReadOnly = True
            .Columns.Item("Descripcion").ReadOnly = True
        End With
    End Sub
    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            dtCuentas.Rows.Add()
            base.ReadOnly = False
            Generales.deshabilitarBotones(ToolStrip1)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
            identificador = txtcodigo.Text
            dgvCuentas.ReadOnly = False
            deshabilitarColumnas()
        End If
    End Sub
    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btBuscar.Enabled = True
            btNuevo.Enabled = True
            PnlInfo.Visible = False
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
            Textnombredocumento.Text = objDocumentoContable.descripcion
        Else
            MsgBox("No se encontró ningún documento", MsgBoxStyle.Information)
            btBusquedaDocumento.PerformClick()
        End If
    End Sub
    Private Sub dgvCuentas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellEnter
        calcularTotales()
        If e.ColumnIndex = 4 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 5 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        deshabilitarColumnas()
    End Sub
    Private Sub dgvCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
        If e.ColumnIndex = 4 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 5 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        deshabilitarColumnas()
    End Sub
    Private Sub dgvcuentas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvCuentas.DataError
        If e.ColumnIndex = 4 Then
            For i = 0 To dgvCuentas.Rows.Count - 1
                If dgvCuentas.Rows(i).Cells(4).Value.ToString = "" Then
                    MsgBox("Por Favor ingrese un valor ", MsgBoxStyle.Exclamation)
                End If
            Next
        ElseIf e.ColumnIndex = 5 Then
            For i = 0 To dgvCuentas.Rows.Count - 1
                If dgvCuentas.Rows(i).Cells(5).Value.ToString = "" Then
                    MsgBox("Por Favor ingrese un valor ", MsgBoxStyle.Exclamation)
                End If
            Next
        End If
    End Sub
    Private Sub ocultarControles()
        textdocumento.Visible = False
        textfactura.Visible = False
        textsaldoactual.Visible = False
        tsaldon.Visible = False
        tfecha.Visible = False
        Ldoc.Visible = False
        Lfac.Visible = False
        Lsal.Visible = False
        Lnue.Visible = False
    End Sub
    Private Sub mostrarControles()
        textdocumento.Visible = True
        textfactura.Visible = True
        textsaldoactual.Visible = True
        tsaldon.Visible = True
        tfecha.Visible = True
        Ldoc.Visible = True
        Lfac.Visible = True
        Lsal.Visible = True
        Lnue.Visible = True
    End Sub
    Private Sub calcularSaldo()
        Try
            Dim valorDebito, sumaDebito, sumaCredito, valorCredito, saldoActual, saldoNuevo As Double
            If textsaldoactual.Visible = True Then
                saldoActual = textsaldoactual.Text
            End If
            If dgvCuentas.Rows.Count > 1 Then

                For indicedgvCuentas = 0 To dgvCuentas.Rows.Count - 1
                    If dgvCuentas.Rows(indicedgvCuentas).Cells("Descripcion").Value.ToString <> "" Then
                        sumaDebito = CDbl(dgvCuentas.Rows(indicedgvCuentas).Cells(4).Value)
                        sumaCredito = CDbl(dgvCuentas.Rows(indicedgvCuentas).Cells(5).Value)
                        valorDebito = valorDebito + sumaDebito
                        valorCredito = valorCredito + sumaCredito

                        If dgvCuentas.Rows(indicedgvCuentas).Cells(1).Value.ToString.StartsWith("22") And dgvCuentas.Rows(indicedgvCuentas).Cells(4).Value <> 0 Then
                            saldoNuevo = CDbl(saldoActual) - valorDebito
                            saldoNuevo = CDbl(saldoNuevo).ToString("C2")
                        ElseIf dgvCuentas.Rows(indicedgvCuentas).Cells(1).Value.ToString.StartsWith("22") And dgvCuentas.Rows(indicedgvCuentas).Cells(5).Value <> 0 Then
                            saldoNuevo = CDbl(saldoActual) + valorCredito
                            saldoNuevo = CDbl(saldoNuevo).ToString("C2")
                        ElseIf dgvCuentas.Rows(indicedgvCuentas).Cells(1).Value.ToString.StartsWith("22") And dgvCuentas.Rows(indicedgvCuentas).Cells(4).Value = 0 And dgvCuentas.Rows(indicedgvCuentas).Cells(5).Value = 0 Then
                            saldoNuevo = CDbl(saldoActual)
                            saldoNuevo = CDbl(saldoNuevo).ToString("C2")
                        End If
                    End If
                Next
                textdiferencia.Text = FormatCurrency((CDbl(valorDebito) - CDbl(valorCredito)), 2)
                textvalordebito.Text = CDbl(valorDebito).ToString("C2")
                textvalorcredito.Text = CDbl(valorCredito).ToString("C2")
                tsaldon.Text = CDbl(saldoNuevo).ToString("C2")
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub calcularTotales()
        Try
            Dim valorDebito, sumaDebito, sumaCredito, valorCredito As Double
            dgvCuentas.EndEdit()

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
            Throw ex
        End Try
    End Sub
    Private Function validarInformacion() As Boolean
        dgvCuentas.EndEdit()
        If textCodigoCliente.Text = "" Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por Favor Elija el proveedor")
            bttercero.Focus()
        ElseIf (textdiferencia.Text) = "" Then
            EstiloMensajes.mostrarMensajeAdvertencia("No ha escogido la factura a editar")
            dgvComprobantes.Focus()
        ElseIf CDbl(textdiferencia.Text) <> 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por Favor Corrija el movimiento, los saldos debito y credito no son iguales")
            dgvCuentas.Focus()
        ElseIf CDbl(textvalorcredito.Text) = 0 Or CDbl(textvalordebito.Text) = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por favor corrija el movimiento, los saldos debito y credito no son iguales o estan en cero")
            dgvCuentas.Focus()
        ElseIf FuncionesContables.validardgv(dtCuentas) = False Then

        ElseIf FuncionesContables.verificarFecha(fechadoc.Value) Then
            mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.Red)
        Else
            mostrarInfo(Nothing, Nothing, Nothing, True)
            PnlInfo.Visible = False
            Return True
        End If
        Return False
    End Function
    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarInformacion() Then
            codigoPuc = FuncionesContables.obtenerPucActivo()
            calcularTotales()
            calcularSaldo()
            dgvCuentas.EndEdit()
            dtCuentas.AcceptChanges()
            Dim objNotaProveedorBll As New NotaProveedorBLL
            Try
                objNotaProveedorBll.guardarNotaProveedor(crearNotaProveedor(), SesionActual.idUsuario)
                Generales.habilitarBotones(ToolStrip1)
                dtComprobantes.Clear()
                llenardgvCuentas(txtcodigo.Text)
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub
    Public Function crearNotaProveedor() As NotaProveedor
        Dim objNotaProveedor As New NotaProveedor
        Dim valorDebito, valorCredito As Double
        valorDebito = textvalordebito.Text
        valorCredito = textvalorcredito.Text
        objNotaProveedor.codigoDocumento = codigoDocumento
        objNotaProveedor.comprobante = txtcodigo.Text
        objNotaProveedor.idProveedor = idTercero
        objNotaProveedor.fechaRecibo = fechadoc.Value
        objNotaProveedor.identificador = identificador
        objNotaProveedor.valorDebito = valorDebito
        objNotaProveedor.valorCredito = valorCredito
        objNotaProveedor.valorCredito = valorDebito
        Dim Index As Integer = 0
        For Each drFila As DataRow In dtCuentas.Rows
            If drFila.Item("Cuenta").ToString <> "" Then
                Dim drCuenta As DataRow = objNotaProveedor.dtCuentas.NewRow
                drCuenta.Item("comprobante") = txtcodigo.Text
                drCuenta.Item("comprobanteA") = textdocumento.Text
                drCuenta.Item("codigo_puc") = codigoPuc
                drCuenta.Item("codigoCuenta") = drFila.Item("Cuenta")
                drCuenta.Item("debito") = drFila.Item("debito")
                drCuenta.Item("credito") = drFila.Item("credito")
                drCuenta.Item("orden") = Index
                objNotaProveedor.dtCuentas.Rows.Add(drCuenta)
                Index += 1
            End If
        Next
        Return objNotaProveedor
    End Function
    Private Sub formNotaProveedor_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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
                    Else
                        EstiloMensajes.mostrarMensajeAdvertencia("la cantidad base no puede ser cero")
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
                    dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(3) = txtTotal.Text
                End If
                base.Text = ""
                txtTotal.Text = ""
                dgvCuentas.Focus()
            End If

        End If
    End Sub

End Class