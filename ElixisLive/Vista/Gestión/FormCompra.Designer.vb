<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCompra
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCompra))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvFactura = New System.Windows.Forms.DataGridView()
        Me.dgCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtCantidadArticulos = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtValorTotal = New System.Windows.Forms.TextBox()
        Me.txtNumeroFatura = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GpDatos = New System.Windows.Forms.GroupBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextDV = New System.Windows.Forms.TextBox()
        Me.TextNombre = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextIdentificacion = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btBusqueda = New System.Windows.Forms.ToolStripButton()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.btImprimir = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GpDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GpDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(888, 450)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvFactura)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.txtCantidadArticulos)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.dtFecha)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtValorTotal)
        Me.GroupBox2.Controls.Add(Me.txtNumeroFatura)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox2.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(876, 384)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de la compra"
        '
        'dgvFactura
        '
        Me.dgvFactura.AllowUserToAddRows = False
        Me.dgvFactura.AllowUserToDeleteRows = False
        Me.dgvFactura.AllowUserToResizeColumns = False
        Me.dgvFactura.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvFactura.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvFactura.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFactura.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFactura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgCodigo, Me.dgDescripcion, Me.dgCantidad, Me.dgValor, Me.dgTotal, Me.dgQuitar})
        Me.dgvFactura.Location = New System.Drawing.Point(10, 56)
        Me.dgvFactura.MultiSelect = False
        Me.dgvFactura.Name = "dgvFactura"
        Me.dgvFactura.ReadOnly = True
        Me.dgvFactura.Size = New System.Drawing.Size(677, 322)
        Me.dgvFactura.TabIndex = 60032
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
        'dgTotal
        '
        Me.dgTotal.HeaderText = "Total"
        Me.dgTotal.Name = "dgTotal"
        Me.dgTotal.ReadOnly = True
        '
        'dgQuitar
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = CType(resources.GetObject("DataGridViewCellStyle3.NullValue"), Object)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        Me.dgQuitar.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgQuitar.HeaderText = "Quitar"
        Me.dgQuitar.Name = "dgQuitar"
        Me.dgQuitar.ReadOnly = True
        Me.dgQuitar.Width = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quality.My.Resources.Resources.XANDaR
        Me.PictureBox1.Location = New System.Drawing.Point(696, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 169)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 60031
        Me.PictureBox1.TabStop = False
        '
        'txtCantidadArticulos
        '
        Me.txtCantidadArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadArticulos.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadArticulos.Location = New System.Drawing.Point(705, 288)
        Me.txtCantidadArticulos.Name = "txtCantidadArticulos"
        Me.txtCantidadArticulos.Size = New System.Drawing.Size(155, 29)
        Me.txtCantidadArticulos.TabIndex = 25
        Me.txtCantidadArticulos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(705, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 36)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Artículos"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dtFecha
        '
        Me.dtFecha.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Location = New System.Drawing.Point(375, 20)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(272, 25)
        Me.dtFecha.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(305, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Fecha:"
        '
        'txtValorTotal
        '
        Me.txtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValorTotal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValorTotal.Location = New System.Drawing.Point(705, 342)
        Me.txtValorTotal.Name = "txtValorTotal"
        Me.txtValorTotal.Size = New System.Drawing.Size(155, 29)
        Me.txtValorTotal.TabIndex = 19
        Me.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNumeroFatura
        '
        Me.txtNumeroFatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumeroFatura.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroFatura.Location = New System.Drawing.Point(107, 20)
        Me.txtNumeroFatura.Name = "txtNumeroFatura"
        Me.txtNumeroFatura.Size = New System.Drawing.Size(157, 25)
        Me.txtNumeroFatura.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Factura N°:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(705, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 36)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Total"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox3.Location = New System.Drawing.Point(693, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(177, 134)
        Me.GroupBox3.TabIndex = 60029
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'GpDatos
        '
        Me.GpDatos.BackColor = System.Drawing.Color.Transparent
        Me.GpDatos.Controls.Add(Me.txtTelefono)
        Me.GpDatos.Controls.Add(Me.Label2)
        Me.GpDatos.Controls.Add(Me.TextDV)
        Me.GpDatos.Controls.Add(Me.TextNombre)
        Me.GpDatos.Controls.Add(Me.Label17)
        Me.GpDatos.Controls.Add(Me.TextIdentificacion)
        Me.GpDatos.Controls.Add(Me.Label19)
        Me.GpDatos.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpDatos.ForeColor = System.Drawing.Color.DarkBlue
        Me.GpDatos.Location = New System.Drawing.Point(6, 6)
        Me.GpDatos.Name = "GpDatos"
        Me.GpDatos.Size = New System.Drawing.Size(876, 52)
        Me.GpDatos.TabIndex = 10
        Me.GpDatos.TabStop = False
        Me.GpDatos.Text = "Información del proveedor"
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(731, 18)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(138, 25)
        Me.txtTelefono.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(654, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Teléfono:"
        '
        'TextDV
        '
        Me.TextDV.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TextDV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextDV.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDV.Location = New System.Drawing.Point(239, 17)
        Me.TextDV.Name = "TextDV"
        Me.TextDV.Size = New System.Drawing.Size(29, 25)
        Me.TextDV.TabIndex = 8
        Me.TextDV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextNombre
        '
        Me.TextNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextNombre.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNombre.Location = New System.Drawing.Point(379, 17)
        Me.TextNombre.Name = "TextNombre"
        Me.TextNombre.Size = New System.Drawing.Size(274, 25)
        Me.TextNombre.TabIndex = 9
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(306, 20)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 19)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "Nombre:"
        '
        'TextIdentificacion
        '
        Me.TextIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextIdentificacion.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextIdentificacion.Location = New System.Drawing.Point(111, 17)
        Me.TextIdentificacion.Name = "TextIdentificacion"
        Me.TextIdentificacion.Size = New System.Drawing.Size(126, 25)
        Me.TextIdentificacion.TabIndex = 5
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
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = CType(resources.GetObject("DataGridViewCellStyle4.NullValue"), Object)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewImageColumn1.HeaderText = "Quitar"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LTitulo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 34)
        Me.Panel1.TabIndex = 20
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.Black
        Me.LTitulo.Location = New System.Drawing.Point(3, 3)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(832, 28)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Compras"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        Me.ErrorIcono.RightToLeft = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btNuevo, Me.btBusqueda, Me.btRegistrar, Me.btCancelar, Me.btAnular, Me.btImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 494)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(900, 32)
        Me.ToolStrip1.TabIndex = 1002
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'btNuevo
        '
        Me.btNuevo.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.ForeColor = System.Drawing.Color.Black
        Me.btNuevo.Image = Global.Quality.My.Resources.Resources.Add_File_icon
        Me.btNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(81, 29)
        Me.btNuevo.Text = "&Nuevo"
        Me.btNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btBusqueda
        '
        Me.btBusqueda.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBusqueda.ForeColor = System.Drawing.Color.Black
        Me.btBusqueda.Image = Global.Quality.My.Resources.Resources.Very_Basic_Search_icon
        Me.btBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBusqueda.Name = "btBusqueda"
        Me.btBusqueda.Size = New System.Drawing.Size(85, 29)
        Me.btBusqueda.Text = "&Buscar"
        Me.btBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btRegistrar
        '
        Me.btRegistrar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegistrar.ForeColor = System.Drawing.Color.Black
        Me.btRegistrar.Image = Global.Quality.My.Resources.Resources.User_Interface_Save_As_icon
        Me.btRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRegistrar.Name = "btRegistrar"
        Me.btRegistrar.Size = New System.Drawing.Size(100, 29)
        Me.btRegistrar.Text = "&Registrar"
        Me.btRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.Black
        Me.btCancelar.Image = Global.Quality.My.Resources.Resources.Arrows_Right_2_icon
        Me.btCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(99, 29)
        Me.btCancelar.Text = "&Cancelar"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btAnular
        '
        Me.btAnular.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnular.ForeColor = System.Drawing.Color.Black
        Me.btAnular.Image = Global.Quality.My.Resources.Resources.Files_Delete_File_icon
        Me.btAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btAnular.Name = "btAnular"
        Me.btAnular.Size = New System.Drawing.Size(86, 29)
        Me.btAnular.Text = "&Anular"
        Me.btAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btImprimir
        '
        Me.btImprimir.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btImprimir.ForeColor = System.Drawing.Color.Black
        Me.btImprimir.Image = Global.Quality.My.Resources.Resources.Computer_Hardware_Print_icon
        Me.btImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(98, 29)
        Me.btImprimir.Text = "&Imprimir"
        Me.btImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FormCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 526)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(916, 565)
        Me.MinimumSize = New System.Drawing.Size(916, 565)
        Me.Name = "FormCompra"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvFactura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GpDatos.ResumeLayout(False)
        Me.GpDatos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Panel1 As Panel
    Public WithEvents LTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Public WithEvents txtCantidadArticulos As TextBox
    Public WithEvents Label5 As Label
    Friend WithEvents dtFecha As DateTimePicker
    Public WithEvents Label7 As Label
    Public WithEvents txtValorTotal As TextBox
    Public WithEvents txtNumeroFatura As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GpDatos As GroupBox
    Public WithEvents txtTelefono As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents TextDV As TextBox
    Public WithEvents TextNombre As TextBox
    Public WithEvents Label17 As Label
    Public WithEvents TextIdentificacion As TextBox
    Public WithEvents Label19 As Label
    Public WithEvents btBuscar As ToolStripButton
    Friend WithEvents btBuscarProveedor As Button
    Public WithEvents dgvFactura As DataGridView
    Friend WithEvents dgCodigo As DataGridViewTextBoxColumn
    Friend WithEvents dgDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgValor As DataGridViewTextBoxColumn
    Friend WithEvents dgTotal As DataGridViewTextBoxColumn
    Friend WithEvents dgQuitar As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ErrorIcono As ErrorProvider
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents btNuevo As ToolStripButton
    Public WithEvents btBusqueda As ToolStripButton
    Public WithEvents btRegistrar As ToolStripButton
    Public WithEvents btCancelar As ToolStripButton
    Public WithEvents btAnular As ToolStripButton
    Public WithEvents btImprimir As ToolStripButton
End Class
