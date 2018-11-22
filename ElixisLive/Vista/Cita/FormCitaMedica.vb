Public Class FormCitaMedica
    Dim objCita As AgendarCita
    Public Property estadoRegistro As Boolean
    Public Property objFormularioProgram As FormProgramacionCita
    Property fechaHora As DateTime
    Dim formulario As New vForm
    Private Sub FormCitaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objCita = New AgendarCita
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        If estadoRegistro = True Then
            btEditar.Enabled = True
            btAnular.Enabled = True
        Else
            txtobservacion.ReadOnly = False
            txtfecha.Text = Format(fechaHora, Constantes.FORMATO_FECHA_HORA)
            btBuscarCliente.Enabled = True
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
        establecerPosicion()
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub btCancelar_Click(sender As Object, e As EventArgs) Handles btCancelar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.CANCELAR) = Constantes.SI Then
            If Not IsNothing(objCita.codigo) Then
                Generales.deshabilitarBotones(ToolStrip1)
                Generales.deshabilitarControles(Me)
                btEditar.Enabled = True
                btAnular.Enabled = True
            Else
                Close()
            End If
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        establecerPosicion()
        formulario.ventana = Me '' se indica el formulario que usara el efecto
        formulario.redondear() '' se redondean los bordes del formulario
    End Sub
    Private Sub establecerPosicion()
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 920
        y = Screen.PrimaryScreen.WorkingArea.Height - 570
        Me.Location = New Point(x, y)
    End Sub
    Private Sub formBusqueda_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = ChrW(Keys.Escape) Then
            Close()
        End If
    End Sub
    Private Sub FormBusquedaMouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                Handles MyBase.MouseMove '' aca puedes agregar mas controles que quieras usar para mover el formulario ej: label1.MouseMove
        If e.Button = MouseButtons.Left Then
            formulario.moverForm() '' se llama la función que da el efecto
        End If
    End Sub
    Private Sub cargarObjeto()
        objCita.dtFechaCita = Format(Convert.ToDateTime(txtfecha.Text), Constantes.FORMATO_FECHA_HORA)
        objCita.observacion = txtobservacion.Text
    End Sub
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Try
            cargarObjeto()
            AgendarCitaBLL.guardarCita(objCita)
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.deshabilitarControles(Me)
            btEditar.Enabled = True
            btAnular.Enabled = True
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Close()
        End If
    End Sub
    Private Sub btBuscarCliente_Click(sender As Object, e As EventArgs) Handles btBuscarCliente.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento("[SP_ADMIN_PERSONA_CONSULTAR]",
                                   params,
                                   AddressOf cargarPersona,
                                   "Busqueda de persona",
                                   True, True)
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub
    Private Sub cargarPersona(pCodigo As Integer)
        Dim params As New List(Of String)
        Dim dfila As DataRow
        objCita.codigoPersona = pCodigo
        params.Add(pCodigo)
        Try
            dfila = Generales.cargarItem("SP_PERSONA_CARGAR", params)
            textNombre.Text = dfila("Nombre")
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub


End Class