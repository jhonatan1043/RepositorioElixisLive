Public Class FormLote
    Property objInventarioEntrada As FormEntradaInventario
    Dim dtLote As New DataTable
    Private Sub FormLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCantidadEntrante.Text = objInventarioEntrada.cantidadEntrante
        establecerPosicion()
        dtLote = objInventarioEntrada.dtContenedorLote.Clone
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If String.IsNullOrEmpty(txtNombre.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ Debe ingresar el registro lote !")
        ElseIf String.IsNullOrEmpty(txtCantidadExistete.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ Faltan Campos por llenar !")
        Else
                Try
                If objInventarioEntrada.dtContenedorLote.Select("[CodigoProducto]='" & objInventarioEntrada.codigoProducto & "'").Count > 0 Then
                    objInventarioEntrada.dtContenedorLote.Rows.Remove(getFila)
                End If
                dtLote.Rows.Add()
                dtLote.Rows(dtLote.Rows.Count - 1).Item("CodigoProducto") = objInventarioEntrada.codigoProducto
                dtLote.Rows(dtLote.Rows.Count - 1).Item("Nombre") = txtNombre.Text
                dtLote.Rows(dtLote.Rows.Count - 1).Item("CantidadExistente") = txtCantidadExistete.Text
                dtLote.Rows(dtLote.Rows.Count - 1).Item("CantidadEntrante") = objInventarioEntrada.cantidadEntrante
                dtLote.Rows(dtLote.Rows.Count - 1).Item("FechaVencimiento") = dtFechaVencimiento.Value
                objInventarioEntrada.dtContenedorLote.ImportRow(dtLote.Rows(0))
                Close()
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsultarLote()
        End If
    End Sub
    Private Sub ConsultarLote()
        Dim fila As DataRow
        Dim params As New List(Of String)
        Try
            params.Add(txtNombre.Text)
            fila = Generales.cargarItem(Sentencias.LOTE_CONSULTAR, params)
            If Not IsNothing(fila) Then
                txtCantidadExistete.Text = fila("Cantidad")
            Else
                txtCantidadExistete.Text = Constantes.SIN_VALOR_NUMERICO
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub FormLote_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        Close()
    End Sub
    Private Sub establecerPosicion()
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 619
        y = Screen.PrimaryScreen.WorkingArea.Height - 236
        Me.Location = New Point(x, y)
    End Sub
    Private Function getFila() As DataRow
        Dim fila As DataRow = Nothing
        For Each fila In objInventarioEntrada.dtContenedorLote.Select("[CodigoProducto]='" & objInventarioEntrada.codigoProducto & "'")
            Exit For
        Next
        Return fila
    End Function
    Public Sub cargarRegistros()
        Dim fila As DataRow

        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)

        If objInventarioEntrada.registroGuardado = True Then
        Else
            If Not IsNothing(getFila) Then
                fila = getFila()
                txtNombre.Text = fila("Nombre")
                txtCantidadExistete.Text = fila("CantidadExistente")
                txtCantidadEntrante.Text = objInventarioEntrada.cantidadEntrante
                dtFechaVencimiento.Value = fila("FechaVencimiento")
            End If
            dtFechaVencimiento.Enabled = True
            txtNombre.ReadOnly = False
            btRegistrar.Enabled = True
        End If

    End Sub
    Private Sub txtNombre_LostFocus(sender As Object, e As EventArgs) Handles txtNombre.LostFocus
        ConsultarLote()
    End Sub
End Class