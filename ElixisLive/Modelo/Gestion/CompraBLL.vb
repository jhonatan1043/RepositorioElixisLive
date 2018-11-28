Public Class CompraBLL
    Public Shared Function guardarCompra(objCompra As Compra) As Compra
        CompraDAL.guardarCompra(objCompra)
        Return objCompra
    End Function
End Class
