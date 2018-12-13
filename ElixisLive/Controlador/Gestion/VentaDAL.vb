﻿Imports System.Data.SqlClient
Public Class VentaDAL

    Public Shared Function guardarVenta(objVenta As Venta) As Venta
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            objConexio.conectar()
            Using comando = New SqlCommand()
                Using trnsccion = objConexio.cnxbd.BeginTransaction()
                    comando.Connection = objConexio.cnxbd
                    comando.Transaction = trnsccion
                    comando.CommandType = CommandType.StoredProcedure
                    comando.Parameters.Clear()
                    comando.CommandText = objVenta.sqlGuardar
                    comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objVenta.codigo
                    comando.Parameters.Add(New SqlParameter("@Codigo_persona_cliente", SqlDbType.Int)).Value = objVenta.codigoPersonaCliente
                    comando.Parameters.Add(New SqlParameter("@Usuario", SqlDbType.Int)).Value = SesionActual.idUsuario
                    comando.Parameters.Add(New SqlParameter("@tablaProducto", SqlDbType.Structured)).Value = objVenta.dtProductos
                    comando.Parameters.Add(New SqlParameter("@tablaServicio", SqlDbType.Structured)).Value = objVenta.dtServicio
                    objVenta.codigo = CType(comando.ExecuteScalar, String)
                    trnsccion.Commit()
                End Using
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            objConexio.desConectar()
        End Try
        Return objVenta
    End Function
End Class