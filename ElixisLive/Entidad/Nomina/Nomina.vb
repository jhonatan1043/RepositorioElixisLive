Public Class Nomina
    Public Property codigoNomina As String
    Public Property fechaInicio As Date
    Public Property fechaFin As Date
    Public Property usuarioCreacion As Integer
    Public Property dtNomina As DataTable
    Sub New()
        dtNomina = New DataTable
        dtNomina.Columns.Add("codigoPersona", Type.GetType("System.Int32"))
        dtNomina.Columns.Add("valorPagado", Type.GetType("System.Double"))
    End Sub
End Class
