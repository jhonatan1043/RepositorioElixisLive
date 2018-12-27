Imports System.ComponentModel
Public Class FormPersona
    Dim objPersona As persona
    Dim idPerfil As Integer
    Private Sub cargarObjeto()
        objPersona.identificacion = TextIdentificacion.Text
        objPersona.nombre = TextNombre.Text
        objPersona.telefono = TextTelefono.Text
        objPersona.celular = TextCelular.Text
        objPersona.correo = TextEmail.Text
        objPersona.direccion = TextDireccion.Text
        objPersona.codigoDepartamento = cbDepartamento.SelectedValue
        objPersona.codigoCiudad = ComboMunicipio.SelectedValue
        objPersona.codigoTipoIdentificacion = CombotipoIdentificacion.SelectedValue
        objPersona.asignar = chUsuario.Checked
        objPersona.usuario = txtUsuario.Text
    End Sub
    Private Function validarCampos() As Boolean
        If String.IsNullOrEmpty(TextIdentificacion.Text) Or
                    CombotipoIdentificacion.SelectedIndex = 0 Or
                    String.IsNullOrEmpty(TextNombre.Text) Or
                    String.IsNullOrEmpty(TextTelefono.Text) Or
                   cbDepartamento.SelectedIndex = 0 Or
                   ComboMunicipio.SelectedIndex = 0 Or
                    String.IsNullOrEmpty(TextDireccion.Text) Then
        ElseIf chUsuario.Checked = True _
            And Funciones.consultarUsuario(txtUsuario.Text) = True _
            And IsNothing(objPersona.codigo) Then
        ElseIf chUsuario.Checked = True And txtPerfil.Text = "" Then
        Else
            Return True
        End If
        Return False
    End Function
    Private Sub quitarIconoError()
        ErrorIcono.SetError(TextDireccion, "")
        ErrorIcono.SetError(ComboMunicipio, "")
        ErrorIcono.SetError(cbDepartamento, "")
        ErrorIcono.SetError(TextTelefono, "")
        ErrorIcono.SetError(TextNombre, "")
        ErrorIcono.SetError(TextIdentificacion, "")
        ErrorIcono.SetError(CombotipoIdentificacion, "")
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objPersona = New persona
        Try
            cargarComboDepartamento()
            cargarComboCiudad()
            Generales.cargarCombo(Sentencias.TIPO_IDENTENTIFICACION_LISTA, Nothing, "Nombre", "Codigo", CombotipoIdentificacion)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
        Generales.tabularConEnter(Me)
    End Sub
    Private Sub cargarComboDepartamento()
        Generales.cargarCombo(Sentencias.DEPARTAMENTO_CONSULTAR, Nothing, "descripcion", "Codigo_Departamento", cbDepartamento)
    End Sub
    Private Sub cargarComboCiudad()
        Dim params As New List(Of String)
        If Not String.IsNullOrEmpty(cbDepartamento.ValueMember) Then
            params.Add(cbDepartamento.SelectedValue)
            Generales.cargarCombo(Sentencias.CIUDAD_CONSULTAR, params, "descripcion", "Codigo_Municipio", ComboMunicipio)
        End If
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.deshabilitarControles(GroupBox1)
        Generales.limpiarControles(Me)
        TextDV.Enabled = False
        chUsuario.Enabled = True
        objPersona.codigo = Nothing
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
        CombotipoIdentificacion.Focus()
        listaSucursalesListar()
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarCampos() = True Then
            Try
                cargarObjeto()
                PersonaBLL.guardar(objPersona)
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
        mostrarIconoError()
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            btCancelar.Enabled = True
            btRegistrar.Enabled = True
            listaSucursalesCargar(objPersona.codigo, Constantes.EDITABLE)
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            objPersona.codigo = Nothing
            btNuevo.Enabled = True
            btBuscar.Enabled = True
            quitarIconoError()
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objPersona.sqlAnular & objPersona.codigo) = True Then
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
        Generales.buscarElemento(objPersona.sqlConsulta,
                                   params,
                                   AddressOf cargarInfomacion,
                                   Titulo.BUSQUEDA_PERSONA,
                                   True, True)
    End Sub
    Private Sub cargarInfomacion(pcodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objPersona.codigo = pcodigo
        params.Add(pcodigo)
        dfila = Generales.cargarItem(objPersona.sqlCargar, params)
        Try
            If Not IsNothing(dfila) Then
                TextIdentificacion.Text = dfila.Item("Identificacion")
                TextNombre.Text = dfila.Item("Nombre")
                TextTelefono.Text = If(IsDBNull(dfila("Telefono")), Nothing, dfila("Telefono"))
                TextCelular.Text = dfila("Celular")
                TextDireccion.Text = If(IsDBNull(dfila("Direccion")), Nothing, dfila("Direccion"))
                TextEmail.Text = If(IsDBNull(dfila("Email")), Nothing, dfila("Email"))
                CombotipoIdentificacion.SelectedValue = dfila("Tipo_Identificacion")
                cbDepartamento.SelectedValue = If(IsDBNull(dfila("Codigo_Departamento")), -1, dfila("Codigo_Departamento"))
                ComboMunicipio.SelectedValue = If(IsDBNull(dfila("Codigo_Ciudad")), -1, dfila("Codigo_Ciudad"))
                objPersona.codigoPerfil = If(IsDBNull(dfila("Codigo_Perfil")), Nothing, dfila("Codigo_Perfil"))
                chUsuario.Checked = If(IsDBNull(dfila("Codigo_Perfil")), False, True)
                txtUsuario.Text = dfila("Usuario")
                txtPerfil.Text = dfila("Perfil")
                listaSucursalesCargar(pcodigo, Constantes.NO_EDITABLE)
            End If
            Generales.habilitarBotones(ToolStrip1)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cbDepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepartamento.SelectedIndexChanged
        cargarComboCiudad()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Generales.cargarForm(FormPerfil)
    End Sub
    Private Sub chUsuario_Click(sender As Object, e As EventArgs) Handles chUsuario.Click
        If chUsuario.Checked = True Then
            txtUsuario.ReadOnly = False
            btBuscarPerfil.Enabled = True
        Else
            btBuscarPerfil.Enabled = False
            txtPerfil.Clear()
            txtUsuario.Clear()
        End If
    End Sub
    Private Sub txtUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtUsuario.Leave
        If btRegistrar.Enabled = False Then Exit Sub

        If Funciones.consultarUsuario(txtUsuario.Text) = True Then
            ErrorIcono.SetError(txtUsuario, "Este usuario ya existe")
            txtUsuario.Focus()
        Else
            ErrorIcono.SetError(txtUsuario, "")
        End If

    End Sub

    Private Sub TextIdentificacion_TextChanged(sender As Object, e As EventArgs) Handles TextIdentificacion.TextChanged
        Dim dV As New DigitoVerificacion
        Dim numero As Integer
        numero = dV.calculaNit(TextIdentificacion.Text)
        TextDV.Text = CType(numero, String)
        If TextIdentificacion.Text = Nothing Then
            TextDV.Text = Nothing
        End If
    End Sub

    Private Sub CombotipoIdentificacion_Validating(sender As Object, e As EventArgs) Handles CombotipoIdentificacion.LostFocus
        If CombotipoIdentificacion.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(CombotipoIdentificacion, "Debe escoger un tipo de identifición")
        Else
            ErrorIcono.SetError(CombotipoIdentificacion, "")
        End If
    End Sub
    Private Sub TextNombre_Validating(sender As Object, e As EventArgs) Handles TextNombre.LostFocus
        If TextNombre.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TextNombre, "Debe digitar el nombre")
        Else
            ErrorIcono.SetError(TextNombre, "")
        End If
    End Sub
    Private Sub TextIdentificacion_Validating(sender As Object, e As EventArgs) Handles TextIdentificacion.LostFocus
        If TextIdentificacion.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TextIdentificacion, "Debe digitar el número de identificación")
        Else
            ErrorIcono.SetError(TextIdentificacion, "")
        End If
    End Sub
    Private Sub TextDireccion_Validating(sender As Object, e As EventArgs) Handles TextDireccion.LostFocus
        If TextDireccion.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TextDireccion, "Debe digitar una dirección")
        Else
            ErrorIcono.SetError(TextDireccion, "")
        End If
    End Sub
    Private Sub TextTelefono_Validating(sender As Object, e As EventArgs) Handles TextTelefono.LostFocus
        If TextTelefono.Text.Length = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(TextTelefono, "Debe digitar un número de teléfono")
        Else
            ErrorIcono.SetError(TextTelefono, "")
        End If
    End Sub
    Private Sub cbDepartamento_Validating(sender As Object, e As EventArgs) Handles cbDepartamento.LostFocus
        If cbDepartamento.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(cbDepartamento, "Debe escoger un departamento")
        Else
            ErrorIcono.SetError(cbDepartamento, "")
        End If
    End Sub
    Private Sub ComboMunicipio_Validating(sender As Object, e As EventArgs) Handles ComboMunicipio.LostFocus
        If ComboMunicipio.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(ComboMunicipio, "Debe escoger un municipio")
        Else
            ErrorIcono.SetError(ComboMunicipio, "")
        End If
    End Sub
    Private Sub cbSede_Validating(sender As Object, e As EventArgs)
        If ComboMunicipio.SelectedIndex = 0 And btRegistrar.Enabled = True Then
            ErrorIcono.SetError(ComboMunicipio, "Debe escoger un municipio")
        Else
            ErrorIcono.SetError(ComboMunicipio, "")
        End If
    End Sub
    Private Sub mostrarIconoError()
        If CombotipoIdentificacion.SelectedIndex = 0 Then
            ErrorIcono.SetError(CombotipoIdentificacion, "Debe escoger un tipo de identifición")
        Else
            ErrorIcono.SetError(CombotipoIdentificacion, "")
        End If
        If TextIdentificacion.Text.Length = 0 Then
            ErrorIcono.SetError(TextIdentificacion, "Debe digitar un número de identificación")
        Else
            ErrorIcono.SetError(TextIdentificacion, "")
        End If
        If TextNombre.Text.Length = 0 Then
            ErrorIcono.SetError(TextNombre, "Debe digitar un nombre")
        Else
            ErrorIcono.SetError(TextNombre, "")
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
        If TextDireccion.Text.Length = 0 Then
            ErrorIcono.SetError(TextDireccion, "Debe digitar una dirección")
        Else
            ErrorIcono.SetError(TextDireccion, "")
        End If
        If TextTelefono.Text.Length = 0 Then
            ErrorIcono.SetError(TextTelefono, "Debe digitar un número de teléfono")
        Else
            ErrorIcono.SetError(TextTelefono, "")
        End If

        If chUsuario.Checked = True And txtUsuario.Text.Length = 0 Then
            ErrorIcono.SetError(txtUsuario, "Debe digitar un nombre de usuario")
        Else
            ErrorIcono.SetError(txtUsuario, "")
        End If
        If chUsuario.Checked = True And txtPerfil.Text.Length = 0 Then
            ErrorIcono.SetError(txtPerfil, "Debe escoger un perfil de usuario")
        Else
            ErrorIcono.SetError(txtPerfil, "")
        End If
    End Sub

    Private Sub btBuscarPerfil_Click(sender As Object, e As EventArgs) Handles btBuscarPerfil.Click
        Dim params As New List(Of String)
        Dim tblPerfil As DataRow = Nothing
        params.Add(String.Empty)
        Dim formBusqueda As FormBusqueda = Generales.buscarElemento(Sentencias.PERFIL_LISTA, params, "Busqueda de perfiles de usuario", True)
        tblPerfil = formBusqueda.rowResultados
        If tblPerfil IsNot Nothing Then
            objPersona.codigoPerfil = tblPerfil(0)
            idPerfil = tblPerfil(0)
            txtPerfil.Text = tblPerfil(1)
        End If
    End Sub
    Private Sub listaSucursalesCargar(codigo As Integer, editable As Integer)
        Dim params As New List(Of String)
        params.Add(codigo)
        params.Add(editable)
        Try
            Generales.llenarTabla(Sentencias.PERSONA_SUCURSALES_ASIGNADO, params, objPersona.dtSucursal)

            ListSucursal.DataSource = objPersona.dtSucursal
            ListSucursal.ValueMember = "Codigo"
            ListSucursal.DisplayMember = "Nombre"
            For item = 0 To objPersona.dtSucursal.Rows.Count - 1
                ListSucursal.SetItemChecked(item, objPersona.dtSucursal.Rows(item).Item("Realizado"))
            Next

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub listaSucursalesListar()
        Try
            Generales.llenarTabla(Sentencias.PERSONA_SUCURSALES_SIN_ASIGNAR, Nothing, objPersona.dtSucursal)
            ListSucursal.DataSource = objPersona.dtSucursal
            ListSucursal.ValueMember = "Codigo"
            ListSucursal.DisplayMember = "Nombre"
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub TextIdentificacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextTelefono.KeyPress,
        TextIdentificacion.KeyPress, TextCelular.KeyPress
        ValidacionDigitacion.validarValoresNumericos(e)
    End Sub

    Private Sub FormPersona_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNombre.KeyPress, MyBase.KeyPress
        ValidacionDigitacion.validarAlfabetico(e)
    End Sub
End Class