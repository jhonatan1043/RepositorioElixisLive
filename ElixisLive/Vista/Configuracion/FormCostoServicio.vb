Public Class FormCostoServicio
    Dim objCostoServicio As CostoServicio
    Private Sub FormCostoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCostoServicio = New CostoServicio
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        Generales.tabularConEnter(Me)
    End Sub
    Private Sub btBuscarServicio_Click(sender As Object, e As EventArgs) Handles btBuscarServicio.Click

    End Sub
End Class