Public Class PerfilBLL
    Private Shared dsDatos As DataSet
    Public Shared Function guardarPerfil(objPerfil As Perfil) As Perfil
        PerfilDAL.guardarPerfil(objPerfil)
        Return objPerfil
    End Function
    Public Shared Sub cargarMenu(arbolMenu As TreeView, Optional codigoPerfil As String = Nothing)
        Dim nodo As TreeNode
        Dim drCuentaPadre As DataRow()
        Try
            dsDatos = New DataSet
            arbolMenu.Nodes.Clear()
            CreaOpciones(dsDatos)
            cargarMenu(dsDatos, codigoPerfil)
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
    Private Shared Sub crearSubcuentas(ByRef nodoPade As TreeNode, Optional codigoPerfil As String = Nothing)
        Dim expr As String = "[Codigo_Padre] ='" & nodoPade.Name & "'"
        Dim subnodo As TreeNode
        Try
            Dim aDrFilas As DataRow()
            aDrFilas = dsDatos.Tables("Hijo").Select(expr, "Codigo")
            For Each drFila As DataRow In aDrFilas
                subnodo = New TreeNode
                subnodo.Name = drFila("Codigo").ToString()
                subnodo.Text = drFila("Descripcion").ToString()
                nodoPade.Nodes.Add(subnodo)
                crearSubcuentas(subnodo)
            Next
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Shared Sub CreaOpciones(ByRef dsDatos As DataSet, Optional codigoPerfil As String = Nothing)
        Dim dtmenu As New DataTable("menu")
        Dim params As New List(Of String)
        Try
            params.Add(codigoPerfil)
            Generales.llenarTabla("[SP_ADMIN_PERFIL_CONSULTAR]", params, dtmenu)
            dsDatos.Tables.Add(dtmenu)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Shared Sub cargarMenuPadre(ByRef dsDatos As DataSet, Optional codigoPerfil As String = Nothing)
        Dim dtmenu As New DataTable("padre")
        Dim params As New List(Of String)
        Try
            params.Add(codigoPerfil)
            Generales.llenarTabla("[SP_ADMIN_PERFIL_PADRE]", params, dtmenu)
            dsDatos.Tables.Add(dtmenu)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Shared Sub cargarMenuHijas(ByRef dsDatos As DataSet, Optional codigoPerfil As String = Nothing)
        Dim dtmenu As New DataTable("hijo")
        Dim params As New List(Of String)
        Try
            params.Add(codigoPerfil)
            Generales.llenarTabla("[SP_ADMIN_PERFIL_HIJOS]", params, dtmenu)
            dsDatos.Tables.Add(dtmenu)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Public Shared Sub cargarMenu(ByRef dsCuentas As DataSet, Optional codigoPerfil As String = Nothing)
        cargarMenuPadre(dsCuentas, codigoPerfil)
        cargarMenuHijas(dsCuentas, codigoPerfil)
    End Sub
End Class
