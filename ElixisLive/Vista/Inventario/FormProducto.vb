Public Class FormProducto
    Dim objProducto As producto
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim params As New List(Of String)
        objProducto = New producto
        Try
            params.Add(ElementoMenu.codigo)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            Generales.llenardgv(Sentencias.PARAMETROS_CONSULTAR, dgRegistro, params)
            Generales.diseñoDGV(dgRegistro)
            Generales.diseñoGrillaParametros(dgRegistro)
            Generales.cargarCombo(Sentencias.MARCA_CONSULTAR, Nothing, "Nombre", "Codigo_Marca", cbMarca)
            Generales.cargarCombo("[SP_CONSULTAR_CATEGORIA]", Nothing, "Nombre", "Codigo_Categoria", cbCategoria)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Generales.tabularConEnter(Me)
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub dgvParametro_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgRegistro.CellEnter
        If btRegistrar.Enabled = False Then Exit Sub
        Try
            Generales.consultarTipoControl(dgRegistro, dgRegistro.CurrentCell.RowIndex)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objProducto.codigo = pcodigo
        params.Add(objProducto.codigo)
        dfila = Generales.cargarItem(objProducto.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                cbMarca.SelectedValue = dfila("Codigo_Marca")
                cbCategoria.SelectedValue = dfila("Codigo_Categoria")
                txtnombre.Text = dfila("Nombre")
                txtCodigoBarra.Text = Generales.Ceros(objProducto.codigo, 5)
                params.Add(ElementoMenu.codigo)
                Generales.llenardgv(objProducto.sqlCargarDetalle, dgRegistro, params)
                Generales.diseñoDGV(dgRegistro)
                controlVerificarControl()
            End If
            Generales.habilitarBotones(ToolStrip1)
            btGenerar.Enabled = True
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btGenerar_Click(sender As Object, e As EventArgs) Handles btGenerar.Click
        Dim ruta As String
        Dim nombre As String
        Dim ptImagen As New PictureBox
        Try
            nombre = "\" & txtCodigoBarra.Text & "_" & txtnombre.Text & ".jpg"
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\CodigoBarra"
            If IO.Directory.Exists(ruta) = False Then
                IO.Directory.CreateDirectory(ruta)
            End If
            ruta = ruta & nombre
            ptImagen.Image = CodigosBarra.codigo128("A" & txtCodigoBarra.Text & "B", True, Constantes.ALTO_BARRA)
            ptImagen.SizeMode = PictureBoxSizeMode.AutoSize
            ptImagen.Image.Save(ruta, Imaging.ImageFormat.Jpeg)
            Process.Start(ruta)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Generales.buscarElemento(objProducto.sqlConsulta,
                                   params,
                                   AddressOf cargarInfomacion,
                                   Titulo.BUSQUEDA_PRODUCTO,
                                   True, True)
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Gbdatos)
        Generales.limpiarGrillaParametro(dgRegistro)
        objProducto.codigo = Nothing
        txtCodigoBarra.ReadOnly = True
        btGenerar.Enabled = False
        dgRegistro.ReadOnly = False
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub
    Private Function validarCampos() As Boolean
        If String.IsNullOrEmpty(txtnombre.Text) Then
        ElseIf cbMarca.SelectedIndex = 0 Then
        ElseIf cbCategoria.SelectedIndex = 0 Then
        Else
            Return True
        End If
        Return False
    End Function
    Private Sub cargarObjeto()
        objProducto.codigoMarca = cbMarca.SelectedValue.ToString
        objProducto.codigoCategoria = cbCategoria.SelectedValue.ToString
        objProducto.nombre = txtnombre.Text
        objProducto.dtParametro = dgRegistro.DataSource
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgRegistro.EndEdit()

        If validarCampos() = True Then
            cargarObjeto()
            Try
                ProductoBLL.guardar(objProducto)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                txtcodigo.Text = objProducto.codigo
                btRegistrar.Enabled = False
                btCancelar.Enabled = False
                btGenerar.Enabled = True
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        Else
            EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.VALIDAR_CAMPOS)
        End If
        mostrarIconoError()
    End Sub
    Private Sub quitarIconoError()
        ErrorIcono.SetError(txtnombre, "")
        ErrorIcono.SetError(cbMarca, "")
        ErrorIcono.SetError(cbCategoria, "")
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            objProducto.codigo = Nothing
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            quitarIconoError()
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            txtCodigoBarra.ReadOnly = True
            dgRegistro.ReadOnly = False
            btGenerar.Enabled = False
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objProducto.sqlAnular & objProducto.codigo) = True Then
                    Generales.deshabilitarBotones(ToolStrip1)
                    Generales.limpiarControles(Gbdatos)
                    btNuevo.Enabled = True
                    btBuscar.Enabled = True
                    EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub controlVerificarControl()
        For posicion = 0 To dgRegistro.Rows.Count - 1
            Generales.consultarTipoControl(dgRegistro, posicion)
        Next
    End Sub
    Private Sub txtnombre_LostFocus(sender As Object, e As EventArgs) Handles txtnombre.LostFocus
        If txtnombre.TextLength = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(txtnombre, "Debe digitar un nombre")
        Else
            ErrorIcono.SetError(txtnombre, "")
        End If
    End Sub
    Private Sub cbMarca_LostFocus(sender As Object, e As EventArgs) Handles cbMarca.LostFocus
        If cbMarca.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(cbMarca, "Debe escoger una marca")
        Else
            ErrorIcono.SetError(cbMarca, "")
        End If
    End Sub
    Private Sub cbCategoria_LostFocus(sender As Object, e As EventArgs) Handles cbCategoria.LostFocus
        If cbMarca.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(cbCategoria, "Debe escoger una categoria")
        Else
            ErrorIcono.SetError(cbCategoria, "")
        End If
    End Sub
    Private Sub mostrarIconoError()
        If cbMarca.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(cbMarca, "Debe escoger una marca")
        Else
            ErrorIcono.SetError(cbMarca, "")
        End If
        If txtnombre.TextLength = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(txtnombre, "Debe digitar un nombre")
        Else
            ErrorIcono.SetError(txtnombre, "")
        End If
        If cbCategoria.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(cbCategoria, "Debe escoger una categoria")
        Else
            ErrorIcono.SetError(cbCategoria, "")
        End If
    End Sub
End Class
