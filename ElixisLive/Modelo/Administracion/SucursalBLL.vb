Public Class SucursalBLL
    Public Shared Function guardar(objSucursal As Sucursal) As Sucursal
        SucursalDAL.guardar(objSucursal)
        Return objSucursal
    End Function
End Class
