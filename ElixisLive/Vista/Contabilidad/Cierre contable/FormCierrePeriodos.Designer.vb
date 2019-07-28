<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCierrePeriodos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fechaCierre = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.dgfecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgAnulado = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btCerrarAño = New System.Windows.Forms.Button()
        Me.btAbrirAño = New System.Windows.Forms.Button()
        Me.btAbrirMes = New System.Windows.Forms.Button()
        Me.btCerrarMes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.fechaCierre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dgvCuentas)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(759, 436)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'fechaCierre
        '
        Me.fechaCierre.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaCierre.CalendarMonthBackground = System.Drawing.SystemColors.MenuHighlight
        Me.fechaCierre.CustomFormat = "dd /MMMM/ yyyy"
        Me.fechaCierre.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaCierre.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaCierre.Location = New System.Drawing.Point(566, 38)
        Me.fechaCierre.MinDate = New Date(2014, 1, 1, 0, 0, 0, 0)
        Me.fechaCierre.Name = "fechaCierre"
        Me.fechaCierre.Size = New System.Drawing.Size(187, 25)
        Me.fechaCierre.TabIndex = 46
        Me.fechaCierre.Value = New Date(2014, 1, 2, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(590, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Seleccione fecha"
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToResizeColumns = False
        Me.dgvCuentas.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.AliceBlue
        Me.dgvCuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCuentas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgfecha, Me.dgDetalle, Me.dgAnulado})
        Me.dgvCuentas.Location = New System.Drawing.Point(4, 13)
        Me.dgvCuentas.MultiSelect = False
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.RowHeadersVisible = False
        Me.dgvCuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCuentas.Size = New System.Drawing.Size(556, 417)
        Me.dgvCuentas.TabIndex = 49
        '
        'dgfecha
        '
        Me.dgfecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgfecha.HeaderText = "Fecha"
        Me.dgfecha.Name = "dgfecha"
        Me.dgfecha.Width = 63
        '
        'dgDetalle
        '
        Me.dgDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgDetalle.HeaderText = "Detalle"
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.Width = 400
        '
        'dgAnulado
        '
        Me.dgAnulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.dgAnulado.HeaderText = "Cerrado"
        Me.dgAnulado.Name = "dgAnulado"
        Me.dgAnulado.Width = 74
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btCerrarAño)
        Me.GroupBox2.Controls.Add(Me.btAbrirAño)
        Me.GroupBox2.Controls.Add(Me.btAbrirMes)
        Me.GroupBox2.Controls.Add(Me.btCerrarMes)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(566, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 349)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btCerrarAño
        '
        Me.btCerrarAño.BackColor = System.Drawing.Color.Gainsboro
        Me.btCerrarAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCerrarAño.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCerrarAño.ForeColor = System.Drawing.Color.Black
        Me.btCerrarAño.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCerrarAño.Location = New System.Drawing.Point(17, 244)
        Me.btCerrarAño.Name = "btCerrarAño"
        Me.btCerrarAño.Size = New System.Drawing.Size(152, 57)
        Me.btCerrarAño.TabIndex = 43
        Me.btCerrarAño.Text = "Cerrar todo el año"
        Me.btCerrarAño.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btCerrarAño.UseVisualStyleBackColor = False
        '
        'btAbrirAño
        '
        Me.btAbrirAño.BackColor = System.Drawing.Color.Gainsboro
        Me.btAbrirAño.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAbrirAño.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAbrirAño.ForeColor = System.Drawing.Color.Black
        Me.btAbrirAño.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAbrirAño.Location = New System.Drawing.Point(17, 174)
        Me.btAbrirAño.Name = "btAbrirAño"
        Me.btAbrirAño.Size = New System.Drawing.Size(152, 57)
        Me.btAbrirAño.TabIndex = 50
        Me.btAbrirAño.Text = "Abrir todo el año"
        Me.btAbrirAño.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAbrirAño.UseVisualStyleBackColor = False
        '
        'btAbrirMes
        '
        Me.btAbrirMes.BackColor = System.Drawing.Color.Gainsboro
        Me.btAbrirMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btAbrirMes.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAbrirMes.ForeColor = System.Drawing.Color.Black
        Me.btAbrirMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAbrirMes.Location = New System.Drawing.Point(17, 34)
        Me.btAbrirMes.Name = "btAbrirMes"
        Me.btAbrirMes.Size = New System.Drawing.Size(152, 57)
        Me.btAbrirMes.TabIndex = 47
        Me.btAbrirMes.Text = "Abrir todo el mes"
        Me.btAbrirMes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btAbrirMes.UseVisualStyleBackColor = False
        '
        'btCerrarMes
        '
        Me.btCerrarMes.BackColor = System.Drawing.Color.Gainsboro
        Me.btCerrarMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCerrarMes.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCerrarMes.ForeColor = System.Drawing.Color.Black
        Me.btCerrarMes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btCerrarMes.Location = New System.Drawing.Point(17, 104)
        Me.btCerrarMes.Name = "btCerrarMes"
        Me.btCerrarMes.Size = New System.Drawing.Size(152, 57)
        Me.btCerrarMes.TabIndex = 48
        Me.btCerrarMes.Text = "Cerrar todo el mes"
        Me.btCerrarMes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btCerrarMes.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.LTitulo)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(777, 34)
        Me.Panel2.TabIndex = 3
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.Black
        Me.LTitulo.Location = New System.Drawing.Point(1, 2)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(742, 28)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Cierre de Periodos"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormCierrePeriodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(775, 489)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(791, 528)
        Me.MinimumSize = New System.Drawing.Size(791, 528)
        Me.Name = "FormCierrePeriodos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Panel2 As Panel
    Public WithEvents LTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents fechaCierre As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvCuentas As DataGridView
    Friend WithEvents dgfecha As DataGridViewTextBoxColumn
    Friend WithEvents dgDetalle As DataGridViewTextBoxColumn
    Friend WithEvents dgAnulado As DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btCerrarAño As Button
    Friend WithEvents btAbrirAño As Button
    Friend WithEvents btAbrirMes As Button
    Friend WithEvents btCerrarMes As Button
End Class
