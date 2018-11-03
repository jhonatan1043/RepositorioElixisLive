Public Class FormPerfil
    Dim objPerfil As Perfil
    Private Sub FormPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objPerfil = New Perfil
        principalBLL.cargarMenu(arbolmenu)
        listarPerfiles()
        validarCampoGrilla()
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btNuevo.Enabled = True
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        objPerfil.codigo = Nothing
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub
    Private Sub cargarInfomacion(pCodigo As Integer)
        Dim params As New List(Of String)
        objPerfil.codigo = pCodigo
        params.Add(pCodigo)
        Generales.llenarTabla("[SP_ADMIN_PERFIL_DETALLE]", params, objPerfil.dtRegistro)
        chequearArbol()
        Generales.habilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btRegistrar.Enabled = False
    End Sub
    Private Sub chequearArbol()
        For Each nodo As TreeNode In arbolmenu.Nodes
            If IsNothing(nodo.Parent) Then
                For posicion = 0 To objPerfil.dtRegistro.Rows.Count - 1
                    If nodo.Name = objPerfil.dtRegistro.Rows(posicion).Item("Codigo_Menu") Then
                        nodo.Checked = True
                    End If
                Next
            End If
        Next
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try
            cargarObjeto()
            PerfilBLL.guardarPerfil(objPerfil)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btAnular.Enabled = True
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
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
            btNuevo.Enabled = True
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL("" & objPerfil.codigo) = True Then
                    Generales.limpiarControles(Me)
                    Generales.deshabilitarBotones(ToolStrip1)
                    objPerfil.codigo = Nothing
                    btNuevo.Enabled = True
                    EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub cargarObjeto()
        objPerfil.nombre = TextNombre.Text
        For Each nodo As TreeNode In arbolmenu.Nodes
            If IsNothing(nodo.Parent) Then
                If nodo.Checked = True Then
                    objPerfil.dtPerfil.Rows.Add()
                    objPerfil.dtRegistro.Rows(objPerfil.dtPerfil.Rows.Count - 1).Item("Codigo_Menu") = nodo.Name
                End If
            End If
        Next
    End Sub

    Private Sub dgvFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFactura.CellClick
        If btRegistrar.Enabled = True Then Exit Sub
        If dgvFactura.Rows.Count > 0 Then
            TextNombre.Text = dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("Descripción").Value
            cargarInfomacion(dgvFactura.Rows(dgvFactura.CurrentCell.RowIndex).Cells("Codigo").Value)
        End If
    End Sub
    Private Sub listarPerfiles()
        Dim params As New List(Of String)
        params.Add(txtBuscar.Text)
        Generales.llenardgv(objPerfil.sqlCargar, dgvFactura, params)
    End Sub
    Private Sub validarCampoGrilla()
        With dgvFactura
            .ReadOnly = True
            .Columns("Codigo").Visible = False
            .Columns("Descripción").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub
    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            listarPerfiles()
        End If
    End Sub
End Class