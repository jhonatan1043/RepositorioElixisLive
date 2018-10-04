<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCliente
    Inherits ElixisLive.FormBaseProductivo

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.Text = "Clientes"
        '
        'Pimagen
        '
        Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        Me.Pimagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Pimagen.Image = Global.ElixisLive.My.Resources.Resources.proveedor
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(278, 12)
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.Text = "Nombre:"
        '
        'lbID
        '
        Me.lbID.Size = New System.Drawing.Size(34, 19)
        Me.lbID.Text = "Nit:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Size = New System.Drawing.Size(136, 22)
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(367, 66)
        Me.TextBox5.Size = New System.Drawing.Size(462, 22)
        '
        'Label5
        '
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.Text = "Em@il:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(367, 38)
        Me.TextBox4.Size = New System.Drawing.Size(462, 22)
        '
        'Label4
        '
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.Text = "Dirección:"
        '
        'TextBox3
        '
        Me.TextBox3.Size = New System.Drawing.Size(136, 22)
        '
        'Label3
        '
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.Text = "Celular:"
        '
        'TextBox2
        '
        Me.TextBox2.Size = New System.Drawing.Size(136, 22)
        '
        'Label1
        '
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.Text = "Telefono:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(367, 10)
        '
        'FormCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(905, 523)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FormCliente"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
