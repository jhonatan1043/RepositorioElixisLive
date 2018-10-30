Public Class Perfil
    Inherits generalConsulta
    Property codigo As String
    Property nombre As String
    Property dtPerfil As DataTable
    Public Sub New()
        dtPerfil = New DataTable
        dtPerfil.Columns.Add("Codigo_Menu", Type.GetType("System.String"))
        sqlGuardar = "[SP_ADMIN_PERFIL_CREAR]"
        sqlCargar = "[SP_ADMIN_PERFIL_LISTA]"
        sqlAnular = ""
    End Sub

End Class
