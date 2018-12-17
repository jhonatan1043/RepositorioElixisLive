Public Class CostoServicio
    Inherits generalConsulta
    Property codigoServicio As Integer
    Property dtRegistro As DataTable
    Public Sub New()
        dtRegistro = New DataTable
        dtRegistro.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtRegistro.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtRegistro.Columns.Add("Valor", Type.GetType("System.Decimal"))
        dtRegistro.Columns.Add("Concentracion", Type.GetType("System.Int32"))
        dtRegistro.Columns.Add("Unidad Medida", Type.GetType("System.String"))
        dtRegistro.Columns.Add("Servicios", Type.GetType("System.Int32"))
        dtRegistro.Columns.Add("Costo", Type.GetType("System.Decimal"))
        dtRegistro.Columns.Add("Recomendacion", Type.GetType("System.Int32"))
    End Sub
End Class
