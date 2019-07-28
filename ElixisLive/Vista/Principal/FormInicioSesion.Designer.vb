<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class FormInicioSesion
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
    Friend WithEvents Pimagen As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbEmpresa = New System.Windows.Forms.ComboBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Pimagen = New System.Windows.Forms.PictureBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.BackColor = System.Drawing.Color.White
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(14, 213)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(66, 24)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Usuario:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.BackColor = System.Drawing.Color.White
        Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.PasswordLabel.Location = New System.Drawing.Point(14, 256)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(58, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Clave:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(69, 212)
        Me.txtUsuario.MaxLength = 15
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(193, 23)
        Me.txtUsuario.TabIndex = 1
        '
        'txtContraseña
        '
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.Location = New System.Drawing.Point(69, 254)
        Me.txtContraseña.MaxLength = 20
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(193, 23)
        Me.txtContraseña.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "&Sede:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbEmpresa
        '
        Me.CbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbEmpresa.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbEmpresa.FormattingEnabled = True
        Me.CbEmpresa.Location = New System.Drawing.Point(69, 293)
        Me.CbEmpresa.Name = "CbEmpresa"
        Me.CbEmpresa.Size = New System.Drawing.Size(193, 23)
        Me.CbEmpresa.TabIndex = 7
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OK.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK.ForeColor = System.Drawing.Color.Black
        Me.OK.Location = New System.Drawing.Point(107, 356)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(75, 30)
        Me.OK.TabIndex = 4
        Me.OK.Text = "&Aceptar"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.ForeColor = System.Drawing.Color.Black
        Me.Cancel.Location = New System.Drawing.Point(197, 356)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(75, 30)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Cancelar"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.CbEmpresa)
        Me.GroupBox2.Controls.Add(Me.txtContraseña)
        Me.GroupBox2.Controls.Add(Me.txtUsuario)
        Me.GroupBox2.Controls.Add(Me.Pimagen)
        Me.GroupBox2.Controls.Add(Me.UsernameLabel)
        Me.GroupBox2.Controls.Add(Me.PasswordLabel)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 382)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.XANDaR
        Me.Pimagen.Location = New System.Drawing.Point(35, 19)
        Me.Pimagen.Name = "Pimagen"
        Me.Pimagen.Size = New System.Drawing.Size(232, 167)
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pimagen.TabIndex = 0
        Me.Pimagen.TabStop = False
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        Me.ErrorIcono.RightToLeft = True
        '
        'FormInicioSesion
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(337, 420)
        Me.ControlBox = False
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(343, 426)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(343, 426)
        Me.Name = "FormInicioSesion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CbEmpresa As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents txtContraseña As TextBox
    Friend WithEvents ErrorIcono As ErrorProvider
End Class
