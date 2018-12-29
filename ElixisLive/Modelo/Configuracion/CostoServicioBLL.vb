Public Class CostoServicioBLL
    Public Shared Function guardarCostoServicio(objCostoServicio As CostoServicio) As CostoServicio
        CostoServicioDAL.guardarCostoServicio(objCostoServicio)
        Return objCostoServicio
    End Function
End Class
