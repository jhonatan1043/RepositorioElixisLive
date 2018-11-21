
Imports System.Data.SqlClient
Imports CnxElixisLiveBD
Imports System.Net
Imports System.Threading

Public Class Generales
    Public Delegate Sub cargaInfoForm(ByVal codigo As String)
    Public Delegate Sub cargaInfoFormObj(ByVal fila As DataRow)
    Public Delegate Sub subRutina()
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
        Finally
            objConexion.desConectar()
        End Try
    End Sub

    Public Shared Function getCadenaSeleccionados(datatable As DataTable, seleccionados As String, posicionCodigo As Integer) As String

        For indice = 0 To datatable.Rows.Count - 2
            If indice = 0 Then
                seleccionados = "" & datatable.Rows(indice).Item(posicionCodigo).ToString & ""
            ElseIf indice <> datatable.Rows.Count - 2 Then
                seleccionados = seleccionados & "'" & Constantes.SIGNO_PESO & "','" & Constantes.SIGNO_PESO & "'" & datatable.Rows(indice).Item(posicionCodigo).ToString & ""
            Else
                seleccionados = seleccionados & "'" & Constantes.SIGNO_PESO & "','" & Constantes.SIGNO_PESO & "'" & datatable.Rows(indice).Item(posicionCodigo).ToString
            End If
        Next
        If String.IsNullOrEmpty(seleccionados) Then
            seleccionados = Constantes.SIGNO_PESO
        End If
        Return seleccionados
    End Function
    Public Shared Sub busquedaItems(nombreProc As String,
                                    params As List(Of String),
                                    titulo As String,
                                    datagrid As DataGridView,
                                    datatable As DataTable,
                                    indColumnaInicio As Integer,
                                    indColumnaFin As Integer,
                                    indColumnaFoco As Integer,
                                    Optional ocultarCodigo As Boolean = False,
                                    Optional noRepetir As Boolean = False,
                                    Optional indColumnaNoRepetible As Integer = 0,
                                    Optional cerrarBusqueda As Boolean = False,
                                    Optional pMetodo As subRutina = Nothing
                                    )
        Dim seguir As Boolean = False
        Dim seleccionados As String = ""
        Do
            Dim tbl As DataRow = Nothing
            If noRepetir = True Then
                seleccionados = getCadenaSeleccionados(datatable, seleccionados, indColumnaNoRepetible)
                params.Add(seleccionados)
            End If

            Dim formBusqueda As FormBusqueda = buscarElemento(nombreProc, params, titulo, ocultarCodigo, True)
            If noRepetir = True Then
                params.RemoveAt(params.Count - 1)
            End If

            tbl = formBusqueda.rowResultados
            Dim ultimaFila = datatable.Rows.Count - 1
            If tbl IsNot Nothing Then
                If datatable.Rows.Count = 0 OrElse datatable.Rows(ultimaFila).Item(indColumnaInicio).ToString <> "" Then
                    datatable.Rows.Add()
                    ultimaFila = datatable.Rows.Count - 1
                End If

                For indColumna = indColumnaInicio To indColumnaFin
                    datatable.Rows(ultimaFila).Item(indColumna) = tbl.Item(indColumna - indColumnaInicio).ToString
                Next
                datatable.Rows.Add()
                ultimaFila = datatable.Rows.Count - 1

                datagrid.EndEdit()
                Try
                    datagrid.Rows(ultimaFila - 1).Cells(indColumnaFoco).Selected = True
                Catch ex As Exception

                End Try
                seguir = True
                If Not IsNothing(pMetodo) Then
                    pMetodo.Invoke()
                End If
            Else
                seguir = False
            End If

        Loop While (seguir = True AndAlso cerrarBusqueda = False)
    End Sub
    Public Shared Function buscarElemento(pConsultaSQL As String,
                                          plistaParam As List(Of String),
                                          pTitulo As String,
                                          pOcultaCol As Boolean,
                                          Optional pTamanoForm As Integer = 0,
                                          Optional pBuscarDarEnter As Boolean = False)

        Dim vForm As New FormBusqueda()
        vForm.Text = pTitulo
        If Not IsNothing(plistaParam) Then
            vForm.consulta = pConsultaSQL & Funciones.getParametros(plistaParam)
        Else
            vForm.consulta = pConsultaSQL
        End If
        vForm.isOcultaCol = pOcultaCol
        vForm.buscarAlDarEnter = pBuscarDarEnter
        vForm.ShowDialog()
        Return vForm

    End Function
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
    Public Shared Sub diseñoGrillaParametros(dgv As DataGridView)
        With dgv
            .Columns("codigo_Descripcion").Visible = False
            .Columns("Informacion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Datos").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns("Informacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .Columns("Datos").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub
    Public Shared Sub limpiarGrillaParametro(dgv As DataGridView)
        For posicion = 0 To dgv.Rows.Count - 1
            dgv.Rows(posicion).Cells("Datos").Value = Nothing
        Next
    End Sub
    Public Shared Function convertirNumero(ByVal numero As Double) As String
        Dim sValor As String, siValor As Single = Nothing
        Dim numEntero, numDecimal As Single
        Dim numeroConvertido As String

        sValor = Val(Replace(Format(numero, "General Number"), ",", ".").ToString)
        numEntero = Int(Val(sValor))
        numDecimal = CInt((sValor - numEntero) * 100)

        If numDecimal > 0 Then
            numeroConvertido = asignarNombreNumero(Val(sValor)) & " PESOS CON " + asignarNombreNumero(numDecimal) + " CENTAVOS MCTE"
        Else
            numeroConvertido = asignarNombreNumero(Val(sValor)) & " PESOS MCTE"
        End If
        Return numeroConvertido
    End Function
    Public Shared Function asignarNombreNumero(ByVal value As Double) As String
        value = Int(value)
        Select Case value
            Case 0 : asignarNombreNumero = "CERO"
            Case 1 : asignarNombreNumero = "UN"
            Case 2 : asignarNombreNumero = "DOS"
            Case 3 : asignarNombreNumero = "TRES"
            Case 4 : asignarNombreNumero = "CUATRO"
            Case 5 : asignarNombreNumero = "CINCO"
            Case 6 : asignarNombreNumero = "SEIS"
            Case 7 : asignarNombreNumero = "SIETE"
            Case 8 : asignarNombreNumero = "OCHO"
            Case 9 : asignarNombreNumero = "NUEVE"
            Case 10 : asignarNombreNumero = "DIEZ"
            Case 11 : asignarNombreNumero = "ONCE"
            Case 12 : asignarNombreNumero = "DOCE"
            Case 13 : asignarNombreNumero = "TRECE"
            Case 14 : asignarNombreNumero = "CATORCE"
            Case 15 : asignarNombreNumero = "QUINCE"
            Case Is < 20 : asignarNombreNumero = "DIECI" & asignarNombreNumero(value - 10)
            Case 20 : asignarNombreNumero = "VEINTE"
            Case Is < 30 : asignarNombreNumero = "VEINTI" & asignarNombreNumero(value - 20)
            Case 30 : asignarNombreNumero = "TREINTA"
            Case 40 : asignarNombreNumero = "CUARENTA"
            Case 50 : asignarNombreNumero = "CINCUENTA"
            Case 60 : asignarNombreNumero = "SESENTA"
            Case 70 : asignarNombreNumero = "SETENTA"
            Case 80 : asignarNombreNumero = "OCHENTA"
            Case 90 : asignarNombreNumero = "NOVENTA"
            Case Is < 100 : asignarNombreNumero = asignarNombreNumero(Int(value \ 10) * 10) & " Y " & asignarNombreNumero(value Mod 10)
            Case 100 : asignarNombreNumero = "CIEN"
            Case Is < 200 : asignarNombreNumero = "CIENTO " & asignarNombreNumero(value - 100)
            Case 200, 300, 400, 600, 800 : asignarNombreNumero = asignarNombreNumero(Int(value \ 100)) & "CIENTOS"
            Case 500 : asignarNombreNumero = "QUINIENTOS"
            Case 700 : asignarNombreNumero = "SETECIENTOS"
            Case 900 : asignarNombreNumero = "NOVECIENTOS"
            Case Is < 1000 : asignarNombreNumero = asignarNombreNumero(Int(value \ 100) * 100) & " " & asignarNombreNumero(value Mod 100)
            Case 1000 : asignarNombreNumero = "MIL"
            Case Is < 2000 : asignarNombreNumero = "MIL " & asignarNombreNumero(value Mod 1000)
            Case Is < 1000000 : asignarNombreNumero = asignarNombreNumero(Int(value \ 1000)) & " MIL"
                If value Mod 1000 Then asignarNombreNumero = asignarNombreNumero & " " & asignarNombreNumero(value Mod 1000)
            Case 1000000 : asignarNombreNumero = "UN MILLON"
            Case Is < 2000000 : asignarNombreNumero = "UN MILLON" & asignarNombreNumero(value Mod 1000000)
            Case Is < 1000000000000.0# : asignarNombreNumero = asignarNombreNumero(Int(value / 1000000)) & " MILLONES"
                If (value - Int(value / 1000000) * 1000000) Then asignarNombreNumero = asignarNombreNumero & " " & asignarNombreNumero(value - Int(value / 1000000) * 1000000)
            Case 1000000000000.0# : asignarNombreNumero = "UN BILLON"
            Case Is < 2000000000000.0# : asignarNombreNumero = "UN BILLON" & asignarNombreNumero(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            Case Else : asignarNombreNumero = asignarNombreNumero(Int(value / 1000000000000.0#)) & " BILLONES"
                If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then asignarNombreNumero = asignarNombreNumero & " " & asignarNombreNumero(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
        End Select
    End Function
    Public Shared Function validarDatosDgv(dgv As DataGridView, columna As Integer)
        If (dgv.RowCount = 1) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡No se puede guardar registros en blanco!")
            dgv.Focus()
            Return False
        Else
            For indiceFila = 0 To dgv.Rows.Count - 2
                If dgv.Rows(indiceFila).Cells(columna).Value.ToString = "" Then
                    EstiloMensajes.mostrarMensajeAdvertencia("¡Falta ingresar datos en la fila" & indiceFila + 1 & "!")
                    Return False
                End If
            Next
        End If
        Return True
    End Function
    Public Shared Function digitarEnDgv(consulta As String, params As List(Of String)) As DataRow
        Dim drCodigo As DataRow
        drCodigo = Generales.cargarItem(consulta, params)
        If Not IsNothing(drCodigo) Then
            Return drCodigo
        Else
            EstiloMensajes.mostrarMensajeAdvertencia("¡Este código no existe!")
        End If
        Return Nothing
    End Function
    Public Shared Sub diseñoDGV(ByRef dgv As DataGridView)
        dgv.BackgroundColor = Color.White
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.ForeColor = Color.Black
        dgv.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.DefaultCellStyle.Font = New Font("Times New Roman", 11, FontStyle.Italic)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Nothing
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Nothing
        dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Nothing
        dgv.AlternatingRowsDefaultCellStyle.Font = New Font("Times New Roman", 11, FontStyle.Italic)
        'dgv.AlternatingRowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Times New Roman", 12, FontStyle.Italic)
        For indiceColumna = 0 To dgv.Columns.Count - 1
            dgv.Columns(indiceColumna).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Next

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
            objConexion.desConectar()
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        objConexion.desConectar()
        dgdgv.DataSource = dtTabla
        diseñoDGV(dgdgv)
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
            objConexion.desConectar()
            Return dtTabla.Rows(0)
        Else
            objConexion.desConectar()
            Return Nothing
        End If

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

        If dtTabla.Rows.Count > 0 Then
            objConexion.desConectar()
            Return dtTabla.Rows(0)
        Else
            objConexion.desConectar()
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
                If vItem.name = "dgvParametro" AndAlso vItem.ColumnCount > 0 Then
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
        Finally
            objConexion.desConectar()
        End Try
        Return resultado
    End Function
    Public Shared Sub desvanecerForm(form As Form)
        For contador = 90 To 9 Step -18
            form.Opacity = contador / 100
            form.Refresh()
            Thread.Sleep(80)
        Next
    End Sub
    Public Shared Sub desvanecerControl(objeto As Object)
        For contador = 90 To 9 Step -9
            objeto.Opacity = contador / 100
            objeto.Refresh()
            Thread.Sleep(80)
        Next
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
    Public Shared Function crearControl(controlDgv As String,
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
