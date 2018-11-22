Public Class FormEntradaInventario
    Dim objEntrada As EntradaInventario
    Property dtContenedor As DataTable
    Property cantidadEntrante As Integer
    Property codigoProducto As Integer

    Private Sub FormEntradaInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objEntrada = New EntradaInventario
        dtContenedor = New DataTable
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btNuevo.Enabled = True
        btBuscar.Enabled = True
    End Sub
    Private Sub limpiarControl()
        objEntrada.dtEntrada.Clear()
        txtCodigo.Clear()
        txtSubTotal.Clear()
        txtTotal.Clear()
    End Sub
    Private Sub dgvEntrada_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntrada.CellEnter
        If btRegistrar.Enabled = False Then Exit Sub
        Try
            If dgvEntrada.Rows.Count > 0 Then
                If Not IsNothing(dgvEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Cells("dgCodigoProducto").Value) Then
                    If e.ColumnIndex = 5 Then
                        dgvEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Cells("dgBodega") =
                                        Generales.crearControl(Constantes.NOMBRE_COMBO, "[SP_CONFI_BODEGA_CONSULTAR] ''", "Codigo", "nombre", Nothing)
                    End If
                End If
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub validarGrilla()
        With dgvEntrada
            '----------- Asociar datatable con grilla
            .Columns("dgCodigoProducto").DataPropertyName = "Codigo"
            .Columns("dgProducto").DataPropertyName = "producto"
            .Columns("dgValor").DataPropertyName = "valor"
            .Columns("dgCantidad").DataPropertyName = "Cantidad"
            .Columns("dgTotal").DataPropertyName = "Total"
            .Columns("dgBodega").DataPropertyName = "Bodega"
            .Columns("dgLote").DataPropertyName = "Lote"
            '------------------------------------------------------
            .Columns("dgProducto").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("dgValor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgCantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgTotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgBodega").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgLote").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .DataSource = objEntrada.dtEntrada
            .AutoGenerateColumns = False
        End With
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
        btBuscarCompra.Enabled = True
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
                                   "Busqueda de Inventario",
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarInventario(pCodigo As Integer)

    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If String.IsNullOrEmpty(txtCodigo.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ Favor seleccionar la compra !")
        Else
            dgvEntrada.EndEdit()
            EntradaInventarioBLL.guardarEntrada(objEntrada)
            Generales.deshabilitarBotones(ToolStrip1)
            validarEdicionGrilla(Constantes.NO_EDITABLE)
            btBuscarCompra.Enabled = False
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            btAnular.Enabled = True
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            validarEdicionGrilla(Constantes.NO_EDITABLE)
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
    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgvEntrada
            .ReadOnly = False
            .Columns("dgProducto").ReadOnly = True
            .Columns("dgValor").ReadOnly = True
            .Columns("dgCantidad").ReadOnly = True
            .Columns("dgTotal").ReadOnly = True
            .Columns("dgBodega").ReadOnly = True
            .Columns("dgLote").ReadOnly = True
        End With
        If Estado = True Then
            With dgvEntrada
                .Columns("dgBodega").ReadOnly = False
                .Columns("dgLote").ReadOnly = False
            End With
        End If
    End Sub
    Private Sub btBuscarCompra_Click(sender As Object, e As EventArgs) Handles btBuscarCompra.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento("[SP_INVEN_COMPRA_CONSULTAR]",
                                   params,
                                   AddressOf cargarCompra,
                                   "Busqueda de Compra",
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarCompra(pCodigo As Integer)
        Dim params As New List(Of String)
        params.Add(pCodigo)
        txtCodigo.Text = pCodigo
        objEntrada.codigoCompra = pCodigo
        Try
            Generales.llenarTabla("[SP_INVEN_COMPRA_DETALLE]", params, objEntrada.dtEntrada)
            dgvEntrada.DataSource = objEntrada.dtEntrada
            validarEdicionGrilla(Constantes.EDITABLE)
            If dgvEntrada.Rows.Count > 0 Then
                txtSubTotal.Text = Format(objEntrada.dtEntrada.Compute("Sum(Valor)", ""), "C")
                txtTotal.Text = Format(objEntrada.dtEntrada.Compute("Sum(Total)", ""), "C")
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub dgvEntrada_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvEntrada.CellFormatting
        If objEntrada.dtEntrada.Rows.Count > 0 Then
            If e.ColumnIndex = 2 _
                OrElse e.ColumnIndex = 4 Then
                e.Value = If(Not IsDBNull(e.Value), Format(Val(e.Value), "c2"), 0)
            End If
        End If
    End Sub
    Private Sub dgvEntrada_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEntrada.CellClick
        Dim lote As FormLote
        If objEntrada.dtEntrada.Rows.Count > 0 Then
            If e.ColumnIndex = 6 Then
                lote = New FormLote
                codigoProducto = objEntrada.dtEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Item("Codigo")
                cantidadEntrante = objEntrada.dtEntrada.Rows(dgvEntrada.CurrentCell.RowIndex).Item("Cantidad")
                lote.MdiParent = FormPrincipal
                lote.Show()
                lote.Focus()
            End If
        End If
    End Sub

End Class