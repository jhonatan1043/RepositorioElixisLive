Public Class GastoServicioBLL
    Public Shared Function guardar(objGastoServicio As GastoServicio) As GastoServicio
        GastoServicioDAL.guardar(objGastoServicio)
        Return objGastoServicio
    End Function
End Class
