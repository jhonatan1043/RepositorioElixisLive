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
        Me.Pimagen.Image = Global.ElixisLive.My.Resources.Resources.Apps_preferences_contact_list_icon__1_1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(137, 14)
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.lbID.Size = New System.Drawing.Size(34, 19)
        Me.lbID.Text = "Nit:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Size = New System.Drawing.Size(92, 22)
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
