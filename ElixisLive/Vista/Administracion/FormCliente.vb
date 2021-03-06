﻿Public Class FormCliente
    Dim objCliente As Cliente
    Dim bdNavegador As New BindingSource
    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.asignarPermiso(Me)
        objCliente = New Cliente
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        btEditar.Enabled = True
        cargarClientes()

    End Sub
    Private Sub validarGrilla()
        With dgvCliente
            .Columns("dgCodigo").DataPropertyName = "Codigo"
            .Columns("dgNombre").DataPropertyName = "Nombre"
            .Columns("dgDescuento").DataPropertyName = "Descuento"
            .Columns("dgFechaD").DataPropertyName = "Fecha_Inicio"
            .Columns("dgFechaDF").DataPropertyName = "Fecha_Fin"
            .AutoGenerateColumns = False
            .DataSource = objCliente.dtCliente
        End With
    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgvCliente
            .ReadOnly = False
            .Columns("dgCodigo").ReadOnly = True
            .Columns("dgNombre").ReadOnly = True
            .Columns("dgDescuento").ReadOnly = True
            .Columns("dgFechaD").ReadOnly = True
            .Columns("dgFechaDF").ReadOnly = True
        End With
        If Estado = True Then
            With dgvCliente
                .Columns("dgDescuento").ReadOnly = False
                .Columns("dgFechaD").ReadOnly = False
                .Columns("dgFechaDF").ReadOnly = False
            End With
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            validarEdicionGrilla(Constantes.EDITABLE)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarControles(Me)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.limpiarControles(Me)
            btEditar.Enabled = True
        End If
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try
            dgvCliente.EndEdit()
            ClienteBLL.guardar(objCliente)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btEditar.Enabled = True
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            bdNavegador.Filter = "Nombre Like '%" & txtBuscar.Text & "%'"
        End If
    End Sub
    Private Sub cargarClientes()
        Try
            Generales.llenarTabla(objCliente.sqlConsulta, Nothing, objCliente.dtCliente)
            dgvCliente.DataSource = objCliente.dtCliente
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Sub FormProductoUbicacion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
End Class