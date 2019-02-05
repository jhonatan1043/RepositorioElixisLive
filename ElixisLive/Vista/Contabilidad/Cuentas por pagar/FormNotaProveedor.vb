Public Class FormNotaProveedor
    Private Sub FormNotaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
    End Sub
End Class