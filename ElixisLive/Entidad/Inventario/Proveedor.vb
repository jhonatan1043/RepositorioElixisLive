﻿Public Class Proveedor
    Inherits generalConsulta
    Property codigoProducto As String
    Property nombre As String
    Property fecha As DateTime
    Property foto As Byte()
    Property dtParametro As DataTable
    Property dtRegistro As DataTable
    Property bdraControl As Boolean
    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = "[SP_INVEN_PRODUCTO_CREAR]"
        sqlConsulta = "[SP_INVEN_PRODUCTO_CONSULTAR]"
        sqlCargar = "SP_INVEN_PRODUCTO_CARGAR"
        sqlCargarDetalle = "[SP_INVEN_PRODUCTO_CARGAR_D]"
    End Sub

End Class
