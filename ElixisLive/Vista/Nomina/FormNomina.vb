Public Class FormNomina
    Private Sub cambiarFechaHasta()
        Dim fechaInicio As Date = New DateTime(dateFechaNomina.Value.Year, dateFechaNomina.Value.Month, 15)
        Dim fechaFin As Date = New DateTime(dateFechaNomina.Value.Year, dateFechaNomina.Value.Month, DateTime.DaysInMonth(dateFechaNomina.Value.Year, dateFechaNomina.Value.Month))
        If fechaFin.Date < dtFechaHasta.MaxDate.Date Then
            dtFechaHasta.MinDate = fechaInicio
            dtFechaHasta.MaxDate = fechaFin.AddDays(1).AddSeconds(-1)
        Else
            dtFechaHasta.MaxDate = fechaFin.AddDays(1).AddSeconds(-1)
            dtFechaHasta.MinDate = fechaInicio
        End If
        dtFechaHasta.Value = fechaFin
        'objNomina.mes = fechaInicio
        'objNomina.hasta = dtFechaHasta.Value

    End Sub

    Private Sub FormNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiarFechaHasta()
    End Sub
End Class