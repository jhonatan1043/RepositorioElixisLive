Public Class FormCliente
    Public Sub llenarComboDescuento()
        Dim dtDescuento As New DataTable
        dtDescuento.Columns.Add("Codigo")
        dtDescuento.Columns.Add("Nombre")
        dtDescuento.Rows.Add()
        dtDescuento.Rows(0).Item("Codigo") = 0
        dtDescuento.Rows(0).Item("Nombre") = "-- Seleccione --"
        dtDescuento.Rows.Add()
        dtDescuento.Rows(1).Item("Codigo") = 5
        dtDescuento.Rows(1).Item("Nombre") = "5%"
        dtDescuento.Rows.Add()
        dtDescuento.Rows(2).Item("Codigo") = 10
        dtDescuento.Rows(2).Item("Nombre") = "10%"
        dtDescuento.Rows.Add()
        dtDescuento.Rows(3).Item("Codigo") = 15
        dtDescuento.Rows(3).Item("Nombre") = "15%"
        dtDescuento.Rows.Add()
        dtDescuento.Rows(4).Item("Codigo") = 20
        dtDescuento.Rows(4).Item("Nombre") = "20%"
        dtDescuento.Rows.Add()
        dtDescuento.Rows(5).Item("Codigo") = 25
        dtDescuento.Rows(5).Item("Nombre") = "25%"
        dtDescuento.Rows.Add()
        dtDescuento.Rows(6).Item("Codigo") = 30
        dtDescuento.Rows(6).Item("Nombre") = "30%"
        dtDescuento.Rows.Add()
        dtDescuento.Rows(7).Item("Codigo") = 40
        dtDescuento.Rows(7).Item("Nombre") = "40%"
        dtDescuento.Rows.Add()
        dtDescuento.Rows(8).Item("Codigo") = 50
        dtDescuento.Rows(8).Item("Nombre") = "50%"
        cbDescuento.Items.Clear()
        cbDescuento.DataSource = Nothing
        cbDescuento.DataSource = dtDescuento
        cbDescuento.DisplayMember = "Nombre"
        cbDescuento.ValueMember = "Codigo"
    End Sub

    Private Sub FormCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboDescuento()
    End Sub
End Class