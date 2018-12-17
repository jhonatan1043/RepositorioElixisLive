Public Class CostoServicio
    Inherits generalConsulta
    Property codigoServicio As Integer
    Property dtRegistro As DataTable
    Public Sub New()
        dtRegistro = New DataTable
        dtRegistro.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtRegistro.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtRegistro.Columns.Add("Valor", Type.GetType("System.Decimal"))
        dtRegistro.Columns.Add("Cantidad_Recomendacion", Type.GetType("System.Int32"))
        dtRegistro.Columns.Add("", Type.GetType("System.Int32"))
    End Sub
End Class
