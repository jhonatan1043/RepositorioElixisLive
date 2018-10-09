Public Class FormServicio
    Private objConfig As Configuracion
    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objConfig = New Configuracion
        cargarConsultas()
        cargarRegistro()
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        visibleConfig()
        btNuevo.Enabled = True
    End Sub
    Private Sub visibleConfig()
        btBuscar.Visible = False
        ralla1.Visible = False
    End Sub
    Private Sub cargarRegistro()
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(SesionActual.idEmpresa)
        Generales.llenardgv(objConfig.sqlConsulta, dgRegistro, params)
        diseñoGrillaConfig()
    End Sub
    Private Sub diseñoGrillaConfig()
        With dgRegistro
            .Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub
    Private Sub dgRegistro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRegistro.CellClick
        If btRegistrar.Enabled = True Then Exit Sub
        If dgRegistro.RowCount > 0 Then
            txtcodigo.Text = dgRegistro.Rows(dgRegistro.CurrentCell.RowIndex).Cells(0).Value
            txtnombre.Text = dgRegistro.Rows(dgRegistro.CurrentCell.RowIndex).Cells(1).Value
            Generales.deshabilitarBotones(ToolStrip1)
            btEditar.Enabled = True
            btNuevo.Enabled = True
            btAnular.Enabled = True
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            btNuevo.Enabled = True
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
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objConfig.sqlAnular & txtcodigo.Text) = True Then
                    Generales.limpiarControles(Gbdatos)
                    Generales.deshabilitarBotones(ToolStrip1)
                    cargarRegistro()
                    btNuevo.Enabled = True
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Gbdatos)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub
    Private Function validaciones() As Boolean
        Dim badraResultado As Boolean
        If txtnombre.Text = String.Empty Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe Registrar un valor valido!")
        Else
            badraResultado = True
        End If
        Return badraResultado
    End Function
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try
            If validaciones() = True Then
                cargarObjeto()
                ConfigBLL.guardar(objConfig)
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btNuevo.Enabled = True
                btAnular.Enabled = True
                btEditar.Enabled = True
                txtcodigo.Text = objConfig.codigo
                cargarRegistro()
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarObjeto()
        objConfig.codigo = If(String.IsNullOrEmpty(txtcodigo.Text), Nothing, txtcodigo.Text)
        objConfig.descripcion = txtnombre.Text.ToLower
    End Sub

    Private Sub cargarConsultas()
        objConfig.sqlConsulta = "SP_CONFI_SERVICIO_CONSULTAR"
        objConfig.sqlAnular = "[SP_CONFI_SERVICIO_ANULADO] "
        objConfig.sqlGuardar = "SP_CONFI_SERVICIO_CREAR"
    End Sub
End Class
