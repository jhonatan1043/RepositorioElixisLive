﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCarteraCXP
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.textdiferencia = New System.Windows.Forms.Label()
        Me.textvalorcredito = New System.Windows.Forms.Label()
        Me.textvalordebito = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PnlInfo = New System.Windows.Forms.Panel()
        Me.lbinfo = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvCartera = New System.Windows.Forms.DataGridView()
        Me.dgComprobante = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Factura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tercero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Debito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Credito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anular = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.fechadoc = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textsigla = New System.Windows.Forms.Label()
        Me.Textnombredocumento = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btBusqueda = New System.Windows.Forms.ToolStripButton()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PnlInfo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCartera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.LTitulo)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(905, 34)
        Me.Panel2.TabIndex = 3
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.Black
        Me.LTitulo.Location = New System.Drawing.Point(1, 2)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(777, 28)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Cartera cuentas por pagar"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.textdiferencia)
        Me.GroupBox1.Controls.Add(Me.textvalorcredito)
        Me.GroupBox1.Controls.Add(Me.textvalordebito)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PnlInfo)
        Me.GroupBox1.Controls.Add(Me.dgvCartera)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(892, 437)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'textdiferencia
        '
        Me.textdiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textdiferencia.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textdiferencia.Location = New System.Drawing.Point(693, 406)
        Me.textdiferencia.Name = "textdiferencia"
        Me.textdiferencia.Size = New System.Drawing.Size(186, 25)
        Me.textdiferencia.TabIndex = 60051
        Me.textdiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textvalorcredito
        '
        Me.textvalorcredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textvalorcredito.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textvalorcredito.Location = New System.Drawing.Point(404, 406)
        Me.textvalorcredito.Name = "textvalorcredito"
        Me.textvalorcredito.Size = New System.Drawing.Size(186, 25)
        Me.textvalorcredito.TabIndex = 60050
        Me.textvalorcredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textvalordebito
        '
        Me.textvalordebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textvalordebito.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textvalordebito.Location = New System.Drawing.Point(108, 406)
        Me.textvalordebito.Name = "textvalordebito"
        Me.textvalordebito.Size = New System.Drawing.Size(186, 25)
        Me.textvalordebito.TabIndex = 60049
        Me.textvalordebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 410)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 19)
        Me.Label3.TabIndex = 60046
        Me.Label3.Text = "Valor Débito:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(298, 411)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 19)
        Me.Label11.TabIndex = 60047
        Me.Label11.Text = "Valor Crédito:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(603, 411)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 60048
        Me.Label10.Text = "Diferencia:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PnlInfo
        '
        Me.PnlInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlInfo.Controls.Add(Me.lbinfo)
        Me.PnlInfo.Controls.Add(Me.PictureBox2)
        Me.PnlInfo.Location = New System.Drawing.Point(7, 357)
        Me.PnlInfo.Name = "PnlInfo"
        Me.PnlInfo.Size = New System.Drawing.Size(879, 29)
        Me.PnlInfo.TabIndex = 60032
        Me.PnlInfo.Visible = False
        '
        'lbinfo
        '
        Me.lbinfo.AutoSize = True
        Me.lbinfo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbinfo.Location = New System.Drawing.Point(32, 8)
        Me.lbinfo.Name = "lbinfo"
        Me.lbinfo.Size = New System.Drawing.Size(68, 16)
        Me.lbinfo.TabIndex = 10063
        Me.lbinfo.Text = "CONTENIDO"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Quality.My.Resources.Resources.advertencia
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10063
        Me.PictureBox2.TabStop = False
        '
        'dgvCartera
        '
        Me.dgvCartera.AllowUserToAddRows = False
        Me.dgvCartera.AllowUserToDeleteRows = False
        Me.dgvCartera.AllowUserToResizeColumns = False
        Me.dgvCartera.AllowUserToResizeRows = False
        Me.dgvCartera.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCartera.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvCartera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCartera.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgComprobante, Me.Factura, Me.nit, Me.Tercero, Me.Cuenta, Me.Descripcion, Me.Debito, Me.Credito, Me.Estado, Me.anular})
        Me.dgvCartera.Location = New System.Drawing.Point(6, 91)
        Me.dgvCartera.Name = "dgvCartera"
        Me.dgvCartera.RowHeadersVisible = False
        Me.dgvCartera.Size = New System.Drawing.Size(881, 299)
        Me.dgvCartera.TabIndex = 56
        '
        'dgComprobante
        '
        Me.dgComprobante.HeaderText = "Column1"
        Me.dgComprobante.Name = "dgComprobante"
        Me.dgComprobante.Visible = False
        '
        'Factura
        '
        Me.Factura.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Factura.HeaderText = "No. Factura"
        Me.Factura.Name = "Factura"
        Me.Factura.Width = 86
        '
        'nit
        '
        Me.nit.HeaderText = "idtercero"
        Me.nit.Name = "nit"
        Me.nit.Visible = False
        '
        'Tercero
        '
        Me.Tercero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Tercero.HeaderText = "Tercero"
        Me.Tercero.Name = "Tercero"
        Me.Tercero.Width = 69
        '
        'Cuenta
        '
        Me.Cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cuenta.HeaderText = "Cuenta"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.Width = 65
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Descripcion.HeaderText = "Nombre Cuenta"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 105
        '
        'Debito
        '
        Me.Debito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Format = "C2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.Debito.DefaultCellStyle = DataGridViewCellStyle11
        Me.Debito.HeaderText = "Débito"
        Me.Debito.Name = "Debito"
        Me.Debito.Width = 63
        '
        'Credito
        '
        Me.Credito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.Format = "C2"
        DataGridViewCellStyle12.NullValue = Nothing
        Me.Credito.DefaultCellStyle = DataGridViewCellStyle12
        Me.Credito.HeaderText = "Crédito"
        Me.Credito.Name = "Credito"
        Me.Credito.Width = 67
        '
        'Estado
        '
        Me.Estado.HeaderText = "estado"
        Me.Estado.Name = "Estado"
        Me.Estado.Visible = False
        '
        'anular
        '
        Me.anular.HeaderText = "Quitar"
        Me.anular.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.anular.Name = "anular"
        Me.anular.Width = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.fechadoc)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Textsigla)
        Me.GroupBox2.Controls.Add(Me.Textnombredocumento)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(881, 48)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        '
        'fechadoc
        '
        Me.fechadoc.CustomFormat = "dd |  MMMM |  yyyy"
        Me.fechadoc.Enabled = False
        Me.fechadoc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechadoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechadoc.Location = New System.Drawing.Point(686, 16)
        Me.fechadoc.Name = "fechadoc"
        Me.fechadoc.Size = New System.Drawing.Size(189, 25)
        Me.fechadoc.TabIndex = 60029
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 17)
        Me.Label1.TabIndex = 60026
        Me.Label1.Text = "Tipo Documento:"
        '
        'Textsigla
        '
        Me.Textsigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textsigla.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textsigla.Location = New System.Drawing.Point(117, 16)
        Me.Textsigla.Name = "Textsigla"
        Me.Textsigla.Size = New System.Drawing.Size(74, 25)
        Me.Textsigla.TabIndex = 60025
        Me.Textsigla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Textnombredocumento
        '
        Me.Textnombredocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textnombredocumento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textnombredocumento.Location = New System.Drawing.Point(197, 16)
        Me.Textnombredocumento.Name = "Textnombredocumento"
        Me.Textnombredocumento.Size = New System.Drawing.Size(358, 25)
        Me.Textnombredocumento.TabIndex = 60024
        Me.Textnombredocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(560, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 17)
        Me.Label21.TabIndex = 60028
        Me.Label21.Text = "Fecha Documento:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btNuevo, Me.btBusqueda, Me.btRegistrar, Me.btEditar, Me.btCancelar, Me.btAnular})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 491)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(905, 32)
        Me.ToolStrip1.TabIndex = 1003
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
        'btEditar
        '
        Me.btEditar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEditar.ForeColor = System.Drawing.Color.Black
        Me.btEditar.Image = Global.Quality.My.Resources.Resources.Pencil_icon
        Me.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(81, 29)
        Me.btEditar.Text = "&Editar"
        Me.btEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
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
        'FormCarteraCXP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 523)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(921, 562)
        Me.MinimumSize = New System.Drawing.Size(921, 562)
        Me.Name = "FormCarteraCXP"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.PnlInfo.ResumeLayout(False)
        Me.PnlInfo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCartera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Panel2 As Panel
    Public WithEvents LTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents PnlInfo As Panel
    Public WithEvents lbinfo As Label
    Public WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvCartera As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Textsigla As Label
    Friend WithEvents Textnombredocumento As Label
    Public WithEvents btBuscar As ToolStripButton
    Friend WithEvents Label1 As Label
    Public WithEvents fechadoc As DateTimePicker
    Friend WithEvents Label21 As Label
    Friend WithEvents textdiferencia As Label
    Friend WithEvents textvalorcredito As Label
    Friend WithEvents textvalordebito As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dgComprobante As DataGridViewTextBoxColumn
    Friend WithEvents Factura As DataGridViewTextBoxColumn
    Friend WithEvents nit As DataGridViewTextBoxColumn
    Friend WithEvents Tercero As DataGridViewTextBoxColumn
    Friend WithEvents Cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Debito As DataGridViewTextBoxColumn
    Friend WithEvents Credito As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents anular As DataGridViewImageColumn
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents btNuevo As ToolStripButton
    Public WithEvents btBusqueda As ToolStripButton
    Public WithEvents btRegistrar As ToolStripButton
    Public WithEvents btEditar As ToolStripButton
    Public WithEvents btCancelar As ToolStripButton
    Public WithEvents btAnular As ToolStripButton
End Class
