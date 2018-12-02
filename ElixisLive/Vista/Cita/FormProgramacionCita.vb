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
    Public Sub posicionFormulario(posicionX As Integer,
                                  posicionY As Integer,
                                  contenedor As Panel)
        panelAux = New Panel
        panelAux.Location = New Point(posicionX, posicionY)
        panelAux.Size = New Point(130, 58)
        panelAux.BackColor = Color.Black
        panelAux.Controls.Add(crearBotones(1, 1, Constantes.CITA_CANCELADA, Color.AliceBlue, "Cancelar Cita"))
        panelAux.Controls.Add(crearBotones(65, 1, Constantes.CITA_REALIZADA, Color.FromArgb(255, 192, 192), "Confirmar Cita"))
        contenedor.Controls.Add(panelAux)
        AddHandler panelAux.PreviewKeyDown, AddressOf eventoEscape
        AddHandler panelAux.LostFocus, AddressOf eventoSalir
        panelAux.Focus()
        panelAux.BringToFront()
        panelAux.Show()
    End Sub
    Private Function crearBotones(tamanoX As Integer,
                                  tamanoY As Integer,
                                  estado As String,
                                  color As Color, texto As String) As Button
        Dim boton As New Button
        boton.Size = New Point(64, 57)
        boton.Location = New Point(tamanoX, tamanoY)
        boton.Tag = estado
        boton.BackColor = color
        boton.Text = texto
        ToolTip1.SetToolTip(boton, texto)
        boton.TextAlign = ContentAlignment.MiddleCenter
        boton.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 8)
        AddHandler boton.Click, AddressOf cambiarEstado
        boton.Show()
        Return boton
    End Function
    Private Sub cambiarEstado(sender As Object, e As EventArgs)
        Dim params As New List(Of String)
        Dim cadenaPrametros As String
        Dim msjCita As String
        msjCita = If(sender.tag = Constantes.CITA_CANCELADA,
                                  "¿ Desea Cancelar la cita ?",
                                  "¿ Desea Confirmar la cita ?")

        If EstiloMensajes.mostrarMensajePregunta(msjCita) = Constantes.SI Then
            params.Add(codigoCita)
            params.Add(sender.tag)
            cadenaPrametros = Funciones.getParametros(params)
            If Generales.ejecutarSQL(Sentencias.CITA_CAMBIO_ESTADO & cadenaPrametros) Then
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            End If
            validarControles()
        End If
    End Sub
    Private Sub eventoEscape(sender As Object, e As PreviewKeyDownEventArgs)
        If e.KeyCode = Keys.Escape Then
            panelAux.Dispose()
        End If
    End Sub
    Private Sub eventoSalir()
        panelAux.Dispose()
    End Sub
End Class