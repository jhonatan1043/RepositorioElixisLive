Public Class UbicacionProducto
    Inherits Lote
    Property dtProducto As DataTable
    Property dtSetLote As DataSet
    Property sqlGuardar As String
    Property sqlConsulta As String
    Public Sub New()
        dtProducto = New DataTable
        dtSetLote = New DataSet
        dtLote = New DataTable

        dtProducto.Columns.Add("codigo", Type.GetType("System.Int32"))
        dtProducto.Columns.Add("Nombre", Type.GetType("System.String"))
        dtProducto.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dtProducto.Columns.Add("Ubicacion", Type.GetType("System.String"))

        sqlGuardar = "[SP_INVEN_PRODUCTO_UBICACION_CREAR]"
        sqlConsulta = "[SP_INVEN_PRODUCTO_UBICACION_CARGAR]"

    End Sub
End Class
