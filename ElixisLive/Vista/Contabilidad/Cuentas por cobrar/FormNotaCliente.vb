﻿Public Class FormNotaCliente
    Dim dtCuentas As New DataTable
    Dim identificador As String
    Dim codigoPuc, codigoDocumento, idTercero As Integer
    Private Sub FormNotaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
        llenarDtCuentas()
        codigoPuc = FuncionesContables.obtenerPucActivo()
        Generales.deshabilitarControles(Me)
        codigoDocumento = Constantes.NOTAS_DE_VENTAS
    End Sub
    Private Sub FormNotaCliente_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox(MensajeSistema.SALIR, MsgBoxStyle.Question + MsgBoxStyle.YesNo, TitulosForm.SALIR) = MsgBoxResult.Yes Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub formatoDgv()
        dgvCuentas.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCuentas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        dgvCuentas.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        dgvCuentas.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
    End Sub
    Private Sub llenarDtCuentas()
        Dim factura, cuenta, descripcion, naturaleza, debito, credito As New DataColumn

        factura.ColumnName = "Factura"
        factura.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(factura)

        cuenta.ColumnName = "Cuenta"
        cuenta.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(cuenta)

        descripcion.ColumnName = "Descripcion"
        descripcion.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(descripcion)

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
            .Columns("Factura").ReadOnly = True
            .Columns("Factura").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Factura").DataPropertyName = "Factura"
            .Columns("Factura").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("Cuenta").ReadOnly = True
            .Columns("Cuenta").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Cuenta").DataPropertyName = "Cuenta"
            .Columns("Cuenta").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns("Descripcion").ReadOnly = True
            .Columns("Descripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Descripcion").DataPropertyName = "Descripcion"
            .Columns("Descripcion").HeaderText = "Descripción"
            .Columns("Debito").ReadOnly = True
            .Columns("Debito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Debito").DataPropertyName = "Debito"
            .Columns("Credito").ReadOnly = True
            .Columns("Credito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Credito").DataPropertyName = "Credito"
            .Columns("anular").ReadOnly = True
            .Columns("anular").DisplayIndex = CInt(dgvCuentas.ColumnCount - 1)
        End With
        dgvCuentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        dgvCuentas.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
    End Sub

    Private Sub dgvcuentas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellEndEdit
        If e.RowIndex > 0 Then

            If dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(1).ToString <> "" Then
                Dim params As New List(Of String)
                params.Add(codigoPuc)
                params.Add(dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(1).ToString)

                Dim fila As DataRow
                fila = FuncionesContables.digitarCuenta(params)
                If Not IsNothing(fila) Then
                    If dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(1).ToString <> "" And dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(2).ToString = "" Then
                        dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(2) = fila(2)
                        dtCuentas.Rows(dtCuentas.Rows.Count - 1).Item("factura") = dtCuentas.Rows(dgvCuentas.CurrentRow.Index - 1).Item("factura").ToString.Trim()
                        dtCuentas.Rows.Add()
                    Else
                        dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(2) = fila(2)
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
                    Dim filaRetencion As DataRow
                    filaRetencion = FuncionesContables.llenarRetencion(params)
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
                dtCuentas.AcceptChanges()

            End If
            formatoDgv()
        End If

    End Sub
    Private Sub cargaCuentaCliente(idCliente As Integer)
        Dim params As New List(Of String)
        params.Add(idCliente)
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

    Private Sub llenardgvCuentas(pCodigo As String)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtcodigo.Text = pCodigo
        Generales.llenarTabla(Consultas.NOTAS_CLIENTE_DETALLE_CARGAR, params, dtCuentas)
        formatoDgv()

        If dtCuentas.Rows.Count > 0 Then
            calcularTotales()
        Else
            textdiferencia.Text = FormatCurrency(0, 2)
        End If
    End Sub
    Private Sub bttercero_Click(sender As Object, e As EventArgs) Handles bttercero.Click
        Dim params As New List(Of String)
        params.Add("")
        Generales.buscarElemento(Consultas.BUSQUEDA_CLIENTES,
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
        Generales.llenarTabla(Consultas.NOTA_CLIENTE_CARGAR, params, dt)
        If dt.Rows.Count > 0 Then
            Textsigla.Text = Constantes.SIGLA_NOTA_CLIENTE
            cargarDocumento(Textsigla.Text)
            fechadoc.Value = dt.Rows(0).Item("Fecha_Recibo").ToString()
            textnombreproveedor.Text = dt.Rows(0).Item("Tercero").ToString()
            textCodigoCliente.Text = dt.Rows(0).Item("Nit").ToString()
            textObservacion.Text = dt.Rows(0).Item("detalle_mov").ToString()
            idTercero = dt.Rows(0).Item("Id_cliente").ToString()
            llenardgvCuentas(pCodigo)

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
        Generales.buscarElemento(Consultas.NOTA_CLIENTE_BUSCAR,
                           Nothing,
                           AddressOf cargarDatos,
                           TitulosForm.BUSQUEDA_NOTA_CLIENTE,
                           False, True)

    End Sub
    Private Sub dgvcuentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellDoubleClick
        Dim params As New List(Of String)
        Dim paramsFac As New List(Of String)
        params.Add(codigoPuc)
        params.Add("")
        paramsFac.Add(idTercero)

        Try
            If btRegistrar.Enabled = False Then
                Exit Sub
            End If

            If dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("factura").Selected = True Then
                Generales.busquedaItems(Consultas.FACTURAS_NOTA_CLIENTE_BUSCAR, paramsFac, TitulosForm.BUSQUEDA_FACTURAS, dgvCuentas, dtCuentas, 0, 3, 0, 0, True, 0, 1)
            ElseIf dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Cuenta").Selected = True And dgvCuentas.Rows.Count > 1 And e.RowIndex > 0 Then
                Generales.busquedaItems(Consultas.BUSQUEDA_CUENTAS_DETALLE_PUC, params, TitulosForm.BUSQUEDA_CUENTAS_PUC, dgvCuentas, dtCuentas, 1, 2, 0, 0, 0, 0, 1)
                dtCuentas.Rows(dtCuentas.Rows.Count - 2).Item("factura") = dtCuentas.Rows(dgvCuentas.CurrentRow.Index - 1).Item("factura").ToString.Trim()
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
            formatoDgv()
        Catch ex As Exception
            Throw ex
        End Try
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
            dtCuentas.Clear()
            dtCuentas.Rows.Add()
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
        If dgvCuentas.CurrentCell.ColumnIndex = 5 Or dgvCuentas.CurrentCell.ColumnIndex = 4 Or dgvCuentas.CurrentCell.ColumnIndex = 1 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.limpiarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        codigoDocumento = Constantes.NOTAS_DE_VENTAS
        txtcodigo.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        Textsigla.Text = Constantes.SIGLA_NOTA_CLIENTE
        Textsigla_Leave(sender, e)
        dtCuentas.Rows.Add()
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        identificador = String.Empty
        bttercero.Focus()
        textvalorcredito.Text = FormatCurrency(0, 2)
        textvalordebito.Text = FormatCurrency(0, 2)
        textdiferencia.Text = FormatCurrency(0, 2)
        PnlInfo.Visible = False
        bloquearCloumnas()
        fechadoc.Enabled = True
    End Sub
    Private Sub bloquearCloumnas()
        With dgvCuentas
            .Columns("Factura").ReadOnly = True
            .Columns("Cuenta").ReadOnly = False
            .Columns("Descripcion").ReadOnly = True
        End With
    End Sub
    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            identificador = txtcodigo.Text
            dtCuentas.Rows.Add()
            bttercero.Enabled = False
            base.ReadOnly = False
            Generales.deshabilitarBotones(ToolStrip1)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
            dgvCuentas.ReadOnly = False
            bloquearCloumnas()
            fechadoc.Enabled = True
            textObservacion.ReadOnly = False
        End If

    End Sub
    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        Generales.deshabilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        btBuscar.Enabled = True
        btNuevo.Enabled = True
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
        End If
    End Sub

    Private Sub base_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles base.KeyPress, txtPorcentaje.KeyPress
        ValidacionDigitacion.validarSoloNumerosPositivo(e)
    End Sub
    Private Sub dgvCuentas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellEnter
        calcularTotales()
        If e.ColumnIndex = 4 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 5 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        bloquearCloumnas()
    End Sub

    Private Sub btCuentas_Click(sender As Object, e As EventArgs)
        Dim formCuenta As New FormCuentasPuc
        formCuenta.ShowDialog()
    End Sub

    Private Sub dgvCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
        If e.ColumnIndex = 4 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 5 Then
            FuncionesContables.ValidarCreditoDebito(dgvCuentas, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        bloquearCloumnas()
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
    Private Sub calcularTotales()
        Try
            Dim valorDebito, sumaDebito, sumaCredito, valorCredito As Double
            If dgvCuentas.Rows.Count > 1 Then
                For indicedgvCartera = 0 To dgvCuentas.Rows.Count - 1
                    If dgvCuentas.Rows(indicedgvCartera).Cells("Descripcion").Value.ToString <> "" Then
                        sumaDebito = CDbl(dgvCuentas.Rows(indicedgvCartera).Cells(4).Value)
                        sumaCredito = CDbl(dgvCuentas.Rows(indicedgvCartera).Cells(5).Value)
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

    Private Sub dgvcuentas_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvCuentas.KeyDown
        Dim params As New List(Of String)
        params.Add(codigoPuc)
        params.Add("")
        If btRegistrar.Enabled = False Then
            Exit Sub
        End If
        If e.KeyCode = Keys.F3 And dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Factura").Selected = True Then
            Generales.busquedaItems(Consultas.FACTURAS_NOTA_CLIENTE_BUSCAR, params, TitulosForm.BUSQUEDA_CUENTAS_PUC, dgvCuentas, dtCuentas, 0, 3, 0, 0, 0, 0, 1)
        ElseIf e.KeyCode = Keys.F3 And dgvCuentas.Rows(dgvCuentas.CurrentCell.RowIndex).Cells("Cuenta").Selected = True Then
            Generales.busquedaItems(Consultas.BUSQUEDA_CUENTAS_DETALLE_PUC, params, TitulosForm.BUSQUEDA_CUENTAS_PUC, dgvCuentas, dtCuentas, 1, 2, 0, 0, 0, 0, 1)
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
        formatoDgv()
    End Sub
    Private Function validarInformacion() As Boolean
        dgvCuentas.EndEdit()
        If textCodigoCliente.Text = "" Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por favor elija el cliente")
            bttercero.Focus()
            Return False
        ElseIf CDbl(textdiferencia.Text) <> 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por favor corrija el movimiento, los saldos debito y credito no son iguales")
            dgvCuentas.Focus()
            Return False
        ElseIf CDbl(textvalorcredito.Text) = 0 Or CDbl(textvalordebito.Text) = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por favor corrija el movimiento, los saldos debito y credito no son iguales o estan en cero")
            dgvCuentas.Focus()
            Return False
        ElseIf FuncionesContables.validardgv(dtCuentas) = False Then
            Return False
        End If
        If FuncionesContables.verificarFecha(fechadoc.Value) Then
            mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.Red)
            Return False
        Else
            mostrarInfo(Nothing, Nothing, Nothing, True)
            PnlInfo.Visible = False
        End If
        Return True
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarInformacion() Then
            calcularTotales()
            dgvCuentas.EndEdit()
            dtCuentas.AcceptChanges()
            Dim objNotaClienteBll As New NotaClienteBLL
            Try
                objNotaClienteBll.guardarNotaCliente(crearNotaCliente(), SesionActual.idUsuario)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btRegistrar.Enabled = False
                btCancelar.Enabled = False
                llenardgvCuentas(txtcodigo.Text)
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub
    Public Function crearNotaCliente() As NotaCliente
        Dim objNotaCliente As New NotaCliente
        Dim valorDebito, valorCredito As Double
        valorDebito = textvalordebito.Text
        valorCredito = textvalorcredito.Text
        codigoPuc = FuncionesContables.obtenerPucActivo()
        codigoDocumento = Constantes.NOTAS_DE_VENTAS
        objNotaCliente.codigoDocumento = codigoDocumento
        objNotaCliente.comprobante = txtcodigo.Text
        objNotaCliente.idCliente = idTercero
        objNotaCliente.fechaRecibo = fechadoc.Value
        objNotaCliente.detalleMov = textObservacion.Text
        objNotaCliente.identificador = identificador
        objNotaCliente.valorDebito = valorDebito
        objNotaCliente.valorCredito = valorCredito
        Dim Index As Integer = 0
        For Each drFila As DataRow In dtCuentas.Rows
            If drFila.Item("Cuenta").ToString <> "" Then
                Dim drCuenta As DataRow = objNotaCliente.dtCuentas.NewRow
                drCuenta.Item("comprobante") = txtcodigo.Text
                drCuenta.Item("codigo_Factura") = drFila.Item("Factura")
                drCuenta.Item("codigo_puc") = codigoPuc
                drCuenta.Item("codigoCuenta") = drFila.Item("Cuenta")
                drCuenta.Item("debito") = drFila.Item("debito")
                drCuenta.Item("credito") = drFila.Item("credito")
                drCuenta.Item("orden") = Index
                objNotaCliente.dtCuentas.Rows.Add(drCuenta)
                Index += 1
            End If
        Next
        Return objNotaCliente
    End Function
    Private Sub formNotaCliente_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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
                        MsgBox("la cantidad base no puede ser cero", MsgBoxStyle.Exclamation)
                        base.Focus()
                    End If
                Else
                    MsgBox("Digite cantidad base", MsgBoxStyle.Exclamation)
                    base.Focus()
                End If
            ElseIf txttotal.Focused() = True Then
                Panel3.Visible = False
                dgvCuentas.Enabled = True
                bttercero.Enabled = True
                ToolStrip1.Enabled = True
                If base.Text <> "" Then

                    dtCuentas.Rows(dgvCuentas.CurrentRow.Index).Item(4) = txtTotal.Text
                End If

                base.Text = ""
                txtTotal.Text = ""
                dgvCuentas.Focus()
            End If

        End If
    End Sub
End Class