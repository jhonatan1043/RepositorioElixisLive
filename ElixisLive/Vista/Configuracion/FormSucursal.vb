Public Class FormSucursal
    Dim objSucursal As Sucursal
    Private Sub cargarObjeto()
        objSucursal.identiResponsable = txtIdentResponsable.Text
        objSucursal.responsable = txtResponsable.Text
        objSucursal.nombre = TextNombre.Text
        objSucursal.telefono = TextTelefono.Text
        objSucursal.celular = TextCelular.Text
        objSucursal.direccion = TextDireccion.Text
        objSucursal.codigoPais = cbPais.SelectedValue
        objSucursal.codigoDepartamento = cbDepartamento.SelectedValue
        objSucursal.codigoCiudad = ComboMunicipio.SelectedValue
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(TextNombre.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el nombre !")
        ElseIf String.IsNullOrEmpty(TextCelular.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar el Numero de celular !")
        ElseIf String.IsNullOrEmpty(cbPais.SelectedIndex) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe seleccionar el pais!")
        ElseIf String.IsNullOrEmpty(cbDepartamento.SelectedIndex) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe seleccionar el departamento!")
        ElseIf String.IsNullOrEmpty(ComboMunicipio.SelectedIndex) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe seleccionar la ciudad !")
        ElseIf String.IsNullOrEmpty(TextDireccion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe digitar la dirección !")
        Else
            resultado = True
        End If
        Return resultado
    End Function
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objSucursal = New Sucursal
        Try
            cargarComboPais()
            cargarComboDepartamento()
            cargarComboCiudad()
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarComboPais()
        Generales.cargarCombo("[SP_CONSULTAR_PAIS]", Nothing, "Nombre", "Codigo_Pais", cbPais)
    End Sub
    Private Sub cargarComboDepartamento()
        Dim params As New List(Of String)
        params.Add(cbPais.SelectedValue)
        Generales.cargarCombo("[SP_CONSULTAR_DEPARTAMENTO]", params, "Nombre", "Codigo_Departamento", cbDepartamento)
    End Sub
    Private Sub cargarComboCiudad()
        Dim params As New List(Of String)
        params.Add(cbDepartamento.SelectedValue)
        Generales.cargarCombo("[SP_CONSULTAR_CIUDAD]", params, "descripcion", "Codigo_Municipio", ComboMunicipio)
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        objSucursal.codigo = Nothing
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarCampos() = True Then
            Try
                cargarObjeto()
                SucursalBLL.guardar(objSucursal)
                Generales.habilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btRegistrar.Enabled = False
                btCancelar.Enabled = False
                EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
        End If
    End Sub

    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            objSucursal.codigo = Nothing
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objSucursal.sqlAnular & objSucursal.codigo) = True Then
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
        Generales.buscarElemento(objSucursal.sqlConsulta,
                                   params,
                                   AddressOf cargarInfomacion,
                                   "Busqueda de Sucursales",
                                   True, True)
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objSucursal.codigo = pcodigo
        params.Add(pcodigo)
        dfila = Generales.cargarItem(objSucursal.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                TextNombre.Text = dfila.Item("Nombre")
                TextTelefono.Text = If(IsDBNull(dfila("Telefono")), Nothing, dfila("Telefono"))
                TextCelular.Text = dfila("Celular")
                TextDireccion.Text = dfila("Direccion")
                cbPais.SelectedValue = dfila("pais")
                cbDepartamento.SelectedValue = dfila("Departamento")
                ComboMunicipio.SelectedValue = dfila("Ciudad")
                txtIdentResponsable.Text = dfila("Identi_Responsable")
                txtResponsable.Text = dfila("Responsable")
            End If
            Generales.habilitarBotones(ToolStrip1)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cbPais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPais.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cbPais.ValueMember) Then
            cargarComboDepartamento()
        End If
    End Sub
    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cbDepartamento.ValueMember) Then
            cargarComboCiudad()
        End If
    End Sub
End Class