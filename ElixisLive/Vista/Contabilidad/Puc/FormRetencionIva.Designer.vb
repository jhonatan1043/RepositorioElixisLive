<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRetencionIva
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.gbInformacionCuenta = New System.Windows.Forms.GroupBox()
        Me.txtCodigoPuc = New System.Windows.Forms.Label()
        Me.txtDescripcionPUC = New System.Windows.Forms.Label()
        Me.txtCodigoCuenta = New System.Windows.Forms.Label()
        Me.txtNombreCuenta = New System.Windows.Forms.Label()
        Me.btBusquedaCuenta = New System.Windows.Forms.Button()
        Me.txtTasa = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btBusqueda = New System.Windows.Forms.ToolStripButton()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.Panel1.SuspendLayout()
        Me.gbDatosGrupo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbInformacionCuenta.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
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
        Me.Panel1.TabIndex = 4
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.Black
        Me.LTitulo.Location = New System.Drawing.Point(2, 3)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(490, 28)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Retención IVA"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbDatosGrupo
        '
        Me.gbDatosGrupo.Controls.Add(Me.GroupBox1)
        Me.gbDatosGrupo.Controls.Add(Me.gbInformacionCuenta)
        Me.gbDatosGrupo.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosGrupo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gbDatosGrupo.Location = New System.Drawing.Point(9, 42)
        Me.gbDatosGrupo.Name = "gbDatosGrupo"
        Me.gbDatosGrupo.Size = New System.Drawing.Size(584, 286)
        Me.gbDatosGrupo.TabIndex = 19
        Me.gbDatosGrupo.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(7, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(571, 159)
        Me.GroupBox1.TabIndex = 60041
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Observaciones"
        '
        'txtObservacion
        '
        Me.txtObservacion.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(6, 20)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(559, 133)
        Me.txtObservacion.TabIndex = 60020
        '
        'gbInformacionCuenta
        '
        Me.gbInformacionCuenta.Controls.Add(Me.txtCodigoPuc)
        Me.gbInformacionCuenta.Controls.Add(Me.txtDescripcionPUC)
        Me.gbInformacionCuenta.Controls.Add(Me.txtCodigoCuenta)
        Me.gbInformacionCuenta.Controls.Add(Me.txtNombreCuenta)
        Me.gbInformacionCuenta.Controls.Add(Me.btBusquedaCuenta)
        Me.gbInformacionCuenta.Controls.Add(Me.txtTasa)
        Me.gbInformacionCuenta.Controls.Add(Me.Label7)
        Me.gbInformacionCuenta.Controls.Add(Me.Label6)
        Me.gbInformacionCuenta.Controls.Add(Me.Label1)
        Me.gbInformacionCuenta.Controls.Add(Me.txtBase)
        Me.gbInformacionCuenta.Controls.Add(Me.Label2)
        Me.gbInformacionCuenta.Controls.Add(Me.Label3)
        Me.gbInformacionCuenta.Controls.Add(Me.Label8)
        Me.gbInformacionCuenta.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInformacionCuenta.ForeColor = System.Drawing.Color.Black
        Me.gbInformacionCuenta.Location = New System.Drawing.Point(7, 9)
        Me.gbInformacionCuenta.Name = "gbInformacionCuenta"
        Me.gbInformacionCuenta.Size = New System.Drawing.Size(571, 106)
        Me.gbInformacionCuenta.TabIndex = 60040
        Me.gbInformacionCuenta.TabStop = False
        Me.gbInformacionCuenta.Text = "Información de la Cuenta"
        '
        'txtCodigoPuc
        '
        Me.txtCodigoPuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoPuc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoPuc.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoPuc.Location = New System.Drawing.Point(84, 18)
        Me.txtCodigoPuc.Name = "txtCodigoPuc"
        Me.txtCodigoPuc.Size = New System.Drawing.Size(96, 25)
        Me.txtCodigoPuc.TabIndex = 60051
        Me.txtCodigoPuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcionPUC
        '
        Me.txtDescripcionPUC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionPUC.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionPUC.ForeColor = System.Drawing.Color.Black
        Me.txtDescripcionPUC.Location = New System.Drawing.Point(329, 18)
        Me.txtDescripcionPUC.Name = "txtDescripcionPUC"
        Me.txtDescripcionPUC.Size = New System.Drawing.Size(232, 25)
        Me.txtDescripcionPUC.TabIndex = 60050
        Me.txtDescripcionPUC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigoCuenta
        '
        Me.txtCodigoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoCuenta.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtCodigoCuenta.Location = New System.Drawing.Point(84, 46)
        Me.txtCodigoCuenta.Name = "txtCodigoCuenta"
        Me.txtCodigoCuenta.Size = New System.Drawing.Size(96, 25)
        Me.txtCodigoCuenta.TabIndex = 60049
        Me.txtCodigoCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreCuenta
        '
        Me.txtNombreCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCuenta.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCuenta.ForeColor = System.Drawing.Color.Black
        Me.txtNombreCuenta.Location = New System.Drawing.Point(329, 46)
        Me.txtNombreCuenta.Name = "txtNombreCuenta"
        Me.txtNombreCuenta.Size = New System.Drawing.Size(232, 25)
        Me.txtNombreCuenta.TabIndex = 60048
        Me.txtNombreCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btBusquedaCuenta
        '
        Me.btBusquedaCuenta.BackgroundImage = Global.Quality.My.Resources.Resources.Very_Basic_Search_icon
        Me.btBusquedaCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBusquedaCuenta.Location = New System.Drawing.Point(187, 46)
        Me.btBusquedaCuenta.Name = "btBusquedaCuenta"
        Me.btBusquedaCuenta.Size = New System.Drawing.Size(26, 25)
        Me.btBusquedaCuenta.TabIndex = 60047
        Me.btBusquedaCuenta.UseVisualStyleBackColor = True
        '
        'txtTasa
        '
        Me.txtTasa.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTasa.Location = New System.Drawing.Point(329, 74)
        Me.txtTasa.Name = "txtTasa"
        Me.txtTasa.Size = New System.Drawing.Size(194, 25)
        Me.txtTasa.TabIndex = 60019
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(238, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 60020
        Me.Label7.Text = "Tasa (%):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(238, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 60018
        Me.Label6.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(238, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 17)
        Me.Label1.TabIndex = 60017
        Me.Label1.Text = "Descripción:"
        '
        'txtBase
        '
        Me.txtBase.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBase.Location = New System.Drawing.Point(84, 74)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(96, 25)
        Me.txtBase.TabIndex = 60015
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 60016
        Me.Label2.Text = "Base:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cuenta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "PUC:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btNuevo, Me.btBusqueda, Me.btRegistrar, Me.btEditar, Me.btCancelar, Me.btAnular})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 337)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(603, 32)
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
        'FormRetencionIva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(603, 369)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbDatosGrupo)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(619, 408)
        Me.MinimumSize = New System.Drawing.Size(619, 408)
        Me.Name = "FormRetencionIva"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.gbDatosGrupo.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbInformacionCuenta.ResumeLayout(False)
        Me.gbInformacionCuenta.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents Panel1 As Panel
    Public WithEvents LTitulo As Label
    Public WithEvents btBuscar As ToolStripButton
    Public WithEvents gbDatosGrupo As GroupBox
    Public WithEvents GroupBox1 As GroupBox
    Public WithEvents txtObservacion As TextBox
    Public WithEvents gbInformacionCuenta As GroupBox
    Public WithEvents txtTasa As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label1 As Label
    Public WithEvents txtBase As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label8 As Label
    Public WithEvents btBusquedaCuenta As Button
    Friend WithEvents txtCodigoCuenta As Label
    Friend WithEvents txtNombreCuenta As Label
    Friend WithEvents txtCodigoPuc As Label
    Friend WithEvents txtDescripcionPUC As Label
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents btNuevo As ToolStripButton
    Public WithEvents btBusqueda As ToolStripButton
    Public WithEvents btRegistrar As ToolStripButton
    Public WithEvents btEditar As ToolStripButton
    Public WithEvents btCancelar As ToolStripButton
    Public WithEvents btAnular As ToolStripButton
End Class
