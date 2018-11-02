Public Class PerfilBLL
    Private Shared dsDatos As DataSet
    Public Shared Function guardarPerfil(objPerfil As Perfil) As Perfil
        PerfilDAL.guardarPerfil(objPerfil)
        Return objPerfil
    End Function

End Class
