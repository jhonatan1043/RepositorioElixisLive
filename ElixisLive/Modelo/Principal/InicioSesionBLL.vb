Public Class InicioSesionBLL
    Property usuario As String
    Property contrasena As String
    Property idEmpresa As String
    Public Function inicioSesionCargar() As Boolean
        Dim params As New List(Of String)
        Dim resultado As String
        Dim objSesionActual As New SesionActual
        Dim banderaForm As Boolean

        params.Add(usuario)
        params.Add(contrasena)
        params.Add(idEmpresa)

        resultado = Funciones.consulInicioSesion(params)
        objSesionActual.idUsuario = resultado
        objSesionActual.idEmpresa = idEmpresa

        If Not String.IsNullOrEmpty(resultado) Then
            FormPrincipal.Show()
            banderaForm = True
        Else
            'MsgBox("¡ Usuario o contraseña no validos !", , "Inicio Sesión")
            FormPrincipal.Show()
            banderaForm = True
        End If
        Return banderaForm
    End Function
End Class
