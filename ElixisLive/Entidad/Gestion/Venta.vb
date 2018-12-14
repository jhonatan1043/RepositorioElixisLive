Public Class Venta
    Inherits generalConsulta
    Property codigo As String
    Property codigoPersonaCliente As String
    Property identificacion As String
    Property nombre As String
    Property telefono As String
    Property dtProductos As DataTable
    Property dtServicio As DataTable
    Public Sub New()
        dtProductos = New DataTable
        dtServicio = New DataTable

        dtProductos.Columns.Add("codigo", Type.GetType("System.Int32"))
        dtProductos.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtProductos.Columns.Add("Stock", Type.GetType("System.Int32"))
        dtProductos.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        dtProductos.Columns.Add("Valor", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("Total", Type.GetType("System.Decimal")).DefaultValue = 0

        dtServicio.Columns.Add("codigo", Type.GetType("System.Int32"))
        dtServicio.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtServicio.Columns.Add("ValorServicio", Type.GetType("System.Decimal")).DefaultValue = 0
        dtServicio.Columns.Add("codigo_Empleado", Type.GetType("System.String"))
        dtServicio.Columns.Add("NombreEmpleado", Type.GetType("System.String"))

        sqlAnular = ""
        sqlCargar = ""
        sqlCargarDetalle = ""
        sqlConsulta = ""
        sqlGuardar = "[SP_INVEN_VENTA_CREAR]"

    End Sub
End Class
