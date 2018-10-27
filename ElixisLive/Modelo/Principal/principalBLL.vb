Imports System.IO
Imports System.Reflection
Public Class principalBLL
    Private Shared dsDatos As DataSet
    Public Shared Sub cargarMenu(arbolMenu As TreeView)
        Dim nodo As TreeNode
        Dim drCuentaPadre As DataRow()
        Try
            dsDatos = New DataSet
            CreaOpciones(dsDatos)
            cargarMenu(dsDatos)
            drCuentaPadre = dsDatos.Tables("padre").Select()
            For Each drFila As DataRow In drCuentaPadre
                nodo = New TreeNode
                nodo.Name = drFila("Codigo").ToString()
                nodo.Text = drFila("Descripcion").ToString()
                nodo.Tag = drFila("codigo_Padre").ToString()
                arbolMenu.Nodes.Add(nodo)
                crearSubcuentas(nodo)
            Next
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Shared Sub crearSubcuentas(ByRef nodoPade As TreeNode)
        Dim expr As String = "[Codigo_Padre] ='" & nodoPade.Name & "'"
        Dim subnodo As TreeNode

        Try
            Dim aDrFilas As DataRow()
            aDrFilas = dsDatos.Tables("Hijo").Select(expr, "Codigo")

            For Each drFila As DataRow In aDrFilas
                subnodo = New TreeNode
                subnodo.Name = drFila("Codigo").ToString()
                subnodo.Text = drFila("Descripcion").ToString()
                subnodo.Tag = drFila("Formulario").ToString()
                nodoPade.Nodes.Add(subnodo)
                crearSubcuentas(subnodo)
            Next
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try

    End Sub
    Private Shared Sub CreaOpciones(ByRef dsDatos As DataSet)
        Dim dtmenu As New DataTable("menu")
        Dim params As New List(Of String)
        Try
            params.Add(SesionActual.idUsuario)
            Generales.llenarTabla("SP_ADMIN_MENU", params, dtmenu)
            dsDatos.Tables.Add(dtmenu)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Shared Sub cargarMenuPadre(ByRef dsDatos As DataSet)
        Dim dtmenu As New DataTable("padre")
        Dim params As New List(Of String)
        Try
            params.Add(SesionActual.idUsuario)
            Generales.llenarTabla("SP_ADMIN_MENU_PADRE", params, dtmenu)
            dsDatos.Tables.Add(dtmenu)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Shared Sub cargarMenuHijas(ByRef dsDatos As DataSet)
        Dim dtmenu As New DataTable("hijo")
        Dim params As New List(Of String)
        Try
            params.Add(SesionActual.idUsuario)
            Generales.llenarTabla("SP_ADMIN_MENU_HIJOS", params, dtmenu)
            dsDatos.Tables.Add(dtmenu)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Public Shared Sub cargarMenu(ByRef dsCuentas As DataSet)
        cargarMenuPadre(dsCuentas)
        cargarMenuHijas(dsCuentas)
    End Sub

    Public Shared Sub cargarFormulario(elemento As ElementoMenu)
        Try
            Dim elemMenu As ElementoMenu = elemento

            If estaAbierto(elemMenu) = True Then
                traerAlFrente(elemMenu)
            Else

                Dim nombreTipo = "Quality." & elemMenu.nombre

                Dim vTipo As Type = Assembly.GetExecutingAssembly.GetType(nombreTipo)
                If vTipo IsNot Nothing Then
                    Dim vFormulario = Activator.CreateInstance(vTipo)
                    vFormulario.tag = elemMenu
                    Generales.cargarForm(vFormulario)
                End If
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
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
End Class
