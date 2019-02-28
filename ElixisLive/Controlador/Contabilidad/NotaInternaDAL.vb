﻿Imports System.Data.SqlClient

Public Class CualquierNotaDAL
    Dim conexion As New ConexionBD
    Public Sub crearCualquierNota(ByVal objCualquierNota As NotaInterna, pUSuario As Integer)
        Try
            conexion.conectar()
            Using dbCommand As New SqlCommand
                objCualquierNota.comprobante = FuncionesContables.verificarConsecutivo(objCualquierNota.codigoDocumento)
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_NOTA_INTERNA_CREAR"
                dbCommand.Parameters.Add(New SqlParameter("@Comprobante", SqlDbType.NVarChar)).Value = objCualquierNota.comprobante
                dbCommand.Parameters.Add(New SqlParameter("@id_tercero", SqlDbType.Int)).Value = objCualquierNota.idProveedor
                dbCommand.Parameters.Add(New SqlParameter("@Fecha_Recibo", SqlDbType.Date)).Value = objCualquierNota.fechaRecibo
                dbCommand.Parameters.Add(New SqlParameter("@detalleMov", SqlDbType.NVarChar)).Value = objCualquierNota.detalleMov
                dbCommand.Parameters.Add(New SqlParameter("@detalleCualquierNota", SqlDbType.Structured)).Value = objCualquierNota.dtCuentas
                dbCommand.Parameters.Add(New SqlParameter("@Usuario_Creacion", SqlDbType.Int)).Value = pUSuario
                dbCommand.ExecuteNonQuery()
                FuncionesContables.aumentarConsecutivo(objCualquierNota.codigoDocumento)
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            conexion.desconectar()
        End Try

    End Sub

    Public Sub actualizarCualquierNota(ByVal objCualquierNota As NotaInterna, pUSuario As Integer)
        Try
            conexion.desconectar()
            Using dbCommand As New SqlCommand
                dbCommand.Connection = conexion.cnxbd
                dbCommand.CommandType = CommandType.StoredProcedure
                dbCommand.CommandText = "SP_NOTA_INTERNA_ACTUALIZAR"
                dbCommand.Parameters.Add(New SqlParameter("@comprobante", SqlDbType.NVarChar)).Value = objCualquierNota.identificador
                dbCommand.Parameters.Add(New SqlParameter("@Fecha_Recibo", SqlDbType.Date)).Value = objCualquierNota.fechaRecibo
                dbCommand.Parameters.Add(New SqlParameter("@detalleMov", SqlDbType.NVarChar)).Value = objCualquierNota.detalleMov
                dbCommand.Parameters.Add(New SqlParameter("@Usuario_Actualizacion", SqlDbType.Int)).Value = pUSuario
                dbCommand.Parameters.Add(New SqlParameter("@detalleCualquierNota", SqlDbType.Structured)).Value = objCualquierNota.dtCuentas
                dbCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            conexion.desconectar()
        End Try
    End Sub
End Class
