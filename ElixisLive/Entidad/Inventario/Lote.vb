Public Class Lote
    Property dtLote As DataTable
    Public Sub New()
        crearColumnaDatatable()
    End Sub
    Public Sub crearColumnaDatatable()
        dtLote = New DataTable
        dtLote.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtLote.Columns.Add("Registro", Type.GetType("System.String"))
        dtLote.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        dtLote.Columns.Add("Cantidad_Actual", Type.GetType("System.Int32")).DefaultValue = 0
        dtLote.Columns.Add("FechaLote", Type.GetType("System.DateTime")).DefaultValue = DateTime.Now
        dtLote.Columns.Add("FechaVencimiento", Type.GetType("System.DateTime")).DefaultValue = DateTime.Now
        dtLote.Columns.Add("Ubicacion_Lote", Type.GetType("System.String"))
    End Sub
End Class
