﻿Imports System.Data.SqlClient
Public Class SucursalDAL
    Public Shared Function guardar(objSucursal As Sucursal) As Sucursal
        Dim objConexio As New ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objSucursal.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objSucursal.codigo
                    comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objSucursal.nombre
                    comando.Parameters.Add(New SqlParameter("@telefono", SqlDbType.NVarChar)).Value = objSucursal.telefono
                    comando.Parameters.Add(New SqlParameter("@celular", SqlDbType.NVarChar)).Value = objSucursal.celular
                    comando.Parameters.Add(New SqlParameter("@direccion", SqlDbType.NVarChar)).Value = objSucursal.direccion
                    comando.Parameters.Add(New SqlParameter("@codigo_Departamento", SqlDbType.NVarChar)).Value = objSucursal.codigoDepartamento
                    comando.Parameters.Add(New SqlParameter("@codigo_ciudad", SqlDbType.NVarChar)).Value = objSucursal.codigoCiudad
                    comando.Parameters.Add(New SqlParameter("@Usuario_Creacion", SqlDbType.NVarChar)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@TABLABODEGA", SqlDbType.Structured)).Value = extrarColumna(objSucursal)
                    objSucursal.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            objConexio.desconectar()
        End Try
        Return objSucursal
    End Function
    Private Shared Function extrarColumna(objSucursal As Sucursal) As DataTable
        Dim tabla As New DataTable
        tabla = objSucursal.dtSucursal.Copy
        tabla.Columns.Remove("Nombre")
        tabla.Columns.Remove("Realizado")
        Return tabla
    End Function
End Class
