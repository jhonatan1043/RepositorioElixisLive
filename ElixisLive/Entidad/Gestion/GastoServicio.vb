Public Class GastoServicio
    Inherits generalConsulta
    Property codigo As String
    Property fecha As Date
    Property dtGasto As DataTable
    Public Sub New()
        dtGasto = New DataTable
        dtGasto.Columns.Add("Justificacion", Type.GetType("System.String"))
        dtGasto.Columns.Add("Valor", Type.GetType("System.Decimal")).DefaultValue = 0
        sqlCargar = "[SP_ADMIN_GASTO_SERVICIO_CARGAR]"
        sqlCargarDetalle = "[SP_ADMIN_GASTO_SERVICIO_DETALLE]"
        sqlConsulta = "[SP_ADMIN_GASTO_SERVICIO_CONSULTAR]"
        sqlGuardar = "[SP_ADMIN_GASTO_SERVICIO_CREAR]"
        sqlAnular = "[SP_ADMIN_GASTO_SERVICIO_ANULADO]"
    End Sub
End Class
