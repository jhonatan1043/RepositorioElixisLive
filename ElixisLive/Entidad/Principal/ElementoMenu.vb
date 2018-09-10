Public Class ElementoMenu
    Public Property codigo As String
    Public Property nombre As String
    Public Property modulo As String

    Sub New()

    End Sub

    Sub New(pCodigo As String, pNombre As String, pModulo As String)
        codigo = pCodigo
        nombre = pNombre
        modulo = pModulo
    End Sub
End Class
