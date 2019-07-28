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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.gbDatosGrupo = New System.Windows.Forms.GroupBox()
        Me.btExportaExcel = New System.Windows.Forms.Button()
        Me.btTercero = New System.Windows.Forms.Button()
        Me.txtIdentificacionTercero = New System.Windows.Forms.Label()
        Me.txtDescripcionTercero = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btBusquedaCuenta = New System.Windows.Forms.Button()
        Me.txtCodigoCuenta = New System.Windows.Forms.Label()
        Me.txtDescripcionCuenta = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.btVisualizaPDF = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.gbDatosGrupo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LTitulo)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(603, 34)
        Me.Panel1.TabIndex = 2
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.Black
        Me.LTitulo.Location = New System.Drawing.Point(2, 3)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(511, 28)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Libro auxiliar"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbDatosGrupo
        '
        Me.gbDatosGrupo.Controls.Add(Me.btExportaExcel)
        Me.gbDatosGrupo.Controls.Add(Me.btTercero)
        Me.gbDatosGrupo.Controls.Add(Me.txtIdentificacionTercero)
        Me.gbDatosGrupo.Controls.Add(Me.txtDescripcionTercero)
        Me.gbDatosGrupo.Controls.Add(Me.Label3)
        Me.gbDatosGrupo.Controls.Add(Me.btBusquedaCuenta)
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
        'btExportaExcel
        '
        Me.btExportaExcel.BackgroundImage = Global.Quality.My.Resources.Resources.Logos_Excel_Copyrighted_icon
        Me.btExportaExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btExportaExcel.Enabled = False
        Me.btExportaExcel.Location = New System.Drawing.Point(414, 110)
        Me.btExportaExcel.Name = "btExportaExcel"
        Me.btExportaExcel.Size = New System.Drawing.Size(42, 38)
        Me.btExportaExcel.TabIndex = 60047
        Me.btExportaExcel.UseVisualStyleBackColor = True
        '
        'btTercero
        '
        Me.btTercero.BackgroundImage = Global.Quality.My.Resources.Resources.Very_Basic_Search_icon
        Me.btTercero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btTercero.Location = New System.Drawing.Point(548, 54)
        Me.btTercero.Name = "btTercero"
        Me.btTercero.Size = New System.Drawing.Size(26, 25)
        Me.btTercero.TabIndex = 60046
        Me.btTercero.UseVisualStyleBackColor = True
        '
        'txtIdentificacionTercero
        '
        Me.txtIdentificacionTercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdentificacionTercero.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacionTercero.ForeColor = System.Drawing.Color.Black
        Me.txtIdentificacionTercero.Location = New System.Drawing.Point(67, 53)
        Me.txtIdentificacionTercero.Name = "txtIdentificacionTercero"
        Me.txtIdentificacionTercero.Size = New System.Drawing.Size(86, 25)
        Me.txtIdentificacionTercero.TabIndex = 60045
        Me.txtIdentificacionTercero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcionTercero
        '
        Me.txtDescripcionTercero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionTercero.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTercero.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcionTercero.Location = New System.Drawing.Point(157, 53)
        Me.txtDescripcionTercero.Name = "txtDescripcionTercero"
        Me.txtDescripcionTercero.Size = New System.Drawing.Size(387, 25)
        Me.txtDescripcionTercero.TabIndex = 60044
        Me.txtDescripcionTercero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'btBusquedaCuenta
        '
        Me.btBusquedaCuenta.BackgroundImage = Global.Quality.My.Resources.Resources.Very_Basic_Search_icon
        Me.btBusquedaCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBusquedaCuenta.Location = New System.Drawing.Point(548, 22)
        Me.btBusquedaCuenta.Name = "btBusquedaCuenta"
        Me.btBusquedaCuenta.Size = New System.Drawing.Size(26, 25)
        Me.btBusquedaCuenta.TabIndex = 60042
        Me.btBusquedaCuenta.UseVisualStyleBackColor = True
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
        Me.btVisualizaPDF.BackgroundImage = Global.Quality.My.Resources.Resources.Computer_Hardware_Print_icon
        Me.btVisualizaPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btVisualizaPDF.Enabled = False
        Me.btVisualizaPDF.ForeColor = System.Drawing.Color.Black
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
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.gbDatosGrupo.ResumeLayout(False)
        Me.gbDatosGrupo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents Panel1 As Panel
    Public WithEvents LTitulo As Label
    Public WithEvents gbDatosGrupo As GroupBox
    Public WithEvents btBusquedaCuenta As Button
    Friend WithEvents txtCodigoCuenta As Label
    Friend WithEvents txtDescripcionCuenta As Label
    Public WithEvents dtpFechaFin As DateTimePicker
    Public WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents btVisualizaPDF As Button
    Public WithEvents Label4 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label11 As Label
    Public WithEvents btTercero As Button
    Friend WithEvents txtIdentificacionTercero As Label
    Friend WithEvents txtDescripcionTercero As Label
    Public WithEvents Label3 As Label
    Friend WithEvents btExportaExcel As Button
End Class
