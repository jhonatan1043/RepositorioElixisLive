Public Class FormInventarioBalance
    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btVisualizaPDF_Click(sender As Object, e As EventArgs) Handles btVisualizaPDF.Click
        If validarFormulario() Then
            visualizarReporte()
        End If
    End Sub
    Private Sub visualizarReporte()
        Dim params As BalanceComprobacionParams
        Dim rptInventario As New rptLibroInventarioBalance
        Dim objInventarioBalance As New BalanceComprobacionBLL
        params = crearParametros()
        Try
            Dim rango As String = dtpFechaInicio.Text & " - " & dtpFechaFin.Text
            Cursor = Cursors.WaitCursor
            objInventarioBalance.calcularBalanceComprobacion(params)
            rptInventario.SetParameterValue("rango", rango)
            Funciones.getReporteNoFTP(rptInventario, Nothing, "InventarioBalance01")
            Cursor = Cursors.Default
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

    Public Function crearParametros() As BalanceComprobacionParams
        Dim params As New BalanceComprobacionParams
        params.detalle = False
        params.clasificacion = getTipoCuentaSeleccionada()
        params.fechaInicio = dtpFechaInicio.Value
        params.fechaFin = dtpFechaFin.Value
        Return params
    End Function

    Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        If validarFormulario() Then
            calcularInventario()
        End If
    End Sub

    Private Sub calcularInventario()
        Dim dtBalance As New DataTable
        Dim params As New List(Of String)
        params.Add(getTipoCuentaSeleccionada)
        params.Add(CDate(dtpFechaInicio.Value).Date)
        params.Add(CDate(dtpFechaFin.Value.ToString).Date)
        Generales.llenarTabla(Consultas.BALANCE_COMPROBACION_CARGAR_PREV, params, dtBalance)
        dgBalance.DataSource = dtBalance
        dgBalance.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgBalance.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
    End Sub

    Private Function validarFormulario() As Boolean
        If dtpFechaInicio.Value > dtpFechaFin.Value Then
            EstiloMensajes.mostrarMensajeAdvertencia("La fecha de inicio no puede ser mayor a la fecha final!")
            Return False
        End If
        Return True
    End Function

    Private Function getTipoCuentaSeleccionada()
        Select Case True
            Case rbBalance.Checked
                Return Constantes.PUC_CLASIFICACION_BALANCE
            Case rbResultado.Checked
                Return Constantes.PUC_CLASIFICACION_RESULTADO
            Case Else
                Return Nothing
        End Select

    End Function

    Private Sub btExportaExcel_Click(sender As Object, e As EventArgs) Handles btExportaExcel.Click
        Try
            Dim nombreRpt As String = "inv_balance01"
            Dim ruta As String
            Dim dtInventarioBalance As New DataTable
            Dim params As New List(Of String)
            Cursor = Cursors.WaitCursor
            params.Add(getTipoCuentaSeleccionada())
            params.Add(CDate(dtpFechaInicio.Value).Date)
            params.Add(CDate(dtpFechaFin.Value).Date)
            Generales.llenarTabla(Consultas.BALANCE_COMPROBACION_CARGAR_XLS, params, dtInventarioBalance)
            ruta = FuncionesExcel.exportarDataTable(dtInventarioBalance, nombreRpt)
            Process.Start(ruta)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub FormInventarioBalance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.habilitarControles(Me)
        Generales.asignarPermiso(Me)
        txtNit.Text = SesionActual.nitEmpresa
        txtRazonSocial.Text = SesionActual.nombreEmpresa
        dtpFechaInicio.Value = DateTime.Now
        dtpFechaFin.Value = DateTime.Now
    End Sub
End Class