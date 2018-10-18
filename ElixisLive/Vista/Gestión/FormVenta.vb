Public Class FormVenta
    Dim codigoCliente As Integer
    Dim respucola As Boolean = False
    Dim dtProductos As New DataTable
    Private Sub FormVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.diseñoDGV(dgvParametro)
        Generales.deshabilitarBotones(ToolStrip1)
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        enlanzarTabla()
    End Sub
    Private Sub enlanzarTabla()

        Dim colCodigo, colDescripcion, colCantidad, colValor, colTotal As New DataColumn


        colCodigo.ColumnName = "Codigo"
        colCodigo.DataType = Type.GetType("System.String")
        colCodigo.DefaultValue = String.Empty
        dtProductos.Columns.Add(colCodigo)

        colDescripcion.ColumnName = "Descripcion"
        colDescripcion.DataType = Type.GetType("System.String")
        colDescripcion.DefaultValue = String.Empty
        dtProductos.Columns.Add(colDescripcion)

        colCantidad.ColumnName = "Cantidad"
        colCantidad.DataType = Type.GetType("System.Int32")
        colCantidad.DefaultValue = 0
        dtProductos.Columns.Add(colCantidad)

        colValor.ColumnName = "Valor"
        colValor.DataType = Type.GetType("System.Decimal")
        colValor.DefaultValue = 0
        dtProductos.Columns.Add(colValor)

        colTotal.ColumnName = "Total"
        colTotal.DataType = Type.GetType("System.Decimal")
        colTotal.DefaultValue = 0
        dtProductos.Columns.Add(colTotal)

        With dgvParametro
            .Columns.Item("dgCodigo").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgCodigo").DataPropertyName = "Codigo"

            .Columns.Item("dgDescripcion").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgDescripcion").DataPropertyName = "Descripcion"

            .Columns.Item("dgCantidad").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgCantidad").DataPropertyName = "Cantidad"

            .Columns.Item("dgValor").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgValor").DataPropertyName = "Valor"

            .Columns.Item("dgTotal").SortMode = DataGridViewColumnSortMode.NotSortable
            .Columns.Item("dgTotal").DataPropertyName = "Total"

        End With
        dgvParametro.AutoGenerateColumns = False
        dgvParametro.DataSource = dtProductos
        dgvParametro.ReadOnly = True
    End Sub
    Private Sub TextIdentificacion_TextChanged(sender As Object, e As EventArgs) Handles TextIdentificacion.TextChanged
        Dim dV As New DigitoVerificacion
        Dim numero As Integer
        numero = dV.calculaNit(TextIdentificacion.Text)
        TextDV.Text = CType(numero, String)
        If TextIdentificacion.Text = Nothing Then
            TextDV.Text = Nothing
        End If
    End Sub
    Private Sub texthistoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextIdentificacion.KeyPress
        ValidacionDigitacion.validarValoresNumericos(e)
        If Asc(e.KeyChar) = 13 Then
            cargarDatosCliente(TextIdentificacion.Text)
            If respucola = True Then
                dgvParametro.Focus()
            Else
                TextNombre.Focus()
            End If
        End If
    End Sub
    Private Sub cargarDatosCliente(identificacion As String)
        Dim params As New List(Of String)
        Dim dFila As DataRow
        params.Add(identificacion)
        dFila = Generales.cargarItem(Sentencias.CLIENTE_FACTURA_CARGAR, params)
        Try
            If Not IsNothing(dFila) Then
                codigoCliente = dFila.Item("Codigo").ToString
                TextNombre.Text = dFila.Item("Nombre").ToString
                TextTelefono.Text = dFila.Item("Telefono").ToString
                respucola = True
            Else
                TextNombre.Clear()
                TextTelefono.Clear()
                respucola = False
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        dtProductos.Rows.Add()
    End Sub
End Class