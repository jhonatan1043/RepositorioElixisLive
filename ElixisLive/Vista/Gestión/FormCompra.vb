﻿Public Class FormCompra
    Dim objCompra As Compra
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FormCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCompra = New Compra
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btNuevo.Enabled = True
        btBuscar.Enabled = True
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.deshabilitarControles(GpDatos)
        Generales.limpiarControles(Me)
        objCompra.codigo = Nothing
        objCompra.dtCompra.Rows.Add()
        validarEdicionGrilla(Constantes.EDITABLE)
        btBuscarProveedor.Enabled = True
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub
    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento(objCompra.sqlConsulta,
                                   params,
                                   AddressOf cargarCompra,
                                   Titulo.BUSQUEDA_COMPRA,
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarCompra(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dFila As DataRow
        Try
            params.Add(pCodigo)
            objCompra.codigo = pCodigo
            dFila = Generales.cargarItem(objCompra.sqlCargar, params)
            TextIdentificacion.Text = dFila("Identificacion")
            TextNombre.Text = dFila("Nombre")
            txtTelefono.Text = dFila("Telefono")
            txtNumeroFatura.Text = dFila("Numero_Factura")
            dtFecha.Value = dFila("Fecha_Compra")
            Generales.llenarTabla(objCompra.sqlCargarDetalle, params, objCompra.dtCompra)
            dgvFactura.DataSource = objCompra.dtCompra
            calcularTotales()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Generales.habilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btRegistrar.Enabled = False
        btCancelar.Enabled = False
    End Sub
    Private Sub cargarObjeto()
        objCompra.numeroFactura = txtNumeroFatura.Text
        objCompra.fechaCompra = Format(dtFecha.Value, Constantes.FORMATO_FECHA_HORA)
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try
            dgvFactura.EndEdit()
            cargarObjeto()
            CompraBLL.guardarCompra(objCompra)
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            Generales.deshabilitarControles(GpDatos)
            validarEdicionGrilla(Constantes.EDITABLE)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            validarEdicionGrilla(Constantes.NO_EDITABLE)
            objCompra.codigo = Nothing
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objCompra.sqlAnular & objCompra.codigo) = True Then
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
    Private Sub dgvFactura_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFactura.CellDoubleClick
        Dim params As New List(Of String)
        params.Add(String.Empty)
        If TextIdentificacion.Text <> String.Empty Then
            Try
                If btRegistrar.Enabled = False Then Exit Sub
                If (dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgCodigo").Selected = True _
                    Or dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgDescripcion").Selected = True) Then
                    Generales.busquedaItems(Sentencias.PRODUCTO_CONSULTAR,
                                              params,
                                              Titulo.BUSQUEDA_PRODUCTO,
                                              dgvFactura,
                                              objCompra.dtCompra,
                                              0,
                                              1,
                                              0,
                                              0,
                                              True)
                ElseIf dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True _
                    And objCompra.dtCompra.Rows(dgvFactura.CurrentCell.RowIndex).Item(0).ToString <> "" Then
                    objCompra.dtCompra.Rows.RemoveAt(e.RowIndex)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub dgvFactura_CellFormatting(sender As System.Object, e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvFactura.CellFormatting
        If e.ColumnIndex = 4 Or e.ColumnIndex = 5 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), Constantes.FORMATO_MONEDA)
            Else
                e.Value = Format(Val(e.Value), Constantes.FORMATO_MONEDA)
            End If
        End If
    End Sub
    Private Sub dgvFactura_Enter(sender As Object, e As EventArgs) Handles dgvFactura.CellEnter
        If dgvFactura.RowCount >= 1 Then
            calcularTotales()
            For indice = 0 To dgvFactura.RowCount - 1
                dgvFactura.Rows(indice).Cells("dgTotal").Value = dgvFactura.Rows(indice).Cells("dgValor").Value * dgvFactura.Rows(indice).Cells("dgCantidad").Value
            Next
        End If
    End Sub
    Private Sub btBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btBuscarProveedor.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento(Sentencias.PROVEEDOR_ADMIN_CONSULTAR,
                                     params,
                                     AddressOf cargarProveedor,
                                     Titulo.BUSQUEDA_PROVEEDOR,
                                     True,
                                     True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarProveedor(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objCompra.codigoPersona = pCodigo
        params.Add(objCompra.codigoPersona)
        Try
            dfila = Generales.cargarItem(Sentencias.PROVEEDOR_ADMIN_CARGAR, params)
            TextIdentificacion.Text = dfila("Identificacion")
            txtTelefono.Text = If(IsDBNull(dfila("Telefono")), dfila("Celular"), dfila("Telefono"))
            TextNombre.Text = dfila("Nombre")
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub validarGrilla()
        With dgvFactura
            '----------- Asociar datatable con grilla
            .Columns("dgCodigo").DataPropertyName = "Codigo"
            .Columns("dgDescripcion").DataPropertyName = "Descripcion"
            .Columns("dgValor").DataPropertyName = "valor"
            .Columns("dgCantidad").DataPropertyName = "Cantidad"
            .Columns("dgTotal").DataPropertyName = "Total"
            '------------------------------------------------------
            .Columns("dgDescripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("dgValor").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgCantidad").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("dgTotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .DataSource = objCompra.dtCompra
            .AutoGenerateColumns = False
        End With
    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgvFactura
            .ReadOnly = False
            .Columns("dgDescripcion").ReadOnly = True
            .Columns("dgValor").ReadOnly = True
            .Columns("dgCantidad").ReadOnly = True
            .Columns("dgTotal").ReadOnly = True

        End With
        If Estado = True Then
            With dgvFactura
                .Columns("dgCantidad").ReadOnly = False
                .Columns("dgValor").ReadOnly = False
            End With
        End If
    End Sub
    Private Sub calcularTotales()
        dgvFactura.EndEdit()
        Try

            Dim cantidadArticulos,
                valorTotal As Double

            If dgvFactura.Rows.Count >= 1 Then
                valorTotal = objCompra.dtCompra.Compute("SUM(Total)", "")
                cantidadArticulos = objCompra.dtCompra.Compute("SUM(Cantidad)", "")
            Else
                cantidadArticulos = Constantes.SIN_VALOR_NUMERICO
                valorTotal = Constantes.SIN_VALOR_NUMERICO
            End If

            txtCantidadArticulos.Text = cantidadArticulos
            txtValorTotal.Text = CDbl(valorTotal).ToString(Constantes.FORMATO_MONEDA)

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub dgvFactura_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvFactura.DataError
        If e.ColumnIndex = 2 OrElse e.ColumnIndex = 3 Then
            EstiloMensajes.mostrarMensajeError(MensajeSistema.INGRESAR_VALOR_VALIDO)
        End If
    End Sub
End Class