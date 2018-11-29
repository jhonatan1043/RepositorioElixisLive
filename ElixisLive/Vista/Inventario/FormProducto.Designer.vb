<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducto
    Inherits Quality.FormBase

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbMarca = New System.Windows.Forms.ComboBox()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Gbdatos.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.Size = New System.Drawing.Size(603, 42)
        Me.LTitulo.Text = "Productos"
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.Image = Global.Quality.My.Resources.Resources.palet_03_icon
        Me.Pimagen.Location = New System.Drawing.Point(4, -3)
        Me.Pimagen.Size = New System.Drawing.Size(43, 46)
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Gbdatos
        '
        Me.Gbdatos.Controls.Add(Me.cbMarca)
        Me.Gbdatos.Controls.Add(Me.Label1)
        Me.Gbdatos.Controls.SetChildIndex(Me.Label5, 0)
        Me.Gbdatos.Controls.SetChildIndex(Me.Label3, 0)
        Me.Gbdatos.Controls.SetChildIndex(Me.txtcodigo, 0)
        Me.Gbdatos.Controls.SetChildIndex(Me.txtnombre, 0)
        Me.Gbdatos.Controls.SetChildIndex(Me.Label1, 0)
        Me.Gbdatos.Controls.SetChildIndex(Me.cbMarca, 0)
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(87, 16)
        Me.txtnombre.Size = New System.Drawing.Size(219, 25)
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(563, 17)
        Me.txtcodigo.Size = New System.Drawing.Size(12, 25)
        Me.txtcodigo.Visible = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 19)
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.Text = "Producto:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(279, 67)
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.Text = "Em@il:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(312, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Marca:"
        '
        'cbMarca
        '
        Me.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMarca.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cbMarca.FormattingEnabled = True
        Me.cbMarca.Location = New System.Drawing.Point(373, 16)
        Me.cbMarca.Name = "cbMarca"
        Me.cbMarca.Size = New System.Drawing.Size(201, 25)
        Me.cbMarca.TabIndex = 20
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        Me.ErrorIcono.RightToLeft = True
        '
        'FormProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(603, 369)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FormProducto"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Gbdatos.ResumeLayout(False)
        Me.Gbdatos.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbMarca As ComboBox
    Friend WithEvents ErrorIcono As ErrorProvider
End Class
