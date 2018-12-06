Public Class FormListaPrecio
    Dim objListaPrecio As ListaPrecio
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FormListaPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objListaPrecio = New ListaPrecio
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        ListaPrecioBLL.cargarComboTipoLista(cbTipoLista)
        btNuevo.Enabled = True
        btBuscar.Enabled = True
    End Sub
    Private Sub validarGrilla()
        With dgvLista
            .DataSource = objListaPrecio.dtPrecio
            .Columns("Codigo").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Precio").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells

            .Columns("Codigo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Descripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Precio").SortMode = DataGridViewColumnSortMode.NotSortable

            .AutoGenerateColumns = False
        End With
    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgvLista
            .Columns("Codigo").ReadOnly = True
            .Columns("Descripcion").ReadOnly = True
            .Columns("Precio").ReadOnly = True
        End With
        If Estado = True Then
            With dgvLista
                .Columns("Precio").ReadOnly = False
            End With
        End If
    End Sub
    Private Sub cargarListaPrecio(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dFila As DataRow
        params.Add(pCodigo)
        objListaPrecio.codigo = pCodigo
        Try
            dFila = Generales.cargarItem(objListaPrecio.sqlCargar, params)
            txtNombre.Text = dFila("Nombre")
            cbTipoLista.SelectedValue = dFila("Tipo_Lista")
            Generales.llenarTabla(objListaPrecio.sqlCargarDetalle, params, objListaPrecio.dtPrecio)
            dgvLista.DataSource = objListaPrecio.dtPrecio
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtBuscar.ReadOnly = False
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
            btDuplicar.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        validarEdicionGrilla(Constantes.EDITABLE)
        objListaPrecio.codigo = Nothing
        btDuplicar.Enabled = False
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento(objListaPrecio.sqlConsulta,
                                   params,
                                   AddressOf cargarListaPrecio,
                                   Titulo.BUSQUEDA_LISTA_PRECIO,
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarObjeto()
        objListaPrecio.nombre = txtNombre.Text
        objListaPrecio.codigoTipoLista = cbTipoLista.SelectedValue
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarCampos() = True Then
            Try
                dgvLista.EndEdit()
                cargarObjeto()
                ListaPrecioBLL.guardarListaPrecio(objListaPrecio)
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btNuevo.Enabled = True
                btBuscar.Enabled = True
                btAnular.Enabled = True
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        Else
            EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.VALIDAR_CAMPOS)
        End If
        mostrarIconoError()
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            validarEdicionGrilla(Constantes.EDITABLE)
            cargarItems("[SP_INVEN_PRECIO_CONSULTAR_EDITAR]", Constantes.EDITABLE)
            cbTipoLista.Enabled = False
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.limpiarControles(Me)
            Generales.deshabilitarControles(Me)
            objListaPrecio.codigo = Nothing
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objListaPrecio.sqlAnular & objListaPrecio.codigo) = True Then
                    Generales.deshabilitarBotones(ToolStrip1)
                    Generales.limpiarControles(Me)
                    objListaPrecio.codigo = Nothing
                    btNuevo.Enabled = True
                    btBuscar.Enabled = True
                    EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub dgvLista_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvLista.CellFormatting
        If objListaPrecio.dtPrecio.Rows.Count > 0 Then
            If e.ColumnIndex = 2 Then
                e.Value = If(Not IsDBNull(e.Value), Format(Val(e.Value), Constantes.FORMATO_MONEDA), 0)
            End If
        End If
    End Sub
    Private Sub cbTipoLista_TextChanged(sender As Object, e As EventArgs) Handles cbTipoLista.TextChanged
        If btRegistrar.Enabled = False Then Exit Sub
        Select Case cbTipoLista.SelectedValue
            Case 0 ' producto
                cargarItems(Sentencias.PRODUCTO_CONSULTAR)
            Case 1 ' servicio
                cargarItems(Sentencias.SERVICIO_CONSULTAR)
            Case Else
                objListaPrecio.dtPrecio.Clear()
        End Select
    End Sub
    Private Sub cargarItems(consulta As String, Optional nuevo As Integer = 0)
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(String.Empty)
        Try
            If nuevo = 0 Then
                Generales.llenarTabla(consulta, params, objListaPrecio.dtPrecio)
            Else
                params.Clear()
                params.Add(cbTipoLista.SelectedValue)
                params.Add(objListaPrecio.codigo)
                Generales.llenarTabla(consulta, params, objListaPrecio.dtPrecio)
            End If
            dgvLista.DataSource = objListaPrecio.dtPrecio
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btDuplicar_Click(sender As Object, e As EventArgs) Handles btDuplicar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.DUPLICAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            validarEdicionGrilla(Constantes.EDITABLE)
            objListaPrecio.codigo = Nothing
            txtNombre.Clear()
            cbTipoLista.Enabled = False
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Function validarCampos() As Boolean
        If String.IsNullOrEmpty(txtNombre.Text) Or
                    cbTipoLista.SelectedIndex = 0 Then
        Else
            Return True
        End If
        Return False
    End Function
    Private Sub mostrarIconoError()
        If String.IsNullOrEmpty(txtNombre.Text) Then
            errorIcono.SetError(txtNombre, "¡ Debe digitar el nombre de la lista !")
        Else
            errorIcono.SetError(txtNombre, String.Empty)
        End If
        If cbTipoLista.SelectedIndex = 0 Then
            errorIcono.SetError(cbTipoLista, "¡ Debe seleccionar el tipo de lista !")
        Else
            errorIcono.SetError(cbTipoLista, String.Empty)
        End If
    End Sub
End Class
