<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProducto
    Inherits ElixisLive.FormBase

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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Gbdatos.SuspendLayout()
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
        Me.Pimagen.Image = Global.ElixisLive.My.Resources.Resources.producto1
        Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Gbdatos
        '
        Me.Gbdatos.Controls.Add(Me.Label1)
        Me.Gbdatos.Controls.SetChildIndex(Me.Label5, 0)
        Me.Gbdatos.Controls.SetChildIndex(Me.Label3, 0)
        Me.Gbdatos.Controls.SetChildIndex(Me.txtcodigo, 0)
        Me.Gbdatos.Controls.SetChildIndex(Me.txtnombre, 0)
        Me.Gbdatos.Controls.SetChildIndex(Me.Label1, 0)
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(238, 17)
        Me.txtnombre.Size = New System.Drawing.Size(334, 21)
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(35, 18)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(159, 19)
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
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 15)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID:"
        '
        'FormProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(603, 370)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FormProducto"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Gbdatos.ResumeLayout(False)
        Me.Gbdatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
End Class
