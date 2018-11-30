Public Class FormEstadoCita
    Property codigoCita As Integer
    Property objFormProgram As FormProgramacionCita
    Private Sub txtRealizado_Click(sender As Object, e As EventArgs) Handles txtRealizado.Click
        If EstiloMensajes.mostrarMensajePregunta("¿ Desea Confirmar la cita ?") = Constantes.SI Then
            cambiarEstado(Constantes.CITA_REALIZADA)
            objFormProgram.validarControles()
            Close()
        End If
    End Sub
    Private Sub txtCancelado_Click(sender As Object, e As EventArgs) Handles txtCancelado.Click
        If EstiloMensajes.mostrarMensajePregunta("¿ Desea cancelar la cita ?") = Constantes.SI Then
            cambiarEstado(Constantes.CITA_CANCELADA)
            objFormProgram.validarControles()
            Close()
        End If
    End Sub
    Public Sub posicionFormulario(posicionX As Integer,
                                  posicionY As Integer, contenedor As Panel)
        Me.TopLevel = False
        Me.Location = New Point(posicionX, posicionY)
        contenedor.Controls.Add(Me)
    End Sub
    Private Sub cambiarEstado(Estado As String)
        Dim params As New List(Of String)
        Dim cadenaPrametros As String
        params.Add(codigoCita)
        params.Add(Estado)
        cadenaPrametros = Funciones.getParametros(params)
        If Generales.ejecutarSQL(Sentencias.CITA_CAMBIO_ESTADO & cadenaPrametros) Then
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
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