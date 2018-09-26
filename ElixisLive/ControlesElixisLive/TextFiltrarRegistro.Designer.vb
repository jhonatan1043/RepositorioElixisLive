<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextFiltrarRegistro
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.Text = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgRegistro = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgRegistro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.Text)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 270)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Text
        '
        Me.Text.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text.Location = New System.Drawing.Point(12, 15)
        Me.Text.Name = "Text"
        Me.Text.ReadOnly = True
        Me.Text.Size = New System.Drawing.Size(460, 21)
        Me.Text.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgRegistro)
        Me.Panel1.Location = New System.Drawing.Point(12, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(460, 228)
        Me.Panel1.TabIndex = 1
        '
        'dgRegistro
        '
        Me.dgRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRegistro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRegistro.Location = New System.Drawing.Point(0, 0)
        Me.dgRegistro.Name = "dgRegistro"
        Me.dgRegistro.Size = New System.Drawing.Size(460, 228)
        Me.dgRegistro.TabIndex = 0
        Me.dgRegistro.Visible = False
        '
        'TextFiltrarRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(498, 280)
        Me.MinimumSize = New System.Drawing.Size(498, 280)
        Me.Name = "TextFiltrarRegistro"
        Me.Size = New System.Drawing.Size(498, 280)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgRegistro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgRegistro As DataGridView
    Friend WithEvents Text As TextBox
End Class
