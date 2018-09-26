Public Class producto
    Inherits persona
    Property codigoProducto As String
    Property fecha As DateTime
    Property foto As Byte()

    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = "[SP_INVEN_PRODUCTO_CREAR]"
        sqlConsulta = "[SP_INVEN_PRODUCTO_CONSULTAR]"
        sqlCargar = "SP_INVEN_PRODUCTO_CARGAR"
        sqlCargarDetalle = "[SP_INVEN_PRODUCTO_CARGAR_D]"
    End Sub

End Class
