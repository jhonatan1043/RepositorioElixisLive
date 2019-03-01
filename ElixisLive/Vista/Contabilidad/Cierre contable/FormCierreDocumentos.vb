Public Class FormCierreDocumentos
    Dim dtCierre, dtTraslado As New DataTable
    Dim identificador, nCuenta As String
    Dim codigoPuc, codigoDocumento, idTercero As Integer
    Private Sub FormCierreDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
        enlazarTabla()
        Generales.deshabilitarBotones(ToolStrip1)
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        Btcerrar.Enabled = False
    End Sub
    Public Sub enlazarTabla()
        Dim col1, col2, col3, col4, ColT1, ColT2, ColT3, ColT4 As New DataColumn

        col1.ColumnName = "Cuenta"
        col1.DataType = Type.GetType("System.String")
        dtCierre.Columns.Add(col1)

        col2.ColumnName = "Descripcion"
        col2.DataType = Type.GetType("System.String")
        dtCierre.Columns.Add(col2)

        col3.ColumnName = "Debito"
        col3.DataType = Type.GetType("System.Double")
        col3.DefaultValue = 0
        dtCierre.Columns.Add(col3)

        col4.ColumnName = "Credito"
        col4.DataType = Type.GetType("System.Double")
        col4.DefaultValue = 0
        dtCierre.Columns.Add(col4)

        With dgvCierre
            .Columns.Item("Cuenta").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Cuenta").DataPropertyName = "Cuenta"
            .Columns.Item("Cuenta").ReadOnly = True

            .Columns.Item("Descripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Descripcion").DataPropertyName = "Descripcion"
            .Columns.Item("Descripcion").ReadOnly = True

            .Columns.Item("Debito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Debito").DataPropertyName = "Debito"

            .Columns.Item("Credito").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("Credito").DataPropertyName = "Credito"

        End With
        dgvCierre.AutoGenerateColumns = False
        dgvCierre.DataSource = dtCierre
        dgvCierre.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvCierre.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)

        ColT1.ColumnName = "Cuenta"
        ColT1.DataType = Type.GetType("System.String")
        dtTraslado.Columns.Add(ColT1)

        ColT2.ColumnName = "Descripcion"
        ColT2.DataType = Type.GetType("System.String")
        dtTraslado.Columns.Add(ColT2)

        ColT3.ColumnName = "Debito"
        ColT3.DataType = Type.GetType("System.Double")
        ColT3.DefaultValue = 0
        dtTraslado.Columns.Add(ColT3)

        ColT4.ColumnName = "Credito"
        ColT4.DataType = Type.GetType("System.Double")
        ColT4.DefaultValue = 0
        dtTraslado.Columns.Add(ColT4)

        With dgvTraslado
            .Columns.Item("CuentaT").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("CuentaT").DataPropertyName = "Cuenta"
            .Columns.Item("CuentaT").ReadOnly = True

            .Columns.Item("DescripcionT").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("DescripcionT").DataPropertyName = "Descripcion"
            .Columns.Item("DescripcionT").ReadOnly = True

            .Columns.Item("DebitoT").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("DebitoT").DataPropertyName = "Debito"

            .Columns.Item("CreditoT").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("CreditoT").DataPropertyName = "Credito"

        End With
        dgvTraslado.AutoGenerateColumns = False
        dgvTraslado.DataSource = dtTraslado
        dgvTraslado.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvTraslado.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
        codigoPuc = FuncionesContables.obtenerPucActivo()
        Generales.deshabilitarControles(Me)
        codigoDocumento = Constantes.CIERRE_CONTABLE
    End Sub
    Private Sub llenardgvCierre(pCodigo As String)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtcodigo.Text = pCodigo
        Generales.llenarTabla(Consultas.CIERRE_DOCUMENTOS_DETALLE_CIERRE_CARGAR, params, dtCierre)
        dtCierre.Rows.RemoveAt(dtCierre.Rows.Count - 1)
        If dtCierre.Rows.Count > 0 Then
            calcularTotales()
        Else
            textdiferencia.Text = FormatCurrency(0, 2)
        End If
    End Sub
    Private Sub llenardgvTraslado(pCodigo As String)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtcodigo.Text = pCodigo
        Generales.llenarTabla(Consultas.CIERRE_DOCUMENTOS_DETALLE_TRASLADO_CARGAR, params, dtTraslado)
    End Sub
    Private Sub cargarDgvCierre(fechaInicio As Date, fechaFin As Date)
        Dim params As New List(Of String)
        params.Add(DtInicio.Value.Date)
        params.Add(DtFin.Value.Date)
        Generales.llenarTabla(Consultas.CIERRE_DOCUMENTOS_LLENAR, params, dtCierre)
    End Sub
    Public Function crearCierreDocumentos() As CierreDocumentos
        Dim objCierreDocumentos As New CierreDocumentos
        Dim valorDebito, valorCredito As Double
        valorDebito = textvalordebito.Text
        valorCredito = textvalorcredito.Text
        txtcodigo.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        objCierreDocumentos.comprobante = txtcodigo.Text
        objCierreDocumentos.fechaInicio = DtInicio.Value.Date
        objCierreDocumentos.fechaFin = DtFin.Value.Date
        objCierreDocumentos.identificador = identificador
        objCierreDocumentos.valorDebito = valorDebito
        objCierreDocumentos.valorCredito = valorCredito
        Dim index As Integer = 0
        For Each drFila As DataRow In dtCierre.Rows
            If drFila.Item("Cuenta").ToString <> "" Then
                Dim drCuenta As DataRow = objCierreDocumentos.dtCierre.NewRow
                drCuenta.Item("comprobante") = txtcodigo.Text
                drCuenta.Item("codigo_puc") = codigoPuc
                drCuenta.Item("codigoCuenta") = drFila.Item("Cuenta")
                drCuenta.Item("debito") = drFila.Item("debito")
                drCuenta.Item("credito") = drFila.Item("credito")
                drCuenta.Item("orden") = index
                objCierreDocumentos.dtCierre.Rows.Add(drCuenta)
                index += 1
            End If
        Next
        For Each drFila As DataRow In dtTraslado.Rows
            Dim drCuenta As DataRow = objCierreDocumentos.dtCierre.NewRow
            drCuenta.Item("comprobante") = txtcodigo.Text
            drCuenta.Item("codigo_puc") = codigoPuc
            drCuenta.Item("codigoCuenta") = drFila.Item("Cuenta")
            drCuenta.Item("debito") = drFila.Item("debito")
            drCuenta.Item("credito") = drFila.Item("credito")
            drCuenta.Item("orden") = index
            objCierreDocumentos.dtCierre.Rows.Add(drCuenta)
            index += 1
        Next
        Return objCierreDocumentos
    End Function
    Private Sub calcularTotales()
        Try
            Dim valorDebito, sumaDebito, sumaCredito, valorCredito, diferencia As Double
            If dgvCierre.Rows.Count > 1 Then
                For indicedgvCartera = 0 To dgvCierre.Rows.Count - 1
                    If dgvCierre.Rows(indicedgvCartera).Cells("Descripcion").Value.ToString <> "" Then
                        sumaDebito = CDbl(dgvCierre.Rows(indicedgvCartera).Cells(2).Value)
                        sumaCredito = CDbl(dgvCierre.Rows(indicedgvCartera).Cells(3).Value)
                        valorDebito = valorDebito + sumaDebito
                        valorCredito = valorCredito + sumaCredito
                    End If
                Next
                diferencia = FormatCurrency((CDbl(valorDebito) - CDbl(valorCredito)), 2)
                textvalordebito.Text = CDbl(valorDebito).ToString("C2")
                textvalorcredito.Text = Math.Abs(valorCredito).ToString("C2")
                textdiferencia.Text = Math.Abs(diferencia).ToString("C2")
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub cerrarCuentas(puc As Integer)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add(codigoPuc)
        Generales.llenarTabla(Consultas.CIERRE_DOCUMENTOS_CUENTAS_CERRAR, params, dt)
        If dt.Rows.Count > 0 Then
            dtCierre.Rows.Add()
            dtCierre.Rows(dtCierre.Rows.Count - 1).Item("Cuenta") = dt.Rows(0).Item("Cuenta").ToString()
            dtCierre.Rows(dtCierre.Rows.Count - 1).Item("Descripcion") = dt.Rows(0).Item("Nombre").ToString()
        End If
    End Sub
    Private Sub cruzarCuentas(cuenta As String)
        Dim dt As New DataTable
        Dim vDebito, vCredito As Double
        Dim params As New List(Of String)
        calcularTotales()
        vDebito = textvalordebito.Text
        vCredito = textvalorcredito.Text
        If CDbl(vDebito) > CDbl(vCredito) Then
            dtCierre.Rows(dtCierre.Rows.Count - 1).Item("Credito") = CDbl(textdiferencia.Text)
            nCuenta = "360505"
            vCredito = CDbl(textdiferencia.Text)
            vDebito = 0
        ElseIf CDbl(vCredito) > CDbl(vDebito) Then
            dtCierre.Rows(dtCierre.Rows.Count - 1).Item("Debito") = CDbl(textdiferencia.Text)
            nCuenta = "361005"
            vDebito = CDbl(textdiferencia.Text)
            vCredito = 0
        End If
        Dim params2 As New List(Of String)
        params2.Add(0)
        params2.Add(nCuenta)
        Generales.llenarTabla(Consultas.CUENTAS_PUC_CARGAR, params2, dt)
        If dt.Rows.Count > 0 Then
            dtTraslado.Rows.Add()
            dtTraslado.Rows(dtTraslado.Rows.Count - 1).Item("Cuenta") = dtCierre.Rows(dtCierre.Rows.Count - 1).Item("Cuenta")
            dtTraslado.Rows(dtTraslado.Rows.Count - 1).Item("Descripcion") = dtCierre.Rows(dtCierre.Rows.Count - 1).Item("Descripcion")
            dtTraslado.Rows(dtTraslado.Rows.Count - 1).Item("Debito") = dtCierre.Rows(dtCierre.Rows.Count - 1).Item("Credito")
            dtTraslado.Rows(dtTraslado.Rows.Count - 1).Item("Credito") = dtCierre.Rows(dtCierre.Rows.Count - 1).Item("Debito")
            dtTraslado.Rows.Add()
            dtTraslado.Rows(dtTraslado.Rows.Count - 1).Item("Cuenta") = nCuenta
            dtTraslado.Rows(dtTraslado.Rows.Count - 1).Item("Descripcion") = dt.Rows(0).Item("Descripcion").ToString()
            dtTraslado.Rows(dtTraslado.Rows.Count - 1).Item("Debito") = Math.Abs(vDebito)
            dtTraslado.Rows(dtTraslado.Rows.Count - 1).Item("Credito") = Math.Abs(vCredito)
            Btcerrar.Enabled = False
        End If
    End Sub
    Private Sub Btcerrar_Click(sender As Object, e As EventArgs) Handles Btcerrar.Click
        If dgvCierre.Rows.Count > 0 Then
            cerrarCuentas(codigoPuc)
            cruzarCuentas(nCuenta)
            Panel1.Visible = True
        End If
    End Sub
    Private Sub DtInicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DtInicio.ValueChanged
        If DtFin.Value > DateTime.Now.Date Then
            DtFin.Value = DateTime.Now.Date
        End If
        If DtInicio.Value > DtFin.Value Then
            DtInicio.Value = DtFin.Value
        End If
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvCierre.EndEdit()
        If Format(CDate(DtInicio.Value), Constantes.FORMATO_FECHA_GEN) >= Format(CDate(DtFin.Value), Constantes.FORMATO_FECHA_GEN) Then
            EstiloMensajes.mostrarMensajeAdvertencia("La fecha de fin no puede ser menor o igual a la fecha de inicio!")
            DtFin.Focus()
        ElseIf dtCierre.Rows.Count = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("El lapso de tiempo no ha generado ningun registro!!")
        ElseIf dtTraslado.Select("Cuenta='590505'").Count = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Debe cerrar las cuentas antes de guardar !!")
        Else
            codigoPuc = FuncionesContables.obtenerPucActivo()
            calcularTotales()
            dgvCierre.EndEdit()
            dtCierre.AcceptChanges()
            Dim objCierreDocumentosBLL As New CierreDocumentosBLL
            Try
                objCierreDocumentosBLL.guardarCiereDocumentos(crearCierreDocumentos(), SesionActual.idUsuario)
                Generales.habilitarBotones(ToolStrip1)
                btRegistrar.Enabled = False
                btNuevo.Enabled = True
                Generales.deshabilitarControles(Me)
                FuncionesContables.aumentarConsecutivo(codigoDocumento)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub DtFin_CloseUp(sender As System.Object, e As System.EventArgs) Handles DtFin.CloseUp
        If DtFin.Value > DtInicio.Value Then
            cargarDgvCierre(DtInicio.Value.Date, DtFin.Value.Date)
            calcularTotales()
        End If
    End Sub

    Private Sub DtInicio_CloseUp(sender As System.Object, e As System.EventArgs) Handles DtInicio.CloseUp
        If DtFin.Value > DtInicio.Value Then
            cargarDgvCierre(DtInicio.Value.Date, DtFin.Value.Date)
            calcularTotales()
        End If
    End Sub
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.limpiarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        txtcodigo.Text = FuncionesContables.verificarConsecutivo(codigoDocumento)
        Textsigla.Text = Constantes.SIGLA_CIERRE_CONTABLE
        cargarDocumento(Textsigla.Text)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        identificador = String.Empty
        Panel1.Visible = False
        textvalorcredito.Text = FormatCurrency(0, 2)
        textvalordebito.Text = FormatCurrency(0, 2)
        textdiferencia.Text = FormatCurrency(0, 2)
        dgvCierre.ReadOnly = True
        dgvTraslado.ReadOnly = True

    End Sub
    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)

        Generales.buscarElemento(Consultas.CIERRE_DOCUMENTOS_BUSCAR,
                               params,
                               AddressOf cargarDatos,
                               TitulosForm.BUSQUEDA_DOCUMENTOS_CONTABLES,
                               True, True)

    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            identificador = txtcodigo.Text
            dgvTraslado.ReadOnly = True
            dgvCierre.ReadOnly = True
            Generales.deshabilitarBotones(ToolStrip1)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub dgvCierre_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCierre.CellEnter
        calcularTotales()
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarControles(Me)
            Generales.deshabilitarBotones(ToolStrip1)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            Panel1.Visible = False
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
    Private Sub cargarDatos(pCodigo As String)
        Dim dt As New DataTable
        Dim params As New List(Of String)
        params.Add(pCodigo)
        Generales.llenarTabla(Consultas.CIERRE_DOCUMENTOS_CARGAR, params, dt)
        If dt.Rows.Count > 0 Then

            Textsigla.Text = Constantes.SIGLA_CIERRE_CONTABLE
            cargarDocumento(Textsigla.Text)
            DtInicio.Value = dt.Rows(0).Item("Fecha_Inicio").ToString()
            DtFin.Value = dt.Rows(0).Item("Fecha_Fin").ToString()
            textvalordebito.Text = dt.Rows(0).Item("valor_debito").ToString()
            textvalorcredito.Text = dt.Rows(0).Item("valor_credito").ToString()
            llenardgvCierre(pCodigo)
            llenardgvTraslado(pCodigo)
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
            Panel1.Visible = True
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
End Class