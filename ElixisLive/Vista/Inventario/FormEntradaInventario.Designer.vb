<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEntradaInventario
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
        Me.GbInform_D = New System.Windows.Forms.GroupBox()
        Me.dgvEntrada = New System.Windows.Forms.DataGridView()
        Me.dgCodigoProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgValor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgBodega = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCodigoBarra = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btBuscarCompra = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.btBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbCompra = New System.Windows.Forms.RadioButton()
        Me.rvManual = New System.Windows.Forms.RadioButton()
        Me.GbInform_D.SuspendLayout()
        CType(Me.dgvEntrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GbInform_D
        '
        Me.GbInform_D.Controls.Add(Me.dgvEntrada)
        Me.GbInform_D.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbInform_D.ForeColor = System.Drawing.Color.DarkBlue
        Me.GbInform_D.Location = New System.Drawing.Point(4, 57)
        Me.GbInform_D.Name = "GbInform_D"
        Me.GbInform_D.Size = New System.Drawing.Size(888, 336)
        Me.GbInform_D.TabIndex = 59
        Me.GbInform_D.TabStop = False
        '
        'dgvEntrada
        '
        Me.dgvEntrada.AllowUserToAddRows = False
        Me.dgvEntrada.AllowUserToDeleteRows = False
        Me.dgvEntrada.AllowUserToResizeColumns = False
        Me.dgvEntrada.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvEntrada.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEntrada.BackgroundColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEntrada.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEntrada.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgCodigoProducto, Me.dgProducto, Me.dgValor, Me.dgCantidad, Me.dgTotal, Me.dgBodega, Me.dgCodigoBarra})
        Me.dgvEntrada.Location = New System.Drawing.Point(3, 18)
        Me.dgvEntrada.MultiSelect = False
        Me.dgvEntrada.Name = "dgvEntrada"
        Me.dgvEntrada.RowHeadersVisible = False
        Me.dgvEntrada.Size = New System.Drawing.Size(879, 311)
        Me.dgvEntrada.TabIndex = 0
        '
        'dgCodigoProducto
        '
        Me.dgCodigoProducto.HeaderText = "Codigo"
        Me.dgCodigoProducto.Name = "dgCodigoProducto"
        Me.dgCodigoProducto.Visible = False
        '
        'dgProducto
        '
        Me.dgProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dgProducto.HeaderText = "Producto"
        Me.dgProducto.Name = "dgProducto"
        '
        'dgValor
        '
        Me.dgValor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgValor.HeaderText = "Vr. Unitario"
        Me.dgValor.Name = "dgValor"
        Me.dgValor.Width = 85
        '
        'dgCantidad
        '
        Me.dgCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgCantidad.HeaderText = "Cantidad"
        Me.dgCantidad.Name = "dgCantidad"
        Me.dgCantidad.Width = 75
        '
        'dgTotal
        '
        Me.dgTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.dgTotal.HeaderText = "Total"
        Me.dgTotal.Name = "dgTotal"
        Me.dgTotal.Width = 55
        '
        'dgBodega
        '
        Me.dgBodega.HeaderText = "Bodega"
        Me.dgBodega.Name = "dgBodega"
        Me.dgBodega.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgBodega.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgCodigoBarra
        '
        Me.dgCodigoBarra.HeaderText = "C. de Barra"
        Me.dgCodigoBarra.Name = "dgCodigoBarra"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtSubTotal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GbInform_D)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 435)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtTotal.Location = New System.Drawing.Point(295, 398)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(130, 25)
        Me.txtTotal.TabIndex = 64
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(244, 402)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Total:"
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtSubTotal.Location = New System.Drawing.Point(89, 399)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(130, 25)
        Me.txtSubTotal.TabIndex = 62
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label2.Location = New System.Drawing.Point(10, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Sub Total:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.btBuscarCompra)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(885, 45)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        '
        'btBuscarCompra
        '
        Me.btBuscarCompra.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.btBuscarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBuscarCompra.Image = Global.Quality.My.Resources.Resources.Zoom_icon1
        Me.btBuscarCompra.Location = New System.Drawing.Point(577, 14)
        Me.btBuscarCompra.Name = "btBuscarCompra"
        Me.btBuscarCompra.Size = New System.Drawing.Size(28, 25)
        Me.btBuscarCompra.TabIndex = 66
        Me.btBuscarCompra.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.txtCodigo.Location = New System.Drawing.Point(408, 14)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(167, 25)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orden de Compra:"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        Me.ErrorIcono.RightToLeft = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btNuevo, Me.ToolStripSeparator7, Me.btBuscar, Me.ToolStripSeparator2, Me.btRegistrar, Me.ToolStripSeparator4, Me.btCancelar, Me.ToolStripSeparator3, Me.btAnular, Me.ToolStripSeparator6})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 487)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(905, 37)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 37)
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
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 37)
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 37)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 37)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 37)
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
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 37)
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
        Me.Panel1.Size = New System.Drawing.Size(905, 44)
        Me.Panel1.TabIndex = 0
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.fork_1_icon
        Me.Pimagen.Location = New System.Drawing.Point(6, 0)
        Me.Pimagen.Name = "Pimagen"
        Me.Pimagen.Size = New System.Drawing.Size(41, 42)
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pimagen.TabIndex = 1
        Me.Pimagen.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(0, 0)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(904, 40)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Entrada Inventario"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rvManual)
        Me.GroupBox3.Controls.Add(Me.rbCompra)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(247, 36)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        '
        'rbCompra
        '
        Me.rbCompra.AutoSize = True
        Me.rbCompra.Location = New System.Drawing.Point(6, 10)
        Me.rbCompra.Name = "rbCompra"
        Me.rbCompra.Size = New System.Drawing.Size(102, 23)
        Me.rbCompra.TabIndex = 0
        Me.rbCompra.TabStop = True
        Me.rbCompra.Text = "por compra"
        Me.rbCompra.UseVisualStyleBackColor = True
        '
        'rvManual
        '
        Me.rvManual.AutoSize = True
        Me.rvManual.Location = New System.Drawing.Point(139, 11)
        Me.rvManual.Name = "rvManual"
        Me.rvManual.Size = New System.Drawing.Size(76, 23)
        Me.rvManual.TabIndex = 1
        Me.rvManual.TabStop = True
        Me.rvManual.Text = "Manual"
        Me.rvManual.UseVisualStyleBackColor = True
        '
        'FormEntradaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(905, 524)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(3000, 1000)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(921, 562)
        Me.MinimumSize = New System.Drawing.Size(921, 562)
        Me.Name = "FormEntradaInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GbInform_D.ResumeLayout(False)
        CType(Me.dgvEntrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Panel1 As Panel
    Public WithEvents LTitulo As Label
    Public WithEvents Pimagen As PictureBox
    Friend WithEvents GbInform_D As GroupBox
    Public WithEvents dgvEntrada As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents btNuevo As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Public WithEvents btBuscar As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Public WithEvents btRegistrar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Public WithEvents btCancelar As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Public WithEvents btAnular As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btBuscarCompra As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgCodigoProducto As DataGridViewTextBoxColumn
    Friend WithEvents dgProducto As DataGridViewTextBoxColumn
    Friend WithEvents dgValor As DataGridViewTextBoxColumn
    Friend WithEvents dgCantidad As DataGridViewTextBoxColumn
    Friend WithEvents dgTotal As DataGridViewTextBoxColumn
    Friend WithEvents dgBodega As DataGridViewTextBoxColumn
    Friend WithEvents dgCodigoBarra As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rvManual As RadioButton
    Friend WithEvents rbCompra As RadioButton
End Class
