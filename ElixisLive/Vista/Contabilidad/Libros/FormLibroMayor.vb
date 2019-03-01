Imports CrystalDecisions.Shared

Public Class FormLibroMayor
    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Public Function crearParametros() As LibroMayorParams
        Dim params As New LibroMayorParams
        params.fechaInicio = dtpFechaInicio.Value
        params.fechaFin = dtpFechaFin.Value
        Return params
    End Function

    Private Sub btExportaExcel_Click(sender As Object, e As EventArgs) Handles btExportaExcel.Click
        Try
            Dim nombreRpt As String = "libro_mayor01"
            Dim dtLibroMayor As New DataTable
            Dim params As New List(Of String)
            Cursor = Cursors.WaitCursor
            params.Add(CDate(dtpFechaInicio.Value).Date)
            params.Add(CDate(dtpFechaFin.Value).Date)
            Generales.llenarTabla("SP_E_LIBRO_MAYOR_CARGAR_PADRES_XLS", params, dtLibroMayor)
            Dim rutaArchivo As String = FuncionesExcel.exportarDataTable(dtLibroMayor, nombreRpt)
            Process.Start("file:///" & rutaArchivo)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub btVisualizaPDF_Click(sender As Object, e As EventArgs) Handles btVisualizaPDF.Click
        Try
            visualizarReporte(ExportFormatType.PortableDocFormat)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Function generarReporte() As rptLibroMayor
        Dim rptLibro As New rptLibroMayor
        Dim rango As String = dtpFechaInicio.Text & " - " & dtpFechaFin.Text
        Cursor = Cursors.WaitCursor
        rptLibro.SetParameterValue("rango", rango)
        Return rptLibro
    End Function
    Public Sub visualizarReporte(formato As CrystalDecisions.Shared.ExportFormatType)
        Dim objLibroMayorBLL As New LibroMayorBLL
        Dim params As New LibroMayorParams
        params = crearParametros()
        objLibroMayorBLL.calcularlibroMayor(params)
        If params.resultado = False Then
            EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.CONTA_RESULTADO_VACIO)
        Else
            Cursor = Cursors.WaitCursor
            Funciones.getReporteNoFTP(generarReporte(), Nothing, "LibroMayor01")
            Cursor = Cursors.Default
        End If
    End Sub
    Private Sub FormLibroMayor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.habilitarControles(Me)
        Generales.asignarPermiso(Me)
        txtNit.Text = SesionActual.nitEmpresa
        txtRazonSocial.Text = SesionActual.nombreEmpresa
        dtpFechaInicio.Value = DateTime.Now
        dtpFechaFin.Value = DateTime.Now
    End Sub
End Class