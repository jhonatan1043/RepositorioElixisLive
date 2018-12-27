Public Class CambioClave
    Public Property claveActual As String
    Public Property claveNueva As String
    Public Property confirmarClave As String

    Public Function verificarClave() As Boolean
        Dim params As New List(Of String)
        params.Add(SesionActual.idUsuario)
        params.Add(claveActual)
        Return Generales.getEstadoVF(Sentencias.VERIFICAR_CAMBIAR_CLAVE, params)
    End Function
    Public Sub guardarClave()
        CambioClaveDAL.guardarClave(Me)
    End Sub
End Class
