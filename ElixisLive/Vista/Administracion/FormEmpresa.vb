Public Class FormEmpresa
    Dim objEmpresa As Empresa
    Private Sub cargarObjeto()
        objEmpresa.identificacion = txtId.Text
        objEmpresa.nombre = TxtDescripcion.Text
        objEmpresa.telefono = TextTelefono.Text
        objEmpresa.celular = TextCelular.Text
        objEmpresa.correo = TextEmail.Text
        objEmpresa.direccion = TextDireccion.Text
        objEmpresa.encabezado = txtEncabezado.Text
        objEmpresa.codigoCiudad = ComboMunicipio.SelectedValue
        objEmpresa.pie = txtPie.Text
        objEmpresa.dtParametro = dgvParametro.DataSource
    End Sub
    Private Function validarCampos() As Boolean
        If String.IsNullOrEmpty(txtId.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el nit de la Empresa!")
        ElseIf String.IsNullOrEmpty(TxtDescripcion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el nombre de la empresa!")
        ElseIf String.IsNullOrEmpty(TextCelular.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el Numero de celular de la empresa!")
        ElseIf String.IsNullOrEmpty(ComboMunicipio.SelectedIndex) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe seleccionar la ciudad de la empresa!")
        ElseIf String.IsNullOrEmpty(TextDireccion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar la dirección de la empresa!")
        Else
            Return True
        End If
        Return False
    End Function
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objEmpresa = New Empresa
        Try
            CheckForIllegalCrossThreadCalls = False
            params.Add(ElementoMenu.codigo)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            Generales.llenardgv("SP_CONSULTAR_PARAMETROS", dgvParametro, params)
            Generales.diseñoDGV(dgvParametro)
            Generales.diseñoGrillaParametros(dgvParametro)
            Generales.cargarCombo("[SP_CONSULTAR_CIUDAD]", Nothing, "descripcion", "Codigo_Municipio", ComboMunicipio)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        If txtId.Text = String.Empty Then
            btNuevo_Click(sender, e)
        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        objEmpresa.codigo = Nothing
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvParametro.EndEdit()
        If validarCampos() = True Then
            Try
                cargarObjeto()
                EmpresaBLL.guardar(objEmpresa)
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btNuevo.Enabled = True
                btEditar.Enabled = True
                btBuscar.Enabled = True
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.habilitarControles(Me)
            Generales.deshabilitarBotones(ToolStrip1)
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objEmpresa.sqlAnular) = True Then
                    Generales.limpiarControles(Me)
                    Generales.deshabilitarBotones(ToolStrip1)
                    btNuevo.Enabled = True
                    btBuscar.Enabled = True
                    EstiloMensajes.mostrarMensajeAnulado(MensajeSistema.REGISTRO_ANULADO)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Generales.buscarElemento(objEmpresa.sqlConsulta,
                                   params,
                                   AddressOf cargarInfomacion,
                                   "Busqueda de Empresa",
                                   True, True)
    End Sub
    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged
        Dim dV As New DigitoVerificacion
        Dim numero As Integer
        numero = dV.calculaNit(txtId.Text)
        TextDV.Text = CType(numero, String)
        If txtId.Text = Nothing Then
            TextDV.Text = Nothing
        End If
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objEmpresa.codigo = pcodigo
        params.Add(pcodigo)
        dfila = Generales.cargarItem(objEmpresa.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                txtId.Text = dfila.Item("Nit")
                TxtDescripcion.Text = dfila.Item("Nombre")
                TextTelefono.Text = If(IsDBNull(dfila("Telefono")), Nothing, dfila("Telefono"))
                TextCelular.Text = dfila("Celular")
                TextDireccion.Text = dfila("Direccion")
                TextEmail.Text = If(IsDBNull(dfila("Email")), Nothing, dfila("Email"))
                ComboMunicipio.SelectedValue = dfila("Ciudad")
                txtEncabezado.Text = If(IsDBNull(dfila("Encabezado")), Nothing, dfila("Encabezado"))
                txtPie.Text = If(IsDBNull(dfila("Pie_Factura")), Nothing, dfila("Pie_Factura"))
                params.Add(ElementoMenu.codigo)
                Generales.llenardgv(objEmpresa.sqlCargarDetalle, dgvParametro, params)
                Generales.diseñoDGV(dgvParametro)
                Generales.diseñoGrillaParametros(dgvParametro)
            End If
            Generales.habilitarBotones(ToolStrip1)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
End Class