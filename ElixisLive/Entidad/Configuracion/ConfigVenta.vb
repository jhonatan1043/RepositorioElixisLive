Public Class ConfigVenta
    Inherits generalConsulta
    Property codigoListaProducto As String
    Property codigoListaServicio As String
    Property indice As Integer
    Property dtEvento As DataTable
    Public Sub New()
        dtEvento = New DataTable
        dtEvento.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtEvento.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtEvento.Columns.Add("Descuento", Type.GetType("System.Int32")).DefaultValue = 0
        dtEvento.Columns.Add("F_Inicio", Type.GetType("System.DateTime"))
        dtEvento.Columns.Add("F_Fin", Type.GetType("System.DateTime"))

        sqlGuardar = "[SP_CONFI_VENTA_CREAR]"
        sqlCargar = "[SP_CONFI_VENTA_CARGAR]"

    End Sub
End Class
