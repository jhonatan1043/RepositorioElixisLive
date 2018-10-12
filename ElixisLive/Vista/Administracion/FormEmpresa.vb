﻿Public Class FormEmpresa
    Dim objEmpresa As Empresa
    Private Sub cargarObjeto()
        objEmpresa.identificacion = txtId.Text
        objEmpresa.nombre = TxtDescripcion.Text
        objEmpresa.dtParametro = dgvParametro.DataSource
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(txtId.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el nit de la Empresa!")
        ElseIf String.IsNullOrEmpty(TxtDescripcion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el nombre de la empresa!")
        Else
            resultado = True
        End If
        Return resultado
    End Function
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
        objEmpresa = New Empresa
        Try
            CheckForIllegalCrossThreadCalls = False
            params.Add(ElementoMenu.codigo)
            params.Add(SesionActual.idEmpresa)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoDGV(dgvParametro)
            Generales.diseñoGrillaParametros(dgvParametro)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(GbInform_D)
        Generales.limpiarControles(GbInform)
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvParametro.EndEdit()
        If validarCampos() = True Then
            Try
                cargarObjeto()
                EmpresaBLL.guardar(objEmpresa)
                Generales.subirArchivoFTP(objEmpresa)
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btNuevo.Enabled = True
                btEditar.Enabled = True
                btBuscar.Enabled = True
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.habilitarControles(Me)
            Generales.deshabilitarBotones(ToolStrip1)
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objEmpresa.sqlAnular) = True Then
                    Generales.limpiarControles(GbInform_D)
                    Generales.limpiarControles(GbInform)
                    Generales.deshabilitarBotones(ToolStrip1)
                    btNuevo.Enabled = True
                    btBuscar.Enabled = True
                    EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add("")
        Generales.buscarElemento(objEmpresa.sqlConsulta,
                                   params,
                                   AddressOf cargarInfomacion,
                                   "Busqueda de Empresa",
                                   False, True)
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objEmpresa.codigo = pcodigo
        params.Add(pcodigo)
        dfila = Generales.cargarItem(objEmpresa.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                txtId.Text = dfila.Item("Nit")
                TxtDescripcion.Text = dfila.Item("Nombre")
                params.Add(ElementoMenu.codigo)
                Generales.llenardgv(objEmpresa.sqlCargarDetalle, dgvParametro, params)
                Generales.diseñoDGV(dgvParametro)
                Generales.diseñoGrillaParametros(dgvParametro)
                controlVerificarControl()
            End If
            Generales.deshabilitarBotones(ToolStrip1)
            btEditar.Enabled = True
            btAnular.Enabled = True
            btNuevo.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub controlVerificarControl()
        For posicion = 0 To dgvParametro.Rows.Count - 1
            Generales.consultarTipoControl(dgvParametro, posicion)
        Next
    End Sub
End Class