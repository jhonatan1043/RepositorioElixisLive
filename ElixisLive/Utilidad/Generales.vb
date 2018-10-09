Imports System.Data.SqlClient
Imports CnxElixisLiveBD
Imports System.Net
Public Class Generales
    Public Delegate Sub cargaInfoForm(ByVal codigo As String)
    Public Delegate Sub cargaInfoFormObj(ByVal fila As DataRow)
    Private Shared objConexion As New ConexionBD
    Public Shared Sub llenarTabla(ByVal consulta As String,
                                  ByVal params As List(Of String),
                                  ByVal dtTabla As DataTable,
                                  Optional pLimpiarDT As Boolean = True)

        Dim listaParams As String = Funciones.getParametros(params)
        objConexion.conectar()

        Try
            If pLimpiarDT Then dtTabla.Clear()
            Using daAdapter = New SqlDataAdapter(consulta & listaParams, objConexion.cnxbd)
                daAdapter.SelectCommand.CommandTimeout = 120
                daAdapter.Fill(dtTabla)
            End Using
            objConexion.desConectar()
        Catch ex As Exception
            Throw
        End Try

    End Sub
    Public Shared Sub buscarElemento(pConsultaSQL As String,
                                     plistaParam As List(Of String),
                                     pMetodo As cargaInfoForm,
                                     pTitulo As String,
                                     pOcultaCol As Boolean,
                                     Optional pBuscarDarEnter As Boolean = False
                                     )
        Dim vForm As New FormBusqueda()
        vForm.Text = pTitulo
        If Not IsNothing(plistaParam) Then
            vForm.consulta = pConsultaSQL & Funciones.getParametros(plistaParam)
        Else
            vForm.consulta = pConsultaSQL
        End If
        vForm.metodoCarga = pMetodo
        vForm.isOcultaCol = pOcultaCol
        vForm.buscarAlDarEnter = pBuscarDarEnter
        vForm.ShowDialog()
    End Sub
    Public Shared Function validarComillaSimple(ByVal busqueda As String) As String
        Return Replace(busqueda, "'", "")
    End Function
    Public Shared Function filaValida(ByVal fila As Integer) As Boolean
        If fila < 0 Then
            Return False
        End If
        Return True
    End Function
    Public Shared Sub limpiarControles(ByRef pFormulario As Object)
        Dim vFrtRB As Integer = pFormulario.Width + pFormulario.Height
        For Each vControl In pFormulario.Controls
            If (TypeOf vControl Is TextBox) OrElse (TypeOf vControl Is RichTextBox) Then
                vControl.Clear()
            ElseIf (TypeOf vControl Is MaskedTextBox) Then
                vControl.ResetText()
            ElseIf (TypeOf vControl Is ComboBox) Then
                If (vControl.Items.Count > 0) Then vControl.SelectedIndex = 0 _
                    Else vControl.Text = ""
            ElseIf (TypeOf vControl Is DateTimePicker) Then
                vControl.Value = DateTime.Now
            ElseIf (TypeOf vControl Is NumericUpDown) Then
                vControl.Value = vControl.Minimum
            ElseIf (TypeOf vControl Is CheckBox) Then
                vControl.Checked = False
            ElseIf (TypeOf vControl Is CheckedListBox) Then
                vControl.Items.Clear()
            ElseIf (TypeOf vControl Is RadioButton) Then
                Dim vCurrentRB = vControl.Location.X + vControl.Location.Y
                If (vFrtRB > vCurrentRB) Then
                    vFrtRB = vCurrentRB
                Else
                    vControl.Checked = False
                End If
            ElseIf (TypeOf vControl Is TreeView) Then
                vControl.Nodes.Clear()
            ElseIf (TypeOf vControl Is DataGridView) Then
                If vControl.name <> "dgvParametro" Then
                    vControl.EndEdit()
                    If TypeOf vControl.DataSource Is BindingSource Then
                        vControl.DataSource.DataSource.Clear()
                    Else
                        If vControl.Datasource IsNot Nothing Then
                            vControl.Datasource.Clear()
                        End If
                    End If
                    diseñoDGV(vControl)
                Else
                    limpiarGrillaParametro(vControl)
                End If
            Else
                ' mira a ve si es un contenedor
                limpiarControles(vControl)
            End If
        Next
    End Sub
    Private Shared Sub limpiarGrillaParametro(dgv As DataGridView)
        For posicion = 0 To dgv.Rows.Count - 1
            dgv.Rows(posicion).Cells("Datos").Value = Nothing
        Next
    End Sub
    Public Shared Sub diseñoDGV(ByRef dgv As DataGridView)
        dgv.BackgroundColor = Color.White
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.ForeColor = Color.Black
        dgv.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.Gainsboro
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Nothing
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Nothing
        dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Nothing
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA, 9)
    End Sub
    Public Shared Sub cargarForm(ByVal form As System.Windows.Forms.Form)
        FormPrincipal.Cursor = Cursors.WaitCursor
        form.MdiParent = FormPrincipal
        Generales.limpiarControles(form)
        form.Show()
        form.Focus()
        If form.WindowState = FormWindowState.Minimized Then
            form.WindowState = FormWindowState.Normal
        End If
        FormPrincipal.Cursor = Cursors.Default
    End Sub
    Public Shared Sub llenardgv(ByVal consulta As String,
                                 ByVal dgdgv As DataGridView,
                                 ByVal params As List(Of String))

        Dim listaParams As String = Funciones.getParametros(params)
        Dim dtTabla As New DataTable

        Try
            objConexion.conectar()
            Using daAdapter = New SqlDataAdapter(consulta & listaParams, objConexion.cnxbd)
                daAdapter.Fill(dtTabla)
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        objConexion.desConectar()
        dgdgv.DataSource = dtTabla
        'dgdgv.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)

    End Sub
    Public Shared Function cargarItem(ByVal consulta As String) As DataRow
        Dim dtTabla As New DataTable
        Try
            objConexion.conectar()
            Using daAdapter = New SqlDataAdapter(consulta, objConexion.cnxbd)
                daAdapter.Fill(dtTabla)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        If dtTabla.Rows.Count > 0 Then
            Return dtTabla.Rows(0)
        Else
            Return Nothing
        End If
        objConexion.desConectar()
    End Function
    Public Shared Function cargarItem(ByVal consulta As String,
                                  ByVal params As List(Of String)) As DataRow

        Dim listaParams As String = Funciones.getParametros(params)
        Dim dtTabla As New DataTable
        Try
            objConexion.conectar()

            Using daAdapter = New SqlDataAdapter(consulta & listaParams, objConexion.cnxbd)
                daAdapter.Fill(dtTabla)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        objConexion.desConectar()
        If dtTabla.Rows.Count > 0 Then
            Return dtTabla.Rows(0)
        Else
            Return Nothing
        End If
    End Function
    Public Shared Function llenarTabla(ByVal consulta As String,
                                   ByVal params As List(Of SqlParameter)) As DataTable
        Dim dtTabla As New DataTable
        Try
            objConexion.conectar()

            Using dbCommand As New SqlCommand
                dbCommand.Connection = objConexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = consulta
                For Each param As SqlParameter In params
                    If param.Value = Nothing Then
                        param.Value = DBNull.Value
                    End If
                    dbCommand.Parameters.Add(param)
                Next
                Using daAdapter = New SqlDataAdapter(dbCommand)
                    daAdapter.Fill(dtTabla)
                End Using
            End Using
        Catch ex As Exception
            Throw
        End Try
        objConexion.desConectar()
        Return dtTabla
    End Function
    Public Shared Sub deshabilitarControles(ByRef pElemento As Object)
        Dim vItem As Object
        For Each vItem In pElemento.Controls
            If (TypeOf vItem Is TextBox) Or (TypeOf vItem Is RichTextBox) Or (TypeOf vItem Is MaskedTextBox) Or (TypeOf vItem Is DataGridView) Then
                vItem.readonly = True
            ElseIf (TypeOf vItem Is CheckBox) Or (TypeOf vItem Is RadioButton) Or (TypeOf vItem Is ComboBox) Or
                   ((TypeOf vItem Is Button) Or (TypeOf vItem Is TreeView) Or (TypeOf vItem Is DateTimePicker) Or (TypeOf vItem Is NumericUpDown)) Then
                vItem.enabled = False
            ElseIf (TypeOf vItem Is GroupBox) Or (vItem.hasChildren) Then
                deshabilitarControles(vItem)
            End If
        Next
    End Sub
    Public Shared Sub habilitarBotones(ByRef pToolStrip As ToolStrip)

        'Recorre y habilita cada elemento
        For Each oToolStripButton In pToolStrip.Items
            If TypeOf oToolStripButton Is ToolStripButton Then
                oToolStripButton.enabled = True
            ElseIf TypeOf oToolStripButton Is ToolStripDropDown Then
                oToolStripButton.enabled = True
            End If
        Next
    End Sub
    Public Shared Sub deshabilitarBotones(ByRef pToolStrip As ToolStrip)
        'Recorre y deshabilita cada elemento
        For Each oToolStripButton In pToolStrip.Items
            If TypeOf oToolStripButton Is ToolStripButton Then
                oToolStripButton.enabled = False
            ElseIf TypeOf oToolStripButton Is ToolStripDropDownButton Then
                oToolStripButton.enabled = False
            End If
        Next
    End Sub
    Public Shared Sub habilitarControles(ByRef pElemento As Object)
        For Each vItem In pElemento.Controls
            If ((TypeOf vItem Is TextBox) Or (TypeOf vItem Is RichTextBox) Or (TypeOf vItem Is MaskedTextBox) Or (TypeOf vItem Is DataGridView)) And
                   Not (vItem.name.ToString.ToLower.Contains("txtcodigo")) Then
                If vItem.name = "dgvParametro" Then
                    habilitarColumnaParametro(vItem)
                ElseIf vItem.name = "dgRegistro" Then
                    vItem.readonly = True
                Else
                    vItem.readonly = False
                End If
            ElseIf (TypeOf vItem Is CheckBox) Or (TypeOf vItem Is RadioButton) Or (TypeOf vItem Is ComboBox) Or
                (TypeOf vItem Is Button) Or (TypeOf vItem Is TreeView) Or (TypeOf vItem Is DateTimePicker) Or (TypeOf vItem Is NumericUpDown) Then
                vItem.enabled = True
            ElseIf (TypeOf vItem Is GroupBox) Or (vItem.hasChildren) Then
                habilitarControles(vItem)
            End If
        Next
    End Sub
    Private Shared Sub habilitarColumnaParametro(dgv As DataGridView)
        With dgv
            .ReadOnly = False
            .Columns("Informacion").ReadOnly = True
        End With
    End Sub

    Public Shared Function cargarCombo(ByVal consulta As String,
                                  ByVal params As List(Of String),
                                  ByVal vlrDisplayMember As String,
                                  ByVal vlrValueMember As String,
                                  ByVal cbCombo As ComboBox) As Boolean
        Dim dtTabla As New DataTable
        Dim resultado As Boolean
        Try
            Dim drFila As DataRow = dtTabla.NewRow()
            dtTabla.Columns.Add(vlrValueMember)
            dtTabla.Columns.Add(vlrDisplayMember)
            drFila.Item(0) = "-1"
            drFila.Item(1) = " - - - Seleccione - - - "
            dtTabla.Rows.Add(drFila)
            objConexion.conectar()
            Using da = New SqlDataAdapter(consulta & Funciones.getParametros(params), objConexion.cnxbd)
                da.Fill(dtTabla)
            End Using
            objConexion.desConectar()
            If dtTabla.Rows.Count > 1 Then
                resultado = True
            End If
            cbCombo.DataSource = dtTabla
            cbCombo.DisplayMember = vlrDisplayMember
            cbCombo.ValueMember = vlrValueMember
            If cbCombo IsNot Nothing Then
                cbCombo.AutoCompleteMode = AutoCompleteMode.None
                cbCombo.AutoCompleteSource = AutoCompleteSource.None
                cbCombo.DropDownStyle = ComboBoxStyle.DropDownList
            End If
        Catch ex As Exception
            Throw ex
        End Try
        Return resultado
    End Function
    Public Shared Sub diseñoGrillaParametro(dgv As DataGridView)
        With dgv
            .Columns("codigo_Descripcion").Visible = False
            .Columns("Informacion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Datos").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Informacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Datos").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub
    Public Shared Function subirimagen(ByVal objeto As PictureBox, ByVal componente As OpenFileDialog) As OpenFileDialog
        Try
            objeto.Image = Nothing
            objeto.SizeMode = PictureBoxSizeMode.StretchImage
            objeto.BorderStyle = BorderStyle.None
            With componente
                .InitialDirectory = ""
                .Filter = "Todos los archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.pdf;*|PDF|*.pdf|JPEG|*.jpeg;*.jpg|BMP|*.bmp|GIF|*.gif|PNG|*.png"
                .Title = "Seleccionar Archivo"
            End With
            If componente.ShowDialog() = DialogResult.OK Then
                Dim documento = componente.FileName
                Dim aux = System.IO.Path.GetExtension(componente.FileName).ToLower
                With objeto
                    documento = Nothing
                    .Image = Image.FromFile(componente.FileName)
                End With
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Return componente
    End Function
    Public Shared Function consultarTipoControl(dgv As DataGridView,
                                                posicion As Integer) As Boolean
        Dim params As New List(Of String)
        Dim dfil As DataRow
        Dim controlDgv As String
        Dim consulta As String
        Dim valorInterno As String
        Dim valorExterno As String
        Dim resultado As Boolean

        Try
            params.Add(dgv.Rows(posicion).Cells("codigo_Descripcion").Value)
            dfil = Generales.cargarItem("SP_CONSULTAR_CONTROL", params)

            If Not IsNothing(dfil) Then
                params = Nothing
                controlDgv = dfil("control")
                consulta = dfil("Consulta")
                valorInterno = dfil("valorInterno")
                valorExterno = dfil("valorExterno")

                dgv.Rows(posicion).Cells("Datos") = crearControl(controlDgv, consulta, valorInterno, valorExterno, params)
                resultado = True

            End If

            Return resultado

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Shared Function crearControl(controlDgv As String,
                                         consulta As String,
                                         valorInterno As String,
                                         valorExterno As String,
                                         params As List(Of String))
        Dim cell As Object = Nothing

        Select Case controlDgv
            Case "combo"
                cell = dgvComboCellSinParametro(consulta, valorInterno, valorExterno, params)
            Case "seleccion"
                Dim tipoControl As New DataGridViewCheckBoxCell
                cell = tipoControl
            Case "tiempo"
                'Dim contedor As New DataGridView
                'cell = contedor
        End Select

        Return cell
    End Function
    Private Shared Function dgvComboCellSinParametro(consulta As String,
                                                     valorInterno As String,
                                                     valorExterno As String,
                                                     params As List(Of String))
        Dim contedor As New DataGridViewComboBoxCell
        Dim dtTabla As New DataTable
        Dim resultado As Boolean
        Try

            dtTabla.Columns.Add(valorInterno)
            dtTabla.Columns.Add(valorExterno)

            Dim drFila As DataRow = dtTabla.NewRow()
            drFila.Item(0) = "-1"
            drFila.Item(1) = " - - - Seleccione - - - "
            dtTabla.Rows.Add(drFila)

            objConexion.conectar()

            Using da = New SqlDataAdapter(consulta & Funciones.getParametros(params), objConexion.cnxbd)
                da.Fill(dtTabla)
            End Using

            If dtTabla.Rows.Count > 1 Then
                resultado = True
            End If

            contedor.DataSource = dtTabla
            contedor.DisplayMember = valorExterno
            contedor.ValueMember = valorInterno
            contedor.Tag = Constantes.TIPO_CONTROL.COMBO
        Catch ex As Exception
            Throw ex
        End Try

        objConexion.desConectar()

        Return contedor
    End Function
    Public Shared Sub mostrarMensaje(ByVal mensaje As String, icono As Image)
        Dim popupmotify1 As New NotifySenderControl.NotifySender
        popupmotify1.Show("¡Atención!", mensaje, icono)
    End Sub
    Public Shared Function ejecutarSQL(ByVal cadena As String) As Boolean
        Try
            objConexion.conectar()
            Using consulta As New SqlCommand(cadena)
                consulta.Connection = objConexion.cnxbd
                consulta.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
            objConexion.desConectar()
            Return False
        End Try
        objConexion.desConectar()
        Return True
    End Function
    Public Shared Sub subirArchivoFTP(objeto As Object)
        Dim segundoPlano As System.Threading.Thread
        Try
            segundoPlano = New Threading.Thread(AddressOf subirArchivo)
            segundoPlano.Start(objeto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Shared Sub subirArchivo(objeto As Object)
        If Not IsNothing(objeto.foto) Then
            Try
                My.Computer.Network.UploadFile(objeto.ruta, Constantes.SERVIDOR_FTP & objeto.foto,
                                               Constantes.USUARIO_FTP,
                                               Constantes.CONTRASENA_FTP,
                                               False,
                                               3500,
                                               FileIO.UICancelOption.ThrowException)
            Catch ex As Net.WebException
                Throw ex
            End Try
        End If
    End Sub
    Public Shared Sub bajarArchivoFTP(objeto As Object)
        Dim segundoPlanoBajar As System.Threading.Thread
        Try
            segundoPlanoBajar = New Threading.Thread(AddressOf bajarArchivo)
            segundoPlanoBajar.Start(objeto)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Shared Sub bajarArchivo(objeto As Object)
        Dim ruta As String
        If Not IsNothing(objeto.foto) Then
            Try
                ruta = IO.Path.GetTempPath & objeto.codigo
                'objeto.imagen.Cursor = Cursors.WaitCursor
                My.Computer.Network.DownloadFile(ruta, Constantes.SERVIDOR_FTP & objeto.foto,
                                                 Constantes.USUARIO_FTP,
                                                 Constantes.CONTRASENA_FTP,
                                                 False,
                                                 3500,
                                                 True,
                                                 FileIO.UICancelOption.ThrowException)
                objeto.image.ImageLocation(ruta)
                'objeto.imagen.Cursor = Cursors.Default
            Catch ex As Exception
                objeto.imagen.image = My.Resources.advertencia
            End Try
        End If
    End Sub
End Class
