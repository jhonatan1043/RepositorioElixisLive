<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInventarioBalance
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dgBalance = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btExportaExcel = New System.Windows.Forms.Button()
        Me.btVisualizaPDF = New System.Windows.Forms.Button()
        Me.rbTodas = New System.Windows.Forms.RadioButton()
        Me.rbResultado = New System.Windows.Forms.RadioButton()
        Me.rbBalance = New System.Windows.Forms.RadioButton()
        Me.gbTipoCuenta = New System.Windows.Forms.GroupBox()
        Me.gbDatosGrupo = New System.Windows.Forms.GroupBox()
        Me.txtNit = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbDatosGrupo.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Controls.Add(Me.gbDatosGrupo)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(893, 466)
        Me.GroupBox2.TabIndex = 10009
        Me.GroupBox2.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dgBalance)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(11, 133)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(874, 328)
        Me.GroupBox5.TabIndex = 60032
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Vista Previa"
        '
        'dgBalance
        '
        Me.dgBalance.AllowUserToAddRows = False
        Me.dgBalance.AllowUserToDeleteRows = False
        Me.dgBalance.AllowUserToResizeColumns = False
        Me.dgBalance.AllowUserToResizeRows = False
        Me.dgBalance.BackgroundColor = System.Drawing.Color.White
        Me.dgBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBalance.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgBalance.Location = New System.Drawing.Point(3, 17)
        Me.dgBalance.Name = "dgBalance"
        Me.dgBalance.ReadOnly = True
        Me.dgBalance.RowHeadersVisible = False
        Me.dgBalance.Size = New System.Drawing.Size(868, 308)
        Me.dgBalance.TabIndex = 60030
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btExportaExcel)
        Me.GroupBox1.Controls.Add(Me.btVisualizaPDF)
        Me.GroupBox1.Controls.Add(Me.rbTodas)
        Me.GroupBox1.Controls.Add(Me.rbResultado)
        Me.GroupBox1.Controls.Add(Me.rbBalance)
        Me.GroupBox1.Controls.Add(Me.gbTipoCuenta)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(496, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 118)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones del informe"
        '
        'btExportaExcel
        '
        Me.btExportaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btExportaExcel.Enabled = False
        Me.btExportaExcel.Image = Global.Quality.My.Resources.Resources.Microsoft_Excel_2013_icon1
        Me.btExportaExcel.Location = New System.Drawing.Point(337, 71)
        Me.btExportaExcel.Name = "btExportaExcel"
        Me.btExportaExcel.Size = New System.Drawing.Size(42, 38)
        Me.btExportaExcel.TabIndex = 60037
        Me.btExportaExcel.UseVisualStyleBackColor = True
        '
        'btVisualizaPDF
        '
        Me.btVisualizaPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btVisualizaPDF.Enabled = False
        Me.btVisualizaPDF.Image = Global.Quality.My.Resources.Resources.Printer_icon__1_1
        Me.btVisualizaPDF.Location = New System.Drawing.Point(337, 29)
        Me.btVisualizaPDF.Name = "btVisualizaPDF"
        Me.btVisualizaPDF.Size = New System.Drawing.Size(42, 38)
        Me.btVisualizaPDF.TabIndex = 60036
        Me.btVisualizaPDF.UseVisualStyleBackColor = True
        '
        'rbTodas
        '
        Me.rbTodas.AutoSize = True
        Me.rbTodas.Checked = True
        Me.rbTodas.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbTodas.ForeColor = System.Drawing.Color.Black
        Me.rbTodas.Location = New System.Drawing.Point(15, 88)
        Me.rbTodas.Name = "rbTodas"
        Me.rbTodas.Size = New System.Drawing.Size(63, 21)
        Me.rbTodas.TabIndex = 2
        Me.rbTodas.TabStop = True
        Me.rbTodas.Text = "Todas"
        Me.rbTodas.UseVisualStyleBackColor = True
        '
        'rbResultado
        '
        Me.rbResultado.AutoSize = True
        Me.rbResultado.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbResultado.ForeColor = System.Drawing.Color.Black
        Me.rbResultado.Location = New System.Drawing.Point(15, 63)
        Me.rbResultado.Name = "rbResultado"
        Me.rbResultado.Size = New System.Drawing.Size(94, 21)
        Me.rbResultado.TabIndex = 1
        Me.rbResultado.Text = "Resultados"
        Me.rbResultado.UseVisualStyleBackColor = True
        '
        'rbBalance
        '
        Me.rbBalance.AutoSize = True
        Me.rbBalance.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbBalance.ForeColor = System.Drawing.Color.Black
        Me.rbBalance.Location = New System.Drawing.Point(15, 38)
        Me.rbBalance.Name = "rbBalance"
        Me.rbBalance.Size = New System.Drawing.Size(77, 21)
        Me.rbBalance.TabIndex = 0
        Me.rbBalance.Text = "Balance"
        Me.rbBalance.UseVisualStyleBackColor = True
        '
        'gbTipoCuenta
        '
        Me.gbTipoCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbTipoCuenta.Location = New System.Drawing.Point(9, 18)
        Me.gbTipoCuenta.Name = "gbTipoCuenta"
        Me.gbTipoCuenta.Size = New System.Drawing.Size(322, 92)
        Me.gbTipoCuenta.TabIndex = 18
        Me.gbTipoCuenta.TabStop = False
        Me.gbTipoCuenta.Text = "Naturaleza"
        '
        'gbDatosGrupo
        '
        Me.gbDatosGrupo.Controls.Add(Me.txtNit)
        Me.gbDatosGrupo.Controls.Add(Me.txtRazonSocial)
        Me.gbDatosGrupo.Controls.Add(Me.dtpFechaFin)
        Me.gbDatosGrupo.Controls.Add(Me.dtpFechaInicio)
        Me.gbDatosGrupo.Controls.Add(Me.btCalcular)
        Me.gbDatosGrupo.Controls.Add(Me.Label4)
        Me.gbDatosGrupo.Controls.Add(Me.Label5)
        Me.gbDatosGrupo.Controls.Add(Me.Label11)
        Me.gbDatosGrupo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbDatosGrupo.Location = New System.Drawing.Point(10, 13)
        Me.gbDatosGrupo.Name = "gbDatosGrupo"
        Me.gbDatosGrupo.Size = New System.Drawing.Size(480, 117)
        Me.gbDatosGrupo.TabIndex = 16
        Me.gbDatosGrupo.TabStop = False
        Me.gbDatosGrupo.Text = "Empresa"
        '
        'txtNit
        '
        Me.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNit.ForeColor = System.Drawing.Color.Black
        Me.txtNit.Location = New System.Drawing.Point(34, 26)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(86, 25)
        Me.txtNit.TabIndex = 60036
        Me.txtNit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.Black
        Me.txtRazonSocial.Location = New System.Drawing.Point(124, 26)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(350, 25)
        Me.txtRazonSocial.TabIndex = 60035
        Me.txtRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd |  MMMM |  yyyy"
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(100, 86)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(189, 25)
        Me.dtpFechaFin.TabIndex = 60034
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CustomFormat = "dd |  MMMM |  yyyy"
        Me.dtpFechaInicio.Enabled = False
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.Location = New System.Drawing.Point(99, 57)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(189, 25)
        Me.dtpFechaInicio.TabIndex = 60033
        '
        'btCalcular
        '
        Me.btCalcular.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.btCalcular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCalcular.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCalcular.ForeColor = System.Drawing.Color.White
        Me.btCalcular.Image = Global.Quality.My.Resources.Resources.SEO_icon
        Me.btCalcular.Location = New System.Drawing.Point(320, 67)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(130, 34)
        Me.btCalcular.TabIndex = 60032
        Me.btCalcular.Text = "Previsualizar"
        Me.btCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btCalcular.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 60029
        Me.Label4.Text = "Fecha Inicio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 60030
        Me.Label5.Text = "Fecha fin:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(4, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Nit:"
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
        Me.Panel2.TabIndex = 10010
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.bar_chart_icon
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
        Me.LTitulo.Location = New System.Drawing.Point(-5, -1)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(910, 40)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Inventario y balance"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormInventarioBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(905, 523)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(921, 562)
        Me.MinimumSize = New System.Drawing.Size(921, 562)
        Me.Name = "FormInventarioBalance"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgBalance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDatosGrupo.ResumeLayout(False)
        Me.gbDatosGrupo.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents dgBalance As DataGridView
    Public WithEvents GroupBox1 As GroupBox
    Friend WithEvents btExportaExcel As Button
    Friend WithEvents btVisualizaPDF As Button
    Friend WithEvents rbTodas As RadioButton
    Friend WithEvents rbResultado As RadioButton
    Friend WithEvents rbBalance As RadioButton
    Friend WithEvents gbTipoCuenta As GroupBox
    Public WithEvents gbDatosGrupo As GroupBox
    Friend WithEvents txtNit As Label
    Friend WithEvents txtRazonSocial As Label
    Public WithEvents dtpFechaFin As DateTimePicker
    Public WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents btCalcular As Button
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label11 As Label
    Public WithEvents Panel2 As Panel
    Public WithEvents Pimagen As PictureBox
    Public WithEvents LTitulo As Label
End Class
