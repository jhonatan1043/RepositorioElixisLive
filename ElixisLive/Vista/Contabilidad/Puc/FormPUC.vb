Public Class FormPUC
    Private Sub FormPUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
    End Sub
End Class