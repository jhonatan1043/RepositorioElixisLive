﻿Public Class EmpleadoBLL
    Public Shared Function guardar(objEmpleado As Empleado) As Empleado
        EmpleadoDAL.guardar(objEmpleado)
        Return objEmpleado
    End Function
    Public Shared Sub cargarComboFormaPago(cbCombo As ComboBox)
        Dim tabla As New DataTable
        Dim drFila As DataRow
        tabla.Columns.Add("Codigo")
        tabla.Columns.Add("Nombre")

        drFila = tabla.NewRow()
        drFila.Item(0) = "-1"
        drFila.Item(1) = " - - - Seleccione - - - "
        tabla.Rows.Add(drFila)

        drFila = tabla.NewRow()
        drFila.Item(0) = "1"
        drFila.Item(1) = "Efectivo"
        tabla.Rows.Add(drFila)

        drFila = tabla.NewRow()
        drFila.Item(0) = "2"
        drFila.Item(1) = "Consignación"
        tabla.Rows.Add(drFila)

        cargarCombo(tabla, cbCombo)
    End Sub

    Public Shared Sub cargarComboCuenta(cbCombo As ComboBox)
        Dim tabla As New DataTable
        Dim drFila As DataRow
        tabla.Columns.Add("Codigo")
        tabla.Columns.Add("Nombre")

        drFila = tabla.NewRow()
        drFila.Item(0) = "-1"
        drFila.Item(1) = " - - - Seleccione - - - "
        tabla.Rows.Add(drFila)

        drFila = tabla.NewRow()
        drFila.Item(0) = "1"
        drFila.Item(1) = "Ahorro"
        tabla.Rows.Add(drFila)

        drFila = tabla.NewRow()
        drFila.Item(0) = "2"
        drFila.Item(1) = "Corriente"
        tabla.Rows.Add(drFila)

        cargarCombo(tabla, cbCombo)
    End Sub
    Public Shared Sub cargarComboTipoSalario(cbCombo As ComboBox)
        Dim tabla As New DataTable
        Dim drFila As DataRow
        tabla.Columns.Add("Codigo")
        tabla.Columns.Add("Nombre")

        drFila = tabla.NewRow()
        drFila.Item(0) = "-1"
        drFila.Item(1) = " - - - Seleccione - - - "
        tabla.Rows.Add(drFila)

        drFila = tabla.NewRow()
        drFila.Item(0) = "1"
        drFila.Item(1) = "Salario Fijo"
        tabla.Rows.Add(drFila)

        drFila = tabla.NewRow()
        drFila.Item(0) = "2"
        drFila.Item(1) = "Por Comisión"
        tabla.Rows.Add(drFila)

        cargarCombo(tabla, cbCombo)
    End Sub

    Private Shared Sub cargarCombo(dtTabla As DataTable, cbCombo As ComboBox)
        Try
            cbCombo.DataSource = dtTabla
            cbCombo.DisplayMember = "Nombre"
            cbCombo.ValueMember = "Codigo"
            If cbCombo IsNot Nothing Then
                cbCombo.AutoCompleteMode = AutoCompleteMode.None
                cbCombo.AutoCompleteSource = AutoCompleteSource.None
                cbCombo.DropDownStyle = ComboBoxStyle.DropDownList
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
End Class
