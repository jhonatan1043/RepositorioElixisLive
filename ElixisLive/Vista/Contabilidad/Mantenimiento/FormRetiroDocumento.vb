Public Class FormRetiroDocumento
    Public objDocumento As New RetiroDocumento
    Private Sub FormDocumentoContable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.habilitarControles(Me)
        Generales.asignarPermiso(Me)
        cargarDocumentos()
    End Sub

    Public Sub cargarDocumentos()
        If IsNothing(dgvDocumento.DataSource) Then

            With dgvDocumento

                .Columns("fecha").ReadOnly = True
                .Columns.Item("fecha").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("fecha").DataPropertyName = "Fecha comprobante"

                .Columns("comprobante").ReadOnly = True
                .Columns.Item("comprobante").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("comprobante").DataPropertyName = "Comprobante"

                .Columns("Detalle").ReadOnly = True
                .Columns.Item("Detalle").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("Detalle").DataPropertyName = "Detalle"

                .Columns("nit").ReadOnly = True
                .Columns.Item("nit").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("nit").DataPropertyName = "Nit tercero"

                .Columns("tercero").ReadOnly = True
                .Columns.Item("tercero").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("tercero").DataPropertyName = "Tercero"


                .Columns("debito").ReadOnly = True
                .Columns.Item("debito").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("debito").DataPropertyName = "Débito"

                .Columns("credito").ReadOnly = True
                .Columns.Item("credito").SortMode = DataGridViewColumnSortMode.NotSortable
                .Columns("credito").DataPropertyName = "Crédito"

            End With
        End If
        objDocumento.anulado = rAnulado.Checked = True
        objDocumento.fecha = CDate(inicio.Value).Date
        objDocumento.fecha2 = CDate(fin.Value).Date
        objDocumento.busqueda = TextBox2.Text
        objDocumento.cargarDatos()
        dgvDocumento.DataSource = objDocumento.dtDocumento
        dgvDocumento.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvDocumento.DefaultCellStyle.Font = New Font(Constantes.TIPO_LETRA_ELEMENTO, 9)
        nRegistro.Text = objDocumento.dtDocumento.Rows.Count
    End Sub

    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub inicio_ValueChanged(sender As Object, e As EventArgs) Handles inicio.ValueChanged
        cargarDocumentos()
        If rAnulado.Checked = True Then

            dgvDocumento.Columns(0).HeaderText = "Habilitar"
            For i = 0 To dgvDocumento.Rows.Count - 1
                dgvDocumento.Rows(i).Cells("Anulado").Value = My.Resources.verde
            Next
        Else
            dgvDocumento.Columns(0).HeaderText = "Anular"

            For i = 0 To dgvDocumento.Rows.Count - 1
                dgvDocumento.Rows(i).Cells("Anulado").Value = My.Resources.rojo
            Next
        End If
    End Sub

    Private Sub fin_ValueChanged(sender As Object, e As EventArgs) Handles fin.ValueChanged
        cargarDocumentos()
        If rAnulado.Checked = True Then

            dgvDocumento.Columns(0).HeaderText = "Habilitar"
            For i = 0 To dgvDocumento.Rows.Count - 1
                dgvDocumento.Rows(i).Cells("Anulado").Value = My.Resources.verde
            Next
        Else
            dgvDocumento.Columns(0).HeaderText = "Anular"

            For i = 0 To dgvDocumento.Rows.Count - 1
                dgvDocumento.Rows(i).Cells("Anulado").Value = My.Resources.rojo
            Next
        End If
    End Sub

    Private Sub rAnulado_CheckedChanged(sender As Object, e As EventArgs) Handles rAnulado.CheckedChanged
        cargarDocumentos()

        If rAnulado.Checked = True Then

            dgvDocumento.Columns(0).HeaderText = "Habilitar"
            For i = 0 To dgvDocumento.Rows.Count - 1
                dgvDocumento.Rows(i).Cells("Anulado").Value = My.Resources.verde
            Next
        Else
            dgvDocumento.Columns(0).HeaderText = "Anular"

            For i = 0 To dgvDocumento.Rows.Count - 1
                dgvDocumento.Rows(i).Cells("Anulado").Value = My.Resources.rojo
            Next
        End If

    End Sub


    Private Sub btcancelar_Click_1(sender As Object, e As EventArgs) Handles btcancelar.Click
        Panel2.Visible = False
        txtobservacion.Clear()
    End Sub

    Private Sub dgvDocumento_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumento.CellContentClick
        If e.ColumnIndex = 0 And rAnulado.Checked = False Then
            If dgvDocumento.Rows(dgvDocumento.CurrentCell.RowIndex).Cells("Anulado").Selected = True Then
                Dim mensaje As String
                mensaje = EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI
                If mensaje = True Then
                    Panel2.Visible = True
                End If
            End If
        ElseIf e.ColumnIndex = 0 And rAnulado.Checked = True Then
            If EstiloMensajes.mostrarMensajePregunta("Desea habilitar este registro") = Constantes.SI Then
                Dim lista As New List(Of String)
                lista.Add(dgvDocumento.Rows(dgvDocumento.CurrentCell.RowIndex).Cells("Comprobante").Value)
                Generales.ejecutarSQL(Consultas.RETIRO_DOCUMENTO_HABILITAR, lista)
                EstiloMensajes.mostrarMensajeExitoso("Registro habilitado")
                cargarDocumentos()
            End If
        End If
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        Try
            objDocumento.observacion = txtobservacion.Text
            objDocumento.comprobante = dgvDocumento.Rows(dgvDocumento.CurrentCell.RowIndex).Cells("Comprobante").Value
            objDocumento.usuario = SesionActual.idUsuario
            objDocumento.guardarRegistro()
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Panel2.Visible = False
            txtobservacion.Clear()
            btguardar.Enabled = True
            btcancelar.Enabled = True
            cargarDocumentos()
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        cargarDocumentos()
    End Sub

    Private Sub dgvDocumento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDocumento.CellDoubleClick
        Generales.abrirJustificacion(dgvDocumento, dgvDocumento.DataSource, Panel1, txtjustificacion, "Detalle", Not btguardar.Enabled)
        txtjustificacion.ReadOnly = True
    End Sub

    Private Sub dgvDocumento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgvDocumento.KeyPress
        Generales.abrirJustificacion(dgvDocumento, dgvDocumento.DataSource, Panel1, txtjustificacion, "Detalle", Not btguardar.Enabled, e.KeyChar)
        txtjustificacion.ReadOnly = True
    End Sub

    Private Sub txtjustificacion_Leave(sender As Object, e As EventArgs) Handles txtjustificacion.Leave
        Try
            If Panel1.Visible = True Then
                Panel1.Visible = False
                If dgvDocumento.Rows(dgvDocumento.CurrentRow.Index).Cells("Detalle").Selected = True Then
                    dgvDocumento.Rows(dgvDocumento.CurrentRow.Index).Cells("Detalle").Value = txtjustificacion.Text
                End If
                txtjustificacion.Clear()
                dgvDocumento.EndEdit()
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub

    Private Sub dgvDocumento_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvDocumento.CellFormatting
        If e.ColumnIndex = 6 Or e.ColumnIndex = 7 Then
            If IsDBNull(e.Value) Then
                e.Value = Format(Val(0), "c2")
            Else
                e.Value = Format(Val(e.Value), "c2")
            End If
        End If
    End Sub
End Class