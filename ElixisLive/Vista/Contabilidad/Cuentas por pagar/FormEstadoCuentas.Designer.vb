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
        Me.textnombretercero = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fechaFin = New System.Windows.Forms.DateTimePicker()
        Me.btexcel = New System.Windows.Forms.Button()
        Me.btimprimir = New System.Windows.Forms.Button()
        Me.btBusquedaCuenta = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.text180dias = New System.Windows.Forms.TextBox()
        Me.text360dias = New System.Windows.Forms.TextBox()
        Me.text30dias = New System.Windows.Forms.TextBox()
        Me.text60dias = New System.Windows.Forms.TextBox()
        Me.text90dias = New System.Windows.Forms.TextBox()
        Me.textvalortotal = New System.Windows.Forms.TextBox()
        Me.textmas360dias = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.fechaIni = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvCuentas)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1073, 366)
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
        Me.dgvCuentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCuentas.Location = New System.Drawing.Point(3, 16)
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
        Me.dgvCuentas.Size = New System.Drawing.Size(1067, 347)
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
        'textnombretercero
        '
        Me.textnombretercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textnombretercero.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textnombretercero.Location = New System.Drawing.Point(74, 61)
        Me.textnombretercero.Name = "textnombretercero"
        Me.textnombretercero.Size = New System.Drawing.Size(551, 25)
        Me.textnombretercero.TabIndex = 60032
        Me.textnombretercero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 60033
        Me.Label3.Text = "Tercero:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(682, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 17)
        Me.Label4.TabIndex = 60036
        Me.Label4.Text = "Hasta:"
        '
        'fechaFin
        '
        Me.fechaFin.CustomFormat = "dd |  MMMM |  yyyy"
        Me.fechaFin.Enabled = False
        Me.fechaFin.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaFin.Location = New System.Drawing.Point(734, 62)
        Me.fechaFin.Name = "fechaFin"
        Me.fechaFin.Size = New System.Drawing.Size(189, 25)
        Me.fechaFin.TabIndex = 60037
        '
        'btexcel
        '
        Me.btexcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btexcel.Enabled = False
        Me.btexcel.Image = Global.Quality.My.Resources.Resources.Microsoft_Excel_2013_icon1
        Me.btexcel.Location = New System.Drawing.Point(1026, 55)
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
        Me.btimprimir.Location = New System.Drawing.Point(967, 55)
        Me.btimprimir.Name = "btimprimir"
        Me.btimprimir.Size = New System.Drawing.Size(42, 38)
        Me.btimprimir.TabIndex = 60034
        Me.btimprimir.UseVisualStyleBackColor = True
        '
        'btBusquedaCuenta
        '
        Me.btBusquedaCuenta.BackgroundImage = CType(resources.GetObject("btBusquedaCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btBusquedaCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBusquedaCuenta.Image = CType(resources.GetObject("btBusquedaCuenta.Image"), System.Drawing.Image)
        Me.btBusquedaCuenta.Location = New System.Drawing.Point(634, 61)
        Me.btBusquedaCuenta.Name = "btBusquedaCuenta"
        Me.btBusquedaCuenta.Size = New System.Drawing.Size(26, 25)
        Me.btBusquedaCuenta.TabIndex = 60031
        Me.btBusquedaCuenta.UseVisualStyleBackColor = True
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
        Me.Panel2.Size = New System.Drawing.Size(1078, 44)
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
        Me.LTitulo.Size = New System.Drawing.Size(1077, 40)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Estado de cuentas"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.text180dias)
        Me.GroupBox3.Controls.Add(Me.text360dias)
        Me.GroupBox3.Controls.Add(Me.text30dias)
        Me.GroupBox3.Controls.Add(Me.text60dias)
        Me.GroupBox3.Controls.Add(Me.text90dias)
        Me.GroupBox3.Controls.Add(Me.textvalortotal)
        Me.GroupBox3.Controls.Add(Me.textmas360dias)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(2, 454)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1073, 58)
        Me.GroupBox3.TabIndex = 10061
        Me.GroupBox3.TabStop = False
        '
        'text180dias
        '
        Me.text180dias.BackColor = System.Drawing.Color.White
        Me.text180dias.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text180dias.Location = New System.Drawing.Point(469, 29)
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
        Me.text360dias.Location = New System.Drawing.Point(624, 29)
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
        Me.text30dias.Location = New System.Drawing.Point(13, 29)
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
        Me.text60dias.Location = New System.Drawing.Point(160, 29)
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
        Me.text90dias.Location = New System.Drawing.Point(318, 29)
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
        Me.textvalortotal.Location = New System.Drawing.Point(938, 29)
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
        Me.textmas360dias.Location = New System.Drawing.Point(789, 29)
        Me.textmas360dias.Name = "textmas360dias"
        Me.textmas360dias.ReadOnly = True
        Me.textmas360dias.Size = New System.Drawing.Size(115, 25)
        Me.textmas360dias.TabIndex = 13
        Me.textmas360dias.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(20, 61, 113)
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " De 1 a 30 Días"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(20, 61, 113)
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(160, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "De 31 a 60 Días"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(20, 61, 113)
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(624, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 27)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = " De 181 a 360 Días"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(20, 61, 113)
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(318, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 27)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "De 61 a 90 Días"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(20, 61, 113)
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(938, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(115, 27)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Valor Total"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(20, 61, 113)
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(469, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 27)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "De 91 a 180 Días"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(20, 61, 113)
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(789, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 27)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "A Mas 360 Días"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fechaIni
        '
        Me.fechaIni.CustomFormat = "dd |  MMMM |  yyyy"
        Me.fechaIni.Enabled = False
        Me.fechaIni.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaIni.Location = New System.Drawing.Point(499, 296)
        Me.fechaIni.Name = "fechaIni"
        Me.fechaIni.Size = New System.Drawing.Size(189, 25)
        Me.fechaIni.TabIndex = 60038
        '
        'FormEstadoCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1078, 514)
        Me.Controls.Add(Me.fechaFin)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btexcel)
        Me.Controls.Add(Me.btimprimir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textnombretercero)
        Me.Controls.Add(Me.btBusquedaCuenta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.fechaIni)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1203, 616)
        Me.Name = "FormEstadoCuentas"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
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
    Friend WithEvents textnombretercero As Label
    Public WithEvents btBusquedaCuenta As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btexcel As Button
    Friend WithEvents btimprimir As Button
    Friend WithEvents Label4 As Label
    Public WithEvents fechaFin As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents text180dias As TextBox
    Friend WithEvents text360dias As TextBox
    Friend WithEvents text30dias As TextBox
    Friend WithEvents text60dias As TextBox
    Friend WithEvents text90dias As TextBox
    Friend WithEvents textvalortotal As TextBox
    Friend WithEvents textmas360dias As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Public WithEvents fechaIni As DateTimePicker
End Class
