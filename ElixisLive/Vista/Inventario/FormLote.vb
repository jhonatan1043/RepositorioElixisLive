Public Class FormLote
    Dim objLote As Lote
    Public Property objproducto As UbicacionProducto
    Public Property codigoProducto As Integer
    Public Property cantidadExistente As Integer
    Public Property nombreProducto As String
    Private Sub FormLote_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.cargarPermiso(Me)
        objLote = New Lote
        lbNombre.Text = nombreProducto
        validarGrilla()
        valoresIniciales()
        'establecerPosicion()
    End Sub
    'Private Sub establecerPosicion()
    '    Dim x As Integer
    '    Dim y As Integer
    '    x = Screen.PrimaryScreen.WorkingArea.Width - 880
    '    y = Screen.PrimaryScreen.WorkingArea.Height - 590
    '    Me.Location = New Point(x, y)
    'End Sub
    Private Sub dgAgregar_Click(sender As Object, e As EventArgs) Handles dgAgregar.Click
        objLote.dtLote.Rows.Add()
        objLote.dtLote.Rows(objLote.dtLote.Rows.Count - 1).Item("Codigo") = codigoProducto
    End Sub
    Private Sub dgvLote_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLote.CellClick
        If dgvLote.Rows(dgvLote.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True And objLote.dtLote.Rows.Count > 1 Then
            objLote.dtLote.Rows.RemoveAt(dgvLote.CurrentCell.RowIndex)
        End If
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Dim cantidades As Integer
        Dim bandera As Boolean
        dgvLote.EndEdit()
        objLote.dtLote.AcceptChanges()
        Try
            cantidades = objLote.dtLote.Compute("SUM(cantidad)", "")
            If objLote.dtLote.Select("[Registro] NOT IS NULL AND [Cantidad] = 0").Count > 0 Then
                EstiloMensajes.mostrarMensajeAdvertencia("Hay lotes con cantidades en 0")
            ElseIf cantidadExistente < cantidades
                EstiloMensajes.mostrarMensajeAdvertencia("la cantidad ingresada no puede ser mayor a la existente")
            Else
                bandera = LoteBLL.verificarTabla(objproducto, codigoProducto)
                If bandera = True Then
                    objproducto.dtSetLote.Tables.Remove(CStr(codigoProducto))
                End If

                For posicion = 0 To objLote.dtLote.Rows.Count - 1
                    objLote.dtLote.Rows(posicion).Item("Cantidad_Actual") = objLote.dtLote.Rows(posicion).Item("Cantidad")
                Next

                objLote.dtLote.AcceptChanges()
                objproducto.dtSetLote.Tables.Add(objLote.dtLote)
                Close()
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub valoresIniciales()
        Dim bandera As Boolean
        Try
            bandera = LoteBLL.verificarTabla(objproducto, codigoProducto)
            If bandera = True Then
                objLote.dtLote = objproducto.dtSetLote.Tables(CStr(codigoProducto)).Copy()
                dgvLote.DataSource = objLote.dtLote
            Else
                objLote.dtLote.TableName = codigoProducto
                dgvLote.DataSource = objLote.dtLote
                dgvLote.AutoGenerateColumns = False
                objLote.dtLote.Rows.Add()
                objLote.dtLote.Rows(objLote.dtLote.Rows.Count - 1).Item("Codigo") = codigoProducto
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Close()
        End If
    End Sub
    Private Sub validarGrilla()
        With dgvLote
            .ReadOnly = False
            .Columns("dgCodigo").DataPropertyName = "Codigo"
            .Columns("dgNombre").DataPropertyName = "Registro"
            .Columns("dgCantidad").DataPropertyName = "Cantidad"
            .Columns("dgCantidadAct").DataPropertyName = "Cantidad_Actual"
            .Columns("dgFechaLote").DataPropertyName = "FechaLote"
            .Columns("dgFechaVencimiento").DataPropertyName = "FechaVencimiento"
            .Columns("dgUbicacion").DataPropertyName = "Ubicacion_Lote"
            .Columns("dgCantidadAct").ReadOnly = True
        End With
    End Sub
    Private Sub dgvLote_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvLote.EditingControlShowing
        If dgvLote.Rows(dgvLote.CurrentCell.RowIndex).Cells("dgNombre").Selected = True OrElse
            dgvLote.Rows(dgvLote.CurrentCell.RowIndex).Cells("dgUbicacion").Selected = True Then
            AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarAlfanumerico
        Else
        AddHandler e.Control.KeyPress, AddressOf ValidacionDigitacion.validarValoresNumericos
        End If
    End Sub
End Class
