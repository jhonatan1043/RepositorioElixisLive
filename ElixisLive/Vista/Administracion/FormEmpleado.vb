﻿Public Class FormEmpleado
    Dim objEmpleado As Empleado
    Private Sub cargarRegistro()
        Dim params As New List(Of String)
        params.Add(txtBuscar.Text)
        params.Add(SesionActual.idEmpresa)
        Try
            Generales.llenardgv(objEmpleado.sqlConsulta, dgRegistro, params)
            objEmpleado.dtRegistro = dgRegistro.DataSource
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarObjeto()
        Dim almMemoria As System.IO.MemoryStream = Nothing
        If Not IsNothing(pictImagen.Image) Then
            almMemoria = New System.IO.MemoryStream
            pictImagen.Image.Save(almMemoria, Imaging.ImageFormat.Png)
        End If
        objEmpleado.identificacion = txtId.Text
        objEmpleado.nombre = TxtDescripcion.Text
        objEmpleado.foto = If(IsNothing(almMemoria), Nothing, almMemoria.GetBuffer())
        objEmpleado.dtParametro = dgvParametro.DataSource
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(txtId.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe ingresar el nit de la empresa!")
        ElseIf String.IsNullOrEmpty(TxtDescripcion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe ingresar el nombre de la empresa!")
        Else
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarRegistro()
        End If
    End Sub
    Private Sub dgvParametro_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametro.CellEnter
        If btRegistrar.Enabled = False Then Exit Sub
        Try
            Generales.consultarTipoControl(dgvParametro, dgvParametro.CurrentCell.RowIndex)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objEmpleado = New Empleado
        Try
            params.Add(ElementoMenu.codigo)
            params.Add(SesionActual.idEmpresa)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoGrillaParametro(dgvParametro)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(GbInform_D)
        Generales.limpiarControles(GbInform)
        pictImagen.Image = Nothing
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
        txtBuscar.ReadOnly = True
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvParametro.EndEdit()
        If validarCampos() = True Then
            cargarObjeto()
            'EmpresaBLL.guardar(objEmpleado)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            cargarRegistro()
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            btEditar.Enabled = True
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.habilitarControles(Me)
            txtBuscar.ReadOnly = True
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
            txtBuscar.ReadOnly = True
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(GbInform_D)
            Generales.limpiarControles(GbInform)
            pictImagen.Image = Nothing
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
        End If
    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            If Generales.ejecutarSQL(objEmpleado.sqlAnular) = True Then
                Generales.limpiarControles(GbInform_D)
                Generales.limpiarControles(GbInform)
                Generales.deshabilitarBotones(ToolStrip1)
                pictImagen.Image = Nothing
                cargarRegistro()
                btNuevo.Enabled = True
                EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
            End If
        End If
    End Sub
    Private Sub btExaminar_Click(sender As Object, e As EventArgs) Handles btExaminar.Click
        Dim openDialog As New OpenFileDialog
        Try
            Generales.subirimagen(pictImagen, openDialog)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
End Class