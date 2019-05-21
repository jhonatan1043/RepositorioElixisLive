<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLote
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvLote = New System.Windows.Forms.DataGridView()
        Me.dgCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCantidadAct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgFechaLote = New Quality.DataGridViewDateTimePickerColumn()
        Me.dgFechaVencimiento = New Quality.DataGridViewDateTimePickerColumn()
        Me.dgUbicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgQuitar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.dgAgregar = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewDateTimePickerColumn1 = New Quality.DataGridViewDateTimePickerColumn()
        Me.DataGridViewDateTimePickerColumn2 = New Quality.DataGridViewDateTimePickerColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvLote, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 278)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvLote)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(578, 197)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'dgvLote
        '
        Me.dgvLote.AllowUserToAddRows = False
        Me.dgvLote.AllowUserToDeleteRows = False
        Me.dgvLote.AllowUserToResizeColumns = False
        Me.dgvLote.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvLote.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLote.BackgroundColor = System.Drawing.Color.White
        Me.dgvLote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLote.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgCodigo, Me.dgNombre, Me.dgCantidad, Me.dgCantidadAct, Me.dgFechaLote, Me.dgFechaVencimiento, Me.dgUbicacion, Me.dgQuitar})
        Me.dgvLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLote.Location = New System.Drawing.Point(3, 18)
        Me.dgvLote.MultiSelect = False
        Me.dgvLote.Name = "dgvLote"
        Me.dgvLote.ReadOnly = True
        Me.dgvLote.RowHeadersVisible = False
        Me.dgvLote.Size = New System.Drawing.Size(572, 176)
        Me.dgvLote.TabIndex = 1
        '
        'dgCodigo
        '
        Me.dgCodigo.HeaderText = "Codigo"
        Me.dgCodigo.Name = "dgCodigo"
        Me.dgCodigo.ReadOnly = True
        Me.dgCodigo.Visible = False
        '
        'dgNombre
        '
        Me.dgNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgNombre.HeaderText = "Registro Lote"
        Me.dgNombre.Name = "dgNombre"
        Me.dgNombre.ReadOnly = True
        Me.dgNombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgNombre.Width = 86
        '
        'dgCantidad
        '
        Me.dgCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgCantidad.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCantidad.HeaderText = "Cant. Inicial"
        Me.dgCantidad.Name = "dgCantidad"
        Me.dgCantidad.ReadOnly = True
        Me.dgCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgCantidad.Width = 82
        '
        'dgCantidadAct
        '
        Me.dgCantidadAct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgCantidadAct.HeaderText = "Cant. Actual"
        Me.dgCantidadAct.Name = "dgCantidadAct"
        Me.dgCantidadAct.ReadOnly = True
        Me.dgCantidadAct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgCantidadAct.Width = 82
        '
        'dgFechaLote
        '
        Me.dgFechaLote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgFechaLote.HeaderText = "F. Lote"
        Me.dgFechaLote.Name = "dgFechaLote"
        Me.dgFechaLote.ReadOnly = True
        Me.dgFechaLote.Width = 49
        '
        'dgFechaVencimiento
        '
        Me.dgFechaVencimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgFechaVencimiento.HeaderText = "F. Vencimiento"
        Me.dgFechaVencimiento.Name = "dgFechaVencimiento"
        Me.dgFechaVencimiento.ReadOnly = True
        Me.dgFechaVencimiento.Width = 92
        '
        'dgUbicacion
        '
        Me.dgUbicacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgUbicacion.HeaderText = "Ubicacion"
        Me.dgUbicacion.MaxInputLength = 100
        Me.dgUbicacion.Name = "dgUbicacion"
        Me.dgUbicacion.ReadOnly = True
        Me.dgUbicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.dgUbicacion.Width = 70
        '
        'dgQuitar
        '
        Me.dgQuitar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgQuitar.HeaderText = "quitar"
        Me.dgQuitar.Image = Global.Quality.My.Resources.Resources.papelera
        Me.dgQuitar.Name = "dgQuitar"
        Me.dgQuitar.ReadOnly = True
        Me.dgQuitar.Width = 47
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbNombre)
        Me.GroupBox2.Controls.Add(Me.dgAgregar)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 58)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbNombre.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNombre.Location = New System.Drawing.Point(127, 23)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(66, 23)
        Me.lbNombre.TabIndex = 1
        Me.lbNombre.Text = "Label1"
        '
        'dgAgregar
        '
        Me.dgAgregar.Image = Global.Quality.My.Resources.Resources.plus_icon
        Me.dgAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dgAgregar.Location = New System.Drawing.Point(6, 15)
        Me.dgAgregar.Name = "dgAgregar"
        Me.dgAgregar.Size = New System.Drawing.Size(115, 37)
        Me.dgAgregar.TabIndex = 0
        Me.dgAgregar.Text = "Agregar"
        Me.dgAgregar.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "quitar"
        Me.DataGridViewImageColumn1.Image = Global.Quality.My.Resources.Resources.papelera
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btRegistrar, Me.btCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 332)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(603, 37)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Pimagen)
        Me.Panel1.Controls.Add(Me.LTitulo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(602, 44)
        Me.Panel1.TabIndex = 1
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.palet_01_icon
        Me.Pimagen.Location = New System.Drawing.Point(4, 0)
        Me.Pimagen.Name = "Pimagen"
        Me.Pimagen.Size = New System.Drawing.Size(58, 40)
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pimagen.TabIndex = 1
        Me.Pimagen.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(-2, -2)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(605, 40)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Lote"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "Registro Lote"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewDateTimePickerColumn1
        '
        Me.DataGridViewDateTimePickerColumn1.HeaderText = "Fecha Lote"
        Me.DataGridViewDateTimePickerColumn1.Name = "DataGridViewDateTimePickerColumn1"
        '
        'DataGridViewDateTimePickerColumn2
        '
        Me.DataGridViewDateTimePickerColumn2.HeaderText = "F. Vencimiento"
        Me.DataGridViewDateTimePickerColumn2.Name = "DataGridViewDateTimePickerColumn2"
        '
        'FormLote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 369)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(619, 408)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(619, 408)
        Me.Name = "FormLote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvLote, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Panel1 As Panel
    Public WithEvents Pimagen As PictureBox
    Public WithEvents LTitulo As Label
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents ToolStrip1 As ToolStrip
    Public WithEvents btRegistrar As ToolStripButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents dgvLote As DataGridView
    Friend WithEvents dgAgregar As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Public WithEvents btCancelar As ToolStripButton
    Friend WithEvents lbNombre As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewDateTimePickerColumn1 As DataGridViewDateTimePickerColumn
    Friend WithEvents DataGridViewDateTimePickerColumn2 As DataGridViewDateTimePickerColumn
    Friend WithEvents dgCodigo As DataGridViewTextBoxColumn
    Friend WithEvents dgNombre As DataGridViewTextBoxColumn
    Friend WithEvents dgCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgCantidadAct As DataGridViewTextBoxColumn
    Friend WithEvents dgFechaLote As DataGridViewDateTimePickerColumn
    Friend WithEvents dgFechaVencimiento As DataGridViewDateTimePickerColumn
    Friend WithEvents dgUbicacion As DataGridViewTextBoxColumn
    Friend WithEvents dgQuitar As DataGridViewImageColumn
End Class
