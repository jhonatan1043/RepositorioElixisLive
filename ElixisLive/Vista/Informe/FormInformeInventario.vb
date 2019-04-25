Imports System.IO
Imports System.Reflection
Public Class FormInformeInventario
    Dim codigoListaPrecio As Integer
    Dim tbla As DataTable
    Private Sub FormInformeInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        valoresIniciales()
    End Sub
    Private Sub valoresIniciales()
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(Constantes.INVENTARIO)
        tbla = Generales.cargarComboTabla(Sentencias.INFORME_CONSULTAR, params, "Nombre", "Codigo", cbInforme)

        dRows = Generales.cargarItem("[SP_LISTA_PRODUCTO_ACTUAL_CONSULTAR]", Nothing)

        If Not IsNothing(dRows) Then
            codigoListaPrecio = dRows("Codigo")
            lbListaMedicamento.Text = dRows("Nombre")
        End If

        btGenerar.Enabled = False
    End Sub
    Private Sub cbInforme_TextChanged(sender As Object, e As EventArgs) Handles cbInforme.TextChanged
        If cbInforme.SelectedIndex > 0 Then
            btGenerar.Enabled = True
        Else
            btGenerar.Enabled = False
        End If
    End Sub
    Private Sub btGenerar_Click(sender As Object, e As EventArgs) Handles btGenerar.Click
        Dim dRows() As DataRow
        Dim formula As String
        Dim reporte As String
        Try
            dRows = tbla.Select("[codigo] = " & cbInforme.SelectedValue)
            formula = dRows.First().Item("Formula").ToString
            reporte = Constantes.NOMBRE_SOFTWARE & dRows.First().Item("Reporte").ToString
            Dim vTipo As Type = Assembly.GetExecutingAssembly.GetType(reporte)
            If vTipo IsNot Nothing Then
                Dim vReporte = Activator.CreateInstance(vTipo)
                crView.ReportSource = vReporte
                crView.SelectionFormula = Replace(Replace(formula, "'$F1'", dtFechaInicio.Value.Date), "'$F2'", dtFechaFin.Value.Date)
            End If
            crView.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class