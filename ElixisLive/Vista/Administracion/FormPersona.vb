Public Class FormPersona
    Dim objPersona As persona
    Private Sub cargarRegistro()
        Dim params As New List(Of String)
        params.Add(txtBuscar.Text)
        params.Add(SesionActual.idEmpresa)
        Try
            Generales.llenardgv(objPersona.sqlConsulta, dgRegistro, params)
            objPersona.dtRegistro = dgRegistro.DataSource
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarObjeto()
        objPersona.identificacion = txtCodigo.Text
        objPersona.nombre = TxtDescripcion.Text
        objPersona.dtParametro = dgvParametro.DataSource
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(txtCodigo.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("Debe ingresar el número de identificación de la persona")
        ElseIf String.IsNullOrEmpty(TxtDescripcion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("Debe ingresar el nombre de la persona")
        Else
            resultado = True
        End If
        Return resultado
    End Function
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

    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objPersona = New persona
        Try
            params.Add(ElementoMenu.codigo)
            params.Add(SesionActual.idEmpresa)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoGrillaParametro(dgvParametro)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs)
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(GbInform_D)
        Generales.limpiarControles(gbInform)
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
        txtBuscar.ReadOnly = True
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs)
        dgvParametro.EndEdit()
        If validarCampos() = True Then
            cargarObjeto()
            'EmpresaBLL.guardar(objEmpresa)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            cargarRegistro()
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            btEditar.Enabled = True
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        End If

    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs)
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            txtBuscar.ReadOnly = True
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
            txtBuscar.ReadOnly = True
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs)
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(GbInform_D)
            Generales.limpiarControles(gbInform)
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
        End If
    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs)
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            If Generales.ejecutarSQL(objPersona.sqlAnular) = True Then
                Generales.limpiarControles(GbInform_D)
                Generales.limpiarControles(gbInform)
                Generales.deshabilitarBotones(ToolStrip1)
                cargarRegistro()
                btNuevo.Enabled = True
                EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
            End If
        End If
    End Sub

End Class