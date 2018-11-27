Imports System.Data.SqlClient
Public Class EmpleadoDAL
    Public Shared Function guardar(objEmpleado As Empleado) As Empleado
        Dim objConexio As New CnxElixisLiveBD.ConexionBD

        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objEmpleado.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objEmpleado.codigo
                    comando.Parameters.Add(New SqlParameter("@FORMA_PAGO", SqlDbType.Int)).Value = objEmpleado.codigoFormaPago
                    comando.Parameters.Add(New SqlParameter("@CODIGO_BANCO", SqlDbType.Int)).Value = objEmpleado.codigoBanco
                    comando.Parameters.Add(New SqlParameter("@CODIGO_CUENTA", SqlDbType.Int)).Value = objEmpleado.codigoCuenta
                    comando.Parameters.Add(New SqlParameter("@CUENTA", SqlDbType.NVarChar)).Value = objEmpleado.Cuenta
                    comando.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@Codigo_Cargo", SqlDbType.Int)).Value = objEmpleado.cargo
                    comando.Parameters.Add(New SqlParameter("@Codigo_Departamento_t", SqlDbType.Int)).Value = objEmpleado.deparTrabajo
                    comando.Parameters.Add(New SqlParameter("@Foto", SqlDbType.VarBinary)).Value = objEmpleado.imagenEmpleado
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objEmpleado.dtParametro
                    comando.Parameters.Add(New SqlParameter("@TablaSucursal", SqlDbType.Structured)).Value = extrarColumna(objEmpleado)
                    comando.ExecuteNonQuery()
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objEmpleado
    End Function
    Private Shared Function extrarColumna(objEmpleado As Empleado) As DataTable
        Dim tabla As New DataTable
        tabla = objEmpleado.dtSucursal.Clone

        For Each fila As DataRow In objEmpleado.dtSucursal.Rows
            If fila("Editable") <> Constantes.SIN_VALOR_NUMERICO Then
                tabla.ImportRow(fila)
            End If
        Next

        tabla.Columns.Remove("Nombre")
        tabla.Columns.Remove("Editable")
        tabla.Columns.Remove("Realizado")

        Return tabla
    End Function
End Class
