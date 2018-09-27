Public Class Empleado
    Inherits persona
    Property foto As Byte()

    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = ""
        sqlConsulta = ""
        sqlCargar = ""
        sqlCargarDetalle = ""
    End Sub
End Class
