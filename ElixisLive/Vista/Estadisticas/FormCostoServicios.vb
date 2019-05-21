Public Class FormCostoServicios
    Dim dtServicios, dtProductos As New DataTable
    Private Sub FormCostoServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarServicios()
    End Sub
    Private Sub cargarServicios()
        Generales.llenarTabla(Sentencias.CONFIGURACION_COSTO_SERVICIO_LISTAR, Nothing, dtServicios)
        dgvServicio.DataSource = dtServicios
        dgvServicio.Columns(0).Visible = False
        dgvServicio.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Generales.deshabilitarControles(Me)
        Label1.ForeColor = Color.White
        Label5.ForeColor = Color.White
    End Sub
    Private Sub dgvServicio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicio.CellContentClick
        If dgvServicio.RowCount > 0 Then
            cargarProductos(dgvServicio.CurrentRow.Cells(0).Value)
        End If
    End Sub
    Private Sub dgvProducto_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvProducto.CellFormatting
        If e.ColumnIndex = 6 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub
    Private Sub cargarProductos(pCodigo As Integer)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        Generales.llenarTabla(Sentencias.COSTO_SERVICIO_CARGAR, params, dtProductos)
        dgvProducto.DataSource = dtProductos
        If dtProductos.Rows.Count > 0 Then
            dgvProducto.Columns(0).Visible = False
            dgvProducto.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProducto.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProducto.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProducto.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProducto.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvProducto.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        End If
    End Sub
End Class