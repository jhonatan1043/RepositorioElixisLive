Public Class FormExistencia
    Private Sub FormExistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarExistencia()
        Generales.diseñoDGV(dgvLista)
    End Sub
    Private Sub cargarExistencia()
        Dim params As New List(Of String)
        dgvLista.ReadOnly = True
        params.Add(txtBuscar.Text)
        Generales.llenardgv("[SP_PRODUCTO_EXISTENCIA_CONSULTAR]", dgvLista, params)
    End Sub
    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarExistencia()
        End If
    End Sub
    Private Sub dgvLista_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLista.CellFormatting
        If dgvLista.RowCount > 0 Then
            If dgvLista.Rows(e.RowIndex).Cells("Stock").Value = 0 Then
                dgvLista.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
            End If
        End If
    End Sub
End Class