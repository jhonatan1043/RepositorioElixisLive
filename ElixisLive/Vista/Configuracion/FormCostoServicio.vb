Public Class FormCostoServicio
    Dim objCostoServicio As CostoServicio
    Private Sub FormCostoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCostoServicio = New CostoServicio
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        Generales.tabularConEnter(Me)
    End Sub
    Private Sub btBuscarServicio_Click(sender As Object, e As EventArgs) Handles btBuscarServicio.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(String.Empty)
        Generales.buscarElemento("[SP_SERVICIO_COSTOS_CONSULTAR]",
                                  params,
                                  AddressOf cargarServicio,
                                  Titulo.BUSQUEDA_SERVICIO,
                                  False,
                                  True)
    End Sub
    Private Sub cargarServicio(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(pCodigo)
        dRows = Generales.cargarItem("[SP_SERVICIO_CARGAR]", params)
        objCostoServicio.codigoServicio = pCodigo
        txtcodigo.Text = pCodigo
        txtnombre.Text = dRows("Descripcion")
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Gbdatos)
        Generales.limpiarControles(Me)
        validarEdicionGrilla(Constantes.EDITABLE)
        objCostoServicio.dtRegistro.Rows.Add()
        objCostoServicio.codigoServicio = Nothing
        btBuscarServicio.Enabled = True
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try
            If validarCampos() = True Then
                CostoServicioBLL.guardarCostoServicio(objCostoServicio)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btCancelar.Enabled = False
                btRegistrar.Enabled = False
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Gbdatos)
            validarEdicionGrilla(Constantes.EDITABLE)
            objCostoServicio.dtRegistro.Rows.Add()
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            objCostoServicio.codigoServicio = Nothing
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub
    Private Sub validarGrilla()
        With dgvRegistro

            .DataSource = objCostoServicio.dtRegistro

            .Columns("Codigo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Descripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Valor").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Concentracion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("U.Medida").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Servicios").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Costo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Recomendacion").SortMode = DataGridViewColumnSortMode.NotSortable

            .Columns("Codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Valor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Concentracion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("U.Medida").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Servicios").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Costo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Recomendacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            .Columns("Valor").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Concentracion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("U.Medida").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Servicios").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Costo").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Recomendacion").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

            .Columns("dgQuitar").DisplayIndex = 8

            .AutoGenerateColumns = False

        End With
    End Sub

    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgvRegistro
            .ReadOnly = False
            .Columns("Codigo").ReadOnly = True
            .Columns("Descripcion").ReadOnly = True
            .Columns("Valor").ReadOnly = True
            .Columns("Concentracion").ReadOnly = True
            .Columns("U.Medida").ReadOnly = True
            .Columns("Servicios").ReadOnly = True
            .Columns("Costo").ReadOnly = True
            .Columns("Recomendacion").ReadOnly = True
        End With
        If Estado = True Then
            With dgvRegistro
                .Columns("Valor").ReadOnly = False
                .Columns("Recomendacion").ReadOnly = False
            End With
        End If
    End Sub
    Private Sub dgvRegistro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistro.CellDoubleClick
        consultarProducto()
    End Sub
    Private Sub consultarProducto()
        Dim params As New List(Of String)
        params.Add(String.Empty)

        If objCostoServicio.dtRegistro.Rows.Count > 0 Then
            Try
                If btRegistrar.Enabled = False Then Exit Sub
                If (dgvRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Cells("Codigo").Selected = True _
                    Or dgvRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Cells("Descripcion").Selected = True) Then
                    Generales.busquedaItems("[SP_PRODUCTOS_COSTO_CONSULTAR]",
                                              params,
                                              Titulo.BUSQUEDA_PRODUCTO,
                                              dgvRegistro,
                                              objCostoServicio.dtRegistro,
                                              0,
                                              3,
                                              0,
                                              0,
                                              True)
                ElseIf dgvRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True _
                    And objCostoServicio.dtRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Item(0).ToString <> String.Empty Then
                    objCostoServicio.dtRegistro.Rows.RemoveAt(dgvRegistro.CurrentCell.RowIndex)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub dgvRegistro_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvRegistro.CellFormatting
        If objCostoServicio.dtRegistro.Rows.Count > 0 Then
            If e.ColumnIndex = 5 _
                OrElse e.ColumnIndex = 8 Then
                e.Value = If(Not IsDBNull(e.Value), Format(Val(e.Value), Constantes.FORMATO_MONEDA), 0)
            End If
        End If
    End Sub

    Private Sub dgvRegistro_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRegistro.CellEndEdit
        Dim costo As Integer
        Dim servicio As Integer
        If btRegistrar.Enabled = False Then Exit Sub
        If objCostoServicio.dtRegistro.Rows.Count > 0 Then
            If e.ColumnIndex = 6 Then
                If objCostoServicio.dtRegistro.Select("Codigo Is Not Null and Concentracion <> 0 and Recomendacion <> 0").Count > 0 Then
                    servicio = (dgvRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Cells("Concentracion").Value / dgvRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Cells("Recomendacion").Value)
                    dgvRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Cells("Servicios").Value = servicio
                End If
                objCostoServicio.dtRegistro.AcceptChanges()
                If objCostoServicio.dtRegistro.Select("Codigo Is Not Null and Valor <> 0 and Servicios <> 0").Count > 0 Then
                    costo = (dgvRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Cells("Valor").Value / dgvRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Cells("Servicios").Value)
                    dgvRegistro.Rows(dgvRegistro.CurrentCell.RowIndex).Cells("Costo").Value = costo
                End If
            End If
        End If
    End Sub
    Private Function validarCampos() As Boolean
        If IsNothing(objCostoServicio.codigoServicio) Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor seleccionar un servicio")
        ElseIf objCostoServicio.dtRegistro.Rows.Count <= 1
            EstiloMensajes.mostrarMensajeAdvertencia("Favor agregar algun movimiento")
        Else
            Return True
        End If
        Return False
    End Function
End Class