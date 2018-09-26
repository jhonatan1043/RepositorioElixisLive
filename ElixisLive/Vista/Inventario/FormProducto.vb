Public Class FormProducto
    Dim objProducto As producto
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objProducto = New producto
        Try
            params.Add(ElementoMenu.codigo)
            params.Add(SesionActual.idEmpresa)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoGrillaParametro(dgvParametro)
            cargarRegistro()
            TxtDescripcion.DropDownStyle = ComboBoxStyle.Simple
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objProducto.codigoProducto = pcodigo
        params.Add(objProducto.codigoProducto)
        dfila = Generales.cargarItem(objProducto.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                txtCodigo.Text = objProducto.codigoProducto
                TxtDescripcion.Text = dfila.Item("Nombre")
                cargarImagen(If(IsDBNull(dfila.Item("Foto")), Nothing, dfila.Item("Foto")))
                Generales.llenardgv(objProducto.sqlCargarDetalle, dgvParametro, params)
                Generales.diseñoGrillaParametro(dgvParametro)
                controlVeificar()
            End If
            Generales.deshabilitarBotones(ToolStrip1)
            btEditar.Enabled = True
            btCancelar.Enabled = True
            btNuevo.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
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
    Private Sub cargarRegistro()
        Dim params As New List(Of String)
        params.Add(txtBuscar.Text)
        params.Add(SesionActual.idEmpresa)
        Try
            Generales.llenardgv(objProducto.sqlConsulta, dgRegistro, params)
            objProducto.dtRegistro = dgRegistro.DataSource
        Catch ex As Exception
            MsgBox(ex.Message)
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
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgRegistro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRegistro.CellClick
        If objProducto.dtRegistro.Rows.Count > 0 Then
            cargarInfomacion(objProducto.dtRegistro.Rows(dgRegistro.CurrentCell.RowIndex).Item("Codigo"))
        End If
    End Sub
    Private Sub cargarObjeto()
        Dim almMemoria As System.IO.MemoryStream = Nothing
        If Not IsNothing(pictImagen.Image) Then
            almMemoria = New System.IO.MemoryStream
            pictImagen.Image.Save(almMemoria, Imaging.ImageFormat.Png)
        End If
        objProducto.codigoProducto = If(String.IsNullOrEmpty(txtCodigo.Text), Nothing, txtCodigo.Text)
        objProducto.nombre = TxtDescripcion.Text
        objProducto.foto = If(IsNothing(almMemoria), Nothing, almMemoria.GetBuffer())
        objProducto.dtParametro = dgvParametro.DataSource
    End Sub
    Private Sub btExaminar_Click(sender As Object, e As EventArgs) Handles btExaminar.Click
        Dim openImag As New OpenFileDialog
        Generales.subirimagen(pictImagen, openImag)
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(GbInform_D)
        Generales.limpiarControles(gbInform)
        pictImagen.Image = Nothing
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
        txtBuscar.ReadOnly = True
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(TxtDescripcion.Text) Then
            MsgBox("¡ Favor digitar el nombre del registro !", MsgBoxStyle.Exclamation)
        Else
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvParametro.EndEdit()
        If validarCampos() = True Then
            cargarObjeto()
            ProductoBLL.guardar(objProducto)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtCodigo.Text = objProducto.codigoProducto
            cargarRegistro()
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            btEditar.Enabled = True
            Generales.mostrarMensaje(MensajeSistema.REGISTRO_GUARDADO, My.Resources.Save_icon__1_)
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If MsgBox(MensajeSistema.CANCELAR, 32 + 1, "Cancelar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(GbInform_D)
            Generales.limpiarControles(gbInform)
            pictImagen.Image = Nothing
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If MsgBox(MensajeSistema.EDITAR, 32 + 1, "Editar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            txtBuscar.ReadOnly = True
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
            txtBuscar.ReadOnly = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If MsgBox(MensajeSistema.ANULAR, 32 + 1, "Anular") = 1 Then
            If Generales.ejecutarSQL(objProducto.sqlAnular) = True Then
                Generales.limpiarControles(GbInform_D)
                Generales.limpiarControles(gbInform)
                Generales.deshabilitarBotones(ToolStrip1)
                pictImagen.Image = Nothing
                cargarRegistro()
                btNuevo.Enabled = True
                Generales.mostrarMensaje(MensajeSistema.REGISTRO_ANULADO, My.Resources.document_delete_icon__1_)
            End If
        End If
    End Sub

End Class
