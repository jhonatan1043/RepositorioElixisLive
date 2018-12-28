Public Class FormConfigVenta
    Dim objConfigVenta As ConfigVenta
    Private Sub FormConfigVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objConfigVenta = New ConfigVenta
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        Generales.cargarCombo("[SP_INVEN_PRODUCTO_LISTA]", Nothing, "Nombre", "codigo", cbListaProducto)
        Generales.cargarCombo("[SP_INVEN_SERVICIO_LISTA]", Nothing, "Nombre", "codigo", cbListaServicio)
        cargarConfVenta()
        btEditar.Enabled = True
    End Sub
    Private Sub cargarConfVenta()
        Dim dFila As DataRow
        Dim params As New List(Of String)
        params.Add(SesionActual.codigoEmpresa)
        Try
            dFila = Generales.cargarItem(objConfigVenta.sqlCargar, params)
            If Not IsNothing(dFila) Then
                cbListaProducto.SelectedValue = dFila("codigo_lista_producto")
                cbListaServicio.SelectedValue = dFila("codigo_lista_servicio")
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
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

            objConfigVenta.codigoListaProducto = cbListaProducto.SelectedValue
            objConfigVenta.codigoListaServicio = cbListaServicio.SelectedValue

            ConfigVentaBLL.guardarConfVenta(objConfigVenta)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)

            btEditar.Enabled = True
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
End Class