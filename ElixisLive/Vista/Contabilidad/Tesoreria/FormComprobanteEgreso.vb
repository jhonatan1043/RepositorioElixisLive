Public Class FormComprobanteEgreso
    Dim objComprobante As New PagosDirecto
    Dim codigoPuc, codigoDocumento, idTercero As Integer

    Private Sub bttercero_Click(sender As Object, e As EventArgs) Handles bttercero.Click
        Dim params As New List(Of String)
        params.Add(Nothing)
        Generales.buscarElemento(Consultas.CONTA_TERCERO_BUSCAR,
                             params,
                             AddressOf cargarTercero,
                             TitulosForm.BUSQUEDA_TERCERO,
                             True, True)
    End Sub
    Public Function muestraImagen()
        Return PictureBox1.Image
    End Function
    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub cargarTercero(pCodigoTercero As String)
        Dim drTercero As DataRow
        Dim params As New List(Of String)
        params.Add(pCodigoTercero)

        drTercero = Generales.cargarItem(Consultas.CONTA_PROVEEDOR_CARGAR, params)
        idTercero = drTercero.Item("id_Proveedor")
        textCodigoCliente.Text = drTercero.Item("Nit")
        textnombreproveedor.Text = drTercero.Item("Proveedor")
        txtfactura.Enabled = True
        textobservacion.ReadOnly = False
        objComprobante.dtComprobante.Rows.Add()
    End Sub

    Public Sub deshabilitarControles()
        bttercero.Enabled = False
    End Sub

    Public Sub habilitarControles()
        bttercero.Enabled = True
    End Sub
    Private Sub FormPagoDirecto_Load(sender As Object, e As EventArgs) Handles MyBase.Load, base.Enter
        codigoPuc = FuncionesContables.obtenerPucActivo()
        dgvComprobante.DataSource = objComprobante.dtComprobante
        dgvComprobante.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvComprobante.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
        dgvComprobante.ReadOnly = False
        dgvComprobante.Columns("descripcion").ReadOnly = True
        dgvComprobante.Columns("descripcion").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvComprobante.Columns("Comprobante causacion").Visible = False
        dgvComprobante.Columns("Comprobante causacion").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvComprobante.Columns("Codigo Factura").Visible = False
        dgvComprobante.Columns("Codigo Factura").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvComprobante.Columns("Codigo").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvComprobante.Columns("Debito").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvComprobante.Columns("Credito").SortMode = DataGridViewColumnSortMode.NotSortable
        dgvComprobante.Columns("Orden").Visible = False
        dgvComprobante.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        deshabilitarControles()
        codigoDocumento = Constantes.COMPROBANTE_DE_EGRESO
        dgvComprobante.Columns(0).DisplayIndex = 7
        PnlInfo.Visible = False
        Generales.asignarPermiso(Me)
    End Sub

    Private Sub dgvCargos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComprobante.CellDoubleClick
        If btRegistrar.Enabled = False Then
            Exit Sub
        End If
        If e.ColumnIndex = 4 Then
            Dim params As New List(Of String)
            params.Add(codigoPuc)
            params.Add("")
            If (dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Codigo").Selected = True Or dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Descripcion").Selected = True) Then
                Generales.busquedaItems(Consultas.BUSQUEDA_CUENTAS_DETALLE_PUC, params, TitulosForm.BUSQUEDA_CUENTAS_PUC, dgvComprobante, objComprobante.dtComprobante, 2, 3, 0, 0)
                objComprobante.codigoCuenta = IsDBNull(dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Codigo").Value)
                llenarRetencion(objComprobante.codigoCuenta)
            End If
        End If

        If e.ColumnIndex = 0 Then

            If Not String.IsNullOrEmpty(dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Descripcion").Value.ToString) Then
                objComprobante.dtComprobante.Rows.RemoveAt(e.RowIndex)
                calcularTotales()
            End If
        End If
    End Sub

    Public Sub calcularTotalesDgv()

        Try
            Dim valorDebito, sumaDebito, sumaCredito, valorCredito As Double

            For i = 0 To dgvComprobante.Rows.Count - 1
                If Not String.IsNullOrEmpty(Funciones.castFromDbItem(dgvComprobante.Rows(i).Cells("Codigo").Value)) Then
                    sumaDebito = CDbl(dgvComprobante.Rows(i).Cells("Debito").Value)
                    sumaCredito = CDbl(dgvComprobante.Rows(i).Cells("Credito").Value)

                    valorDebito = valorDebito + sumaDebito
                    valorCredito = valorCredito + sumaCredito
                End If
            Next
            objComprobante.diferencia = FormatCurrency((CDbl(valorDebito) - CDbl(valorCredito)), 2)
            objComprobante.debito = valorDebito
            objComprobante.credito = valorCredito
            objComprobante.retencion = FuncionesContables.sumaRetencion(codigoPuc, dgvComprobante)

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub dgvComprobante_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvComprobante.CellFormatting
        If e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), "c2")
            Else
                e.Value = Format(Val(e.Value), "c2")
            End If
        End If
    End Sub



    Private Sub dgvComprobante_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComprobante.CellEndEdit
        If dgvComprobante.CurrentCell.ColumnIndex = 4 AndAlso dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Codigo").Value.ToString.Length > 5 Then
            objComprobante.codigoCuenta = dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Codigo").Value
            FuncionesContables.verificarCuenta(dgvComprobante.CurrentCell.RowIndex, 0,
                                               objComprobante.codigoCuenta, "Codigo",
                                               "Descripcion", objComprobante.dtComprobante)
            llenarRetencion(objComprobante.codigoCuenta)

        Else
            If Not (IsDBNull(dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Codigo").Value) OrElse Not dgvComprobante.CurrentCell.ColumnIndex = 4) And
                dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Codigo").Value.ToString.Length < 5 Then
                EstiloMensajes.mostrarMensajeAdvertencia("Cuenta errada, por favor digite una cuenta válida!")
                dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Codigo").Value = ""
            End If
        End If
        dgvComprobante.Columns("Comprobante causacion").Visible = True
        dgvComprobante.Columns("Codigo Factura").Visible = True
        calcularTotales()
    End Sub

    Private Sub calcularTotales()

        objComprobante.codigoPuc = codigoPuc
        calcularTotalesDgv()
        textvalorcredito.Text = CDbl(objComprobante.credito).ToString("C2")
        textvalordebito.Text = CDbl(objComprobante.debito).ToString("C2")
        txtretencion.Text = CDbl(objComprobante.retencion).ToString("C2")
        textdiferencia.Text = CDbl(objComprobante.diferencia).ToString("C2")
    End Sub

    Private Sub llenarRetencion(pCuenta As String)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add("")
        params.Add(pCuenta)
        Generales.llenarTabla(Consultas.RETENCION_CUENTAS_RETENCION, params, dt)
        If dt.Rows.Count > 0 Then
            lblivarete.Text = dt.Rows(0).Item("cuenta").ToString()
            txtPorcentaje.Text = dt.Rows(0).Item("tasa").ToString()
            txtPorcentaje.Text = Replace(txtPorcentaje.Text, ".", ",")
            txtNaturaleza.Text = dt.Rows(0).Item("naturaleza").ToString()
            Panel3.Visible = True
            base.Focus()
            dgvComprobante.Enabled = False
            btNuevo.Enabled = False
            btBuscar.Enabled = False
            btEditar.Enabled = False
            btRegistrar.Enabled = False
            btCancelar.Enabled = True
            bttercero.Enabled = False
        End If
    End Sub
    Private Sub dgvComprobante_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvComprobante.EditingControlShowing

        If dgvComprobante.CurrentCell.ColumnIndex = 4 Or dgvComprobante.CurrentCell.ColumnIndex = 6 Or dgvComprobante.CurrentCell.ColumnIndex = 7 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click

        If Panel3.Visible = True Then
            btNuevo.Enabled = False
            Panel3.Visible = False
            dgvComprobante.Enabled = True
            dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("codigo").Value = ""
            dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Descripcion").Value = ""
            dgvComprobante.Rows.RemoveAt(dgvComprobante.CurrentCell.RowIndex)

            btEditar.Enabled = False
            btRegistrar.Enabled = True
            base.Text = ""
            txtTotal.Text = ""
            bttercero.Enabled = True
            PnlInfo.Visible = False
        Else
            If EstiloMensajes.mostrarMensajePregunta("Desea cancelar este registro") = Constantes.SI Then
                objComprobante.dtComprobante.Clear()
                btNuevo.Enabled = True
                txtcomprobante.Text = ""
                btRegistrar.Enabled = False
                btImprimir.Enabled = False
                textCodigoCliente.Text = ""
                idTercero = ""
                txtfactura.Text = ""
                textCodigoCliente.Text = ""
                bttercero.Enabled = False
                btBuscar.Enabled = True
                textobservacion.Clear()
                textvalordebito.Text = ""
                textobservacion.ReadOnly = False
                textvalorcredito.Text = ""
                textdiferencia.Text = ""
                btCancelar.Enabled = False
                PnlInfo.Visible = False
            End If
        End If
    End Sub

    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(Nothing)
        Generales.buscarElemento(Consultas.COMPROBANTE_EGRESO_BUSCAR,
                           params,
                           AddressOf cargarDatos,
                           TitulosForm.BUSQUEDA_COMPROBANTE_EGRESO,
                           False, True)

    End Sub

    Public Sub cargarDatos(pcodigo As String)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add(pcodigo)
        Generales.llenarTabla(Consultas.COMPROBANTE_EGRESO_CARGAR, params, dt)
        If dt.Rows.Count > 0 Then
            txtcomprobante.Text = pcodigo
            textobservacion.Text = dt.Rows(0).Item("Detalle movimiento").ToString
            fechaRecibo.Text = dt.Rows(0).Item("fecha recibo").ToString
            fechaDoc.Text = dt.Rows(0).Item("fecha pago").ToString
            idTercero = dt.Rows(0).Item("id tercero").ToString
            textCodigoCliente.Text = dt.Rows(0).Item("Nit").ToString
            textnombreproveedor.Text = dt.Rows(0).Item("nombre proveedor").ToString
            txtfactura.Text = dt.Rows(0).Item("entrada").ToString
            fechaDoc.Enabled = False
            fechaRecibo.Enabled = False
            objComprobante.comprobante = txtcomprobante.Text
            objComprobante.cargarComprobante()
            calcularTotales()
            dgvComprobante.Columns("Comprobante causacion").Visible = True
            dgvComprobante.Columns("Codigo Factura").Visible = True
            bttercero.Enabled = False
            If FuncionesContables.verificarFecha(fechaRecibo.Value) Then
                mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.Red)
                btEditar.Enabled = False
            Else
                mostrarInfo(Nothing, Nothing, Nothing, True)
                PnlInfo.Visible = False
                btEditar.Enabled = True
            End If
            If FuncionesContables.verificarComprobante(pcodigo) Then
                mostrarInfo(String.Format(MensajeSistema.COMPROBANTE_ANULADO), Color.White, Color.Red)
                Generales.deshabilitarBotones(ToolStrip1)
                btBuscar.Enabled = True
                btNuevo.Enabled = True
            End If
            btImprimir.Enabled = True
        End If
    End Sub
    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        objComprobante.fecha = fechaRecibo.Value.Date
        objComprobante.VerificarFecha()
        objComprobante.registroNuevo = False
        If objComprobante.periodoCerrado = False Then
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
            btEditar.Enabled = False
            Generales.habilitarControles(Me)
            dgvComprobante.Columns("Descripcion").ReadOnly = True
            dgvComprobante.Columns("Codigo Factura").ReadOnly = True
            dgvComprobante.Columns("Comprobante causacion").ReadOnly = True
            textobservacion.ReadOnly = False
            dgvComprobante.Enabled = True
            btNuevo.Enabled = False
            bttercero.Enabled = False
            fechaRecibo.Enabled = False
            fechaRecibo.Enabled = False
            btImprimir.Enabled = False
            btBuscar.Enabled = False
            txtfactura.Enabled = True
            objComprobante.dtComprobante.Rows.Add()
            mostrarInfo(Nothing, Nothing, Nothing, True)
        Else
            mostrarInfo(String.Format(objComprobante.mensaje), Color.White, Color.Red)
            btRegistrar.Enabled = False
            btEditar.Enabled = True
            btNuevo.Enabled = True
            fechaRecibo.Enabled = False
            fechaRecibo.Enabled = False
            txtfactura.Enabled = False
            textobservacion.Enabled = False
            btCancelar.Enabled = False
            dgvComprobante.Enabled = False
            bttercero.Enabled = False
        End If
    End Sub
    Private Sub base_KeyPress(sender As Object, e As KeyPressEventArgs) Handles base.KeyPress
        ValidacionDigitacion.validarValoresNumericos(e)
    End Sub

    Public Function validarControles()
        dgvComprobante.EndEdit()

        Dim vDebito, vCredito As Double
        vDebito = CDbl(textvalorcredito.Text)
        vCredito = CDbl(textvalordebito.Text)
        If textCodigoCliente.Text = "" Then
            EstiloMensajes.mostrarMensajeAdvertencia("Debe seleccionar un tercero")
            bttercero.Focus()
            Return False
        ElseIf txtfactura.Text = "" Then
            EstiloMensajes.mostrarMensajeAdvertencia("El campo factura se encuentra vacio")
            txtfactura.Focus()
            Return False
        ElseIf textobservacion.Text = "" Then
            EstiloMensajes.mostrarMensajeAdvertencia("El campo detalle del movimiento se encuentra vacio")
            textobservacion.Focus()
            Return False
        ElseIf CDbl(textdiferencia.Text) <> 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por favor corrija el movimiento, los saldos debito y credito no son iguales")
            dgvComprobante.Focus()
            Return False
        ElseIf vCredito = 0 Or vDebito = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Por favor corrija el movimiento, los saldos debito y credito no son iguales o estan en cero")
            dgvComprobante.Focus()
            Return False
        ElseIf FuncionesContables.validardgv(objComprobante.dtComprobante) = False Then
            Return False
        End If
        Return True
    End Function

    Public Sub guardarComprobante()
        dgvComprobante.EndEdit()

        Try

            objComprobante.fecha = fechaRecibo.Value.Date
            objComprobante.VerificarFecha()

            If objComprobante.periodoCerrado = False Then
                If (objComprobante.registroNuevo) Then
                    txtcomprobante.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
                End If
                objComprobante.comprobante = txtcomprobante.Text
                objComprobante.fecha = fechaRecibo.Value.Date
                objComprobante.fecharec = fechaRecibo.Value.Date
                objComprobante.movimiento = textobservacion.Text
                objComprobante.usuario = SesionActual.idUsuario
                objComprobante.documento = Constantes.COMPROBANTE_DE_EGRESO
                objComprobante.entrada = txtfactura.Text
                objComprobante.idtercero = idTercero
                objComprobante.guardar()
                If objComprobante.registroNuevo = True Then
                    FuncionesContables.aumentarConsecutivo(codigoDocumento)
                End If
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
                btRegistrar.Enabled = False
                btEditar.Enabled = True
                btBuscar.Enabled = True
                btImprimir.Enabled = True
                objComprobante.cargarComprobante()
                calcularTotales()
                btNuevo.Enabled = True
                btCancelar.Enabled = False
                Generales.deshabilitarControles(Me)
                dgvComprobante.Enabled = False
            Else
                mostrarInfo(String.Format(objComprobante.mensaje), Color.White, Color.Red)
                btRegistrar.Enabled = False
                btBuscar.Enabled = True
                btEditar.Enabled = False
                btCancelar.Enabled = False
                dgvComprobante.Enabled = False
                fechaRecibo.Enabled = False
                txtfactura.Enabled = False
                fechaRecibo.Enabled = False
                bttercero.Enabled = False
                textobservacion.Enabled = False
                btNuevo.Enabled = True
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarControles() Then
            guardarComprobante()
        End If
    End Sub

    Private Sub base_KeyDown(sender As Object, e As KeyEventArgs) Handles base.KeyDown
        If e.KeyCode = 13 Then
            If Panel3.Visible = True Then
                If base.Focused = True And base.Text <> "" Then
                    txtPorcentaje.Text = Replace(txtPorcentaje.Text, ".", ",")
                    txtTotal.Text = CDbl(base.Text) * CDbl(txtPorcentaje.Text) / 100
                    txtTotal.Focus()
                Else
                    EstiloMensajes.mostrarMensajeAdvertencia("Digite cantidad base")
                    base.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btimprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        imprimir()

    End Sub

    Public Sub imprimir()
        Dim nombreArchivo, ruta, formula, nombreReporte As String
        Dim reporte As New CrearInforme
        Dim params As New List(Of String)
        Try
            nombreReporte = "Comprobante egreso"

            Cursor = Cursors.WaitCursor

            nombreArchivo = nombreReporte & Constantes.NOMBRE_PDF_SEPARADOR & txtcomprobante.Text & Constantes.EXTENSION_ARCHIVO_PDF
            ruta = IO.Path.GetTempPath() & nombreReporte

            formula = "{VISTA_COMPROBANTE_EGRESO.Comprobante} = " & txtcomprobante.Text

            reporte.crearReportePDF(New rptComprobanteEgreso, txtcomprobante.Text, formula, nombreReporte, IO.Path.GetTempPath(),,, params)

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub dgvComprobante_CellEnter_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvComprobante.CellEnter
        dgvComprobante.EndEdit()
        calcularTotales()
    End Sub

    Private Sub total_KeyDown(sender As Object, e As KeyEventArgs) Handles txtTotal.KeyDown
        If e.KeyCode = 13 Then
            If txtNaturaleza.Text = "D" Then
                dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Credito").Value = txtTotal.Text
            Else
                dgvComprobante.Rows(dgvComprobante.CurrentCell.RowIndex).Cells("Debito").Value = txtTotal.Text
            End If
            Panel3.Visible = False
            dgvComprobante.Enabled = True
            btRegistrar.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub

    Private Sub dgvComprobante_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvComprobante.DataError

    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.limpiarControles(Me)
        txtcomprobante.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        objComprobante.dtComprobante.Clear()
        Generales.habilitarControles(Me)
        dgvComprobante.Columns("Descripcion").ReadOnly = True
        dgvComprobante.Columns("Comprobante causacion").Visible = False
        dgvComprobante.Columns("Codigo Factura").Visible = False
        Generales.habilitarBotones(ToolStrip1)
        PnlInfo.Visible = False
        objComprobante.registroNuevo = True
        objComprobante.fecha = fechaRecibo.Value.Date
        objComprobante.VerificarFecha()
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
End Class