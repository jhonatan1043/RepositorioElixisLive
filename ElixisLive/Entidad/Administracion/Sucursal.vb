Public Class Sucursal
    Inherits persona
    Property identiResponsable As String
    Property responsable As String
    Public Sub New()
        sqlAnular = "[SP_CONFI_SUCURSAL_ANULAR] "
        sqlCargar = "[SP_CONFI_SUCURSAL_CARGAR]"
        sqlConsulta = Sentencias.SUCURSAL_LISTA
        sqlGuardar = "[SP_CONFI_SUCURSAL_CREAR]"
    End Sub
End Class
