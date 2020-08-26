Imports System.Data.SqlClient
Public Class FormModulo
    Dim dtModulo As New DataTable
    Dim fprincipal As New FormPrincipal
    Dim principalBLL As New principalBLL
    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        Dim respuesta = TextClave.Text
        Dim comparacion = String.CompareOrdinal(respuesta, Constantes.CLAVE_PRODUCTO)
        If comparacion <> 0 Then
            gbClave.Visible = True
            EstiloMensajes.mostrarMensajeError("La clave ingresada no es valida")
        Else
            gbClave.Visible = False
            Generales.habilitarControles(Me)
            btEditar.Enabled = False
            btRegistrar.Enabled = True
            btCancelar.Enabled = True
        End If
        TextClave.Clear()
    End Sub

    Private Sub btDeclinar_Click(sender As Object, e As EventArgs) Handles btDeclinar.Click
        gbClave.Visible = False
    End Sub

    Private Sub FormModulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbClave.Visible = False
        Generales.deshabilitarControles(Me)
        Generales.deshabilitarBotones(ToolStrip1)
        btEditar.Enabled = True
        cargarOpciones()
    End Sub
    Private Sub llenarModulos()
        Dim fila As DataRow = dtModulo.NewRow()
        dtModulo.Columns.Add("Modulo")
        If chConfiguracion.Checked = True Then
            fila("Modulo") = Constantes.MODULO_CONFIG
            dtModulo.Rows.Add(fila)
        End If
        If ChContabilidad.Checked = True Then
            fila = dtModulo.NewRow()
            fila("Modulo") = Constantes.MODULO_CONTA
            dtModulo.Rows.Add(fila)
        End If
        If ChInventario.Checked = True Then
            fila = dtModulo.NewRow()
            fila("Modulo") = Constantes.MODULO_INVEN
            dtModulo.Rows.Add(fila)
        End If
        If chNomina.Checked = True Then
            fila = dtModulo.NewRow()
            fila("Modulo") = Constantes.MODULO_NOMIN
            dtModulo.Rows.Add(fila)
        End If
        If ChCitas.Checked = True Then
            fila = dtModulo.NewRow()
            fila("Modulo") = Constantes.MODULO_CITA
            dtModulo.Rows.Add(fila)
        End If
        If chEstadistica.Checked = True Then
            fila = dtModulo.NewRow()
            fila("Modulo") = Constantes.MODULO_ESTAD
            dtModulo.Rows.Add(fila)
        End If
        If ChVentas.Checked = True Then
            fila = dtModulo.NewRow()
            fila("Modulo") = Constantes.MODULO_VENTA
            dtModulo.Rows.Add(fila)
        End If
    End Sub
    Public Function cargarModulos(ByVal pCodigo As String)
        Dim objConexio As New ConexionBD
        Dim dt As New DataTable
        dt.Clear()
        objConexio.conectar()
        Try
            Using dbCommand As New SqlCommand("SP_ADMIN_MENU_SUCURSAL_CARGAR " & pCodigo, objConexio.cnxbd)
                Using daCuentaPadre As New SqlDataAdapter(dbCommand)
                    daCuentaPadre.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        Finally
            objConexio.desconectar()
        End Try
        Return dt
    End Function
    Private Sub cargarOpciones()
        Dim dt As DataTable
        dt = cargarModulos(SesionActual.codigoSucursal)
        If dt.Rows.Count > 0 Then
            If dt.Select("Codigo='" & Constantes.MODULO_ADMIN & "'").Count > 0 Then
                chAdministracion.Checked = True
            Else
                chAdministracion.Checked = False
            End If
            If dt.Select("Codigo='" & Constantes.MODULO_CITA & "'").Count > 0 Then
                ChCitas.Checked = True
            Else
                ChCitas.Checked = False
            End If
            If dt.Select("Codigo='" & Constantes.MODULO_CONFIG & "'").Count > 0 Then
                chConfiguracion.Checked = True
            Else
                chConfiguracion.Checked = False
            End If
            If dt.Select("Codigo='" & Constantes.MODULO_CONTA & "'").Count > 0 Then
                ChContabilidad.Checked = True
            Else
                ChContabilidad.Checked = False
            End If
            If dt.Select("Codigo='" & Constantes.MODULO_ESTAD & "'").Count > 0 Then
                chEstadistica.Checked = True
            Else
                chEstadistica.Checked = False
            End If
            If dt.Select("Codigo='" & Constantes.MODULO_INVEN & "'").Count > 0 Then
                ChInventario.Checked = True
            Else
                ChInventario.Checked = False
            End If
            If dt.Select("Codigo='" & Constantes.MODULO_NOMIN & "'").Count > 0 Then
                chNomina.Checked = True
            Else
                chNomina.Checked = False
            End If
            If dt.Select("Codigo='" & Constantes.MODULO_VENTA & "'").Count > 0 Then
                ChVentas.Checked = True
            Else
                ChVentas.Checked = False
            End If
        End If
    End Sub
    Public Function crearModulo() As Modulo
        Dim modulo As New Modulo
        llenarModulos()

        For Each drFila As DataRow In dtModulo.Rows
            Dim drModulo As DataRow = modulo.dtModulo.NewRow
            drModulo.Item("codigo_sucursal") = SesionActual.codigoSucursal
            drModulo.Item("codigo_modulo") = drFila.Item("Modulo")
            modulo.dtModulo.Rows.Add(drModulo)
        Next
        Return modulo
    End Function

    Private Sub btRegistrar_Click(sender As Object, e As EventArgs) Handles btRegistrar.Click
        Dim moduloBLL As New ModuloBLL
        Try
            moduloBLL.guardarModulo(crearModulo())
            Generales.habilitarBotones(ToolStrip1)
            btRegistrar.Enabled = False
            btCancelar.Enabled = False
            principalBLL.eliminarMenu()
            principalBLL.cargarMenu()
            SesionActual.dtPermisos.Clear()
            SesionActual.dtPermisos = fprincipal.cargarOpciones(SesionActual.codigoPerfil)
            EstiloMensajes.mostrarMensajeExitoso(MensajeSistema.REGISTRO_GUARDADO)
            cargarOpciones()
            dtModulo.Columns.RemoveAt(0)
            dtModulo.Clear()

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try

    End Sub

    Private Sub btEditar_Click(sender As Object, e As EventArgs) Handles btEditar.Click
        cargarOpciones()
        gbClave.Visible = True
        btAceptar.Enabled = True
        btDeclinar.Enabled = True
        TextClave.ReadOnly = False
        TextClave.Focus()
    End Sub
End Class