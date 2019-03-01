Public Class ListaPrecioBLL
    Public Shared Function guardarListaPrecio(objLista As ListaPrecio) As ListaPrecio
        ListaPrecioDAL.guardarLista(objLista)
        Return objLista
    End Function
    Public Shared Sub cargarComboTipoLista(cbCombo As ComboBox)
        Dim tabla As New DataTable
        Dim drFila As DataRow
        tabla.Columns.Add("Codigo")
        tabla.Columns.Add("Nombre")

        drFila = tabla.NewRow()
        drFila.Item(0) = "-1"
        drFila.Item(1) = " - - - Seleccione - - - "
        tabla.Rows.Add(drFila)

        drFila = tabla.NewRow()
        drFila.Item(0) = "0"
        drFila.Item(1) = "Producto"
        tabla.Rows.Add(drFila)

        drFila = tabla.NewRow()
        drFila.Item(0) = "1"
        drFila.Item(1) = "Servicio"
        tabla.Rows.Add(drFila)

        cargarCombo(tabla, cbCombo)
    End Sub

    Private Shared Sub cargarCombo(dtTabla As DataTable, cbCombo As ComboBox)
        Try
            cbCombo.DataSource = dtTabla
            cbCombo.DisplayMember = "Nombre"
            cbCombo.ValueMember = "Codigo"
            If cbCombo IsNot Nothing Then
                cbCombo.AutoCompleteMode = AutoCompleteMode.None
                cbCombo.AutoCompleteSource = AutoCompleteSource.None
                cbCombo.DropDownStyle = ComboBoxStyle.DropDownList
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
End Class
