<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModulo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chNomina = New System.Windows.Forms.CheckBox()
        Me.chConfiguracion = New System.Windows.Forms.CheckBox()
        Me.chEstadistica = New System.Windows.Forms.CheckBox()
        Me.gbClave = New System.Windows.Forms.GroupBox()
        Me.TextClave = New System.Windows.Forms.TextBox()
        Me.btDeclinar = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chAdministracion = New System.Windows.Forms.CheckBox()
        Me.ChCitas = New System.Windows.Forms.CheckBox()
        Me.ChInventario = New System.Windows.Forms.CheckBox()
        Me.ChContabilidad = New System.Windows.Forms.CheckBox()
        Me.ChVentas = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gbClave.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chNomina)
        Me.GroupBox1.Controls.Add(Me.chConfiguracion)
        Me.GroupBox1.Controls.Add(Me.chEstadistica)
        Me.GroupBox1.Controls.Add(Me.gbClave)
        Me.GroupBox1.Controls.Add(Me.chAdministracion)
        Me.GroupBox1.Controls.Add(Me.ChCitas)
        Me.GroupBox1.Controls.Add(Me.ChInventario)
        Me.GroupBox1.Controls.Add(Me.ChContabilidad)
        Me.GroupBox1.Controls.Add(Me.ChVentas)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 348)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'chNomina
        '
        Me.chNomina.AutoSize = True
        Me.chNomina.Image = Global.Quality.My.Resources.Resources._05_step2_review_payroll_02
        Me.chNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chNomina.Location = New System.Drawing.Point(217, 253)
        Me.chNomina.Name = "chNomina"
        Me.chNomina.Size = New System.Drawing.Size(87, 77)
        Me.chNomina.TabIndex = 27
        Me.chNomina.Text = "Nomina"
        Me.chNomina.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chNomina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chNomina.UseVisualStyleBackColor = True
        '
        'chConfiguracion
        '
        Me.chConfiguracion.AutoSize = True
        Me.chConfiguracion.Image = Global.Quality.My.Resources.Resources.Setting_icon
        Me.chConfiguracion.Location = New System.Drawing.Point(65, 22)
        Me.chConfiguracion.Name = "chConfiguracion"
        Me.chConfiguracion.Size = New System.Drawing.Size(91, 81)
        Me.chConfiguracion.TabIndex = 24
        Me.chConfiguracion.Text = "Configuracion"
        Me.chConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chConfiguracion.UseVisualStyleBackColor = True
        '
        'chEstadistica
        '
        Me.chEstadistica.AutoSize = True
        Me.chEstadistica.Image = Global.Quality.My.Resources.Resources.bar_chart_icon1
        Me.chEstadistica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chEstadistica.Location = New System.Drawing.Point(369, 249)
        Me.chEstadistica.Name = "chEstadistica"
        Me.chEstadistica.Size = New System.Drawing.Size(82, 81)
        Me.chEstadistica.TabIndex = 25
        Me.chEstadistica.Text = "Estadisticas"
        Me.chEstadistica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chEstadistica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chEstadistica.UseVisualStyleBackColor = True
        '
        'gbClave
        '
        Me.gbClave.BackColor = System.Drawing.Color.SteelBlue
        Me.gbClave.Controls.Add(Me.TextClave)
        Me.gbClave.Controls.Add(Me.btDeclinar)
        Me.gbClave.Controls.Add(Me.btAceptar)
        Me.gbClave.Controls.Add(Me.Label1)
        Me.gbClave.Location = New System.Drawing.Point(165, 127)
        Me.gbClave.Name = "gbClave"
        Me.gbClave.Size = New System.Drawing.Size(320, 87)
        Me.gbClave.TabIndex = 23
        Me.gbClave.TabStop = False
        '
        'TextClave
        '
        Me.TextClave.Location = New System.Drawing.Point(6, 31)
        Me.TextClave.Name = "TextClave"
        Me.TextClave.Size = New System.Drawing.Size(308, 20)
        Me.TextClave.TabIndex = 3
        '
        'btDeclinar
        '
        Me.btDeclinar.Location = New System.Drawing.Point(224, 57)
        Me.btDeclinar.Name = "btDeclinar"
        Me.btDeclinar.Size = New System.Drawing.Size(75, 23)
        Me.btDeclinar.TabIndex = 2
        Me.btDeclinar.Text = "&Declinar"
        Me.btDeclinar.UseVisualStyleBackColor = True
        '
        'btAceptar
        '
        Me.btAceptar.Location = New System.Drawing.Point(140, 57)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btAceptar.TabIndex = 1
        Me.btAceptar.Text = "&Aceptar"
        Me.btAceptar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(94, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite la clave del producto"
        '
        'chAdministracion
        '
        Me.chAdministracion.AutoSize = True
        Me.chAdministracion.Image = Global.Quality.My.Resources.Resources.Personnel_icon
        Me.chAdministracion.Location = New System.Drawing.Point(210, 22)
        Me.chAdministracion.Name = "chAdministracion"
        Me.chAdministracion.Size = New System.Drawing.Size(94, 81)
        Me.chAdministracion.TabIndex = 22
        Me.chAdministracion.Text = "Administracion"
        Me.chAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chAdministracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.chAdministracion.UseVisualStyleBackColor = True
        '
        'ChCitas
        '
        Me.ChCitas.AutoSize = True
        Me.ChCitas.Image = Global.Quality.My.Resources.Resources.Network_time_icon__1_
        Me.ChCitas.Location = New System.Drawing.Point(522, 249)
        Me.ChCitas.Name = "ChCitas"
        Me.ChCitas.Size = New System.Drawing.Size(79, 81)
        Me.ChCitas.TabIndex = 21
        Me.ChCitas.Text = "Citas"
        Me.ChCitas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChCitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ChCitas.UseVisualStyleBackColor = True
        '
        'ChInventario
        '
        Me.ChInventario.AutoSize = True
        Me.ChInventario.Image = Global.Quality.My.Resources.Resources.palet_01_icon1
        Me.ChInventario.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChInventario.Location = New System.Drawing.Point(369, 22)
        Me.ChInventario.Name = "ChInventario"
        Me.ChInventario.Size = New System.Drawing.Size(79, 81)
        Me.ChInventario.TabIndex = 18
        Me.ChInventario.Text = "Inventario"
        Me.ChInventario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ChInventario.UseVisualStyleBackColor = True
        '
        'ChContabilidad
        '
        Me.ChContabilidad.AutoSize = True
        Me.ChContabilidad.Image = Global.Quality.My.Resources.Resources.Safe_icon
        Me.ChContabilidad.Location = New System.Drawing.Point(65, 249)
        Me.ChContabilidad.Name = "ChContabilidad"
        Me.ChContabilidad.Size = New System.Drawing.Size(84, 81)
        Me.ChContabilidad.TabIndex = 20
        Me.ChContabilidad.Text = "Contabilidad"
        Me.ChContabilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChContabilidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ChContabilidad.UseVisualStyleBackColor = True
        '
        'ChVentas
        '
        Me.ChVentas.AutoSize = True
        Me.ChVentas.Image = Global.Quality.My.Resources.Resources.DeviceControl_icon
        Me.ChVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChVentas.Location = New System.Drawing.Point(522, 22)
        Me.ChVentas.Name = "ChVentas"
        Me.ChVentas.Size = New System.Drawing.Size(79, 81)
        Me.ChVentas.TabIndex = 19
        Me.ChVentas.Text = "Ventas"
        Me.ChVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ChVentas.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btRegistrar, Me.btEditar, Me.btCancelar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 399)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(713, 37)
        Me.ToolStrip1.TabIndex = 17
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
        Me.btRegistrar.Text = "&Registrar"
        Me.btRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btEditar
        '
        Me.btEditar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEditar.ForeColor = System.Drawing.Color.White
        Me.btEditar.Image = Global.Quality.My.Resources.Resources.pencil_icon__1_
        Me.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(86, 34)
        Me.btEditar.Text = "&Editar"
        Me.btEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.White
        Me.btCancelar.Image = Global.Quality.My.Resources.Resources.Actions_blue_arrow_undo_icon
        Me.btCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(104, 34)
        Me.btCancelar.Text = "&Cancelar"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Pimagen)
        Me.Panel1.Controls.Add(Me.LTitulo)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(713, 42)
        Me.Panel1.TabIndex = 1
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.Network_Panel_Settings_icon
        Me.Pimagen.Location = New System.Drawing.Point(4, 0)
        Me.Pimagen.Name = "Pimagen"
        Me.Pimagen.Size = New System.Drawing.Size(50, 39)
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pimagen.TabIndex = 1
        Me.Pimagen.TabStop = False
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.White
        Me.LTitulo.Location = New System.Drawing.Point(0, 1)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(713, 44)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Asignación de modulos"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormModulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(713, 436)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(729, 475)
        Me.MinimumSize = New System.Drawing.Size(729, 475)
        Me.Name = "FormModulo"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbClave.ResumeLayout(False)
        Me.gbClave.PerformLayout()
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
    Public WithEvents ToolStrip1 As ToolStrip
    Public WithEvents btRegistrar As ToolStripButton
    Public WithEvents btEditar As ToolStripButton
    Public WithEvents btCancelar As ToolStripButton
    Friend WithEvents ChInventario As CheckBox
    Friend WithEvents ChVentas As CheckBox
    Friend WithEvents ChContabilidad As CheckBox
    Friend WithEvents ChCitas As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chAdministracion As CheckBox
    Friend WithEvents gbClave As GroupBox
    Friend WithEvents TextClave As TextBox
    Friend WithEvents btDeclinar As Button
    Friend WithEvents btAceptar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents chNomina As CheckBox
    Friend WithEvents chConfiguracion As CheckBox
    Friend WithEvents chEstadistica As CheckBox
End Class
