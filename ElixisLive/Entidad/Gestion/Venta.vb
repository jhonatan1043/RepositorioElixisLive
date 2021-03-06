﻿Public Class Venta
    Inherits generalConsulta
    Property codigo As String
    Property codigoPersonaCliente As String
    Property identificacion As String
    Property nombre As String
    Property telefono As String
    Property dtProductos As DataTable
    Property dtServicio As DataTable
    Property dtCodigoBarra As DataTable
    Property estadoAnulado As Boolean
    Property estadoFilaNueva As Boolean
    Property descuentoCliente As Decimal
    Property indice As Integer
    Public Sub New()
        dtProductos = New DataTable
        dtServicio = New DataTable
        dtCodigoBarra = New DataTable

        dtProductos.Columns.Add("codigo", Type.GetType("System.String"))
        dtProductos.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtProductos.Columns.Add("Stock", Type.GetType("System.Int32"))
        dtProductos.Columns.Add("Cantidad", Type.GetType("System.Int32")).DefaultValue = 0
        dtProductos.Columns.Add("Valor", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("descuento", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("Valordescuento", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("Total", Type.GetType("System.Decimal")).DefaultValue = 0
        dtProductos.Columns.Add("EmpleadoP", Type.GetType("System.String"))
        dtProductos.Columns.Add("EmpleadoN", Type.GetType("System.String"))

        dtServicio.Columns.Add("codigo", Type.GetType("System.Int32"))
        dtServicio.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtServicio.Columns.Add("descuento", Type.GetType("System.Decimal")).DefaultValue = 0
        dtServicio.Columns.Add("Valordescuento", Type.GetType("System.Decimal")).DefaultValue = 0
        dtServicio.Columns.Add("ValorServicio", Type.GetType("System.Decimal")).DefaultValue = 0
        dtServicio.Columns.Add("codigo_Empleado", Type.GetType("System.String"))
        dtServicio.Columns.Add("NombreEmpleado", Type.GetType("System.String"))

        dtCodigoBarra.Columns.Add("codigoBarra", Type.GetType("System.String"))

        sqlAnular = "[SP_INVEN_VENTA_ANULAR]"
        sqlCargar = Sentencias.INVEN_VENTA_CARGAR
        sqlConsulta = Sentencias.VENTA_BUSCAR
        sqlGuardar = "[SP_INVEN_VENTA_CREAR]"

    End Sub
End Class
