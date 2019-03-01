Public Class FormConfigVenta
    Dim objConfigVenta As ConfigVenta
    Dim bdNavegador As New BindingSource
    Private Sub FormConfigVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objConfigVenta = New ConfigVenta
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        Generales.cargarCombo("[SP_INVEN_PRODUCTO_LISTA]", Nothing, "Nombre", "codigo", cbListaProducto)
        Generales.cargarCombo("[SP_INVEN_SERVICIO_LISTA]", Nothing, "Nombre", "codigo", cbListaServicio)
        cargarConfVenta()
        btEditar.Enabled = True
        Generales.asignarPermiso(Me)
    End Sub
    Private Sub cargarConfVenta()
        Dim dFila As DataRow
        Dim params As New List(Of String)
        params.Add(SesionActual.codigoEmpresa)
        Try
            dFila = Generales.cargarItem(objConfigVenta.sqlCargar, params)
            If Not IsNothing(dFila) Then
                cbListaProducto.SelectedValue = If(IsDBNull(dFila("codigo_lista_producto")), -1, dFila("codigo_lista_producto"))
                cbListaServicio.SelectedValue = If(IsDBNull(dFila("codigo_lista_servicio")), -1, dFila("codigo_lista_servicio"))
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            validarEdicionGrilla(Constantes.EDITABLE)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarControles(Me)
            Generales.deshabilitarBotones(ToolStrip1)
            cargarConfVenta()
            btEditar.Enabled = True
        End If
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try
            dgRegistro.EndEdit()

            objConfigVenta.codigoListaProducto = If(cbListaProducto.SelectedIndex = 0, Nothing, cbListaProducto.SelectedValue)
            objConfigVenta.codigoListaServicio = If(cbListaServicio.SelectedIndex = 0, Nothing, cbListaServicio.SelectedValue)

            ConfigVentaBLL.guardarConfVenta(objConfigVenta)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)

            btEditar.Enabled = True
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub dgRegistro_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgRegistro.EditingControlShowing
        AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
    End Sub
    Private Sub validarGrilla()
        With dgRegistro
            .Columns("dgCodigo").DataPropertyName = "Codigo"
            .Columns("dgDescripcion").DataPropertyName = "Descripcion"
            .Columns("dgDescuento").DataPropertyName = "Descuento"
            .Columns("dgFechaDescuento").DataPropertyName = "F_Inicio"
            .Columns("dgFechaDF").DataPropertyName = "F_Fin"
            .AutoGenerateColumns = False
        End With
    End Sub

    Private Sub btCargarProducto_Click(sender As Object, e As EventArgs) Handles btCargarProducto.Click
        cargarDgview("[SP_CONFI_LISTA_PRODUCTO_DESCUENTO]", cbListaProducto.SelectedValue)
        If objConfigVenta.dtEvento.Rows.Count > 0 Then
            btCargarProducto.Enabled = False
            btCargarServicio.Enabled = True
            objConfigVenta.indice = Constantes.CPRODUCTO
        End If
    End Sub
    Private Sub btCargarServicio_Click(sender As Object, e As EventArgs) Handles btCargarServicio.Click
        cargarDgview("[SP_CONFI_LISTA_SERVICIO_DESCUENTO]", cbListaServicio.SelectedValue)
        If objConfigVenta.dtEvento.Rows.Count > 0 Then
            btCargarServicio.Enabled = False
            btCargarProducto.Enabled = True
            objConfigVenta.indice = Constantes.CSERVICIO
        End If
    End Sub
    Private Sub cargarDgview(consulta As String, codigo As String)
        Dim params As New List(Of String)
        params.Add(codigo)
        Generales.llenarTabla(consulta, params, objConfigVenta.dtEvento)
        bdNavegador.DataSource = objConfigVenta.dtEvento
        dgRegistro.DataSource = bdNavegador.DataSource
    End Sub
    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            bdNavegador.Filter = "Descripcion Like '%" & txtFiltro.Text & "%'"
        End If
    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgRegistro
            .ReadOnly = False
            .Columns("dgCodigo").ReadOnly = True
            .Columns("dgDescripcion").ReadOnly = True
            .Columns("dgDescuento").ReadOnly = True
            .Columns("dgFechaDescuento").ReadOnly = True
            .Columns("dgFechaDF").ReadOnly = True
        End With
        If Estado = True Then
            With dgRegistro
                .Columns("dgDescuento").ReadOnly = False
                .Columns("dgFechaDescuento").ReadOnly = False
                .Columns("dgFechaDF").ReadOnly = False
            End With
        End If
    End Sub
    Private Sub FormProductoUbicacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
End Class