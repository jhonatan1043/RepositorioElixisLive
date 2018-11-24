Public Class Compra
    Inherits generalConsulta
    Property codigo As String
    Property codigoPersona As Integer
    Property fechaCompra As DateTime
    Property numeroFactura As String
    Property dtCompra As DataTable

    Public Sub New()
        dtCompra = New DataTable
        dtCompra.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtCompra.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtCompra.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        dtCompra.Columns.Add("valor", Type.GetType("System.Int32")).DefaultValue = 0
        dtCompra.Columns.Add("Total", Type.GetType("System.Int32")).DefaultValue = 0
    End Sub

End Class
