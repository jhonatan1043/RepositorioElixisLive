Public Class FormProgramacionCita
    Dim fecha As DateTime
    Property codigoCita As Integer
    Dim panelAux As Panel
    Private Sub FormProgramacionCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecha = Format(dFecha.Value, Constantes.FORMATO_FECHA_HORA)
        UtlidadCitaBLL.objFormCita = Me
        validarControles()
    End Sub
    Public Sub validarControles()
        Try
            cargarDia()
            dFecha.CustomFormat = Constantes.FORMATO_FECHA_LARGA
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarDia()
        Try
            limpiarPanel(PanelDia)
            PanelDia.Visible = True
            cargarInformacion(ProgramacionCitaDiaBLL.cargarCitas(PanelDia,
                                                                 Format(CDate(dFecha.Value), Constantes.FORMATO_FECHA),
                                                                 txtBusqueda.Text))
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If String.IsNullOrEmpty(txtBusqueda.Text) Then
            validarControles()
        End If
    End Sub
    Private Sub dFecha_TextChanged(sender As Object, e As EventArgs) Handles dFecha.ValueChanged
        validarControles()
    End Sub
    Private Sub limpiarPanel(panel As Panel)
        Dim numeroControles As Integer
        Dim control As Control
        Try
            numeroControles = panel.Controls.Count - 1
            If numeroControles > 0 Then
                For posicion = numeroControles To 0 Step -1
                    control = panel.Controls(posicion)
                    panel.Controls.Remove(control)
                    control.Dispose()
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub cargarInformacion(params As List(Of String))
        txtPendiente.Text = params.Item(0)
        txtRealizado.Text = params.Item(1)
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        dFecha.Value = MonthCalendar1.SelectionStart.ToString
    End Sub
    Private Sub btRealizado_Click(sender As Object, e As EventArgs) Handles btRealizado.Click
        If EstiloMensajes.mostrarMensajePregunta("¿ Desea Confirmar la cita ?") = Constantes.SI Then
            cambiarEstado(Constantes.CITA_REALIZADA)
            validarControles()
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta("¿ Desea Cancelar la cita ?") = Constantes.SI Then
            cambiarEstado(Constantes.CITA_CANCELADA)
            validarControles()
        End If
    End Sub
    Public Sub posicionFormulario(posicionX As Integer,
                                  posicionY As Integer,
                                  contenedor As Panel)
        panelAux = clonarControl(pnEstado, posicionX, posicionY)
        contenedor.Controls.Add(panelAux)
        panelAux.BringToFront()
    End Sub
    Private Function clonarControl(ByVal Pclonar As Panel,
                                   posicionX As Integer,
                                   posicionY As Integer) As Panel
        Pclonar.Visible = True
        Pclonar.Location = New Point(posicionX, posicionY)
        Pclonar.Focus()
        Return Pclonar
    End Function
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
    Private Sub pnEstado_KeyDown(sender As Object, e As KeyEventArgs) Handles pnEstado.KeyDown
        If e.KeyCode = Keys.Escape Then
            panelAux.Visible = False
        End If
    End Sub
    Private Sub pnEstado_Leave(sender As Object, e As EventArgs) Handles pnEstado.Leave
        panelAux.Visible = False
    End Sub
End Class