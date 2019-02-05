Public Class FormEstadoCuentas
    Private Sub FormEstadoCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
        bttercero.Enabled = True
    End Sub
End Class