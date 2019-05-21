Public Class FormExistencia
    Dim dt As New DataTable
    Dim bdNavegador As New BindingSource
    Private Sub FormExistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarExistencia()
        Generales.personalizarDatagrid(dgvLista)
        Generales.tabularConEnter(Me)
    End Sub
    Private Sub cargarExistencia()
        Try
            dgvLista.ReadOnly = True
            Generales.llenarTabla("[SP_PRODUCTO_EXISTENCIA_CONSULTAR]", Nothing, dt)
            bdNavegador.DataSource = dt
            dgvLista.DataSource = bdNavegador.DataSource
            dgvLista.Columns("Registro").Visible = False
            calcularValores()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub calcularValores()
        If dt.Rows.Count > 0 Then
            lbAcabado.Text = dt.Compute("Count(Stock)", "[Stock] = 0")
            lbPorAcabar.Text = dt.Compute("Count(Stock)", "[Stock] < 10 And [Stock] > 0")
        End If
        lbAcabado.Enabled = False
        lbPorAcabar.Enabled = False
    End Sub
    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            bdNavegador.Filter = "(Descripcion Like '%" & txtBuscar.Text.Trim & "%' OR Registro Like '%" & txtBuscar.Text & "%')"
        End If
    End Sub
    Private Sub dgvLista_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLista.CellFormatting
        If dgvLista.RowCount > 0 Then
            If dgvLista.Rows(e.RowIndex).Cells("Stock").Value = 0 Then
                dgvLista.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
            ElseIf dgvLista.Rows(e.RowIndex).Cells("Stock").Value < 10
                dgvLista.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192)
            Else
                dgvLista.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
            End If
        End If
    End Sub
    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        cargarExistencia()
    End Sub
End Class