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
        txtcodigo.Text = pCodigo
        txtnombre.Text = dRows("Descripcion")
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Gbdatos)
        Generales.limpiarControles(Me)
        validarEdicionGrilla(Constantes.EDITABLE)
        objCostoServicio.dtRegistro.Rows.Add()
        objCostoServicio.codigo = Nothing
        btBuscarServicio.Enabled = True
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try
            CostoServicioBLL.guardarCostoServicio(objCostoServicio)
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        Catch ex As Exception

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
            objCostoServicio.codigo = Nothing
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
                .Columns("Servicios").ReadOnly = False
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
            If e.ColumnIndex = 3 _
                OrElse e.ColumnIndex = 7 Then
                e.Value = If(Not IsDBNull(e.Value), Format(Val(e.Value), Constantes.FORMATO_MONEDA), 0)
            End If
        End If
    End Sub
End Class