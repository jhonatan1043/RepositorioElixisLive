<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCajaBanco
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PnlInfo = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbinfo = New System.Windows.Forms.Label()
        Me.dgvcuentas = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Textdetalle = New System.Windows.Forms.TextBox()
        Me.Rbanco = New System.Windows.Forms.RadioButton()
        Me.Rcaja = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.fechadoc = New System.Windows.Forms.DateTimePicker()
        Me.txtcodigo = New System.Windows.Forms.Label()
        Me.Textsigla = New System.Windows.Forms.Label()
        Me.Textnombredocumento = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.txtNaturaleza = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.base = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.lblivarete = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.codigoCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.debito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.credito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anular = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PnlInfo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Pimagen)
        Me.Panel2.Controls.Add(Me.LTitulo)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(905, 44)
        Me.Panel2.TabIndex = 3
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.bank_icon
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
        Me.LTitulo.Size = New System.Drawing.Size(904, 40)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Caja - Banco"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.PnlInfo)
        Me.GroupBox1.Controls.Add(Me.dgvcuentas)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(893, 438)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'PnlInfo
        '
        Me.PnlInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlInfo.Controls.Add(Me.PictureBox2)
        Me.PnlInfo.Controls.Add(Me.lbinfo)
        Me.PnlInfo.Location = New System.Drawing.Point(8, 401)
        Me.PnlInfo.Name = "PnlInfo"
        Me.PnlInfo.Size = New System.Drawing.Size(875, 29)
        Me.PnlInfo.TabIndex = 60032
        Me.PnlInfo.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Quality.My.Resources.Resources.atencion
        Me.PictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10063
        Me.PictureBox2.TabStop = False
        '
        'lbinfo
        '
        Me.lbinfo.AutoSize = True
        Me.lbinfo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbinfo.Location = New System.Drawing.Point(32, 6)
        Me.lbinfo.Name = "lbinfo"
        Me.lbinfo.Size = New System.Drawing.Size(68, 16)
        Me.lbinfo.TabIndex = 10063
        Me.lbinfo.Text = "CONTENIDO"
        '
        'dgvcuentas
        '
        Me.dgvcuentas.AllowUserToAddRows = False
        Me.dgvcuentas.AllowUserToDeleteRows = False
        Me.dgvcuentas.AllowUserToResizeColumns = False
        Me.dgvcuentas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvcuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvcuentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvcuentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvcuentas.BackgroundColor = System.Drawing.Color.White
        Me.dgvcuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.dgvcuentas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvcuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvcuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvcuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.codigoCuenta, Me.nombre, Me.debito, Me.estado, Me.credito, Me.orden, Me.anular})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcuentas.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvcuentas.Location = New System.Drawing.Point(6, 160)
        Me.dgvcuentas.MultiSelect = False
        Me.dgvcuentas.Name = "dgvcuentas"
        Me.dgvcuentas.RowHeadersVisible = False
        Me.dgvcuentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvcuentas.ShowCellErrors = False
        Me.dgvcuentas.ShowCellToolTips = False
        Me.dgvcuentas.ShowEditingIcon = False
        Me.dgvcuentas.ShowRowErrors = False
        Me.dgvcuentas.Size = New System.Drawing.Size(879, 272)
        Me.dgvcuentas.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Textsigla)
        Me.GroupBox2.Controls.Add(Me.Textnombredocumento)
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Controls.Add(Me.fechadoc)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Rbanco)
        Me.GroupBox2.Controls.Add(Me.Rcaja)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(878, 147)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(300, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 15)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "Fecha Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 60017
        Me.Label4.Text = "Tipo Documento:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Textdetalle)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(866, 67)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle del Movimiento"
        '
        'Textdetalle
        '
        Me.Textdetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textdetalle.Location = New System.Drawing.Point(6, 17)
        Me.Textdetalle.Multiline = True
        Me.Textdetalle.Name = "Textdetalle"
        Me.Textdetalle.Size = New System.Drawing.Size(854, 44)
        Me.Textdetalle.TabIndex = 0
        '
        'Rbanco
        '
        Me.Rbanco.AutoSize = True
        Me.Rbanco.Location = New System.Drawing.Point(756, 18)
        Me.Rbanco.Name = "Rbanco"
        Me.Rbanco.Size = New System.Drawing.Size(62, 17)
        Me.Rbanco.TabIndex = 34
        Me.Rbanco.Text = "BANCO"
        Me.Rbanco.UseVisualStyleBackColor = True
        '
        'Rcaja
        '
        Me.Rcaja.AutoSize = True
        Me.Rcaja.Checked = True
        Me.Rcaja.Location = New System.Drawing.Point(695, 17)
        Me.Rcaja.Name = "Rcaja"
        Me.Rcaja.Size = New System.Drawing.Size(51, 17)
        Me.Rcaja.TabIndex = 33
        Me.Rcaja.TabStop = True
        Me.Rcaja.Text = "CAJA"
        Me.Rcaja.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(12, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(107, 15)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "No. Comprobante:"
        '
        'fechadoc
        '
        Me.fechadoc.CustomFormat = "dd |  MMMM |  yyyy"
        Me.fechadoc.Enabled = False
        Me.fechadoc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechadoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechadoc.Location = New System.Drawing.Point(417, 15)
        Me.fechadoc.Name = "fechadoc"
        Me.fechadoc.Size = New System.Drawing.Size(189, 25)
        Me.fechadoc.TabIndex = 60028
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(124, 16)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(170, 25)
        Me.txtcodigo.TabIndex = 60034
        Me.txtcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Textsigla
        '
        Me.Textsigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textsigla.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textsigla.Location = New System.Drawing.Point(124, 45)
        Me.Textsigla.Name = "Textsigla"
        Me.Textsigla.Size = New System.Drawing.Size(78, 25)
        Me.Textsigla.TabIndex = 60036
        Me.Textsigla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Textnombredocumento
        '
        Me.Textnombredocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textnombredocumento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textnombredocumento.Location = New System.Drawing.Point(205, 45)
        Me.Textnombredocumento.Name = "Textnombredocumento"
        Me.Textnombredocumento.Size = New System.Drawing.Size(664, 25)
        Me.Textnombredocumento.TabIndex = 60035
        Me.Textnombredocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btNuevo, Me.btBuscar, Me.btRegistrar, Me.btEditar, Me.btCancelar, Me.btAnular})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 486)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(905, 37)
        Me.ToolStrip1.TabIndex = 78
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btNuevo
        '
        Me.btNuevo.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.ForeColor = System.Drawing.Color.White
        Me.btNuevo.Image = Global.Quality.My.Resources.Resources.Files_New_File_icon
        Me.btNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(86, 34)
        Me.btNuevo.Text = "Nuevo"
        Me.btNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btBuscar
        '
        Me.btBuscar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBuscar.ForeColor = System.Drawing.Color.White
        Me.btBuscar.Image = Global.Quality.My.Resources.Resources.Search_icon
        Me.btBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(90, 34)
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btRegistrar
        '
        Me.btRegistrar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegistrar.ForeColor = System.Drawing.Color.White
        Me.btRegistrar.Image = Global.Quality.My.Resources.Resources.Save_icon__1_
        Me.btRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRegistrar.Name = "btRegistrar"
        Me.btRegistrar.Size = New System.Drawing.Size(105, 34)
        Me.btRegistrar.Text = "Registrar"
        Me.btRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btEditar
        '
        Me.btEditar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEditar.ForeColor = System.Drawing.Color.White
        Me.btEditar.Image = Global.Quality.My.Resources.Resources.pencil_icon__1_
        Me.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(86, 34)
        Me.btEditar.Text = "Editar"
        Me.btEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.White
        Me.btCancelar.Image = Global.Quality.My.Resources.Resources.Actions_blue_arrow_undo_icon
        Me.btCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(104, 34)
        Me.btCancelar.Text = "Cancelar"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btAnular
        '
        Me.btAnular.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnular.ForeColor = System.Drawing.Color.White
        Me.btAnular.Image = Global.Quality.My.Resources.Resources.document_delete_icon__1_
        Me.btAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btAnular.Name = "btAnular"
        Me.btAnular.Size = New System.Drawing.Size(91, 34)
        Me.btAnular.Text = "Anular"
        Me.btAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtTotal)
        Me.Panel3.Controls.Add(Me.txtNaturaleza)
        Me.Panel3.Controls.Add(Me.txtPorcentaje)
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.Label29)
        Me.Panel3.Controls.Add(Me.Label28)
        Me.Panel3.Controls.Add(Me.base)
        Me.Panel3.Controls.Add(Me.Label30)
        Me.Panel3.Controls.Add(Me.Label31)
        Me.Panel3.Controls.Add(Me.lblivarete)
        Me.Panel3.Controls.Add(Me.Label32)
        Me.Panel3.Location = New System.Drawing.Point(283, 224)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(296, 114)
        Me.Panel3.TabIndex = 60033
        Me.Panel3.Visible = False
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(159, 63)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(123, 25)
        Me.txtTotal.TabIndex = 60046
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNaturaleza
        '
        Me.txtNaturaleza.BackColor = System.Drawing.Color.White
        Me.txtNaturaleza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNaturaleza.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNaturaleza.Location = New System.Drawing.Point(245, 30)
        Me.txtNaturaleza.Name = "txtNaturaleza"
        Me.txtNaturaleza.Size = New System.Drawing.Size(37, 25)
        Me.txtNaturaleza.TabIndex = 60045
        Me.txtNaturaleza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.BackColor = System.Drawing.Color.White
        Me.txtPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPorcentaje.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentaje.Location = New System.Drawing.Point(74, 30)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(37, 25)
        Me.txtPorcentaje.TabIndex = 60044
        Me.txtPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(175, 35)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(73, 16)
        Me.Label33.TabIndex = 10
        Me.Label33.Text = "Naturaleza:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(115, 35)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(19, 16)
        Me.Label29.TabIndex = 8
        Me.Label29.Text = "%"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(202, 87)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(37, 16)
        Me.Label28.TabIndex = 6
        Me.Label28.Text = "Total"
        '
        'base
        '
        Me.base.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.base.Location = New System.Drawing.Point(8, 64)
        Me.base.Name = "base"
        Me.base.Size = New System.Drawing.Size(119, 22)
        Me.base.TabIndex = 5
        Me.base.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(49, 87)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(35, 16)
        Me.Label30.TabIndex = 4
        Me.Label30.Text = "Base"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(6, 35)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(72, 16)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Porcentaje:"
        '
        'lblivarete
        '
        Me.lblivarete.AutoSize = True
        Me.lblivarete.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblivarete.ForeColor = System.Drawing.Color.White
        Me.lblivarete.Location = New System.Drawing.Point(60, 12)
        Me.lblivarete.Name = "lblivarete"
        Me.lblivarete.Size = New System.Drawing.Size(19, 15)
        Me.lblivarete.TabIndex = 1
        Me.lblivarete.Text = "Rt"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(6, 12)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(52, 16)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Cuenta:"
        '
        'codigoCuenta
        '
        Me.codigoCuenta.HeaderText = "Cuenta"
        Me.codigoCuenta.Name = "codigoCuenta"
        '
        'nombre
        '
        Me.nombre.HeaderText = "Descripción"
        Me.nombre.Name = "nombre"
        '
        'debito
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.debito.DefaultCellStyle = DataGridViewCellStyle3
        Me.debito.HeaderText = "Débito"
        Me.debito.Name = "debito"
        '
        'estado
        '
        Me.estado.HeaderText = "Estado"
        Me.estado.Name = "estado"
        Me.estado.Visible = False
        '
        'credito
        '
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = "0"
        Me.credito.DefaultCellStyle = DataGridViewCellStyle4
        Me.credito.HeaderText = "Crédito"
        Me.credito.Name = "credito"
        '
        'orden
        '
        Me.orden.HeaderText = "orden"
        Me.orden.Name = "orden"
        Me.orden.Visible = False
        '
        'anular
        '
        Me.anular.HeaderText = "Quitar"
        Me.anular.Image = Global.Quality.My.Resources.Resources.papelera
        Me.anular.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.anular.Name = "anular"
        Me.anular.Width = 50
        '
        'FormCajaBanco
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
        Me.Name = "FormCajaBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.PnlInfo.ResumeLayout(False)
        Me.PnlInfo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Panel2 As Panel
    Public WithEvents Pimagen As PictureBox
    Public WithEvents LTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents PnlInfo As Panel
    Public WithEvents PictureBox2 As PictureBox
    Public WithEvents lbinfo As Label
    Friend WithEvents dgvcuentas As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Textdetalle As TextBox
    Friend WithEvents Rbanco As RadioButton
    Friend WithEvents Rcaja As RadioButton
    Friend WithEvents Label15 As Label
    Public WithEvents fechadoc As DateTimePicker
    Friend WithEvents txtcodigo As Label
    Friend WithEvents Textsigla As Label
    Friend WithEvents Textnombredocumento As Label
    Public WithEvents ToolStrip1 As ToolStrip
    Public WithEvents btNuevo As ToolStripButton
    Public WithEvents btBuscar As ToolStripButton
    Public WithEvents btRegistrar As ToolStripButton
    Public WithEvents btEditar As ToolStripButton
    Public WithEvents btCancelar As ToolStripButton
    Public WithEvents btAnular As ToolStripButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTotal As Label
    Friend WithEvents txtNaturaleza As Label
    Friend WithEvents txtPorcentaje As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents base As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblivarete As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents codigoCuenta As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents debito As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
    Friend WithEvents credito As DataGridViewTextBoxColumn
    Friend WithEvents orden As DataGridViewTextBoxColumn
    Friend WithEvents anular As DataGridViewImageColumn
End Class
