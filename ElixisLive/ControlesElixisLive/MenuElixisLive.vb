Public Class MenuElixisLive
    Dim bra As Boolean
    Dim braButton As Boolean
    Dim panelGrobal As Panel
    Dim tamañoGrobalInicial As Point
    Dim tamañoGrobalFinal As Point
    Dim localicionGlobalInicial As Point
    Dim localicionGlobalFinal As Point
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
    Private Sub MenuElixisLive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generarMenu(crearDatatble)
    End Sub

    Private Sub generarMenu(dtMenu As DataTable)
        Dim pnlContButton As Panel
        Dim numHijo As Integer
        Dim salto As Integer
        Dim contador As Integer
        Dim auxTamañoY As Integer

        ' Datos del panel Posicion Y
        Dim posicionInicialY = 77
        Dim tamañoIncialY = 100
        ' Datos del panel Posicion x
        Dim posicionX = 6
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

        For Each dRow As DataRow In dtMenu.Select
            salto = 0
            If dRow.Item("padre") = "" Then
                contador = 1
                pnlContButton = New Panel
                numHijo = dtMenu.Compute("COUNT(codigo)", "padre = '" + dRow.Item("codigo") + "'") + 1
                salto = saltoLineaPredeterminado * numHijo
                pnlContButton = pnlContenedorCrear(New Point(posicionX, auxTamañoY), New Point(tamañoX, salto))
                pnlContButton.Controls.Add(btEncabezadoCrear(New Point(posicionButX, posicionInicialButY), dRow.Item("nombre"), pnlContButton))
                pnlContButton.Name = dRow.Item("nombre")
                SplitContainer1.Panel1.Controls.Add(pnlContButton)
                auxTamañoY = auxTamañoY + salto - 5
            Else
                salto = saltoLineaPredeterminado * contador
                pnlContButton.Controls.Add(btHijoCrear(New Point(posicionButX, salto), dRow.Item("nombre")))
                contador = contador + 1
                If contador = numHijo Then
                    ocultarSubMenu(pnlContButton)
                End If
            End If
        Next
    End Sub
    Private Function crearDatatble() As DataTable
        Dim dt As New DataTable
        dt.Columns.Add("codigo", Type.GetType("System.String"))
        dt.Columns.Add("nombre", Type.GetType("System.String"))
        dt.Columns.Add("formulario", Type.GetType("System.String"))
        dt.Columns.Add("icono", Type.GetType("System.String"))
        dt.Columns.Add("padre", Type.GetType("System.String"))

        For posicion = 0 To 9 Step 1
            dt.Rows.Add()
        Next

        dt.Rows(0).Item("codigo") = "1"
        dt.Rows(0).Item("nombre") = "Administracion"
        dt.Rows(0).Item("formulario") = ""
        dt.Rows(0).Item("icono") = ""
        dt.Rows(0).Item("padre") = ""

        dt.Rows(1).Item("codigo") = "2"
        dt.Rows(1).Item("nombre") = "Empresa"
        dt.Rows(1).Item("formulario") = ""
        dt.Rows(1).Item("icono") = ""
        dt.Rows(1).Item("padre") = "1"

        dt.Rows(2).Item("codigo") = "3"
        dt.Rows(2).Item("nombre") = "Persona"
        dt.Rows(2).Item("formulario") = ""
        dt.Rows(2).Item("icono") = ""
        dt.Rows(2).Item("padre") = "1"

        dt.Rows(3).Item("codigo") = "4"
        dt.Rows(3).Item("nombre") = "cliente"
        dt.Rows(3).Item("formulario") = ""
        dt.Rows(3).Item("icono") = ""
        dt.Rows(3).Item("padre") = "1"

        dt.Rows(4).Item("codigo") = "5"
        dt.Rows(4).Item("nombre") = "Inventario"
        dt.Rows(4).Item("formulario") = ""
        dt.Rows(4).Item("icono") = ""
        dt.Rows(4).Item("padre") = ""

        dt.Rows(5).Item("codigo") = "6"
        dt.Rows(5).Item("nombre") = "Producto"
        dt.Rows(5).Item("formulario") = ""
        dt.Rows(5).Item("icono") = ""
        dt.Rows(5).Item("padre") = "5"

        dt.Rows(6).Item("codigo") = "7"
        dt.Rows(6).Item("nombre") = "Entrada"
        dt.Rows(6).Item("formulario") = ""
        dt.Rows(6).Item("icono") = ""
        dt.Rows(6).Item("padre") = "5"

        dt.Rows(7).Item("codigo") = "8"
        dt.Rows(7).Item("nombre") = "Venta"
        dt.Rows(7).Item("formulario") = ""
        dt.Rows(7).Item("icono") = ""
        dt.Rows(7).Item("padre") = ""

        dt.Rows(8).Item("codigo") = "9"
        dt.Rows(8).Item("nombre") = "Factura"
        dt.Rows(8).Item("formulario") = ""
        dt.Rows(8).Item("icono") = ""
        dt.Rows(8).Item("padre") = "8"

        dt.Rows(9).Item("codigo") = "10"
        dt.Rows(9).Item("nombre") = "Recibo"
        dt.Rows(9).Item("formulario") = ""
        dt.Rows(9).Item("icono") = ""
        dt.Rows(9).Item("padre") = "8"

        Return dt
    End Function

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
                                 Optional img As Image = Nothing) As Button
        Dim btn As New Button

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
End Class
