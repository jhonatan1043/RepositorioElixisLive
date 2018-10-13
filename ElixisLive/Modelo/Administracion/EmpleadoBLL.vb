Public Class EmpleadoBLL
    Public Shared Function guardar(objEmpleado As Empleado) As Empleado
        EmpleadoDAL.guardar(objEmpleado)
        Return objEmpleado
    End Function
End Class
