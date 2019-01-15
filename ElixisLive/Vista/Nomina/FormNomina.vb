Public Class FormNomina
    Dim dtNomina As New DataTable
    Dim nomina As New Nomina
    Private Sub cargarListaEmpleados()
        Dim params As New List(Of String)
        params.Add(dtFechaInicio.Value.Date)
        params.Add(dtFechaFinal.Value.Date)
        Generales.llenarTabla(Sentencias.NOMINA_EMPLEADO_LISTAR, params, dtNomina)
        dgvNomina.DataSource = dtNomina
        If dtNomina.Rows.Count > 0 Then
            dgvNomina.Columns(0).Visible = False
            dgvNomina.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvNomina.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvNomina.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        calcularTotales()
    End Sub
    Private Sub cargarNominaDetalle(codigoNomina)
        Dim params As New List(Of String)
        params.Add(codigoNomina)
        Generales.llenarTabla(Sentencias.NOMINA_EMPLEADOS_CARGAR, params, dtNomina)
        dgvNomina.DataSource = dtNomina
        If dtNomina.Rows.Count > 0 Then
            dgvNomina.Columns(0).Visible = False
            dgvNomina.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            dgvNomina.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvNomina.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvNomina.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        calcularTotales()
    End Sub
    Private Sub dgvNomina_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvNomina.CellFormatting
        If e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub
    Private Sub FormNomina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim respuesta As Integer = Generales.consultarPermiso(Name)
        If respuesta = Constantes.LECTURA_ESCRITURA Then
            Generales.mostrarLecturaEscritura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_LECTURA Then
            Generales.mostrarLectura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_ESCRITURA Then
            Generales.mostrarEscritura(ToolStrip1)
        Else
            Generales.ocultarBotones(ToolStrip1)
        End If
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btNuevo.Enabled = True
        btBuscar.Enabled = True

    End Sub
    Private Sub dtFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaInicio.ValueChanged
        dtFechaFinal.Value = dtFechaInicio.Value.AddDays(14)
    End Sub
    Public Function crearObjeto() As Nomina
        Dim nomina As New Nomina
        nomina.fechaInicio = dtFechaInicio.Value
        nomina.fechaFin = dtFechaFinal.Value
        nomina.usuarioCreacion = SesionActual.idUsuario
        For Each drFila As DataRow In dtNomina.Rows
            Dim drCuenta As DataRow = nomina.dtNomina.NewRow
            drCuenta.Item("codigoPersona") = drFila.Item("Código")
            drCuenta.Item("valorPagado") = drFila.Item("Total a Pagar")
            nomina.dtNomina.Rows.Add(drCuenta)
        Next
        Return nomina
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Dim nominaBLL As New NominaBLL
        Try
            txtCodigo.Text = nominaBLL.guardarNomina(crearObjeto())
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub calcularTotales()
        dgvNomina.EndEdit()

        Try
            Dim valorTotal As Double
            Dim totalServicios As Integer
            If dgvNomina.Rows.Count >= 1 Then
                valorTotal = dtNomina.Compute("SUM([Total a Pagar])", "")
                totalServicios = dtNomina.Compute("SUM(Servicios)", "")
            Else
                valorTotal = Constantes.SIN_VALOR_NUMERICO
                totalServicios = Constantes.SIN_VALOR_NUMERICO
            End If

            TextTotalEmpleados.Text = dgvNomina.Rows.Count
            TextValoTotal.Text = CDbl(valorTotal).ToString(Constantes.FORMATO_MONEDA)
            TextTotalServicios.Text = totalServicios.ToString(Constantes.SIN_VALOR_NUMERICO)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Generales.buscarElemento(Sentencias.NOMINA_BUSCAR,
                                   params,
                                   AddressOf cargarNomina,
                                   Titulo.BUSQUEDA_PERSONA,
                                   True, True)
    End Sub

    Private Sub cargarNomina(codigoNomina As String)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        params.Add(codigoNomina)
        dfila = Generales.cargarItem(Sentencias.NOMINA_CARGAR, params)
        Try
            If Not IsNothing(dfila) Then
                txtCodigo.Text = codigoNomina
                dtFechaInicio.Value = dfila.Item("Fecha_Inicio")
                dtFechaFinal.Value = dfila.Item("Fecha_Final")
                cargarNominaDetalle(codigoNomina)
                Generales.habilitarBotones(ToolStrip1)
                btCancelar.Enabled = False
                btRegistrar.Enabled = False
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(Sentencias.NOMINA_ANULAR & " " & txtCodigo.Text) = True Then
                    Generales.limpiarControles(Me)
                    Generales.deshabilitarBotones(ToolStrip1)
                    txtCodigo.Text = ""
                    btNuevo.Enabled = True
                    btBuscar.Enabled = True
                    EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        dtFechaFinal.Enabled = True
        dtFechaInicio.Enabled = True
        Generales.limpiarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        txtCodigo.Text = ""
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        btCalcular.Enabled = True
        dtFechaInicio.Value = DateSerial(Year(dtFechaInicio.Value), Month(dtFechaInicio.Value), 1)
    End Sub

    Private Sub btCalcular_Click(sender As Object, e As EventArgs) Handles btCalcular.Click
        cargarListaEmpleados()
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub

    Private Sub FormNomina_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btExport_Click(sender As Object, e As EventArgs) Handles btExport.Click
        Try
            Dim nombreRpt As String = "Archivo de Transacciones"
            Dim dtReporte As New DataTable
            Dim params As New List(Of String)

            Cursor = Cursors.WaitCursor
            params.Add(nomina.codigoNomina)
            Generales.llenarTabla(Sentencias.NOMINA_REPORTE_TRANSACCIONES, params, dtReporte)
            Dim ruta As String = FuncionesExcel.exportarDataTable(dtReporte, nombreRpt)

            Process.Start(ruta)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        Finally
            Cursor = Cursors.Default
        End Try

    End Sub
End Class