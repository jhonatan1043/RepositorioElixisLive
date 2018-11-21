Public Class FormProgramacionCita
    Dim fecha As DateTime
    Private Sub FormProgramacionCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UtlidadCitaBLL.cargarComboVista(cbVista)
        fecha = dFecha.Value
        UtlidadCitaBLL.objFormCita = Me
    End Sub

    Public Sub validarControles(Optional disSemana As Integer = Constantes.SIN_VALOR_NUMERICO)
        Dim formato As String = Nothing
        Try
            Select Case cbVista.SelectedIndex
                Case 0
                    cargarDia()
                    formato = Constantes.FORMATO_FECHA_LARGA
            End Select
            dFecha.CustomFormat = formato
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

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Enter Then
            validarControles()
        End If
    End Sub
    Private Sub dFecha_TextChanged(sender As Object, e As EventArgs) Handles dFecha.TextChanged
        If Not IsNothing(cbVista.ValueMember) Then
            validarControles()
        End If
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
    Private Sub comboAreaServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVista.SelectedIndexChanged
        If Not IsNothing(cbVista.ValueMember) Then
            validarControles()
        End If
    End Sub
End Class