Imports System.ComponentModel
Public Class FormVenta
    Dim codigoCliente As Integer
    Dim respuesta As Boolean = False
    Dim dtProductos As New DataTable
    Dim titulo As String
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.diseñoDGV(dgvFactura)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        enlanzarTabla()
        ToolStrip1.Focus()
    End Sub
    Private Sub enlanzarTabla()
        Dim colCodigo, colDescripcion,
            colCantidad, colValor, colId, colTotal As New DataColumn
        colCodigo.ColumnName = "Codigo"
        colCodigo.DataType = Type.GetType("System.String")
        colCodigo.DefaultValue = String.Empty
        dtProductos.Columns.Add(colCodigo)
        colDescripcion.ColumnName = "Descripcion"
        colDescripcion.DataType = Type.GetType("System.String")
        colDescripcion.DefaultValue = String.Empty
        dtProductos.Columns.Add(colDescripcion)
        colCantidad.ColumnName = "Cantidad"
        colCantidad.DataType = Type.GetType("System.Int32")
        colCantidad.DefaultValue = 0
        dtProductos.Columns.Add(colCantidad)
        colValor.ColumnName = "Valor"
        colValor.DataType = Type.GetType("System.Decimal")
        colValor.DefaultValue = 0
        dtProductos.Columns.Add(colValor)
        colId.ColumnName = "Id"
        colId.DataType = Type.GetType("System.String")
        colId.DefaultValue = String.Empty
        dtProductos.Columns.Add(colId)
        colTotal.ColumnName = "Total"
        colTotal.DataType = Type.GetType("System.Decimal")
        colTotal.DefaultValue = 0
        dtProductos.Columns.Add(colTotal)
        With dgvFactura
            .Columns.Item("dgCodigo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgCodigo").DataPropertyName = "Codigo"
            .Columns.Item("dgDescripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgDescripcion").DataPropertyName = "Descripcion"
            .Columns.Item("dgCantidad").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgCantidad").DataPropertyName = "Cantidad"
            .Columns.Item("dgValor").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgValor").DataPropertyName = "Valor"
            .Columns.Item("dgId").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgId").DataPropertyName = "Id"
            .Columns.Item("dgTotal").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgTotal").DataPropertyName = "Total"
        End With
        dgvFactura.AutoGenerateColumns = False
        dgvFactura.DataSource = dtProductos
        dgvFactura.ReadOnly = True
    End Sub
    Private Sub TextIdentificacion_TextChanged(sender As Object, e As EventArgs) Handles TextIdentificacion.TextChanged
        Dim dV As New DigitoVerificacion
        Dim numero As Integer
        numero = dV.calculaNit(TextIdentificacion.Text)
        TextDV.Text = CType(numero, String)
        If TextIdentificacion.Text = Nothing Then
            TextDV.Text = Nothing
        End If
    End Sub
    Private Sub TextIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextIdentificacion.KeyPress
        ValidacionDigitacion.validarValoresNumericos(e)
        If Asc(e.KeyChar) = 13 Then
            cargarDatosCliente(TextIdentificacion.Text)
            If respuesta = True Then
                dgvFactura.Focus()
            Else
                TextNombre.Focus()
            End If
        End If
    End Sub
    Private Sub dgvFactura_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFactura.CellDoubleClick
        Dim params As New List(Of String)
        params.Add("")
        Try
            If btRegistrar.Enabled = False Then
                Exit Sub
            End If
            If (dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgCodigo").Selected = True Or dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgDescripcion").Selected = True) Then
                Generales.busquedaItems(Sentencias.PRODUCTOS_SERVICIO_FACTURA_BUSCAR, params, titulo, dgvFactura, dtProductos, 0, 4, 0, 0, True)
            ElseIf dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True And dtProductos.Rows(dgvFactura.CurrentCell.RowIndex).Item(0).ToString <> "" Then
                dtProductos.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub dgvFactura_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvFactura.CellFormatting
        If e.ColumnIndex = 3 Or e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), "c2")
            Else
                e.Value = Format(Val(e.Value), "c2")
            End If
        End If

    End Sub
    Private Sub cargarDatosCliente(identificacion As String)
        Dim params As New List(Of String)
        Dim dFila As DataRow
        params.Add(identificacion)
        dFila = Generales.cargarItem(Sentencias.CLIENTE_FACTURA_CARGAR, params)
        Try
            If Not IsNothing(dFila) Then
                codigoCliente = dFila.Item("Codigo").ToString
                TextNombre.Text = dFila.Item("Nombre").ToString
                TextTelefono.Text = dFila.Item("Telefono").ToString
                respuesta = True
                TextNombre.ReadOnly = True
                TextTelefono.ReadOnly = True
            Else
                TextNombre.Clear()
                TextTelefono.Clear()
                respuesta = False
                TextNombre.ReadOnly = False
                TextTelefono.ReadOnly = False
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.habilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.limpiarControles(Me)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        TextDV.ReadOnly = True
        TextTotal.ReadOnly = True
        TextTotalArticulos.ReadOnly = True
        TextTotalServicio.ReadOnly = True
        dtProductos.Rows.Add()
        bloquearColumnas()
        dtFechaFactura.Enabled = False
        TextIdentificacion.Focus()
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(SesionActual.codigoSucursal)
        Try
            Generales.buscarElemento(Sentencias.BUSCAR_FACTURAS,
                                   params,
                                   AddressOf cargarInfomacion,
                                   "Busqueda de Facturas",
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarInfomacion()

    End Sub
    Private Function validarCampos()
        Dim resultado As Boolean = False
        If TextIdentificacion.Text <> String.Empty And TextNombre.Text <> String.Empty And TextTelefono.Text <> String.Empty Then
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvFactura.EndEdit()
        Try
            If validarCampos() Then
                'EmpleadoBLL.guardar(objEmpleado)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btCancelar.Enabled = False
                btRegistrar.Enabled = False
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Else
                EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.VALIDAR_CAMPOS)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            quitarIconoError()
        End If
    End Sub

    Private Sub dgvFactura_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFactura.CellEndEdit
        If dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(0).ToString <> "" Then
            Dim params As New List(Of String)
            params.Add(dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(0).ToString)
            Dim fila As DataRow
            fila = Generales.digitarEnDgv(Sentencias.PRODUCTOS_SERVICIO_FACTURA_CARGAR, params)
            If Not IsNothing(fila) Then
                If dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(0).ToString <> "" And dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(1).ToString = "" Then
                    dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(1) = fila(1)
                    dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(2) = fila(2)
                    dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(3) = fila(3)
                    dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(4) = fila(4)
                    dtProductos.Rows.Add()
                    dgvFactura.Rows(dgvFactura.Rows.Count - 1).Cells(0).Selected = True
                Else
                    dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(1) = fila(1)
                    dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(3) = fila(3)
                    dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(4) = fila(4)
                End If
            Else
                dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(0).Value = String.Empty
                dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(1).Value = String.Empty
                dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(2).Value = String.Empty
                dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(3).Value = String.Empty
                dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(4).Value = String.Empty
                If dtProductos.Rows.Count > 1 And dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(0).Value = String.Empty And e.RowIndex <> dgvFactura.Rows.Count - 1 Then
                    dtProductos.Rows.RemoveAt(e.RowIndex)
                End If
            End If
            dtProductos.Rows(dgvFactura.CurrentRow.Index).Item("Total") = dtProductos.Rows(dgvFactura.CurrentRow.Index).Item("Valor") * dtProductos.Rows(dgvFactura.CurrentRow.Index).Item("Cantidad")
            dtProductos.AcceptChanges()
            Generales.diseñoDGV(dgvFactura)
        End If
        calcularTotales()
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub quitarIconoError()
        Me.ErrorIcono.SetError(TextIdentificacion, "")
        Me.ErrorIcono.SetError(TextNombre, "")
        Me.ErrorIcono.SetError(TextTelefono, "")
    End Sub
    Public Sub TextIdentificacion_Validating(sender As Object, e As CancelEventArgs) Handles TextIdentificacion.Validating
        If DirectCast(sender, TextBox).Text.Length = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe Ingresar un número de identificación")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Public Sub TextNombre_Validating(sender As Object, e As CancelEventArgs) Handles TextNombre.Validating
        If DirectCast(sender, TextBox).Text.Length = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe ingresar un nombre")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Public Sub TextTelefono_Validating(sender As Object, e As CancelEventArgs) Handles TextTelefono.Validating
        If DirectCast(sender, TextBox).Text.Length = 0 And btRegistrar.Enabled = True Then
            Me.ErrorIcono.SetError(sender, "Debe ingresar un número de teléfono")
        Else
            Me.ErrorIcono.SetError(sender, "")
        End If
    End Sub
    Private Sub calcularTotales()
        dgvFactura.EndEdit()
        Try
            Dim sumProductos, sumServicio, valorTotal As Double
            sumProductos = 0
            sumServicio = 0
            If dgvFactura.Rows.Count >= 1 Then
                For indicedgvCuentas = 0 To dgvFactura.Rows.Count - 1
                    If dgvFactura.Rows(indicedgvCuentas).Cells("dgDescripcion").Value.ToString <> "" Then
                        If dgvFactura.Rows(indicedgvCuentas).Cells("dgId").Value.ToString = Constantes.ID_PRODUCTO Then
                            sumProductos = sumProductos + CDbl(dgvFactura.Rows(indicedgvCuentas).Cells("dgTotal").Value)
                        Else
                            sumServicio = sumServicio + CDbl(dgvFactura.Rows(indicedgvCuentas).Cells("dgTotal").Value)
                        End If
                    Else
                        dgvFactura.Rows(indicedgvCuentas).Cells("dgTotal").Value = 0
                    End If
                Next
                valorTotal = sumProductos + sumServicio
                TextTotalArticulos.Text = CDbl(sumProductos).ToString("C2")
                TextTotalServicio.Text = CDbl(sumServicio).ToString("C2")
                TextTotal.Text = CDbl(valorTotal).ToString("C2")
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub bloquearColumnas()
        With dgvFactura
            .Columns("dgValor").ReadOnly = True
            .Columns("dgTotal").ReadOnly = True
            .Columns("dgDescripcion").ReadOnly = True
        End With
    End Sub
    Private Sub dgvFactura_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvFactura.DataError
        bloquearColumnas()
    End Sub

    Private Sub dgvFactura_Enter(sender As Object, e As EventArgs) Handles dgvFactura.CellEnter
        If dgvFactura.RowCount >= 1 Then
            calcularTotales()
            For indice = 0 To dgvFactura.RowCount - 1
                dgvFactura.Rows(indice).Cells("dgTotal").Value = dgvFactura.Rows(indice).Cells("dgValor").Value * dgvFactura.Rows(indice).Cells("dgCantidad").Value
            Next
        End If
    End Sub
End Class