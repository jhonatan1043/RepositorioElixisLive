﻿Public Class InicioSesionBLL
    Property usuario As String
    Property contrasena As String
    Property idEmpresa As String
    Public Function inicioSesionCargar() As Boolean
        Dim params As New List(Of String)
        Dim resultado As String
        Dim banderaForm As Boolean

        params.Add(usuario)
        params.Add(contrasena)
        params.Add(idEmpresa)

        resultado = Funciones.consulInicioSesion(params)
        SesionActual.idUsuario = resultado
        SesionActual.idEmpresa = idEmpresa

        If Not String.IsNullOrEmpty(resultado) Then
            FormPrincipal.Show()
            banderaForm = True
        Else
            MsgBox("¡ contraseña no validos !", , "Inicio Sesión")
            'FormPrincipal.Show()
            'banderaForm = True
        End If
        Return banderaForm
    End Function
End Class
