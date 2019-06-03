<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLibroDiario
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
        Me.gbDatosGrupo = New System.Windows.Forms.GroupBox()
        Me.btExportaExcel = New System.Windows.Forms.Button()
        Me.txtNit = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.btVisualizaPDF = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.gbDatosGrupo.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatosGrupo
        '
        Me.gbDatosGrupo.Controls.Add(Me.btExportaExcel)
        Me.gbDatosGrupo.Controls.Add(Me.txtNit)
        Me.gbDatosGrupo.Controls.Add(Me.txtRazonSocial)
        Me.gbDatosGrupo.Controls.Add(Me.dtpFechaFin)
        Me.gbDatosGrupo.Controls.Add(Me.dtpFechaInicio)
        Me.gbDatosGrupo.Controls.Add(Me.btVisualizaPDF)
        Me.gbDatosGrupo.Controls.Add(Me.Label4)
        Me.gbDatosGrupo.Controls.Add(Me.Label5)
        Me.gbDatosGrupo.Controls.Add(Me.Label11)
        Me.gbDatosGrupo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbDatosGrupo.Location = New System.Drawing.Point(9, 48)
        Me.gbDatosGrupo.Name = "gbDatosGrupo"
        Me.gbDatosGrupo.Size = New System.Drawing.Size(584, 313)
        Me.gbDatosGrupo.TabIndex = 17
        Me.gbDatosGrupo.TabStop = False
        '
        'btExportaExcel
        '
        Me.btExportaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btExportaExcel.Enabled = False
        Me.btExportaExcel.Image = Global.Quality.My.Resources.Resources.Microsoft_Excel_2013_icon1
        Me.btExportaExcel.Location = New System.Drawing.Point(445, 95)
        Me.btExportaExcel.Name = "btExportaExcel"
        Me.btExportaExcel.Size = New System.Drawing.Size(42, 38)
        Me.btExportaExcel.TabIndex = 60042
        Me.btExportaExcel.UseVisualStyleBackColor = True
        '
        'txtNit
        '
        Me.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNit.ForeColor = System.Drawing.Color.Black
        Me.txtNit.Location = New System.Drawing.Point(67, 29)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.Size = New System.Drawing.Size(86, 25)
        Me.txtNit.TabIndex = 60041
        Me.txtNit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.Black
        Me.txtRazonSocial.Location = New System.Drawing.Point(157, 29)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(387, 25)
        Me.txtRazonSocial.TabIndex = 60040
        Me.txtRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd |  MMMM |  yyyy"
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(120, 121)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(189, 25)
        Me.dtpFechaFin.TabIndex = 60039
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.CustomFormat = "dd |  MMMM |  yyyy"
        Me.dtpFechaInicio.Enabled = False
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaInicio.Location = New System.Drawing.Point(119, 83)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(189, 25)
        Me.dtpFechaInicio.TabIndex = 60038
        '
        'btVisualizaPDF
        '
        Me.btVisualizaPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btVisualizaPDF.Enabled = False
        Me.btVisualizaPDF.Image = Global.Quality.My.Resources.Resources.Printer_icon__1_1
        Me.btVisualizaPDF.Location = New System.Drawing.Point(387, 95)
        Me.btVisualizaPDF.Name = "btVisualizaPDF"
        Me.btVisualizaPDF.Size = New System.Drawing.Size(42, 38)
        Me.btVisualizaPDF.TabIndex = 60037
        Me.btVisualizaPDF.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 88)
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
        Me.Label5.Location = New System.Drawing.Point(5, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 60030
        Me.Label5.Text = "Fecha Fin:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Nit:"
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
        Me.Panel1.Size = New System.Drawing.Size(603, 42)
        Me.Panel1.TabIndex = 2
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.project_plan_icon
        Me.Pimagen.Location = New System.Drawing.Point(4, 0)
        Me.Pimagen.Name = "Pimagen"
        Me.Pimagen.Size = New System.Drawing.Size(58, 41)
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pimagen.TabIndex = 1
        Me.Pimagen.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(2, 0)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(601, 41)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Libro diario"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormLibroDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(603, 369)
        Me.Controls.Add(Me.gbDatosGrupo)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(619, 408)
        Me.MinimumSize = New System.Drawing.Size(619, 408)
        Me.Name = "FormLibroDiario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbDatosGrupo.ResumeLayout(False)
        Me.gbDatosGrupo.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Panel1 As Panel
    Public WithEvents Pimagen As PictureBox
    Public WithEvents LTitulo As Label
    Public WithEvents gbDatosGrupo As GroupBox
    Friend WithEvents txtNit As Label
    Friend WithEvents txtRazonSocial As Label
    Public WithEvents dtpFechaFin As DateTimePicker
    Public WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents btVisualizaPDF As Button
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label11 As Label
    Friend WithEvents btExportaExcel As Button
End Class
