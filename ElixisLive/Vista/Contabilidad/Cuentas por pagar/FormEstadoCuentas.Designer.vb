<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstadoCuentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEstadoCuentas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.dgfactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFechaRadicado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFechaVence = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg30Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg60Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg90Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg180Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg360Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgMas360Dias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.text180dias = New System.Windows.Forms.TextBox()
        Me.text360dias = New System.Windows.Forms.TextBox()
        Me.text30dias = New System.Windows.Forms.TextBox()
        Me.text60dias = New System.Windows.Forms.TextBox()
        Me.text90dias = New System.Windows.Forms.TextBox()
        Me.textvalortotal = New System.Windows.Forms.TextBox()
        Me.textmas360dias = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.textnombreproveedor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fechadoc = New System.Windows.Forms.DateTimePicker()
        Me.btexcel = New System.Windows.Forms.Button()
        Me.btimprimir = New System.Windows.Forms.Button()
        Me.bttercero = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCuentas)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1295, 514)
        Me.GroupBox1.TabIndex = 10063
        Me.GroupBox1.TabStop = False
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        Me.dgvCuentas.AllowUserToResizeColumns = False
        Me.dgvCuentas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvCuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCuentas.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LavenderBlush
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgfactura, Me.dgFechaRadicado, Me.dgFechaVence, Me.dg30Dias, Me.dg60Dias, Me.dg90Dias, Me.dg180Dias, Me.dg360Dias, Me.dgMas360Dias, Me.dgDias})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SkyBlue
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentas.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvCuentas.Location = New System.Drawing.Point(7, 19)
        Me.dgvCuentas.MultiSelect = False
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        Me.dgvCuentas.RowHeadersVisible = False
        Me.dgvCuentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCuentas.ShowCellErrors = False
        Me.dgvCuentas.ShowCellToolTips = False
        Me.dgvCuentas.ShowEditingIcon = False
        Me.dgvCuentas.ShowRowErrors = False
        Me.dgvCuentas.Size = New System.Drawing.Size(1282, 406)
        Me.dgvCuentas.TabIndex = 10060
        '
        'dgfactura
        '
        Me.dgfactura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgfactura.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgfactura.HeaderText = "No.Factura"
        Me.dgfactura.Name = "dgfactura"
        Me.dgfactura.ReadOnly = True
        Me.dgfactura.Width = 83
        '
        'dgFechaRadicado
        '
        Me.dgFechaRadicado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgFechaRadicado.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgFechaRadicado.HeaderText = "Fecha Radicado"
        Me.dgFechaRadicado.Name = "dgFechaRadicado"
        Me.dgFechaRadicado.ReadOnly = True
        Me.dgFechaRadicado.Width = 106
        '
        'dgFechaVence
        '
        Me.dgFechaVence.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgFechaVence.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgFechaVence.FillWeight = 75.41729!
        Me.dgFechaVence.HeaderText = "Fecha Vencimiento"
        Me.dgFechaVence.MinimumWidth = 75
        Me.dgFechaVence.Name = "dgFechaVence"
        Me.dgFechaVence.ReadOnly = True
        Me.dgFechaVence.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgFechaVence.Width = 121
        '
        'dg30Dias
        '
        Me.dg30Dias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0"
        Me.dg30Dias.DefaultCellStyle = DataGridViewCellStyle6
        Me.dg30Dias.FillWeight = 68.66889!
        Me.dg30Dias.HeaderText = "De 1 a 30 Días"
        Me.dg30Dias.MinimumWidth = 110
        Me.dg30Dias.Name = "dg30Dias"
        Me.dg30Dias.ReadOnly = True
        Me.dg30Dias.Width = 110
        '
        'dg60Dias
        '
        Me.dg60Dias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "C2"
        DataGridViewCellStyle7.NullValue = "0"
        Me.dg60Dias.DefaultCellStyle = DataGridViewCellStyle7
        Me.dg60Dias.FillWeight = 104.4114!
        Me.dg60Dias.HeaderText = "De 31 a 60 Días"
        Me.dg60Dias.MinimumWidth = 110
        Me.dg60Dias.Name = "dg60Dias"
        Me.dg60Dias.ReadOnly = True
        Me.dg60Dias.Width = 110
        '
        'dg90Dias
        '
        Me.dg90Dias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        DataGridViewCellStyle8.NullValue = "0"
        Me.dg90Dias.DefaultCellStyle = DataGridViewCellStyle8
        Me.dg90Dias.FillWeight = 105.397!
        Me.dg90Dias.HeaderText = "De 61 a 90 Días"
        Me.dg90Dias.MinimumWidth = 110
        Me.dg90Dias.Name = "dg90Dias"
        Me.dg90Dias.ReadOnly = True
        Me.dg90Dias.Width = 110
        '
        'dg180Dias
        '
        Me.dg180Dias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = "0"
        Me.dg180Dias.DefaultCellStyle = DataGridViewCellStyle9
        Me.dg180Dias.FillWeight = 110.8689!
        Me.dg180Dias.HeaderText = "De 91 a 180 Días"
        Me.dg180Dias.MinimumWidth = 110
        Me.dg180Dias.Name = "dg180Dias"
        Me.dg180Dias.ReadOnly = True
        Me.dg180Dias.Width = 110
        '
        'dg360Dias
        '
        Me.dg360Dias.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = "0"
        Me.dg360Dias.DefaultCellStyle = DataGridViewCellStyle10
        Me.dg360Dias.HeaderText = "De 181 a  360 Días"
        Me.dg360Dias.MinimumWidth = 110
        Me.dg360Dias.Name = "dg360Dias"
        Me.dg360Dias.ReadOnly = True
        Me.dg360Dias.Width = 115
        '
        'dgMas360Dias
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = "0"
        Me.dgMas360Dias.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgMas360Dias.HeaderText = "Mas De 360 Días"
        Me.dgMas360Dias.MinimumWidth = 110
        Me.dgMas360Dias.Name = "dgMas360Dias"
        Me.dgMas360Dias.ReadOnly = True
        Me.dgMas360Dias.Width = 129
        '
        'dgDias
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgDias.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgDias.HeaderText = "No.Días"
        Me.dgDias.Name = "dgDias"
        Me.dgDias.ReadOnly = True
        Me.dgDias.Width = 60
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.text180dias)
        Me.GroupBox2.Controls.Add(Me.text360dias)
        Me.GroupBox2.Controls.Add(Me.text30dias)
        Me.GroupBox2.Controls.Add(Me.text60dias)
        Me.GroupBox2.Controls.Add(Me.text90dias)
        Me.GroupBox2.Controls.Add(Me.textvalortotal)
        Me.GroupBox2.Controls.Add(Me.textmas360dias)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 431)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1282, 79)
        Me.GroupBox2.TabIndex = 10061
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subtotales"
        '
        'text180dias
        '
        Me.text180dias.BackColor = System.Drawing.Color.White
        Me.text180dias.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text180dias.Location = New System.Drawing.Point(578, 47)
        Me.text180dias.Name = "text180dias"
        Me.text180dias.ReadOnly = True
        Me.text180dias.Size = New System.Drawing.Size(122, 25)
        Me.text180dias.TabIndex = 9
        Me.text180dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'text360dias
        '
        Me.text360dias.BackColor = System.Drawing.Color.White
        Me.text360dias.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text360dias.Location = New System.Drawing.Point(733, 47)
        Me.text360dias.Name = "text360dias"
        Me.text360dias.ReadOnly = True
        Me.text360dias.Size = New System.Drawing.Size(131, 25)
        Me.text360dias.TabIndex = 11
        Me.text360dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'text30dias
        '
        Me.text30dias.BackColor = System.Drawing.Color.White
        Me.text30dias.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text30dias.Location = New System.Drawing.Point(122, 47)
        Me.text30dias.Name = "text30dias"
        Me.text30dias.ReadOnly = True
        Me.text30dias.Size = New System.Drawing.Size(115, 25)
        Me.text30dias.TabIndex = 1
        Me.text30dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'text60dias
        '
        Me.text60dias.BackColor = System.Drawing.Color.White
        Me.text60dias.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text60dias.Location = New System.Drawing.Point(269, 47)
        Me.text60dias.Name = "text60dias"
        Me.text60dias.ReadOnly = True
        Me.text60dias.Size = New System.Drawing.Size(123, 25)
        Me.text60dias.TabIndex = 3
        Me.text60dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'text90dias
        '
        Me.text90dias.BackColor = System.Drawing.Color.White
        Me.text90dias.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text90dias.Location = New System.Drawing.Point(427, 47)
        Me.text90dias.Name = "text90dias"
        Me.text90dias.ReadOnly = True
        Me.text90dias.Size = New System.Drawing.Size(115, 25)
        Me.text90dias.TabIndex = 5
        Me.text90dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textvalortotal
        '
        Me.textvalortotal.BackColor = System.Drawing.Color.White
        Me.textvalortotal.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textvalortotal.Location = New System.Drawing.Point(1047, 47)
        Me.textvalortotal.Name = "textvalortotal"
        Me.textvalortotal.ReadOnly = True
        Me.textvalortotal.Size = New System.Drawing.Size(115, 25)
        Me.textvalortotal.TabIndex = 15
        Me.textvalortotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'textmas360dias
        '
        Me.textmas360dias.BackColor = System.Drawing.Color.White
        Me.textmas360dias.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textmas360dias.Location = New System.Drawing.Point(898, 47)
        Me.textmas360dias.Name = "textmas360dias"
        Me.textmas360dias.ReadOnly = True
        Me.textmas360dias.Size = New System.Drawing.Size(115, 25)
        Me.textmas360dias.TabIndex = 13
        Me.textmas360dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.SteelBlue
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(122, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 48)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = " De 1 a 30 Días"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.SteelBlue
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(269, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 48)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "De 31 a 60 Días"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(733, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 48)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = " De 181 a 360 Días"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.SteelBlue
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(427, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 48)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "De 61 a 90 Días"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.SteelBlue
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(1047, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 48)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Valor Total"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.SteelBlue
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(578, 23)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(122, 48)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "De 91 a 180 Días"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.SteelBlue
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(898, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 48)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "A Mas 360 Días"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'textnombreproveedor
        '
        Me.textnombreproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textnombreproveedor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textnombreproveedor.Location = New System.Drawing.Point(74, 61)
        Me.textnombreproveedor.Name = "textnombreproveedor"
        Me.textnombreproveedor.Size = New System.Drawing.Size(799, 25)
        Me.textnombreproveedor.TabIndex = 60032
        Me.textnombreproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 60033
        Me.Label3.Text = "Tercero:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(928, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 60036
        Me.Label4.Text = "Hasta:"
        '
        'fechadoc
        '
        Me.fechadoc.CustomFormat = "dd |  MMMM |  yyyy"
        Me.fechadoc.Enabled = False
        Me.fechadoc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechadoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechadoc.Location = New System.Drawing.Point(980, 62)
        Me.fechadoc.Name = "fechadoc"
        Me.fechadoc.Size = New System.Drawing.Size(189, 25)
        Me.fechadoc.TabIndex = 60037
        '
        'btexcel
        '
        Me.btexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btexcel.Enabled = False
        Me.btexcel.Image = Global.Quality.My.Resources.Resources.Microsoft_Excel_2013_icon1
        Me.btexcel.Location = New System.Drawing.Point(1249, 55)
        Me.btexcel.Name = "btexcel"
        Me.btexcel.Size = New System.Drawing.Size(42, 38)
        Me.btexcel.TabIndex = 60035
        Me.btexcel.UseVisualStyleBackColor = True
        '
        'btimprimir
        '
        Me.btimprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btimprimir.Enabled = False
        Me.btimprimir.Image = Global.Quality.My.Resources.Resources.Printer_icon__1_1
        Me.btimprimir.Location = New System.Drawing.Point(1190, 55)
        Me.btimprimir.Name = "btimprimir"
        Me.btimprimir.Size = New System.Drawing.Size(42, 38)
        Me.btimprimir.TabIndex = 60034
        Me.btimprimir.UseVisualStyleBackColor = True
        '
        'bttercero
        '
        Me.bttercero.BackgroundImage = CType(resources.GetObject("bttercero.BackgroundImage"), System.Drawing.Image)
        Me.bttercero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttercero.Image = CType(resources.GetObject("bttercero.Image"), System.Drawing.Image)
        Me.bttercero.Location = New System.Drawing.Point(880, 61)
        Me.bttercero.Name = "bttercero"
        Me.bttercero.Size = New System.Drawing.Size(26, 25)
        Me.bttercero.TabIndex = 60031
        Me.bttercero.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Pimagen)
        Me.Panel2.Controls.Add(Me.LTitulo)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1312, 44)
        Me.Panel2.TabIndex = 3
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.Safe_icon
        Me.Pimagen.Location = New System.Drawing.Point(3, 0)
        Me.Pimagen.Name = "Pimagen"
        Me.Pimagen.Size = New System.Drawing.Size(53, 46)
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pimagen.TabIndex = 1
        Me.Pimagen.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(1, -1)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(1308, 40)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Estado de cuentas"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormEstadoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1310, 616)
        Me.Controls.Add(Me.fechadoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btexcel)
        Me.Controls.Add(Me.btimprimir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textnombreproveedor)
        Me.Controls.Add(Me.bttercero)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1326, 655)
        Me.MinimumSize = New System.Drawing.Size(1326, 655)
        Me.Name = "FormEstadoCuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Panel2 As Panel
    Public WithEvents Pimagen As PictureBox
    Public WithEvents LTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCuentas As DataGridView
    Friend WithEvents dgfactura As DataGridViewTextBoxColumn
    Friend WithEvents dgFechaRadicado As DataGridViewTextBoxColumn
    Friend WithEvents dgFechaVence As DataGridViewTextBoxColumn
    Friend WithEvents dg30Dias As DataGridViewTextBoxColumn
    Friend WithEvents dg60Dias As DataGridViewTextBoxColumn
    Friend WithEvents dg90Dias As DataGridViewTextBoxColumn
    Friend WithEvents dg180Dias As DataGridViewTextBoxColumn
    Friend WithEvents dg360Dias As DataGridViewTextBoxColumn
    Friend WithEvents dgMas360Dias As DataGridViewTextBoxColumn
    Friend WithEvents dgDias As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents text180dias As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents text360dias As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents text30dias As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents text60dias As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents text90dias As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents textvalortotal As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents textmas360dias As TextBox
    Friend WithEvents textnombreproveedor As Label
    Public WithEvents bttercero As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btexcel As Button
    Friend WithEvents btimprimir As Button
    Friend WithEvents Label4 As Label
    Public WithEvents fechadoc As DateTimePicker
End Class
