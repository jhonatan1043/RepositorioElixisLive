
Public Class FormPrincipal
    Dim formulario As New vForm
    Dim banderaAncla As Boolean
    Dim ctlMDI As MdiClient
    Private Sub formPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        principalBLL.cargarMenu(arbolMenu)
        Dim ctl As Control
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
    'Private Sub pitImagen_Click(sender As Object, e As EventArgs) Handles pitImagen.Click
    '    If banderaAncla = False Then
    '        desAnclar()
    '    Else
    '        anclar()
    '    End If
    'End Sub
    'Private Sub anclar()
    '    ' pitImagen.Location = New Point(213, 3)
    '    arbolMenu.Size = New Point(239, 733)
    '    pitImagen.Image = My.Resources.Anclar
    '    ctlMDI.BackgroundImage = My.Resources.Quality_logo
    '    pitImagen.Visible = True
    '    banderaAncla = False
    'End Sub
    'Private Sub desAnclar()
    '    'pitImagen.Location = New Point(10, 3)
    '    arbolMenu.Size = New Point(5, 733)
    '    pitImagen.Image = My.Resources.DesAnclar
    '    ctlMDI.BackgroundImage = My.Resources.Quality_logo
    '    pitImagen.Visible = False
    '    banderaAncla = True
    '    arbolMenu.Update()
    'End Sub
    'Private Sub arbolMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles arbolMenu.MouseMove
    '    If banderaAncla = True Then
    '        arbolMenu.Size = New Point(239, 733)
    '        ctlMDI.BackgroundImage = Nothing
    '        ctlMDI.BackgroundImage = My.Resources.Quality_logo
    '        pitImagen.Visible = True
    '        arbolMenu.Update()
    '        pitImagen.Update()
    '    End If
    'End Sub
    'Private Sub arbolMenu_MouseLeave(sender As Object, e As EventArgs) Handles arbolMenu.MouseLeave
    '    If banderaAncla = True Then
    '        arbolMenu.Size = New Point(5, 733)
    '        ctlMDI.BackgroundImage = My.Resources.Quality_logo
    '        pitImagen.Visible = False
    '        arbolMenu.Update()
    '    End If
    'End Sub
End Class
