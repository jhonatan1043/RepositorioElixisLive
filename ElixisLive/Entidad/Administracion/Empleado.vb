Public Class Empleado
    Inherits persona
    Property clave As String
    Property codigoFormaPago As Integer
    Property codigoBanco As String
    Property codigoCuenta As String
    Property codigoTipoPagare As Integer
    Property Comision As Integer
    Property salario As Decimal
    Property Cuenta As String
    Property activo As Boolean
    Property cargo As Integer
    Property deparTrabajo As Integer
    Property imagenEmpleado As Byte()
    Property fechaIngreso As DateTime
    Property banderaImagen As Boolean
    Public Sub New()
        dtSucursal = New DataTable
        dtRegistro = New DataTable
        sqlGuardar = "[SP_ADMIN_EMPLEADO_CREAR]"
        sqlConsulta = "[SP_ADMIN_EMPLEADO_CONSULTAR]"
        sqlCargar = "[SP_ADMIN_EMPLEADO_CARGAR]"
        sqlCargarDetalle = "[SP_ADMIN_EMPLEADO_CARGAR_D]"
        sqlAnular = ""
    End Sub
End Class
