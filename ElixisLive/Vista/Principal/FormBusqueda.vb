Public Class FormBusqueda
    Dim formulario As New vForm
    Public Property consulta As String
    Public Property isOcultaCol As Boolean
    Public Property buscarAlDarEnter As Boolean
    Public Property metodoCarga As Generales.cargaInfoForm
    Public Property rowResultados As DataRow
    Public Property metodoCargaObj As Generales.cargaInfoFormObj
    Public Property isRetornaObj As Boolean

    Dim dtBusqueda As New DataTable

    Private Sub dgvbusqueda_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvBusqueda.CellMouseDoubleClick
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
        For I = 0 To dgvBusqueda.ColumnCount - 1
            dgvBusqueda.Columns(I).SortMode = DataGridViewColumnSortMode.Automatic
        Next
        establecerPosicionBusqueda()
        Generales.diseñoDGV(dgvBusqueda)
        If isOcultaCol Then
            dgvBusqueda.Columns(0).Visible = False
        End If
        formulario.ventana = Me '' se indica el formulario que usara el efecto
        formulario.redondear() '' se redondean los bordes del formulario
    End Sub
    Private Sub establecerPosicionBusqueda()
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 880
        y = Screen.PrimaryScreen.WorkingArea.Height - 590
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
            dgvBusqueda.DefaultCellStyle.Font = New Font("Times New Roman", 11, FontStyle.Italic)
        End If

    End Sub
    Private Sub formBusqueda_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub FormBusquedaMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                Handles MyBase.MouseMove '' aca puedes agregar mas controles que quieras usar para mover el formulario ej: label1.MouseMove

        If e.Button = MouseButtons.Left Then
            formulario.moverForm() '' se llama la función que da el efecto
        End If

    End Sub
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        Me.Close()
    End Sub
End Class