Public Class FormNomina
    Dim dtNomina As New DataTable
    Private Sub cargarNomina()
        Dim params As New List(Of String)
        params.Add(dtFechaInicio.Value.Date)
        params.Add(dtFechaFinal.Value.Date)
        Generales.llenarTabla(Sentencias.NOMINA_EMPLEADO_CARGAR, params, dtNomina)
        dgvNomina.DataSource = dtNomina
        If dtNomina.Rows.Count > 0 Then
            dgvNomina.Columns(0).Visible = False
            dgvNomina.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvNomina.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvNomina.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub
    Private Sub dgvNomina_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvNomina.CellFormatting
        If e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub
    Private Sub FormNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtFechaInicio.Enabled = True
        dtFechaFinal.Enabled = True
        cargarNomina()
    End Sub
    Private Sub dtFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaInicio.ValueChanged
        dtFechaFinal.Value = dtFechaInicio.Value.AddDays(14)
        cargarNomina()
    End Sub
    Private Sub dtFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaFinal.ValueChanged
        cargarNomina()
    End Sub

End Class