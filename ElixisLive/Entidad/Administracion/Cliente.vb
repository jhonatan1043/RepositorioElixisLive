Public Class Cliente
    Inherits generalConsulta
    Property dtCliente As DataTable
    Public Sub New()
        dtCliente = New DataTable

        dtCliente.Columns.Add("codigo", Type.GetType("System.Int32"))
        dtCliente.Columns.Add("Nombre", Type.GetType("System.String"))
        dtCliente.Columns.Add("Descuento", Type.GetType("System.Decimal"))
        dtCliente.Columns.Add("Fecha_Inicio", Type.GetType("System.DateTime"))
        dtCliente.Columns.Add("Fecha_Fin", Type.GetType("System.DateTime"))

        sqlGuardar = "[SP_ADMIN_CLIENTE_CREAR]"
        sqlConsulta = "[SP_ADMIN_CLIENTE_CARGAR]"
    End Sub
End Class
