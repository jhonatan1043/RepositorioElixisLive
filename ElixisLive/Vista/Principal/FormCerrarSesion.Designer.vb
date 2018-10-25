<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCerrarSesion
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PicRegresar = New System.Windows.Forms.PictureBox()
        Me.PicSalir = New System.Windows.Forms.PictureBox()
        Me.PicCerrarSesion = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCerrarSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(319, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 23)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Regresar"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(239, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Salir"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(124, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Cerrar Sesión"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Quality.My.Resources.Resources.Quality_logo
        Me.PictureBox4.Location = New System.Drawing.Point(7, 20)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(109, 118)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'PicRegresar
        '
        Me.PicRegresar.Image = Global.Quality.My.Resources.Resources.glossy_3d_blue_orbs2_092_icon
        Me.PicRegresar.Location = New System.Drawing.Point(310, 36)
        Me.PicRegresar.Name = "PicRegresar"
        Me.PicRegresar.Size = New System.Drawing.Size(75, 75)
        Me.PicRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRegresar.TabIndex = 25
        Me.PicRegresar.TabStop = False
        '
        'PicSalir
        '
        Me.PicSalir.Image = Global.Quality.My.Resources.Resources.glossy_3d_blue_orbs2_132_icon
        Me.PicSalir.Location = New System.Drawing.Point(218, 36)
        Me.PicSalir.Name = "PicSalir"
        Me.PicSalir.Size = New System.Drawing.Size(75, 75)
        Me.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSalir.TabIndex = 24
        Me.PicSalir.TabStop = False
        '
        'PicCerrarSesion
        '
        Me.PicCerrarSesion.Image = Global.Quality.My.Resources.Resources.glossy_3d_blue_orbs2_115_icon
        Me.PicCerrarSesion.Location = New System.Drawing.Point(127, 36)
        Me.PicCerrarSesion.Name = "PicCerrarSesion"
        Me.PicCerrarSesion.Size = New System.Drawing.Size(75, 75)
        Me.PicCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCerrarSesion.TabIndex = 21
        Me.PicCerrarSesion.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 132)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'FormCerrarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Quality.My.Resources.Resources.fondo_azul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(401, 146)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PicRegresar)
        Me.Controls.Add(Me.PicSalir)
        Me.Controls.Add(Me.PicCerrarSesion)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormCerrarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSalir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCerrarSesion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PicRegresar As PictureBox
    Friend WithEvents PicSalir As PictureBox
    Friend WithEvents PicCerrarSesion As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
