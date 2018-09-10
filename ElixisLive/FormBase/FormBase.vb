Public Class FormBase
    Private objConfig As Configuracion
    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objConfig = New Configuracion
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btNuevo.Enabled = True
        btSalir.Enabled = True
    End Sub
    Private Sub cargarRegistro()
        Dim params As New List(Of String)
        params.Add(txtBuscar.Text)
        Generales.llenardgv(objConfig.sqlConsulta, dgRegistro, params)
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If MsgBox(MensajeSistema.CANCELAR, 32 + 1, "Cancelar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            btNuevo.Enabled = True
            btSalir.Enabled = True
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If MsgBox(MensajeSistema.EDITAR, 32 + 1, "Editar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
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
        Generales.deshabilitarControles(Me)
        Generales.limpiarControles(Me)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub
    Private Sub btSalir_Click(sender As Object, e As EventArgs) Handles btSalir.Click
        If MsgBox(MensajeSistema.SALIR, 32 + 1, "Salir") = 1 Then
            If btRegistrar.Enabled = True Then
                Close()
            End If
        End If
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If MsgBox(MensajeSistema.REGISTRAR, 32 + 1, "Registrar") = 1 Then

        End If
    End Sub
    Private Sub cargarObjeto()
        objConfig.id = txtId.Text
        objConfig.descripcion = TxtDescripcion.Text
    End Sub
End Class