Public Class producto
    Inherits generalConsulta
    Property codigoProducto As String
    Property nombre As String
    Property fecha As DateTime
    Property foto As Byte()
    Property dtParametro As DataTable
    Property dtRegistro As DataTable
    Property bdraControl As Boolean
    Public Sub New()
        sqlGuardar = "[SP_INVERT_PRODUCTO_CREAR]"
    End Sub

End Class
