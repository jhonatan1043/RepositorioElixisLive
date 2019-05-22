Public Class ModuloBLL
    Dim moduloDal As New ModuloDAL
    Public Sub guardarModulo(ByVal modulo As Modulo)
        moduloDal.guardarModulo(modulo)
    End Sub
End Class
