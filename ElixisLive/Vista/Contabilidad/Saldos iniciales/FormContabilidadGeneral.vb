﻿Public Class FormContabilidadGeneral
    Dim dtCuentas As New DataTable
    Dim identificador As String
    Dim codigoPuc, codigoDocumento As Integer

    Private Sub Form_Contabilidad_General_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlazarTabla()
        Generales.deshabilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.asignarPermiso(Me)
        codigoDocumento = Constantes.SALDOS_INICIALES
        btNuevo.Enabled = True
        btBuscar.Enabled = True
    End Sub
    Private Sub fechadoc_Leave(sender As Object, e As EventArgs) Handles fechadoc.Leave
        FuncionesContables.validarFechaFutura(fechadoc)
    End Sub
    Private Sub base_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles base.KeyPress, txtPorcentaje.KeyPress
        ValidacionDigitacion.validarSoloNumerosPositivo(e)
    End Sub
    Private Sub enlazarTabla()

        Dim A1, A2, A3, A4, A5, A6, A7, A8 As New DataColumn

        A1.ColumnName = "codigoCuenta"
        A1.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(A1)

        A2.ColumnName = "Nombre"
        A2.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(A2)

        A7.ColumnName = "idTercero"
        A7.DataType = Type.GetType("System.Int32")
        dtCuentas.Columns.Add(A7)

        A6.ColumnName = "Estado"
        A6.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(A6)

        A8.ColumnName = "Tercero"
        A8.DataType = Type.GetType("System.String")
        dtCuentas.Columns.Add(A8)

        A3.ColumnName = "Debito"
        A3.DataType = Type.GetType("System.Double")
        A3.DefaultValue = "0,00"
        dtCuentas.Columns.Add(A3)

        A4.ColumnName = "Credito"
        A4.DataType = Type.GetType("System.Double")
        A4.DefaultValue = "0,00"
        dtCuentas.Columns.Add(A4)

        A5.ColumnName = "orden"
        A5.DataType = Type.GetType("System.Int32")
        dtCuentas.Columns.Add(A5)


        With dgvcartera

            .Columns.Item("dgcuenta").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgcuenta").DataPropertyName = "codigoCuenta"


            .Columns.Item("dgdescripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgdescripcion").DataPropertyName = "Nombre"
            .Columns.Item("dgdescripcion").ReadOnly = True

            .Columns.Item("dgnit").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgnit").DataPropertyName = "idTercero"

            .Columns.Item("Estado").DataPropertyName = "Estado"
            .Columns.Item("Estado").HeaderText = "Estado"
            .Columns.Item("Estado").Visible = False

            .Columns.Item("dgtercero").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgtercero").DataPropertyName = "Tercero"
            .Columns.Item("dgtercero").ReadOnly = False

            .Columns.Item("dgdebito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgdebito").DataPropertyName = "Debito"
            .Columns.Item("dgdebito").ReadOnly = False

            .Columns.Item("dgcredito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgcredito").DataPropertyName = "Credito"
            .Columns.Item("dgcredito").ReadOnly = False

            .Columns.Item("orden").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("orden").DataPropertyName = "orden"
            .Columns.Item("orden").Visible = False

            .Columns.Item("anular").ReadOnly = True
            .Columns.Item("anular").DisplayIndex = CInt(dgvcartera.ColumnCount - 1)
            .Columns.Item("anular").Width = 80

        End With

        dgvcartera.DataSource = dtCuentas
        dgvcartera.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvcartera.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
    End Sub
    Private Sub dgvcartera_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcartera.CellDoubleClick
        Dim columna As Integer = e.ColumnIndex

        Try
            If btRegistrar.Enabled = False Then
                Exit Sub
            End If
            If (dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgCuenta").Selected = True Or dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgDescripcion").Selected = True) And dtCuentas.Rows(dgvcartera.CurrentCell.RowIndex).Item("Estado").ToString = "" Then
                agregarCuentas(Consultas.CUENTAS_CONTA_GENERAL, TitulosForm.BUSQUEDA_CUENTAS_PUC, dgvcartera, dtCuentas)
            ElseIf columna = 5 And dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgCuenta").ToString <> "" Then
                Dim nombre As String = "''"
                agregarTercero(Consultas.CONTA_TERCERO_BUSCAR & nombre, TitulosForm.BUSQUEDA_TERCERO, dgvcartera, dtCuentas)
            ElseIf dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("anular").Selected = True And dtCuentas.Rows(dgvcartera.CurrentCell.RowIndex).Item("codigoCuenta").ToString <> "" Then
                If dtCuentas.Rows(dgvcartera.CurrentCell.RowIndex).Item("Estado").ToString = Constantes.ITEM_NUEVO Then
                    dtCuentas.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try

    End Sub
    Private Sub agregarCuentas(ByVal consulta As String, ByVal titulo As String, ByVal datagrid As Object, ByVal datatable As Object)
        Dim tbl As DataRow = Nothing
        Dim formBusqueda As FormBusqueda = Generales.buscarElemento(consulta, Nothing, titulo, False)
        tbl = formBusqueda.rowResultados
        If tbl IsNot Nothing Then
            datatable.Rows(datagrid.CurrentCell.RowIndex).Item(0) = tbl(0)
            datatable.Rows(datagrid.CurrentCell.RowIndex).Item(1) = tbl(1)
            datatable.Rows(datagrid.CurrentCell.RowIndex).Item(3) = Constantes.ITEM_NUEVO
            datagrid.Rows(datagrid.RowCount - 1).Cells(5).Selected = True
        End If
    End Sub
    Private Sub agregarTercero(ByVal consulta As String, ByVal titulo As String, ByVal datagrid As Object, ByVal datatable As Object)
        Dim tbl As DataRow = Nothing
        Dim formBusqueda As FormBusqueda = Generales.buscarElemento(consulta, Nothing, titulo, False)
        tbl = formBusqueda.rowResultados
        If tbl IsNot Nothing Then
            If dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item(2).ToString = "" Then
                datatable.Rows.Add()
            End If
            datatable.Rows(datagrid.CurrentCell.RowIndex).Item(2) = tbl(0)
            datatable.Rows(datagrid.CurrentCell.RowIndex).Item(4) = tbl(2)

            datagrid.Rows(datagrid.RowCount - 1).Cells(1).Selected = True
        End If
    End Sub

    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
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
        dgvcartera.Focus()
        identificador = String.Empty
        bloquearColumnas()
        PnlInfo.Visible = False
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
    Private Function validarInformacion() As Boolean
        If FuncionesContables.verificarFecha(fechadoc.Value) Then
            mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.Red)
            Return False
        Else
            mostrarInfo(Nothing, Nothing, Nothing, True)
            PnlInfo.Visible = False
        End If
        If Textnombredocumento.Text = "" Then
            EstiloMensajes.mostrarMensajeAdvertencia("Debe ingresar el tipo de documento")
            Return False
        End If
        If FuncionesContables.validarFechaFutura(fechadoc) = False Then
            Return False
        End If
        Return True
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dtCuentas.AcceptChanges()
        If validarInformacion() Then

            If FuncionesContables.validarDatosDgv(dgvcartera, 1) Then
                If FuncionesContables.validardgv(dtCuentas) Then
                    codigoPuc = FuncionesContables.obtenerPucActivo()
                    Dim objcontageneral_D As New ContabilidadGeneralBLL
                    Try
                        objcontageneral_D.guardarContaGeneral(crearContaGeneral(), SesionActual.idUsuario)
                        Generales.deshabilitarControles(Me)
                        Generales.habilitarBotones(ToolStrip1)
                        btRegistrar.Enabled = False
                        btCancelar.Enabled = False
                    Catch ex As Exception
                        EstiloMensajes.mostrarMensajeError(ex.Message)
                    End Try
                    llenardgv(txtcodigo.Text)
                End If
            End If
        End If
    End Sub
    Private Sub llenardgv(pCodigo As String)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtcodigo.Text = pCodigo
        Generales.llenarTabla(Consultas.CONTA_GENERAL_CARGAR_CUENTAS, params, dtCuentas)
        If FuncionesContables.verificarFecha(fechadoc.Value) Then
            mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.Red)
            fechadoc.Focus()
        End If
    End Sub
    Public Function crearContaGeneral() As ContabilidadGeneral
        Dim objContaGeneral As New ContabilidadGeneral
        objContaGeneral.identificador = identificador
        objContaGeneral.comprobante = txtcodigo.Text
        objContaGeneral.idTercero = SesionActual.codigoEmpresa
        objContaGeneral.fechaRecibo = fechadoc.Value
        objContaGeneral.codigoDocumento = codigoDocumento
        Dim index As Integer = 0
        For Each drFila As DataRow In dtCuentas.Rows
            If drFila.Item("codigoCuenta").ToString <> "" Then
                Dim drCuenta As DataRow = objContaGeneral.dtCuentas.NewRow
                drCuenta.Item("comprobante") = objContaGeneral.comprobante
                drCuenta.Item("codigo_puc") = codigoPuc
                drCuenta.Item("codigoCuenta") = drFila.Item("codigoCuenta")
                drCuenta.Item("idTercero") = drFila.Item("idTercero")
                drCuenta.Item("debito") = drFila.Item("debito")
                drCuenta.Item("credito") = drFila.Item("credito")
                drCuenta.Item("orden") = index
                objContaGeneral.dtCuentas.Rows.Add(drCuenta)
                index += 1
            End If
        Next
        Return objContaGeneral
    End Function
    Private Sub cargarDatos(pCodigo)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add(pCodigo)
        Generales.llenarTabla(Consultas.CAJA_BANCO_CARGAR, params, dt)
        txtcodigo.Text = pCodigo
        fechadoc.Value = dt.Rows(0).Item("Fecha_Recibo").ToString()
        Textsigla.Text = dt.Rows(0).Item("Sigla").ToString()
        Textnombredocumento.Text = dt.Rows(0).Item("Documento").ToString()
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

    Private Sub cargarDocumento(codigo As String)
        Dim objDocumentoContable As DocumentoContable = FuncionesContables.cargarDocumento(codigo)
        If objDocumentoContable IsNot Nothing Then
            Textsigla.Text = codigo
            codigoDocumento = objDocumentoContable.codigo
            Textnombredocumento.Text = objDocumentoContable.descripcion
        End If
    End Sub
    Private Sub Textsigla_Leave(sender As Object, e As EventArgs) Handles Textsigla.Leave
        If Textsigla.Text <> "" Then
            cargarDocumento(Textsigla.Text)
            txtcodigo.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        End If
    End Sub

    Private Sub dgvCuentas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcartera.CellEnter
        If e.ColumnIndex = 6 Then
            FuncionesContables.ValidarCreditoDebito(dgvcartera, "dgdebito", "dgcredito")
        ElseIf e.ColumnIndex = 7 Then
            FuncionesContables.ValidarCreditoDebito(dgvcartera, "dgcredito", "dgdebito")
        End If
        bloquearColumnas()
    End Sub

    Private Sub dgvCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcartera.CellClick
        If e.ColumnIndex = 6 Then
            FuncionesContables.ValidarCreditoDebito(dgvcartera, "dgdebito", "dgcredito")
        ElseIf e.ColumnIndex = 7 Then
            FuncionesContables.ValidarCreditoDebito(dgvcartera, "dgcredito", "dgdebito")
        End If
        bloquearColumnas()
    End Sub
    Private Sub dgvcartera_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcartera.CellEndEdit

        If dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item(0).ToString <> "" Then
            Dim params As New List(Of String)
            params.Add(codigoPuc)
            params.Add(dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item(0).ToString)
            Dim fila As DataRow
            fila = FuncionesContables.digitarCuenta(params)
            If Not IsNothing(fila) Then
                dtCuentas.Rows(dgvcartera.CurrentCell.RowIndex).Item("Estado") = Constantes.ITEM_NUEVO
                If dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item(0).ToString <> "" And dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item(4).ToString <> "" Then
                    dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item(1) = fila(2)
                ElseIf e.ColumnIndex = 5 And dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item(4).ToString = "" Then
                    dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item(1) = fila(2)
                    dtCuentas.Rows.Add()
                End If
            Else
                dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgcuenta").Value = String.Empty
                dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgdescripcion").Value = String.Empty
            End If
            If dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item(1).ToString = "" Then
                dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgCuenta").Value = String.Empty
                Exit Sub
            End If

            If dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item("Debito").ToString = "" Then
                dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgdebito").Value = 0
            ElseIf dtCuentas.Rows(dgvcartera.CurrentRow.Index).Item("Credito").ToString = "" Then
                dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgcredito").Value = 0
            End If
            dtCuentas.AcceptChanges()
        End If

    End Sub

    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Generales.buscarElemento(Consultas.CONTA_GENERAL_BUSCAR,
                               Nothing,
                               AddressOf cargarDatos,
                               TitulosForm.BUSQUEDA_CAJA_BANCO,
                               False, True)
    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.habilitarControles(Me)
            Generales.deshabilitarBotones(ToolStrip1)
            dtCuentas.Rows.Add()
            identificador = txtcodigo.Text
            bloquearColumnas()
            Generales.deshabilitarBotones(ToolStrip1)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub dgvcartera_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvcartera.CellFormatting
        If e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), "c2")
            Else
                e.Value = Format(Val(e.Value), "c2")
            End If
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
    Private Sub dgvcartera_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvcartera.EditingControlShowing,
            dgvcartera.EditingControlShowing
        If dgvcartera.CurrentCell.ColumnIndex = 7 Or dgvcartera.CurrentCell.ColumnIndex = 6 Or dgvcartera.CurrentCell.ColumnIndex = 0 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub

    Private Sub dgvcartera_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvcartera.KeyDown
        If e.KeyCode = Keys.F3 And btRegistrar.Enabled = True Then
            If (dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgCuenta").Selected = True Or dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgDescripcion").Selected = True) And dtCuentas.Rows(dgvcartera.CurrentCell.RowIndex).Item("Estado").ToString = "" Then
                agregarCuentas(Consultas.CUENTAS_CONTA_GENERAL, TitulosForm.BUSQUEDA_CUENTAS_PUC, dgvcartera, dtCuentas)
                Generales.agregarItems(Consultas.CUENTAS_CONTA_GENERAL, TitulosForm.BUSQUEDA_CAJA_BANCO, dgvcartera, dtCuentas)
            ElseIf (dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgTercero").Selected = True And dgvcartera.Rows(dgvcartera.CurrentCell.RowIndex).Cells("dgCuenta").ToString <> "") Then
                agregarTercero(Consultas.CONTA_TERCERO_BUSCAR, TitulosForm.BUSQUEDA_TERCERO, dgvcartera, dtCuentas)
            End If
        End If
    End Sub
    Private Sub bloquearColumnas()
        With dgvcartera
            .Columns.Item("dgdescripcion").ReadOnly = True
            .Columns.Item("dgtercero").ReadOnly = True
        End With
    End Sub
    Private Sub dgvcartera_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgvcartera.DataError
        If e.ColumnIndex = 5 Then
            For i = 0 To dgvcartera.Rows.Count - 1
                If dgvcartera.Rows(i).Cells(4).Value.ToString = "" Then
                    EstiloMensajes.mostrarMensajeAdvertencia("Por Favor ingrese un valor")
                End If
            Next
        ElseIf e.ColumnIndex = 6 Then
            For i = 0 To dgvcartera.Rows.Count - 1
                If dgvcartera.Rows(i).Cells(5).Value.ToString = "" Then
                    EstiloMensajes.mostrarMensajeAdvertencia("Por Favor ingrese un valor")
                End If
            Next
        End If
    End Sub
End Class