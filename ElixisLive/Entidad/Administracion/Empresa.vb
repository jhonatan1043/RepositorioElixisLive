Public Class Empresa
    Inherits generalConsulta
    Property codigoEmpresa As String
    Property nit As String
    Property nombre As String
    Property foto As Byte()
    Property dtParametro As DataTable
    Property dtRegistro As DataTable
    Property bdraControl As Boolean
    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = ""
        sqlConsulta = ""
        sqlCargar = ""
        sqlCargarDetalle = ""
    End Sub
End Class
