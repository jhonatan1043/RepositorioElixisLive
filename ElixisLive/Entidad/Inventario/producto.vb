Public Class producto
    Inherits persona
    Property codigoMarca As Integer
    Property codigoBarra As String
    Property codigoCategoria As Integer
    Property nombreCompleto As String
    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = "[SP_INVEN_PRODUCTO_CREAR]"
        sqlConsulta = "[SP_INVEN_PRODUCTO_CONSULTAR]"
        sqlCargar = "SP_INVEN_PRODUCTO_CARGAR"
        sqlCargarDetalle = "[SP_INVEN_PRODUCTO_CARGAR_D]"
        sqlAnular = "[SP_INVEN_PRODUCTO_ANULADO] "
    End Sub

End Class
