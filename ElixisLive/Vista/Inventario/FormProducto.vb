Public Class FormProducto
    Dim objProducto As producto
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        Try
            params.Add(ElementoMenu.codigo)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            Generales.cargarPrametro(params, dgvParametro)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click

    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click

    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click

    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click

    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click

    End Sub
End Class
