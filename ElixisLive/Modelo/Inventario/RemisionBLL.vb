Public Class RemisionBLL
    Public Shared Function guardarRemision(objVenta As RemisionInventario) As RemisionInventario
        RemisionDAL.guardarVenta(objVenta)
        Return objVenta
    End Function
    Public Shared Function anularVenta(objVenta As RemisionInventario) As RemisionInventario
        RemisionDAL.anularVenta(objVenta)
        Return objVenta
    End Function
End Class
