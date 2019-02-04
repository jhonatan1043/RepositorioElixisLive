Public Class FormFacturaCliente
    Private Sub FormFacturaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.cargarPermiso(Me)
        Generales.deshabilitarControles(Me)
    End Sub
End Class