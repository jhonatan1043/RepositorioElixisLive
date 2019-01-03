
Public Class FormPrincipal
    Dim formulario As New vForm

    Private Sub formPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        principalBLL.cargarMenu(arbolMenu)
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackgroundImage = My.Resources.Quality_logo
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next
        'formulario.ventana = Me '' se indica el formulario que usara el efecto
        'formulario.redondear() '' se redondean los bordes del formulario
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
