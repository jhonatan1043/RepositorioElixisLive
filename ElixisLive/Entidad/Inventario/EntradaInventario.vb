Public Class EntradaInventario
    Inherits generalConsulta
    Property codigo As Integer
    Property codigoCompra As String
    Property dtEntrada As DataTable
    Public Sub New()
        dtEntrada = New DataTable
        dtEntrada.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtEntrada.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtEntrada.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        dtEntrada.Columns.Add("valor", Type.GetType("System.Int32")).DefaultValue = 0
        dtEntrada.Columns.Add("Total", Type.GetType("System.Int32")).DefaultValue = 0
        dtEntrada.Columns.Add("Bodega", Type.GetType("System.String"))
        dtEntrada.Columns.Add("FechaVencimiento", Type.GetType("System.DateTime"))
        dtEntrada.Columns.Add("CodigoBarra", Type.GetType("System.String"))
        sqlAnular = ""
        sqlGuardar = "SP_INVEN_INVENTARIO_CREAR"
        sqlConsulta = ""
        sqlCargarDetalle = ""
    End Sub
End Class
