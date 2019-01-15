Public Class SesionActual
    Public Shared Property idUsuario As Integer
    Public Shared Property codigoSucursal As Integer
    Public Shared Property codigoEmpresa As Integer
    Public Shared Property usuario As String
    Public Shared Property nombreUsuario As String
    Public Shared Property codigoPerfil As Integer
    Public Shared Property dtPermisos As New DataTable

    Public Shared Function tienePermiso(pCodigoPermiso As String) As Boolean
        If dtPermisos.Select("Codigo_Menu='" & pCodigoPermiso & "'", "").Count > 0 Then
            Return True
        End If
        Return False
    End Function
End Class
