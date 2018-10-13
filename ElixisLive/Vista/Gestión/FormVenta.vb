Public Class FormVenta
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.diseñoDGV(dgvParametro)
        Generales.deshabilitarBotones(ToolStrip1)
        btNuevo.Enabled = True
        btBuscar.Enabled = True
    End Sub
    Private Sub TextIdentificacion_TextChanged(sender As Object, e As EventArgs) Handles TextIdentificacion.TextChanged
        Dim dV As New DigitoVerificacion
        Dim numero As Integer
        numero = dV.calculaNit(TextIdentificacion.Text)
        TextDV.Text = CType(numero, String)
        If TextIdentificacion.Text = Nothing Then
            TextDV.Text = Nothing
        End If
    End Sub
End Class