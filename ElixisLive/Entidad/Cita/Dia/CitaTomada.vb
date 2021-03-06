﻿Public Class CitaTomada
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
        Dim texto, contener As String
        texto = nombre & vbNewLine & CStr(Format(fechaCita, "HH:mm"))
        contener = posicionX & posicionY
        Try
            panel.Name = contener
            panel.Location = New Point(posicionX, posicionY)
            panel.Size = New Point(anchura, altura)
            panel.BackColor = If(pendiente = Constantes.PENDIENTE, Color.AliceBlue, colorLabel())
            panel.Controls.Add(creaBotones(4, 3, idCita, If(pendiente = Constantes.PENDIENTE, Constantes.CITA_DISPONIBLE, texto), contener))
            panel.Tag = hora & "-" & estado & "-" & idCita
            panel.Cursor = Cursors.Hand
            panel.Show()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
        Return panel
    End Function
    Private Function creaBotones(posicionX As Integer,
                                 posicionY As Integer,
                                 idCita As String,
                                 Texto As String,
                                 nombrePrincipal As String) As Button
        Dim boton As New Button
        Try
            boton.Name = "-" & nombrePrincipal
            boton.Size = New Point(130, 60)
            boton.Location = New Point(posicionX, posicionY)
            boton.TextAlign = ContentAlignment.MiddleCenter
            boton.BackColor = Color.White
            boton.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 8)
            boton.Cursor = Cursors.Hand
            boton.Text = Texto
            boton.Tag = hora & "-" & estado & "-" & idCita
            AddHandler boton.Click, AddressOf UtlidadCitaBLL.llamarFormularioCita
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
        Return boton
    End Function
End Class
