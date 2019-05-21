Public Class RemisionInventario
    Inherits Venta

    Property observacion As String
    Public Sub New()
        sqlAnular = "[SP_INVEN_REMISION_ANULAR]"
        sqlCargar = "[SP_INVEN_REMISION_CARGAR]"
        sqlConsulta = "[SP_INVEN_REMISION_BUSCAR]"
        sqlGuardar = "[SP_INVEN_REMISION_CREAR]"
    End Sub
End Class
