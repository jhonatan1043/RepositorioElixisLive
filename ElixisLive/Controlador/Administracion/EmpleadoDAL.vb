﻿Imports System.Data.SqlClient
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
                    comando.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.NVarChar)).Value = objEmpleado.usuario
                    comando.Parameters.Add(New SqlParameter("@Contrasena", SqlDbType.VarChar)).Value = objEmpleado.clave
                    comando.Parameters.Add(New SqlParameter("@Codigo_Perfil", SqlDbType.Int)).Value = objEmpleado.codigoPerfil
                    comando.Parameters.Add(New SqlParameter("@Estado", SqlDbType.Bit)).Value = objEmpleado.activo
                    comando.Parameters.Add(New SqlParameter("@Foto", SqlDbType.VarBinary)).Value = objEmpleado.imagenEmpleado
                    comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objEmpleado.dtParametro
                    comando.Parameters.Add(New SqlParameter("@CODIGO_BANCO", SqlDbType.Int)).Value = objEmpleado.codigoBanco
                    comando.Parameters.Add(New SqlParameter("@CODIGO_CUENTA", SqlDbType.Int)).Value = objEmpleado.codigoCuenta
                    comando.Parameters.Add(New SqlParameter("@CUENTA", SqlDbType.NVarChar)).Value = objEmpleado.Cuenta
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
End Class