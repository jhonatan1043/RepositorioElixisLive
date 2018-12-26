Public Class FormCostoServicios
    Dim dtServicios, dtProductos As New DataTable
    Private Sub FormCostoServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarServicios()
    End Sub
    Private Sub cargarServicios()
        Generales.llenarTabla("[SP_CONFIGURACION_COSTO_SERVICIO_LISTAR]", Nothing, dtServicios)
        dgvServicio.DataSource = dtServicios
        dgvServicio.Columns(0).Visible = False
        dgvServicio.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
    End Sub

    Private Sub dgvServicio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicio.CellContentClick
        cargarProductos(dgvServicio.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub cargarProductos(pCodigo As Integer)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        Generales.llenarTabla("[SP_COSTO_SERVICIO_CARGAR]", params, dtProductos)
        dgvProducto.DataSource = dtProductos
    End Sub
End Class