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
    Public Shared Function consulInicioSesion(params As List(Of String)) As String
        Dim idUsuario As String = String.Empty
        Dim dFila As DataRow
        Try
            dFila = Generales.cargarItem("[SP_ADMIN_INICIO_SESION]", params)
            If Not IsDBNull(dFila.Item(0)) Then
                idUsuario = dFila.Item(0)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Return idUsuario
    End Function
End Class
