Imports System.ComponentModel
Public Class FormVenta
    Dim objVenta As Venta
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objVenta = New Venta
        Generales.diseñoDGV(dgvFactura)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btNuevo.Enabled = True
        btBuscar.Enabled = True
    End Sub
    Private Sub dgvFactura_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFactura.CellDoubleClick
        Try
            If btRegistrar.Enabled = False Then Exit Sub

            If (dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgCodigo").Selected = True Or
                dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgDescripcion").Selected = True) Then
                buscarProductosServicio()
            ElseIf dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True And
                   objVenta.dtProductos.Rows(dgvFactura.CurrentCell.RowIndex).Item("Codigo").ToString <> Constantes.CADENA_VACIA Then
                objVenta.dtProductos.Rows.RemoveAt(e.RowIndex)
            End If

            calcularTotales()

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub dgvFactura_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvFactura.CellFormatting
        If e.ColumnIndex = 4 Or e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub
    Private Sub dgvFactura_CellEndEdit(sender As Object, e As EventArgs) Handles dgvFactura.CellEndEdit
        If dgvFactura.RowCount >= 1 Then
            Try
                For indice = 0 To dgvFactura.RowCount - 1
                    If Not IsDBNull(dgvFactura.Rows(indice).Cells("dgValor").Value) AndAlso Not IsDBNull(dgvFactura.Rows(indice).Cells("dgCantidad").Value) Then
                        dgvFactura.Rows(indice).Cells("dgTotal").Value = dgvFactura.Rows(indice).Cells("dgValor").Value * dgvFactura.Rows(indice).Cells("dgCantidad").Value
                    End If
                Next
                calcularTotales()
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.habilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.limpiarControles(Me)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        desactivadoPermante()
        validarEdicionGrilla(Constantes.EDITABLE)
        objVenta.codigo = Nothing
        objVenta.dtProductos.Rows.Add()
        dgvFactura.Rows(dgvFactura.Rows.Count - 1).Selected = True
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(SesionActual.codigoSucursal)
        Try
            Generales.buscarElemento(Sentencias.FACTURA_BUSCAR,
                                   params,
                                   AddressOf cargarInfomacion,
                                   Titulo.BUSQUEDA_FACTURA,
                                   True,
                                   True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvFactura.EndEdit()
        Try
            VentaBLL.guardarVenta(objVenta)
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtCodigo.Text = objVenta.codigo
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            If IsNothing(objVenta.codigo) Then
                Generales.limpiarControles(Me)
            End If
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub dgvFactura_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvFactura.KeyDown
        If btRegistrar.Enabled = False Then Exit Sub
        If e.KeyCode = Keys.Space Then
            buscarProductosServicio()
        End If
    End Sub
    Private Sub txtIdentificacion_Leave(sender As Object, e As EventArgs) Handles txtIdentificacion.Leave
        If Not String.IsNullOrEmpty(txtIdentificacion.Text) Then

        End If
    End Sub
    Private Sub txtIdentificacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdentificacion.KeyDown
        If Not String.IsNullOrEmpty(txtIdentificacion.Text) Then

        End If
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

            .Columns("dgCodigo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgDescripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgCantidad").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgValor").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgTotal").SortMode = DataGridViewColumnSortMode.NotSortable

            .DataSource = objVenta.dtProductos
            .AutoGenerateColumns = False
        End With
    End Sub
    Private Sub calcularTotales()
        dgvFactura.EndEdit()
        Try
            Dim cantidadArticulos,
                cantidadServicio As Double

            If dgvFactura.Rows.Count >= 1 Then
                If objVenta.dtProductos.Select("[Tipo] = 'P'").Count > 0 Then
                    cantidadArticulos = objVenta.dtProductos.Compute("SUM(Total)", "Tipo = 'P'")
                Else
                    cantidadServicio = 0
                End If
                If objVenta.dtProductos.Select("[Tipo] = 'S'").Count > 0 Then
                    cantidadServicio = objVenta.dtProductos.Compute("SUM(Total)", "Tipo = 'S'")
                Else
                    cantidadArticulos = 0
                End If
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
    Private Sub cargarInfomacion()

    End Sub
    Private Sub desactivadoPermante()
        TextTotal.ReadOnly = True
        TextTotalArticulos.ReadOnly = True
        TextTotalServicio.ReadOnly = True
    End Sub
    Private Sub buscarProductosServicio()
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Generales.busquedaItems(Sentencias.PRODUCTO_SERVICIO_FACTURA_BUSCAR,
                                   params,
                                   Titulo.BUSQUEDA_PRODUCTO,
                                   dgvFactura,
                                   objVenta.dtProductos,
                                   0,
                                   5,
                                   0,
                                   0,
                                   True)
    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgvFactura
            .ReadOnly = False
            .Columns("dgCodigo").ReadOnly = True
            .Columns("dgDescripcion").ReadOnly = True
            .Columns("dgValor").ReadOnly = True
            .Columns("dgCantidad").ReadOnly = True
            .Columns("dgTotal").ReadOnly = True
        End With
        If Estado = True Then
            With dgvFactura
                .Columns("dgCantidad").ReadOnly = False
                .Columns("dgValor").ReadOnly = False
            End With
        End If
    End Sub

End Class