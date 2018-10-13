Public Class FormPersona
    Dim objPersona As persona
    Private Sub cargarObjeto()
        objPersona.identificacion = TextIdentificacion.Text
        objPersona.nombre = TextNombre.Text
    End Sub
    Private Function validarCampos() As Boolean
        Dim resultado As Boolean
        If String.IsNullOrEmpty(TextIdentificacion.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe ingresar el número de identificación de la persona!")
        ElseIf String.IsNullOrEmpty(TextNombre.Text) Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡Debe ingresar el nombre de la persona!")
        Else
            resultado = True
        End If
        Return resultado
    End Function

    Private Sub FormBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim params As New List(Of String)
        objPersona = New persona
        Try
            params.Add(ElementoMenu.codigo)
            params.Add(SesionActual.idEmpresa)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub btNuevo_Click(sender As Object, e As EventArgs) Handles btNuevo.Click
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.habilitarControles(Me)
        Generales.limpiarControles(Me)
        btCancelar.Enabled = True
        btRegistrar.Enabled = True
    End Sub

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        If validarCampos() = True Then
            Try
                cargarObjeto()
                PersonaBLL.guardar(objPersona)
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btNuevo.Enabled = True
                btEditar.Enabled = True
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
            btNuevo.Enabled = True
            btBuscar.Enabled = True
        End If
    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objPersona.sqlAnular) = True Then
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
                                   "Busqueda de Empresa",
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
                TextIdentificacion.Text = dfila.Item("Nit")
                TextNombre.Text = dfila.Item("Nombre")
                params.Add(ElementoMenu.codigo)
            End If
            Generales.habilitarBotones(ToolStrip1)
            btCancelar.Enabled = False
            btRegistrar.Enabled = False
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
End Class