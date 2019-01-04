Public Class FormNomina
    Dim dtNomina As New DataTable
    Private Sub cargarNomina()
        Dim params As New List(Of String)
        params.Add(dtFechaInicio.Value.Date)
        params.Add(dtFechaFinal.Value.Date)
        Generales.llenarTabla(Sentencias.NOMINA_EMPLEADO_CARGAR, params, dtNomina)
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
        Generales.deshabilitarBotones(ToolStrip1)
        dtFechaInicio.Enabled = True
        dtFechaFinal.Enabled = True
        dtFechaInicio.Value = DateSerial(Year(dtFechaInicio.Value), Month(dtFechaInicio.Value), 1)
        cargarNomina()
    End Sub
    Private Sub dtFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaInicio.ValueChanged
        dtFechaFinal.Value = dtFechaInicio.Value.AddDays(14)
        cargarNomina()
    End Sub
    Private Sub dtFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtFechaFinal.ValueChanged
        cargarNomina()
    End Sub
    Public Function crearObjeto() As Nomina
        Dim nomina As New Nomina
        nomina.fechaInicio = dtFechaInicio.Value
        nomina.fechaFin = dtFechaFinal.Value
        nomina.usuarioCreacion = SesionActual.idUsuario
        For Each drFila As DataRow In dtNomina.Rows
            Dim drCuenta As DataRow = nomina.dtNomina.NewRow
            drCuenta.Item("codigoPersona") = drFila.Item("Código")
            drCuenta.Item("valorPagado") = drFila.Item("Valor a Pagar")
            nomina.dtNomina.Rows.Add(drCuenta)
        Next
        Return nomina
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Dim nominaBLL As New NominaBLL
        Try
            nominaBLL.guardarNomina(crearObjeto())
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
End Class