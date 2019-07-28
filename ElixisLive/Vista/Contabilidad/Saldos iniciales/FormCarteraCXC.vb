﻿Public Class FormCarteraCXC
    Dim dtCartera As New DataTable
    Dim identificador, comprobante As String
    Dim codigoPuc, codigoDocumento As Integer

    Private Sub llenardgv(pCodigo As DateTime)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        Generales.llenarTabla(Consultas.CARTERA_CXC_CUENTAS_CARGAR, params, dtCartera)
        dgvCartera.Rows(dgvCartera.RowCount - 1).Cells(0).Selected = True
    End Sub
    Private Sub cargarDocumento(codigo As String)
        Dim objDocumentoContable As DocumentoContable = FuncionesContables.cargarDocumento(codigo)
        If objDocumentoContable IsNot Nothing Then
            codigoDocumento = objDocumentoContable.codigo
            Textsigla.Text = codigo
            Textnombredocumento.Text = objDocumentoContable.descripcion
        End If
    End Sub

    Private Sub Form_Cartera_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub deshabilitarColumnas()
        With dgvCartera
            .Columns.Item("Factura").ReadOnly = True
            .Columns.Item("nit").ReadOnly = True
            .Columns.Item("Tercero").ReadOnly = True
            .Columns.Item("Descripcion").ReadOnly = True
            .Columns.Item("Cuenta").ReadOnly = True
        End With
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        dtCartera.Clear()
        dtCartera.Rows.Add()
        Textsigla.Focus()
        Textsigla.Text = Constantes.SIGLA_SALDOS_INICIALES
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        dgvCartera.Focus()
        identificador = String.Empty
        deshabilitarColumnas()
        textvalorcredito.Text = FormatCurrency(0, 2)
        textvalordebito.Text = FormatCurrency(0, 2)
        textdiferencia.Text = FormatCurrency(0, 2)
    End Sub
    Private Sub cargarDatos(pCodigo As String)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add(pCodigo)
        identificador = pCodigo
        Generales.llenarTabla(Consultas.CARTERA_CXC_CARGAR, params, dt)
        Textsigla.Text = Constantes.SIGLA_SALDOS_INICIALES
        cargarDocumento(Textsigla.Text)
        comprobante = dt.Rows(0).Item("Codigo_Factura").ToString()
        fechadoc.Value = dt.Rows(0).Item("Fecha_Doc").ToString()
        llenardgv(fechadoc.Value)
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
        Generales.buscarElemento(Consultas.CARTERA_CXC_BUSCAR,
                                   Nothing,
                                   AddressOf cargarDatos,
                                   TitulosForm.BUSQUEDA_CAJA_BANCO,
                                   False)
    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            identificador = comprobante
            dtCartera.Rows.Add()
            Generales.deshabilitarBotones(ToolStrip1)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
            dgvCartera.ReadOnly = False
            deshabilitarColumnas()
        End If
    End Sub
    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btBuscar.Enabled = True
            btNuevo.Enabled = True
        End If
    End Sub
    Private Sub dgvcartera_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvCartera.EditingControlShowing
        If dgvCartera.CurrentCell.ColumnIndex = 6 Or dgvCartera.CurrentCell.ColumnIndex = 7 Or dgvCartera.CurrentCell.ColumnIndex = 0 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub
    Private Sub calcularTotales()
        Try
            Dim valorDebito, sumaDebito, sumaCredito, valorCredito As Double
            If dgvCartera.Rows.Count > 1 Then
                For indicedgvCartera = 0 To dgvCartera.Rows.Count - 1
                    If dgvCartera.Rows(indicedgvCartera).Cells("Descripcion").Value.ToString <> "" Then
                        sumaDebito = CDbl(dgvCartera.Rows(indicedgvCartera).Cells(6).Value)
                        sumaCredito = CDbl(dgvCartera.Rows(indicedgvCartera).Cells(7).Value)
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

    Private Sub Form_CarteraCXC_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub dgvCuentas_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCartera.CellEnter
        If e.ColumnIndex = 6 Then
            FuncionesContables.ValidarCreditoDebito(dgvCartera, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 7 Then
            FuncionesContables.ValidarCreditoDebito(dgvCartera, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        deshabilitarColumnas()
    End Sub

    Private Sub dgvCuentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCartera.CellClick
        If e.ColumnIndex = 6 Then
            FuncionesContables.ValidarCreditoDebito(dgvCartera, Constantes.COLUMNA_DEBITO, Constantes.COLUMNA_CREDITO)
        ElseIf e.ColumnIndex = 7 Then
            FuncionesContables.ValidarCreditoDebito(dgvCartera, Constantes.COLUMNA_CREDITO, Constantes.COLUMNA_DEBITO)
        End If
        deshabilitarColumnas()
    End Sub
    Private Sub dgvCartera_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCartera.CellEndEdit
        If dtCartera.Rows(dgvCartera.CurrentRow.Index).Item("Debito").ToString = "" Then
            dgvCartera.Rows(dgvCartera.CurrentCell.RowIndex).Cells("Debito").Value = 0
        ElseIf dtCartera.Rows(dgvCartera.CurrentRow.Index).Item("Credito").ToString = "" Then
            dgvCartera.Rows(dgvCartera.CurrentCell.RowIndex).Cells("Credito").Value = 0
        End If
        dtCartera.AcceptChanges()
    End Sub
    Private Sub Textsigla_Leave(sender As Object, e As EventArgs) Handles Textsigla.Leave
        If Textsigla.Text <> "" Then
            cargarDocumento(Textsigla.Text)
        End If
    End Sub
    Public Sub enlazarTabla()
        Dim col1, col2, col3, col4, col5, col6, col7, col8, col9 As New DataColumn

        col1.ColumnName = "Factura"
        col1.DataType = Type.GetType("System.String")
        dtCartera.Columns.Add(col1)

        col2.ColumnName = "Nit"
        col2.DataType = Type.GetType("System.String")
        dtCartera.Columns.Add(col2)

        col3.ColumnName = "Tercero"
        col3.DataType = Type.GetType("System.String")
        dtCartera.Columns.Add(col3)

        col4.ColumnName = "Cuenta"
        col4.DataType = Type.GetType("System.String")
        dtCartera.Columns.Add(col4)

        col5.ColumnName = "Descripcion"
        col5.DataType = Type.GetType("System.String")
        dtCartera.Columns.Add(col5)

        col6.ColumnName = "Debito"
        col6.DataType = Type.GetType("System.Double")
        col6.DefaultValue = 0
        dtCartera.Columns.Add(col6)

        col7.ColumnName = "Credito"
        col7.DataType = Type.GetType("System.Double")
        col7.DefaultValue = 0
        dtCartera.Columns.Add(col7)

        col8.ColumnName = "Comprobante"
        col8.DataType = Type.GetType("System.String")
        dtCartera.Columns.Add(col8)

        col9.ColumnName = "Estado"
        col9.DataType = Type.GetType("System.Int32")
        dtCartera.Columns.Add(col9)

        With dgvCartera
            .Columns.Item("dgComprobante").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgComprobante").DataPropertyName = "Comprobante"

            .Columns.Item("Factura").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Factura").DataPropertyName = "Factura"

            .Columns.Item("nit").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("nit").DataPropertyName = "Nit"
            .Columns.Item("nit").ReadOnly = True

            .Columns.Item("Tercero").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Tercero").DataPropertyName = "Tercero"
            .Columns.Item("Tercero").ReadOnly = True

            .Columns.Item("Cuenta").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Cuenta").DataPropertyName = "Cuenta"

            .Columns.Item("Descripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Descripcion").DataPropertyName = "Descripcion"
            .Columns.Item("Descripcion").ReadOnly = True

            .Columns.Item("Debito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Debito").DataPropertyName = "Debito"

            .Columns.Item("Credito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Credito").DataPropertyName = "Credito"

            .Columns.Item("estado").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("estado").DataPropertyName = "Estado"
        End With

        dgvCartera.AutoGenerateColumns = False
        dgvCartera.DataSource = dtCartera
        dgvCartera.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCartera.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
    End Sub
    Private Sub Form_CarteraCXC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        enlazarTabla()
        Generales.deshabilitarControles(Me)
        codigoDocumento = Constantes.SALDOS_INICIALES
        Generales.asignarPermiso(Me)
    End Sub
    Public Function validarDatosDgv()
        If (dgvCartera.RowCount = 1) Then
            EstiloMensajes.mostrarMensajeAdvertencia("No se puede guardar registros en blanco")
            dgvCartera.Focus()
            Return False
        Else
            For i = 0 To dgvCartera.Rows.Count - 1
                If dgvCartera.Rows(i).Cells("cuenta").Value.ToString = "" Then
                    EstiloMensajes.mostrarMensajeAdvertencia("El Tercero " + dgvCartera.Rows(i).Cells("Tercero").Value.ToString.ToLower + " no tiene cuenta configurada")
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Private Function validaInformacion() As Boolean
        dgvCartera.EndEdit()
        If FuncionesContables.verificarFecha(fechadoc.Value) Then
            mostrarInfo(String.Format(MensajeSistema.PERIODO_CONTABLE_CERRADO), Color.White, Color.FromArgb(252, 249, 169))
            Return False
        Else
            mostrarInfo(Nothing, Nothing, Nothing, True)
            PnlInfo.Visible = False
        End If
        If dgvCartera.RowCount <= 1 Then
            Return False
        End If
        Return True
    End Function
    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validaInformacion() Then
            If FuncionesContables.validardgv(dtCartera) Then
                If validarDatosDgv() Then
                    codigoPuc = FuncionesContables.obtenerPucActivo()
                    Dim objCarteraCXC_D As New CarteraCuentaPorCobrarBLL
                    calcularTotales()
                    Try
                        objCarteraCXC_D.guardarCarteraCXC(crearCarteraCXC())
                        Generales.deshabilitarControles(Me)
                        Generales.habilitarBotones(ToolStrip1)
                        btRegistrar.Enabled = False
                        btCancelar.Enabled = False
                        FuncionesContables.removerUltimafila(dtCartera, dgvCartera)
                    Catch ex As Exception
                        EstiloMensajes.mostrarMensajeError(ex.Message)
                    End Try

                End If
            End If
        End If
    End Sub
    Public Function crearCarteraCXC() As CarteraCXC
        Dim objCarteraCXC As New CarteraCXC
        Dim valorDebito, valorCredito As Double
        valorDebito = textvalordebito.Text
        valorCredito = textvalorcredito.Text
        objCarteraCXC.identificador = comprobante

        Dim index As Integer = 0
        For Each drFila As DataRow In dtCartera.Rows
            If drFila.Item("Factura").ToString <> "" Then
                Dim drCuenta As DataRow = objCarteraCXC.dtCartera.NewRow
                Dim drCuentaP As DataRow = objCarteraCXC.dtCarteraP.NewRow

                drCuenta.Item("comprobante") = drFila.Item("Factura")
                drCuenta.Item("codigo_puc") = codigoPuc
                drCuenta.Item("codigoCuenta") = drFila.Item("Cuenta")
                drCuenta.Item("debito") = drFila.Item("debito")
                drCuenta.Item("credito") = drFila.Item("credito")
                drCuenta.Item("orden") = index
                If String.IsNullOrEmpty(identificador) Then
                    drCuentaP.Item("comprobante") = FuncionesContables.verificarConsecutivo(codigoDocumento)
                Else
                    drCuentaP.Item("comprobante") = drFila.Item("comprobante")
                End If
                drCuentaP.Item("codigoDocumento") = codigoDocumento
                drCuentaP.Item("codigoFactura") = drFila.Item("Factura")
                drCuentaP.Item("idProveedor") = drFila.Item("Nit")
                drCuentaP.Item("fechaRecibo") = fechadoc.Value.Date
                drCuentaP.Item("fechaVence") = fechadoc.Value.Date
                drCuentaP.Item("fechaDoc") = fechadoc.Value.Date
                drCuentaP.Item("valorDebito") = valorDebito
                drCuentaP.Item("valorCredito") = valorCredito
                drCuentaP.Item("usuario") = SesionActual.idUsuario
                objCarteraCXC.dtCartera.Rows.Add(drCuenta)
                objCarteraCXC.dtCarteraP.Rows.Add(drCuentaP)
                index += 1
                If String.IsNullOrEmpty(identificador) Then
                    FuncionesContables.aumentarConsecutivo(codigoDocumento)
                End If
            End If
        Next

        Return objCarteraCXC
    End Function
    Private Sub dgvcartera_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCartera.CellDoubleClick
        Try
            If btRegistrar.Enabled = False Then
                Exit Sub
            End If
            If (dgvCartera.Rows(dgvCartera.CurrentCell.RowIndex).Cells("Factura").Selected = True) And dtCartera.Rows(dgvCartera.CurrentCell.RowIndex).Item("Estado").ToString = "" Then
                Generales.busquedaItems(Consultas.FACTURAS_CXC_BUSCAR, Nothing, TitulosForm.BUSQUEDA_CAJA_BANCO, dgvCartera, dtCartera, 0, 4, 0, 0)
            ElseIf dgvCartera.Rows(dgvCartera.CurrentCell.RowIndex).Cells("anular").Selected = True And dtCartera.Rows(dgvCartera.CurrentCell.RowIndex).Item("Factura").ToString <> "" Then
                If dtCartera.Rows(dgvCartera.CurrentCell.RowIndex).Item("Estado").ToString = Constantes.ITEM_NUEVO Then
                    dtCartera.Rows.RemoveAt(e.RowIndex)
                End If
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try

    End Sub
End Class