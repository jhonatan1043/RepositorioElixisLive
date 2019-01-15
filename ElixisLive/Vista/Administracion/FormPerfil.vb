Imports System.Data.SqlClient
Public Class FormPerfil
    Dim objPerfil As Perfil
    Dim sw, sw2, sw3 As Boolean
    Private dsDatos As DataSet
    Private objPerfilBll As New PerfilBLL
    Dim fprincipal As New FormPrincipal
    Private Sub FormPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        objPerfil = New Perfil
        listarPerfiles()
        validarCampoGrilla()
        Generales.deshabilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        txtBuscar.ReadOnly = False
        btNuevo.Enabled = True
        Generales.tabularConEnter(Me)
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        objPerfil.codigoPerfil = -1
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        cargarArbol()
        txtnombre.Focus()
    End Sub
    Private Sub cargarInfomacion(pCodigo As Integer)
        Dim params As New List(Of String)
        objPerfil.codigoPerfil = pCodigo
        params.Add(pCodigo)
        Generales.llenarTabla(Sentencias.ADMIN_PERFIL_DETALLE, params, objPerfil.dtRegistro)
        cargarArbol()
        Generales.habilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btRegistrar.Enabled = False
        btCancelar.Enabled = False
    End Sub
    Public Sub cargarArbol()
        Dim nodo As TreeNode
        Dim drCuentaPadre As DataRow()

        arbolmenu.Enabled = True
        arbolmenu.Nodes.Clear()
        arbolmenu.ExpandAll()

        Try
            dsDatos = New DataSet
            CreaOpciones(dsDatos)
            objPerfilBll.cargarMenu(SesionActual.codigoSucursal, dsDatos)
            drCuentaPadre = dsDatos.Tables("Padre").Select()

            'Se recorren las cuentas Padre
            For Each drFila As DataRow In drCuentaPadre
                nodo = New TreeNode
                nodo.Name = drFila("Codigo_Menu").ToString()
                nodo.Text = drFila("Descripcion").ToString()
                If dsDatos.Tables("Perfil_Menu").Select("[Codigo_Menu]='" + nodo.Name.ToString + "'").Count = 1 Then
                    nodo.Checked = True
                Else
                    nodo.Checked = False
                End If
                arbolmenu.Nodes.Add(nodo)

                'Se recorren las cuentas hijas
                crearSubcuentas(nodo)
            Next

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try

        dsDatos.Dispose()

    End Sub
    Private Sub crearSubcuentas(ByRef nodoPade As TreeNode)
        Dim expr As String = "Codigo_Padre ='" & nodoPade.Name & "'"
        Dim subnodo As TreeNode

        Try
            Dim aDrFilas As DataRow()
            aDrFilas = dsDatos.Tables("Hijas").Select(expr, "Codigo_Menu")

            For Each drFila As DataRow In aDrFilas
                subnodo = New TreeNode
                subnodo.Name = drFila("Codigo_Menu").ToString()
                subnodo.Text = drFila("Descripcion").ToString()
                If dsDatos.Tables("Perfil_Menu").Select("[Codigo_Menu]='" + subnodo.Name.ToString + "'").Count = 1 Then
                    subnodo.Checked = True
                Else
                    subnodo.Checked = False
                End If
                nodoPade.Nodes.Add(subnodo)
                crearSubcuentas(subnodo)
            Next
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try

    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If txtnombre.Text.Length = 0 Then
            Me.ErrorIcono.SetError(txtnombre, "Debe ingresar un nombre")
        Else
            Try
                objPerfil.codigoPerfil = txtcodigo.Text
                objPerfil.nombre = txtnombre.Text
                objPerfil.guardarPerfil()
                txtcodigo.Text = objPerfil.codigoPerfil
                guardarPermisos()
                SesionActual.dtPermisos = fprincipal.cargarOpciones(SesionActual.codigoPerfil)
                Generales.deshabilitarControles(Me)
                Generales.habilitarBotones(Me.ToolStrip1)
                principalBLL.cargarMenu(FormPrincipal.arbolMenu)
                btRegistrar.Enabled = False
                btCancelar.Enabled = False
                arbolmenu.Enabled = False
                Me.ErrorIcono.SetError(txtnombre, Constantes.CADENA_VACIA)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
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
            btNuevo.Enabled = True
            ErrorIcono.SetError(txtnombre, "")
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL("" & objPerfil.codigoPerfil) = True Then
                    Generales.limpiarControles(Me)
                    Generales.deshabilitarBotones(ToolStrip1)
                    objPerfil.codigoPerfil = Nothing
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
        objPerfil.nombre = txtnombre.Text
        For Each nodo As TreeNode In arbolmenu.Nodes
            If IsNothing(nodo.Parent) Then
                If nodo.Checked = True Then
                    objPerfil.dtPerfil.Rows.Add()
                    objPerfil.dtRegistro.Rows(objPerfil.dtPerfil.Rows.Count - 1).Item("Codigo_Menu") = nodo.Name
                End If
            End If
        Next
    End Sub
    Private Sub guardarPermisos()
        Dim objConexio As New ConexionBD
        objConexio.conectar()
        Try
            Using consulta = New SqlCommand()
                consulta.Connection = objConexio.cnxbd
                consulta.CommandType = CommandType.StoredProcedure
                consulta.CommandText = "SP_PERFIL_MODULO_ELIMINAR"
                consulta.Parameters.Add(New SqlParameter("@Codigo_perfil", SqlDbType.Int)).Value = objPerfil.codigoPerfil
                consulta.ExecuteNonQuery()
                consulta.CommandText = "[SP_PERFIL_MODULO_ASIGNAR]"
                consulta.Parameters.Add(New SqlParameter("@tbl", SqlDbType.Structured)).Value = dsDatos.Tables("Perfil_Menu")
                consulta.ExecuteNonQuery()
                EstiloMensajes.mostrarMensajeExitoso((MensajeSistema.MODULO_ASIGNADO))
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        objConexio.desconectar()
    End Sub
    Private Sub CreaOpciones(ByRef dsDatos As DataSet)
        Dim objConexio As New ConexionBD
        Dim cadena As String
        objConexio.conectar()
        Try
            cadena = "EXEC [SP_ADMIN_PERFIL_CARGAR] " & objPerfil.codigoPerfil & "," & SesionActual.codigoSucursal & ""

            Using consulta = New SqlCommand(cadena, objConexio.cnxbd)
                Using daAdaptador = New SqlDataAdapter(consulta)
                    daAdaptador.Fill(dsDatos, "Perfil_Menu")
                End Using
            End Using

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        Finally
            objConexio.desconectar()
        End Try

    End Sub
    Private Sub dgvFactura_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametro.CellClick
        If dgvParametro.Rows.Count > 0 Then
            txtnombre.Text = dgvParametro.Rows(dgvParametro.CurrentCell.RowIndex).Cells("Descripción").Value
            cargarInfomacion(dgvParametro.Rows(dgvParametro.CurrentCell.RowIndex).Cells("Codigo").Value)
            txtcodigo.Text = dgvParametro.Rows(dgvParametro.CurrentCell.RowIndex).Cells("Codigo").Value
        End If
    End Sub
    Private Sub listarPerfiles()
        Dim params As New List(Of String)
        params.Add(txtBuscar.Text)
        Generales.llenardgv(objPerfil.sqlCargar, dgvParametro, params)
    End Sub
    Private Sub validarCampoGrilla()
        With dgvParametro
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
    Private Sub arbolmenu_AfterCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles arbolmenu.AfterCheck
        If e.Node.Checked = True Then
            If dsDatos.Tables("Perfil_Menu").Select("[Codigo_Menu]='" + e.Node.Name.ToString + "'").Count = 0 Then
                Dim dr As DataRow = dsDatos.Tables("Perfil_Menu").NewRow
                dr("Codigo_Menu") = e.Node.Name
                dr("Codigo_Perfil") = objPerfil.codigoPerfil
                dsDatos.Tables("Perfil_Menu").Rows.Add(dr)
            End If

        Else
            If dsDatos.Tables("Perfil_Menu").Select("[Codigo_Menu]='" + e.Node.Name.ToString + "'").Count > 0 Then
                Dim dr As DataRow() = dsDatos.Tables("Perfil_Menu").Select("[Codigo_Menu] like '" + e.Node.Name.ToString + "'")
                For Each adr In dr
                    dsDatos.Tables("Perfil_Menu").Rows.Remove(adr)
                Next
            End If
        End If

        'nodo principal por cada arbol
        If e.Node.Nodes.Count > 0 Then
            If Not IsNothing(e.Node.Parent) AndAlso e.Node.Parent.Checked = False AndAlso e.Node.Checked = True Then
                sw = True
                e.Node.Parent.Checked = True
                sw = False
                For i As Int32 = 0 To e.Node.Nodes.Count - 1
                    If e.Node.Checked = True And sw3 = False Then
                        sw2 = True
                        e.Node.Nodes.Item(i).Checked = True
                        sw2 = False
                    ElseIf e.Node.Checked = False And sw3 = False Then
                        sw2 = True
                        e.Node.Nodes.Item(i).Checked = False
                        sw2 = False
                    End If
                Next
            ElseIf Not IsNothing(e.Node.Parent) AndAlso e.Node.Parent.Checked = True AndAlso e.Node.Checked = False Then
                Dim con As Integer = 0
                For i As Int32 = 0 To e.Node.Parent.Nodes.Count - 1
                    If e.Node.Parent.Nodes.Item(i).Checked = True Then
                        con = con + 1
                    End If
                Next
                If con = 0 Then
                    sw = True
                    e.Node.Parent.Checked = False
                    sw = False
                End If
                For i As Int32 = 0 To e.Node.Nodes.Count - 1
                    If e.Node.Checked = True And sw = False Then
                        sw2 = True
                        e.Node.Nodes.Item(i).Checked = True
                        sw2 = False
                    ElseIf e.Node.Checked = False And sw = False Then
                        sw2 = True
                        e.Node.Nodes.Item(i).Checked = False
                        sw2 = False
                    End If
                Next
            Else
                For i As Int32 = 0 To e.Node.Nodes.Count - 1
                    If e.Node.Checked = True And sw = False And sw3 = False Then
                        sw2 = True
                        e.Node.Nodes.Item(i).Checked = True
                        sw2 = False
                    ElseIf e.Node.Checked = False And sw = False And sw3 = False Then
                        sw2 = True
                        e.Node.Nodes.Item(i).Checked = False
                        sw2 = False
                    End If
                Next

            End If


        ElseIf e.Node.Nodes.Count = 0 Then
            If IsNothing(e.Node.Parent) Then Exit Sub
            If e.Node.Parent.Checked = False And e.Node.Checked = True Then
                sw3 = True
                e.Node.Parent.Checked = True
                sw3 = False
            ElseIf e.Node.Parent.Checked = True And e.Node.Checked = False Then
                Dim con As Integer = 0
                For i As Int32 = 0 To e.Node.Parent.Nodes.Count - 1
                    If e.Node.Parent.Nodes.Item(i).Checked = True Then
                        con = con + 1
                    End If
                Next
                If con = 0 Then
                    sw3 = True
                    e.Node.Parent.Checked = False
                    sw3 = False
                End If
            End If
        End If

    End Sub
End Class