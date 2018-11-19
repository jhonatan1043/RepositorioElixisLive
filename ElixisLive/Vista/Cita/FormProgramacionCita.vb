Public Class FormProgramacionCita
    Dim fecha As DateTime
    Private Sub FormProgramacionCita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UtlidadCitaBLL.cargarComboVista(cbVista)
        fecha = dFecha.Value
        UtlidadCitaBLL.objFormCita = Me
    End Sub
    Public Sub validarControles(Optional disSemana As Integer = Constantes.SIN_VALOR_NUMERICO)
        ocultasPaneles()
        Dim formato As String = Nothing
        Try
            Select Case cbVista.SelectedIndex
                Case 0
                    cargarDia()
                    formato = Constantes.FORMATO_FECHA_LARGA
                Case 1
                    cargarSemana(disSemana)
                    formato = Constantes.FORMATO_FECHA_CORTA
                Case 2
                    cargarMes()
                    formato = Constantes.FORMATO_FECHA_CORTA
            End Select
            dFecha.CustomFormat = formato
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarDia()
        limpiarPanel(PanelDia)
        PanelDia.Visible = True
        tamañoPanel(PanelDia)
        cargarInformacion(ProgramacionCitaDiaBLL.cargarCitas(PanelDia,
                                                 Format(CDate(dFecha.Value), Constantes.FORMATO_FECHA),
                                                 txtBusqueda.Text))
    End Sub
    Private Sub cargarSemana(disSemana As Integer)
        limpiarPanel(PanelContenedorSem)
        imagenesSemana()
        tamañoPanel(PanelSemana)
        fecha = fecha.AddDays(disSemana)
        PanelSemana.Visible = True
        cargarInformacion(ProgramacionCitaSemanaBLL.cargarCitas(PanelContenedorSem,
                                              Format(CDate(fecha), Constantes.FORMATO_FECHA),
                                              txtBusqueda.Text,
                                              PanelSemana))
    End Sub
    Private Sub cargarMes()
        limpiarPanel(PanelContenedorMes)
        PanelMes.Visible = True
        tamañoPanel(PanelMes)
        cargarInformacion(ProgramacionCitaMesesBLL.cargarCitas(PanelContenedorMes,
                                             Format(CDate(dFecha.Value), Constantes.FORMATO_FECHA),
                                             txtBusqueda.Text))
    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        If String.IsNullOrEmpty(txtBusqueda.Text) Then
            validarControles()
        End If
    End Sub
    Private Sub ptAtras_Click(sender As Object, e As EventArgs) Handles ptAtras.Click
        validarControles(-Constantes.DIA_SEMANA)
        dFecha.Value = dFecha.Value.AddDays(-Constantes.DIA_SEMANA)
    End Sub
    Private Sub ptSiguiente_Click(sender As Object, e As EventArgs) Handles ptSiguiente.Click
        validarControles(+Constantes.DIA_SEMANA)
        dFecha.Value = dFecha.Value.AddDays(+Constantes.DIA_SEMANA)
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
    Private Sub imagenesSemana()
        'ptAtras.Image = My.Resources.Arrow_Back_3_icon
        'ptSiguiente.Image = My.Resources.Arrow_Back_3_icon___copia
    End Sub
    Private Sub tamañoPanel(panel As Panel)
        panel.Size = New Point(788, 401)
        panel.Location = New Point(11, 85)
    End Sub
    Private Sub ocultasPaneles()
        PanelDia.Visible = False
        PanelSemana.Visible = False
        PanelMes.Visible = False
    End Sub
    Private Sub comboAreaServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVista.SelectedIndexChanged
        If Not IsNothing(cbVista.ValueMember) Then
            validarControles()
        End If
    End Sub
End Class