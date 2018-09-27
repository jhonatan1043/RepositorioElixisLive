Public Class SuperMessageBox
    Inherits System.Windows.Forms.Form
    Dim ex, ey As Integer
    Dim Arrastre As Boolean

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents lblMensaje As System.Windows.Forms.Label
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents label2 As System.Windows.Forms.Label
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents panel2 As System.Windows.Forms.Panel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.lblMensaje = New System.Windows.Forms.Label()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.panel1.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.BackgroundImage = Global.ElixisLive.My.Resources.Resources.fondo_azul
        Me.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Controls.Add(Me.label2)
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(350, 23)
        Me.panel1.TabIndex = 0
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(-1, -1)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(338, 23)
        Me.label2.TabIndex = 0
        Me.label2.Text = "Elixis"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'panel2
        '
        Me.panel2.BackgroundImage = Global.ElixisLive.My.Resources.Resources.fondo_azul
        Me.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel2.Controls.Add(Me.lblMensaje)
        Me.panel2.Controls.Add(Me.logo)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2.Location = New System.Drawing.Point(0, 0)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(350, 150)
        Me.panel2.TabIndex = 1
        '
        'lblMensaje
        '
        Me.lblMensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblMensaje.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMensaje.ForeColor = System.Drawing.Color.White
        Me.lblMensaje.Location = New System.Drawing.Point(73, 60)
        Me.lblMensaje.Name = "lblMensaje"
        Me.lblMensaje.Size = New System.Drawing.Size(260, 37)
        Me.lblMensaje.TabIndex = 0
        Me.lblMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logo
        '
        Me.logo.BackColor = System.Drawing.Color.Transparent
        Me.logo.Location = New System.Drawing.Point(2, 45)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(68, 68)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'SuperMessageBox
        '
        Me.ClientSize = New System.Drawing.Size(350, 150)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SuperMessageBox"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SuperMessageBox"
        Me.TopMost = True
        Me.panel1.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub


#End Region

    Dim mintAncho As Integer = 80
    Dim alstBotones As New ArrayList
    Dim mstrRetorno As String


    '''<summary> Agrega un titulo al formulario </summary>
    '''<param name="Cadena">El titulo a agregar</param>
    Public Sub AgregarTitulo(ByVal Cadena As String)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Autor: angell
        'Fecha de Creación: 16/12/2004
        'Modificaciones:
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                DESCRIPCION DE LAS VARIABLES LOCALES
        '    (agregar nombre de variables y su descripción) 
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        label2.Text = Cadena
    End Sub

    Public Sub Agregarlogo(ByVal logo As Bitmap)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                DESCRIPCION DE LAS VARIABLES LOCALES
        '    (agregar nombre de variables y su descripción) 
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        Me.logo.Image = logo
    End Sub

    '''<summary> Agrega un boton al formulario </summary>
    '''<param name="Cadena">El titulo del boton</param>
    Public Sub AgregarBoton(ByVal Cadena As String)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Autor: angell
        'Fecha de Creación: 16/12/2004
        'Modificaciones:
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                DESCRIPCION DE LAS VARIABLES LOCALES
        '    (agregar nombre de variables y su descripción) 
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim cmdBoton As New System.Windows.Forms.Button
        cmdBoton.Text = Cadena
        cmdBoton.Height = 22 : cmdBoton.Width = mintAncho
        cmdBoton.Font = New Font("Arial", 9, FontStyle.Regular)
        alstBotones.Add(cmdBoton)
    End Sub

    '''<summary> Agrega un mensaje al Formulario </summary>
    '''<param name="cadena">El texto del mensaje</param>
    Public Sub AgregarMensaje(ByVal cadena As String)
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Autor: angell
        'Fecha de Creación: 16/12/2004
        'Modificaciones:
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                DESCRIPCION DE LAS VARIABLES LOCALES
        '    (agregar nombre de variables y su descripción) 
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        lblMensaje.Text = cadena
    End Sub

    '''<summary> Diseña el MessageBox </summary>
    '''<returns> Devuelve el campo TEXT del botón presionado</returns>
    Public Function Mostrar() As String
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Autor: angell
        'Fecha de Creación: 16/12/2004
        'Modificaciones:
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '                DESCRIPCION DE LAS VARIABLES LOCALES
        '   cmdBoton        : un objeto boton temporal
        '   intContador     : la cantidad de botones del formulario
        '   intLargo        : la suma del largo de todos los botones mas sus espacios
        '   intI            : contador para el FOR-NEXT
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        Dim cmdBoton As Button
        Dim intContador As Integer = alstBotones.Count
        Dim intLargo As Integer = intContador * (mintAncho + 3)
        Dim intI As Integer

        'seteamos el largo del formulario + 50 unidades
        'Me.Width = intLargo + 50
        'seteamos el largo de la etiqueta del formulario
        'Me.lblMensaje.Width = intLargo
        'centramos la etiqueta haciendola comensar en la posicion 25 (pues se agrego 50, 25 de cada lado al formulario)
        'lblMensaje.Left = 25

        'para cada boton del arraylist, iteramos y lo agregamos al formulario 
        'asignándole el evento EVENTOCLICK que cargara en la variable
        'de retorno el contenido del campo TEXT del botón
        For intI = 0 To intContador - 1
            cmdBoton = CType(alstBotones(intI), Button)

            'situamos la posicion del boton en base a su orden
            If intContador = 1 Then
                cmdBoton.Location = New Point((mintAncho + 3) * intI + 260, 115)
            ElseIf intContador = 2 Then
                cmdBoton.Location = New Point((mintAncho + 3) * intI + 160, 115)
            ElseIf intContador = 3 Then
                cmdBoton.Location = New Point((mintAncho + 3) * intI + 52, 115)
            End If
            'agregamos el controlador del evento click al boton
            AddHandler cmdBoton.Click, AddressOf EventoClick

            'seteamos al formulario como padre del control.
            panel2.Controls.Add(cmdBoton)
        Next
        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - 750
        y = Screen.PrimaryScreen.WorkingArea.Height - 450
        Me.Location = New Point(x, y)
        'centramos en la pantalla el formulario
        'Me.CenterToScreen()
        'lo mostramos y esperamos hasta que se haya presionado un boton 
        'evento que cerrará el formulario
        'Me.MdiParent = FormPrincipal
        Me.ShowDialog()

        'retornamos el valor de la variable de retorno
        Return mstrRetorno
    End Function

    '''<sumary>El evento que controla el click de los botones </sumary>
    Private Sub EventoClick(ByVal Sender As System.Object, ByVal e As EventArgs)
        mstrRetorno = CType(Sender, Button).Text
        Me.Close()
    End Sub

End Class
