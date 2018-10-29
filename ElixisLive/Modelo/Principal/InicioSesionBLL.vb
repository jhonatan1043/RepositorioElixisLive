Public Class InicioSesionBLL
    Property usuario As String
    Property contrasena As String
    Property codigoSucursal As String
    Public Function inicioSesionCargar() As Boolean
        Dim params As New List(Of String)
        Dim resultado As String
        Dim banderaForm As Boolean

        params.Add(usuario)
        params.Add(contrasena)
        params.Add(codigoSucursal)

        resultado = Funciones.consulInicioSesion(params)

        If Not String.IsNullOrEmpty(resultado) Then
            SesionActual.idUsuario = resultado
            SesionActual.codigoSucursal = codigoSucursal
            FormPrincipal.Show()
            banderaForm = True
        Else
            MsgBox(MensajeSistema.CONTRASENA_VALIDA, , "Inicio Sesión")
        End If
        Return banderaForm
    End Function
End Class
