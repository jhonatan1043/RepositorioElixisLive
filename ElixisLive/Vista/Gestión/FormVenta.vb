Imports System.ComponentModel
Public Class FormVenta
    Dim objVenta As Venta
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objVenta = New Venta
        Generales.diseñoDGV(dgvProducto)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btNuevo.Enabled = True
        btBuscar.Enabled = True
    End Sub
    Private Sub dgvProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducto.CellDoubleClick
        Try
            If btRegistrar.Enabled = False Then Exit Sub
            If (dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCodigo").Selected = True Or
                dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgDescripcion").Selected = True) Then
                buscarProducto()
            ElseIf dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True And
                   objVenta.dtProductos.Rows(dgvProducto.CurrentCell.RowIndex).Item("Codigo").ToString <> Constantes.CADENA_VACIA Then
                objVenta.dtProductos.Rows.RemoveAt(e.RowIndex)
            End If
            calcularTotales()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub dgvServicio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicio.CellDoubleClick
        Try
            If btRegistrar.Enabled = False Then Exit Sub
            If (dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgCodigoServ").Selected = True Or
                dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgDescripcionServ").Selected = True) Then
                buscarServicio()
            ElseIf dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgQuitarServ").Selected = True And
                   objVenta.dtServicio.Rows(dgvServicio.CurrentCell.RowIndex).Item("dgCodigoServ").ToString <> Constantes.CADENA_VACIA Then
                objVenta.dtServicio.Rows.RemoveAt(e.RowIndex)
            End If
            calcularTotales()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub dgvProducto_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProducto.CellFormatting
        If e.ColumnIndex = 4 OrElse e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub
    Private Sub dgvServicio_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvServicio.CellFormatting
        If e.ColumnIndex = 3 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub
    Private Sub dgvProducto_CellEndEdit(sender As Object, e As EventArgs) Handles dgvProducto.CellEndEdit
        If dgvProducto.RowCount >= 1 Then
            Try
                For indice = 0 To dgvProducto.RowCount - 1
                    If Not IsDBNull(dgvProducto.Rows(indice).Cells("dgValor").Value) AndAlso
                       Not IsDBNull(dgvProducto.Rows(indice).Cells("dgCantidad").Value) Then
                        dgvProducto.Rows(indice).Cells("dgTotal").Value =
                            dgvProducto.Rows(indice).Cells("dgValor").Value * dgvProducto.Rows(indice).Cells("dgCantidad").Value
                    End If
                Next
                calcularTotales()
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub dgvServicio_CellEndEdit(sender As Object, e As EventArgs) Handles dgvServicio.CellEndEdit
        Dim nombre As String = Nothing
        If dgvServicio.RowCount >= 1 Then
            Try
                nombre = consultarEmpleado(dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgIdEmpleado").Value)
                If Not IsNothing(nombre) Then
                    dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgNombreEmpleado").Value = nombre
                Else
                    dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgIdEmpleado").Value = String.Empty
                    dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgIdEmpleado").Selected = True
                    EstiloMensajes.mostrarMensajeError("¡ Empleado no valido !")
                End If
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
        objVenta.dtServicio.Rows.Add()
        dgvProducto.Rows(0).Cells("dgCodigo").Selected = True
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
        dgvProducto.EndEdit()
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
    Private Sub dgvProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProducto.KeyDown
        If btRegistrar.Enabled = False Then Exit Sub

        If e.KeyCode = Keys.Space Then
            buscarProducto()
        End If

    End Sub
    Private Sub dgvServicio_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvServicio.KeyDown
        If btRegistrar.Enabled = False Then Exit Sub
        If e.KeyCode = Keys.Space Then
            buscarServicio()
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
    Private Sub calcularTotales()
        dgvProducto.EndEdit()
        dgvServicio.EndEdit()
        Try
            Dim cantidadArticulos,
                cantidadServicio As Double
            If dgvProducto.Rows.Count >= 1 Then
                cantidadArticulos = objVenta.dtProductos.Compute("SUM(Total)", "")
            Else
                cantidadArticulos = Constantes.SIN_VALOR_NUMERICO
            End If
            If dgvServicio.Rows.Count >= 1 Then
                cantidadServicio = objVenta.dtServicio.Compute("SUM(ValorServicio)", "")
            Else
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
    Private Sub buscarServicio()
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Generales.busquedaItems("[SP_SERVICIO_FACTURA_CONSULTAR]",
                                   params,
                                   Titulo.BUSQUEDA_SERVICIO,
                                   dgvServicio,
                                   objVenta.dtServicio,
                                   0,
                                   2,
                                   0,
                                   0,
                                   True)
    End Sub
    Private Sub buscarProducto()
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Generales.busquedaItems("[SP_PRODUCTOS_FACTURA_CONSULTAR]",
                                   params,
                                   Titulo.BUSQUEDA_PRODUCTO,
                                   dgvProducto,
                                   objVenta.dtProductos,
                                   0,
                                   4,
                                   0,
                                   0,
                                   True)
    End Sub
    Private Sub validarGrilla()

        With dgvProducto

            .ReadOnly = False
            .Columns("dgCodigo").DataPropertyName = "codigo"
            .Columns("dgDescripcion").DataPropertyName = "Descripcion"
            .Columns("dgCantidad").DataPropertyName = "Cantidad"
            .Columns("dgValor").DataPropertyName = "Valor"
            .Columns("dgTotal").DataPropertyName = "Total"

            .Columns("dgCodigo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgDescripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgCantidad").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgValor").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgTotal").SortMode = DataGridViewColumnSortMode.NotSortable

            .DataSource = objVenta.dtProductos
            .AutoGenerateColumns = False
        End With

        With dgvServicio

            .ReadOnly = False
            .Columns("dgCodigoServ").DataPropertyName = "codigo"
            .Columns("dgDescripcionServ").DataPropertyName = "Descripcion"
            .Columns("dgValorServ").DataPropertyName = "ValorServicio"
            .Columns("dgIdEmpleado").DataPropertyName = "codigo_Empleado"
            .Columns("dgNombreEmpleado").DataPropertyName = "NombreEmpleado"

            .Columns("dgCodigoServ").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgDescripcionServ").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgValorServ").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgIdEmpleado").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgNombreEmpleado").SortMode = DataGridViewColumnSortMode.NotSortable

            .DataSource = objVenta.dtServicio
            .AutoGenerateColumns = False
        End With

    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)

        With dgvProducto
            .ReadOnly = False
            .Columns("dgCodigo").ReadOnly = True
            .Columns("dgDescripcion").ReadOnly = True
            .Columns("dgValor").ReadOnly = True
            .Columns("dgCantidad").ReadOnly = True
            .Columns("dgTotal").ReadOnly = True
        End With
        If Estado = True Then
            With dgvProducto
                .Columns("dgCantidad").ReadOnly = False
                .Columns("dgValor").ReadOnly = False
            End With
        End If

        With dgvServicio
            .ReadOnly = False
            .Columns("dgCodigoServ").ReadOnly = True
            .Columns("dgDescripcionServ").ReadOnly = True
            .Columns("dgValorServ").ReadOnly = True
            .Columns("dgIdEmpleado").ReadOnly = True
            .Columns("dgNombreEmpleado").ReadOnly = True
        End With
        If Estado = True Then
            With dgvServicio
                .Columns("dgIdEmpleado").ReadOnly = False
            End With
        End If
    End Sub
    Private Function consultarEmpleado(codigo As String)
        Dim nombre As String
        nombre = Funciones.consultarEmpleado(codigo)
        Return nombre
    End Function
End Class