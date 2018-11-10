Public Class Perfil
    Inherits generalConsulta
    Property codigoPerfil As String
    Property nombre As String
    Property dtRegistro As DataTable
    Property dtPerfil As DataTable
    Property codigoPersona As Integer
    Public Property dtEmpleados As New DataTable
    Public Sub New()
        dtPerfil = New DataTable
        dtRegistro = New DataTable
        dtPerfil.Columns.Add("Codigo_Menu", Type.GetType("System.String"))
        sqlGuardar = "[SP_ADMIN_PERFIL_CREAR]"
        sqlCargar = "[SP_ADMIN_PERFIL_LISTA]"
        sqlAnular = ""
    End Sub
    Sub New(persona As persona)
        codigoPersona = persona.codigo
    End Sub
    Sub New(drPerfilTercero As DataRow)
        codigoPerfil = Funciones.castFromDbItem(drPerfilTercero.Item("codigo_perfil"))
        nombre = Funciones.castFromDbItem(drPerfilTercero.Item("nombre_perfil"))
    End Sub

    Public Sub guardarPerfil()
        If String.IsNullOrEmpty(codigoPerfil) Then
            PerfilDAL.crearPerfil(Me)
        Else
            PerfilDAL.actualizarPerfil(Me)
        End If
    End Sub

    Friend Sub anularPerfil()
        PerfilDAL.anularPerfil(Me)
    End Sub


End Class
