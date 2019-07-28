<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormExistencia
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Estado = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lbPorAcabar = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lbAcabado = New System.Windows.Forms.ToolStripTextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgvLista = New System.Windows.Forms.DataGridView()
        Me.errorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Estado.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(70, 14)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(549, 25)
        Me.txtBuscar.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Filtrar:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btActualizar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.txtBuscar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 376)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'btActualizar
        '
        Me.btActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btActualizar.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btActualizar.Location = New System.Drawing.Point(625, 12)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(94, 28)
        Me.btActualizar.TabIndex = 59
        Me.btActualizar.Text = "Recargar"
        Me.btActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btActualizar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Estado)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(7, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(713, 48)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        '
        'Estado
        '
        Me.Estado.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Estado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Estado.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Estado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lbPorAcabar, Me.ToolStripLabel2, Me.lbAcabado})
        Me.Estado.Location = New System.Drawing.Point(3, 16)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(707, 29)
        Me.Estado.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(137, 26)
        Me.ToolStripLabel1.Text = "Productos por Acabar"
        '
        'lbPorAcabar
        '
        Me.lbPorAcabar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbPorAcabar.CausesValidation = False
        Me.lbPorAcabar.Name = "lbPorAcabar"
        Me.lbPorAcabar.Size = New System.Drawing.Size(100, 29)
        Me.lbPorAcabar.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(129, 26)
        Me.ToolStripLabel2.Text = "Productos Acabados"
        '
        'lbAcabado
        '
        Me.lbAcabado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbAcabado.CausesValidation = False
        Me.lbAcabado.Name = "lbAcabado"
        Me.lbAcabado.Size = New System.Drawing.Size(100, 29)
        Me.lbAcabado.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgvLista)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox5.Location = New System.Drawing.Point(7, 42)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(713, 283)
        Me.GroupBox5.TabIndex = 61
        Me.GroupBox5.TabStop = False
        '
        'dgvLista
        '
        Me.dgvLista.AllowUserToAddRows = False
        Me.dgvLista.AllowUserToDeleteRows = False
        Me.dgvLista.AllowUserToResizeColumns = False
        Me.dgvLista.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvLista.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLista.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLista.Location = New System.Drawing.Point(3, 16)
        Me.dgvLista.MultiSelect = False
        Me.dgvLista.Name = "dgvLista"
        Me.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvLista.Size = New System.Drawing.Size(707, 264)
        Me.dgvLista.TabIndex = 0
        '
        'errorIcono
        '
        Me.errorIcono.ContainerControl = Me
        Me.errorIcono.RightToLeft = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LTitulo)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 34)
        Me.Panel1.TabIndex = 0
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.Black
        Me.LTitulo.Location = New System.Drawing.Point(4, 3)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(679, 28)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Productos en existencia"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormExistencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 421)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(3000, 1000)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(750, 460)
        Me.MinimumSize = New System.Drawing.Size(750, 460)
        Me.Name = "FormExistencia"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Estado.ResumeLayout(False)
        Me.Estado.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgvLista, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents Panel1 As Panel
    Public WithEvents LTitulo As Label
    Public WithEvents txtBuscar As TextBox
    Public WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Public WithEvents dgvLista As DataGridView
    Friend WithEvents errorIcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Estado As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lbPorAcabar As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lbAcabado As ToolStripTextBox
    Friend WithEvents btActualizar As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
