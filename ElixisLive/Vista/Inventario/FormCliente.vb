Public Class FormCliente
    Dim objCliente As Cliente
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objCliente = New Cliente
        Try
            params.Add(ElementoMenu.codigo)
            params.Add(SesionActual.idEmpresa)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoGrillaParametro(dgvParametro)
            params.Clear()
            params.Add(SesionActual.idEmpresa)
            Generales.cargarCombo("[SP_CONSULTAR_PERSONA]", params, "Nombre", "Codigo_persona", TxtDescripcion)
            cargarRegistro()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objCliente.codigoProducto = pcodigo
        params.Add(objCliente.codigoProducto)
        dfila = Generales.cargarItem(objCliente.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                txtCodigo.Text = objCliente.codigoProducto
                TxtDescripcion.Text = dfila.Item("Nombre")
                cargarImagen(If(IsDBNull(dfila.Item("Foto")), Nothing, dfila.Item("Foto")))
                Generales.llenardgv(objCliente.sqlCargarDetalle, dgvParametro, params)
                Generales.diseñoGrillaParametro(dgvParametro)
                controlVeificar()
            End If
            Generales.deshabilitarBotones(ToolStrip1)
            btEditar.Enabled = True
            btCancelar.Enabled = True
            btNuevo.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub controlVeificar()
        For posicion = 0 To dgvParametro.Rows.Count - 1
            Generales.consultarTipoControl(dgvParametro, posicion)
        Next
    End Sub
    Private Sub cargarImagen(bites As Byte())
        If IsNothing(bites) = True Then
            pictImagen.Image = Nothing
        Else
            If (bites IsNot DBNull.Value AndAlso bites.Length > 0) Then
                Dim ms As New System.IO.MemoryStream(DirectCast(bites, Byte()))
                pictImagen.Image = Image.FromStream(ms)
                ms.Dispose()
                bites = Nothing
            End If
        End If
    End Sub
    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add("")

        Generales.buscarElemento(Sentencias.BUSCAR_CLIENTES,
                                   params,
                                   AddressOf cargarDatosCliente,
                                   "Busqueda de Clientes",
                                   False, True)
    End Sub
    Private Sub cargarDatosCliente(pCodigoCliente As String)
        Dim dtCliente As New DataTable
        Dim params As New List(Of String)
        params.Add(pCodigoCliente)
        Generales.llenarTabla(Sentencias.CARGAR_CLIENTES, params, dtCliente)
        If dtCliente.Rows.Count > 0 Then

        End If
    End Sub
    Private Sub cargarRegistro()
        Dim params As New List(Of String)
        params.Add(txtBuscar.Text)
        params.Add(SesionActual.idEmpresa)
        Try
            Generales.llenardgv(objCliente.sqlConsulta, dgRegistro, params)
            objCliente.dtRegistro = dgRegistro.DataSource
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarRegistro()
        End If
    End Sub
    Private Sub dgvParametro_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametro.CellEnter
        If btRegistrar.Enabled = False Then Exit Sub
        Try
            Generales.consultarTipoControl(dgvParametro, dgvParametro.CurrentCell.RowIndex)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub dgRegistro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRegistro.CellClick
        If objCliente.dtRegistro.Rows.Count > 0 Then
            cargarInfomacion(objCliente.dtRegistro.Rows(dgRegistro.CurrentCell.RowIndex).Item("Codigo"))
        End If
    End Sub
    Private Sub cargarObjeto()
        Dim almMemoria As System.IO.MemoryStream = Nothing
        If Not IsNothing(pictImagen.Image) Then
            almMemoria = New System.IO.MemoryStream
            pictImagen.Image.Save(almMemoria, Imaging.ImageFormat.Png)
        End If
        objCliente.codigoProducto = If(String.IsNullOrEmpty(txtCodigo.Text), Nothing, txtCodigo.Text)
        objCliente.nombre = TxtDescripcion.Text
        objCliente.foto = If(IsNothing(almMemoria), Nothing, almMemoria.GetBuffer())
        objCliente.dtParametro = dgvParametro.DataSource
    End Sub
    Private Sub btExaminar_Click(sender As Object, e As EventArgs) Handles btExaminar.Click
        Dim openImag As New OpenFileDialog
        Generales.subirimagen(pictImagen, openImag)
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(gbInformD)
        Generales.limpiarControles(gbInform)
        pictImagen.Image = Nothing
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
        txtBuscar.ReadOnly = True
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(TxtDescripcion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("")
        Else
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvParametro.EndEdit()
        If validarCampos() = True Then
            cargarObjeto()
            ClienteBLL.guardar(objCliente)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtCodigo.Text = objCliente.codigoProducto
            cargarRegistro()
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            btEditar.Enabled = True
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(gbInformD)
            Generales.limpiarControles(gbInform)
            pictImagen.Image = Nothing
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            txtBuscar.ReadOnly = True
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
            txtBuscar.ReadOnly = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            If Generales.ejecutarSQL(objCliente.sqlAnular) = True Then
                Generales.limpiarControles(gbInformD)
                Generales.limpiarControles(gbInform)
                Generales.deshabilitarBotones(ToolStrip1)
                pictImagen.Image = Nothing
                cargarRegistro()
                btNuevo.Enabled = True
                EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
            End If
        End If
    End Sub
End Class
