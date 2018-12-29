Public Class FormNomina
    Dim dtNomina As New DataTable
    Private Sub cargarNomina()
        Dim params As New List(Of String)
        params.Add(dateFechaNomina.Value.Date)
        params.Add(dtFechaHasta.Value.Date)
        Generales.llenarTabla(Sentencias.NOMINA_EMPLEADO_CARGAR, params, dtNomina)
        dgvNomina.DataSource = dtNomina
        If dtNomina.Rows.Count > 0 Then
            dgvNomina.Columns(0).Visible = False
            dgvNomina.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End If
    End Sub
    Private Sub FormNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarNomina()
    End Sub
End Class