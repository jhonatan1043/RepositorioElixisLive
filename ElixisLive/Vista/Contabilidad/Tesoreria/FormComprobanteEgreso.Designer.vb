﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComprobanteEgreso
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.txtretencion = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.textdiferencia = New System.Windows.Forms.Label()
        Me.textvalorcredito = New System.Windows.Forms.Label()
        Me.textvalordebito = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.PnlInfo = New System.Windows.Forms.Panel()
        Me.lbinfo = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dgvComprobante = New System.Windows.Forms.DataGridView()
        Me.dgOrden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgNumFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDebito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCredito = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.grupoDetalle = New System.Windows.Forms.GroupBox()
        Me.textobservacion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtfactura = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.fechaDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Textsigla = New System.Windows.Forms.Label()
        Me.Textnombredocumento = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btBusquedaDocumento = New System.Windows.Forms.Button()
        Me.txtcomprobante = New System.Windows.Forms.Label()
        Me.fechaRecibo = New System.Windows.Forms.DateTimePicker()
        Me.textnombreproveedor = New System.Windows.Forms.Label()
        Me.textCodigoCliente = New System.Windows.Forms.Label()
        Me.bttercero = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btBusqueda = New System.Windows.Forms.ToolStripButton()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.btImprimir = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PnlInfo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDetalle.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(908, 34)
        Me.Panel1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(787, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Comprobante de Egreso"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.grupoDetalle)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(894, 441)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtretencion)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.textdiferencia)
        Me.GroupBox6.Controls.Add(Me.textvalorcredito)
        Me.GroupBox6.Controls.Add(Me.textvalordebito)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Panel3)
        Me.GroupBox6.Controls.Add(Me.PnlInfo)
        Me.GroupBox6.Controls.Add(Me.dgvComprobante)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Black
        Me.GroupBox6.Location = New System.Drawing.Point(6, 148)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(882, 287)
        Me.GroupBox6.TabIndex = 60059
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Ajustes Varios"
        '
        'txtretencion
        '
        Me.txtretencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtretencion.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtretencion.Location = New System.Drawing.Point(750, 254)
        Me.txtretencion.Name = "txtretencion"
        Me.txtretencion.Size = New System.Drawing.Size(132, 25)
        Me.txtretencion.TabIndex = 60051
        Me.txtretencion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(668, 259)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 19)
        Me.Label8.TabIndex = 60050
        Me.Label8.Text = "Diferencia:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'textdiferencia
        '
        Me.textdiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textdiferencia.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textdiferencia.Location = New System.Drawing.Point(558, 256)
        Me.textdiferencia.Name = "textdiferencia"
        Me.textdiferencia.Size = New System.Drawing.Size(132, 25)
        Me.textdiferencia.TabIndex = 60049
        Me.textdiferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textvalorcredito
        '
        Me.textvalorcredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textvalorcredito.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textvalorcredito.Location = New System.Drawing.Point(335, 256)
        Me.textvalorcredito.Name = "textvalorcredito"
        Me.textvalorcredito.Size = New System.Drawing.Size(136, 25)
        Me.textvalorcredito.TabIndex = 60048
        Me.textvalorcredito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'textvalordebito
        '
        Me.textvalordebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textvalordebito.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textvalordebito.Location = New System.Drawing.Point(99, 256)
        Me.textvalordebito.Name = "textvalordebito"
        Me.textvalordebito.Size = New System.Drawing.Size(140, 25)
        Me.textvalordebito.TabIndex = 60047
        Me.textvalordebito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 60044
        Me.Label5.Text = "Valor Débito:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(235, 261)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 19)
        Me.Label11.TabIndex = 60045
        Me.Label11.Text = "Valor Crédito:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(476, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 19)
        Me.Label10.TabIndex = 60046
        Me.Label10.Text = "Diferencia:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.Panel3.Location = New System.Drawing.Point(293, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(296, 114)
        Me.Panel3.TabIndex = 60029
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
        Me.Label33.ForeColor = System.Drawing.Color.Black
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
        Me.Label29.ForeColor = System.Drawing.Color.Black
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
        Me.Label28.ForeColor = System.Drawing.Color.Black
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
        Me.Label30.ForeColor = System.Drawing.Color.Black
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
        Me.Label31.ForeColor = System.Drawing.Color.Black
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
        Me.lblivarete.ForeColor = System.Drawing.Color.Black
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
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(6, 12)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(52, 16)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Cuenta:"
        '
        'PnlInfo
        '
        Me.PnlInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlInfo.Controls.Add(Me.lbinfo)
        Me.PnlInfo.Controls.Add(Me.PictureBox2)
        Me.PnlInfo.Location = New System.Drawing.Point(5, 214)
        Me.PnlInfo.Name = "PnlInfo"
        Me.PnlInfo.Size = New System.Drawing.Size(870, 31)
        Me.PnlInfo.TabIndex = 60028
        Me.PnlInfo.Visible = False
        '
        'lbinfo
        '
        Me.lbinfo.AutoSize = True
        Me.lbinfo.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbinfo.ForeColor = System.Drawing.Color.Black
        Me.lbinfo.Location = New System.Drawing.Point(32, 8)
        Me.lbinfo.Name = "lbinfo"
        Me.lbinfo.Size = New System.Drawing.Size(68, 16)
        Me.lbinfo.TabIndex = 10063
        Me.lbinfo.Text = "CONTENIDO"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Quality.My.Resources.Resources.advertencia
        Me.PictureBox2.Location = New System.Drawing.Point(3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10063
        Me.PictureBox2.TabStop = False
        '
        'dgvComprobante
        '
        Me.dgvComprobante.AllowUserToAddRows = False
        Me.dgvComprobante.AllowUserToDeleteRows = False
        Me.dgvComprobante.AllowUserToResizeColumns = False
        Me.dgvComprobante.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvComprobante.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvComprobante.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvComprobante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvComprobante.BackgroundColor = System.Drawing.Color.White
        Me.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvComprobante.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgOrden, Me.dgNumFactura, Me.dgCuenta, Me.dgDescripcion, Me.dgDebito, Me.dgCredito, Me.dgQuitar})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvComprobante.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvComprobante.Location = New System.Drawing.Point(5, 20)
        Me.dgvComprobante.Name = "dgvComprobante"
        Me.dgvComprobante.RowHeadersVisible = False
        Me.dgvComprobante.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvComprobante.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvComprobante.ShowCellErrors = False
        Me.dgvComprobante.ShowCellToolTips = False
        Me.dgvComprobante.ShowEditingIcon = False
        Me.dgvComprobante.ShowRowErrors = False
        Me.dgvComprobante.Size = New System.Drawing.Size(871, 227)
        Me.dgvComprobante.TabIndex = 60027
        '
        'dgOrden
        '
        Me.dgOrden.HeaderText = "Orden"
        Me.dgOrden.Name = "dgOrden"
        Me.dgOrden.Visible = False
        '
        'dgNumFactura
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgNumFactura.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgNumFactura.HeaderText = "Nº Factura"
        Me.dgNumFactura.Name = "dgNumFactura"
        Me.dgNumFactura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgCuenta
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgCuenta.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgCuenta.HeaderText = "Cuenta"
        Me.dgCuenta.Name = "dgCuenta"
        Me.dgCuenta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgDescripcion
        '
        Me.dgDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgDescripcion.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgDescripcion.HeaderText = "Descripcion"
        Me.dgDescripcion.Name = "dgDescripcion"
        Me.dgDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgDescripcion.Width = 69
        '
        'dgDebito
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.dgDebito.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgDebito.HeaderText = "Debito"
        Me.dgDebito.Name = "dgDebito"
        Me.dgDebito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgCredito
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.dgCredito.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgCredito.HeaderText = "Credito"
        Me.dgCredito.Name = "dgCredito"
        Me.dgCredito.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgQuitar
        '
        Me.dgQuitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgQuitar.HeaderText = "Quitar"
        Me.dgQuitar.Name = "dgQuitar"
        Me.dgQuitar.Width = 43
        '
        'grupoDetalle
        '
        Me.grupoDetalle.Controls.Add(Me.textobservacion)
        Me.grupoDetalle.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupoDetalle.ForeColor = System.Drawing.Color.Black
        Me.grupoDetalle.Location = New System.Drawing.Point(6, 97)
        Me.grupoDetalle.Name = "grupoDetalle"
        Me.grupoDetalle.Size = New System.Drawing.Size(882, 51)
        Me.grupoDetalle.TabIndex = 60026
        Me.grupoDetalle.TabStop = False
        Me.grupoDetalle.Text = "Detalle del Movimiento"
        '
        'textobservacion
        '
        Me.textobservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textobservacion.Location = New System.Drawing.Point(5, 14)
        Me.textobservacion.Multiline = True
        Me.textobservacion.Name = "textobservacion"
        Me.textobservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textobservacion.Size = New System.Drawing.Size(871, 34)
        Me.textobservacion.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtfactura)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.fechaDoc)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Textsigla)
        Me.GroupBox2.Controls.Add(Me.Textnombredocumento)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btBusquedaDocumento)
        Me.GroupBox2.Controls.Add(Me.txtcomprobante)
        Me.GroupBox2.Controls.Add(Me.fechaRecibo)
        Me.GroupBox2.Controls.Add(Me.textnombreproveedor)
        Me.GroupBox2.Controls.Add(Me.textCodigoCliente)
        Me.GroupBox2.Controls.Add(Me.bttercero)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(882, 90)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        '
        'txtfactura
        '
        Me.txtfactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfactura.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfactura.Location = New System.Drawing.Point(785, 36)
        Me.txtfactura.Name = "txtfactura"
        Me.txtfactura.Size = New System.Drawing.Size(78, 25)
        Me.txtfactura.TabIndex = 60043
        Me.txtfactura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(719, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 60042
        Me.Label7.Text = "Factura:"
        '
        'fechaDoc
        '
        Me.fechaDoc.CustomFormat = "dd |  MMMM |  yyyy"
        Me.fechaDoc.Enabled = False
        Me.fechaDoc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaDoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaDoc.Location = New System.Drawing.Point(674, 10)
        Me.fechaDoc.Name = "fechaDoc"
        Me.fechaDoc.Size = New System.Drawing.Size(189, 25)
        Me.fechaDoc.TabIndex = 60041
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(601, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 60040
        Me.Label1.Text = "Fecha Doc:"
        '
        'Textsigla
        '
        Me.Textsigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textsigla.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textsigla.Location = New System.Drawing.Point(120, 36)
        Me.Textsigla.Name = "Textsigla"
        Me.Textsigla.Size = New System.Drawing.Size(78, 25)
        Me.Textsigla.TabIndex = 60039
        Me.Textsigla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Textnombredocumento
        '
        Me.Textnombredocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Textnombredocumento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textnombredocumento.Location = New System.Drawing.Point(201, 36)
        Me.Textnombredocumento.Name = "Textnombredocumento"
        Me.Textnombredocumento.Size = New System.Drawing.Size(458, 25)
        Me.Textnombredocumento.TabIndex = 60038
        Me.Textnombredocumento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 17)
        Me.Label4.TabIndex = 60036
        Me.Label4.Text = "Tipo Documento:"
        '
        'btBusquedaDocumento
        '
        Me.btBusquedaDocumento.Location = New System.Drawing.Point(216, 37)
        Me.btBusquedaDocumento.Name = "btBusquedaDocumento"
        Me.btBusquedaDocumento.Size = New System.Drawing.Size(25, 23)
        Me.btBusquedaDocumento.TabIndex = 60037
        Me.btBusquedaDocumento.UseVisualStyleBackColor = True
        Me.btBusquedaDocumento.Visible = False
        '
        'txtcomprobante
        '
        Me.txtcomprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcomprobante.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcomprobante.Location = New System.Drawing.Point(120, 10)
        Me.txtcomprobante.Name = "txtcomprobante"
        Me.txtcomprobante.Size = New System.Drawing.Size(170, 25)
        Me.txtcomprobante.TabIndex = 60035
        Me.txtcomprobante.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fechaRecibo
        '
        Me.fechaRecibo.CustomFormat = "dd |  MMMM |  yyyy"
        Me.fechaRecibo.Enabled = False
        Me.fechaRecibo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fechaRecibo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fechaRecibo.Location = New System.Drawing.Point(405, 10)
        Me.fechaRecibo.Name = "fechaRecibo"
        Me.fechaRecibo.Size = New System.Drawing.Size(189, 25)
        Me.fechaRecibo.TabIndex = 60034
        '
        'textnombreproveedor
        '
        Me.textnombreproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textnombreproveedor.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textnombreproveedor.Location = New System.Drawing.Point(201, 62)
        Me.textnombreproveedor.Name = "textnombreproveedor"
        Me.textnombreproveedor.Size = New System.Drawing.Size(610, 25)
        Me.textnombreproveedor.TabIndex = 60033
        Me.textnombreproveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'textCodigoCliente
        '
        Me.textCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textCodigoCliente.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textCodigoCliente.Location = New System.Drawing.Point(120, 62)
        Me.textCodigoCliente.Name = "textCodigoCliente"
        Me.textCodigoCliente.Size = New System.Drawing.Size(78, 25)
        Me.textCodigoCliente.TabIndex = 60034
        Me.textCodigoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bttercero
        '
        Me.bttercero.BackgroundImage = Global.Quality.My.Resources.Resources.Very_Basic_Search_icon
        Me.bttercero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttercero.Location = New System.Drawing.Point(819, 62)
        Me.bttercero.Name = "bttercero"
        Me.bttercero.Size = New System.Drawing.Size(26, 25)
        Me.bttercero.TabIndex = 60032
        Me.bttercero.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(320, 14)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 15)
        Me.Label21.TabIndex = 27
        Me.Label21.Text = "Fecha Recibo:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(95, 17)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Comprobante:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 17)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Tercero:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btNuevo, Me.btBusqueda, Me.btRegistrar, Me.btEditar, Me.btCancelar, Me.btAnular, Me.btImprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 491)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(905, 32)
        Me.ToolStrip1.TabIndex = 1004
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
        'FormComprobanteEgreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 523)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(921, 562)
        Me.MinimumSize = New System.Drawing.Size(921, 562)
        Me.Name = "FormComprobanteEgreso"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.PnlInfo.ResumeLayout(False)
        Me.PnlInfo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDetalle.ResumeLayout(False)
        Me.grupoDetalle.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Panel1 As Panel
    Public WithEvents Label2 As Label
    Public WithEvents btBuscar As ToolStripButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Public WithEvents PnlInfo As Panel
    Public WithEvents lbinfo As Label
    Public WithEvents PictureBox2 As PictureBox
    Friend WithEvents dgvComprobante As DataGridView
    Friend WithEvents dgOrden As DataGridViewTextBoxColumn
    Friend WithEvents dgNumFactura As DataGridViewTextBoxColumn
    Friend WithEvents dgCuenta As DataGridViewTextBoxColumn
    Friend WithEvents dgDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgDebito As DataGridViewTextBoxColumn
    Friend WithEvents dgCredito As DataGridViewTextBoxColumn
    Friend WithEvents dgQuitar As DataGridViewImageColumn
    Friend WithEvents grupoDetalle As GroupBox
    Public WithEvents textobservacion As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents fechaDoc As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Textsigla As Label
    Friend WithEvents Textnombredocumento As Label
    Friend WithEvents Label4 As Label
    Public WithEvents btBusquedaDocumento As Button
    Friend WithEvents txtcomprobante As Label
    Public WithEvents fechaRecibo As DateTimePicker
    Friend WithEvents textnombreproveedor As Label
    Friend WithEvents textCodigoCliente As Label
    Public WithEvents bttercero As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label3 As Label
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
    Friend WithEvents textdiferencia As Label
    Friend WithEvents textvalorcredito As Label
    Friend WithEvents textvalordebito As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtfactura As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtretencion As Label
    Friend WithEvents Label8 As Label
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents btNuevo As ToolStripButton
    Public WithEvents btBusqueda As ToolStripButton
    Public WithEvents btRegistrar As ToolStripButton
    Public WithEvents btEditar As ToolStripButton
    Public WithEvents btCancelar As ToolStripButton
    Public WithEvents btAnular As ToolStripButton
    Public WithEvents btImprimir As ToolStripButton
End Class
