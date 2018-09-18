Public Class ConfigBLL
    Public Shared Function guardar(objConfig As Configuracion) As Configuracion
        ConfigDAL.guardar(objConfig)
        Return objConfig
    End Function
End Class
