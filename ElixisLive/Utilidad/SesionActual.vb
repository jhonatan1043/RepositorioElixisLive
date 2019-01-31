Imports System.Data.SqlClient
Public Class SesionActual
    Public Shared Property idUsuario As Integer
    Public Shared Property codigoSucursal As Integer
    Public Shared Property codigoEmpresa As Integer
    Public Shared Property usuario As String
    Public Shared Property nombreUsuario As String
    Public Shared Property codigoPerfil As Integer
    Public Shared Property dtPermisos As New DataTable
    Public Shared fprincipal As New FormPrincipal
    Public Shared Function verificarPermiso(pCodigoPermiso As String) As Boolean
        dtPermisos = fprincipal.cargarOpciones(codigoPerfil)
        If dtPermisos.Select("Codigo_Menu='" & pCodigoPermiso & "'", "").Count > 0 Then
            Return True
        ElseIf codigoPerfil = 0 Then
            Return True
        End If
        Return False
    End Function

End Class
