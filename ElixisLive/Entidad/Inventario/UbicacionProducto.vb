Public Class UbicacionProducto
    Inherits generalConsulta
    Property dtProducto As DataTable
    Property dtSetLote As DataSet
    Public Sub New()
        dtProducto = New DataTable
        dtSetLote = New DataSet

        dtProducto.Columns.Add("codigo", Type.GetType("System.Int32"))
        dtProducto.Columns.Add("RegistroLote", Type.GetType("System.String"))
        dtProducto.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dtProducto.Columns.Add("Fecha_Lote", Type.GetType("System.DateTime"))
        dtProducto.Columns.Add("Fecha_Vencimiento", Type.GetType("System.DateTime"))

        sqlGuardar = "[SP_ADMIN_CLIENTE_CREAR]"
        sqlConsulta = "[SP_ADMIN_CLIENTE_CARGAR]"

    End Sub
End Class
