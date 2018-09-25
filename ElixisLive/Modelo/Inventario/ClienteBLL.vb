Public Class ClienteBLL
    Public Shared Function guardar(objCliente As Cliente) As Cliente
        ClienteDAL.guardar(objCliente)
        Return objCliente
    End Function
    'Public Shared Sub verificarTipoControl(ByRef dgv As DataGridView)
    '    Dim valorTipo As String
    '    valorTipo = dgv.Rows(dgv.CurrentCell.RowIndex).Cells("Datos").Tag

    '    Select Case valorTipo

    '        Case Constantes.TIPO_CONTROL.COMBO
    '            dgv.Rows(dgv.CurrentCell.RowIndex).Cells("ControlEspecial").Value = dgv.Rows(dgv.CurrentCell.RowIndex).Cells("Datos").Value
    '        Case Constantes.TIPO_CONTROL.SELECTOR

    '        Case Constantes.TIPO_CONTROL.TIEMPO

    '    End Select

    'End Sub
End Class
