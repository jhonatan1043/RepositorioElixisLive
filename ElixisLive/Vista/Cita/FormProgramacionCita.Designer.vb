<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProgramacionCita
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
        Me.dFecha = New System.Windows.Forms.DateTimePicker()
        Me.PanelDia = New System.Windows.Forms.Panel()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rbAgendados = New System.Windows.Forms.RadioButton()
        Me.txtPendiente = New System.Windows.Forms.Button()
        Me.txtRealizado = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.lbInformacionCliente = New System.Windows.Forms.ToolStripLabel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dFecha
        '
        Me.dFecha.CustomFormat = "MMMM\dddd,dd\yyyy"
        Me.dFecha.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dFecha.Location = New System.Drawing.Point(818, 99)
        Me.dFecha.Name = "dFecha"
        Me.dFecha.Size = New System.Drawing.Size(80, 25)
        Me.dFecha.TabIndex = 10059
        Me.dFecha.Visible = False
        '
        'PanelDia
        '
        Me.PanelDia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelDia.AutoScroll = True
        Me.PanelDia.BackColor = System.Drawing.Color.White
        Me.PanelDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDia.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.PanelDia.Location = New System.Drawing.Point(1, 45)
        Me.PanelDia.Name = "PanelDia"
        Me.PanelDia.Size = New System.Drawing.Size(721, 448)
        Me.PanelDia.TabIndex = 10056
        Me.PanelDia.Visible = False
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.White
        Me.MonthCalendar1.Font = New System.Drawing.Font("Times New Roman", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.ForeColor = System.Drawing.Color.White
        Me.MonthCalendar1.Location = New System.Drawing.Point(726, 55)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.MonthCalendar1.TitleForeColor = System.Drawing.Color.White
        Me.MonthCalendar1.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(113, Byte), Integer))
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusqueda.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.Black
        Me.txtBusqueda.Location = New System.Drawing.Point(730, 248)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(199, 29)
        Me.txtBusqueda.TabIndex = 10068
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(727, 326)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(111, 24)
        Me.RadioButton2.TabIndex = 10070
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Realizados"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'rbAgendados
        '
        Me.rbAgendados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbAgendados.Appearance = System.Windows.Forms.Appearance.Button
        Me.rbAgendados.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbAgendados.Checked = True
        Me.rbAgendados.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAgendados.ForeColor = System.Drawing.Color.Black
        Me.rbAgendados.Location = New System.Drawing.Point(728, 300)
        Me.rbAgendados.Name = "rbAgendados"
        Me.rbAgendados.Size = New System.Drawing.Size(110, 24)
        Me.rbAgendados.TabIndex = 10072
        Me.rbAgendados.TabStop = True
        Me.rbAgendados.Text = "Agendados"
        Me.rbAgendados.UseVisualStyleBackColor = False
        '
        'txtPendiente
        '
        Me.txtPendiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtPendiente.Location = New System.Drawing.Point(840, 301)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.Size = New System.Drawing.Size(32, 22)
        Me.txtPendiente.TabIndex = 10074
        Me.txtPendiente.UseVisualStyleBackColor = False
        '
        'txtRealizado
        '
        Me.txtRealizado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRealizado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtRealizado.Location = New System.Drawing.Point(840, 326)
        Me.txtRealizado.Name = "txtRealizado"
        Me.txtRealizado.Size = New System.Drawing.Size(32, 22)
        Me.txtRealizado.TabIndex = 10076
        Me.txtRealizado.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbInformacionCliente})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 498)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(945, 25)
        Me.ToolStrip1.TabIndex = 10077
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'lbInformacionCliente
        '
        Me.lbInformacionCliente.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInformacionCliente.ForeColor = System.Drawing.Color.White
        Me.lbInformacionCliente.Name = "lbInformacionCliente"
        Me.lbInformacionCliente.Size = New System.Drawing.Size(0, 22)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(730, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(199, 38)
        Me.Label5.TabIndex = 10067
        Me.Label5.Text = "Filtro"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LTitulo)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(944, 34)
        Me.Panel1.TabIndex = 10058
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.Black
        Me.LTitulo.Location = New System.Drawing.Point(1, 3)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(837, 28)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Agenda de Citas"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'FormProgramacionCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(945, 523)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtRealizado)
        Me.Controls.Add(Me.txtPendiente)
        Me.Controls.Add(Me.rbAgendados)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PanelDia)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dFecha)
        Me.Location = New System.Drawing.Point(921, 562)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(961, 562)
        Me.MinimumSize = New System.Drawing.Size(961, 562)
        Me.Name = "FormProgramacionCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dFecha As DateTimePicker
    Friend WithEvents PanelDia As Panel
    Public WithEvents Panel1 As Panel
    Public WithEvents LTitulo As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Public WithEvents txtBusqueda As TextBox
    Public WithEvents Label5 As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents rbAgendados As RadioButton
    Friend WithEvents txtPendiente As Button
    Friend WithEvents txtRealizado As Button
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents lbInformacionCliente As ToolStripLabel
    Friend WithEvents ToolTip1 As ToolTip
End Class
