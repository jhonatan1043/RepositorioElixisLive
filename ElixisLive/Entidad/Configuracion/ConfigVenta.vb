Public Class ConfigVenta
    Inherits generalConsulta
    Property codigoListaProducto As Integer
    Property codigoListaServicio As Integer
    Property dtEvento As DataTable
    Public Sub New()
        sqlGuardar = "[SP_CONFI_VENTA_CREAR]"
        sqlCargar = "[SP_CONFI_VENTA_CARGAR]"
    End Sub
End Class
