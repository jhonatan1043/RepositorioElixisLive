<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLibroAuxiliar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLibroAuxiliar))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.gbDatosGrupo = New System.Windows.Forms.GroupBox()
        Me.btTercero = New System.Windows.Forms.Button()
        Me.txtTercero = New System.Windows.Forms.Label()
        Me.txtRazonSocial = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btCuenta = New System.Windows.Forms.Button()
        Me.txtCodigoCuenta = New System.Windows.Forms.Label()
        Me.txtDescripcionCuenta = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.btVisualizaPDF = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatosGrupo.SuspendLayout()
        Me.SuspendLayout()
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
        Me.LTitulo.Text = "Libro auxiliar"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbDatosGrupo
        '
        Me.gbDatosGrupo.Controls.Add(Me.btTercero)
        Me.gbDatosGrupo.Controls.Add(Me.txtTercero)
        Me.gbDatosGrupo.Controls.Add(Me.txtRazonSocial)
        Me.gbDatosGrupo.Controls.Add(Me.Label3)
        Me.gbDatosGrupo.Controls.Add(Me.btCuenta)
        Me.gbDatosGrupo.Controls.Add(Me.txtCodigoCuenta)
        Me.gbDatosGrupo.Controls.Add(Me.txtDescripcionCuenta)
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
        Me.gbDatosGrupo.Size = New System.Drawing.Size(584, 310)
        Me.gbDatosGrupo.TabIndex = 17
        Me.gbDatosGrupo.TabStop = False
        '
        'btTercero
        '
        Me.btTercero.BackgroundImage = CType(resources.GetObject("btTercero.BackgroundImage"), System.Drawing.Image)
        Me.btTercero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btTercero.Image = CType(resources.GetObject("btTercero.Image"), System.Drawing.Image)
        Me.btTercero.Location = New System.Drawing.Point(548, 54)
        Me.btTercero.Name = "btTercero"
        Me.btTercero.Size = New System.Drawing.Size(26, 25)
        Me.btTercero.TabIndex = 60046
        Me.btTercero.UseVisualStyleBackColor = True
        '
        'txtTercero
        '
        Me.txtTercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTercero.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTercero.ForeColor = System.Drawing.Color.Black
        Me.txtTercero.Location = New System.Drawing.Point(67, 53)
        Me.txtTercero.Name = "txtTercero"
        Me.txtTercero.Size = New System.Drawing.Size(86, 25)
        Me.txtTercero.TabIndex = 60045
        Me.txtTercero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtRazonSocial
        '
        Me.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRazonSocial.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRazonSocial.ForeColor = System.Drawing.Color.Black
        Me.txtRazonSocial.Location = New System.Drawing.Point(157, 53)
        Me.txtRazonSocial.Name = "txtRazonSocial"
        Me.txtRazonSocial.Size = New System.Drawing.Size(387, 25)
        Me.txtRazonSocial.TabIndex = 60044
        Me.txtRazonSocial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 60043
        Me.Label3.Text = "Tercero:"
        '
        'btCuenta
        '
        Me.btCuenta.BackgroundImage = CType(resources.GetObject("btCuenta.BackgroundImage"), System.Drawing.Image)
        Me.btCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btCuenta.Image = CType(resources.GetObject("btCuenta.Image"), System.Drawing.Image)
        Me.btCuenta.Location = New System.Drawing.Point(548, 22)
        Me.btCuenta.Name = "btCuenta"
        Me.btCuenta.Size = New System.Drawing.Size(26, 25)
        Me.btCuenta.TabIndex = 60042
        Me.btCuenta.UseVisualStyleBackColor = True
        '
        'txtCodigoCuenta
        '
        Me.txtCodigoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoCuenta.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoCuenta.Location = New System.Drawing.Point(67, 22)
        Me.txtCodigoCuenta.Name = "txtCodigoCuenta"
        Me.txtCodigoCuenta.Size = New System.Drawing.Size(86, 25)
        Me.txtCodigoCuenta.TabIndex = 60041
        Me.txtCodigoCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcionCuenta
        '
        Me.txtDescripcionCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionCuenta.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcionCuenta.Location = New System.Drawing.Point(157, 22)
        Me.txtDescripcionCuenta.Name = "txtDescripcionCuenta"
        Me.txtDescripcionCuenta.Size = New System.Drawing.Size(387, 25)
        Me.txtDescripcionCuenta.TabIndex = 60040
        Me.txtDescripcionCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.CustomFormat = "dd |  MMMM |  yyyy"
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaFin.Location = New System.Drawing.Point(120, 137)
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
        Me.dtpFechaInicio.Location = New System.Drawing.Point(119, 99)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(189, 25)
        Me.dtpFechaInicio.TabIndex = 60038
        '
        'btVisualizaPDF
        '
        Me.btVisualizaPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btVisualizaPDF.Enabled = False
        Me.btVisualizaPDF.Image = Global.Quality.My.Resources.Resources.Printer_icon__1_1
        Me.btVisualizaPDF.Location = New System.Drawing.Point(354, 110)
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
        Me.Label4.Location = New System.Drawing.Point(6, 104)
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
        Me.Label5.Location = New System.Drawing.Point(5, 143)
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
        Me.Label11.Location = New System.Drawing.Point(7, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 17)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Cuenta:"
        '
        'FormLibroAuxiliar
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
        Me.Name = "FormLibroAuxiliar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatosGrupo.ResumeLayout(False)
        Me.gbDatosGrupo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Panel1 As Panel
    Public WithEvents Pimagen As PictureBox
    Public WithEvents LTitulo As Label
    Public WithEvents gbDatosGrupo As GroupBox
    Public WithEvents btCuenta As Button
    Friend WithEvents txtCodigoCuenta As Label
    Friend WithEvents txtDescripcionCuenta As Label
    Public WithEvents dtpFechaFin As DateTimePicker
    Public WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents btVisualizaPDF As Button
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label11 As Label
    Public WithEvents btTercero As Button
    Friend WithEvents txtTercero As Label
    Friend WithEvents txtRazonSocial As Label
    Public WithEvents Label3 As Label
End Class
