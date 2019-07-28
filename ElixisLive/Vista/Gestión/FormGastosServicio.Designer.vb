<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGastosServicio
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GpDatos = New System.Windows.Forms.GroupBox()
        Me.dgvGastos = New System.Windows.Forms.DataGridView()
        Me.dgDescripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btBusqueda = New System.Windows.Forms.ToolStripButton()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.GpDatos.SuspendLayout()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(699, 34)
        Me.Panel1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(0, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(583, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Gastos de Servicios"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GpDatos
        '
        Me.GpDatos.BackColor = System.Drawing.Color.Transparent
        Me.GpDatos.Controls.Add(Me.dgvGastos)
        Me.GpDatos.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpDatos.ForeColor = System.Drawing.Color.DarkBlue
        Me.GpDatos.Location = New System.Drawing.Point(3, 91)
        Me.GpDatos.Name = "GpDatos"
        Me.GpDatos.Size = New System.Drawing.Size(693, 290)
        Me.GpDatos.TabIndex = 38
        Me.GpDatos.TabStop = False
        '
        'dgvGastos
        '
        Me.dgvGastos.AllowUserToAddRows = False
        Me.dgvGastos.AllowUserToDeleteRows = False
        Me.dgvGastos.AllowUserToResizeColumns = False
        Me.dgvGastos.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvGastos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGastos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgDescripcion, Me.dgValor, Me.dgQuitar})
        Me.dgvGastos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGastos.Location = New System.Drawing.Point(3, 17)
        Me.dgvGastos.MultiSelect = False
        Me.dgvGastos.Name = "dgvGastos"
        Me.dgvGastos.Size = New System.Drawing.Size(687, 270)
        Me.dgvGastos.TabIndex = 1
        '
        'dgDescripcion
        '
        Me.dgDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgDescripcion.HeaderText = "Justificación"
        Me.dgDescripcion.MaxInputLength = 100
        Me.dgDescripcion.Name = "dgDescripcion"
        Me.dgDescripcion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgValor
        '
        Me.dgValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgValor.HeaderText = "Valor"
        Me.dgValor.Name = "dgValor"
        Me.dgValor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgValor.Width = 39
        '
        'dgQuitar
        '
        Me.dgQuitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.NullValue = "Nothing"
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgQuitar.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgQuitar.HeaderText = "Quitar"
        Me.dgQuitar.Name = "dgQuitar"
        Me.dgQuitar.Width = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btAgregar)
        Me.GroupBox1.Controls.Add(Me.dtFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox1.Location = New System.Drawing.Point(3, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 51)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        '
        'btAgregar
        '
        Me.btAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.btAgregar.ForeColor = System.Drawing.Color.Black
        Me.btAgregar.Location = New System.Drawing.Point(575, 10)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(115, 37)
        Me.btAgregar.TabIndex = 2
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = False
        '
        'dtFecha
        '
        Me.dtFecha.CustomFormat = "MMMM/yyyy"
        Me.dtFecha.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFecha.Location = New System.Drawing.Point(59, 18)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(151, 22)
        Me.dtFecha.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Fecha:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.DarkBlue
        Me.GroupBox4.Location = New System.Drawing.Point(8, 137)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(693, 93)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btNuevo, Me.btBusqueda, Me.btRegistrar, Me.btEditar, Me.btCancelar, Me.btAnular})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 389)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(698, 32)
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
        'FormGastosServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(698, 421)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GpDatos)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(714, 460)
        Me.MinimumSize = New System.Drawing.Size(714, 460)
        Me.Name = "FormGastosServicio"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.GpDatos.ResumeLayout(False)
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Panel1 As Panel
    Public WithEvents Label2 As Label
    Friend WithEvents GpDatos As GroupBox
    Public WithEvents btBuscar As ToolStripButton
    Public WithEvents dgvGastos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtFecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dgDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents dgValor As DataGridViewTextBoxColumn
    Friend WithEvents dgQuitar As DataGridViewImageColumn
    Friend WithEvents btAgregar As Button
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents btNuevo As ToolStripButton
    Public WithEvents btBusqueda As ToolStripButton
    Public WithEvents btRegistrar As ToolStripButton
    Public WithEvents btEditar As ToolStripButton
    Public WithEvents btCancelar As ToolStripButton
    Public WithEvents btAnular As ToolStripButton
End Class
