Public Class ConfigVentaBLL
    Public Shared Function guardarConfVenta(objConfVenta As ConfigVenta) As ConfigVenta
        ConfigVentaDAL.guardar(objConfVenta)
        Return objConfVenta
    End Function
End Class
