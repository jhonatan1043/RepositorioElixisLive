Public Class FormBalanceComprobacion
    Private Sub FormBalanceComprobacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.habilitarControles(Me)
        Generales.asignarPermiso(Me)
    End Sub
End Class