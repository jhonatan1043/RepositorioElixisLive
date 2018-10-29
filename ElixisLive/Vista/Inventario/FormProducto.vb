Public Class FormProducto
    Dim objProducto As producto
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objProducto = New producto
        Try
            params.Add(ElementoMenu.codigo)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgRegistro, params)
            Generales.diseñoDGV(dgRegistro)
            Generales.diseñoGrillaParametros(dgRegistro)
            params.Clear()
            params.Add(SesionActual.codigoSucursal)
            Generales.cargarCombo("[SP_CONSULTAR_MARCA]", params, "Nombre", "Codigo_Marca", cbMarca)
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
                txtnombre.Text = dfila("Nombre")
                params.Add(ElementoMenu.codigo)
                Generales.llenardgv(objProducto.sqlCargarDetalle, dgRegistro, params)
                Generales.diseñoDGV(dgRegistro)
                controlVerificarControl()
            End If
            Generales.habilitarBotones(ToolStrip1)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(SesionActual.codigoSucursal)
        Generales.buscarElemento(objProducto.sqlConsulta,
                                   params,
                                   AddressOf cargarInfomacion,
                                   "Busqueda de producto",
                                   True, True)
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Gbdatos)
        Generales.limpiarGrillaParametro(dgRegistro)
        objProducto.codigo = Nothing
        dgRegistro.ReadOnly = False
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(txtnombre.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe ingresar el nombre del producto!")
        ElseIf cbMarca.SelectedIndex = 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe seleccionar la marca!")
        Else
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub cargarObjeto()
        objProducto.codigoMarca = cbMarca.SelectedValue.ToString
        objProducto.nombre = txtnombre.Text
        objProducto.dtParametro = dgRegistro.DataSource
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarCampos() = True Then
            cargarObjeto()
            Try
                ProductoBLL.guardar(objProducto)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                txtcodigo.Text = objProducto.codigo
                btRegistrar.Enabled = False
                btCancelar.Enabled = False
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
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            dgRegistro.ReadOnly = False
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objProducto.sqlAnular & txtcodigo.Text) = True Then
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
End Class
