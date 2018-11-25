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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.txtPendiente = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.txtCancelado = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.txtRealizado = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.PanelDia = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Panel3)
        Me.GroupBox4.Controls.Add(Me.Panel2)
        Me.GroupBox4.Controls.Add(Me.txtBusqueda)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.dFecha)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 46)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(789, 54)
        Me.GroupBox4.TabIndex = 10052
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Filtros de busqueda:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.txtBusqueda.Location = New System.Drawing.Point(447, 20)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(331, 23)
        Me.txtBusqueda.TabIndex = 10066
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.Location = New System.Drawing.Point(367, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 10065
        Me.Label3.Text = "Filtro:"
        '
        'dFecha
        '
        Me.dFecha.CustomFormat = "MMMM\dddd,dd\yyyy"
        Me.dFecha.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.dFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dFecha.Location = New System.Drawing.Point(98, 21)
        Me.dFecha.Name = "dFecha"
        Me.dFecha.Size = New System.Drawing.Size(208, 23)
        Me.dFecha.TabIndex = 10059
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 10061
        Me.Label5.Text = "Fecha:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.txtPendiente, Me.ToolStripLabel3, Me.txtCancelado, Me.ToolStripLabel2, Me.txtRealizado, Me.ToolStripLabel4, Me.ToolStripTextBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 498)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(799, 25)
        Me.ToolStrip1.TabIndex = 10057
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(70, 22)
        Me.ToolStripLabel1.Text = "Agendados:"
        '
        'txtPendiente
        '
        Me.txtPendiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPendiente.Enabled = False
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.ReadOnly = True
        Me.txtPendiente.Size = New System.Drawing.Size(55, 25)
        Me.txtPendiente.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(71, 22)
        Me.ToolStripLabel3.Text = "Cancelados:"
        '
        'txtCancelado
        '
        Me.txtCancelado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCancelado.Enabled = False
        Me.txtCancelado.Name = "txtCancelado"
        Me.txtCancelado.ReadOnly = True
        Me.txtCancelado.Size = New System.Drawing.Size(55, 25)
        Me.txtCancelado.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(65, 22)
        Me.ToolStripLabel2.Text = "Realizados:"
        '
        'txtRealizado
        '
        Me.txtRealizado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRealizado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRealizado.Enabled = False
        Me.txtRealizado.Name = "txtRealizado"
        Me.txtRealizado.ReadOnly = True
        Me.txtRealizado.Size = New System.Drawing.Size(55, 25)
        Me.txtRealizado.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel4.Text = "Disponible:"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBox1.Enabled = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(55, 25)
        Me.ToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PanelDia
        '
        Me.PanelDia.AutoScroll = True
        Me.PanelDia.BackColor = System.Drawing.Color.White
        Me.PanelDia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDia.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic)
        Me.PanelDia.Location = New System.Drawing.Point(5, 106)
        Me.PanelDia.Name = "PanelDia"
        Me.PanelDia.Size = New System.Drawing.Size(789, 390)
        Me.PanelDia.TabIndex = 10056
        Me.PanelDia.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 42)
        Me.Panel1.TabIndex = 10058
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Quality.My.Resources.Resources.Resume_icon
        Me.PictureBox1.Location = New System.Drawing.Point(4, -7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(69, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(798, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agenda de Citas"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = Global.Quality.My.Resources.Resources.Actions_zoom_out_icon
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(413, 20)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(30, 23)
        Me.Panel3.TabIndex = 10068
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BackgroundImage = Global.Quality.My.Resources.Resources.calendar_icon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(67, 20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(30, 23)
        Me.Panel2.TabIndex = 10067
        '
        'FormProgramacionCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(799, 523)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelDia)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Location = New System.Drawing.Point(921, 562)
        Me.MaximumSize = New System.Drawing.Size(815, 562)
        Me.MinimumSize = New System.Drawing.Size(815, 562)
        Me.Name = "FormProgramacionCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents dFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtPendiente As ToolStripTextBox
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents txtRealizado As ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents txtCancelado As ToolStripTextBox
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PanelDia As Panel
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Public WithEvents Panel1 As Panel
    Public WithEvents PictureBox1 As PictureBox
    Public WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
