Public Class FormCitaMedica
    Dim objCita As AgendarCita
    Public Property estadoRegistro As Boolean
    Public Property objFormularioProgram As FormProgramacionCita
    Property fechaHora As DateTime
    Property codigoCita As Integer
    Dim formulario As New vForm

    Private Sub FormCitaMedica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim respuesta As Integer = Generales.consultarPermiso(Name)
        If respuesta = Constantes.LECTURA_ESCRITURA Then
            Generales.mostrarLecturaEscritura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_LECTURA Then
            Generales.mostrarLectura(ToolStrip1)
        ElseIf respuesta = Constantes.SOLO_ESCRITURA Then
            Generales.mostrarEscritura(ToolStrip1)
        Else
            Generales.ocultarBotones(ToolStrip1)
        End If
        objCita = New AgendarCita
        Generales.deshabilitarBotones(ToolStrip1)
        Generales.deshabilitarControles(Me)
        validarGrilla()
        establecerPosicion()
        If estadoRegistro = True Then
            cargarCita(codigoCita)
            btEditar.Enabled = True
            btAnular.Enabled = True
        Else
            txtobservacion.ReadOnly = False
            txtfecha.Text = Format(fechaHora, Constantes.FORMATO_FECHA_HORA)
            validarEdicionGrilla(Constantes.EDITABLE)
            txtfecha.ReadOnly = False
            btBuscarCliente.Enabled = True
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
            objCita.dtServicio.Rows.Add()
        End If
        Generales.tabularConEnter(Me)
    End Sub
    Private Sub validarGrilla()
        With dgvServicio
            .Columns("dgCodigo").Visible = False
            .Columns("dgCodigo").DataPropertyName = "codigo"
            .Columns("dgServicio").DataPropertyName = "Descripcion"
            .Columns("dgCantidad").DataPropertyName = "Cantidad"
            .Columns("dgQuitar").DisplayIndex = 3
            .DataSource = objCita.dtServicio
            .AutoGenerateColumns = False
        End With
    End Sub
    Private Sub validarEdicionGrilla(Estado As Boolean)
        With dgvServicio
            .ReadOnly = False
            .Columns("dgServicio").ReadOnly = True
            .Columns("dgCantidad").ReadOnly = True
        End With
        If Estado = True Then
            With dgvServicio
                .Columns("dgCantidad").ReadOnly = False
            End With
        End If
    End Sub
    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.EDITAR) = Constantes.SI Then
            Generales.deshabilitarBotones(ToolStrip1)
            Generales.habilitarControles(Me)
            validarEdicionGrilla(Constantes.EDITABLE)
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
        If EstiloMensajes.mostrarMensajePregunta(MensajeSistema.ANULAR) = Constantes.SI Then
            Try
                If Generales.ejecutarSQL(objCita.sqlAnular & objCita.codigo) = True Then
                    Generales.deshabilitarBotones(ToolStrip1)
                    Generales.limpiarControles(Me)
                    Close()
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
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
            objFormularioProgram.validarControles()
            Close()
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
            Generales.buscarElemento(Sentencias.PERSONA_CONSULTAR,
                                   params,
                                   AddressOf cargarPersona,
                                   Titulo.BUSQUEDA_PERSONA,
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
            dfila = Generales.cargarItem(Sentencias.PERSONA_CARGAR, params)
            textNombre.Text = dfila("Nombre")
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub dgvServicio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvServicio.CellDoubleClick
        Dim params As New List(Of String)
        params.Add(String.Empty)
        If textNombre.Text <> String.Empty Then
            Try
                If btRegistrar.Enabled = False Then Exit Sub
                If (dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgCodigo").Selected = True _
                    Or dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgServicio").Selected = True) Then
                    Generales.busquedaItems(Sentencias.SERVICIO_CONSULTAR,
                                              params,
                                              Titulo.BUSQUEDA_SERVICIO,
                                              dgvServicio,
                                              objCita.dtServicio,
                                              0,
                                              1,
                                              0,
                                              0,
                                              True)
                ElseIf dgvServicio.Rows(dgvServicio.CurrentCell.RowIndex).Cells("dgQuitar").Selected = True _
                    And objCita.dtServicio.Rows(dgvServicio.CurrentCell.RowIndex).Item(0).ToString <> String.Empty Then
                    objCita.dtServicio.Rows.RemoveAt(e.RowIndex)
                End If
            Catch ex As Exception
                EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
            End Try
        End If
    End Sub
    Private Sub txtfecha_Leave(sender As Object, e As EventArgs) Handles txtfecha.Leave
        If btRegistrar.Enabled = False Then Exit Sub
        If validarIngresoFecha() = True Then
            EstiloMensajes.mostrarMensajeAdvertencia("¡ No se puede modificar la fecha, Solo minutos dentro de la hora establecida !")
            txtfecha.Focus()
        End If
    End Sub
    Private Function validarIngresoFecha() As Boolean
        Dim resultado As Boolean
        Dim fechaCitaHora As String = Format(fechaHora, "ddMMyyy HH")
        Dim fechaModificada As String = Format(Convert.ToDateTime(txtfecha.Text), "ddMMyyy HH")
        If fechaCitaHora <> fechaModificada Then
            resultado = True
        End If
        Return resultado
    End Function
    Public Sub cargarCita(idCita As Integer)
        Dim params As New List(Of String)
        Dim fila As DataRow
        Try
            params.Add(idCita)
            fila = Generales.cargarItem(objCita.sqlCargar, params)
            textNombre.Text = fila("Nombre")
            txtfecha.Text = Format(fila("Fecha_Cita"), Constantes.FORMATO_FECHA_HORA)
            txtobservacion.Text = fila("Observacion")
            Generales.llenarTabla(objCita.sqlCargarDetalle, params, objCita.dtServicio)
            dgvServicio.DataSource = objCita.dtServicio
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(MsgBox(ex.Message))
        End Try
    End Sub

    Private Sub dgvServicio_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvServicio.DataError
        If e.ColumnIndex = 3 Then
            EstiloMensajes.mostrarMensajeError(MensajeSistema.INGRESAR_VALOR_VALIDO)
        End If
    End Sub
End Class