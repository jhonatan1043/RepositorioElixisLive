<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEstadoCita
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
        Me.txtRealizado = New System.Windows.Forms.Button()
        Me.txtCancelado = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRealizado
        '
        Me.txtRealizado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRealizado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtRealizado.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRealizado.Location = New System.Drawing.Point(69, 3)
        Me.txtRealizado.Name = "txtRealizado"
        Me.txtRealizado.Size = New System.Drawing.Size(66, 59)
        Me.txtRealizado.TabIndex = 10079
        Me.txtRealizado.Text = "Confirmar Cita"
        Me.txtRealizado.UseVisualStyleBackColor = False
        '
        'txtCancelado
        '
        Me.txtCancelado.BackColor = System.Drawing.Color.AliceBlue
        Me.txtCancelado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtCancelado.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelado.Location = New System.Drawing.Point(3, 3)
        Me.txtCancelado.Name = "txtCancelado"
        Me.txtCancelado.Size = New System.Drawing.Size(66, 59)
        Me.txtCancelado.TabIndex = 10078
        Me.txtCancelado.Text = "Cancelar Cita"
        Me.txtCancelado.UseVisualStyleBackColor = False
        '
        'FormEstadoCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(138, 64)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCancelado)
        Me.Controls.Add(Me.txtRealizado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormEstadoCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtRealizado As Button
    Friend WithEvents txtCancelado As Button
End Class
