Public Class FormRetencionIva
    Private codigoPUC As String
    Private descripcionPUC As String

    Private Sub Form_RetencionIVA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
        btBuscar.Enabled = True
        btNuevo.Enabled = True
    End Sub
    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Public Sub cargarInfoPUC(ByVal pCodigoPUC As String, ByVal pDescripcionPUC As String)

        codigoPUC = pCodigoPUC
        descripcionPUC = pDescripcionPUC

        txtCodigoPUC.Text = codigoPUC
        txtDescripcionPUC.Text = descripcionPUC

    End Sub

    Private Sub btBusquedaCuenta_Click(sender As Object, e As EventArgs) Handles btBusquedaCuenta.Click

        Dim params As New List(Of String)
        params.Add(txtCodigoPUC.Text)
        params.Add(Nothing)

        Generales.buscarElemento(Consultas.BUSQUEDA_CUENTAS_PUC_RETENCION,
                               params,
                               AddressOf cargarCuentaPUC,
                               TitulosForm.BUSQUEDA_CUENTAS_PUC_RETENCION,
                               False, True)

    End Sub

    Public Sub cargarCuentaPUC(ByVal pCodigoCuenta As String)
        Dim drCuentaPUC As DataRow
        Dim params As New List(Of String)

        params.Add(codigoPUC)
        params.Add(pCodigoCuenta)

        drCuentaPUC = Generales.cargarItem(Consultas.CUENTAS_DETALLE_CARGAR,
                                        params)

        Dim objCuentaPUC As New CuentaPUC(drCuentaPUC)
        Generales.limpiarControles(Me)

        cargarInfoPUC(codigoPUC, descripcionPUC)
        txtCodigoCuenta.Text = objCuentaPUC.getCodigo
        txtNombreCuenta.Text = objCuentaPUC.getDescripcion
    End Sub

    Public Sub cargarRetencionIVA(ByVal pCodigoCuenta As String)
        cargarCuentaPUC(pCodigoCuenta)
        Dim params As New List(Of String)
        Dim drRetencionIva As DataRow

        params.Add(codigoPUC)
        params.Add(pCodigoCuenta)

        drRetencionIva = Generales.cargarItem(Consultas.RETENCION_IVA_CARGAR, params)
        Dim objRetencionIVA As New RetencionIVA(drRetencionIva)

        txtBase.Text = objRetencionIVA.base
        txtTasa.Text = objRetencionIVA.tasa
        txtObservacion.Text = objRetencionIVA.observacion
        Generales.deshabilitarControles(Me)
    End Sub

    Private Sub txtBase_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBase.KeyPress
        ValidacionDigitacion.validarSoloNumerosPositivo(e)
    End Sub

    Private Sub txtTasa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTasa.KeyPress
        ValidacionDigitacion.validarSoloNumerosPositivo(e)
    End Sub

    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click

        Generales.habilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        btRegistrar.Enabled = True
        btCancelar.Enabled = True
        cargarInfoPUC(codigoPUC, descripcionPUC)
    End Sub

    Private Sub btanular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        Try
            If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
                Dim params As New List(Of String)
                params.Add(txtCodigoPuc.Text)
                params.Add(txtCodigoCuenta.Text)
                params.Add(SesionActual.idUsuario)
                Generales.ejecutarSQL(Consultas.ANULAR_RETENCION_IVA, params)
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                Generales.limpiarControles(Me)
                btBuscar.Enabled = True
                btNuevo.Enabled = True
                txtCodigoPuc.Text = codigoPUC
                txtDescripcionPUC.Text = descripcionPUC

            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try


    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btBuscar.Enabled = True
            btNuevo.Enabled = True
            cargarInfoPUC(codigoPUC, descripcionPUC)
        End If
    End Sub

    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(txtCodigoPuc.Text)
        params.Add(Nothing)

        Generales.buscarElemento(Consultas.BUSQUEDA_RETENCION_IVA,
                               params,
                               AddressOf cargarRetencionIVA,
                               TitulosForm.BUSQUEDA_RETENCION_IVA,
                               False, True)


    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.NO Then
            Exit Sub
        Else
            Generales.deshabilitarBotones(ToolStrip1)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
        btBusquedaCuenta.Enabled = False
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarFormulario() Then
            guardarRetencionIVA()
        End If
    End Sub

    Private Sub guardarRetencionIVA()
        Try
            IVARetencionBLL.guardarRetencionIVA(crearRetencionIVA, SesionActual.idUsuario)
            Generales.habilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try

    End Sub

    Public Function crearRetencionIVA() As RetencionIVA
        Dim objRetencionIVA As New RetencionIVA

        objRetencionIVA.codigoPUC = txtCodigoPUC.Text
        objRetencionIVA.codigoCuenta = txtCodigoCuenta.Text
        objRetencionIVA.base = txtBase.Text
        objRetencionIVA.tasa = txtTasa.Text
        objRetencionIVA.observacion = txtObservacion.Text

        Return objRetencionIVA
    End Function

    Private Function validarFormulario() As Boolean

        If txtCodigoCuenta.Text = String.Empty Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor escoger la cuenta")
        ElseIf txtBase.Text = String.Empty Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor ingresar la base")
        ElseIf txtTasa.Text = String.Empty Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor ingresar la tasa")
        Else
            Return True
        End If

        Return False
    End Function
End Class