Public Class FormServicio
    Private objConfig As Configuracion
    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objConfig = New Configuracion
        cargarConsultas()
        cargarRegistro()
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        txtFiltro.ReadOnly = False
        btNuevo.Enabled = True
    End Sub
    Private Sub cargarRegistro()
        Dim params As New List(Of String)
        params.Add(txtFiltro.Text)
        params.Add(SesionActual.idEmpresa)
        Generales.llenardgv(objConfig.sqlConsulta, dgRegistro, params)
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            txtFiltro.ReadOnly = False
            btNuevo.Enabled = True
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            txtFiltro.ReadOnly = True
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            If Generales.ejecutarSQL(objConfig.sqlAnular) = True Then
                Generales.limpiarControles(Gbdatos)
                Generales.deshabilitarBotones(ToolStrip1)
                cargarRegistro()
                btNuevo.Enabled = True
                EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
            End If
        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Gbdatos)
        txtFiltro.ReadOnly = True
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub
    Private Function validaciones() As Boolean
        Dim badraResultado As Boolean
        If txtnombre.Text = String.Empty Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe Registrar un valor valido!")
        Else
            badraResultado = True
        End If
        Return badraResultado
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try

            If validaciones() = True Then
                cargarObjeto()
                ConfigBLL.guardar(objConfig)
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btNuevo.Enabled = True
                btAnular.Enabled = True
                txtFiltro.ReadOnly = False
                txtcodigo.Text = objConfig.codigo
                cargarRegistro()
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try

    End Sub
    Private Sub cargarObjeto()
        objConfig.codigo = If(String.IsNullOrEmpty(txtcodigo.Text), Nothing, txtcodigo.Text)
        objConfig.descripcion = txtnombre.Text.ToLower
    End Sub
    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarRegistro()
        End If
    End Sub
    Private Sub txtFiltro_TextChanged(sender As Object, e As KeyEventArgs) Handles txtFiltro.TextChanged
        If String.IsNullOrEmpty(txtFiltro.Text) Then
            cargarRegistro()
        End If
    End Sub
    Private Sub cargarConsultas()
        objConfig.sqlConsulta = "SP_CONFI_SERVICIO_CONSULTAR"
        objConfig.sqlAnular = ""
        objConfig.sqlGuardar = "SP_CONFI_SERVICIO_CREAR"
    End Sub
End Class
