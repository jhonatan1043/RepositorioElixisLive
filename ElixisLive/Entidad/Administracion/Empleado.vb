﻿Public Class Empleado
    Inherits persona
    Property usuario As String
    Property clave As String
    Property codigoPerfil As Integer
    Property activo As Boolean
    Property imagenEmpleado As Byte()
    Public Sub New()
        dtRegistro = New DataTable
        sqlGuardar = "[SP_ADMIN_EMPLEADO_CREAR]"
        sqlConsulta = "[SP_ADMIN_EMPLEADO_CONSULTAR]"
        sqlCargar = "[SP_ADMIN_EMPLEADO_CARGAR]"
        sqlCargarDetalle = "[SP_ADMIN_EMPLEADO_CARGAR_D]"
    End Sub
End Class
