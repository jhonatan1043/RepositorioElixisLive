Public Class Empresa
    Inherits persona
    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = "[SP_ADMIN_EMPRESA_CREAR]"
        sqlConsulta = "[SP_ADMIN_EMPRESA_CONSULTAR]"
        sqlCargar = "SP_ADMIN_EMPRESA_CARGAR"
        sqlCargarDetalle = "[SP_ADMIN_EMPRESA_CARGAR_D]"
        sqlAnular = ""
    End Sub
End Class
