Public Class FormGasto
    Private objConfig As Configuracion
    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objConfig = New Configuracion
        cargarConsultas()
        cargarRegistro()
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        txtFiltro.ReadOnly = False
        btNuevo.Enabled = True
    End Sub
    Private Sub cargarRegistro()
        Dim params As New List(Of String)
        params.Add(txtFiltro.Text)
        Generales.llenardgv(objConfig.sqlConsulta, dgRegistro, params)
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If MsgBox(MensajeSistema.CANCELAR, 32 + 1, "Cancelar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            txtFiltro.ReadOnly = False
            btNuevo.Enabled = True
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If MsgBox(MensajeSistema.EDITAR, 32 + 1, "Editar") = 1 Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            txtFiltro.ReadOnly = True
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If MsgBox(MensajeSistema.ANULAR, 32 + 1, "Anular") = 1 Then

        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        txtFiltro.ReadOnly = True
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub
    Private Function validaciones() As Boolean
        Dim badraResultado As Boolean
        If txtnombre.Text = String.Empty Then
            MsgBox("¡ Favor Registrar, algún valor valido. !", MsgBoxStyle.Exclamation)
        Else
            badraResultado = True
        End If
        Return badraResultado
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If MsgBox(MensajeSistema.REGISTRAR, 32 + 1, "Registrar") = 1 Then
            Try

                If validaciones() = True Then
                    cargarObjeto()
                    ConfigBLL.guardar(objConfig)
                    Generales.deshabilitarBotones(ToolStrip1)
                    Generales.deshabilitarControles(Me)
                    btNuevo.Enabled = True
                    btAnular.Enabled = True
                    txtFiltro.ReadOnly = False
                    txtcodigo.Text = objConfig.codigo
                    cargarRegistro()
                    MsgBox(MensajeSistema.REGISTRADO_CON_EXITO, MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub cargarObjeto()
        objConfig.codigo = If(String.IsNullOrEmpty(txtcodigo.Text), Nothing, txtcodigo.Text)
        objConfig.descripcion = txtnombre.Text.ToUpper
    End Sub
    Private Sub txtFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarRegistro()
        End If
    End Sub
    Private Sub cargarConsultas()
        objConfig.sqlConsulta = "SP_CONFI_GASTOS_CONSULTAR"
        objConfig.sqlAnular = ""
        objConfig.sqlGuardar = "SP_CONFI_GASTOS_CREAR"
    End Sub
End Class
