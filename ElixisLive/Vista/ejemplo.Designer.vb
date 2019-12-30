<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ejemplo
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
        Me.MenuElixisLive1 = New Quality.MenuElixisLive()
        Me.SuspendLayout()
        '
        'MenuElixisLive1
        '
        Me.MenuElixisLive1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuElixisLive1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuElixisLive1.Location = New System.Drawing.Point(0, 0)
        Me.MenuElixisLive1.Name = "MenuElixisLive1"
        Me.MenuElixisLive1.Size = New System.Drawing.Size(1093, 614)
        Me.MenuElixisLive1.TabIndex = 0
        '
        'ejemplo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1093, 614)
        Me.Controls.Add(Me.MenuElixisLive1)
        Me.Name = "ejemplo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ejemplo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuElixisLive1 As MenuElixisLive
End Class
