﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGasto
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
        Me.Panel1.SuspendLayout()
        'CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Gbdatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'LTitulo
        '
        Me.LTitulo.Size = New System.Drawing.Size(571, 41)
        Me.LTitulo.Text = "Gastos"
        '
        'Pimagen
        '
        '  Me.Pimagen.BackColor = System.Drawing.Color.Transparent
        ''    Me.Pimagen.Image = Global.Quality.My.Resources.Resources.Cash_icon
        '  Me.Pimagen.Location = New System.Drawing.Point(13, -4)
        '  Me.Pimagen.Size = New System.Drawing.Size(55, 45)
        '  Me.Pimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'FormGasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(603, 369)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "FormGasto"
        Me.Panel1.ResumeLayout(False)
        'CType(Me.Pimagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Gbdatos.ResumeLayout(False)
        Me.Gbdatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
