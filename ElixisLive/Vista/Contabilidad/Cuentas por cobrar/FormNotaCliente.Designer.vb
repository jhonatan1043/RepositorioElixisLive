<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNotaCliente
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNotaCliente))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.textObservacion = New System.Windows.Forms.TextBox()
        Me.textdiferencia = New System.Windows.Forms.Label()
        Me.textvalorcredito = New System.Windows.Forms.Label()
        Me.textvalordebito = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PnlInfo = New System.Windows.Forms.Panel()
        Me.lbinfo = New System.Windows.Forms.Label()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtcodigo = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.textnombreproveedor = New System.Windows.Forms.Label()
        Me.textCodigoCliente = New System.Windows.Forms.Label()
        Me.Textsigla = New System.Windows.Forms.Label()
        Me.Textnombredocumento = New System.Windows.Forms.Label()
        Me.fechadoc = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btBusquedaDocumento = New System.Windows.Forms.Button()
        Me.dgvCuentas = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btBuscar = New System.Windows.Forms.ToolStripButton()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.bttercero = New System.Windows.Forms.Button()
        Me.anular = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.PnlInfo.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.textdiferencia)
        Me.GroupBox1.Controls.Add(Me.textvalorcredito)
        Me.GroupBox1.Controls.Add(Me.textvalordebito)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.PnlInfo)
        Me.GroupBox1.Controls.Add(Me.Panel3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dgvCuentas)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 441)
        Me.GroupBox1.TabIndex = 75
        Me.GroupBox1.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.textObservacion)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(6, 105)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(884, 61)
        Me.GroupBox4.TabIndex = 60044
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle del movimiento"
        '
        'textObservacion
        '
        Me.textObservacion.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textObservacion.Location = New System.Drawing.Point(5, 17)
        Me.textObservacion.Multiline = True
        Me.textObservacion.Name = "textObservacion"
        Me.textObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textObservacion.Size = New System.Drawing.Size(873, 37)
        Me.textObservacion.TabIndex = 0
        '
        'textdiferencia
        '
        Me.textdiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textdiferencia.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textdiferencia.Location = New System.Drawing.Point(687, 412)
        Me.textdiferencia.Name = "textdiferencia"
        Me.textdiferencia.Size = New System.Drawing.Size(186, 25)
        Me.textdiferencia.TabIndex = 60043
        Me.textdiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textvalorcredito
        '
        Me.textvalorcredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textvalorcredito.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textvalorcredito.Location = New System.Drawing.Point(398, 412)
        Me.textvalorcredito.Name = "textvalorcredito"
        Me.textvalorcredito.Size = New System.Drawing.Size(186, 25)
        Me.textvalorcredito.TabIndex = 60042
        Me.textvalorcredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textvalordebito
        '
        Me.textvalordebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textvalordebito.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textvalordebito.Location = New System.Drawing.Point(102, 412)
        Me.textvalordebito.Name = "textvalordebito"
        Me.textvalordebito.Size = New System.Drawing.Size(186, 25)
        Me.textvalordebito.TabIndex = 60041
        Me.textvalordebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 60038
        Me.Label1.Text = "Valor Débito:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(292, 417)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 19)
        Me.Label11.TabIndex = 60039
        Me.Label11.Text = "Valor Crédito:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(597, 417)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 60040
        Me.Label10.Text = "Diferencia:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PnlInfo
        '
        Me.PnlInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlInfo.Controls.Add(Me.lbinfo)
        Me.PnlInfo.Controls.Add(Me.PictureBox2)
        Me.PnlInfo.Location = New System.Drawing.Point(1, 378)
        Me.PnlInfo.Name = "PnlInfo"
        Me.PnlInfo.Size = New System.Drawing.Size(895, 29)
        Me.PnlInfo.TabIndex = 60037
        Me.PnlInfo.Visible = False
        '
        'lbinfo
        '
        Me.lbinfo.AutoSize = True
        Me.lbinfo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbinfo.Location = New System.Drawing.Point(34, 8)
        Me.lbinfo.Name = "lbinfo"
        Me.lbinfo.Size = New System.Drawing.Size(68, 16)
        Me.lbinfo.TabIndex = 10063
        Me.lbinfo.Text = "CONTENIDO"
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
        Me.Panel3.Location = New System.Drawing.Point(306, 225)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(296, 114)
        Me.Panel3.TabIndex = 60028
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcodigo)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.textnombreproveedor)
        Me.GroupBox2.Controls.Add(Me.textCodigoCliente)
        Me.GroupBox2.Controls.Add(Me.Textsigla)
        Me.GroupBox2.Controls.Add(Me.Textnombredocumento)
        Me.GroupBox2.Controls.Add(Me.fechadoc)
        Me.GroupBox2.Controls.Add(Me.bttercero)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btBusquedaDocumento)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(884, 98)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'txtcodigo
        '
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.Location = New System.Drawing.Point(133, 11)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(170, 25)
        Me.txtcodigo.TabIndex = 60033
        Me.txtcodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(3, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 17)
        Me.Label15.TabIndex = 60032
        Me.Label15.Text = "Comprobante:"
        '
        'textnombreproveedor
        '
        Me.textnombreproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textnombreproveedor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textnombreproveedor.Location = New System.Drawing.Point(214, 66)
        Me.textnombreproveedor.Name = "textnombreproveedor"
        Me.textnombreproveedor.Size = New System.Drawing.Size(637, 25)
        Me.textnombreproveedor.TabIndex = 60029
        Me.textnombreproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textCodigoCliente
        '
        Me.textCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textCodigoCliente.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textCodigoCliente.Location = New System.Drawing.Point(133, 66)
        Me.textCodigoCliente.Name = "textCodigoCliente"
        Me.textCodigoCliente.Size = New System.Drawing.Size(78, 25)
        Me.textCodigoCliente.TabIndex = 60031
        Me.textCodigoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Textsigla
        '
        Me.Textsigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textsigla.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textsigla.Location = New System.Drawing.Point(133, 39)
        Me.Textsigla.Name = "Textsigla"
        Me.Textsigla.Size = New System.Drawing.Size(78, 25)
        Me.Textsigla.TabIndex = 60029
        Me.Textsigla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Textnombredocumento
        '
        Me.Textnombredocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textnombredocumento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textnombredocumento.Location = New System.Drawing.Point(214, 39)
        Me.Textnombredocumento.Name = "Textnombredocumento"
        Me.Textnombredocumento.Size = New System.Drawing.Size(664, 25)
        Me.Textnombredocumento.TabIndex = 60028
        Me.Textnombredocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fechadoc
        '
        Me.fechadoc.CustomFormat = "dd |  MMMM |  yyyy"
        Me.fechadoc.Enabled = False
        Me.fechadoc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechadoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechadoc.Location = New System.Drawing.Point(480, 11)
        Me.fechadoc.Name = "fechadoc"
        Me.fechadoc.Size = New System.Drawing.Size(189, 25)
        Me.fechadoc.TabIndex = 60027
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(348, 15)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(127, 17)
        Me.Label21.TabIndex = 60026
        Me.Label21.Text = "Fecha Documento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(2, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Tipo Documento:"
        '
        'btBusquedaDocumento
        '
        Me.btBusquedaDocumento.Location = New System.Drawing.Point(214, 40)
        Me.btBusquedaDocumento.Name = "btBusquedaDocumento"
        Me.btBusquedaDocumento.Size = New System.Drawing.Size(25, 23)
        Me.btBusquedaDocumento.TabIndex = 60015
        Me.btBusquedaDocumento.UseVisualStyleBackColor = True
        Me.btBusquedaDocumento.Visible = False
        '
        'dgvCuentas
        '
        Me.dgvCuentas.AllowUserToAddRows = False
        Me.dgvCuentas.AllowUserToDeleteRows = False
        Me.dgvCuentas.AllowUserToResizeColumns = False
        Me.dgvCuentas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvCuentas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCuentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvCuentas.BackgroundColor = System.Drawing.Color.White
        Me.dgvCuentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCuentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.anular})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentas.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCuentas.Location = New System.Drawing.Point(14, 178)
        Me.dgvCuentas.Name = "dgvCuentas"
        Me.dgvCuentas.ReadOnly = True
        Me.dgvCuentas.RowHeadersVisible = False
        Me.dgvCuentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvCuentas.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuentas.ShowCellErrors = False
        Me.dgvCuentas.ShowCellToolTips = False
        Me.dgvCuentas.ShowEditingIcon = False
        Me.dgvCuentas.ShowRowErrors = False
        Me.dgvCuentas.Size = New System.Drawing.Size(870, 220)
        Me.dgvCuentas.TabIndex = 60027
        '
        'GroupBox3
        '
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 165)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(884, 240)
        Me.GroupBox3.TabIndex = 60026
        Me.GroupBox3.TabStop = False
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = "Quitar"
        Me.DataGridViewImageColumn1.Image = Global.Quality.My.Resources.Resources.papelera
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 43
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
        Me.ToolStrip1.TabIndex = 77
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
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Quality.My.Resources.Resources.atencion
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 26)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10063
        Me.PictureBox2.TabStop = False
        '
        'bttercero
        '
        Me.bttercero.BackgroundImage = CType(resources.GetObject("bttercero.BackgroundImage"), System.Drawing.Image)
        Me.bttercero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttercero.Image = CType(resources.GetObject("bttercero.Image"), System.Drawing.Image)
        Me.bttercero.Location = New System.Drawing.Point(853, 67)
        Me.bttercero.Name = "bttercero"
        Me.bttercero.Size = New System.Drawing.Size(26, 25)
        Me.bttercero.TabIndex = 60016
        Me.bttercero.UseVisualStyleBackColor = True
        '
        'anular
        '
        Me.anular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.anular.HeaderText = "Quitar"
        Me.anular.Image = Global.Quality.My.Resources.Resources.papelera
        Me.anular.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch
        Me.anular.Name = "anular"
        Me.anular.ReadOnly = True
        Me.anular.Width = 43
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
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.Mimetypes_text_x_vcard_icon
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
        Me.LTitulo.Location = New System.Drawing.Point(4, 2)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(901, 40)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Nota Cliente"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormNotaCliente
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
        Me.Name = "FormNotaCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.PnlInfo.ResumeLayout(False)
        Me.PnlInfo.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Panel2 As Panel
    Public WithEvents Pimagen As PictureBox
    Public WithEvents LTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents textdiferencia As Label
    Friend WithEvents textvalorcredito As Label
    Friend WithEvents textvalordebito As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Public WithEvents PnlInfo As Panel
    Public WithEvents lbinfo As Label
    Public WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents base As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents lblivarete As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents textnombreproveedor As Label
    Friend WithEvents textCodigoCliente As Label
    Friend WithEvents Textsigla As Label
    Friend WithEvents Textnombredocumento As Label
    Public WithEvents fechadoc As DateTimePicker
    Public WithEvents bttercero As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Public WithEvents btBusquedaDocumento As Button
    Friend WithEvents dgvCuentas As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtNaturaleza As Label
    Friend WithEvents txtPorcentaje As Label
    Public WithEvents ToolStrip1 As ToolStrip
    Public WithEvents btNuevo As ToolStripButton
    Public WithEvents btBuscar As ToolStripButton
    Public WithEvents btRegistrar As ToolStripButton
    Public WithEvents btEditar As ToolStripButton
    Public WithEvents btCancelar As ToolStripButton
    Public WithEvents btAnular As ToolStripButton
    Friend WithEvents txtTotal As Label
    Friend WithEvents txtcodigo As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Public WithEvents textObservacion As TextBox
    Friend WithEvents anular As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
End Class
