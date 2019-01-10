Public Class Lote
    Property dtLote As DataTable
    Public Sub New()
        dtLote = New DataTable
        dtLote.Columns.Add("Registro", Type.GetType("System.String"))
        dtLote.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        dtLote.Columns.Add("FechaLote", Type.GetType("System.DateTime"))
        dtLote.Columns.Add("FechaVencimiento", Type.GetType("System.DateTime"))
    End Sub

End Class
