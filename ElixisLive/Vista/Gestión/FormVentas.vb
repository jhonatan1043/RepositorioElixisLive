Public Class FormVentas
    Dim objVenta As Venta
    Dim formExistencia As FormExistencia
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.asignarPermiso(Me)
        objVenta = New Venta
        Generales.personalizarDatagrid(dgvProducto)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        Generales.personalizarTabControl(tabVenta)
    End Sub
    Private Sub dgvProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducto.CellDoubleClick, DataGridView9.CellDoubleClick, DataGridView3.CellDoubleClick
        Try
            If btRegistrar.Enabled = False Then Exit Sub
            If (dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCodigo").Selected = True Or
                dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgDescripcion").Selected = True) Then
                buscarProducto()
            ElseIf dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True And
                   objVenta.dtProductos.Rows(dgvProducto.CurrentCell.RowIndex).Item("Codigo").ToString <> Constantes.CADENA_VACIA Then
                objVenta.dtProductos.Rows.RemoveAt(e.RowIndex)
                calcularTotales()
            ElseIf dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgEmpleadoN").Selected = True And
                    Not IsDBNull(dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCodigo").Value) Then
                consultarEmpleado(1)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub dgvServicio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicio.CellDoubleClick, DataGridView8.CellDoubleClick, DataGridView2.CellDoubleClick
        Try
            If btRegistrar.Enabled = False Then Exit Sub
            If (dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgCodigoServ").Selected = True Or
                dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgDescripcionServ").Selected = True) Then
                buscarServicio()
            ElseIf dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgQuitarServ").Selected = True And
                   objVenta.dtServicio.Rows(dgvServicio.CurrentCell.RowIndex).Item("Codigo").ToString <> Constantes.CADENA_VACIA Then
                objVenta.dtServicio.Rows.RemoveAt(e.RowIndex)
                calcularTotales()
            ElseIf dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgNombreEmpleado").Selected = True And
                    Not IsDBNull(dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgCodigoServ").Value) Then
                consultarEmpleado(2)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub dgvProducto_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvProducto.CellFormatting, DataGridView9.CellFormatting, DataGridView3.CellFormatting

        If e.ColumnIndex = 5 _
            OrElse e.ColumnIndex = 8 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        ElseIf e.ColumnIndex = 6 Then
            e.Value = Replace(Format(Val(e.Value), "P"), ",00", "")
        End If
    End Sub
    Private Sub dgvServicio_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvServicio.CellFormatting, DataGridView8.CellFormatting, DataGridView2.CellFormatting
        If e.ColumnIndex = 6 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        ElseIf e.ColumnIndex = 4 Then
            e.Value = Replace(Format(Val(e.Value), "P"), ",00", "")
        End If
    End Sub
    Private Sub dgvProducto_CellEndEdit(sender As Object, e As EventArgs) Handles dgvProducto.CellEndEdit
        Dim dFila As DataRow = Nothing
        If dgvProducto.RowCount >= 1 Then
            Try
                If Not IsDBNull(objVenta.dtProductos.Rows(dgvProducto.CurrentCell.RowIndex).Item("Codigo")) Then
                    calcularCampos()
                End If
                calcularTotales()
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(ex.Message)
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
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.habilitarControles(Me)
        dtFecha.Enabled = False
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.limpiarControles(Me)
        valoresPorDefauld()
        desactivadoPermante()
        validarEdicionGrilla(Constantes.EDITABLE)
        dtFecha.Text = Format(DateTime.Now, Constantes.FORMATO_FECHA2)
        objVenta.codigo = Nothing
        objVenta.descuentoCliente = Constantes.SIN_VALOR_NUMERICO
        objVenta.dtProductos.Rows.Add()
        objVenta.dtServicio.Rows.Add()
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        btExistencia.Enabled = True
        txtCodigoBarra.ReadOnly = False
        txtCodigoBarra.Focus()
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento(objVenta.sqlConsulta,
                                     params,
                                     AddressOf cargarInfomacion,
                                     Titulo.BUSQUEDA_FACTURA,
                                     True,
                                     True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub btExistencia_Click(sender As Object, e As EventArgs) Handles btExistencia.Click, Button3.Click, Button1.Click
        formExistencia = New FormExistencia
        formExistencia.ShowDialog()
    End Sub
    Private Sub cargarItemProducto(codigo As String)
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(codigo)
        dRows = Generales.cargarItem(Sentencias.PRODUCTOS_FACTURA_CARGAR, params)
        If Not IsNothing(dRows) Then

            objVenta.dtProductos(dgvProducto.CurrentCell.RowIndex).Item("Descripcion") = dRows("Descripcion")
            objVenta.dtProductos(dgvProducto.CurrentCell.RowIndex).Item("Stock") = dRows("Stock")
            objVenta.dtProductos(dgvProducto.CurrentCell.RowIndex).Item("Valor") = dRows("Valor")
            dgvProducto.Columns("dgCantidad").Selected = True

            If IsDBNull(objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count).Item("Codigo")) And objVenta.estadoFilaNueva = True Then
                objVenta.dtProductos.Rows.Add()
                objVenta.estadoFilaNueva = False
            End If
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
        guardarVenta()
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            lbInformativo.Visible = False
            objVenta.dtCodigoBarra.Clear()
            objVenta.descuentoCliente = Constantes.SIN_VALOR_NUMERICO
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
    Private Sub dgvProducto_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvProducto.KeyDown, DataGridView9.KeyDown, DataGridView3.KeyDown
        If btRegistrar.Enabled = False Then Exit Sub
        If e.KeyCode = Keys.Space Then
            buscarProducto()
        End If
    End Sub
    Private Sub dgvServicio_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvServicio.KeyDown, DataGridView8.KeyDown, DataGridView2.KeyDown
        If btRegistrar.Enabled = False Then Exit Sub
        If e.KeyCode = Keys.Space Then
            buscarServicio()
        End If
    End Sub
    Private Sub txtIdentificacion_Leave(sender As Object, e As EventArgs) Handles txtIdentificacion.Leave, TextBox4.Leave, TextBox31.Leave, TextBox22.Leave, TextBox13.Leave
        If btRegistrar.Enabled = False Then Exit Sub
        If Not String.IsNullOrEmpty(txtIdentificacion.Text) Then
            Try
                cargarCliente(txtIdentificacion.Text)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(ex.Message)
            End Try
        End If
    End Sub
    Private Sub txtIdentificacion_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdentificacion.KeyDown, TextBox4.KeyDown, TextBox31.KeyDown, TextBox22.KeyDown, TextBox13.KeyDown
        If Not String.IsNullOrEmpty(txtIdentificacion.Text) Then
            Try
                If e.KeyCode = Keys.Enter Then
                    cargarCliente(txtIdentificacion.Text)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(ex.Message)
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
                EstiloMensajes.mostrarMensajeError(ex.Message)
            End Try
        End If
    End Sub
    Private Sub calcularCampos()
        Dim descuento As Double
        Dim valor As Integer

        If Not IsDBNull(dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgStock").Value) Then
            If dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCantidad").Value >
             dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgStock").Value Then
                dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCantidad").Value = 0
                EstiloMensajes.mostrarMensajeAdvertencia("¡ la Cantidad supera la existencia !")
                Exit Sub
            End If
            For indice = 0 To dgvProducto.RowCount - 1
                If Not IsDBNull(dgvProducto.Rows(indice).Cells("dgValor").Value) AndAlso
                   Not IsDBNull(dgvProducto.Rows(indice).Cells("dgCantidad").Value) Then
                    valor = dgvProducto.Rows(indice).Cells("dgCantidad").Value * dgvProducto.Rows(indice).Cells("dgValor").Value
                    descuento = (valor * dgvProducto.Rows(indice).Cells("dgDescuento").Value)
                    dgvProducto.Rows(indice).Cells("dgValorDescuento").Value = descuento
                    dgvProducto.Rows(indice).Cells("dgTotal").Value = (valor - descuento)
                End If
            Next
        Else
            cargarItemProducto(dgvProducto.Rows(dgvProducto.CurrentCell.RowIndex).Cells("dgCodigo").Value)
        End If
    End Sub
    Private Sub calcularTotales()
        Dim descuento As Double
        Dim valorTotal As Integer
        Dim descuentoTotalServicio As Integer
        Dim descuentoTotalProducto As Integer

        dgvProducto.EndEdit()
        dgvServicio.EndEdit()
        Try
            Dim cantidadArticulos,
                cantidadServicio As Double
            If dgvProducto.Rows.Count >= 1 Then
                cantidadArticulos = objVenta.dtProductos.Compute("SUM(Total)", "")
                descuentoTotalProducto = objVenta.dtProductos.Compute("SUM(valorDescuento)", "")
            Else
                cantidadArticulos = Constantes.SIN_VALOR_NUMERICO
            End If
            If dgvServicio.Rows.Count >= 1 Then
                cantidadServicio = objVenta.dtServicio.Compute("SUM(ValorServicio)", "")
                descuentoTotalServicio = objVenta.dtServicio.Compute("SUM(valorDescuento)", "")
            Else
                cantidadServicio = Constantes.SIN_VALOR_NUMERICO
            End If
            TextTotalArticulos.Text = CDbl(cantidadArticulos).ToString(Constantes.FORMATO_MONEDA)
            TextTotalServicio.Text = CDbl(cantidadServicio).ToString(Constantes.FORMATO_MONEDA)

            valorTotal = (cantidadArticulos + cantidadServicio)
            descuento = (valorTotal * objVenta.descuentoCliente)
            TextTotal.Text = CDbl(valorTotal - descuento).ToString(Constantes.FORMATO_MONEDA)
            txtDescuento.Text = CDbl(descuentoTotalProducto + descuentoTotalServicio + descuento).ToString(Constantes.FORMATO_MONEDA)

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub cargarInfomacion(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(pCodigo)
        objVenta.codigo = pCodigo
        dRows = Generales.cargarItem(objVenta.sqlCargar, params)

        txtCodigo.Text = pCodigo
        txtIdentificacion.Text = dRows("Identificacion")
        TextNombre.Text = dRows("Nombre")
        TextTelefono.Text = dRows("Telefono")
        dtFecha.Text = Format(dRows("Fecha_Venta"), Constantes.FORMATO_FECHA2)
        objVenta.descuentoCliente = dRows("Descuento")

        If Replace(dRows("Descuento"), ",00", "") <> Constantes.SIN_VALOR_NUMERICO Then
            lbInformativo.Visible = True
            lbInformativo.Text = "Este cliente presentó un descuento del " & CStr(Replace(Format(objVenta.descuentoCliente, "p2"), ",00", ""))
        End If

        Generales.llenarTabla(Sentencias.VENTA_CARGAR_PRODUCTO, params, objVenta.dtProductos)
        Generales.llenarTabla(Sentencias.VENTA_CARGAR_SERVICIO, params, objVenta.dtServicio)

        dgvProducto.DataSource = objVenta.dtProductos
        dgvServicio.DataSource = objVenta.dtServicio
        calcularTotales()

        Generales.habilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btRegistrar.Enabled = False
        btCancelar.Enabled = False
    End Sub
    Private Sub buscarServicio()
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Generales.busquedaItems(Sentencias.SERVICIO_FACTURA_CONSULTAR,
                                   params,
                                   Titulo.BUSQUEDA_SERVICIO,
                                   dgvServicio,
                                   objVenta.dtServicio,
                                   0,
                                   4,
                                   0,
                                   0,
                                   True)
        calcularTotales()
    End Sub
    Private Sub buscarProducto()
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(SesionActual.codigoSucursal)
        Try
            Generales.buscarElemento(Sentencias.PRODUCTOS_FACTURA_CONSULTAR,
                                     params,
                                     AddressOf cargarProductoFactura,
                                     Titulo.BUSQUEDA_PRODUCTO,
                                     True,
                                     True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub cargarProductoFactura(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dt As New DataTable
        params.Add(pCodigo)
        Generales.llenarTabla(Sentencias.PRODUCTOS_FACTURA_PENDIENTE_CARGAR, params, dt)
        If dt.Rows.Count > 0 Then
            objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Codigo") = dt.Rows(dt.Rows.Count - 1).Item("Codigo")
            objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Descripcion") = dt.Rows(dt.Rows.Count - 1).Item("Descripcion")
            objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Stock") = dt.Rows(dt.Rows.Count - 1).Item("Stock")
            objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Cantidad") = dt.Rows(dt.Rows.Count - 1).Item("Cantidad")
            objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Valor") = dt.Rows(dt.Rows.Count - 1).Item("Precio")
            objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("descuento") = dt.Rows(dt.Rows.Count - 1).Item("descuento")
            objVenta.dtProductos.Rows.Add()
            calcularTotales()
        End If
    End Sub
    Private Sub validarGrilla()
        With dgvProducto
            .ReadOnly = False
            .Columns("dgCodigo").DataPropertyName = "codigo"
            .Columns("dgDescripcion").DataPropertyName = "Descripcion"
            .Columns("dgStock").DataPropertyName = "Stock"
            .Columns("dgCantidad").DataPropertyName = "Cantidad"
            .Columns("dgValor").DataPropertyName = "Valor"
            .Columns("dgDescuento").DataPropertyName = "descuento"
            .Columns("dgValorDescuento").DataPropertyName = "valorDescuento"
            .Columns("dgTotal").DataPropertyName = "Total"
            .Columns("dgEmpleadoP").DataPropertyName = "EmpleadoP"
            .Columns("dgEmpleadoN").DataPropertyName = "EmpleadoN"

            .Columns("dgCodigo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgDescripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgCantidad").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgDescuento").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgValor").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgTotal").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgEmpleadoP").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .DataSource = objVenta.dtProductos
            .AutoGenerateColumns = False
        End With

        With dgvServicio

            .ReadOnly = False
            .Columns("dgCodigoServ").DataPropertyName = "codigo"
            .Columns("dgDescripcionServ").DataPropertyName = "Descripcion"
            .Columns("dgDescuentoS").DataPropertyName = "Descuento"
            .Columns("dgValorDescuentoS").DataPropertyName = "valorDescuento"
            .Columns("dgValorServ").DataPropertyName = "ValorServicio"
            .Columns("dgIdEmpleado").DataPropertyName = "codigo_Empleado"
            .Columns("dgNombreEmpleado").DataPropertyName = "NombreEmpleado"

            .Columns("dgCodigoServ").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgDescripcionServ").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgDescuentoS").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgValorServ").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgIdEmpleado").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgNombreEmpleado").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("dgIdEmpleado").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .DataSource = objVenta.dtServicio
            .AutoGenerateColumns = False
        End With
    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)

        With dgvProducto
            .ReadOnly = False
            .Columns("dgCodigo").ReadOnly = True
            .Columns("dgDescripcion").ReadOnly = True
            .Columns("dgDescuento").ReadOnly = True
            .Columns("dgValor").ReadOnly = True
            .Columns("dgCantidad").ReadOnly = True
            .Columns("dgTotal").ReadOnly = True
            .Columns("dgEmpleadoP").ReadOnly = True
        End With
        If Estado = True Then
            With dgvProducto
                .Columns("dgCantidad").ReadOnly = False
                .Columns("dgEmpleadoP").ReadOnly = False
            End With
        End If

        With dgvServicio
            .ReadOnly = False
            .Columns("dgCodigoServ").ReadOnly = True
            .Columns("dgDescripcionServ").ReadOnly = True
            .Columns("dgValorServ").ReadOnly = True
            .Columns("dgDescuentoS").ReadOnly = True
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
            objVenta.descuentoCliente = dRows("Descuento")
            If Replace(dRows("Descuento"), ",00", "") <> Constantes.SIN_VALOR_NUMERICO Then
                lbInformativo.Visible = True
                lbInformativo.Text = "Este cliente presenta un descuento del " & CStr(Replace(Format(objVenta.descuentoCliente, "p2"), ",00", ""))
                calcularTotales()
            End If
        Else
            objVenta.codigoPersonaCliente = Nothing
            TextNombre.Clear()
            TextTelefono.Clear()
        End If
    End Sub
    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        Dim nombreArchivo, ruta, formula, nombreReporte As String
        Dim reporte As New CrearInforme
        Dim params As New List(Of String)
        Dim convertirNumeroLetra As New ConvertirNumeros
        Try
            nombreReporte = "Factura"

            Cursor = Cursors.WaitCursor

            nombreArchivo = nombreReporte & Constantes.NOMBRE_PDF_SEPARADOR & objVenta.codigo & Constantes.EXTENSION_ARCHIVO_PDF
            ruta = IO.Path.GetTempPath() & nombreReporte

            formula = "{VISTA_VENTA.Codigo_Factura} = " & objVenta.codigo

            params.Add(TextTotalArticulos.Text)
            params.Add(TextTotalServicio.Text)
            params.Add(TextTotal.Text)
            params.Add(txtDescuento.Text)
            params.Add(convertirNumeroLetra.Num2MoneyTxt(TextTotal.Text))

            reporte.crearReportePDF(New factura, objVenta.codigo, formula, nombreReporte, IO.Path.GetTempPath(),,, params)

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub dgvServicio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicio.CellClick, DataGridView8.CellClick, DataGridView2.CellClick
        If e.ColumnIndex = 0 Then
            If objVenta.dtServicio.Rows.Count > 0 Then
                cargarCostosServicio(If(IsDBNull(objVenta.dtServicio.Rows(dgvServicio.CurrentCell.RowIndex).Item("codigo")), Nothing,
                                     objVenta.dtServicio.Rows(dgvServicio.CurrentCell.RowIndex).Item("codigo")))
            End If
        End If
    End Sub
    Private Sub cargarCostosServicio(pcodigo)
        Dim params As New List(Of String)
        Dim dtServicioCosto As New DataTable
        params.Add(pcodigo)
        Generales.llenarTabla("[SP_COSTO_FACTURA_SERVICIO_CARGAR]", params, dtServicioCosto)
        dgvDetalle.DataSource = dtServicioCosto
        If dtServicioCosto.Rows.Count > 0 Then

            With dgvDetalle
                .ReadOnly = True
                .Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Costo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            End With

            PanelGastos.Visible = True
            txtTotalGastos.Text = Format(dtServicioCosto.Compute("SUM(Costo)", String.Empty), Constantes.FORMATO_MONEDA)
            PanelGastos.Focus()

        End If
    End Sub
    Private Sub PanelGastos_LostFocus(sender As Object, e As EventArgs) Handles PanelGastos.LostFocus, Panel4.LostFocus, Panel2.LostFocus
        PanelGastos.Visible = False
    End Sub

    Private Sub TextNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNombre.KeyPress, TextBox6.KeyPress, TextBox33.KeyPress, TextBox24.KeyPress, TextBox15.KeyPress
        ValidacionDigitacion.validarAlfabetico(e)
    End Sub

    Private Sub txtIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdentificacion.KeyPress, TextTelefono.KeyPress, TextBox5.KeyPress, TextBox4.KeyPress, TextBox32.KeyPress, TextBox31.KeyPress, TextBox23.KeyPress, TextBox22.KeyPress, TextBox14.KeyPress, TextBox13.KeyPress
        ValidacionDigitacion.validarValoresNumericos(e)
    End Sub
    Private Sub consultarEmpleado(indice As Integer)
        Dim params As New List(Of String)
        params.Add(String.Empty)
        objVenta.indice = indice
        Try
            Generales.buscarElemento("[SP_ADMIN_EMPLEADO_CONSULTAR]",
                                     params,
                                     AddressOf empleadoCargar,
                                     Titulo.BUSQUEDA_EMPLEADO,
                                     True,
                                     True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub empleadoCargar(pCodigo)
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(pCodigo)
        dRows = Generales.cargarItem(Sentencias.PERSONA_EMPLEADO_CARGAR, params)
        If objVenta.indice = 1 Then
            objVenta.dtProductos.Rows(dgvProducto.CurrentCell.RowIndex).Item("EmpleadoP") = pCodigo
            objVenta.dtProductos.Rows(dgvProducto.CurrentCell.RowIndex).Item("EmpleadoN") = dRows("Nombre")
            objVenta.dtProductos.AcceptChanges()
        ElseIf objVenta.indice = 2 Then
            objVenta.dtServicio.Rows(dgvServicio.CurrentCell.RowIndex).Item("codigo_Empleado") = pCodigo
            objVenta.dtServicio.Rows(dgvServicio.CurrentCell.RowIndex).Item("NombreEmpleado") = dRows("Nombre")
            objVenta.dtServicio.AcceptChanges()
        End If
    End Sub
    Private Sub desactivadoPermante()
        TextTotal.ReadOnly = True
        TextTotalArticulos.ReadOnly = True
        TextTotalServicio.ReadOnly = True
        txtTotalGastos.ReadOnly = True
        txtDescuento.ReadOnly = True
    End Sub
    Private Sub valoresPorDefauld()
        TextTotal.Text = Format(0, Constantes.FORMATO_MONEDA)
        TextTotalArticulos.Text = Format(0, Constantes.FORMATO_MONEDA)
        TextTotalServicio.Text = Format(0, Constantes.FORMATO_MONEDA)
        txtTotalGastos.Text = Format(0, Constantes.FORMATO_MONEDA)
        txtDescuento.Text = Format(0, Constantes.FORMATO_MONEDA)
        lbInformativo.Visible = False
    End Sub
    Private Sub FormVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        funcionesFormulario(e)
    End Sub
    Private Sub guardarVenta()
        dgvProducto.EndEdit()
        dgvServicio.EndEdit()
        Try
            If validarCampos() = True Then
                cargarObjeto()
                VentaBLL.guardarVenta(objVenta)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                objVenta.dtCodigoBarra.Clear()
                txtCodigo.Text = objVenta.codigo
                cargarInfomacion(txtCodigo.Text)
                btCancelar.Enabled = False
                btRegistrar.Enabled = False
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub funcionesFormulario(e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F10 Then
            If btRegistrar.Enabled = False Then Exit Sub
            If EstiloMensajes.mostrarMensajePregunta("¡ Desea Registro la Compra !", "Registrar") = Constantes.SI Then
                guardarVenta()
            End If
        ElseIf e.KeyCode = Keys.F2 Then
            If btRegistrar.Enabled = False Then Exit Sub
            formExistencia = New FormExistencia
            formExistencia.ShowDialog()
        End If
    End Sub
    Private Sub cargarProductoCodigoBarra(pCodigoBarra As String)
        Dim params As New List(Of String)
        Dim dt As New DataTable
        params.Add(pCodigoBarra)
        params.Add(SesionActual.codigoSucursal)
        Generales.llenarTabla(Sentencias.PRODUCTO_CODIGO_BARRA_CARGAR, params, dt)
        If dt.Rows.Count > 0 Then
            If objVenta.dtCodigoBarra.Select("codigoBarra='" + pCodigoBarra + "'").Count = 0 Then
                objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Codigo") = dt.Rows(dt.Rows.Count - 1).Item("Codigo")
                objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Descripcion") = dt.Rows(dt.Rows.Count - 1).Item("Descripcion")
                objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Stock") = dt.Rows(dt.Rows.Count - 1).Item("Stock")
                objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Cantidad") = dt.Rows(dt.Rows.Count - 1).Item("Cantidad")
                objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("Valor") = dt.Rows(dt.Rows.Count - 1).Item("Precio")
                objVenta.dtProductos.Rows(objVenta.dtProductos.Rows.Count - 1).Item("descuento") = dt.Rows(dt.Rows.Count - 1).Item("descuento")
                objVenta.dtProductos.Rows.Add()
                objVenta.dtCodigoBarra.Rows.Add()
                objVenta.dtCodigoBarra.Rows(objVenta.dtCodigoBarra.Rows.Count - 1).Item("codigoBarra") = pCodigoBarra
                calcularCampos()
            Else
                Beep()
            End If
            calcularTotales()
        Else
            EstiloMensajes.mostrarMensajeAdvertencia("Registro no encontrado")
        End If
        txtCodigoBarra.Focus()
    End Sub
    Private Sub txtCodigoBarra_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoBarra.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtCodigoBarra.Text.Length > 0 Then
                cargarProductoCodigoBarra(txtCodigoBarra.Text)
                txtCodigoBarra.Clear()
                txtCodigoBarra.Focus()
            End If
        End If
    End Sub


End Class