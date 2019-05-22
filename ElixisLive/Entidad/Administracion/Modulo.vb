Public Class Modulo
    Public Property dtModulo As DataTable
    Sub New()
        dtModulo = New DataTable
        dtModulo.Columns.Add("codigo_modulo", Type.GetType("System.String"))
        dtModulo.Columns.Add("codigo_sucursal", Type.GetType("System.Int32"))
    End Sub
End Class
