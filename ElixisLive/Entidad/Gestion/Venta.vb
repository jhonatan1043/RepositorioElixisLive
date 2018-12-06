Public Class Venta
    Inherits generalConsulta
    Property codigo As String
    Property codigoPersonaCliente As Integer
    Property codigoPersonaEmpleado As Integer
    Property dtProductos As DataTable
    Public Sub New()
        dtProductos = New DataTable
        dtProductos.Columns.Add("codigo", Type.GetType("System.Int32"))
        dtProductos.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtProductos.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        dtProductos.Columns.Add("Valor", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("Total", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("Tipo", Type.GetType("System.String"))
        sqlAnular = ""
        sqlCargar = ""
        sqlCargarDetalle = ""
        sqlConsulta = ""
        sqlGuardar = ""
    End Sub
End Class
