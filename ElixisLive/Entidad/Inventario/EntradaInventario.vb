Public Class EntradaInventario
    Inherits generalConsulta
    Property codigo As Integer
    Property codigoCompra As Integer
    Property dtEntrada As DataTable
    Property dtLote As DataTable
    Public Sub New()
        dtEntrada = New DataTable
        dtEntrada.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtEntrada.Columns.Add("producto", Type.GetType("System.String"))
        dtEntrada.Columns.Add("valor", Type.GetType("System.Decimal"))
        dtEntrada.Columns.Add("Cantidad", Type.GetType("System.Int32"))
        dtEntrada.Columns.Add("Total", Type.GetType("System.Decimal"))
        dtEntrada.Columns.Add("Bodega", Type.GetType("System.String"))
        dtEntrada.Columns.Add("CodigoBarra", Type.GetType("System.String"))
        sqlAnular = ""
        sqlGuardar = "SP_INVEN_INVENTARIO_CREAR"
        sqlConsulta = ""
        sqlCargarDetalle = ""
    End Sub
End Class
