﻿Public Class ListaPrecio
    Inherits generalConsulta
    Property codigo As String
    Property nombre As String
    Property codigoTipoLista As Integer
    Property dtPrecio As DataTable
    Public Sub New()
        dtPrecio = New DataTable

        dtPrecio.Columns.Add("Codigo", Type.GetType("System.Int32"))
        dtPrecio.Columns.Add("Descripcion", Type.GetType("System.String"))
        dtPrecio.Columns.Add("Precio", Type.GetType("System.Decimal")).DefaultValue = 0

        sqlConsulta = "[SP_INVEN_PRECIO_CONSULTAR]"
        sqlCargar = "[SP_INVEN_PRECIO_CARGAR]"
        sqlGuardar = "[SP_INVEN_PRECIO_CREAR]"
        sqlAnular = "[SP_INVEN_PRECIO_ANULADO] "
        sqlCargarDetalle = "[SP_INVEN_PRECIO_DETALLE]"
    End Sub

End Class
