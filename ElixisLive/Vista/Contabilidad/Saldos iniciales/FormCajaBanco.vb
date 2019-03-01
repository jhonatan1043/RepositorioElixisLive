Public Class FormCajaBanco
    Dim dtCuentas As New DataTable
    Dim identificador As String
    Dim codigoPuc, codigoDocumento As Integer
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
    Private Sub fechadoc_Leave(sender As Object, e As EventArgs) Handles fechadoc.Leave
        FuncionesContables.validarFechaFutura(fechadoc)
    End Sub
    Private Function valiadarInformacion() As Boolean
        If FuncionesContables.verificarFecha(fechadoc.Value) Then
            mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.Red)
            Return False
        Else
            mostrarInfo(Nothing, Nothing, Nothing, True)
            PnlInfo.Visible = False
        End If
        If dtCuentas.Rows.Count <= 1 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Corrija el movimiento, debe agregar una cuenta")
            Return False
        End If
        If FuncionesContables.validarFechaFutura(fechadoc) = False Then
            Return False
        End If
        Return True
    End Function
    Private Sub dgvCuentas_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvcuentas.CellFormatting
        If e.ColumnIndex = 3 Or e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), "c2")
            Else
                e.Value = Format(Val(e.Value), "c2")
            End If
        End If

    End Sub
    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If valiadarInformacion() Then
            If FuncionesContables.validarDatosDgv(dgvcuentas, 1) Then

                If FuncionesContables.validardgv(dtCuentas) Then
                    codigoPuc = FuncionesContables.obtenerPucActivo()

                    Dim objcajaBanco_D As New CajaBancoBLL
                    Try
                        objcajaBanco_D.guardarCajaBanco(crearCajaBanco(), SesionActual.idUsuario)
                        Generales.habilitarBotones(ToolStrip1)
                        Generales.deshabilitarControles(Me)
                        btRegistrar.Enabled = False
                        btCancelar.Enabled = False
                        llenardgv(txtcodigo.Text)
                    Catch ex As Exception
                        EstiloMensajes.mostrarMensajeError(ex.Message)
                    End Try
                End If
            End If
        End If
    End Sub
    Private Sub llenardgv(pCodigo As String)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtcodigo.Text = pCodigo
        Generales.llenarTabla(Consultas.CAJA_BANCO_CARGAR_CUENTAS, params, dtCuentas)
    End Sub
    Private Sub cargarDocumento(codigo As String)
        Dim objDocumentoContable As DocumentoContable = FuncionesContables.cargarDocumento(codigo)
        If objDocumentoContable IsNot Nothing Then
            codigoDocumento = objDocumentoContable.codigo
            Textsigla.Text = codigo
            Textnombredocumento.Text = objDocumentoContable.descripcion
        End If
    End Sub
    Public Function crearCajaBanco() As CajaBanco
        Dim objCajaBanco As New CajaBanco
        If String.IsNullOrEmpty(identificador) Then
            txtcodigo.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        End If
        objCajaBanco.identificador = identificador
        objCajaBanco.codigoDocumento = codigoDocumento
        objCajaBanco.comprobante = txtcodigo.Text
        objCajaBanco.idTercero = SesionActual.codigoEmpresa
        objCajaBanco.fechaRecibo = fechadoc.Value
        objCajaBanco.detalleMov = Textdetalle.Text

        Dim index As Integer = 0
        For Each drFila As DataRow In dtCuentas.Rows
            If drFila.Item("codigoCuenta").ToString <> "" Then
                Dim drCuenta As DataRow = objCajaBanco.dtCuentas.NewRow
                drCuenta.Item("comprobante") = objCajaBanco.comprobante
                drCuenta.Item("codigo_puc") = codigoPuc
                drCuenta.Item("codigoCuenta") = drFila.Item("codigoCuenta")
                drCuenta.Item("debito") = drFila.Item("debito")
                drCuenta.Item("credito") = drFila.Item("credito")
                drCuenta.Item("orden") = index
                objCajaBanco.dtCuentas.Rows.Add(drCuenta)
                index += 1
            End If
        Next
        Return objCajaBanco
    End Function
    Private Sub bloquearColumnas()
        With dgvcuentas
            .Columns.Item("Nombre").ReadOnly = True
        End With
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.limpiarControles(Me)
        dtCuentas.Rows.Add()
        txtcodigo.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        Textsigla.Focus()
        Textsigla.Text = Constantes.SIGLA_SALDOS_INICIALES
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        dgvcuentas.Focus()
        identificador = String.Empty
        bloquearColumnas()
        PnlInfo.Visible = False
    End Sub
    Private Sub cargarDatos(pCodigo)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add(pCodigo)
        Generales.llenarTabla(Consultas.CAJA_BANCO_CARGAR, params, dt)
        Textsigla.Text = Constantes.SIGLA_SALDOS_INICIALES
        cargarDocumento(Textsigla.Text)
        txtcodigo.Text = pCodigo
        Textdetalle.Text = dt.Rows(0).Item("detalle_mov").ToString()
        fechadoc.Value = dt.Rows(0).Item("Fecha_Recibo").ToString()
        llenardgv(txtcodigo.Text)
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
    End Sub

    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Generales.buscarElemento(Consultas.CAJA_BANCO_BUSCAR,
                                   Nothing,
                                   AddressOf cargarDatos,
                                   TitulosForm.BUSQUEDA_CAJA_BANCO,
                                   False, True)
    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            identificador = txtcodigo.Text
            dtCuentas.Rows.Add()
            bloquearColumnas()
            Generales.deshabilitarBotones(ToolStrip1)
            dgvcuentas.ReadOnly = False
            bloquearColumnas()
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
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

    Private Sub dgvcuentas_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvcuentas.EditingControlShowing,
            dgvcuentas.EditingControlShowing
        If dgvcuentas.CurrentCell.ColumnIndex = 3 Or dgvcuentas.CurrentCell.ColumnIndex = 5 Or dgvcuentas.CurrentCell.ColumnIndex = 1 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub
    Private Sub dgvCuentas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcuentas.CellEnter
        If e.ColumnIndex = 2 Then
            FuncionesContables.ValidarCreditoDebito(dgvcuentas, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 4 Then
            FuncionesContables.ValidarCreditoDebito(dgvcuentas, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        bloquearColumnas()
    End Sub

    Private Sub dgvCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcuentas.CellClick
        If e.ColumnIndex = 3 Then
            FuncionesContables.ValidarCreditoDebito(dgvcuentas, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 5 Then
            FuncionesContables.ValidarCreditoDebito(dgvcuentas, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        bloquearColumnas()
    End Sub
    Private Function digitarCuenta(params As List(Of String)) As DataRow
        Dim params2 As New List(Of String)
        params2.Add("")
        params.Add(dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item(0).ToString)
        Dim consulta As String
        Dim drCuenta As DataRow
        If Rcaja.Checked = True Then
            consulta = Consultas.CUENTAS_CAJA_BUSCAR
        Else
            consulta = Consultas.CUENTAS_BANCO_BUSCAR
        End If
        drCuenta = Generales.cargarItem(consulta, params2)
        If Not IsNothing(drCuenta) Then
            Return drCuenta
        Else
            EstiloMensajes.mostrarMensajeAdvertencia("Cuenta inválida")
        End If
        Return Nothing
    End Function
    Private Sub dgvcuentas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcuentas.CellEndEdit
        If e.ColumnIndex = 1 Then
            If dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item(0).ToString <> "" Then
                Dim params As New List(Of String)
                params.Add(codigoPuc)
                params.Add(dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item(0).ToString)

                Dim fila As DataRow
                fila = digitarCuenta(params)
                If Not IsNothing(fila) Then

                    dtCuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Item("Estado") = Constantes.ITEM_NUEVO
                    If dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item(0).ToString <> "" And dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item(1).ToString = "" Then
                        dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item(1) = fila(1)
                        dtCuentas.Rows.Add()
                    Else
                        dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item(1) = fila(1)
                    End If
                Else
                    dgvcuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Cells("codigoCuenta").Value = String.Empty
                    dgvcuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Cells("nombre").Value = String.Empty
                End If

            End If

            If dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item("Debito").ToString = "" Then
                dgvcuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Cells("Debito").Value = 0
            ElseIf dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item("Credito").ToString = "" Then
                dgvcuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Cells("Credito").Value = 0
            End If
            dtCuentas.AcceptChanges()
        End If

    End Sub
    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub Rbanco_CheckedChanged(sender As Object, e As EventArgs) Handles Rbanco.CheckedChanged
        dtCuentas.Clear()
        dtCuentas.Rows.Add()
    End Sub

    Private Sub Rcaja_CheckedChanged(sender As Object, e As EventArgs) Handles Rcaja.CheckedChanged
        dtCuentas.Clear()
        dtCuentas.Rows.Add()
    End Sub
    Private Sub Textsigla_Leave(sender As Object, e As EventArgs) Handles Textsigla.Leave
        If Textsigla.Text <> "" Then
            cargarDocumento(Textsigla.Text)
            txtcodigo.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        End If
    End Sub
    Private Sub Form_CajaBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlazarTabla()
        Generales.deshabilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        btBuscar.Enabled = True
        btNuevo.Enabled = True
        Generales.asignarPermiso(Me)
        codigoDocumento = Constantes.SALDOS_INICIALES
    End Sub
    Private Sub enlazarTabla()

        Dim A1, A2, A3, A4, A5, A6 As New DataColumn

        A1.ColumnName = "codigoCuenta"
        A1.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(A1)

        A2.ColumnName = "Nombre"
        A2.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(A2)

        A3.ColumnName = "Debito"
        A3.DataType = Type.GetType("System.Double")
        A3.DefaultValue = "0,00"
        dtCuentas.Columns.Add(A3)

        A6.ColumnName = "Estado"
        A6.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(A6)

        A4.ColumnName = "Credito"
        A4.DataType = Type.GetType("System.Double")
        A4.DefaultValue = "0,00"
        dtCuentas.Columns.Add(A4)

        A5.ColumnName = "orden"
        A5.DataType = Type.GetType("System.Int32")
        dtCuentas.Columns.Add(A5)

        With dgvcuentas

            .Columns.Item("codigoCuenta").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("codigoCuenta").DataPropertyName = "codigoCuenta"

            .Columns.Item("nombre").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("nombre").DataPropertyName = "Nombre"
            .Columns.Item("nombre").ReadOnly = True

            .Columns.Item("debito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("debito").DataPropertyName = "Debito"
            .Columns.Item("debito").ReadOnly = False

            .Columns.Item("estado").DataPropertyName = "Estado"
            .Columns.Item("estado").HeaderText = "Estado"
            .Columns.Item("estado").Visible = False

            .Columns.Item("credito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("credito").DataPropertyName = "Credito"
            .Columns.Item("credito").ReadOnly = False

            .Columns.Item("orden").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("orden").DataPropertyName = "orden"
            .Columns.Item("orden").Visible = False

            .Columns.Item("anular").ReadOnly = True
            .Columns.Item("anular").Width = 80

        End With
        dgvcuentas.DataSource = dtCuentas
        dgvcuentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvcuentas.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
    End Sub
    Private Sub dgvcuentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcuentas.CellDoubleClick

        Dim consulta As String
        If Rcaja.Checked = True Then
            consulta = Consultas.CUENTAS_CAJA_BUSCAR
        Else
            consulta = Consultas.CUENTAS_BANCO_BUSCAR
        End If
        Try
            If btRegistrar.Enabled = False Then
                Exit Sub
            End If
            If (dgvcuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Cells("codigoCuenta").Selected = True Or dgvcuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Cells("Nombre").Selected = True) And dtCuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Item("Estado").ToString = "" Then
                Generales.agregarItems(consulta, TitulosForm.BUSQUEDA_CAJA_BANCO, dgvcuentas, dtCuentas)
            ElseIf dgvcuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Cells("anular").Selected = True And dtCuentas.Rows(dgvcuentas.CurrentCell.RowIndex).Item("codigoCuenta").ToString <> "" Then
                dtCuentas.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try

    End Sub
    Private Sub form_cajabanco_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) And Panel3.Visible = True Then
            Panel3.Visible = False
            base.Text = ""
            txtTotal.Text = ""
            dgvcuentas.Focus()
        ElseIf Panel3.Visible = True And e.KeyChar = Chr(13) Then
            If base.Focused() = True Then
                If base.Text <> "" Then
                    If base.Text <> 0 Then
                        txtPorcentaje.Text = Replace(txtPorcentaje.Text, ".", ",")
                        txtTotal.Text = CDbl(base.Text) * CDbl(txtPorcentaje.Text) / 100
                        txtTotal.Focus()
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
                dgvcuentas.Enabled = True

                ToolStrip1.Enabled = True
                If base.Text <> "" Then
                    If txtNaturaleza.Text = Constantes.PUC_NATURALEZA_DEBITO Then
                        dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item(3) = txtTotal.Text
                    Else
                        dtCuentas.Rows(dgvcuentas.CurrentRow.Index).Item(4) = txtTotal.Text
                    End If
                End If
                base.Text = ""
                txtTotal.Text = ""
                dgvcuentas.Focus()
            End If

        End If
    End Sub
    Private Sub dgvcuentas_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvcuentas.DataError
        If e.ColumnIndex = 2 Then
            For indice = 0 To dgvcuentas.Rows.Count - 1
                If dgvcuentas.Rows(indice).Cells(2).Value.ToString = "" Then
                    EstiloMensajes.mostrarMensajeAdvertencia("Por Favor ingrese un valor")
                End If
            Next
        ElseIf e.ColumnIndex = 4 Then
            For indice = 0 To dgvcuentas.Rows.Count - 1
                If dgvcuentas.Rows(indice).Cells(4).Value.ToString = "" Then
                    EstiloMensajes.mostrarMensajeAdvertencia("Por Favor ingrese un valor")
                End If
            Next
        End If
    End Sub
End Class