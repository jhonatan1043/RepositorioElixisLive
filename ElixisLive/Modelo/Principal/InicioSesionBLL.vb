Public Class InicioSesionBLL
    Property usuario As String
    Property contrasena As String
    Property codigoSucursal As String
    Property codigoEmpresa As String
    Public Function inicioSesionCargar() As Boolean
        Dim params As New List(Of String)
        Dim Dresultado As DataRow
        Dim banderaForm As Boolean

        params.Add(usuario)
        params.Add(contrasena)
        params.Add(codigoSucursal)

        Dresultado = Funciones.consultarInicioSesion(params)

        If Not IsNothing(Dresultado) Then

            SesionActual.idUsuario = Dresultado.Item(0)
            SesionActual.codigoSucursal = codigoSucursal
            SesionActual.usuario = usuario
            SesionActual.nombreUsuario = Dresultado.Item(1)
            SesionActual.codigoPerfil = Dresultado.Item(2)
            SesionActual.identificacionUsuario = Dresultado.Item(3)
            SesionActual.nitEmpresa = Dresultado.Item(4)
            SesionActual.nombreEmpresa = Dresultado.Item(5)
            FormPrincipal.Show()
            banderaForm = True
        Else
            MsgBox(MensajeSistema.CONTRASENA_VALIDA, , "Inicio Sesión")
        End If
        Return banderaForm
    End Function
End Class
