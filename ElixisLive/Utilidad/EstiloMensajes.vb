Public Class EstiloMensajes
    Shared formMsgBx As SuperMessageBox
    Public Shared Sub mostrarMensajeExitoso(mensaje As String, ByVal Optional titulo As String = "")
        formMsgBx = New SuperMessageBox
        If titulo <> "" Then
            formMsgBx.AgregarTitulo(titulo)
        End If
        formMsgBx.AgregarBoton("Aceptar")
        formMsgBx.AgregarMensaje(mensaje)
        formMsgBx.Agregarlogo(My.Resources.ok)
        formMsgBx.Mostrar()
    End Sub
    Public Shared Sub mostrarMensajeAnulado(mensaje As String, ByVal Optional titulo As String = "")
        formMsgBx = New SuperMessageBox
        If titulo <> "" Then
            formMsgBx.AgregarTitulo(titulo)
        End If
        formMsgBx.AgregarBoton("Aceptar")
        formMsgBx.AgregarMensaje(mensaje)
        formMsgBx.Agregarlogo(My.Resources.Anular)
        formMsgBx.Mostrar()
    End Sub
    Public Shared Sub mostrarMensajeError(mensaje As String, ByVal Optional titulo As String = "")
        formMsgBx = New SuperMessageBox
        If titulo <> "" Then
            formMsgBx.AgregarTitulo(titulo)
        End If
        formMsgBx.AgregarBoton("Aceptar")
        formMsgBx.AgregarMensaje(mensaje)
        formMsgBx.Agregarlogo(My.Resources.advertencia)
        formMsgBx.Mostrar()
    End Sub
    Public Shared Sub mostrarMensajeAdvertencia(mensaje As String, ByVal Optional titulo As String = "")
        formMsgBx = New SuperMessageBox
        If titulo <> "" Then
            formMsgBx.AgregarTitulo(titulo)
        End If
        formMsgBx.AgregarBoton("Aceptar")
        formMsgBx.AgregarMensaje(mensaje)
        formMsgBx.Agregarlogo(My.Resources.Cancel)
        formMsgBx.Mostrar()
    End Sub
    Public Shared Function mostrarMensajePregunta(mensaje As String, ByVal Optional titulo As String = "") As String
        formMsgBx = New SuperMessageBox
        Dim respuesta As String
        If titulo <> "" Then
            formMsgBx.AgregarTitulo(titulo)
        End If
        formMsgBx.AgregarBoton(Constantes.SI)
        formMsgBx.AgregarBoton(Constantes.NO)
        formMsgBx.AgregarMensaje(mensaje)
        formMsgBx.Agregarlogo(My.Resources.Very_Basic_Help_icon)
        respuesta = formMsgBx.Mostrar()
        Return respuesta

    End Function

    Public Shared Sub mostrarMensajePreguntaCancel(mensaje As String, ByVal Optional titulo As String = "")
        formMsgBx.AgregarTitulo(titulo)
        formMsgBx.AgregarBoton(Constantes.SI)
        formMsgBx.AgregarBoton(Constantes.NO)
        formMsgBx.AgregarBoton("Cancelar")
        formMsgBx.AgregarMensaje(mensaje)
        'formMsgBx.Agregarlogo(My.Resources.azul)
        formMsgBx.Mostrar()
    End Sub
End Class
