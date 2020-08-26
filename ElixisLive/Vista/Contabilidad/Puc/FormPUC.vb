Public Class FormPUC

    Dim objPucBLL As New PucBLL
    Private Sub btnuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.habilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        txtDescripcion.Focus()
        btCuentas.Enabled = False
        btRetencionIVA.Enabled = False
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btBuscar.Enabled = True
            btNuevo.Enabled = True
        End If
    End Sub

    Private Sub bteditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.NO Then
            Exit Sub
        Else
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub

    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btBusqueda.Click
        Generales.buscarElemento(Consultas.BUSQUEDA_PUC,
                               Nothing,
                               AddressOf cargarPUC,
                               TitulosForm.BUSQUEDA_PUC,
                               False, True)

    End Sub

    Public Sub cargarPUC(ByVal pCodigo As String)
        Dim drPUC As DataRow
        Dim params As New List(Of String)
        params.Add(pCodigo)
        drPUC = Generales.cargarItem(Consultas.PUC_CARGAR, params)
        If drPUC IsNot Nothing Then
            txtCodigo.Text = pCodigo
            numAno.Text = drPUC.Item(0)
            txtDescripcion.Text = drPUC.Item(1)
            chkActivo.Checked = drPUC.Item(2)
        End If
        Generales.deshabilitarControles(Me)
        Generales.habilitarBotones(ToolStrip1)
        btRegistrar.Enabled = False
        btCancelar.Enabled = False
        btCuentas.Enabled = True
        btRetencionIVA.Enabled = True
    End Sub


    Public Sub cargarPUC(ByVal codigoPUC As String,
                         ByVal anoPUC As String,
                         ByVal descripcionPUC As String,
                         ByVal activoPUC As Boolean)

        txtCodigo.Text = codigoPUC
        txtDescripcion.Text = descripcionPUC
        numAno.Text = anoPUC
        chkActivo.Checked = activoPUC
        Generales.deshabilitarControles(Me)
        Generales.habilitarBotones(ToolStrip1)
        btRegistrar.Enabled = False
        btCancelar.Enabled = False
        btCuentas.Enabled = True
        btRetencionIVA.Enabled = True
    End Sub

    Private Sub Form_PUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
        btBusqueda.Enabled = True
        btNuevo.Enabled = True
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarFormulario() Then
            Dim objPUC = crearPUC()
            guardarPUC(objPUC)
        End If

    End Sub

    Public Function crearPUC() As Puc
        Dim objPUC As New Puc

        objPUC.codigo = txtCodigo.Text
        objPUC.ano = numAno.Value
        objPUC.descripcion = txtDescripcion.Text
        objPUC.activo = chkActivo.Checked

        Return objPUC

    End Function

    Public Sub guardarPUC(objPUC As Puc)
        Dim codigoPUC As String = Nothing

        Try
            objPucBLL.guardarPUC(objPUC, SesionActual.idUsuario)

            'Si es un PUC nuevo
            If codigoPUC <> Nothing Then
                txtCodigo.Text = codigoPUC
            End If

            Generales.deshabilitarControles(Me)
            Generales.habilitarBotones(ToolStrip1)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
            btCuentas.Enabled = True
            btRetencionIVA.Enabled = True
            txtCodigo.Text = objPUC.codigo
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try

    End Sub

    Public Function validarFormulario()
        If String.IsNullOrEmpty(txtDescripcion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("Favor digitar la descripción")
            txtDescripcion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btCuentas_Click(sender As Object, e As EventArgs) Handles btCuentas.Click
        Dim formCuentaPUC As New FormCuentasPuc
        Generales.cargarForm(formCuentaPUC)
        formCuentaPUC.cargarInfoPUC(txtCodigo.Text, numAno.Value, txtDescripcion.Text)
    End Sub

    Private Sub Form_antici_decucci_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btanular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        Try
            If chkActivo.Checked Then
                EstiloMensajes.mostrarMensajeAdvertencia("No se puede anular el PUC activo. Escoja otro como activo antes de continuar")
                Return
            End If
            If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
                Dim params As New List(Of String)
                params.Add(txtCodigo.Text)
                params.Add(SesionActual.idUsuario)
                Generales.ejecutarSQL(Consultas.ANULAR_PUC, params)
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                Generales.limpiarControles(Me)
                btCuentas.Enabled = False
                btRetencionIVA.Enabled = False
                EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
            End If
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try

    End Sub

    Private Sub btRetencionIVA_Click(sender As Object, e As EventArgs) Handles btRetencionIVA.Click
        FormRetencionIva.MdiParent = FormPrincipal
        Generales.cargarForm(FormRetencionIva)

        FormRetencionIva.cargarInfoPUC(txtCodigo.Text,
                                       txtDescripcion.Text)
    End Sub
    Private Sub FormPUC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Generales.deshabilitarControles(Me)
        Generales.asignarPermiso(Me)
    End Sub
End Class