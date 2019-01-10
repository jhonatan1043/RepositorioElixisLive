Public Class FormLote
    Dim objLote As Lote
    Property objproducto As UbicacionProducto
    Property codigoProducto As Integer
    Property cantidadExistente As Integer
    Private Sub FormLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objLote = New Lote
        valoresIniciales()
        dgvLote.AutoGenerateColumns = False
    End Sub
    Private Sub dgAgregar_Click(sender As Object, e As EventArgs) Handles dgAgregar.Click
        objLote.dtLote.Rows.Add()
    End Sub
    Private Sub dgvLote_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLote.CellClick
        If dgvLote.Rows(dgvLote.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True And objLote.dtLote.Rows.Count > 1 Then
            objLote.dtLote.Rows.RemoveAt(dgvLote.CurrentCell.RowIndex)
        End If
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Dim cantidades As Integer
        objLote.dtLote.AcceptChanges()
        dgvLote.EndEdit()
        cantidades = objLote.dtLote.Compute("SUM(cantidad)", "")

        If objLote.dtLote.Select("RegistroLote NOT IS NULL AND Cantidad = 0").Count > 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Hay lotes con cantidades en 0")
        ElseIf cantidadExistente < cantidades
            EstiloMensajes.mostrarMensajeAdvertencia("la cantidad ingresada no puede ser mayor a la existente")
        Else
            objproducto.dtSetLote.Tables.Add(objLote.dtLote)
            Close()
        End If
    End Sub
    Private Sub valoresIniciales()
        Dim posicion As Integer
        Dim bandera As Boolean
        For posicion = 0 To objproducto.dtSetLote.Tables.Count > 0
            If objproducto.dtSetLote.Tables(posicion).TableName = codigoProducto Then
                bandera = True
            End If
        Next
        If bandera = True Then
            dgvLote.DataSource = objproducto.dtSetLote.Tables(codigoProducto)
        Else
            objLote.dtLote.TableName = codigoProducto
            dgvLote.DataSource = objLote.dtLote
            objLote.dtLote.Rows.Add()
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Close()
        End If
    End Sub
End Class