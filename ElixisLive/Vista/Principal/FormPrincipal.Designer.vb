<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.arbolMenu = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SuspendLayout()
        '
        'arbolMenu
        '
        Me.arbolMenu.BackColor = System.Drawing.Color.White
        Me.arbolMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.arbolMenu.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.arbolMenu.ForeColor = System.Drawing.Color.RoyalBlue
        Me.arbolMenu.ImageKey = "Orb_Icons_17x17.png"
        Me.arbolMenu.ImageList = Me.ImageList1
        Me.arbolMenu.LineColor = System.Drawing.Color.RoyalBlue
        Me.arbolMenu.Location = New System.Drawing.Point(0, 0)
        Me.arbolMenu.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.arbolMenu.Name = "arbolMenu"
        Me.arbolMenu.SelectedImageKey = "generictokengreen (2).png"
        Me.arbolMenu.Size = New System.Drawing.Size(240, 567)
        Me.arbolMenu.StateImageList = Me.ImageList1
        Me.arbolMenu.TabIndex = 1
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Orb_Icons_17x17.png")
        Me.ImageList1.Images.SetKeyName(1, "generictokengreen (2).png")
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip1.Location = New System.Drawing.Point(240, 545)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 17, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(897, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ElixisLive.My.Resources.Resources.logos
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1137, 567)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.arbolMenu)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Monotype Corsiva", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormPrincipal"
        Me.ShowIcon = False
        Me.Text = "ElixisLive"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents arbolMenu As TreeView
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ImageList1 As ImageList
End Class
