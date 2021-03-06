﻿Public Class persona
    Inherits generalConsulta
    Property codigo As String
    Property identificacion As String
    Property nombre As String
    Property telefono As String
    Property celular As String
    Property codigoTipoIdentificacion As Integer
    Property direccion As String
    Property correo As String
    Property codigoDepartamento As String
    Property codigoCiudad As String
    Property encabezado As String
    Property pie As String
    Property dtParametro As DataTable
    Property dtRegistro As DataTable
    Property ruta As String
    Property foto As String
    Property bdraControl As Boolean
    Property imagen As PictureBox
    Property usuario As String
    Property codigoPerfil As Integer
    Property asignar As Boolean
    Property dtSucursal As DataTable
    Property chEmpleado As Boolean
    Property chCliente As Boolean
    Property chProveedor As Boolean
    Property codigoFormulario As String

    Public Sub New()
        dtSucursal = New DataTable
        dtRegistro = New DataTable
        sqlGuardar = "SP_ADMIN_PERSONA_CREAR"
        sqlConsulta = "[SP_ADMIN_PERSONA_CONSULTAR]"
        sqlCargar = "SP_ADMIN_PERSONA_CARGAR"
        sqlAnular = "SP_ADMIN_PERSONA_ANULAR "
    End Sub
End Class
