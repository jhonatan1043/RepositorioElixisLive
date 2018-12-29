Public Class CostoServicio
    Inherits generalConsulta
    Property codigo As String
    Property codigoServicio As Integer
    Property dtRegistro As DataTable
    Public Sub New()
        dtRegistro = New DataTable
        dtRegistro.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtRegistro.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtRegistro.Columns.Add("Valor", Type.GetType("System.Decimal")).DefaultValue = 0
        dtRegistro.Columns.Add("Concentracion", Type.GetType("System.Int32"))
        dtRegistro.Columns.Add("U.Medida", Type.GetType("System.String"))
        dtRegistro.Columns.Add("Servicios", Type.GetType("System.Int32")).DefaultValue = 0
        dtRegistro.Columns.Add("Costo", Type.GetType("System.Decimal")).DefaultValue = 0
        dtRegistro.Columns.Add("Recomendacion", Type.GetType("System.Int32")).DefaultValue = 0
    End Sub
End Class
