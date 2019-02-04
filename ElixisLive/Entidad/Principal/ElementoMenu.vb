Public Class ElementoMenu
    Public Shared Property codigo As String
    Public Shared Property nombre As String
    Public Shared Property modulo As String
    Public Property nombrePadre As String
    Public Sub New()

    End Sub
    Sub New(pCodigo As String, pNombre As String, pModulo As String, pNombrePadre As String)
        codigo = pCodigo
        nombre = pNombre
        modulo = pModulo
        nombrePadre = pNombrePadre
    End Sub
End Class
