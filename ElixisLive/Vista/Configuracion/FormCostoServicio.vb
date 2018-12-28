Public Class FormCostoServicio
    Dim objCostoServicio As CostoServicio
    Private Sub FormCostoServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCostoServicio = New CostoServicio
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        btNuevo.Enabled = True
        btBuscar.Enabled = True
        Generales.tabularConEnter(Me)
    End Sub
    Private Sub btBuscarServicio_Click(sender As Object, e As EventArgs) Handles btBuscarServicio.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        params.Add(String.Empty)
        Generales.buscarElemento(Sentencias.SERVICIO_CONSULTAR,
                                  params,
                                  AddressOf cargarServicio,
                                  Titulo.BUSQUEDA_SERVICIO,
                                  True,
                                  True)
    End Sub
    Private Sub cargarServicio(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dRows As DataRow
        params.Add(pCodigo)
        dRows = Generales.cargarItem("[SP_SERVICIO_CARGAR]", params)
        txtcodigo.Text = pCodigo
        txtnombre.Text = dRows("Descripcion")
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Gbdatos)
        Generales.limpiarControles(Me)
        objCostoServicio.codigoServicio = Nothing
        btBuscarServicio.Enabled = True
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click

    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click

    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Gbdatos)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            Generales.limpiarControles(Me)
            objCostoServicio.codigoServicio = Nothing
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub

    Private Sub validarGrilla()
        With dgvRegistro

        End With
    End Sub
End Class