﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormEmpleado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbInform = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GbInform_D = New System.Windows.Forms.GroupBox()
        Me.dgvParametro = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.gpPagare = New System.Windows.Forms.GroupBox()
        Me.NumComision = New System.Windows.Forms.NumericUpDown()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbTipoSalario = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gpUsuario = New System.Windows.Forms.GroupBox()
        Me.cbPerfil = New System.Windows.Forms.ComboBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.gpPago = New System.Windows.Forms.GroupBox()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LTitulo = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btBusqueda = New System.Windows.Forms.ToolStripButton()
        Me.btRegistrar = New System.Windows.Forms.ToolStripButton()
        Me.btEditar = New System.Windows.Forms.ToolStripButton()
        Me.btCancelar = New System.Windows.Forms.ToolStripButton()
        Me.btAnular = New System.Windows.Forms.ToolStripButton()
        Me.pFoto = New System.Windows.Forms.PictureBox()
        Me.bttercero = New System.Windows.Forms.Button()
        Me.gbInform.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GbInform_D.SuspendLayout()
        CType(Me.dgvParametro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gpPagare.SuspendLayout()
        CType(Me.NumComision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpUsuario.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gpPago.SuspendLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbInform
        '
        Me.gbInform.BackColor = System.Drawing.Color.Transparent
        Me.gbInform.Controls.Add(Me.bttercero)
        Me.gbInform.Controls.Add(Me.txtEmail)
        Me.gbInform.Controls.Add(Me.txtDireccion)
        Me.gbInform.Controls.Add(Me.txtNombre)
        Me.gbInform.Controls.Add(Me.txtCelular)
        Me.gbInform.Controls.Add(Me.txtTelefono)
        Me.gbInform.Controls.Add(Me.txtIdentificacion)
        Me.gbInform.Controls.Add(Me.Label5)
        Me.gbInform.Controls.Add(Me.Label4)
        Me.gbInform.Controls.Add(Me.Label3)
        Me.gbInform.Controls.Add(Me.Label6)
        Me.gbInform.Controls.Add(Me.Label2)
        Me.gbInform.Controls.Add(Me.Label1)
        Me.gbInform.Location = New System.Drawing.Point(4, 7)
        Me.gbInform.Name = "gbInform"
        Me.gbInform.Size = New System.Drawing.Size(786, 102)
        Me.gbInform.TabIndex = 9
        Me.gbInform.TabStop = False
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(394, 71)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(387, 25)
        Me.txtEmail.TabIndex = 69
        Me.txtEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(394, 43)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(387, 25)
        Me.txtDireccion.TabIndex = 67
        Me.txtDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(394, 15)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(352, 25)
        Me.txtNombre.TabIndex = 68
        Me.txtNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCelular
        '
        Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCelular.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCelular.Location = New System.Drawing.Point(125, 71)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(186, 25)
        Me.txtCelular.TabIndex = 68
        Me.txtCelular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(125, 43)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(186, 25)
        Me.txtTelefono.TabIndex = 69
        Me.txtTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdentificacion.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdentificacion.Location = New System.Drawing.Point(125, 15)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(186, 25)
        Me.txtIdentificacion.TabIndex = 66
        Me.txtIdentificacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(320, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 19)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Em@il:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(316, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 19)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Dirección:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Celular:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 19)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Teléfono:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(320, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "N° Identificación:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.pFoto)
        Me.GroupBox3.Location = New System.Drawing.Point(792, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(100, 102)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        '
        'GbInform_D
        '
        Me.GbInform_D.Controls.Add(Me.dgvParametro)
        Me.GbInform_D.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbInform_D.ForeColor = System.Drawing.Color.Black
        Me.GbInform_D.Location = New System.Drawing.Point(4, 262)
        Me.GbInform_D.Name = "GbInform_D"
        Me.GbInform_D.Size = New System.Drawing.Size(888, 169)
        Me.GbInform_D.TabIndex = 59
        Me.GbInform_D.TabStop = False
        Me.GbInform_D.Text = "Otros Datos del Empleado"
        '
        'dgvParametro
        '
        Me.dgvParametro.AllowUserToAddRows = False
        Me.dgvParametro.AllowUserToDeleteRows = False
        Me.dgvParametro.AllowUserToResizeColumns = False
        Me.dgvParametro.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvParametro.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvParametro.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvParametro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvParametro.Location = New System.Drawing.Point(3, 18)
        Me.dgvParametro.MultiSelect = False
        Me.dgvParametro.Name = "dgvParametro"
        Me.dgvParametro.Size = New System.Drawing.Size(879, 145)
        Me.dgvParametro.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.gpPagare)
        Me.GroupBox1.Controls.Add(Me.gpUsuario)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GbInform_D)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.gbInform)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 440)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'gpPagare
        '
        Me.gpPagare.Controls.Add(Me.NumComision)
        Me.gpPagare.Controls.Add(Me.txtSalario)
        Me.gpPagare.Controls.Add(Me.Label17)
        Me.gpPagare.Controls.Add(Me.Label15)
        Me.gpPagare.Controls.Add(Me.cbTipoSalario)
        Me.gpPagare.Controls.Add(Me.Label16)
        Me.gpPagare.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic)
        Me.gpPagare.ForeColor = System.Drawing.Color.Black
        Me.gpPagare.Location = New System.Drawing.Point(620, 115)
        Me.gpPagare.Name = "gpPagare"
        Me.gpPagare.Size = New System.Drawing.Size(272, 145)
        Me.gpPagare.TabIndex = 68
        Me.gpPagare.TabStop = False
        Me.gpPagare.Text = "Información Salarial"
        '
        'NumComision
        '
        Me.NumComision.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.NumComision.Location = New System.Drawing.Point(103, 46)
        Me.NumComision.Name = "NumComision"
        Me.NumComision.Size = New System.Drawing.Size(163, 25)
        Me.NumComision.TabIndex = 18
        Me.NumComision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSalario
        '
        Me.txtSalario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalario.Location = New System.Drawing.Point(103, 77)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(164, 25)
        Me.txtSalario.TabIndex = 17
        Me.txtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(5, 79)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 19)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Salario:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(5, 49)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 19)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "%.Comisión:"
        '
        'cbTipoSalario
        '
        Me.cbTipoSalario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoSalario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cbTipoSalario.FormattingEnabled = True
        Me.cbTipoSalario.Location = New System.Drawing.Point(103, 16)
        Me.cbTipoSalario.Name = "cbTipoSalario"
        Me.cbTipoSalario.Size = New System.Drawing.Size(163, 25)
        Me.cbTipoSalario.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(5, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 19)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Tipo:"
        '
        'gpUsuario
        '
        Me.gpUsuario.Controls.Add(Me.cbPerfil)
        Me.gpUsuario.Controls.Add(Me.txtUsuario)
        Me.gpUsuario.Controls.Add(Me.Label9)
        Me.gpUsuario.Controls.Add(Me.Label10)
        Me.gpUsuario.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic)
        Me.gpUsuario.ForeColor = System.Drawing.Color.Black
        Me.gpUsuario.Location = New System.Drawing.Point(310, 189)
        Me.gpUsuario.Name = "gpUsuario"
        Me.gpUsuario.Size = New System.Drawing.Size(304, 71)
        Me.gpUsuario.TabIndex = 67
        Me.gpUsuario.TabStop = False
        Me.gpUsuario.Text = "Información del Usuario"
        '
        'cbPerfil
        '
        Me.cbPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPerfil.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cbPerfil.FormattingEnabled = True
        Me.cbPerfil.Location = New System.Drawing.Point(126, 43)
        Me.cbPerfil.Name = "cbPerfil"
        Me.cbPerfil.Size = New System.Drawing.Size(171, 25)
        Me.cbPerfil.TabIndex = 15
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(126, 16)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(171, 25)
        Me.txtUsuario.TabIndex = 14
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(3, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 19)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Perfil:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(3, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 19)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Usuario:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbDepartamento)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.cbCargo)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Italic)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Black
        Me.GroupBox5.Location = New System.Drawing.Point(310, 111)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(304, 77)
        Me.GroupBox5.TabIndex = 66
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Información del Servicio"
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(124, 45)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(172, 25)
        Me.cbDepartamento.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 19)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Area de trabajo:"
        '
        'cbCargo
        '
        Me.cbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCargo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Location = New System.Drawing.Point(124, 16)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(172, 25)
        Me.cbCargo.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(3, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 19)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Cargo:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.gpPago)
        Me.GroupBox2.Controls.Add(Me.cbFormaPago)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(4, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 149)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de pagos"
        '
        'gpPago
        '
        Me.gpPago.Controls.Add(Me.txtCuenta)
        Me.gpPago.Controls.Add(Me.Label13)
        Me.gpPago.Controls.Add(Me.cbTipoCuenta)
        Me.gpPago.Controls.Add(Me.Label11)
        Me.gpPago.Controls.Add(Me.cbBanco)
        Me.gpPago.Controls.Add(Me.Label12)
        Me.gpPago.Location = New System.Drawing.Point(4, 41)
        Me.gpPago.Name = "gpPago"
        Me.gpPago.Size = New System.Drawing.Size(291, 102)
        Me.gpPago.TabIndex = 10
        Me.gpPago.TabStop = False
        '
        'txtCuenta
        '
        Me.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuenta.Location = New System.Drawing.Point(102, 72)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.Size = New System.Drawing.Size(183, 25)
        Me.txtCuenta.TabIndex = 5
        Me.txtCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(1, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 19)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Cuenta:"
        '
        'cbTipoCuenta
        '
        Me.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCuenta.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cbTipoCuenta.FormattingEnabled = True
        Me.cbTipoCuenta.Location = New System.Drawing.Point(101, 42)
        Me.cbTipoCuenta.Name = "cbTipoCuenta"
        Me.cbTipoCuenta.Size = New System.Drawing.Size(184, 25)
        Me.cbTipoCuenta.TabIndex = 4
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(1, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Tipo Cuenta:"
        '
        'cbBanco
        '
        Me.cbBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbBanco.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Location = New System.Drawing.Point(101, 13)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(184, 25)
        Me.cbBanco.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(1, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 19)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Banco:"
        '
        'cbFormaPago
        '
        Me.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPago.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic)
        Me.cbFormaPago.FormattingEnabled = True
        Me.cbFormaPago.Location = New System.Drawing.Point(106, 16)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(183, 25)
        Me.cbFormaPago.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 19)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Forma Pago:"
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        Me.ErrorIcono.RightToLeft = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.LTitulo)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 34)
        Me.Panel1.TabIndex = 0
        '
        'LTitulo
        '
        Me.LTitulo.BackColor = System.Drawing.Color.Transparent
        Me.LTitulo.Font = New System.Drawing.Font("Times New Roman", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTitulo.ForeColor = System.Drawing.Color.Black
        Me.LTitulo.Location = New System.Drawing.Point(1, 3)
        Me.LTitulo.Name = "LTitulo"
        Me.LTitulo.Size = New System.Drawing.Size(890, 28)
        Me.LTitulo.TabIndex = 1
        Me.LTitulo.Text = "Empleado"
        Me.LTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(25, 25)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.btNuevo, Me.btBusqueda, Me.btRegistrar, Me.btEditar, Me.btCancelar, Me.btAnular})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 491)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(905, 32)
        Me.ToolStrip1.TabIndex = 1004
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 32)
        '
        'btNuevo
        '
        Me.btNuevo.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNuevo.ForeColor = System.Drawing.Color.Black
        Me.btNuevo.Image = Global.Quality.My.Resources.Resources.Add_File_icon
        Me.btNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btNuevo.Name = "btNuevo"
        Me.btNuevo.Size = New System.Drawing.Size(81, 29)
        Me.btNuevo.Text = "&Nuevo"
        Me.btNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btBusqueda
        '
        Me.btBusqueda.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBusqueda.ForeColor = System.Drawing.Color.Black
        Me.btBusqueda.Image = Global.Quality.My.Resources.Resources.Very_Basic_Search_icon
        Me.btBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btBusqueda.Name = "btBusqueda"
        Me.btBusqueda.Size = New System.Drawing.Size(85, 29)
        Me.btBusqueda.Text = "&Buscar"
        Me.btBusqueda.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btRegistrar
        '
        Me.btRegistrar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRegistrar.ForeColor = System.Drawing.Color.Black
        Me.btRegistrar.Image = Global.Quality.My.Resources.Resources.User_Interface_Save_As_icon
        Me.btRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btRegistrar.Name = "btRegistrar"
        Me.btRegistrar.Size = New System.Drawing.Size(100, 29)
        Me.btRegistrar.Text = "&Registrar"
        Me.btRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btEditar
        '
        Me.btEditar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEditar.ForeColor = System.Drawing.Color.Black
        Me.btEditar.Image = Global.Quality.My.Resources.Resources.Pencil_icon
        Me.btEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btEditar.Name = "btEditar"
        Me.btEditar.Size = New System.Drawing.Size(81, 29)
        Me.btEditar.Text = "&Editar"
        Me.btEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btCancelar
        '
        Me.btCancelar.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancelar.ForeColor = System.Drawing.Color.Black
        Me.btCancelar.Image = Global.Quality.My.Resources.Resources.Arrows_Right_2_icon
        Me.btCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btCancelar.Name = "btCancelar"
        Me.btCancelar.Size = New System.Drawing.Size(99, 29)
        Me.btCancelar.Text = "&Cancelar"
        Me.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btAnular
        '
        Me.btAnular.Font = New System.Drawing.Font("Times New Roman", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btAnular.ForeColor = System.Drawing.Color.Black
        Me.btAnular.Image = Global.Quality.My.Resources.Resources.Files_Delete_File_icon
        Me.btAnular.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btAnular.Name = "btAnular"
        Me.btAnular.Size = New System.Drawing.Size(86, 29)
        Me.btAnular.Text = "&Anular"
        Me.btAnular.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'pFoto
        '
        Me.pFoto.BackgroundImage = Global.Quality.My.Resources.Resources.Users_User_Male_3_icon
        Me.pFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pFoto.Location = New System.Drawing.Point(3, 16)
        Me.pFoto.Name = "pFoto"
        Me.pFoto.Size = New System.Drawing.Size(94, 83)
        Me.pFoto.TabIndex = 0
        Me.pFoto.TabStop = False
        '
        'bttercero
        '
        Me.bttercero.BackgroundImage = Global.Quality.My.Resources.Resources.Very_Basic_Search_icon
        Me.bttercero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bttercero.Location = New System.Drawing.Point(754, 15)
        Me.bttercero.Name = "bttercero"
        Me.bttercero.Size = New System.Drawing.Size(26, 25)
        Me.bttercero.TabIndex = 60033
        Me.bttercero.UseVisualStyleBackColor = True
        '
        'FormEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(905, 523)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Location = New System.Drawing.Point(3000, 1000)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(921, 562)
        Me.MinimumSize = New System.Drawing.Size(921, 562)
        Me.Name = "FormEmpleado"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbInform.ResumeLayout(False)
        Me.gbInform.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GbInform_D.ResumeLayout(False)
        CType(Me.dgvParametro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gpPagare.ResumeLayout(False)
        Me.gpPagare.PerformLayout()
        CType(Me.NumComision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpUsuario.ResumeLayout(False)
        Me.gpUsuario.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gpPago.ResumeLayout(False)
        Me.gpPago.PerformLayout()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Panel1 As Panel
    Public WithEvents LTitulo As Label
    Friend WithEvents gbInform As GroupBox
    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
    Public WithEvents GroupBox3 As GroupBox
    Friend WithEvents pictImagen As PictureBox
    Friend WithEvents GbInform_D As GroupBox
    Public WithEvents dgvParametro As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents btBuscar As ToolStripButton
    Public WithEvents Label5 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label3 As Label
    Public WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btBuscarPersona As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents cbDepartamento As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents gpPago As GroupBox
    Public WithEvents txtCuenta As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cbTipoCuenta As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbBanco As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbFormaPago As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gpUsuario As GroupBox
    Public WithEvents txtUsuario As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbPerfil As ComboBox
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtDireccion As Label
    Friend WithEvents txtNombre As Label
    Friend WithEvents txtCelular As Label
    Friend WithEvents txtTelefono As Label
    Friend WithEvents txtIdentificacion As Label
    Friend WithEvents gpPagare As GroupBox
    Public WithEvents txtSalario As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cbTipoSalario As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents NumComision As NumericUpDown
    Public WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Public WithEvents btNuevo As ToolStripButton
    Public WithEvents btBusqueda As ToolStripButton
    Public WithEvents btRegistrar As ToolStripButton
    Public WithEvents btEditar As ToolStripButton
    Public WithEvents btCancelar As ToolStripButton
    Public WithEvents btAnular As ToolStripButton
    Public WithEvents bttercero As Button
    Friend WithEvents pFoto As PictureBox
End Class
