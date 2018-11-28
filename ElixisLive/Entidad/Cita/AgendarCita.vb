Public Class AgendarCita
    Inherits generalConsulta
    Property codigo As String
    Property dtServicio As DataTable
    Property codigoPersona As Integer
    Property dtFechaCita As DateTime
    Property observacion As String
    Public Sub New()
        dtServicio = New DataTable
        dtServicio.Columns.Add("codigo", Type.GetType("System.Int32"))
        dtServicio.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtServicio.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        sqlGuardar = "[SP_ADMIN_CITA_CREAR]"
        sqlCargar = "[SP_ADMIN_CITA_CARGAR]"
        sqlCargarDetalle = "[SP_ADMIN_CITA_CARGAR_DETALLE]"
        sqlAnular = "SP_ADMIN_CITA_ANULAR "
    End Sub

End Class
