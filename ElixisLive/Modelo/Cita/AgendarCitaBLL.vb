Public Class AgendarCitaBLL
    Public Shared Function guardarCita(objCita As AgendarCita) As AgendarCita
        AgendarCitaDAL.guardarCita(objCita)
        Return objCita
    End Function
End Class
