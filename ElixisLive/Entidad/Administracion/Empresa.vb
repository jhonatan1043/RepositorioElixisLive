Public Class Empresa
    Inherits persona
    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = ""
        sqlConsulta = ""
        sqlCargar = ""
        sqlCargarDetalle = ""
    End Sub
End Class
