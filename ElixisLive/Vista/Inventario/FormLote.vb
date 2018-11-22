Public Class FormLote
    Property objInventarioEntrada As FormEntradaInventario
    Private Sub FormLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        dtFechaVencimiento.Enabled = True
        txtCantidadEntrante.Text = objInventarioEntrada.cantidadEntrante
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If String.IsNullOrEmpty(txtNombre.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ Debe ingresar el registro lote !")
        Else
            objInventarioEntrada.dtContenedor.ImportRow(validarDatatble.Rows(0))
            Close()
        End If
    End Sub
    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        Dim fila As DataRow
        Dim params As New List(Of String)
        If e.KeyCode = Keys.Enter Then
            params.Add(txtNombre.Text)
            fila = Generales.cargarItem("", params)
            If Not IsNothing(fila) Then
                txtCantidadExistete.Text = fila("")
            Else
                txtCantidadExistete.Text = Constantes.SIN_VALOR_NUMERICO
            End If
        End If
    End Sub
    Private Function validarDatatble() As DataTable
        Dim dtLote As New DataTable(objInventarioEntrada.codigoProducto)
        dtLote.Columns.Add("Nombre", Type.GetType("System.String"))
        dtLote.Columns.Add("CantidadExistente", Type.GetType("System.Int32"))
        dtLote.Columns.Add("FechaVencimiento", Type.GetType("System.DateTime"))
        dtLote.Rows.Add()
        dtLote.Rows(dtLote.Rows.Count - 1).Item("Nombre") = txtNombre.Text
        dtLote.Rows(dtLote.Rows.Count - 1).Item("CantidadExistente") = txtCantidadExistete.Text
        dtLote.Rows(dtLote.Rows.Count - 1).Item("FechaVencimiento") = dtFechaVencimiento.Value
        Return dtLote
    End Function
    Private Sub FormLote_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Close()
    End Sub
End Class