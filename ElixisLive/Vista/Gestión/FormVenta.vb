Imports System.ComponentModel
Public Class FormVenta
    Dim objVenta As Venta
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.diseñoDGV(dgvFactura)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        validarGrilla()
    End Sub
    Private Sub validarGrilla()
        With dgvFactura

            .ReadOnly = False
            .Columns("dgTipo").Visible = False

            .Columns("dgCodigo").DataPropertyName = "codigo"
            .Columns("dgDescripcion").DataPropertyName = "Descripcion"
            .Columns("dgCantidad").DataPropertyName = "Cantidad"
            .Columns("dgValor").DataPropertyName = "Valor"
            .Columns("dgTotal").DataPropertyName = "Total"
            .Columns("dgTipo").DataPropertyName = "Tipo"

            .Columns("dgCodigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgDescripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgCantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgValor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgTotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgTotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            .Columns("dgCodigo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgDescripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgCantidad").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgValor").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgTotal").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgTotal").SortMode = DataGridViewColumnSortMode.NotSortable

            .DataSource = objVenta.dtProductos
            .AutoGenerateColumns = False
        End With
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
        'If Asc(e.KeyChar) = 13 Then
        '    cargarDatosCliente(TextIdentificacion.Text)
        '    If respuesta = True Then
        '        dgvFactura.Focus()
        '    Else
        '        TextNombre.Focus()
        '    End If
        'End If
    End Sub
    Private Sub dgvFactura_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFactura.CellDoubleClick
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            If btRegistrar.Enabled = False Then
                Exit Sub
            End If
            If (dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgCodigo").Selected = True Or
                dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgDescripcion").Selected = True) Then
                Generales.busquedaItems(Sentencias.PRODUCTO_SERVICIO_FACTURA_BUSCAR,
                                        params,
                                        Titulo.BUSQUEDA_PRODUCTO,
                                        dgvFactura,
                                        objVenta.dtProductos,
                                        0,
                                        4,
                                        0,
                                        0,
                                        True)
            ElseIf dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True And
                   objVenta.dtProductos.Rows(dgvFactura.CurrentCell.RowIndex).Item(0).ToString <> Constantes.CADENA_VACIA Then
                objVenta.dtProductos.Rows.RemoveAt(e.RowIndex)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub dgvFactura_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvFactura.CellFormatting
        If e.ColumnIndex = 3 Or e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
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
                objVenta.codigoCliente = dFila.Item("Codigo").ToString
                TextNombre.Text = dFila.Item("Nombre").ToString
                TextTelefono.Text = dFila.Item("Telefono").ToString
                TextNombre.ReadOnly = True
                TextTelefono.ReadOnly = True
                quitarIconoError()
            Else
                TextNombre.Clear()
                TextTelefono.Clear()
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
        objVenta.dtProductos.Rows.Add()
        bloquearColumnas()
        dtFechaFactura.Enabled = False
        TextIdentificacion.Focus()
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(SesionActual.codigoSucursal)
        Try
            Generales.buscarElemento(Sentencias.FACTURA_BUSCAR,
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
        If String.IsNullOrEmpty(TextIdentificacion.Text) Or String.IsNullOrEmpty(TextNombre.Text) Then
            Return True
        End If
        Return False
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
                quitarIconoError()
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Else
                EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.VALIDAR_CAMPOS)
            End If
            mostrarIconoError()
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
        'If dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(0).ToString <> "" Then
        '    Dim params As New List(Of String)
        '    params.Add(dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(0).ToString)
        '    Dim fila As DataRow
        '    fila = Generales.digitarEnDgv(Sentencias.PRODUCTO_SERVICIO_FACTURA_CARGAR, params)
        '    If Not IsNothing(fila) Then
        '        If dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(0).ToString <> "" And dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(1).ToString = "" Then
        '            dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(1) = fila(1)
        '            dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(2) = fila(2)
        '            dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(3) = fila(3)
        '            dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(4) = fila(4)
        '            dtProductos.Rows.Add()
        '            dgvFactura.Rows(dgvFactura.Rows.Count - 1).Cells(0).Selected = True
        '        Else
        '            dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(1) = fila(1)
        '            dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(3) = fila(3)
        '            dtProductos.Rows(dgvFactura.CurrentRow.Index).Item(4) = fila(4)
        '        End If
        '    Else
        '        dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(0).Value = String.Empty
        '        dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(1).Value = String.Empty
        '        dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(2).Value = String.Empty
        '        dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(3).Value = String.Empty
        '        dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells(4).Value = String.Empty
        '        If dtProductos.Rows.Count > 1 And dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgCodigo").Value = String.Empty And e.RowIndex <> dgvFactura.Rows.Count - 1 Then
        '            dtProductos.Rows.RemoveAt(e.RowIndex)
        '        End If
        '    End If
        '    dtProductos.Rows(dgvFactura.CurrentRow.Index).Item("Total") = dtProductos.Rows(dgvFactura.CurrentRow.Index).Item("Valor") * dtProductos.Rows(dgvFactura.CurrentRow.Index).Item("Cantidad")
        '    dtProductos.AcceptChanges()
        '    Generales.diseñoDGV(dgvFactura)
        'End If
        'calcularTotales()
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


    Private Sub calcularTotales()
        dgvFactura.EndEdit()
        Try

            Dim cantidadArticulos,
                cantidadServicio As Double

            If dgvFactura.Rows.Count >= 1 Then
                cantidadServicio = objVenta.dtProductos.Compute("SUM(Total)", "Tipo = 'S'")
                cantidadArticulos = objVenta.dtProductos.Compute("SUM(Total)", "Tipo = 'P'")
            Else
                cantidadArticulos = Constantes.SIN_VALOR_NUMERICO
                cantidadServicio = Constantes.SIN_VALOR_NUMERICO
            End If

            TextTotalArticulos.Text = CDbl(cantidadArticulos).ToString(Constantes.FORMATO_MONEDA)
            TextTotalServicio.Text = CDbl(cantidadServicio).ToString(Constantes.FORMATO_MONEDA)
            TextTotal.Text = CDbl((cantidadArticulos + cantidadServicio)).ToString(Constantes.FORMATO_MONEDA)
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
    Private Sub dgvcartera_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvFactura.EditingControlShowing,
            dgvFactura.EditingControlShowing
        If dgvFactura.CurrentCell.ColumnIndex = 0 Or dgvFactura.CurrentCell.ColumnIndex = 2 Or dgvFactura.CurrentCell.ColumnIndex = 3 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarSoloNumerosNegativo
        End If
    End Sub
    Private Sub TextTelefono_Leave(sender As Object, e As EventArgs) Handles TextTelefono.Leave
        dgvFactura.Focus()
    End Sub
    Private Sub TextTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextTelefono.KeyPress
        ValidacionDigitacion.validarNumerosTelefono(e)
        If Asc(e.KeyChar) = 13 Then
            dgvFactura.Focus()
        End If
    End Sub
    Private Sub TextNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNombre.KeyPress
        ValidacionDigitacion.validarAlfabetico(e)
        If Asc(e.KeyChar) = 13 Then
            TextTelefono.Focus()
        End If
    End Sub
    Private Sub mostrarIconoError()
        If TextIdentificacion.Text.Length = 0 Then
            ErrorIcono.SetError(TextIdentificacion, "Debe digitar un número de identificación")
        Else
            ErrorIcono.SetError(TextIdentificacion, "")
        End If
        If TextNombre.Text.Length = 0 Then
            ErrorIcono.SetError(TextNombre, "Debe digitar un nombre")
        Else
            ErrorIcono.SetError(TextNombre, "")
        End If
        If TextTelefono.Text.Length = 0 Then
            ErrorIcono.SetError(TextTelefono, "Debe digitar un número de teléfono")
        Else
            ErrorIcono.SetError(TextTelefono, "")
        End If
    End Sub
    Private Sub TextIdentificacion_Validating(sender As Object, e As EventArgs) Handles TextIdentificacion.LostFocus
        If TextIdentificacion.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TextIdentificacion, "Debe digitar un número de identificación")
        Else
            ErrorIcono.SetError(TextIdentificacion, "")
        End If
    End Sub
    Private Sub TextNombre_Validating(sender As Object, e As EventArgs) Handles TextNombre.LostFocus
        If TextNombre.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TextNombre, "Debe digitar un nombre")
        Else
            ErrorIcono.SetError(TextNombre, "")
        End If
    End Sub
    Private Sub TextTelefono_Validating(sender As Object, e As EventArgs) Handles TextTelefono.LostFocus
        If TextTelefono.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TextTelefono, "Debe digitar un número de teléfono")
        Else
            ErrorIcono.SetError(TextTelefono, "")
        End If
    End Sub


End Class