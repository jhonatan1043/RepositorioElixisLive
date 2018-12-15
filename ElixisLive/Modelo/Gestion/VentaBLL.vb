Public Class VentaBLL
    Public Shared Function guardarVenta(objVenta As Venta) As Venta
        VentaDAL.guardarVenta(objVenta)
        Return objVenta
    End Function
    Public Shared Function anularVenta(objVenta As Venta) As Venta
        VentaDAL.anularVenta(objVenta)
        Return objVenta
    End Function
End Class
