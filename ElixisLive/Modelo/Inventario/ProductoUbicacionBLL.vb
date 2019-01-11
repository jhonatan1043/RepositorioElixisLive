Public Class ProductoUbicacionBLL
    Public Shared Sub guardar(objUbicacionProducto As UbicacionProducto)
        objUbicacionProducto.dtLote = sacarDatatable(objUbicacionProducto.dtSetLote)
        ProductoUbicacionDAL.guardar(objUbicacionProducto)
    End Sub
    Public Shared Sub varificargrillaProducto(objUbicacionProducto As UbicacionProducto, dgvProducto As DataGridView)
        If objUbicacionProducto.dtSetLote.Tables.Count > 0 Then
            For posicion = 0 To objUbicacionProducto.dtSetLote.Tables.Count - 1
                If objUbicacionProducto.dtSetLote.Tables(posicion).TableName = CStr(objUbicacionProducto.dtProducto.Rows(posicion).Item("Codigo")) Then
                    dgvProducto.Rows(posicion).Cells("dgLote").Style.BackColor = Color.LightGreen
                End If
            Next
        End If
    End Sub
    Private Shared Function sacarDatatable(dtset As DataSet) As DataTable
        Dim dt As New DataTable
        If dtset.Tables.Count > 0 Then
            dt = dtset.Tables(0).Clone
            For posicion = 0 To dtset.Tables.Count - 1
                For posicionD = 0 To dtset.Tables(posicion).Rows.Count - 1
                    dt.ImportRow(dtset.Tables(posicion).Rows(posicionD))
                Next
            Next
        End If
        Return dt
    End Function
End Class
