Public Class UtlidadCitaBLL
    Shared Property objFormCita As FormProgramacionCita
    Shared Property fechaDia As DateTime
    Shared Property fechaCita As Date

    Public Shared Function cargarFestivosMes(fecha As Date) As DataTable
        Dim dt As New DataTable
        Dim params As New List(Of String)
        Dim fechaInicio, fechaFin As Date
        Dim UltimoDia As Integer = DateTime.DaysInMonth(fecha.Year, fecha.Month)

        Try
            fechaInicio = DateAdd(DateInterval.Day, -fecha.Day, fecha).AddDays(1)
            fechaFin = DateAdd(DateInterval.Day, -fecha.Day, fecha).AddDays(UltimoDia)

            params.Add(Format(fechaInicio, "yyyy-MM-dd hh:mm:ss"))
            params.Add(Format(fechaFin, "yyyy-MM-dd hh:mm:ss"))

            Generales.llenarTabla("", params, dt)

        Catch ex As Exception
            Throw
        End Try

        Return dt
    End Function
    Public Shared Function cargarProgramacionCita(Fecha As Date,
                                                  busqueda As String) As DataTable
        Dim params As New List(Of String)
        Dim dtable As New DataTable
        Try
            params.Add(Fecha)
            params.Add(If(String.IsNullOrEmpty(busqueda), Nothing, busqueda))
            Generales.llenarTabla("[SP_ADMIN_PROGRAMACION_CITA]", params, dtable)
        Catch ex As Exception
            Throw ex
        End Try
        Return dtable
    End Function

    Public Shared Sub llamarFormularioCita(sender As Object, e As EventArgs)
        Dim idCita As String = Nothing
        Dim formCitaMedica As New FormCitaMedica
        Dim horaExtraida As String = Nothing
        Dim estadoCita As String = Nothing
        Dim panelPrincipal As String = Nothing
        Dim auxiliar As Integer
        Try
            auxiliar = sender.tag.ToString.Length
            If auxiliar > 2 Then
                horaExtraida = If(auxiliar = 4, sender.tag.ToString.Remove(2), sender.tag.ToString.Remove(2))
                idCita = If(auxiliar = 4, Nothing, sender.tag.ToString.Substring(5))
                estadoCita = If(auxiliar = 4, Nothing, sender.tag.ToString.Substring(3).Remove(1))
                panelPrincipal = sender.Name.ToString.Substring(1)
            Else
                horaExtraida = sender.tag
            End If

            Select Case estadoCita
                Case Constantes.CITA_PENDIENTE
                    objFormCita.codigoCita = idCita
                    objFormCita.posicionFormulario(sender.Location.X,
                                                   sender.Location.Y,
                                                   GetReference(panelPrincipal, objFormCita.PanelDia))
                Case Nothing
                    If Not String.IsNullOrEmpty(idCita) Then
                        formCitaMedica.estadoRegistro = True
                        formCitaMedica.codigoCita = idCita
                    End If
                    formCitaMedica.objFormularioProgram = objFormCita
                    formCitaMedica.fechaHora = fechaDia.AddHours(-fechaDia.Hour).AddHours(horaExtraida)
                    formCitaMedica.ShowDialog()
            End Select

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Shared Function horaDia(posicion As Integer) As String
        Dim hora As String
        Dim fecha As DateTime = DateTime.Now
        fecha = fecha.AddHours(-fecha.Hour)
        fecha = fecha.AddHours(+6)
        fecha = fecha.AddHours(+posicion)
        hora = Format(fecha, "HH:00:00")
        Return hora
    End Function
    Public Shared Function extraeDiaCalendario(posicion As Integer,
                                              Fecha As Date,
                                              ByRef fechaModific As Date) As String
        Dim dia As String
        Dim primerDiaMesNum, diaSemana As String
        Dim nombreMes As String
        Try
            fechaModific = Fecha
            diaSemana = Weekday(fechaModific) - 1
            fechaModific = fechaModific.AddDays(-diaSemana).AddDays(posicion)
            primerDiaMesNum = Format(fechaModific, "dd")
            nombreMes = UCase(Strings.Left(Format(fechaModific, "MMMM"), 4)).ToLower
            dia = primerDiaMesNum
        Catch ex As Exception
            Throw ex
        End Try
        Return dia & " " & nombreMes
    End Function
    Public Shared Function extraeCalendarioPrimerDia(posicion As Integer,
                                                     Fecha As Date,
                                                     ByRef fechaModific As Date) As String
        Dim dia As String
        Dim primerDiaMesNum, diaSemana As String
        Try
            fechaModific = Fecha
            fechaModific = fechaModific.AddDays(-fechaModific.Day).AddDays(1)
            diaSemana = Weekday(fechaModific) - 1
            fechaModific = fechaModific.AddDays(-diaSemana).AddDays(posicion)
            primerDiaMesNum = Format(fechaModific, "dd")
            dia = primerDiaMesNum
        Catch ex As Exception
            Throw ex
        End Try
        Return dia
    End Function
    Public Shared Function GetReference(ByVal nombreControl As String, panel As Panel) As Control
        For Each controlSuperior As Control In panel.Controls
            If (TypeOf controlSuperior Is Panel) Then
                If controlSuperior.Name.ToLower = nombreControl.ToLower Then
                    Return controlSuperior
                End If
            End If
        Next
        Return Nothing
    End Function
End Class
