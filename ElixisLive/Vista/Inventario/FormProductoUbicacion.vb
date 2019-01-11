﻿Public Class FormProductoUbicacion
    Dim objUbicacionProducto As UbicacionProducto
    Dim bdNavegador As New BindingSource
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objUbicacionProducto = New UbicacionProducto
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btEditar.Enabled = True
    End Sub
    Private Sub validarGrilla()
        With dgvProducto
            .Columns("dgCodigo").DataPropertyName = "Codigo"
            .Columns("dgNombre").DataPropertyName = "Nombre"
            .Columns("dgCantidad").DataPropertyName = "Cantidad"
            .Columns("dgUbicacion").DataPropertyName = "Ubicacion"
            .AutoGenerateColumns = False
            .DataSource = objUbicacionProducto.dtProducto
        End With
    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgvProducto
            .ReadOnly = False
            .Columns("dgCodigo").ReadOnly = True
            .Columns("dgNombre").ReadOnly = True
            .Columns("dgCantidad").ReadOnly = True
            .Columns("dgUbicacion").ReadOnly = True
        End With
        If Estado = True Then
            With dgvProducto
                .Columns("dgUbicacion").ReadOnly = False
            End With
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            validarEdicionGrilla(Constantes.EDITABLE)
            cargarProductos()
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarControles(Me)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.limpiarControles(Me)
            objUbicacionProducto.dtSetLote.Clear()
            btEditar.Enabled = True
        End If
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try
            dgvProducto.EndEdit()
            ProductoUbicacionBLL.guardar(objUbicacionProducto)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btEditar.Enabled = True
            objUbicacionProducto.dtSetLote.Clear()
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            bdNavegador.Filter = "Nombre Like '%" & txtBuscar.Text & "%'"
            ProductoUbicacionBLL.varificargrillaProducto(objUbicacionProducto, dgvProducto)
        End If
    End Sub
    Private Sub cargarProductos()
        Try
            Generales.llenarTabla(objUbicacionProducto.sqlConsulta, Nothing, objUbicacionProducto.dtProducto)
            bdNavegador.DataSource = objUbicacionProducto.dtProducto
            dgvProducto.DataSource = bdNavegador.DataSource
            creacionLote()
            ProductoUbicacionBLL.varificargrillaProducto(objUbicacionProducto, dgvProducto)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub dgvProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducto.CellClick
        If e.ColumnIndex = 4 Then
            Dim formLote As New FormLote
            formLote.codigoProducto = objUbicacionProducto.dtProducto.Rows(dgvProducto.CurrentCell.RowIndex).Item("Codigo")
            formLote.cantidadExistente = objUbicacionProducto.dtProducto.Rows(dgvProducto.CurrentCell.RowIndex).Item("Cantidad")
            formLote.nombreProducto = objUbicacionProducto.dtProducto.Rows(dgvProducto.CurrentCell.RowIndex).Item("Nombre")
            formLote.objproducto = objUbicacionProducto
            formLote.ShowDialog()
            ProductoUbicacionBLL.varificargrillaProducto(objUbicacionProducto, dgvProducto)
        End If
    End Sub
    Private Sub creacionLote()
        Dim params As New List(Of String)
        Dim dt As DataTable
        For posicion = 0 To objUbicacionProducto.dtProducto.Rows.Count - 1
            dt = New DataTable
            params.Clear()
            params.Add(objUbicacionProducto.dtProducto.Rows(posicion).Item("Codigo"))
            Generales.llenarTabla("[SP_INVEN_LOTE_CARGAR]", params, dt)
            If dt.Rows.Count > 0 Then
                dt.TableName = CStr(objUbicacionProducto.dtProducto.Rows(posicion).Item("Codigo"))
                objUbicacionProducto.dtSetLote.Tables.Add(dt)
            End If
        Next
    End Sub
End Class