Imports System.Data.SqlClient
Imports CnxElixisLiveBD
Public Class Busqueda
    Shared objConexion As New ConexionBD
    Public Shared Function llenar(cadena As String, busqueda As String) As DataTable
        Dim dt As New DataTable
        Dim enlce_dta As BindingSource = New BindingSource
        Dim aux As String
        Try
            dt.Clear()
            objConexion.conectar()

            Using rsltdo = dt.CreateDataReader()
                aux = Replace(cadena, "''", "'" & busqueda & "'")
                aux = Replace(aux, Constantes.SIGNO_PESO, "")
                Using adpter = New SqlDataAdapter(aux, objConexion.cnxbd)
                    adpter.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return dt
        objConexion.desConectar()
    End Function
End Class
