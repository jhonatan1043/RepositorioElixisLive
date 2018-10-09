Public Class persona
    Inherits generalConsulta
    Property codigo As String
    Property identificacion As String
    Property nombre As String
    Property dtParametro As DataTable
    Property dtRegistro As DataTable
    Property ruta As String
    Property foto As String
    Property bdraControl As Boolean
    Property imagen As PictureBox
    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = ""
        sqlConsulta = ""
        sqlCargar = ""
        sqlCargarDetalle = ""
    End Sub
End Class
