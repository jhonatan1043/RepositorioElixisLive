﻿Public Class FormProducto
    Dim objProducto As producto
    Private Sub FormBaseProductivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objProducto = New producto
        Try
            params.Add(ElementoMenu.codigo)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoGrillaParametro(dgvParametro)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dgvParametro_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametro.CellEnter
        If btRegistrar.Enabled = False Then Exit Sub
        Try
            Generales.consultarTipoControl(dgvParametro)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cargarObjeto()
        Dim almMemoria As System.IO.MemoryStream = Nothing
        If Not IsNothing(pictImagen.Image) Then
            almMemoria = New System.IO.MemoryStream
            pictImagen.Image.Save(almMemoria, Imaging.ImageFormat.Png)
        End If
        objProducto.codigoProducto = txtCodigo.Text
        objProducto.nombre = TxtDescripcion.Text
        objProducto.foto = If(IsNothing(almMemoria), Nothing, almMemoria.GetBuffer())
        objProducto.dtParametro = dgvParametro.DataSource
    End Sub
    Private Sub btExaminar_Click(sender As Object, e As EventArgs) Handles btExaminar.Click
        Dim openImag As New OpenFileDialog
        Generales.subirimagen(pictImagen, openImag)
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
        txtBuscar.ReadOnly = True
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(TxtDescripcion.Text) Then
            MsgBox("¡ Favor digitar el nombre del registro !", MsgBoxStyle.Exclamation)
        Else
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvParametro.EndEdit()

        If validarCampos() = True Then
            If MsgBox(MensajeSistema.REGISTRAR, 32 + 1, "Registrar") = 1 Then
                cargarObjeto()
                ProductoBLL.guardar(objProducto)
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                txtCodigo.Text = objProducto.codigoProducto
                txtBuscar.ReadOnly = False
                btNuevo.Enabled = True
                btEditar.Enabled = True
            End If
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If MsgBox(MensajeSistema.CANCELAR, 32 + 1, "Cancelar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            txtBuscar.ReadOnly = False
            btNuevo.Enabled = True
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If MsgBox(MensajeSistema.EDITAR, 32 + 1, "Editar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            txtBuscar.ReadOnly = True
            btCancelar.Enabled = True
            txtBuscar.ReadOnly = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click

    End Sub

End Class
