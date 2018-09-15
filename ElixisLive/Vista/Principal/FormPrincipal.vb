Public Class FormPrincipal
    Private Sub formPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        principalBLL.cargarMenu(arbolMenu)
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)
                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackgroundImage = My.Resources.esta
            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next
    End Sub

    Private Sub arbolMenu_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles arbolMenu.NodeMouseClick
        Dim ramaActiva As String
        ramaActiva = e.Node.Tag
        If ramaActiva <> String.Empty Then
            principalBLL.cargarFormulario(cargarFormulario(e))
        End If
    End Sub
    Private Function cargarFormulario(e As TreeNodeMouseClickEventArgs) As ElementoMenu
        Dim elemento As New ElementoMenu
        elemento.codigo = e.Node.Name
        elemento.nombre = e.Node.Tag
        Return elemento
    End Function


End Class
