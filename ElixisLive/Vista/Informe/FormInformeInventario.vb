Public Class FormInformeInventario
    Dim codigoListaPrecio As Integer
    Dim tbla As DataTable
    Private Sub FormInformeInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valoresIniciales()
    End Sub
    Private Sub valoresIniciales()
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(Constantes.INVENTARIO)
        tbla = Generales.cargarComboTabla(Sentencias.INFORME_CONSULTAR, params, "Nombre", "Codigo", cbInforme)

        dRows = Generales.cargarItem("[SP_LISTA_PRODUCTO_ACTUAL_CONSULTAR]", Nothing)
        If Not IsNothing(dRows) Then
            codigoListaPrecio = dRows("Codigo")
            lbListaMedicamento.Text = dRows("Nombre")
        End If

    End Sub
    Private Sub cbInforme_TextChanged(sender As Object, e As EventArgs) Handles cbInforme.TextChanged
        Dim dRows() As DataRow
        Dim formula As String
        If cbInforme.SelectedIndex > 0 Then
            dRows = tbla.Select("[codigo] = " & cbInforme.SelectedValue)
            formula = dRows.First().Item("Formula").ToString
            crView.SelectionFormula = formula
            crView.Show()
        End If
    End Sub
End Class