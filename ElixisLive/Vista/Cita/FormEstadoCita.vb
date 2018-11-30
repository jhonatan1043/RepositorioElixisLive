Public Class FormEstadoCita
    Property codigoCita As Integer
    Private Sub txtRealizado_Click(sender As Object, e As EventArgs) Handles txtRealizado.Click
        cambiarEstado(Constantes.CITA_REALIZADA)
        Close()
    End Sub
    Private Sub txtCancelado_Click(sender As Object, e As EventArgs) Handles txtCancelado.Click
        cambiarEstado("C")
        Close()
    End Sub
    Public Sub posicionFormulario(posicionX As Integer, posicionY As Integer)
        Me.Location = New Point(posicionX, posicionY)
    End Sub
    Private Sub cambiarEstado(Estado As String)
        Dim params As New List(Of String)
        Dim cadenaPrametros As String
        params.Add(codigoCita)
        params.Add(Estado)
        cadenaPrametros = Funciones.getParametros(params)
        If Generales.ejecutarSQL(" " & cadenaPrametros) Then

        End If
    End Sub
    Private Sub FormEstadoCita_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        End If
    End Sub
    Private Sub FormEstadoCita_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Close()
    End Sub
End Class