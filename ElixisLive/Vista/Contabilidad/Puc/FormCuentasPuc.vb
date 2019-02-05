Public Class FormCuentasPuc
    Private Sub FormCuentasPuc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
    End Sub
End Class