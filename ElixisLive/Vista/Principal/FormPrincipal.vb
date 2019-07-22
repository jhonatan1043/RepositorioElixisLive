Imports System.Data.SqlClient
Public Class FormPrincipal
    Dim formulario As New vForm
    Dim banderaAncla As Boolean
    Dim ctlMDI As MdiClient
    Dim dtPermisos As New DataTable
    Dim objPrincipalBLL As New principalBLL
    Public menuOpciones As New MenuStrip
    Private Sub formPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objPrincipalBLL.formulario = Me
        objPrincipalBLL.cargarMenu()

        Dim ctl As Control
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                'ctlMDI.BackgroundImage = My.Resources.XANDaR_copia
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next

        lbUsuario.Text = SesionActual.nombreUsuario
        SesionActual.dtPermisos = cargarOpciones(SesionActual.codigoPerfil)
        'txtNombreEmpresa.Text = SesionActual.nombreEmpresa.ToUpper
    End Sub
    Public Function cargarOpciones(codigoPerfil As Integer) As DataTable
        Dim cadena As String
        Dim objConexio As New ConexionBD
        objConexio.conectar()
        Try
            cadena = Sentencias.ADMIN_PERFIL_DETALLE & codigoPerfil & ""
            dtPermisos.Clear()

            Using da = New SqlDataAdapter(cadena, objConexio.cnxbd)
                da.Fill(dtPermisos)
            End Using

        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
        Return dtPermisos
        dtPermisos.Dispose()
        objConexio.desconectar()
    End Function

End Class
