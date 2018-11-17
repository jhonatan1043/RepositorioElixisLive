Public Class EntradaInventarioBLL
    Public Shared Function guardarEntrada(objEntrada As EntradaInventario) As EntradaInventario
        EntradaInventarioDAL.guardarEntrada(objEntrada)
        Return objEntrada
    End Function
End Class
