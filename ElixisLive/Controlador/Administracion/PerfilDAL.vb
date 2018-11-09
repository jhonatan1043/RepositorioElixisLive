Imports System.Data.SqlClient
Public Class PerfilDAL
    'Public Shared Function guardarPerfil(objPerfil As Perfil) As Perfil
    '    Dim objConexio As New CnxElixisLiveBD.ConexionBD
    '    Try
    '        objConexio.conectar()
    '        Using comando = New SqlCommand()
    '            Using trnsccion = objConexio.cnxbd.BeginTransaction()
    '                comando.Connection = objConexio.cnxbd
    '                comando.Transaction = trnsccion
    '                comando.CommandType = CommandType.StoredProcedure
    '                comando.Parameters.Clear()
    '                comando.CommandText = objPerfil.sqlGuardar
    '                comando.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.NVarChar)).Value = objPerfil.codigoPerfil
    '                comando.Parameters.Add(New SqlParameter("@Nombre", SqlDbType.NVarChar)).Value = objPerfil.nombre
    '                comando.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.Structured)).Value = objPerfil.dtPerfil
    '                objPerfil.codigoPerfil = CType(comando.ExecuteScalar, String)
    '                trnsccion.Commit()
    '            End Using
    '        End Using
    '    Catch ex As Exception
    '        Throw ex
    '    Finally
    '        objConexio.desConectar()
    '    End Try
    '    Return objPerfil
    'End Function
    Public Shared Sub crearPerfil(pPerfil As Perfil)
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            Using consulta = New SqlCommand()
                consulta.Connection = objConexio.cnxbd
                consulta.CommandText = "EXEC SP_PERFIL_USUARIO_CREAR @Nombre='" & pPerfil.nombre & "',
                                            @Usuario_Creacion='" & SesionActual.idUsuario & "'"
                pPerfil.codigoPerfil = CType(consulta.ExecuteScalar, String)
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        objConexio.desConectar()
    End Sub

    Public Shared Sub actualizarPerfil(pPerfil As Perfil)
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            Using consulta = New SqlCommand()
                consulta.Connection = objConexio.cnxbd
                consulta.CommandText = "EXEC SP_PERFIL_USUARIO_ACTUALIZAR @Codigo_perfil='" & pPerfil.codigoPerfil & "',@Nombre='" & pPerfil.nombre & "',
                                           @Usuario_actualizacion='" & SesionActual.idUsuario & "'"
                consulta.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        objConexio.desConectar()
    End Sub
    Friend Shared Sub anularPerfil(perfil As Perfil)
        Dim objConexio As New CnxElixisLiveBD.ConexionBD
        Try
            Using consulta = New SqlCommand()
                consulta.Connection = objConexio.cnxbd
                consulta.CommandText = "EXEC SP_PERFIL_USUARIO_ANULAR @Usuario_actualizacion='" & SesionActual.idUsuario & "',@CODIGO_PERFIL='" & perfil.codigoPerfil & "'"
                consulta.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw ex
        End Try
        objConexio.desConectar()
    End Sub
End Class
