﻿Imports System.Data.SqlClient
Imports CnxElixisLiveBD
Public Class Generales
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
                ' mira a ve si es un contenedor
                limpiarControles(vControl)
            End If
        Next
    End Sub
    Public Shared Sub diseñoDGV(ByRef dgv As DataGridView)
        dgv.BackgroundColor = Color.White
        dgv.DefaultCellStyle.BackColor = Color.White
        dgv.DefaultCellStyle.ForeColor = Color.Black
        dgv.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Nothing
        dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Nothing
        dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Nothing
        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgv.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA, 12)
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
            objConexion.desConectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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
            objConexion.desConectar()
        Catch ex As Exception
            Throw ex
        End Try
        If dtTabla.Rows.Count > 0 Then
            Return dtTabla.Rows(0)
        Else
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
            objConexion.desConectar()
        Catch ex As Exception
            Throw ex
        End Try
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
            objConexion.desConectar()
        Catch ex As Exception
            Throw
        End Try
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
                vItem.readonly = False
            ElseIf (TypeOf vItem Is CheckBox) Or (TypeOf vItem Is RadioButton) Or (TypeOf vItem Is ComboBox) Or
                (TypeOf vItem Is Button) Or (TypeOf vItem Is TreeView) Or (TypeOf vItem Is DateTimePicker) Or (TypeOf vItem Is NumericUpDown) Then
                vItem.enabled = True
            ElseIf (TypeOf vItem Is GroupBox) Or (vItem.hasChildren) Then
                habilitarControles(vItem)
            End If
        Next
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
End Class
