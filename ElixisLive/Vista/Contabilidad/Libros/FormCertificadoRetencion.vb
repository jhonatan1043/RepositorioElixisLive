
Public Class FormCertificadoRetencion
    Public Function crearParametros() As CertificadoRetencionParams
        Dim params As New CertificadoRetencionParams
        params.idTercero = LibroAuxiliarBLL.obtenerTerceroByNit(txtTercero.Text)
        params.fechaInicio = dtpFechaInicio.Value
        params.fechaFin = dtpFechaFin.Value
        Return params
    End Function
    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btExportaExcel_Click(sender As Object, e As EventArgs)
        Try
            Dim nombreRpt As String = "certificado_retencion_01"
            Dim dtLibroDiario As New DataTable
            Dim params As New List(Of String)
            Cursor = Cursors.WaitCursor
            params.Add(CDate(dtpFechaInicio.Value).Date)
            params.Add(CDate(dtpFechaFin.Value).Date)
            Generales.llenarTabla(Consultas.CERTIFICADO_RETENCION_CARGAR_XLS, params, dtLibroDiario)
            Dim rutaArchivo As String = FuncionesExcel.exportarDataTable(dtLibroDiario, nombreRpt)
            Process.Start("file:///" & rutaArchivo)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub



    Private Sub btVisualizaPDF_Click(sender As Object, e As EventArgs) Handles btVisualizaPDF.Click
        Try
            visualizarReporte()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

    Public Sub visualizarReporte()

        Dim params As CertificadoRetencionParams

        If validarFormulario() Then
            params = crearParametros()
            CertificadoRetencionBLL.obtenerValorRetencion(params)

            If params.resultado = False Then
                EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.CONTA_RESULTADO_VACIO)
            Else
                Cursor = Cursors.WaitCursor
                CertificadoRetencionBLL.generarCertificadoRetencion(params)
                Cursor = Cursors.Default
            End If
        End If

    End Sub

    Private Function validarFormulario() As Boolean

        If txtTercero.Text = String.Empty Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor escoger un tercero!")
            Return False
        End If

        Return True
    End Function
    Private Sub btTercero_Click(sender As Object, e As EventArgs) Handles btTercero.Click
        Dim params As New List(Of String)
        params.Add(Nothing)
        Generales.buscarElemento(Consultas.CONTA_TERCERO_BUSCAR,
                                   params,
                                   AddressOf cargarTercero,
                                   TitulosForm.BUSQUEDA_TERCERO,
                                   False, True)
    End Sub

    Public Sub cargarTercero(pCodigoTercero As String)
        Dim drTercero As DataRow
        Dim params As New List(Of String)
        params.Add(pCodigoTercero)

        drTercero = Generales.cargarItem(Consultas.CONTA_PROVEEDOR_CARGAR, params)

        txtTercero.Text = drTercero.Item(1)
        txtRazonSocial.Text = drTercero.Item(2)

    End Sub

    Private Sub txtTercero_Leave(sender As Object, e As EventArgs) Handles txtTercero.Leave
        If txtTercero.Text = String.Empty Then
            txtRazonSocial.Text = String.Empty
            Return
        End If

        Dim idTercero As Integer = Nothing
        idTercero = LibroAuxiliarBLL.obtenerTerceroByNit(txtTercero.Text)

        If idTercero = Nothing Then
            EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.CONTA_TERCERO_INEXISTENTE)
            txtTercero.Text = String.Empty
            txtRazonSocial.Text = String.Empty
            txtTercero.Focus()
        Else
            cargarTercero(idTercero)
        End If
    End Sub

    Public Sub cargarTercero(pCodigoTercero As Integer)
        Dim drTercero As DataRow
        Dim params As New List(Of String)
        params.Add(pCodigoTercero)

        drTercero = Generales.cargarItem(Consultas.CONTA_TERCERO_CARGAR, params)
        txtTercero.Text = drTercero.Item(0)
        txtRazonSocial.Text = drTercero.Item(1)

    End Sub

    Private Sub FormCertificadoRetencion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpFechaInicio.Value = DateTime.Now
        dtpFechaFin.Value = DateTime.Now
        Generales.habilitarControles(Me)
        Generales.asignarPermiso(Me)
    End Sub
End Class