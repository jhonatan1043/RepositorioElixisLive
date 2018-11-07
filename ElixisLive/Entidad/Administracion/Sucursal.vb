Public Class Sucursal
    Inherits persona
    Property identiResponsable As String
    Property responsable As String
    Public Sub New()
        sqlAnular = " "
        sqlCargar = ""
        sqlConsulta = ""
        sqlGuardar = ""
    End Sub
End Class
