Public Class RemisionInventario
    Inherits generalConsulta
    Property codigo As String
    Property codigoPersonaCliente As String
    Property identificacion As String
    Property nombre As String
    Property telefono As String
    Property observacion As String
    Property dtProductos As DataTable
    Property estadoAnulado As Boolean
    Property estadoFilaNueva As Boolean
    Property descuentoCliente As Decimal
    Property indice As Integer
    Public Sub New()
        dtProductos = New DataTable

        dtProductos.Columns.Add("codigo", Type.GetType("System.String"))
        dtProductos.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtProductos.Columns.Add("Stock", Type.GetType("System.Int32"))
        dtProductos.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        dtProductos.Columns.Add("Valor", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("descuento", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("Valordescuento", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("Total", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("EmpleadoP", Type.GetType("System.String"))
        dtProductos.Columns.Add("EmpleadoN", Type.GetType("System.String"))

        sqlAnular = "[SP_INVEN_REMISION_ANULAR]"
        sqlCargar = "[SP_INVEN_REMISION_CARGAR]"
        sqlConsulta = "[SP_INVEN_REMISION_BUSCAR]"
        sqlGuardar = "[SP_INVEN_REMISION_CREAR]"

    End Sub
End Class
