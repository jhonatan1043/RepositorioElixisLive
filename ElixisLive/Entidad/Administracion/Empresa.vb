﻿Public Class Empresa
    Inherits persona
    Property codigoEmpresa As String
    Property nit As String
    Property foto As Byte()

    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = ""
        sqlConsulta = ""
        sqlCargar = ""
        sqlCargarDetalle = ""
    End Sub
End Class
