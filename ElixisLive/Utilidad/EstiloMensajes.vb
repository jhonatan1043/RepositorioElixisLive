Public Class EstiloMensajes
    Shared frmMsgBx As SuperMessageBox
    Public Shared Sub mostrarMensajeExitoso(mensaje As String, ByVal Optional titulo As String = "")
        frmMsgBx = New SuperMessageBox
        If titulo <> "" Then
            frmMsgBx.AgregarTitulo(titulo)
        End If
        frmMsgBx.AgregarBoton("Aceptar")
        frmMsgBx.AgregarMensaje(mensaje)
        frmMsgBx.Agregarlogo(My.Resources.exitoso)
        frmMsgBx.Mostrar()
    End Sub
    Public Shared Sub mostrarMensajeAnulado(mensaje As String, ByVal Optional titulo As String = "")
        frmMsgBx = New SuperMessageBox
        If titulo <> "" Then
            frmMsgBx.AgregarTitulo(titulo)
        End If
        frmMsgBx.AgregarBoton("Aceptar")
        frmMsgBx.AgregarMensaje(mensaje)
        frmMsgBx.Agregarlogo(My.Resources.advertencia)
        frmMsgBx.Mostrar()
    End Sub
    Public Shared Sub mostrarMensajeError(mensaje As String, ByVal Optional titulo As String = "")
        frmMsgBx = New SuperMessageBox
        If titulo <> "" Then
            frmMsgBx.AgregarTitulo(titulo)
        End If
        frmMsgBx.AgregarBoton("Aceptar")
        frmMsgBx.AgregarMensaje(mensaje)
        frmMsgBx.Agregarlogo(My.Resources._error)
        frmMsgBx.Mostrar()
    End Sub
    Public Shared Sub mostrarMensajeAdvertencia(mensaje As String, ByVal Optional titulo As String = "")
        frmMsgBx = New SuperMessageBox
        If titulo <> "" Then
            frmMsgBx.AgregarTitulo(titulo)
        End If
        frmMsgBx.AgregarBoton("Aceptar")
        frmMsgBx.AgregarMensaje(mensaje)
        frmMsgBx.Agregarlogo(My.Resources.prohibido)
        frmMsgBx.Mostrar()
    End Sub
    Public Shared Function mostrarMensajePregunta(mensaje As String, ByVal Optional titulo As String = "") As String
        frmMsgBx = New SuperMessageBox
        Dim respuesta As String
        If titulo <> "" Then
            frmMsgBx.AgregarTitulo(titulo)
        End If
        frmMsgBx.AgregarBoton(Constantes.SI)
        frmMsgBx.AgregarBoton(Constantes.NO)
        frmMsgBx.AgregarMensaje(mensaje)
        frmMsgBx.Agregarlogo(My.Resources.pregunta)
        respuesta = frmMsgBx.Mostrar()
        Return respuesta

    End Function

    Public Sub mostrarMensajePreguntaCancel(mensaje As String, ByVal Optional titulo As String = "")
        frmMsgBx.AgregarTitulo(titulo)
        frmMsgBx.AgregarBoton(Constantes.SI)
        frmMsgBx.AgregarBoton(Constantes.NO)
        frmMsgBx.AgregarBoton("Cancelar")
        frmMsgBx.AgregarMensaje(mensaje)
        frmMsgBx.Agregarlogo(My.Resources.pregunta)
        frmMsgBx.Mostrar()
    End Sub
End Class
