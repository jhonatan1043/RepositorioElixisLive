Imports System.Reflection
Public Class MenuElixisLive
    Dim bra As Boolean
    Dim braButton As Boolean
    Dim panelGrobal As Panel
    Dim tamañoGrobalInicial As Point
    Dim tamañoGrobalFinal As Point
    Dim localicionGlobalInicial As Point
    Dim localicionGlobalFinal As Point
    Dim menu As ElementoMenu
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If bra = True Then
            SplitContainer1.Panel1Collapsed = False
            bra = False
        Else
            SplitContainer1.Panel1Collapsed = True
            bra = True
        End If
    End Sub
    'Private Sub desplegarMenuHijo()
    '    If braButton = True Then
    '        panelGrobal.Size = New Size(tamañoGrobalFinal)
    '        panelGrobal.Location = New Point(localicionGlobalFinal)
    '        braButton = False
    '    Else
    '        panelGrobal.Size = New Size(tamañoGrobalInicial)
    '        panelGrobal.Location = New Point(localicionGlobalInicial)
    '        braButton = True
    '    End If
    'End Sub
    Public Sub generarMenu(dtMenu As DataTable,
                           columnPadre As String,
                           columnCodigo As String,
                           columnNombre As String,
                           columnForm As String)

        Dim pnlContButton As Panel
        Dim numHijo As Integer
        Dim salto As Integer
        Dim contador As Integer
        Dim auxTamañoY As Integer

        ' Datos del panel Posicion Y
        Dim posicionInicialY = 77
        Dim tamañoIncialY = 100
        ' Datos del panel Posicion x
        Dim posicionX = 3
        Dim tamañoX = 270
        '----------------------------------------
        ' Datos del Button Posicion Y
        Dim posicionInicialButY = 3
        ' Datos del Button Posicion x
        Dim posicionButX = 3
        '-------------------------------------------
        'salto de linea 
        Dim saltoLineaPredeterminado = 32
        '----------------------------------------------
        auxTamañoY = posicionInicialY

        Try
            For Each dRow As DataRow In dtMenu.Select
                salto = 0

                If dRow.Item(columnPadre) = "" Then
                    contador = 1
                    pnlContButton = New Panel
                    numHijo = dtMenu.Compute("COUNT(" + columnCodigo + ")", columnPadre + " = '" + dRow.Item(columnCodigo) + "'") + 1
                    salto = saltoLineaPredeterminado * numHijo
                    pnlContButton = pnlContenedorCrear(New Point(posicionX, auxTamañoY), New Point(tamañoX, salto))
                    pnlContButton.Controls.Add(btEncabezadoCrear(New Point(posicionButX, posicionInicialButY), dRow.Item(columnNombre), pnlContButton))
                    pnlContButton.Name = dRow.Item(columnNombre)
                    SplitContainer1.Panel1.Controls.Add(pnlContButton)
                    auxTamañoY = auxTamañoY + salto - 5
                Else
                    salto = saltoLineaPredeterminado * contador
                    pnlContButton.Controls.Add(btHijoCrear(New Point(posicionButX, salto),
                                                               dRow.Item(columnNombre),
                                                               dRow,
                                                               columnPadre,
                                                               columnCodigo,
                                                               columnNombre,
                                                               columnForm))
                    contador = contador + 1
                    If contador = numHijo Then
                        'ocultarSubMenu(pnlContButton)
                    End If
                End If
            Next
        Catch ex As Exception
            EstiloMensajes.mostrarMensajeError(ex.Message)
        End Try
    End Sub
    Private Function btEncabezadoCrear(localidad As Point,
                                       nombre As String,
                                       panelC As Panel,
                                       Optional img As Image = Nothing) As Button
        Dim btn As New Button
        btn.BackColor = Color.RoyalBlue
        btn.ForeColor = Color.White
        btn.ImageAlign = ContentAlignment.MiddleLeft
        btn.TextAlign = ContentAlignment.MiddleCenter
        btn.Anchor = AnchorStyles.Bottom
        btn.Anchor = AnchorStyles.Left
        btn.Anchor = AnchorStyles.Right
        btn.FlatStyle = FlatStyle.Popup
        btn.Font = New Font("Microsoft Sans Serif", 10)
        btn.Location = localidad
        btn.Size = New Point(265, 32)
        'AddHandler btn.Click, AddressOf desplegarMenuHijo
        btn.Text = nombre
        btn.Image = img
        btn.Show()
        Return btn
    End Function
    Private Function btHijoCrear(localidad As Point,
                                 nombre As String,
                                 dRow As DataRow,
                                 columnPadre As String,
                                 columnCodigo As String,
                                 columnNombre As String,
                                 columnForm As String,
                                 Optional img As Image = Nothing) As Button

        Dim btn As New Button

        btn.Tag = New ElementoMenu(dRow.Item(columnCodigo),
                                        dRow.Item(columnForm),
                                        Nothing,
                                        dRow.Item(columnNombre))

        btn.Name = dRow.Item(columnNombre)
        btn.BackColor = Color.LightSkyBlue
        btn.ForeColor = Color.Black
        btn.ImageAlign = ContentAlignment.MiddleLeft
        btn.TextAlign = ContentAlignment.MiddleCenter
        btn.Anchor = AnchorStyles.Bottom
        btn.Anchor = AnchorStyles.Left
        btn.Anchor = AnchorStyles.Right
        btn.FlatStyle = FlatStyle.Popup
        btn.Font = New Font("Microsoft Sans Serif", 9)
        btn.Location = localidad
        btn.Size = New Point(265, 32)
        AddHandler btn.Click, AddressOf abrirFormulario
        btn.Text = nombre
        btn.Image = img
        btn.Show()
        Return btn
    End Function
    Private Function pnlContenedorCrear(localidad As Point,
                                   tamaño As Point)
        Dim pnl As New Panel
        pnl.BackColor = Color.Silver
        pnl.Anchor = AnchorStyles.Bottom
        pnl.Anchor = AnchorStyles.Left
        pnl.Anchor = AnchorStyles.Right
        pnl.Size = tamaño
        pnl.Location = localidad
        Return pnl
    End Function
    Private Sub ocultarSubMenu(panelC As Panel)
        For Each control As Control In panelC.Controls
            If control.BackColor <> Color.RoyalBlue Then
                control.Visible = False
            End If
        Next
    End Sub
    Private Sub recogerMenu(panelC As Panel, dRow As DataRow)
        Dim posicionX = 6
        Dim salto As Integer
        Dim contador As Integer = 1
        Dim saltoLineaPredeterminado = 32
        If dRow.Item("padre") = "" And dRow.Item("codigo") <> "1" Then
            salto = saltoLineaPredeterminado * contador
            panelC.Location = New Point(posicionX, salto)
            contador = contador + 1
        End If
    End Sub
    Private Sub abrirFormulario(sender As Object, e As EventArgs)
        Dim boton = DirectCast(sender, Button)
        Dim elemMenu As ElementoMenu = boton.Tag

        Dim nombreTipo = Constantes.NOMBRE_SOFTWARE & elemMenu.nombre
        Dim vTipo As Type = Assembly.GetExecutingAssembly.GetType(nombreTipo)

        If vTipo IsNot Nothing Then
            Dim vFormulario = Activator.CreateInstance(vTipo)
            vFormulario.tag = elemMenu
            cargarFormularioPanel(vFormulario)
        End If
    End Sub
    Private Sub cargarFormularioPanel(formContenido As Form)
        formContenido.TopLevel = False
        formContenido.Dock = DockStyle.None
        formContenido.FormBorderStyle = FormBorderStyle.None
        PnlContendorForm.Controls.Clear()
        PnlContendorForm.Controls.Add(formContenido)
        formContenido.Top = (PnlContendorForm.Height / 2) - (formContenido.Height / 2)
        formContenido.Left = (PnlContendorForm.Width / 2) - (formContenido.Width / 2)
        PnlContendorForm.AutoScroll = True
        formContenido.Show()
    End Sub
End Class
