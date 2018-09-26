Public Class EmpresaBLL
    Public Shared Function guardar(objEmpresa As Empresa) As Empresa
        EmpresaDAL.guardar(objEmpresa)
        Return objEmpresa
    End Function
End Class
