﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRetiroDocumento
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nRegistro = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtjustificacion = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btguardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btcancelar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtobservacion = New System.Windows.Forms.TextBox()
        Me.Ltitulo = New System.Windows.Forms.Label()
        Me.dgvDocumento = New System.Windows.Forms.DataGridView()
        Me.anulado = New System.Windows.Forms.DataGridViewImageColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tercero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.inicio = New System.Windows.Forms.DateTimePicker()
        Me.fin = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rAnulado = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dgvDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nRegistro)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1034, 504)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'nRegistro
        '
        Me.nRegistro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nRegistro.AutoSize = True
        Me.nRegistro.BackColor = System.Drawing.Color.White
        Me.nRegistro.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nRegistro.ForeColor = System.Drawing.Color.Black
        Me.nRegistro.Location = New System.Drawing.Point(1006, 481)
        Me.nRegistro.Name = "nRegistro"
        Me.nRegistro.Size = New System.Drawing.Size(16, 17)
        Me.nRegistro.TabIndex = 10060
        Me.nRegistro.Text = "0"
        Me.nRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(838, 481)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 17)
        Me.Label3.TabIndex = 10059
        Me.Label3.Text = "Cantidad de Registros:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Panel2)
        Me.GroupBox3.Controls.Add(Me.dgvDocumento)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 82)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1019, 391)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtjustificacion)
        Me.Panel1.Location = New System.Drawing.Point(269, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(517, 172)
        Me.Panel1.TabIndex = 60015
        Me.Panel1.Visible = False
        '
        'txtjustificacion
        '
        Me.txtjustificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjustificacion.Location = New System.Drawing.Point(3, 3)
        Me.txtjustificacion.Multiline = True
        Me.txtjustificacion.Name = "txtjustificacion"
        Me.txtjustificacion.ReadOnly = True
        Me.txtjustificacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtjustificacion.Size = New System.Drawing.Size(509, 164)
        Me.txtjustificacion.TabIndex = 10065
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Controls.Add(Me.GroupBox7)
        Me.Panel2.Controls.Add(Me.Ltitulo)
        Me.Panel2.Location = New System.Drawing.Point(230, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(562, 290)
        Me.Panel2.TabIndex = 60018
        Me.Panel2.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btguardar, Me.ToolStripSeparator3, Me.btcancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 263)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(560, 25)
        Me.ToolStrip1.TabIndex = 60017
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btguardar
        '
        Me.btguardar.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btguardar.ForeColor = System.Drawing.Color.Black
        Me.btguardar.Image = Global.Quality.My.Resources.Resources.User_Interface_Save_As_icon
        Me.btguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(71, 22)
        Me.btguardar.Text = "&Registrar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btcancelar
        '
        Me.btcancelar.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcancelar.ForeColor = System.Drawing.Color.Black
        Me.btcancelar.Image = Global.Quality.My.Resources.Resources.Arrows_Right_2_icon
        Me.btcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btcancelar.Name = "btcancelar"
        Me.btcancelar.Size = New System.Drawing.Size(72, 22)
        Me.btcancelar.Text = "&Cancelar"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtobservacion)
        Me.GroupBox7.Location = New System.Drawing.Point(3, 29)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(555, 202)
        Me.GroupBox7.TabIndex = 60016
        Me.GroupBox7.TabStop = False
        '
        'txtobservacion
        '
        Me.txtobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservacion.Location = New System.Drawing.Point(5, 11)
        Me.txtobservacion.Multiline = True
        Me.txtobservacion.Name = "txtobservacion"
        Me.txtobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtobservacion.Size = New System.Drawing.Size(544, 185)
        Me.txtobservacion.TabIndex = 60016
        '
        'Ltitulo
        '
        Me.Ltitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Ltitulo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ltitulo.ForeColor = System.Drawing.Color.Black
        Me.Ltitulo.Location = New System.Drawing.Point(2, 1)
        Me.Ltitulo.Name = "Ltitulo"
        Me.Ltitulo.Size = New System.Drawing.Size(557, 19)
        Me.Ltitulo.TabIndex = 60015
        Me.Ltitulo.Text = "Observación"
        Me.Ltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvDocumento
        '
        Me.dgvDocumento.AllowUserToAddRows = False
        Me.dgvDocumento.AllowUserToDeleteRows = False
        Me.dgvDocumento.AllowUserToResizeColumns = False
        Me.dgvDocumento.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvDocumento.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDocumento.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDocumento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDocumento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDocumento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.anulado, Me.fecha, Me.comprobante, Me.detalle, Me.nit, Me.Tercero, Me.debito, Me.credito})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDocumento.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDocumento.Location = New System.Drawing.Point(3, 16)
        Me.dgvDocumento.Name = "dgvDocumento"
        Me.dgvDocumento.ReadOnly = True
        Me.dgvDocumento.RowHeadersVisible = False
        Me.dgvDocumento.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.dgvDocumento.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvDocumento.Size = New System.Drawing.Size(1013, 372)
        Me.dgvDocumento.TabIndex = 10
        '
        'anulado
        '
        Me.anulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.anulado.HeaderText = "Anular"
        Me.anulado.Name = "anulado"
        Me.anulado.ReadOnly = True
        Me.anulado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.anulado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.anulado.Width = 64
        '
        'fecha
        '
        Me.fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.fecha.HeaderText = "Fecha comprobante"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Width = 114
        '
        'comprobante
        '
        Me.comprobante.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.comprobante.HeaderText = "Comprobante"
        Me.comprobante.Name = "comprobante"
        Me.comprobante.ReadOnly = True
        Me.comprobante.Width = 96
        '
        'detalle
        '
        Me.detalle.HeaderText = "Detalle"
        Me.detalle.Name = "detalle"
        Me.detalle.ReadOnly = True
        Me.detalle.Width = 65
        '
        'nit
        '
        Me.nit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.nit.HeaderText = "Nit tercero"
        Me.nit.Name = "nit"
        Me.nit.ReadOnly = True
        Me.nit.Width = 75
        '
        'Tercero
        '
        Me.Tercero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tercero.HeaderText = "Tercero"
        Me.Tercero.Name = "Tercero"
        Me.Tercero.ReadOnly = True
        Me.Tercero.Width = 69
        '
        'debito
        '
        Me.debito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.debito.HeaderText = "Débito"
        Me.debito.Name = "debito"
        Me.debito.ReadOnly = True
        Me.debito.Width = 63
        '
        'credito
        '
        Me.credito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.credito.HeaderText = "Crédito"
        Me.credito.Name = "credito"
        Me.credito.ReadOnly = True
        Me.credito.Width = 67
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.inicio)
        Me.GroupBox2.Controls.Add(Me.fin)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.rAnulado)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1019, 71)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'inicio
        '
        Me.inicio.CustomFormat = "dd |  MMMM |  yyyy"
        Me.inicio.Enabled = False
        Me.inicio.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.inicio.Location = New System.Drawing.Point(548, 30)
        Me.inicio.Name = "inicio"
        Me.inicio.Size = New System.Drawing.Size(189, 25)
        Me.inicio.TabIndex = 60036
        '
        'fin
        '
        Me.fin.CustomFormat = "dd |  MMMM |  yyyy"
        Me.fin.Enabled = False
        Me.fin.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fin.Location = New System.Drawing.Point(814, 30)
        Me.fin.Name = "fin"
        Me.fin.Size = New System.Drawing.Size(189, 25)
        Me.fin.TabIndex = 60035
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(387, 15)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(71, 21)
        Me.RadioButton2.TabIndex = 10076
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Activos"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rAnulado
        '
        Me.rAnulado.AutoSize = True
        Me.rAnulado.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rAnulado.ForeColor = System.Drawing.Color.Black
        Me.rAnulado.Location = New System.Drawing.Point(387, 42)
        Me.rAnulado.Name = "rAnulado"
        Me.rAnulado.Size = New System.Drawing.Size(79, 21)
        Me.rAnulado.TabIndex = 10075
        Me.rAnulado.Text = "Anulado"
        Me.rAnulado.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(69, 29)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(296, 25)
        Me.TextBox2.TabIndex = 10074
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 10073
        Me.Label5.Text = "Filtrar:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(768, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 17)
        Me.Label4.TabIndex = 10072
        Me.Label4.Text = "Fin:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(496, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 10070
        Me.Label6.Text = "Inicio:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(-2, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1048, 34)
        Me.Panel3.TabIndex = 10010
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(1, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1006, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Comprobantes anulados"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormRetiroDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1043, 567)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1059, 606)
        Me.MinimumSize = New System.Drawing.Size(1059, 606)
        Me.Name = "FormRetiroDocumento"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dgvDocumento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents nRegistro As Label
    Protected WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtjustificacion As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btguardar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents btcancelar As ToolStripButton
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtobservacion As TextBox
    Friend WithEvents Ltitulo As Label
    Friend WithEvents dgvDocumento As DataGridView
    Friend WithEvents anulado As DataGridViewImageColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents comprobante As DataGridViewTextBoxColumn
    Friend WithEvents detalle As DataGridViewTextBoxColumn
    Friend WithEvents nit As DataGridViewTextBoxColumn
    Friend WithEvents Tercero As DataGridViewTextBoxColumn
    Friend WithEvents debito As DataGridViewTextBoxColumn
    Friend WithEvents credito As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rAnulado As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Public WithEvents Panel3 As Panel
    Public WithEvents Label1 As Label
    Public WithEvents inicio As DateTimePicker
    Public WithEvents fin As DateTimePicker
End Class
