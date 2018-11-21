Public Class FormCitaMedica
<<<<<<< .mine
    Dim objCita As AgendarCita
    Public Property estadoRegistro As Boolean
||||||| .r166
=======
    Dim formulario As New vForm
>>>>>>> .r168
    Private Sub FormCitaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
<<<<<<< .mine
        objCita = New AgendarCita
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        If estadoRegistro = True Then
            txtobservacion.ReadOnly = False
            btEditar.Enabled = True
            btAnular.Enabled = True
        Else
            btBuscarPerfil.Enabled = True
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
    End Sub
    Private Sub Form_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Dispose()
        Else
            e.Cancel = True
        End If
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
            Close()
        End If
    End Sub
    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
||||||| .r166
=======
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
>>>>>>> .r168

        If e.Button = MouseButtons.Left Then
            formulario.moverForm() '' se llama la función que da el efecto
        End If

    End Sub
<<<<<<< .mine
    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
||||||| .r166
    'Dim perG As New Buscar_Permisos_generales
    'Dim objCita As New ProgramCitaMedica
    'Dim reporte As New ftp_reportes
    'Dim permiso_general, Pnuevo, Peditar, Panular, PBuscar As String
    'Property objFormularioProgram As FormProgramacionCita
    'Property fechaHora As DateTime
    'Public Property bandera As Boolean
    'Private Sub btbuscarPaciente_Click(sender As Object, e As EventArgs) Handles btbuscarPaciente.Click
    '    Dim params As New List(Of String)
    '    params.Add(Nothing)
    '    General.buscarElemento(Consultas.PACIENTE_EXTERNOS_BUSCAR,
    '                         params,
    '                         AddressOf cargarPacienteAM,
    '                         TitulosForm.BUSQUEDA_PACIENTE,
    '                         True, 0, True)
    'End Sub
=======
    Private Sub Panel2_Click(sender As Object, e As EventArgs) Handles Panel2.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.SALIR) = Constantes.SI Then
            Me.Close()
        End If
    End Sub

    'Dim perG As New Buscar_Permisos_generales
    'Dim objCita As New ProgramCitaMedica
    'Dim reporte As New ftp_reportes
    'Dim permiso_general, Pnuevo, Peditar, Panular, PBuscar As String
    'Property objFormularioProgram As FormProgramacionCita
    'Property fechaHora As DateTime
    'Public Property bandera As Boolean
    'Private Sub btbuscarPaciente_Click(sender As Object, e As EventArgs) Handles btbuscarPaciente.Click
    '    Dim params As New List(Of String)
    '    params.Add(Nothing)
    '    General.buscarElemento(Consultas.PACIENTE_EXTERNOS_BUSCAR,
    '                         params,
    '                         AddressOf cargarPacienteAM,
    '                         TitulosForm.BUSQUEDA_PACIENTE,
    '                         True, 0, True)
    'End Sub
>>>>>>> .r168

    End Sub
    Private Sub btBuscarPerfil_Click(sender As Object, e As EventArgs) Handles btBuscarPerfil.Click
        Dim params As New List(Of String)
        params.Add(String.Empty)
        Try
            Generales.buscarElemento("[SP_PERSONA_EMPLEADO_CONSULTAR]",
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