Public Class FormProgramacionCita
    Dim fecha As DateTime
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
        limpiarPanel(PanelDia)
        PanelDia.Visible = True
        cargarInformacion(ProgramacionCitaDiaBLL.cargarCitas(PanelDia,
                                                 Format(CDate(dFecha.Value), Constantes.FORMATO_FECHA),
                                                 txtBusqueda.Text))
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
        txtCancelado.Text = params.Item(1)
        txtRealizado.Text = params.Item(2)
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        dFecha.Value = MonthCalendar1.SelectionStart.ToString
    End Sub
End Class