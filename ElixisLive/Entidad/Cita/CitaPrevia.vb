Public Class CitaPrevia
    Property altura As Integer
    Property anchura As Integer
    Property descripcion As String
    Property color As Color
    Property estado As String
    Property hora As String
    Public Function colorLabel() As Color
        Select Case estado
            Case "P"
                color = Color.FromArgb(Constantes.COLOR_AGENDADO)
            Case "C"
                color = Color.FromArgb(Constantes.COLOR_CANCELADO)
            Case "R"
                color = Color.FromArgb(Constantes.COLOR_REALIZADO)
        End Select
        Return color
    End Function
End Class
