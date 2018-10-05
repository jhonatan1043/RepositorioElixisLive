Public Class FormBusqueda
    Public Property consulta As String
    Public Property isOcultaCol As Boolean
    Public Property buscarAlDarEnter As Boolean
    Public Property metodoCarga As Generales.cargaInfoForm
    Public Property rowResultados As DataRow
    Public Property metodoCargaObj As Generales.cargaInfoFormObj
    Public Property isRetornaObj As Boolean

    Dim dtBusqueda As New DataTable

    Private Sub dgvbusqueda_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvbusqueda.CellMouseDoubleClick
        If Generales.filaValida(e.RowIndex) Then
            If isRetornaObj Then
                Dim filaSeleccionada As DataGridViewRow = dgvBusqueda.SelectedRows.Item(0)
                Dim registro As DataRow = DirectCast(filaSeleccionada.DataBoundItem.row, DataRow)

                metodoCargaObj.Invoke(registro)
                DialogResult = DialogResult.OK

            Else
                Dim codigo As String = dgvBusqueda.SelectedRows.Item(0).Cells.Item(0).Value.ToString
                If Not IsNothing(metodoCarga) Then
                    metodoCarga.Invoke(codigo)
                End If
                Dim row As DataRowView
                row = DirectCast(dgvBusqueda.CurrentRow.DataBoundItem, DataRowView)
                rowResultados = row.Row
                DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Public Overridable Sub Form_Busqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LTitulo.Text = Text
        Me.Text = ""
        Textbusqueda.Text = Generales.validarComillaSimple(Textbusqueda.Text)
        llenardgv()
        Textbusqueda.SelectionStart = Textbusqueda.TextLength
        For I = 0 To dgvbusqueda.ColumnCount - 1
            dgvbusqueda.Columns(I).SortMode = DataGridViewColumnSortMode.Automatic
        Next
        If isOcultaCol Then
            dgvbusqueda.Columns(0).Visible = False
        End If
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 880
        y = Screen.PrimaryScreen.WorkingArea.Height - 600
        Me.Location = New Point(x, y)
    End Sub
    Private Sub Textbusqueda_TextChanged(sender As Object, e As EventArgs) Handles Textbusqueda.TextChanged
        If buscarAlDarEnter = False Then
            Textbusqueda.Text = Generales.validarComillaSimple(Textbusqueda.Text)
            llenardgv()
            Textbusqueda.SelectionStart = Textbusqueda.TextLength
        End If
    End Sub
    Private Sub Busqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles Textbusqueda.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf buscarAlDarEnter = True And e.KeyCode = Keys.Enter Then
            Textbusqueda.Text = Generales.validarComillaSimple(Textbusqueda.Text)
            llenardgv()
            Textbusqueda.SelectionStart = Textbusqueda.TextLength
        End If
    End Sub

    Public Sub llenardgv()
        Dim busqueda As New Busqueda
        If consulta <> "" Then
            dtBusqueda = Busqueda.llenar(consulta, Textbusqueda.Text)
            dgvBusqueda.DataSource = dtBusqueda
            dgvBusqueda.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgvBusqueda.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA, 9)
        End If

    End Sub
    Private Sub formBusqueda_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class