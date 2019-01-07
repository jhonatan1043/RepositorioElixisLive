Public Class ClienteBLL
    Public Shared Function guardar(objCliente As Cliente) As Cliente
        ClienteDAL.guardar(objCliente)
        Return objCliente
    End Function

End Class
