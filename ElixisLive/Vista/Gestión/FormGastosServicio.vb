Public Class FormGastosServicio
    Dim objGstoServicio As GastoServicio
    Private Sub FormGastosServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim respuesta As Integer = Generales.consultarPermiso(Name)
        If respuesta = Constantes.LECTURA_ESCRITURA Then
            Generales.mostrarLecturaEscritura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_LECTURA Then
            Generales.mostrarLectura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_ESCRITURA Then
            Generales.mostrarEscritura(ToolStrip1)
        Else
            Generales.ocultarBotones(ToolStrip1)
        End If
        objGstoServicio = New GastoServicio
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btNuevo.Enabled = True
        btBuscar.Enabled = True
    End Sub
    Private Sub FormPersona_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim respuesta As Integer = Generales.consultarPermiso(Name)
        If respuesta = Constantes.LECTURA_ESCRITURA Then
            Generales.mostrarLecturaEscritura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_LECTURA Then
            Generales.mostrarLectura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_ESCRITURA Then
            Generales.mostrarEscritura(ToolStrip1)
        Else
            Generales.ocultarBotones(ToolStrip1)
        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        btAgregar.Enabled = True
        objGstoServicio.codigo = Nothing
        objGstoServicio.dtGasto.Rows.Add()
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento(objGstoServicio.sqlConsulta,
                                     params,
                                     AddressOf cargarInformacion,
                                     Titulo.BUSQUEDA_GASTO_SERVICIO,
                                     True,
                                     True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvGastos.EndEdit()
        objGstoServicio.dtGasto.AcceptChanges()
        If objGstoServicio.dtGasto.Select("Justificacion IS NULL").Count > 0 Then
            EstiloMensajes.mostrarMensajeAdvertencia("Describa el servicio")
        ElseIf objGstoServicio.dtGasto.Select("Justificacion IS NOT NULL AND Valor = 0 ").Count > 0
            EstiloMensajes.mostrarMensajeAdvertencia("¡ Hay servicios sin valor !")
        Else
            objGstoServicio.fecha = dtFecha.Value
            GastoServicioBLL.guardar(objGstoServicio)
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            objGstoServicio.codigo = Nothing
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objGstoServicio.sqlAnular & objGstoServicio.codigo) = True Then
                    Generales.deshabilitarBotones(ToolStrip1)
                    Generales.limpiarControles(Me)
                    btNuevo.Enabled = True
                    btBuscar.Enabled = True
                    EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub dgvGastos_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvGastos.CellFormatting
        If dgvGastos.Rows.Count > 0 Then
            Try
                If e.ColumnIndex = 2 Then
                    If IsDBNull(e.Value) Then
                        e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
                    Else
                        e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
                    End If
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(ex.Message)
            End Try
        End If
    End Sub
    Private Sub validarGrilla()
        With dgvGastos
            .Columns("dgDescripcion").DataPropertyName = "Justificacion"
            .Columns("dgValor").DataPropertyName = "Valor"
            .DataSource = objGstoServicio.dtGasto
        End With
    End Sub
    Private Sub dgvGastos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGastos.CellClick
        If objGstoServicio.dtGasto.Rows.Count > 0 Then
            If dgvGastos.Rows(dgvGastos.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True _
                And Not IsNothing(dgvGastos.Rows(dgvGastos.CurrentCell.RowIndex).Cells("dgDescripcion").Value) Then
                objGstoServicio.dtGasto.Rows.RemoveAt(dgvGastos.CurrentCell.RowIndex)
            End If
        End If
    End Sub
    Private Sub dgAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        objGstoServicio.dtGasto.Rows.Add()
    End Sub
    Private Sub cargarInformacion(pCodigo As String)
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(pCodigo)
        objGstoServicio.codigo = pCodigo
        dRows = Generales.cargarItem(objGstoServicio.sqlCargar, params)
        dtFecha.Value = Format(dRows("Fecha"), "MMMM/yyyy")
        Generales.llenarTabla(objGstoServicio.sqlCargarDetalle, params, objGstoServicio.dtGasto)
        dgvGastos.DataSource = objGstoServicio.dtGasto
        Generales.habilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btCancelar.Enabled = False
        btRegistrar.Enabled = False
    End Sub
End Class