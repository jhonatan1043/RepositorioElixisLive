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
            calcularTotales()
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
                                   Titulo.BUSQUEDA_FACTURA,
                                   True,
                                   True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarInfomacion()

    End Sub
    Private Function validarCampos()
        If String.IsNullOrEmpty(TextIdentificacion.Text) OrElse
            String.IsNullOrEmpty(TextNombre.Text) Then
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
        End If
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
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

End Class