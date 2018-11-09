<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVenta
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormVenta))
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvFactura = New System.Windows.Forms.DataGridView()
        Me.dgCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextTotalArticulos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextTotalServicio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtFechaFactura = New System.Windows.Forms.DateTimePicker()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextDV = New System.Windows.Forms.TextBox()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox7.Controls.Add(Me.TextDV)
        Me.GroupBox7.Controls.Add(Me.TextTelefono)
        Me.GroupBox7.Controls.Add(Me.TextNombre)
        Me.GroupBox7.Controls.Add(Me.Label17)
        Me.GroupBox7.Controls.Add(Me.TextIdentificacion)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox7.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(876, 52)
        Me.GroupBox7.TabIndex = 10
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Datos del Clíente"
        '
        'TextTelefono
        '
        Me.TextTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTelefono.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTelefono.Location = New System.Drawing.Point(761, 17)
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(111, 25)
        Me.TextTelefono.TabIndex = 2
        Me.TextTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextNombre
        '
        Me.TextNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextNombre.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNombre.Location = New System.Drawing.Point(337, 17)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(345, 25)
        Me.TextNombre.TabIndex = 1
        Me.TextNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(271, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 19)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Nombre:"
        '
        'TextIdentificacion
        '
        Me.TextIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextIdentificacion.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextIdentificacion.Location = New System.Drawing.Point(108, 17)
        Me.TextIdentificacion.Name = "TextIdentificacion"
        Me.TextIdentificacion.Size = New System.Drawing.Size(126, 25)
        Me.TextIdentificacion.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(3, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 19)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Identificación:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(686, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Teléfono:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(888, 450)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvFactura)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.TextTotalArticulos)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextTotalServicio)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TextTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox2.Location = New System.Drawing.Point(6, 60)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(876, 384)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de Factura"
        '
        'dgvFactura
        '
        Me.dgvFactura.AllowUserToAddRows = False
        Me.dgvFactura.AllowUserToDeleteRows = False
        Me.dgvFactura.AllowUserToResizeColumns = False
        Me.dgvFactura.AllowUserToResizeRows = False
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        Me.dgvFactura.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvFactura.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgCodigo, Me.dgDescripcion, Me.dgCantidad, Me.dgValor, Me.dgId, Me.dgTotal, Me.dgQuitar})
        Me.dgvFactura.Location = New System.Drawing.Point(9, 66)
        Me.dgvFactura.MultiSelect = False
        Me.dgvFactura.Name = "dgvFactura"
        Me.dgvFactura.ReadOnly = True
        Me.dgvFactura.Size = New System.Drawing.Size(673, 306)
        Me.dgvFactura.TabIndex = 3
        '
        'dgCodigo
        '
        Me.dgCodigo.HeaderText = "Código"
        Me.dgCodigo.Name = "dgCodigo"
        Me.dgCodigo.ReadOnly = True
        '
        'dgDescripcion
        '
        Me.dgDescripcion.HeaderText = "Descripción"
        Me.dgDescripcion.Name = "dgDescripcion"
        Me.dgDescripcion.ReadOnly = True
        '
        'dgCantidad
        '
        Me.dgCantidad.HeaderText = "Cantidad"
        Me.dgCantidad.Name = "dgCantidad"
        Me.dgCantidad.ReadOnly = True
        '
        'dgValor
        '
        Me.dgValor.HeaderText = "V.Unitario"
        Me.dgValor.Name = "dgValor"
        Me.dgValor.ReadOnly = True
        '
        'dgId
        '
        Me.dgId.HeaderText = "Id"
        Me.dgId.Name = "dgId"
        Me.dgId.ReadOnly = True
        Me.dgId.Visible = False
        '
        'dgTotal
        '
        Me.dgTotal.HeaderText = "Total"
        Me.dgTotal.Name = "dgTotal"
        Me.dgTotal.ReadOnly = True
        '
        'dgQuitar
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.NullValue = CType(resources.GetObject("DataGridViewCellStyle11.NullValue"), Object)
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White
        Me.dgQuitar.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgQuitar.HeaderText = "Quitar"
        Me.dgQuitar.Image = Global.Quality.My.Resources.Resources.papelera
        Me.dgQuitar.Name = "dgQuitar"
        Me.dgQuitar.ReadOnly = True
        Me.dgQuitar.Width = 50
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(6, 53)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(681, 325)
        Me.GroupBox5.TabIndex = 60035
        Me.GroupBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quality.My.Resources.Resources.Quality_logo
        Me.PictureBox1.Location = New System.Drawing.Point(714, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60031
        Me.PictureBox1.TabStop = False
        '
        'TextTotalArticulos
        '
        Me.TextTotalArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTotalArticulos.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotalArticulos.ForeColor = System.Drawing.Color.Black
        Me.TextTotalArticulos.Location = New System.Drawing.Point(703, 223)
        Me.TextTotalArticulos.Name = "TextTotalArticulos"
        Me.TextTotalArticulos.Size = New System.Drawing.Size(155, 29)
        Me.TextTotalArticulos.TabIndex = 999
        Me.TextTotalArticulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = Global.Quality.My.Resources.Resources.fondo_azul
        Me.Label5.Location = New System.Drawing.Point(703, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 38)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Artículos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextTotalServicio
        '
        Me.TextTotalServicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTotalServicio.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotalServicio.ForeColor = System.Drawing.Color.Black
        Me.TextTotalServicio.Location = New System.Drawing.Point(703, 283)
        Me.TextTotalServicio.Name = "TextTotalServicio"
        Me.TextTotalServicio.Size = New System.Drawing.Size(155, 29)
        Me.TextTotalServicio.TabIndex = 9999
        Me.TextTotalServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = Global.Quality.My.Resources.Resources.fondo_azul
        Me.Label4.Location = New System.Drawing.Point(703, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 38)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Servicios"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextTotal
        '
        Me.TextTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotal.ForeColor = System.Drawing.Color.Black
        Me.TextTotal.Location = New System.Drawing.Point(703, 342)
        Me.TextTotal.Name = "TextTotal"
        Me.TextTotal.Size = New System.Drawing.Size(155, 29)
        Me.TextTotal.TabIndex = 9999
        Me.TextTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Image = Global.Quality.My.Resources.Resources.fondo_azul
        Me.Label6.Location = New System.Drawing.Point(703, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 36)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox3.Location = New System.Drawing.Point(693, 189)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(175, 189)
        Me.GroupBox3.TabIndex = 60029
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.TextBox2)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.dtFechaFactura)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(681, 40)
        Me.GroupBox4.TabIndex = 60034
        Me.GroupBox4.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Factura N°:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(106, 11)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(126, 25)
        Me.TextBox2.TabIndex = 9999
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(271, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Fecha:"
        '
        'dtFechaFactura
        '
        Me.dtFechaFactura.Enabled = False
        Me.dtFechaFactura.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFechaFactura.Location = New System.Drawing.Point(336, 11)
        Me.dtFechaFactura.Name = "dtFechaFactura"
        Me.dtFechaFactura.Size = New System.Drawing.Size(340, 25)
        Me.dtFechaFactura.TabIndex = 9999
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        Me.ErrorIcono.Icon = CType(resources.GetObject("ErrorIcono.Icon"), System.Drawing.Icon)
        Me.ErrorIcono.RightToLeft = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.NullValue = CType(resources.GetObject("DataGridViewCellStyle12.NullValue"), Object)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewImageColumn1.HeaderText = "Quitar"
        Me.DataGridViewImageColumn1.Image = Global.Quality.My.Resources.Resources.RecycleBin_Full_icon__2_
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Pimagen)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(900, 42)
        Me.Panel1.TabIndex = 19
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.dinero
        Me.Pimagen.Location = New System.Drawing.Point(4, -7)
        Me.Pimagen.Name = "Pimagen"
        Me.Pimagen.Size = New System.Drawing.Size(69, 53)
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pimagen.TabIndex = 1
        Me.Pimagen.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(900, 44)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Venta de Artículos y Servicios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(26, 26)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btNuevo, Me.ToolStripSeparator2, Me.btBuscar, Me.ToolStripSeparator7, Me.btRegistrar, Me.ToolStripSeparator4, Me.btAnular, Me.ToolStripSeparator3, Me.btCancelar, Me.ToolStripSeparator6, Me.ToolStripButton1, Me.ToolStripSeparator8})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 493)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(900, 33)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'btNuevo
        '
        Me.btNuevo.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.ForeColor = System.Drawing.Color.White
        Me.btNuevo.Image = Global.Quality.My.Resources.Resources.Files_New_File_icon
        Me.btNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(82, 30)
        Me.btNuevo.Text = "&Nuevo"
        Me.btNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.ForeColor = System.Drawing.Color.White
        Me.btBuscar.Image = Global.Quality.My.Resources.Resources.Search_icon__1_
        Me.btBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(86, 30)
        Me.btBuscar.Text = "&Buscar"
        Me.btBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 33)
        '
        'btRegistrar
        '
        Me.btRegistrar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegistrar.ForeColor = System.Drawing.Color.White
        Me.btRegistrar.Image = Global.Quality.My.Resources.Resources.Save_icon__1_
        Me.btRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRegistrar.Name = "btRegistrar"
        Me.btRegistrar.Size = New System.Drawing.Size(101, 30)
        Me.btRegistrar.Text = "&Registrar"
        Me.btRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 33)
        '
        'btAnular
        '
        Me.btAnular.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnular.ForeColor = System.Drawing.Color.White
        Me.btAnular.Image = Global.Quality.My.Resources.Resources.document_delete_icon__1_
        Me.btAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btAnular.Name = "btAnular"
        Me.btAnular.Size = New System.Drawing.Size(87, 30)
        Me.btAnular.Text = "&Anular"
        Me.btAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 33)
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.White
        Me.btCancelar.Image = Global.Quality.My.Resources.Resources.Actions_blue_arrow_undo_icon
        Me.btCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(100, 30)
        Me.btCancelar.Text = "&Cancelar"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 33)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = Global.Quality.My.Resources.Resources.print_icon
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(99, 30)
        Me.ToolStripButton1.Text = "&Imprimir"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 33)
        '
        'TextDV
        '
        Me.TextDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextDV.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDV.Location = New System.Drawing.Point(238, 17)
        Me.TextDV.Name = "TextDV"
        Me.TextDV.Size = New System.Drawing.Size(29, 25)
        Me.TextDV.TabIndex = 9999
        Me.TextDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 526)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(916, 565)
        Me.MinimumSize = New System.Drawing.Size(916, 565)
        Me.Name = "FormVenta"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox7 As GroupBox
    Public WithEvents TextNombre As TextBox
    Public WithEvents Label17 As Label
    Public WithEvents TextIdentificacion As TextBox
    Public WithEvents Label19 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents btNuevo As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Public WithEvents btBuscar As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Public WithEvents btRegistrar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Public WithEvents btCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Public WithEvents btAnular As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Public WithEvents Panel1 As Panel
    Public WithEvents Pimagen As PictureBox
    Public WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents TextTelefono As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents TextTotalArticulos As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents TextTotalServicio As TextBox
    Public WithEvents Label4 As Label
    Friend WithEvents dtFechaFactura As DateTimePicker
    Public WithEvents Label7 As Label
    Public WithEvents TextTotal As TextBox
    Public WithEvents TextBox2 As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents Label6 As Label
    Public WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents dgvFactura As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgCodigo As DataGridViewTextBoxColumn
    Friend WithEvents dgDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgValor As DataGridViewTextBoxColumn
    Friend WithEvents dgId As DataGridViewTextBoxColumn
    Friend WithEvents dgTotal As DataGridViewTextBoxColumn
    Friend WithEvents dgQuitar As DataGridViewImageColumn
    Friend WithEvents ErrorIcono As ErrorProvider
    Public WithEvents TextDV As TextBox
End Class
