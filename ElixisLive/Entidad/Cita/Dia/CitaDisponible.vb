Public Class CitaDisponible
    Inherits CitaPrevia
    Private posicionLabelX As Integer
    Private posicionLabelY As Integer
    Private posicionPanelX As Integer
    Public Sub New()
        altura = Constantes.ALTURA_CITA_DISPONIBLE
        anchura = Constantes.ANCHURA_CITA_DISPONIBLE
        posicionPanelX = Constantes.PANEL_POCISION_X '------- posicion x en el panel
        descripcion = Constantes.CITA_DISPONIBLE
        posicionLabelX = 330
        posicionLabelY = 9
    End Sub
    Public Function crearPanelDisponible(posicionPanelY As Integer) As Panel
        Dim panel As New Panel
        panel.Location = New Point(posicionPanelX, posicionPanelY)
        panel.Size = New Point(anchura, altura)
        panel.BackColor = color
        panel.BorderStyle = BorderStyle.None
        panel.Controls.Add(crearEtiquetaDisponible())
        panel.Cursor = Cursors.Hand
        panel.Tag = hora
        AddHandler panel.DoubleClick, AddressOf UtlidadCitaBLL.llamarFormularioCita
        panel.Show()
        Return panel
    End Function
    Public Function crearEtiquetaDisponible() As LinkLabel
        Dim etiqueta As New LinkLabel
        etiqueta.Location = New Point(posicionLabelX, posicionLabelY)
        etiqueta.Size = New Point(100, 20)
        etiqueta.Text = descripcion
        etiqueta.Tag = hora
        AddHandler etiqueta.Click, AddressOf UtlidadCitaBLL.llamarFormularioCita
        Return etiqueta
    End Function
End Class
