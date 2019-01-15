Public Class FormEntradaInventario
    Dim objEntrada As EntradaInventario
    Property dtContenedorLote As DataTable
    Property cantidadEntrante As Integer
    Property codigoProducto As Integer
    Property registroGuardado As Boolean

    Private Sub FormEntradaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim respuesta As Integer = Generales.consultarPermiso(Name)
        If respuesta = Constantes.LECTURA_ESCRITURA Then
            Generales.mostrarLecturaEscritura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_LECTURA Then
            Generales.mostrarLectura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_ESCRITURA Then
            Generales.mostrarEscritura(ToolStrip1)
        Else
            Generales.ocultarBotones(ToolStrip1)
        End If
        objEntrada = New EntradaInventario
        dtContenedorLote = New DataTable
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        Generales.cargarCombo(Sentencias.MOVIMIENTO_CONSULTAR, Nothing, "Nombre", "Codigo", cbMovimiento)
        validarGrilla()
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        Generales.tabularConEnter(Me)
    End Sub

    Private Sub dgvEntrada_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntrada.CellEnter
        If btRegistrar.Enabled = False Then Exit Sub
        Try
            If dgvEntrada.Rows.Count > 0 Then
                If Not IsNothing(dgvEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Cells("dgCodigoProducto").Value) Then
                    If e.ColumnIndex = 6 Then
                        dgvEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Cells("dgBodega") =
                                        Generales.crearControl(Constantes.NOMBRE_COMBO, Sentencias.BODEGA_CONSULTAR, "Codigo", "nombre", Nothing)
                    End If
                End If
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        limpiarControl()
        registroGuardado = False
        Generales.habilitarControles(gbModo)
        validarEdicionGrilla(Constantes.EDITABLE)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento(objEntrada.sqlConsulta,
                                   params,
                                   AddressOf cargarInventario,
                                   Titulo.BUSQUEDA_INVENTARIO,
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvEntrada.EndEdit()
        Dim bodega As Integer = objEntrada.dtEntrada.Select("[Codigo] IS NOT NULL AND [Bodega] IS NULL").Count
        If String.IsNullOrEmpty(txtCodigo.Text) And rbCompra.Checked = True Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ Favor seleccionar la compra !")
        ElseIf bodega > 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ Faltan productos por asignar bodega !")
        ElseIf cbMovimiento.SelectedIndex = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ Seleccione un movimiento al inventario !")
        Else
            Try

                objEntrada.codigoCompra = If(String.IsNullOrEmpty(txtCodigo.Text), Nothing, txtCodigo.Text)
                objEntrada.codigoMovimiento = cbMovimiento.SelectedValue
                EntradaInventarioBLL.guardarEntrada(objEntrada)
                rbCompra.Checked = False
                rvManual.Checked = False
                Generales.deshabilitarControles(Me)
                Generales.deshabilitarBotones(ToolStrip1)
                btBuscarCompra.Enabled = False
                btNuevo.Enabled = True
                btBuscar.Enabled = True
                btAnular.Enabled = True
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            limpiarControl()
            btBuscarCompra.Enabled = False
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objEntrada.sqlAnular & objEntrada.codigo) = True Then
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
    Private Sub btBuscarCompra_Click(sender As Object, e As EventArgs) Handles btBuscarCompra.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento(Sentencias.COMPRA_CONSULTAR,
                                   params,
                                   AddressOf cargarCompra,
                                   Titulo.BUSQUEDA_COMPRA,
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub dgvEntrada_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvEntrada.CellFormatting
        If objEntrada.dtEntrada.Rows.Count > 0 Then
            If e.ColumnIndex = 4 _
                OrElse e.ColumnIndex = 5 Then
                e.Value = If(Not IsDBNull(e.Value), Format(Val(e.Value), Constantes.FORMATO_MONEDA), 0)
            End If
        End If
    End Sub
    Private Sub dgvEntrada_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntrada.CellClick
        Dim params As New List(Of String)
        params.Add(String.Empty)

        If rbCompra.Checked = True Then Exit Sub

        If objEntrada.dtEntrada.Rows.Count > 0 Then
            Try
                If btRegistrar.Enabled = False Then Exit Sub
                If (dgvEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Cells("dgCodigoProducto").Selected = True _
                    Or dgvEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Cells("dgDescripcion").Selected = True) Then
                    Generales.busquedaItems(Sentencias.PRODUCTO_CONSULTAR,
                                              params,
                                              Titulo.BUSQUEDA_PRODUCTO,
                                              dgvEntrada,
                                              objEntrada.dtEntrada,
                                              0,
                                              1,
                                              0,
                                              0,
                                              True)
                ElseIf dgvEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True _
                    And objEntrada.dtEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Item(0).ToString <> String.Empty Then
                    If rbCompra.Checked = False Then
                        objEntrada.dtEntrada.Rows.RemoveAt(e.RowIndex)
                    End If
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub cargarInventario(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(pCodigo)
        dRows = Generales.cargarItem(objEntrada.sqlCargar, params)
        If Not IsDBNull(dRows("Codigo_Compra")) Then
            rbCompra.Checked = True
            txtCodigo.Text = dRows("Codigo_Compra")
        Else
            rvManual.Checked = True
        End If
        cbMovimiento.SelectedValue = dRows("Codigo_Movimiento")
        registroGuardado = True
        Generales.llenarTabla(objEntrada.sqlCargarDetalle, params, objEntrada.dtEntrada)
        dgvEntrada.DataSource = objEntrada.dtEntrada
        If dgvEntrada.Rows.Count > 0 Then
            txtSubTotal.Text = Format(objEntrada.dtEntrada.Compute("Sum(Valor)", Constantes.CADENA_VACIA), Constantes.FORMATO_MONEDA)
            txtTotal.Text = Format(objEntrada.dtEntrada.Compute("Sum(Total)", Constantes.CADENA_VACIA), Constantes.FORMATO_MONEDA)
        End If
        Generales.habilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btRegistrar.Enabled = False
        btCancelar.Enabled = False
    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgvEntrada
            .ReadOnly = False
            .Columns("dgDescripcion").ReadOnly = True
            .Columns("dgValor").ReadOnly = True
            .Columns("dgCantidad").ReadOnly = True
            .Columns("dgTotal").ReadOnly = True
            .Columns("dgBodega").ReadOnly = True
            .Columns("dgCodigoBarra").ReadOnly = True
        End With
        If Estado = True Then
            With dgvEntrada
                .Columns("dgCantidad").ReadOnly = False
                .Columns("dgValor").ReadOnly = False
                .Columns("dgBodega").ReadOnly = False
            End With
        End If
    End Sub
    Private Sub validarGrilla()
        With dgvEntrada

            '----------- Asociar datatable con grilla
            .Columns("dgCodigoProducto").DataPropertyName = "Codigo"
            .Columns("dgDescripcion").DataPropertyName = "Descripcion"
            .Columns("dgValor").DataPropertyName = "valor"
            .Columns("dgCantidad").DataPropertyName = "Cantidad"
            .Columns("dgTotal").DataPropertyName = "Total"
            .Columns("dgBodega").DataPropertyName = "Bodega"
            .Columns("dgCodigoBarra").DataPropertyName = "CodigoBarra"
            '------------------------------------------------------
            .Columns("dgDescripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("dgValor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgCantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgTotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgBodega").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgCodigoBarra").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .DataSource = objEntrada.dtEntrada
            .AutoGenerateColumns = False
            .Columns("dgQuitar").DisplayIndex = 7
        End With
    End Sub
    Private Sub cargarCompra(pCodigo As Integer)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtCodigo.Text = pCodigo
        objEntrada.codigoCompra = pCodigo
        Try
            Generales.llenarTabla(Sentencias.COMPRA_CARGAR_DETALLE, params, objEntrada.dtEntrada)
            dgvEntrada.DataSource = objEntrada.dtEntrada
            validarEdicionGrilla(Constantes.EDITABLE)
            If dgvEntrada.Rows.Count > 0 Then
                txtSubTotal.Text = Format(objEntrada.dtEntrada.Compute("Sum(Valor)", Constantes.CADENA_VACIA), Constantes.FORMATO_MONEDA)
                txtTotal.Text = Format(objEntrada.dtEntrada.Compute("Sum(Total)", Constantes.CADENA_VACIA), Constantes.FORMATO_MONEDA)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub limpiarControl()
        objEntrada.dtEntrada.Clear()
        txtCodigo.Clear()
        txtSubTotal.Clear()
        txtTotal.Clear()
    End Sub
    Private Sub dgvEntrada_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvEntrada.DataError
        If e.ColumnIndex = 2 Then
            EstiloMensajes.mostrarMensajeError(MensajeSistema.INGRESAR_VALOR_VALIDO)
        End If
    End Sub
    Private Sub rbCompra_Click(sender As Object, e As EventArgs) Handles rbCompra.Click
        limpiar()
    End Sub
    Private Sub rvManual_Click(sender As Object, e As EventArgs) Handles rvManual.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        txtSubTotal.Clear()
        txtTotal.Clear()
        If rbCompra.Checked = True Then
            objEntrada.dtEntrada.Clear()
            btBuscarCompra.Enabled = True
            dgvEntrada.Columns("dgQuitar").Visible = False
            cbMovimiento.SelectedValue = 1
            cbMovimiento.Enabled = False
        Else
            objEntrada.dtEntrada.Clear()
            txtCodigo.Clear()
            btBuscarCompra.Enabled = False
            objEntrada.dtEntrada.Rows.Add()
            dgvEntrada.Columns("dgQuitar").Visible = True
            cbMovimiento.Enabled = True
        End If
    End Sub
    Private Sub dgvEntrada_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntrada.CellEndEdit
        If dgvEntrada.RowCount >= 1 Then
            Try
                For indice = 0 To dgvEntrada.RowCount - 1
                    If Not IsDBNull(dgvEntrada.Rows(indice).Cells("dgValor").Value) AndAlso Not IsDBNull(dgvEntrada.Rows(indice).Cells("dgCantidad").Value) Then
                        dgvEntrada.Rows(indice).Cells("dgTotal").Value = dgvEntrada.Rows(indice).Cells("dgValor").Value * dgvEntrada.Rows(indice).Cells("dgCantidad").Value
                    End If
                Next
                txtSubTotal.Text = Format(objEntrada.dtEntrada.Compute("Sum(Valor)", Constantes.CADENA_VACIA), Constantes.FORMATO_MONEDA)
                txtTotal.Text = Format(objEntrada.dtEntrada.Compute("Sum(Total)", Constantes.CADENA_VACIA), Constantes.FORMATO_MONEDA)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
End Class