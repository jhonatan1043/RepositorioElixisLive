<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInformeVenta
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormInformeVenta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvVenta = New System.Windows.Forms.DataGridView()
        Me.dgCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgNumeroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgValorCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgValorVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTotalCosto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTotalVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgRentabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFecha = New Quality.DataGridViewDateTimePickerColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvServicio = New System.Windows.Forms.DataGridView()
        Me.dgCodigoServicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFecturaServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDescripcionServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCostoSev = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgVentaServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgRentabilidadServ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFechaServ = New Quality.DataGridViewDateTimePickerColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dgvGasto = New System.Windows.Forms.DataGridView()
        Me.dgCodigoGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDescripcionGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCostoGasto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFechaGasto = New Quality.DataGridViewDateTimePickerColumn()
        Me.gpTotales = New System.Windows.Forms.GroupBox()
        Me.txtRentabilidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTotalCosto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalGasto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GpDatos = New System.Windows.Forms.GroupBox()
        Me.btGenerar = New System.Windows.Forms.Button()
        Me.dtFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewDateTimePickerColumn1 = New Quality.DataGridViewDateTimePickerColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewDateTimePickerColumn2 = New Quality.DataGridViewDateTimePickerColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dgvGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpTotales.SuspendLayout()
        Me.GpDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Controls.Add(Me.gpTotales)
        Me.GroupBox1.Controls.Add(Me.GpDatos)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(888, 472)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic)
        Me.TabControl1.Location = New System.Drawing.Point(6, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(876, 346)
        Me.TabControl1.TabIndex = 60036
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvVenta)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(868, 318)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Ventas Productos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvVenta
        '
        Me.dgvVenta.AllowUserToAddRows = False
        Me.dgvVenta.AllowUserToDeleteRows = False
        Me.dgvVenta.AllowUserToResizeColumns = False
        Me.dgvVenta.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvVenta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVenta.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgCodigo, Me.dgNumeroFactura, Me.dgDescripcion, Me.dgCantidad, Me.dgValorCosto, Me.dgValorVenta, Me.dgTotalCosto, Me.dgTotalVenta, Me.dgRentabilidad, Me.dgFecha})
        Me.dgvVenta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVenta.Location = New System.Drawing.Point(3, 3)
        Me.dgvVenta.MultiSelect = False
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.ReadOnly = True
        Me.dgvVenta.Size = New System.Drawing.Size(862, 312)
        Me.dgvVenta.TabIndex = 60034
        '
        'dgCodigo
        '
        Me.dgCodigo.HeaderText = "Código"
        Me.dgCodigo.Name = "dgCodigo"
        Me.dgCodigo.ReadOnly = True
        Me.dgCodigo.Visible = False
        '
        'dgNumeroFactura
        '
        Me.dgNumeroFactura.HeaderText = "N° Factura"
        Me.dgNumeroFactura.Name = "dgNumeroFactura"
        Me.dgNumeroFactura.ReadOnly = True
        '
        'dgDescripcion
        '
        Me.dgDescripcion.HeaderText = "Descripción"
        Me.dgDescripcion.Name = "dgDescripcion"
        Me.dgDescripcion.ReadOnly = True
        '
        'dgCantidad
        '
        Me.dgCantidad.HeaderText = "CantidadVenta"
        Me.dgCantidad.Name = "dgCantidad"
        Me.dgCantidad.ReadOnly = True
        '
        'dgValorCosto
        '
        Me.dgValorCosto.HeaderText = "Costo"
        Me.dgValorCosto.Name = "dgValorCosto"
        Me.dgValorCosto.ReadOnly = True
        '
        'dgValorVenta
        '
        Me.dgValorVenta.HeaderText = "V.Venta"
        Me.dgValorVenta.Name = "dgValorVenta"
        Me.dgValorVenta.ReadOnly = True
        '
        'dgTotalCosto
        '
        Me.dgTotalCosto.HeaderText = "TotalCosto"
        Me.dgTotalCosto.Name = "dgTotalCosto"
        Me.dgTotalCosto.ReadOnly = True
        '
        'dgTotalVenta
        '
        Me.dgTotalVenta.HeaderText = "TotalVenta"
        Me.dgTotalVenta.Name = "dgTotalVenta"
        Me.dgTotalVenta.ReadOnly = True
        '
        'dgRentabilidad
        '
        Me.dgRentabilidad.HeaderText = "Rentabilidad"
        Me.dgRentabilidad.Name = "dgRentabilidad"
        Me.dgRentabilidad.ReadOnly = True
        '
        'dgFecha
        '
        Me.dgFecha.HeaderText = "Fecha"
        Me.dgFecha.Name = "dgFecha"
        Me.dgFecha.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvServicio)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(868, 318)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ventas Servicio"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvServicio
        '
        Me.dgvServicio.AllowUserToAddRows = False
        Me.dgvServicio.AllowUserToDeleteRows = False
        Me.dgvServicio.AllowUserToResizeColumns = False
        Me.dgvServicio.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvServicio.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvServicio.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServicio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServicio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgCodigoServicio, Me.dgFecturaServ, Me.dgDescripcionServ, Me.dgCostoSev, Me.dgVentaServ, Me.dgRentabilidadServ, Me.dgFechaServ})
        Me.dgvServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvServicio.Location = New System.Drawing.Point(3, 3)
        Me.dgvServicio.MultiSelect = False
        Me.dgvServicio.Name = "dgvServicio"
        Me.dgvServicio.ReadOnly = True
        Me.dgvServicio.Size = New System.Drawing.Size(862, 312)
        Me.dgvServicio.TabIndex = 60035
        '
        'dgCodigoServicio
        '
        Me.dgCodigoServicio.HeaderText = "Código"
        Me.dgCodigoServicio.Name = "dgCodigoServicio"
        Me.dgCodigoServicio.ReadOnly = True
        Me.dgCodigoServicio.Visible = False
        '
        'dgFecturaServ
        '
        Me.dgFecturaServ.HeaderText = "N° Factura"
        Me.dgFecturaServ.Name = "dgFecturaServ"
        Me.dgFecturaServ.ReadOnly = True
        '
        'dgDescripcionServ
        '
        Me.dgDescripcionServ.HeaderText = "Descripción"
        Me.dgDescripcionServ.Name = "dgDescripcionServ"
        Me.dgDescripcionServ.ReadOnly = True
        '
        'dgCostoSev
        '
        Me.dgCostoSev.HeaderText = "Costo"
        Me.dgCostoSev.Name = "dgCostoSev"
        Me.dgCostoSev.ReadOnly = True
        '
        'dgVentaServ
        '
        Me.dgVentaServ.HeaderText = "V.Venta"
        Me.dgVentaServ.Name = "dgVentaServ"
        Me.dgVentaServ.ReadOnly = True
        '
        'dgRentabilidadServ
        '
        Me.dgRentabilidadServ.HeaderText = "Rentabilidad"
        Me.dgRentabilidadServ.Name = "dgRentabilidadServ"
        Me.dgRentabilidadServ.ReadOnly = True
        '
        'dgFechaServ
        '
        Me.dgFechaServ.HeaderText = "Fecha"
        Me.dgFechaServ.Name = "dgFechaServ"
        Me.dgFechaServ.ReadOnly = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dgvGasto)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(868, 318)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Gastos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dgvGasto
        '
        Me.dgvGasto.AllowUserToAddRows = False
        Me.dgvGasto.AllowUserToDeleteRows = False
        Me.dgvGasto.AllowUserToResizeColumns = False
        Me.dgvGasto.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvGasto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvGasto.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(113, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGasto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvGasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGasto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgCodigoGasto, Me.dgDescripcionGasto, Me.dgCostoGasto, Me.dgFechaGasto})
        Me.dgvGasto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGasto.Location = New System.Drawing.Point(0, 0)
        Me.dgvGasto.MultiSelect = False
        Me.dgvGasto.Name = "dgvGasto"
        Me.dgvGasto.ReadOnly = True
        Me.dgvGasto.Size = New System.Drawing.Size(868, 318)
        Me.dgvGasto.TabIndex = 60034
        '
        'dgCodigoGasto
        '
        Me.dgCodigoGasto.HeaderText = "CodigoGasto"
        Me.dgCodigoGasto.Name = "dgCodigoGasto"
        Me.dgCodigoGasto.ReadOnly = True
        Me.dgCodigoGasto.Visible = False
        '
        'dgDescripcionGasto
        '
        Me.dgDescripcionGasto.HeaderText = "Gastos"
        Me.dgDescripcionGasto.Name = "dgDescripcionGasto"
        Me.dgDescripcionGasto.ReadOnly = True
        '
        'dgCostoGasto
        '
        Me.dgCostoGasto.HeaderText = "CostoGasto"
        Me.dgCostoGasto.Name = "dgCostoGasto"
        Me.dgCostoGasto.ReadOnly = True
        '
        'dgFechaGasto
        '
        Me.dgFechaGasto.HeaderText = "Fecha"
        Me.dgFechaGasto.Name = "dgFechaGasto"
        Me.dgFechaGasto.ReadOnly = True
        '
        'gpTotales
        '
        Me.gpTotales.BackColor = System.Drawing.Color.Transparent
        Me.gpTotales.Controls.Add(Me.txtRentabilidad)
        Me.gpTotales.Controls.Add(Me.Label5)
        Me.gpTotales.Controls.Add(Me.txtTotalVenta)
        Me.gpTotales.Controls.Add(Me.Label4)
        Me.gpTotales.Controls.Add(Me.txtTotalCosto)
        Me.gpTotales.Controls.Add(Me.Label3)
        Me.gpTotales.Controls.Add(Me.txtTotalGasto)
        Me.gpTotales.Controls.Add(Me.Label2)
        Me.gpTotales.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpTotales.ForeColor = System.Drawing.Color.DarkBlue
        Me.gpTotales.Location = New System.Drawing.Point(6, 413)
        Me.gpTotales.Name = "gpTotales"
        Me.gpTotales.Size = New System.Drawing.Size(876, 52)
        Me.gpTotales.TabIndex = 60035
        Me.gpTotales.TabStop = False
        '
        'txtRentabilidad
        '
        Me.txtRentabilidad.Location = New System.Drawing.Point(748, 18)
        Me.txtRentabilidad.Name = "txtRentabilidad"
        Me.txtRentabilidad.Size = New System.Drawing.Size(100, 21)
        Me.txtRentabilidad.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(674, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Rentabilidad:"
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Location = New System.Drawing.Point(543, 18)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalVenta.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(447, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Valor Venta:"
        '
        'txtTotalCosto
        '
        Me.txtTotalCosto.Location = New System.Drawing.Point(304, 18)
        Me.txtTotalCosto.Name = "txtTotalCosto"
        Me.txtTotalCosto.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalCosto.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(229, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Costos:"
        '
        'txtTotalGasto
        '
        Me.txtTotalGasto.Location = New System.Drawing.Point(89, 18)
        Me.txtTotalGasto.Name = "txtTotalGasto"
        Me.txtTotalGasto.Size = New System.Drawing.Size(100, 21)
        Me.txtTotalGasto.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(14, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Total Gastos:"
        '
        'GpDatos
        '
        Me.GpDatos.BackColor = System.Drawing.Color.Transparent
        Me.GpDatos.Controls.Add(Me.btGenerar)
        Me.GpDatos.Controls.Add(Me.dtFechaFin)
        Me.GpDatos.Controls.Add(Me.dtFechaInicio)
        Me.GpDatos.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpDatos.ForeColor = System.Drawing.Color.DarkBlue
        Me.GpDatos.Location = New System.Drawing.Point(6, 6)
        Me.GpDatos.Name = "GpDatos"
        Me.GpDatos.Size = New System.Drawing.Size(876, 52)
        Me.GpDatos.TabIndex = 10
        Me.GpDatos.TabStop = False
        '
        'btGenerar
        '
        Me.btGenerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btGenerar.ForeColor = System.Drawing.Color.Black
        Me.btGenerar.Location = New System.Drawing.Point(238, 19)
        Me.btGenerar.Name = "btGenerar"
        Me.btGenerar.Size = New System.Drawing.Size(75, 23)
        Me.btGenerar.TabIndex = 73
        Me.btGenerar.Text = "Generar"
        Me.btGenerar.UseVisualStyleBackColor = False
        '
        'dtFechaFin
        '
        Me.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaFin.Location = New System.Drawing.Point(125, 20)
        Me.dtFechaFin.Name = "dtFechaFin"
        Me.dtFechaFin.Size = New System.Drawing.Size(102, 21)
        Me.dtFechaFin.TabIndex = 72
        '
        'dtFechaInicio
        '
        Me.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaInicio.Location = New System.Drawing.Point(14, 20)
        Me.dtFechaInicio.Name = "dtFechaInicio"
        Me.dtFechaInicio.Size = New System.Drawing.Size(102, 21)
        Me.dtFechaInicio.TabIndex = 71
        '
        'DataGridViewImageColumn1
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.NullValue = CType(resources.GetObject("DataGridViewCellStyle7.NullValue"), Object)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewImageColumn1.HeaderText = "Quitar"
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Width = 50
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 34)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(786, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Informe de Rentabilidad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        Me.ErrorIcono.RightToLeft = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CodigoGasto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Gastos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "CostoGasto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewDateTimePickerColumn1
        '
        Me.DataGridViewDateTimePickerColumn1.HeaderText = "Fecha"
        Me.DataGridViewDateTimePickerColumn1.Name = "DataGridViewDateTimePickerColumn1"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "CantidadVenta"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Costo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "V.Venta"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "TotalCosto"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewDateTimePickerColumn2
        '
        Me.DataGridViewDateTimePickerColumn2.HeaderText = "Fecha"
        Me.DataGridViewDateTimePickerColumn2.Name = "DataGridViewDateTimePickerColumn2"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "TotalVenta"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "Rentabilidad"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'FormInformeVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 526)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(916, 565)
        Me.MinimumSize = New System.Drawing.Size(916, 565)
        Me.Name = "FormInformeVenta"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvServicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dgvGasto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpTotales.ResumeLayout(False)
        Me.gpTotales.PerformLayout()
        Me.GpDatos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Panel1 As Panel
    Public WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GpDatos As GroupBox
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents gpTotales As GroupBox
    Friend WithEvents dtFechaFin As DateTimePicker
    Friend WithEvents dtFechaInicio As DateTimePicker
    Friend WithEvents btGenerar As Button
    Friend WithEvents txtRentabilidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalCosto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotalGasto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewDateTimePickerColumn1 As DataGridViewDateTimePickerColumn
    Friend WithEvents DataGridViewDateTimePickerColumn2 As DataGridViewDateTimePickerColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Public WithEvents dgvVenta As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Public WithEvents dgvServicio As DataGridView
    Friend WithEvents dgCodigoServicio As DataGridViewTextBoxColumn
    Friend WithEvents dgFecturaServ As DataGridViewTextBoxColumn
    Friend WithEvents dgDescripcionServ As DataGridViewTextBoxColumn
    Friend WithEvents dgCostoSev As DataGridViewTextBoxColumn
    Friend WithEvents dgVentaServ As DataGridViewTextBoxColumn
    Friend WithEvents dgRentabilidadServ As DataGridViewTextBoxColumn
    Friend WithEvents dgFechaServ As DataGridViewDateTimePickerColumn
    Friend WithEvents TabPage3 As TabPage
    Public WithEvents dgvGasto As DataGridView
    Friend WithEvents dgCodigoGasto As DataGridViewTextBoxColumn
    Friend WithEvents dgDescripcionGasto As DataGridViewTextBoxColumn
    Friend WithEvents dgCostoGasto As DataGridViewTextBoxColumn
    Friend WithEvents dgFechaGasto As DataGridViewDateTimePickerColumn
    Friend WithEvents dgCodigo As DataGridViewTextBoxColumn
    Friend WithEvents dgNumeroFactura As DataGridViewTextBoxColumn
    Friend WithEvents dgDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgValorCosto As DataGridViewTextBoxColumn
    Friend WithEvents dgValorVenta As DataGridViewTextBoxColumn
    Friend WithEvents dgTotalCosto As DataGridViewTextBoxColumn
    Friend WithEvents dgTotalVenta As DataGridViewTextBoxColumn
    Friend WithEvents dgRentabilidad As DataGridViewTextBoxColumn
    Friend WithEvents dgFecha As DataGridViewDateTimePickerColumn
End Class
