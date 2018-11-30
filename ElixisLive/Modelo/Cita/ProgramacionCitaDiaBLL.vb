﻿Public Class ProgramacionCitaDiaBLL
    Private Shared incrementoPanel, incrementoX, incrementoSaltoLinea As Integer
    Private Shared objHoraDisponible As HoraDisponible
    Private Shared objDisponible As CitaDisponible
    Private Shared objHoraTomada As HoraTomada
    Private Shared objTomada As CitaTomada
    Private Shared panelCreado As Panel
    Private Shared contenedorPanelDispon As Integer
    Private Shared contenedorPanelX As Integer
    Private Shared Sub valoresInicialesDia()
        contenedorPanelDispon = Constantes.VALOR_INICIAL
        incrementoPanel = Constantes.VALOR_INCREMENTO
        incrementoX = 145
        contenedorPanelX = Constantes.PANEL_POCISION_X
        incrementoSaltoLinea = 72
    End Sub
#Region "Citas Asignadas"
    Private Shared Function cargarPanelHoraTomada(ByRef panel As Panel, hora As String) As Integer
        Try
            objHoraTomada = New HoraTomada
            objHoraTomada.color = Color.SteelBlue
            objHoraTomada.hora = hora
            panel.Controls.Add(objHoraTomada.crearPanelHoraTomada(contenedorPanelDispon, 30))
        Catch ex As Exception
            Throw ex
        End Try
        Return 100
    End Function
    Private Shared Sub cargarPanelTomada(ByRef panel As Panel,
                                         filas() As DataRow, hora As String)
        Dim pendiente As Integer
        Try
            For fil = 0 To filas.Count
                objTomada = New CitaTomada

                If fil < filas.Count Then

                    objTomada.idCita = filas(fil).Item("codigo_cita")
                    objTomada.cedula = filas(fil).Item("Identificacion")
                    objTomada.nombre = filas(fil).Item("Nombre")
                    objTomada.fechaCita = filas(fil).Item("Fecha_cita")
                    objTomada.estado = filas(fil).Item("Estado_Atencion")
                    UtlidadCitaBLL.fechaCita = filas(fil).Item("Fecha_cita")

                    pendiente = 1
                Else
                    pendiente = Constantes.PENDIENTE
                End If

                objTomada.hora = hora

                If contenedorPanelX >= Constantes.ANCHURA_CITA_DISPONIBLE Then
                    contenedorPanelDispon = contenedorPanelDispon + incrementoSaltoLinea
                    contenedorPanelX = Constantes.PANEL_POCISION_X
                End If

                panelCreado = objTomada.crearPanel(contenedorPanelX, contenedorPanelDispon, pendiente)
                panel.Controls.Add(panelCreado)

                contenedorPanelX = contenedorPanelX + incrementoX
            Next
            contenedorPanelX = Constantes.PANEL_POCISION_X
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
#Region "Citas no Asignada"
    Private Shared Sub cargarPanelHoraDisponible(ByRef panel As Panel, hora As String)
        Try
            objHoraDisponible = New HoraDisponible
            objHoraDisponible.color = Color.SteelBlue
            objHoraDisponible.hora = hora
            panel.Controls.Add(objHoraDisponible.crearPanelHoraDisponible(contenedorPanelDispon, 8))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Shared Sub cargarPanelDisponible(ByRef panel As Panel, hora As String)
        Try
            objDisponible = New CitaDisponible
            objDisponible.color = Color.AliceBlue
            objDisponible.hora = hora
            panelCreado = objDisponible.crearPanelDisponible(contenedorPanelDispon)
            panel.Controls.Add(panelCreado)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
    Public Shared Function cargarCitas(panel As Panel,
                                  fecha As Date,
                                  busqueda As String) As List(Of String)

        Dim dtCitas As DataTable
        Dim horaCita As String
        Dim extratoHora As String
        Dim params As New List(Of String)

        Try
            dtCitas = UtlidadCitaBLL.cargarProgramacionCita(fecha, busqueda)
            valoresInicialesDia()

            params.Add(dtCitas.Select("Estado_Atencion='P'").Count.ToString)
            params.Add(dtCitas.Select("Estado_Atencion='R'").Count.ToString)

            For posicion = 0 To 18

                horaCita = UtlidadCitaBLL.horaDia(posicion)
                extratoHora = horaCita.Remove(2)
                UtlidadCitaBLL.fechaDia = fecha

                If dtCitas.Select("Hora='" + extratoHora & "'").Count > 0 Then
                    citaAsignada(panel, horaCita, dtCitas.Select("Hora='" + extratoHora & "'"))
                Else
                    citasNoAsignadas(panel, horaCita)
                End If

            Next
        Catch ex As Exception
            Throw ex
        End Try
        Return params
    End Function
    Private Shared Sub citasNoAsignadas(panel As Panel, hora As String)
        cargarPanelHoraDisponible(panel, hora)
        cargarPanelDisponible(panel, hora.Remove(2))
        contenedorPanelDispon = contenedorPanelDispon + incrementoPanel
    End Sub
    Private Shared Sub citaAsignada(panel As Panel,
                                    hora As String,
                                    fila() As DataRow)
        cargarPanelHoraTomada(panel, hora)
        cargarPanelTomada(panel, fila, hora.Remove(2))
        contenedorPanelDispon = contenedorPanelDispon + incrementoSaltoLinea
    End Sub

End Class
