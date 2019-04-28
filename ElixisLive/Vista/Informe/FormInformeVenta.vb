Public Class FormInformeVenta
    Dim rentabilidad As New Rentabilidad

    Private Sub FormInformeVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        validarGrillaGasto()
        validarGrillaVenta()
        Generales.deshabilitarControles(gpTotales)
        dtFechaInicio.Value = dtFechaInicio.Value.AddDays(-dtFechaInicio.Value.Day).AddDays(1)
    End Sub
    Private Sub cargargastos()
        Dim params As New List(Of String)
        params.Add(dtFechaInicio.Value.Date)
        params.Add(dtFechaFin.Value.Date)
        Generales.llenarTabla("", params, rentabilidad.dtgasto)
        dgvGasto.DataSource = rentabilidad.dtgasto
    End Sub
    Private Sub cargarVentas()
        Dim params As New List(Of String)
        params.Add(dtFechaInicio.Value.Date)
        params.Add(dtFechaFin.Value.Date)
        Generales.llenarTabla("", params, rentabilidad.dtVenta)
        dgvVenta.DataSource = rentabilidad.dtVenta
    End Sub

    Private Sub btGenerar_Click(sender As Object, e As EventArgs) Handles btGenerar.Click
        Try
            Cursor = Cursors.WaitCursor
            cargargastos()
            cargarVentas()
            txtTotalGasto.Text = rentabilidad.dtgasto.Compute("SUM(Valor)", "")
            txtTotalCosto.Text = rentabilidad.dtVenta.Compute("SUM(Costo)", "")
            txtTotalVenta.Text = rentabilidad.dtVenta.Compute("SUM(ValorVenta)", "")
            txtRentabilidad.Text = ((txtTotalVenta.Text - txtTotalCosto.Text) - txtTotalGasto.Text)
            Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub validarGrillaVenta()
        With dgvVenta
            .ReadOnly = True
            .Columns(0).DataPropertyName = "Codigo"
            .Columns(1).DataPropertyName = "Descripcion"
            .Columns(2).DataPropertyName = "Cantidad"
            .Columns(3).DataPropertyName = "Costo"
            .Columns(4).DataPropertyName = "ValorVenta"
            .Columns(5).DataPropertyName = "Rentabilidad"
            .AutoGenerateColumns = False
        End With
    End Sub
    Private Sub validarGrillaGasto()
        With dgvGasto
            .ReadOnly = True
            .Columns(0).DataPropertyName = "Codigo"
            .Columns(1).DataPropertyName = "Gasto"
            .Columns(2).DataPropertyName = "Valor"
            .AutoGenerateColumns = False
        End With
    End Sub
End Class