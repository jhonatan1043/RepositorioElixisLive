Public Class LoteBLL
    Public Shared Function verificarTabla(objproducto As UbicacionProducto, codigoProducto As String) As Boolean
        Dim posicion As Integer
        Dim bandera As Boolean
        If objproducto.dtSetLote.Tables.Count > 0 Then
            For posicion = 0 To objproducto.dtSetLote.Tables.Count - 1
                If objproducto.dtSetLote.Tables(posicion).TableName = codigoProducto Then
                    bandera = True
                End If
            Next
        End If
        Return bandera
    End Function
End Class
