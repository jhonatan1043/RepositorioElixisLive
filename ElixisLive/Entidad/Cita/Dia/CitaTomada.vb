Public Class CitaTomada
    Inherits CitaPrevia
    Property idCita As String
    Property nombre As String
    Property cedula As String
    Property fechaCita As DateTime
    Public Sub New()
        altura = Constantes.ALTURA_CITA_TOMADA
        anchura = Constantes.ANCHURA_CITA_TOMADA
    End Sub
    Public Function crearPanel(posicionX As Integer,
                               posicionY As Integer,
                               pendiente As Integer) As Panel
        Dim panel As New Panel
        Try
            panel.Location = New Point(posicionX, posicionY)
            panel.Size = New Point(anchura, altura)
            panel.BackColor = If(pendiente = Constantes.PENDIENTE, Color.FromArgb(192, 255, 255), colorLabel())
            panel.Controls.Add(creaBotones(4, 3, idCita, " Cliente: " & nombre & vbNewLine & " # " & cedula))
            panel.Controls.Add(creaBotones(4, 36, idCita, " Fecha: " & CStr(fechaCita)))
            panel.Tag = hora & "-" & idCita
            panel.Cursor = Cursors.Hand
            panel.Show()
        Catch ex As Exception
            Throw ex
        End Try
        Return panel
    End Function
    Private Function creaBotones(posicionX As Integer,
                                   posicionY As Integer,
                                   idCita As String, Texto As String) As Button
        Dim boton As New Button
        Try
            'boton.BorderStyle = BorderStyle.None
            boton.Size = New Point(130, 29)
            boton.Location = New Point(posicionX, posicionY)
            boton.TextAlign = HorizontalAlignment.Center
            boton.BackColor = Color.White
            boton.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 7)
            'boton.BorderStyle = BorderStyle.FixedSingle
            boton.Cursor = Cursors.Hand
            'boton.Multiline = True
            'boton.ReadOnly = True
            boton.Text = Texto
            boton.Tag = hora & "-" & idCita
            AddHandler boton.DoubleClick, AddressOf UtlidadCitaBLL.llamarFormularioCita
        Catch ex As Exception
            Throw ex
        End Try
        Return boton
    End Function
End Class
