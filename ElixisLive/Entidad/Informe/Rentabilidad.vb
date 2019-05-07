Public Class Rentabilidad
    Property dtVenta As DataTable
    Property dtgasto As DataTable
    Property dtServicio As DataTable

    Public Sub New()
        dtVenta = New DataTable
        dtgasto = New DataTable
        dtServicio = New DataTable


        dtVenta.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtVenta.Columns.Add("NumeroFactura", Type.GetType("System.Int32"))
        dtVenta.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtVenta.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dtVenta.Columns.Add("Costo", Type.GetType("System.Int32"))
        dtVenta.Columns.Add("ValorVenta", Type.GetType("System.Int32"))
        dtVenta.Columns.Add("TotalCosto", Type.GetType("System.Int32"))
        dtVenta.Columns.Add("TotalVenta", Type.GetType("System.Int32"))
        dtVenta.Columns.Add("Rentabilidad", Type.GetType("System.Int32"))
        dtVenta.Columns.Add("Fecha", Type.GetType("System.DateTime"))

        dtServicio.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtServicio.Columns.Add("NumeroFactura", Type.GetType("System.Int32"))
        dtServicio.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtServicio.Columns.Add("Costo", Type.GetType("System.Int32"))
        dtServicio.Columns.Add("ValorVenta", Type.GetType("System.Int32"))
        dtServicio.Columns.Add("Rentabilidad", Type.GetType("System.Int32"))
        dtServicio.Columns.Add("Fecha", Type.GetType("System.DateTime"))

        dtgasto.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtgasto.Columns.Add("Gasto", Type.GetType("System.String"))
        dtgasto.Columns.Add("Valor", Type.GetType("System.Int32"))
        dtgasto.Columns.Add("Fecha", Type.GetType("System.DateTime"))

    End Sub

End Class
