<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCerrarSesion
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PicCerrarSesion = New System.Windows.Forms.PictureBox()
        Me.PicRegresar = New System.Windows.Forms.PictureBox()
        Me.PicSalir = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCerrarSesion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicRegresar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSalir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.PicCerrarSesion)
        Me.GroupBox1.Controls.Add(Me.PicRegresar)
        Me.GroupBox1.Controls.Add(Me.PicSalir)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 382)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(216, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Regresar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 252)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Cerrar Sesion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Salir"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Quality.My.Resources.Resources.XANDaR
        Me.PictureBox4.Location = New System.Drawing.Point(45, 35)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(202, 182)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 26
        Me.PictureBox4.TabStop = False
        '
        'PicCerrarSesion
        '
        Me.PicCerrarSesion.BackColor = System.Drawing.Color.White
        Me.PicCerrarSesion.BackgroundImage = Global.Quality.My.Resources.Resources.Very_Basic_Update_icon
        Me.PicCerrarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicCerrarSesion.Location = New System.Drawing.Point(26, 276)
        Me.PicCerrarSesion.Name = "PicCerrarSesion"
        Me.PicCerrarSesion.Size = New System.Drawing.Size(65, 65)
        Me.PicCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCerrarSesion.TabIndex = 21
        Me.PicCerrarSesion.TabStop = False
        '
        'PicRegresar
        '
        Me.PicRegresar.BackColor = System.Drawing.Color.White
        Me.PicRegresar.BackgroundImage = Global.Quality.My.Resources.Resources.regresar
        Me.PicRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicRegresar.Location = New System.Drawing.Point(209, 276)
        Me.PicRegresar.Name = "PicRegresar"
        Me.PicRegresar.Size = New System.Drawing.Size(65, 65)
        Me.PicRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicRegresar.TabIndex = 25
        Me.PicRegresar.TabStop = False
        '
        'PicSalir
        '
        Me.PicSalir.BackColor = System.Drawing.Color.White
        Me.PicSalir.BackgroundImage = Global.Quality.My.Resources.Resources.Data_Export_icon
        Me.PicSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PicSalir.Location = New System.Drawing.Point(118, 276)
        Me.PicSalir.Name = "PicSalir"
        Me.PicSalir.Size = New System.Drawing.Size(65, 65)
        Me.PicSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicSalir.TabIndex = 24
        Me.PicSalir.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "_____________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(115, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "_____________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(206, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "_____________"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(296, 16)
        Me.Label7.TabIndex = 33
        '
        'FormCerrarSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(343, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(343, 426)
        Me.MinimumSize = New System.Drawing.Size(343, 426)
        Me.Name = "FormCerrarSesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCerrarSesion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicRegresar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSalir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PicRegresar As PictureBox
    Friend WithEvents PicSalir As PictureBox
    Friend WithEvents PicCerrarSesion As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
