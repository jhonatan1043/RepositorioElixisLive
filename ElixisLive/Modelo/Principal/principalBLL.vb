Imports System.IO
Imports System.Reflection
Public Class principalBLL
    Public Shared dsDatos As DataSet
    Public formulario As FormPrincipal
    Public Sub cargarMenu()
        Dim mnuOpcion As ToolStripMenuItem
        Dim drCuentaPadre As DataRow()
        Dim dtFilas As New DataTable
        Try
            dsDatos = New DataSet
            CreaOpciones(dsDatos)
            drCuentaPadre = dsDatos.Tables(0).Select("Codigo_Padre is null", "Codigo")
            For Each drFila As DataRow In drCuentaPadre
                mnuOpcion = New ToolStripMenuItem(drFila("Descripcion").ToString())
                mnuOpcion.Tag = New ElementoMenu(drFila("Codigo").ToString(),
                                                 drFila("Formulario").ToString,
                                                 Nothing,
                                                 drFila("Descripcion").ToString)
                ' añadir este menú desplegable a la barra de menú
                mnuOpcion.ForeColor = Color.White
                formulario.menuOpciones.Items.Add(mnuOpcion)
                ' recorrer si hubiera las opciones dependientes de este menú
                dtFilas = dsDatos.Tables(0)
                CrearSubopciones(mnuOpcion, dtFilas)
            Next

            formulario.Controls.Add(formulario.menuOpciones)
            FormPrincipal.menuOpciones.LayoutStyle = ToolStripLayoutStyle.Flow
            FormPrincipal.menuOpciones.AutoSize = True
            FormPrincipal.menuOpciones.BackColor = Color.SteelBlue


            FormPrincipal.menuOpciones.GripStyle = ToolStripGripStyle.Visible
            FormPrincipal.menuOpciones.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 10)
            formulario.menuOpciones.Renderer = New MyRenderer()

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub eliminarMenu()
        For t = 0 To formulario.menuOpciones.Items.Count - 1
            formulario.menuOpciones.Items.RemoveAt(0)
        Next
        Dim con As Control
        For controlIndex As Integer = FormPrincipal.Controls.Count - 1 To 0 Step -1
            con = FormPrincipal.Controls(controlIndex)
            If con.Name = "menuOpciones" Then
                FormPrincipal.Controls.Remove(con)
            End If
        Next
        Dim con1 As Control
        For controlIndex As Integer = FormPrincipal.Controls.Count - 1 To 0 Step -1
            con1 = FormPrincipal.Controls(controlIndex)
            If con1.Name = "mnuOpcion" Then
                FormPrincipal.Controls.Remove(con1)
            End If
        Next
    End Sub
    Private Sub CrearSubopciones(ByVal mnuOpcion As ToolStripMenuItem, dtFilas As DataTable)
        Dim mnuSubOpcion As ToolStripMenuItem
        Dim drFilas = dtFilas.Select("Codigo_Padre =" & "'" & mnuOpcion.Tag.codigo & "'", "Codigo")

        For Each drFila As DataRow In drFilas
            mnuSubOpcion = New ToolStripMenuItem(drFila("Descripcion").ToString)
            mnuSubOpcion.Tag = New ElementoMenu(drFila("Codigo").ToString(),
                                                drFila("Formulario").ToString,
                                                (mnuOpcion.Tag.codigo.ToString.Substring(0, 2)),
                                                (mnuOpcion.Tag.nombrePadre.ToString))

            mnuSubOpcion.ForeColor = Color.White

            agregarMenuItem(drFila("Formulario").ToString, mnuSubOpcion)
            mnuOpcion.DropDownItems.Add(mnuSubOpcion)
            CrearSubopciones(mnuSubOpcion, dtFilas)
        Next

    End Sub
    Private Shared Sub CreaOpciones(ByRef dsDatos As DataSet)
        Dim dtmenu As New DataTable("menu")
        Dim params As New List(Of String)
        Try
            params.Add(SesionActual.codigoSucursal)
            params.Add(SesionActual.idUsuario)
            Generales.llenarTabla("[SP_ADMIN_MENU_SUCURSAL]", params, dtmenu)
            dsDatos.Tables.Add(dtmenu)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Sub cargarFormulario(sender As Object, e As EventArgs)
        Try
            Dim menuItem = DirectCast(sender, ToolStripMenuItem)
            Dim elemMenu As ElementoMenu = menuItem.Tag

            If estaAbierto(elemMenu) = True Then
                traerAlFrente(elemMenu)
            Else
                Dim nombreTipo = Constantes.NOMBRE_SOFTWARE & elemMenu.nombre
                Dim vTipo As Type = Assembly.GetExecutingAssembly.GetType(nombreTipo)

                If vTipo IsNot Nothing Then
                    Dim vFormulario = Activator.CreateInstance(vTipo)
                    vFormulario.tag = elemMenu
                    Generales.cargarForm(vFormulario)
                End If
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Public Shared Sub traerAlFrente(ByVal elemento As ElementoMenu)
        Dim objForm As System.Windows.Forms.Form
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(elemento.nombre) AndAlso objForm.Tag.Modulo = elemento.modulo AndAlso objForm.Tag.codigo = elemento.codigo) Then
                objForm.Focus()
                If objForm.WindowState = FormWindowState.Minimized Then
                    objForm.WindowState = FormWindowState.Normal
                End If
                Exit For
            End If
        Next
    End Sub
    Public Shared Function estaAbierto(ByVal elemento As ElementoMenu)
        Dim objForm As System.Windows.Forms.Form
        For Each objForm In My.Application.OpenForms
            Dim objName = Trim(objForm.Name)
            If (objName = Trim(elemento.nombre) AndAlso
                objForm.Tag.modulo = elemento.modulo AndAlso
                objForm.Tag.codigo = elemento.codigo) Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Sub agregarMenuItem(ByVal form As String, ByVal mnuSubOpcion As ToolStripMenuItem)

        AddHandler mnuSubOpcion.Click, AddressOf cargarFormulario

        If form.Trim <> String.Empty Then
            AddHandler mnuSubOpcion.Click, AddressOf click_Global
        End If

    End Sub
    Sub click_Global(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not IsNothing(formulario.ActiveMdiChild) AndAlso formulario.ActiveMdiChild.WindowState = FormWindowState.Maximized Then
            formulario.ActiveMdiChild.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
