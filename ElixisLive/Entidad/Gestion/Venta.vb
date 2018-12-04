Public Class Venta
    Inherits generalConsulta
    Property codigoCliente As Integer
    Property dtProductos As DataTable
    Public Sub New()
        dtProductos = New DataTable
        dtProductos.Columns.Add("codigo", Type.GetType("System.Int32"))
        dtProductos.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtProductos.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        dtProductos.Columns.Add("Valor", Type.GetType("System.Int32")).DefaultValue = 0
        dtProductos.Columns.Add("Total", Type.GetType("System.Int32")).DefaultValue = 0
        dtProductos.Columns.Add("Tipo", Type.GetType("System.String"))
    End Sub
End Class
