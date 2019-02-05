Public Class FormFacturaCliente
    Private Sub FormFacturaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.asignarPermiso(Me)
        Generales.deshabilitarControles(Me)
    End Sub
End Class