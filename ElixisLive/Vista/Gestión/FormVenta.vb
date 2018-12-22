﻿Imports System.ComponentModel
Public Class FormVenta
    Dim objVenta As Venta
    Dim formExistencia As FormExistencia
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objVenta = New Venta
        Generales.diseñoDGV(dgvProducto)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        Generales.tabularConEnter(Me)
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
                   objVenta.dtServicio.Rows(dgvServicio.CurrentCell.RowIndex).Item("dgCodigo").ToString <> Constantes.CADENA_VACIA Then
                objVenta.dtServicio.Rows.RemoveAt(e.RowIndex)
            End If
            calcularTotales()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub dgvProducto_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProducto.CellFormatting
        If e.ColumnIndex = 6 OrElse e.ColumnIndex = 7 Then
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
                If dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCodigo").Selected = True Then
                    dgvProducto.EditMode = DataGridViewEditMode.EditOnEnter
                    cargarItemProducto(If(IsDBNull(dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCodigo").Value),
                                            Nothing, dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCodigo").Value))
                Else
                    If Not IsDBNull(objVenta.dtProductos.Rows(dgvProducto.CurrentCell.RowIndex).Item("Codigo")) Then
                        calcularCampos()
                    End If
                End If
                calcularTotales()
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub dgvServicio_CellEndEdit(sender As Object, e As EventArgs) Handles dgvServicio.CellEndEdit
        Dim dFila As DataRow = Nothing
        If dgvServicio.RowCount >= 1 Then
            Try
                If Not IsDBNull(dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgIdEmpleado").Value) Then
                    dFila = consultarEmpleado(dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgIdEmpleado").Value)
                    If Not IsNothing(dFila) Then
                        dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgNombreEmpleado").Value = dFila("Nombre")
                    Else
                        dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgIdEmpleado").Value = Nothing
                        dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgNombreEmpleado").Value = Nothing
                        EstiloMensajes.mostrarMensajeError("¡ Empleado no valido !")
                    End If
                Else
                    dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgIdEmpleado").Value = Nothing
                    dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgNombreEmpleado").Value = Nothing
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub dgvProducto_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvProducto.EditingControlShowing
        If objVenta.dtProductos.Rows.Count > 0 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub
    Private Sub dgvServicio_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvServicio.EditingControlShowing
        If objVenta.dtServicio.Rows.Count > 0 Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub
    Private Sub dgvProducto_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducto.CellEnter
        If dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCodigo").Selected = True Then
            dgvProducto.EditMode = DataGridViewEditMode.EditOnEnter
        Else
            dgvProducto.EndEdit()
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
        Try
            Generales.buscarElemento(Sentencias.VENTA_BUSCAR,
                                     params,
                                     AddressOf cargarInfomacion,
                                     Titulo.BUSQUEDA_FACTURA,
                                     True,
                                     True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btExistencia_Click(sender As Object, e As EventArgs) Handles btExistencia.Click
        formExistencia = New FormExistencia
        formExistencia.ShowDialog()
    End Sub
    Private Sub cargarItemProducto(codigo As String)
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(codigo)
        dRows = Generales.cargarItem("[SP_PRODUCTOS_FACTURA_CARGAR]", params)
        If Not IsNothing(dRows) Then
            objVenta.dtProductos(dgvProducto.CurrentCell.RowIndex).Item("Descripcion") = dRows("Descripcion")
            objVenta.dtProductos(dgvProducto.CurrentCell.RowIndex).Item("Stock") = dRows("Stock")
            objVenta.dtProductos(dgvProducto.CurrentCell.RowIndex).Item("Valor") = dRows("Valor")
            dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCantidad").Selected = True
            objVenta.dtProductos.Rows.Add()
        Else
            EstiloMensajes.mostrarMensajeAdvertencia(" Producto no Encontrado ")
        End If
    End Sub
    Private Sub cargarObjeto()
        objVenta.codigo = If(String.IsNullOrEmpty(txtCodigo.Text), Nothing, txtCodigo.Text)
        objVenta.telefono = TextTelefono.Text
        objVenta.nombre = TextNombre.Text
        objVenta.identificacion = txtIdentificacion.Text
    End Sub
    Private Function validarCampos()
        If dgvProducto.Rows.Count <= 1 _
            AndAlso dgvServicio.Rows.Count <= 1 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ No hay ningun movimiento para guardar !")
        ElseIf objVenta.dtProductos.Select("[codigo] Not is null And [Cantidad] = 0").Count > 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ Hay productos con cantidad en 0 !")
        Else
            Return True
        End If
        Return False
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvProducto.EndEdit()
        dgvServicio.EndEdit()
        Try
            If validarCampos() = True Then
                cargarObjeto()
                VentaBLL.guardarVenta(objVenta)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                txtCodigo.Text = objVenta.codigo
                btCancelar.Enabled = False
                btRegistrar.Enabled = False
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            End If
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
        If btRegistrar.Enabled = False Then Exit Sub
        If Not String.IsNullOrEmpty(txtIdentificacion.Text) Then
            Try
                cargarCliente(txtIdentificacion.Text)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub txtIdentificacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdentificacion.KeyDown
        If Not String.IsNullOrEmpty(txtIdentificacion.Text) Then
            Try
                If e.KeyCode = Keys.Enter Then
                    cargarCliente(txtIdentificacion.Text)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                VentaBLL.anularVenta(objVenta)
                If objVenta.estadoAnulado = True Then
                    Generales.deshabilitarBotones(ToolStrip1)
                    Generales.limpiarControles(Me)
                    btNuevo.Enabled = True
                    btBuscar.Enabled = True
                    EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub calcularCampos()
        If dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCantidad").Value >
             dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgStock").Value Then
            dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCantidad").Value = 0
            dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCantidad").Selected = True
            EstiloMensajes.mostrarMensajeAdvertencia("¡ la Cantidad supera la existencia !")
            Exit Sub
        End If
        For indice = 0 To dgvProducto.RowCount - 1
            If Not IsDBNull(dgvProducto.Rows(indice).Cells("dgValor").Value) AndAlso
               Not IsDBNull(dgvProducto.Rows(indice).Cells("dgCantidad").Value) Then
                dgvProducto.Rows(indice).Cells("dgTotal").Value =
                      dgvProducto.Rows(indice).Cells("dgCantidad").Value * dgvProducto.Rows(indice).Cells("dgValor").Value
            End If
        Next
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
    Private Sub cargarInfomacion(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(pCodigo)
        objVenta.codigo = pCodigo
        dRows = Generales.cargarItem("[SP_INVEN_VENTA_CARGAR]", params)

        txtCodigo.Text = pCodigo
        txtIdentificacion.Text = dRows("Identificacion")
        TextNombre.Text = dRows("Nombre")
        TextTelefono.Text = dRows("Telefono")

        Generales.llenarTabla("[SP_VENTA_CARGAR_PRODUCTO]", params, objVenta.dtProductos)
        Generales.llenarTabla("[SP_VENTA_CARGAR_SERVICIO]", params, objVenta.dtServicio)
        dgvProducto.DataSource = objVenta.dtProductos
        dgvServicio.DataSource = objVenta.dtServicio
        calcularTotales()

        Generales.habilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btRegistrar.Enabled = False
        btCancelar.Enabled = False
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
            .Columns("dgStock").DataPropertyName = "Stock"
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
                .Columns("dgCodigo").ReadOnly = False
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
    Private Function consultarEmpleado(codigo As String) As DataRow
        Dim nombre As DataRow
        nombre = Funciones.consultarEmpleado(codigo)
        Return nombre
    End Function
    Private Sub cargarCliente(txtIdent As String)
        Dim dRows As DataRow
        dRows = Funciones.consultarClienteIdent(txtIdentificacion.Text)
        If Not IsNothing(dRows) Then
            objVenta.codigoPersonaCliente = dRows("codigo")
            TextNombre.Text = dRows("Nombre")
            TextTelefono.Text = dRows("Telefono")
        Else
            objVenta.codigoPersonaCliente = Nothing
            TextNombre.Clear()
            TextTelefono.Clear()
            TextNombre.Focus()
        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        Dim nombreArchivo, ruta, formula, nombreReporte As String
        Dim reporte As New CrearInforme
        Dim params As New List(Of String)
        Try
            nombreReporte = "Factura"

            Cursor = Cursors.WaitCursor

            nombreArchivo = nombreReporte & Constantes.NOMBRE_PDF_SEPARADOR & objVenta.codigo & Constantes.EXTENSION_ARCHIVO_PDF
            ruta = IO.Path.GetTempPath() & nombreReporte

            formula = "{VISTA_VENTA.Codigo_Factura} = " & objVenta.codigo

            params.Add(TextTotalArticulos.Text)
            params.Add(TextTotalServicio.Text)
            params.Add(TextTotal.Text)

            reporte.crearReportePDF(New factura, objVenta.codigo, formula, nombreReporte, IO.Path.GetTempPath(),,, params)

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub FormVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F3 Then
            formExistencia = New FormExistencia
            formExistencia.ShowDialog()
        End If
    End Sub
End Class