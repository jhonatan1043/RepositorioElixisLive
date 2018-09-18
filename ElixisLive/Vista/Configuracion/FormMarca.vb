Public Class FormMarca
    Private objConfig As Configuracion
    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objConfig = New Configuracion
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        txtFiltro.ReadOnly = False
        btNuevo.Enabled = True
    End Sub
    Private Sub cargarRegistro()
        Dim params As New List(Of String)
        params.Add(txtFiltro.Text)
        Generales.llenardgv(objConfig.sqlConsulta, dgRegistro, params)
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If MsgBox(MensajeSistema.CANCELAR, 32 + 1, "Cancelar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            txtFiltro.ReadOnly = False
            btNuevo.Enabled = True
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If MsgBox(MensajeSistema.EDITAR, 32 + 1, "Editar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            txtFiltro.ReadOnly = True
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If MsgBox(MensajeSistema.ANULAR, 32 + 1, "Anular") = 1 Then

        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        txtFiltro.ReadOnly = True
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If MsgBox(MensajeSistema.REGISTRAR, 32 + 1, "Registrar") = 1 Then

        End If
    End Sub
    Private Sub cargarObjeto()
        objConfig.id = txtcodigo.Text
        objConfig.descripcion = txtnombre.Text
    End Sub
End Class
