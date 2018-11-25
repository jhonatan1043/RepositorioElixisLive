Public Class FormSucursal
    Dim objSucursal As Sucursal
    Private Sub cargarObjeto()
        objSucursal.nombre = TextNombre.Text
        objSucursal.telefono = TextTelefono.Text
        objSucursal.celular = TextCelular.Text
        objSucursal.direccion = TextDireccion.Text
        objSucursal.codigoDepartamento = cbDepartamento.SelectedValue
        objSucursal.codigoCiudad = ComboMunicipio.SelectedValue
    End Sub
    Private Function validarCampos() As Boolean
        If String.IsNullOrEmpty(TextNombre.Text) OrElse
           String.IsNullOrEmpty(TextCelular.Text) OrElse
           String.IsNullOrEmpty(cbDepartamento.SelectedIndex) OrElse
           String.IsNullOrEmpty(ComboMunicipio.SelectedIndex) OrElse
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
        objSucursal = New Sucursal
        Try
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
    Private Sub cargarComboDepartamento()
        Generales.cargarCombo(Sentencias.DEPARTAMENTO_CONSULTAR, Nothing, "descripcion", "Codigo_Departamento", cbDepartamento)
    End Sub
    Private Sub cargarComboCiudad()
        Dim params As New List(Of String)
        params.Add(cbDepartamento.SelectedValue)
        Generales.cargarCombo(Sentencias.CIUDAD_CONSULTAR, params, "descripcion", "Codigo_Municipio", ComboMunicipio)
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
        Else
            EstiloMensajes.mostrarMensajeAdvertencia(MensajeSistema.VALIDAR_CAMPOS)
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
                                   Titulo.BUSQUEDA_SUCURSAL,
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
                cbDepartamento.SelectedValue = dfila("Codigo_Departamento")
                ComboMunicipio.SelectedValue = dfila("Codigo_Ciudad")
            End If
            Generales.habilitarBotones(ToolStrip1)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        If Not String.IsNullOrEmpty(cbDepartamento.ValueMember) Then
            cargarComboCiudad()
        End If
    End Sub
End Class