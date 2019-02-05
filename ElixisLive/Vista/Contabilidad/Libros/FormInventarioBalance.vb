Public Class FormInventarioBalance
    Private Sub FormInventarioBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.habilitarControles(Me)
        Generales.asignarPermiso(Me)
    End Sub
End Class