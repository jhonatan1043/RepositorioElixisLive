Public Class FormExistencia
    Dim dt As New DataTable
    Dim bdNavegador As New BindingSource
    Private Sub FormExistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarExistencia()
        Generales.personalizarDatagrid(dgvLista)
        Generales.tabularConEnter(Me)
        'establecerPosicion()
    End Sub
    'Private Sub establecerPosicion()
    '    Dim x As Integer
    '    Dim y As Integer
    '    x = Screen.PrimaryScreen.WorkingArea.Width - 880
    '    y = Screen.PrimaryScreen.WorkingArea.Height - 590
    '    Me.Location = New Point(x, y)
    'End Sub
    Private Sub cargarExistencia()
        Dim params As New List(Of String)
        Try
            dgvLista.ReadOnly = True
            params.Add(txtBuscar.Text)
            Generales.llenarTabla("[SP_PRODUCTO_EXISTENCIA_CONSULTAR]", params, dt)
            bdNavegador.DataSource = dt
            dgvLista.DataSource = bdNavegador.DataSource
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
            bdNavegador.Filter = "Descripcion Like '%" & txtBuscar.Text & "%'"
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