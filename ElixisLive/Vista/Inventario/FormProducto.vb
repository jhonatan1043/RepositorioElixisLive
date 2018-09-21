Public Class FormProducto
    Dim objProducto As producto
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objProducto = New producto
        Try
            params.Add(ElementoMenu.codigo)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoGrillaParametro(dgvParametro)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvParametro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametro.CellClick
        If btRegistrar.Enabled = False Then Exit Sub
        Generales.consultarTipoControl(dgvParametro)
    End Sub
    Private Sub btExaminar_Click(sender As Object, e As EventArgs) Handles btExaminar.Click
        Dim openImag As New OpenFileDialog
        Generales.subirimagen(pictImagen, openImag)
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
        txtBuscar.ReadOnly = False
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click

    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If MsgBox(MensajeSistema.CANCELAR, 32 + 1, "Cancelar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
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
            txtBuscar.ReadOnly = False
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click

    End Sub
End Class
