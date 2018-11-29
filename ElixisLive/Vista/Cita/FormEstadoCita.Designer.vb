<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEstadoCita
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
        Me.txtRealizado = New System.Windows.Forms.Button()
        Me.txtCancelado = New System.Windows.Forms.Button()
        Me.txtPendiente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtRealizado
        '
        Me.txtRealizado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRealizado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtRealizado.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRealizado.Location = New System.Drawing.Point(104, 1)
        Me.txtRealizado.Name = "txtRealizado"
        Me.txtRealizado.Size = New System.Drawing.Size(102, 41)
        Me.txtRealizado.TabIndex = 10079
        Me.txtRealizado.Text = "Confirmar Cita"
        Me.txtRealizado.UseVisualStyleBackColor = False
        '
        'txtCancelado
        '
        Me.txtCancelado.BackColor = System.Drawing.Color.AliceBlue
        Me.txtCancelado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtCancelado.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelado.Location = New System.Drawing.Point(1, 1)
        Me.txtCancelado.Name = "txtCancelado"
        Me.txtCancelado.Size = New System.Drawing.Size(102, 41)
        Me.txtCancelado.TabIndex = 10078
        Me.txtCancelado.Text = "Cancelar Cita"
        Me.txtCancelado.UseVisualStyleBackColor = False
        '
        'txtPendiente
        '
        Me.txtPendiente.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtPendiente.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPendiente.Location = New System.Drawing.Point(1, 1)
        Me.txtPendiente.Name = "txtPendiente"
        Me.txtPendiente.Size = New System.Drawing.Size(205, 41)
        Me.txtPendiente.TabIndex = 10077
        Me.txtPendiente.Text = "Agendar Cita"
        Me.txtPendiente.UseVisualStyleBackColor = False
        '
        'FormEstadoCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(207, 43)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtRealizado)
        Me.Controls.Add(Me.txtCancelado)
        Me.Controls.Add(Me.txtPendiente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormEstadoCita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtRealizado As Button
    Friend WithEvents txtCancelado As Button
    Friend WithEvents txtPendiente As Button
End Class
