Public Class PerfilBLL
    Private Shared dsDatos As DataSet
    Public Shared Function guardarPerfil(objPerfil As Perfil) As Perfil
        PerfilDAL.crearPerfil(objPerfil)
        Return objPerfil
    End Function

End Class
