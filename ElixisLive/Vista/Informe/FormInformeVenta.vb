Public Class FormInformeVenta
    Dim rentabilidad As New Rentabilidad

    Private Sub FormInformeVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validarGrillaGasto()
        validarGrillaVenta()
        validarGrillaServ()
        Generales.deshabilitarControles(gpTotales)
        dtFechaInicio.Value = dtFechaInicio.Value.AddDays(-dtFechaInicio.Value.Day).AddDays(1)
    End Sub
    Private Sub cargargastos()
        Dim params As New List(Of String)
        params.Add(dtFechaInicio.Value.Date)
        params.Add(dtFechaFin.Value.Date)
        Generales.llenarTabla("[SP_ADMIN_RENTABILIDAD_GASTOS_CONSULTAR]", params, rentabilidad.dtgasto)
        dgvGasto.DataSource = rentabilidad.dtgasto
    End Sub
    Private Sub cargarVentas()
        Dim params As New List(Of String)
        params.Add(dtFechaInicio.Value.Date)
        params.Add(dtFechaFin.Value.Date)
        Generales.llenarTabla("[SP_ADMIN_RENTABILIDAD_VENTA_CONSULTAR]", params, rentabilidad.dtVenta)
        dgvVenta.DataSource = rentabilidad.dtVenta
    End Sub
    Private Sub cargarServicio()
        Dim params As New List(Of String)
        params.Add(dtFechaInicio.Value.Date)
        params.Add(dtFechaFin.Value.Date)
        Generales.llenarTabla("[SP_ADMIN_RENTABILIDAD_SERVICIO_CONSULTAR]", params, rentabilidad.dtServicio)
        dgvServicio.DataSource = rentabilidad.dtServicio
    End Sub

    Private Sub btGenerar_Click(sender As Object, e As EventArgs) Handles btGenerar.Click
        Try
            Cursor = Cursors.WaitCursor
            cargargastos()
            cargarVentas()
            cargarServicio()

            If rentabilidad.dtgasto.Rows.Count > 0 Then
                txtTotalGasto.Text = rentabilidad.dtgasto.Compute("SUM(Valor)", "")
            Else
                txtTotalGasto.Text = Constantes.SIN_VALOR_NUMERICO
            End If
            If rentabilidad.dtVenta.Rows.Count > 0 Then
                txtTotalCosto.Text = rentabilidad.dtVenta.Compute("SUM(TotalCosto)", "") +
                                     If(rentabilidad.dtServicio.Rows.Count > 0, rentabilidad.dtServicio.Compute("SUM(Costo)", ""), Constantes.SIN_VALOR_NUMERICO)
                txtTotalVenta.Text = rentabilidad.dtVenta.Compute("SUM(TotalVenta)", "") +
                                     If(rentabilidad.dtServicio.Rows.Count > 0, rentabilidad.dtServicio.Compute("SUM(ValorVenta)", ""), Constantes.SIN_VALOR_NUMERICO)
            Else
                txtTotalCosto.Text = Constantes.SIN_VALOR_NUMERICO
                txtTotalVenta.Text = Constantes.SIN_VALOR_NUMERICO
            End If
            txtTotalGasto.Text = Format(CInt(txtTotalGasto.Text), Constantes.FORMATO_MONEDA)
            txtTotalCosto.Text = Format(CInt(txtTotalCosto.Text), Constantes.FORMATO_MONEDA)
            txtTotalVenta.Text = Format(CInt(txtTotalVenta.Text), Constantes.FORMATO_MONEDA)
            txtRentabilidad.Text = Format(CInt(((txtTotalVenta.Text - txtTotalCosto.Text) - txtTotalGasto.Text)), Constantes.FORMATO_MONEDA)
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub validarGrillaVenta()
        With dgvVenta
            .ReadOnly = True
            .Columns(0).DataPropertyName = "Codigo"
            .Columns(1).DataPropertyName = "NumeroFactura"
            .Columns(2).DataPropertyName = "Descripcion"
            .Columns(3).DataPropertyName = "Cantidad"
            .Columns(4).DataPropertyName = "Costo"
            .Columns(5).DataPropertyName = "ValorVenta"
            .Columns(6).DataPropertyName = "TotalCosto"
            .Columns(7).DataPropertyName = "TotalVenta"
            .Columns(8).DataPropertyName = "Rentabilidad"
            .Columns(9).DataPropertyName = "Fecha"
            .AutoGenerateColumns = False
        End With
    End Sub
    Private Sub validarGrillaServ()
        With dgvServicio
            .ReadOnly = True
            .Columns(0).DataPropertyName = "Codigo"
            .Columns(1).DataPropertyName = "NumeroFactura"
            .Columns(2).DataPropertyName = "Descripcion"
            .Columns(3).DataPropertyName = "Costo"
            .Columns(4).DataPropertyName = "ValorVenta"
            .Columns(5).DataPropertyName = "Rentabilidad"
            .Columns(6).DataPropertyName = "Fecha"
            .AutoGenerateColumns = False
        End With
    End Sub
    Private Sub validarGrillaGasto()
        With dgvGasto
            .ReadOnly = True
            .Columns(0).DataPropertyName = "Codigo"
            .Columns(1).DataPropertyName = "Gasto"
            .Columns(2).DataPropertyName = "Valor"
            .Columns(3).DataPropertyName = "Fecha"
            .AutoGenerateColumns = False
        End With

    End Sub

    Private Sub dgvVenta_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvVenta.CellFormatting
        If e.ColumnIndex = 4 _
            OrElse e.ColumnIndex = 5 _
            OrElse e.ColumnIndex = 6 _
            OrElse e.ColumnIndex = 7 _
            OrElse e.ColumnIndex = 8 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub

    Private Sub dgvGasto_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvGasto.CellFormatting
        If e.ColumnIndex = 2 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub
    Private Sub dgvServicio_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvServicio.CellFormatting
        If e.ColumnIndex = 3 _
            OrElse e.ColumnIndex = 4 _
            OrElse e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub
End Class