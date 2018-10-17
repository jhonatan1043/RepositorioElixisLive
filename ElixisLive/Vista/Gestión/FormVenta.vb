Public Class FormVenta
    Dim codigoCliente As Integer
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
    Private Sub texthistoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextIdentificacion.KeyPress
        ValidacionDigitacion.validarValoresNumericos(e)
        If Asc(e.KeyChar) = 13 Then
            cargarDatosCliente(TextIdentificacion.Text)
        End If
    End Sub
    Private Sub cargarDatosCliente(identificacion As String)
        Dim params As New List(Of String)
        Dim dFila As DataRow
        params.Add(identificacion)
        dFila = Generales.cargarItem(Sentencias.CLIENTE_FACTURA_CARGAR, params)
        Try
            If Not IsNothing(dFila) Then
                codigoCliente = dFila.Item("Codigo")
                TextNombre.Text = dFila.Item("Nombre")
                TextTelefono.Text = dFila.Item("Telefono")
                dgvParametro.Focus()
            Else
                TextNombre.Focus()
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click

    End Sub
End Class