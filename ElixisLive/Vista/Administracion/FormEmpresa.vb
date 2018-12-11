Public Class FormEmpresa
    Dim objEmpresa As Empresa
    Property inicioSesion As FormInicioSesion
    Private Sub cargarObjeto()
        objEmpresa.identificacion = txtId.Text
        objEmpresa.nombre = TxtDescripcion.Text
        objEmpresa.telefono = TextTelefono.Text
        objEmpresa.celular = TextCelular.Text
        objEmpresa.correo = TextEmail.Text
        objEmpresa.direccion = TextDireccion.Text
        objEmpresa.encabezado = txtEncabezado.Text
        objEmpresa.codigoDepartamento = cbDepartamento.SelectedValue
        objEmpresa.codigoCiudad = ComboMunicipio.SelectedValue
        objEmpresa.pie = txtPie.Text
        objEmpresa.dtParametro = dgvParametro.DataSource
    End Sub
    Private Function validarCampos() As Boolean
        If String.IsNullOrEmpty(txtId.Text) Or
           String.IsNullOrEmpty(TxtDescripcion.Text) Or
           String.IsNullOrEmpty(TextCelular.Text) Or
           String.IsNullOrEmpty(ComboMunicipio.SelectedIndex) Or
           String.IsNullOrEmpty(TextDireccion.Text) Then
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
            Generales.llenardgv(Sentencias.PARAMETROS_CONSULTAR, dgvParametro, params)
            Generales.diseñoDGV(dgvParametro)
            Generales.diseñoGrillaParametros(dgvParametro)
            cargarComboDepartamento()
            cargarComboCiudad()
            cargarInfomacion(Constantes.CODIGO_EMPRESA)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        dgvParametro.EndEdit()
        If validarCampos() = True Then
            Try
                cargarObjeto()
                EmpresaBLL.guardar(objEmpresa)
                cargarInfomacion(Constantes.CODIGO_EMPRESA)
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
                If Not IsNothing(inicioSesion) Then
                    Close()
                    inicioSesion.respuesta = False
                    inicioSesion.Show()
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        Else
            EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.VALIDAR_CAMPOS)
        End If
        mostrarIconoError()
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
            cargarInfomacion(Constantes.CODIGO_EMPRESA)
            quitarIconoError()
            If Not IsNothing(inicioSesion) Then
                Close()
            End If
        End If
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
                cbDepartamento.SelectedValue = dfila("Codigo_Departamento")
                ComboMunicipio.SelectedValue = dfila("Codigo_Ciudad")
                txtEncabezado.Text = If(IsDBNull(dfila("Encabezado")), Nothing, dfila("Encabezado"))
                txtPie.Text = If(IsDBNull(dfila("Pie_Factura")), Nothing, dfila("Pie_Factura"))
                params.Add(ElementoMenu.codigo)
                Generales.llenardgv(objEmpresa.sqlCargarDetalle, dgvParametro, params)
                Generales.diseñoDGV(dgvParametro)
                Generales.diseñoGrillaParametros(dgvParametro)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btCancelar.Enabled = False
                btRegistrar.Enabled = False
            Else
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.habilitarControles(Me)
                btRegistrar.Enabled = True
                btCancelar.Enabled = True
            End If

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarComboDepartamento()
        Generales.cargarCombo(Sentencias.DEPARTAMENTO_CONSULTAR, Nothing, "descripcion", "Codigo_Departamento", cbDepartamento)
    End Sub
    Private Sub cargarComboCiudad()
        Dim params As New List(Of String)
        params.Add(cbDepartamento.SelectedValue)
        Generales.cargarCombo(Sentencias.CIUDAD_CONSULTAR, params, "descripcion", "Codigo_Municipio", ComboMunicipio)
    End Sub
    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        If cbDepartamento.ValueMember <> String.Empty Then
            cargarComboCiudad()
        End If
    End Sub

    Private Sub txtPie_Click(sender As Object, e As EventArgs) Handles txtPie.LostFocus
        If txtPie.Text.Length = 0 Then
            ErrorIcono.SetError(txtPie, "Debe digitar información del pié de factura")
        Else
            ErrorIcono.SetError(txtPie, "")
        End If
    End Sub
    Private Sub cbDepartamento_Click(sender As Object, e As EventArgs) Handles cbDepartamento.LostFocus
        If cbDepartamento.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(cbDepartamento, "Debe escoger un departamento")
        Else
            ErrorIcono.SetError(cbDepartamento, "")
        End If
    End Sub
    Private Sub txtId_Click(sender As Object, e As EventArgs) Handles txtId.LostFocus
        If txtId.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(txtId, "Debe digitar un nit")
        Else
            ErrorIcono.SetError(txtId, "")
        End If
    End Sub
    Private Sub txtEncabezado_Click(sender As Object, e As EventArgs) Handles txtEncabezado.LostFocus
        If txtEncabezado.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(txtEncabezado, "Debe digitar el encabezado de la factura")
        Else
            ErrorIcono.SetError(txtEncabezado, "")
        End If
    End Sub
    Private Sub TxtDescripcion_Click(sender As Object, e As EventArgs) Handles TxtDescripcion.LostFocus
        If TxtDescripcion.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TxtDescripcion, "Debe digitar una razón social")
        Else
            ErrorIcono.SetError(TxtDescripcion, "")
        End If
    End Sub
    Private Sub TextTelefono_Click(sender As Object, e As EventArgs) Handles TextTelefono.LostFocus
        If TextTelefono.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TextTelefono, "Debe digitar un número de teléfono")
        Else
            ErrorIcono.SetError(TextTelefono, "")
        End If
    End Sub
    Private Sub TextDireccion_Click(sender As Object, e As EventArgs) Handles TextDireccion.LostFocus
        If TextDireccion.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TextDireccion, "Debe digitar una dirección")
        Else
            ErrorIcono.SetError(TextDireccion, "")
        End If
    End Sub
    Private Sub ComboMunicipio_Click(sender As Object, e As EventArgs) Handles ComboMunicipio.LostFocus
        If ComboMunicipio.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(ComboMunicipio, "Debe escoger un municipio")
        Else
            ErrorIcono.SetError(ComboMunicipio, "")
        End If
    End Sub
    Private Sub mostrarIconoError()

        If txtId.Text.Length = 0 Then
            ErrorIcono.SetError(txtId, "Debe digitar un nit")
        Else
            ErrorIcono.SetError(txtId, "")
        End If
        If TxtDescripcion.Text.Length = 0 Then
            ErrorIcono.SetError(TxtDescripcion, "Debe digitar una razón social")
        Else
            ErrorIcono.SetError(TxtDescripcion, "")
        End If
        If TextTelefono.Text.Length = 0 Then
            ErrorIcono.SetError(TextTelefono, "Debe digitar un número de teléfono")
        Else
            ErrorIcono.SetError(TextTelefono, "")
        End If
        If TextDireccion.Text.Length = 0 Then
            ErrorIcono.SetError(TextDireccion, "Debe digitar una dirección")
        Else
            ErrorIcono.SetError(TextDireccion, "")
        End If
        If cbDepartamento.SelectedIndex = 0 Then
            ErrorIcono.SetError(cbDepartamento, "Debe escoger un departamento")
        Else
            ErrorIcono.SetError(cbDepartamento, "")
        End If
        If ComboMunicipio.SelectedIndex = 0 Then
            ErrorIcono.SetError(ComboMunicipio, "Debe escoger un municipio")
        Else
            ErrorIcono.SetError(ComboMunicipio, "")
        End If

        If txtPie.Text.Length = 0 Then
            ErrorIcono.SetError(txtPie, "Debe digitar información del pié de factura")
        Else
            ErrorIcono.SetError(txtPie, "")
        End If
        If txtEncabezado.Text.Length = 0 Then
            ErrorIcono.SetError(txtEncabezado, "Debe digitar el encabezado de la factura")
        Else
            ErrorIcono.SetError(txtEncabezado, "")
        End If
    End Sub
    Private Sub quitarIconoError()
        ErrorIcono.SetError(TextDireccion, "")
        ErrorIcono.SetError(ComboMunicipio, "")
        ErrorIcono.SetError(cbDepartamento, "")
        ErrorIcono.SetError(txtEncabezado, "")
        ErrorIcono.SetError(TextTelefono, "")
        ErrorIcono.SetError(txtPie, "")
        ErrorIcono.SetError(TxtDescripcion, "")
        ErrorIcono.SetError(txtId, "")
    End Sub
End Class