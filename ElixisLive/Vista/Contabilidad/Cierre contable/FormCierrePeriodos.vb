Public Class FormCierrePeriodos
    Dim dtPeriodos As New DataTable

    Dim PabrirMes, PcerrarMes, PabrirAño, PcerrarAño As String
    Private Sub FormCierrePeriodos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.habilitarControles(Me)
        With fechaCierre
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMMM yyyy"
        End With
        Dim columFecha, columnDetalle, columnEstado As New DataColumn
        columFecha.ColumnName = "Fecha"
        columFecha.DataType = Type.GetType("System.DateTime")
        dtPeriodos.Columns.Add(columFecha)

        columnDetalle.ColumnName = "Detalle"
        columnDetalle.DataType = Type.GetType("System.String")
        dtPeriodos.Columns.Add(columnDetalle)

        columnEstado.ColumnName = "Cerrado"
        columnEstado.DefaultValue = False
        dtPeriodos.Columns.Add(columnEstado)

        With dgvCuentas
            .Columns.Item("dgFecha").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgFecha").DataPropertyName = "Fecha"
            .Columns.Item("dgFecha").ReadOnly = True
            .Columns.Item("dgDetalle").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgDetalle").DataPropertyName = "Detalle"
            .Columns.Item("dgDetalle").ReadOnly = True
            .Columns.Item("dgAnulado").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgAnulado").DataPropertyName = "Cerrado"
        End With
        dgvCuentas.AutoGenerateColumns = False
        dgvCuentas.DataSource = dtPeriodos
        dgvCuentas.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        fechaCierre.Value = DateTime.Now.Date
        llenardgvPeriodos(fechaCierre.Value.Year, fechaCierre.Value.Month)
    End Sub
    Private Sub Form_FormCierrePeriodos_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub fechaCierre_CloseUp(sender As System.Object, e As System.EventArgs) Handles fechaCierre.CloseUp
        If fechaCierre.Value < DateTime.Now.Date Then
            llenardgvPeriodos(fechaCierre.Value.Year, fechaCierre.Value.Month)
        End If
    End Sub
    Private Sub fechaCierre_ValueChanged(sender As System.Object, e As System.EventArgs) Handles fechaCierre.ValueChanged
        If fechaCierre.Value > DateTime.Now.Date Then
            fechaCierre.Value = DateTime.Now.Date
        End If
    End Sub

    Public Function cerrarPeriodo() As CierrePeriodos
        Dim objCierrePeriodo As New CierrePeriodos

        For Each drFila As DataRow In dtPeriodos.Rows
            If drFila.Item("fecha").ToString <> "" Then
                Dim drCuenta As DataRow = objCierrePeriodo.dtCierre.NewRow
                drCuenta.Item("fecha") = drFila.Item("fecha")
                drCuenta.Item("usuario") = SesionActual.idUsuario
                objCierrePeriodo.dtCierre.Rows.Add(drCuenta)

            End If
        Next
        Return objCierrePeriodo
    End Function
    Public Function cerrarPeriodoDia() As CierrePeriodos
        Dim objCierrePeriodo As New CierrePeriodos
        Dim drCuenta As DataRow = objCierrePeriodo.dtCierre.NewRow
        drCuenta.Item("fecha") = dgvCuentas.Rows(dgvCuentas.CurrentRow.Index).Cells(0).Value
        drCuenta.Item("usuario") = SesionActual.idUsuario
        objCierrePeriodo.dtCierre.Rows.Add(drCuenta)
        Return objCierrePeriodo
    End Function
    Private Sub cerrarDia()
        Dim objcierreBll As New CierrePeriosdosBLL
        Try
            objcierreBll.cerrarMes(cerrarPeriodoDia())
            EstiloMensajes.mostrarMensajeExitoso("la fecha ha sido cerrada")
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub btAbrirMes_Click(sender As Object, e As EventArgs) Handles btAbrirMes.Click
        If EstiloMensajes.mostrarMensajePregunta("Desea abrir este mes (" & fechaCierre.Text & ")") = Constantes.SI Then
            abrirMes()
            EstiloMensajes.mostrarMensajeExitoso("El mes ha sido abierto")
        End If
    End Sub
    Private Sub btCerrarMes_Click(sender As Object, e As EventArgs) Handles btCerrarMes.Click
        If EstiloMensajes.mostrarMensajePregunta("Desea cerrar este mes (" & fechaCierre.Text & ")") = Constantes.SI Then
            abrirMes()
            Dim objcierreBll As New CierrePeriosdosBLL
            Try
                objcierreBll.cerrarMes(cerrarPeriodo())
                EstiloMensajes.mostrarMensajeExitoso("El mes ha sido cerrado")
                llenardgvPeriodos(fechaCierre.Value.Year, fechaCierre.Value.Month)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(ex.Message)
            End Try
        End If
    End Sub
    Private Sub btAbrirAño_Click(sender As System.Object, e As System.EventArgs) Handles btAbrirAño.Click
        If DateTime.Now.Date.Year > fechaCierre.Value.Year Then
            If EstiloMensajes.mostrarMensajePregunta("Desea abrir este año (" & fechaCierre.Value.Year & ")") = Constantes.SI Then
                abrirAño()
                EstiloMensajes.mostrarMensajeExitoso("El año ha sido abierto")
                llenardgvPeriodoAnual(fechaCierre.Value.Year)
            End If
        Else
            EstiloMensajes.mostrarMensajeAdvertencia("No se puede realizar esta operación con el año aun en curso")
        End If

    End Sub
    Private Sub btCerrarAño_Click(sender As Object, e As EventArgs) Handles btCerrarAño.Click
        If DateTime.Now.Date.Year > fechaCierre.Value.Year Then
            If EstiloMensajes.mostrarMensajePregunta("Desea cerrar este año (" & fechaCierre.Value.Year & ")") = Constantes.SI Then
                abrirAño()
                Dim objcierreBll As New CierrePeriosdosBLL
                Try
                    objcierreBll.cerrarMes(cerrarPeriodo())
                    EstiloMensajes.mostrarMensajeExitoso("El año ha sido cerrado")
                    llenardgvPeriodoAnual(fechaCierre.Value.Year)
                Catch ex As Exception
                    EstiloMensajes.mostrarMensajeError(ex.Message)
                End Try
            End If
        Else
            EstiloMensajes.mostrarMensajeAdvertencia("No se puede realizar esta operación con el año aun en curso")
        End If

    End Sub
    Private Sub abrirDia()
        Dim respuesta As Boolean
        Try
            respuesta = Generales.anularRegistro(Consultas.CIERRE_DIA & "'" & dgvCuentas.Rows(dgvCuentas.CurrentRow.Index).Cells(0).Value & "'")
            If respuesta = True Then
                EstiloMensajes.mostrarMensajeExitoso("la fecha ha sido abierta")
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub abrirMes()
        Dim respuesta As Boolean
        Try
            respuesta = Generales.anularRegistro(Consultas.CIERRE_MES_ABRIR & "'" & fechaCierre.Value.Year & "-" & fechaCierre.Value.Month & "-" & "01'")

            If respuesta = True Then
                llenardgvPeriodos(fechaCierre.Value.Year, fechaCierre.Value.Month)
            End If

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub abrirAño()
        Dim respuesta As Boolean
        Try
            respuesta = Generales.anularRegistro(Consultas.CIERRE_AÑO_ABRIR & "'" & fechaCierre.Value.Year & "-" & "01" & "-" & "01" & "','" & fechaCierre.Value.Year & "-" & "12" & "-" & "31'")

            If respuesta = True Then
                llenardgvPeriodoAnual(fechaCierre.Value.Year)
            End If

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub dgvCuentas_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCuentas.CellClick
        If e.ColumnIndex = 2 Then
            If dgvCuentas.Rows(dgvCuentas.CurrentRow.Index).Cells(2).Value = False Then
                If EstiloMensajes.mostrarMensajePregunta("Desea cerrar esta fecha (" & dgvCuentas.Rows(dgvCuentas.CurrentRow.Index).Cells(0).Value & ")") = Constantes.SI Then
                    dgvCuentas.Rows(dgvCuentas.CurrentRow.Index).Cells(2).Value = True
                    dtPeriodos.AcceptChanges()
                    dgvCuentas.EndEdit()
                    cerrarDia()
                Else
                    dgvCuentas.Rows(dgvCuentas.CurrentRow.Index).Cells(2).Value = False
                    dtPeriodos.AcceptChanges()
                    dgvCuentas.EndEdit()
                End If
            Else
                If EstiloMensajes.mostrarMensajePregunta("Desea abrir esta fecha (" & dgvCuentas.Rows(dgvCuentas.CurrentRow.Index).Cells(0).Value & ")") = Constantes.SI Then
                    dgvCuentas.Rows(dgvCuentas.CurrentRow.Index).Cells(2).Value = False
                    abrirDia()
                    dtPeriodos.AcceptChanges()
                    dgvCuentas.EndEdit()
                Else
                    dgvCuentas.Rows(dgvCuentas.CurrentRow.Index).Cells(2).Value = True
                    dtPeriodos.AcceptChanges()
                    dgvCuentas.EndEdit()
                End If
            End If
        End If
    End Sub
    Private Sub llenardgvPeriodos(año As String, mes As String)
        Dim params As New List(Of String)
        params.Add(año)
        params.Add(mes)
        Generales.llenarTabla(Consultas.CIERRE_MES_CARGAR, params, dtPeriodos)
    End Sub
    Private Sub llenardgvPeriodoAnual(año As String)
        Dim params As New List(Of String)
        params.Add(año)
        Generales.llenarTabla(Consultas.CIERRE_AÑO_CARGAR, params, dtPeriodos)
    End Sub
End Class