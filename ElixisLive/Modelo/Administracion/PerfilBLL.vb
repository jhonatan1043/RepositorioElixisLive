Public Class PerfilBLL
    Private Shared dsDatos As DataSet
    Dim objPerfilDal As New PerfilDAL
    Public Sub cargarMenu(pcodigoEP As Integer, ByRef dsCuentas As DataSet)
        objPerfilDal.cargarMenuPadre(pcodigoEP, dsCuentas)
        objPerfilDal.cargarMenuHijas(pcodigoEP, dsCuentas)
    End Sub
End Class
