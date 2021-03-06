﻿Public Class MyRenderer
    Inherits ToolStripProfessionalRenderer
    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)
        Dim rc As New Rectangle(Point.Empty, e.Item.Size)
        Dim c As Color = IIf(e.Item.Selected, Color.FromArgb(208, 220, 234), Color.FromArgb(226, 234, 243))
        Using brush As New SolidBrush(c)
            e.Graphics.FillRectangle(brush, rc)
        End Using
    End Sub
End Class
