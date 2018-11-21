Public Class AgendarCita
    Inherits generalConsulta
    Property codigo As String
    Property dtServicio As DataTable
    Property codigoPersona As Integer
    Property dtFechaCita As DateTime
    Property observacion As String
    Public Sub New()
        sqlGuardar = "[SP_ADMIN_CITA_CREAR]"
        sqlCargar = ""
        sqlAnular = ""
    End Sub

End Class
