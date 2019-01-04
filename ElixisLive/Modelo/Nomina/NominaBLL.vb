Public Class NominaBLL
    Public Function guardarNomina(ByVal nomina As Nomina)
        Return NominaDAL.guardarNomina(nomina)
    End Function
End Class
