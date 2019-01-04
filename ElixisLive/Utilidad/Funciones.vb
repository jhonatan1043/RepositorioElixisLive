Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Public Class Funciones
    Public Shared Function getParametros(lista As List(Of String)) As String

        If lista Is Nothing OrElse lista.Count = 0 Then 'OrElse lista.First Is Nothing Then
            Return String.Empty
        End If

        Dim comilla As String = Chr(39) 'comilla simple
        Dim separador As String = Chr(44) '(,)
        Dim listaParams As String

        listaParams = comilla & lista.First & comilla
        For i = 0 To lista.Count - 1

            If i > 0 Then
                listaParams += separador & comilla & lista(i) & comilla
            End If
        Next

        Return listaParams

    End Function
    Public Shared Function consultarInicioSesion(params As List(Of String)) As DataRow
        Dim dFila As DataRow = Nothing
        Try
            dFila = Generales.cargarItem(Sentencias.ADMIN_INICIO_SESION, params)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Return dFila
    End Function
    Public Shared Function consultarUsuario(usuario As String) As Boolean
        Dim dt As New DataTable
        Dim params As New List(Of String)
        Try
            params.Add(usuario)
            Generales.llenarTabla(Sentencias.PERSONA_VERIFICAR_USUARIO, params, dt)
            If dt.Rows.Count > 0 Then
                Return True
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Return False
    End Function
    Public Shared Function consultarEmpleado(codigo As String) As DataRow
        Dim dt As New DataTable
        Dim params As New List(Of String)
        Dim dRows As DataRow = Nothing
        Try
            params.Add(codigo)
            Generales.llenarTabla(Sentencias.PERSONA_EMPLEADO_CARGAR, params, dt)
            If dt.Rows.Count > 0 Then
                dRows = dt.Rows(0)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Return dRows
    End Function
    Public Shared Function consultarClienteIdent(Ident As String) As DataRow
        Dim dt As New DataTable
        Dim params As New List(Of String)
        Dim dRows As DataRow = Nothing
        Try
            params.Add(Ident)
            Generales.llenarTabla(Sentencias.PERSONA_POR_IDENTIFICACION_CARGAR, params, dt)
            If dt.Rows.Count > 0 Then
                dRows = dt.Rows(0)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Return dRows
    End Function
    Public Shared Function castFromDbItemVacio(ByVal DbItem As Object) As Object
        If IsDBNull(DbItem) Then
            Return ""
        Else
            Return DbItem
        End If
    End Function


    Public Shared Function castFromDbItem(ByVal DbItem As Object) As Object
        If IsDBNull(DbItem) Then
            Return Nothing
        Else
            Return DbItem
        End If
    End Function

    Public Shared Function castToSqlInt32(ByVal item As Integer?) As SqlInt32
        If item Is Nothing Then
            Return SqlTypes.SqlInt32.Null
        Else
            Return item
        End If
    End Function
End Class
