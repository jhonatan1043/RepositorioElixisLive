Imports System.Data.SqlClient
Public Class FormPrincipal
    Dim formulario As New vForm
    Dim banderaAncla As Boolean
    Dim ctlMDI As MdiClient
    Dim dtPermisos As New DataTable
    Dim objPrincipalBLL As New principalBLL
    Public menuOpciones As New MenuStrip
    Private Sub formPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MenuElixisLive1.pctLogo.Image = My.Resources.XANDaR
        MenuElixisLive1.generarMenu(objPrincipalBLL.CreaOpciones(), "Codigo_Padre", "codigo", "Descripcion", "Formulario")
        lbUsuario.Text = SesionActual.nombreUsuario
        'SesionActual.dtPermisos = cargarOpciones(SesionActual.codigoPerfil)
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Application.Exit()

    End Sub
End Class
