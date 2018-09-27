Public Class PersonaBLL
    Public Shared Function guardar(objPersona As persona) As persona
        PersonaDAL.guardar(objPersona)
        Return objPersona
    End Function
End Class
