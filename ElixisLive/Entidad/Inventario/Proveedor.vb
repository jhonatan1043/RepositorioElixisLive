Public Class Proveedor
    Inherits Empleado
    Property CodigoTipoPago As Integer
    Property codigoRegimen As Integer
    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = "[SP_ADMIN_PROVEEDOR_CREAR]"
        sqlConsulta = "[SP_ADMIN_PROVEEDOR_CONSULTAR]"
        sqlCargar = "SP_ADMIN_PROVEEDOR_CARGAR"
        sqlCargarDetalle = "[SP_ADMIN_PROVEEDOR_CARGAR_D]"
    End Sub

End Class
