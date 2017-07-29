<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmClientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientes))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblVerCliente = New System.Windows.Forms.Label()
        Me.BtnRegresarMenu = New System.Windows.Forms.Button()
        Me.LblAgregarCliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TcCliente = New System.Windows.Forms.TabControl()
        Me.TpAgregar = New System.Windows.Forms.TabPage()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CboTipoContrato = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.MsktTelf1 = New System.Windows.Forms.MaskedTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RdbActibo = New System.Windows.Forms.RadioButton()
        Me.RdbInactivo = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombreContacto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNombreCompañia = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.TpVer = New System.Windows.Forms.TabPage()
        Me.LsvCliente = New System.Windows.Forms.ListView()
        Me.ChIdCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreCompañia = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChNombreContacto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChDireccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChTelefono = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChIdContratoCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ChEstadoCliente = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CsmCliente = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TcCliente.SuspendLayout()
        Me.TpAgregar.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.TpVer.SuspendLayout()
        Me.CsmCliente.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel3.Location = New System.Drawing.Point(-1, 661)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1143, 11)
        Me.Panel3.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1155, 38)
        Me.Panel2.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblVerCliente)
        Me.Panel1.Controls.Add(Me.BtnRegresarMenu)
        Me.Panel1.Controls.Add(Me.LblAgregarCliente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(20, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 186)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(12, 20)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(14, 111)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LblVerCliente
        '
        Me.LblVerCliente.AutoSize = True
        Me.LblVerCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblVerCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVerCliente.Location = New System.Drawing.Point(38, 111)
        Me.LblVerCliente.Name = "LblVerCliente"
        Me.LblVerCliente.Size = New System.Drawing.Size(84, 16)
        Me.LblVerCliente.TabIndex = 1
        Me.LblVerCliente.Text = "Ver Cliente"
        '
        'BtnRegresarMenu
        '
        Me.BtnRegresarMenu.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnRegresarMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresarMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnRegresarMenu.Location = New System.Drawing.Point(3, 12)
        Me.BtnRegresarMenu.Name = "BtnRegresarMenu"
        Me.BtnRegresarMenu.Size = New System.Drawing.Size(225, 29)
        Me.BtnRegresarMenu.TabIndex = 0
        Me.BtnRegresarMenu.Text = "Regresar Menú Principal "
        Me.BtnRegresarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresarMenu.UseVisualStyleBackColor = False
        '
        'LblAgregarCliente
        '
        Me.LblAgregarCliente.AutoSize = True
        Me.LblAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregarCliente.Location = New System.Drawing.Point(38, 82)
        Me.LblAgregarCliente.Name = "LblAgregarCliente"
        Me.LblAgregarCliente.Size = New System.Drawing.Size(165, 16)
        Me.LblAgregarCliente.TabIndex = 0
        Me.LblAgregarCliente.Text = "Agregar Nuevo Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(20, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "GESTION DE DATOS"
        '
        'TcCliente
        '
        Me.TcCliente.Controls.Add(Me.TpAgregar)
        Me.TcCliente.Controls.Add(Me.TpVer)
        Me.TcCliente.Location = New System.Drawing.Point(268, 71)
        Me.TcCliente.Name = "TcCliente"
        Me.TcCliente.SelectedIndex = 0
        Me.TcCliente.Size = New System.Drawing.Size(871, 574)
        Me.TcCliente.TabIndex = 6
        Me.TcCliente.Visible = False
        '
        'TpAgregar
        '
        Me.TpAgregar.Controls.Add(Me.txtIdCliente)
        Me.TpAgregar.Controls.Add(Me.Label8)
        Me.TpAgregar.Controls.Add(Me.CboTipoContrato)
        Me.TpAgregar.Controls.Add(Me.Label7)
        Me.TpAgregar.Controls.Add(Me.PictureBox3)
        Me.TpAgregar.Controls.Add(Me.PictureBox2)
        Me.TpAgregar.Controls.Add(Me.BtnGuardar)
        Me.TpAgregar.Controls.Add(Me.MsktTelf1)
        Me.TpAgregar.Controls.Add(Me.Panel4)
        Me.TpAgregar.Controls.Add(Me.TxtDireccion)
        Me.TpAgregar.Controls.Add(Me.Label4)
        Me.TpAgregar.Controls.Add(Me.TxtNombreContacto)
        Me.TpAgregar.Controls.Add(Me.Label5)
        Me.TpAgregar.Controls.Add(Me.Label3)
        Me.TpAgregar.Controls.Add(Me.Label2)
        Me.TpAgregar.Controls.Add(Me.TxtNombreCompañia)
        Me.TpAgregar.Controls.Add(Me.btnModificar)
        Me.TpAgregar.Location = New System.Drawing.Point(4, 22)
        Me.TpAgregar.Name = "TpAgregar"
        Me.TpAgregar.Padding = New System.Windows.Forms.Padding(3)
        Me.TpAgregar.Size = New System.Drawing.Size(863, 548)
        Me.TpAgregar.TabIndex = 1
        Me.TpAgregar.Text = "Agregar Cliente"
        Me.TpAgregar.UseVisualStyleBackColor = True
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Location = New System.Drawing.Point(228, 46)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(67, 20)
        Me.txtIdCliente.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(125, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "IdCliente:"
        '
        'CboTipoContrato
        '
        Me.CboTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoContrato.FormattingEnabled = True
        Me.CboTipoContrato.Location = New System.Drawing.Point(228, 252)
        Me.CboTipoContrato.Name = "CboTipoContrato"
        Me.CboTipoContrato.Size = New System.Drawing.Size(147, 21)
        Me.CboTipoContrato.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(73, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 20)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "IdContratoCliente:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(704, 460)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(529, 460)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 18)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnGuardar.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnGuardar.Location = New System.Drawing.Point(687, 449)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(156, 40)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'MsktTelf1
        '
        Me.MsktTelf1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MsktTelf1.Location = New System.Drawing.Point(228, 196)
        Me.MsktTelf1.Mask = "9999-9999"
        Me.MsktTelf1.Name = "MsktTelf1"
        Me.MsktTelf1.Size = New System.Drawing.Size(147, 22)
        Me.MsktTelf1.TabIndex = 3
        Me.MsktTelf1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.RdbActibo)
        Me.Panel4.Controls.Add(Me.RdbInactivo)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Location = New System.Drawing.Point(610, 89)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(233, 81)
        Me.Panel4.TabIndex = 4
        '
        'RdbActibo
        '
        Me.RdbActibo.AutoSize = True
        Me.RdbActibo.Location = New System.Drawing.Point(136, 19)
        Me.RdbActibo.Name = "RdbActibo"
        Me.RdbActibo.Size = New System.Drawing.Size(55, 17)
        Me.RdbActibo.TabIndex = 0
        Me.RdbActibo.TabStop = True
        Me.RdbActibo.Text = "Activo"
        Me.RdbActibo.UseVisualStyleBackColor = True
        '
        'RdbInactivo
        '
        Me.RdbInactivo.AutoSize = True
        Me.RdbInactivo.Location = New System.Drawing.Point(136, 42)
        Me.RdbInactivo.Name = "RdbInactivo"
        Me.RdbInactivo.Size = New System.Drawing.Size(63, 17)
        Me.RdbInactivo.TabIndex = 1
        Me.RdbInactivo.TabStop = True
        Me.RdbInactivo.Text = "Inactivo"
        Me.RdbInactivo.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado Cliente:"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(228, 305)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(385, 86)
        Me.TxtDireccion.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Derección:"
        '
        'TxtNombreContacto
        '
        Me.TxtNombreContacto.Location = New System.Drawing.Point(228, 144)
        Me.TxtNombreContacto.Name = "TxtNombreContacto"
        Me.TxtNombreContacto.Size = New System.Drawing.Size(328, 20)
        Me.TxtNombreContacto.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(129, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Teléfono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre Contacto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Compañia:"
        '
        'TxtNombreCompañia
        '
        Me.TxtNombreCompañia.Location = New System.Drawing.Point(228, 93)
        Me.TxtNombreCompañia.Name = "TxtNombreCompañia"
        Me.TxtNombreCompañia.Size = New System.Drawing.Size(328, 20)
        Me.TxtNombreCompañia.TabIndex = 1
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.LawnGreen
        Me.btnModificar.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnModificar.Location = New System.Drawing.Point(510, 449)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(156, 40)
        Me.btnModificar.TabIndex = 7
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'TpVer
        '
        Me.TpVer.Controls.Add(Me.LsvCliente)
        Me.TpVer.Location = New System.Drawing.Point(4, 22)
        Me.TpVer.Name = "TpVer"
        Me.TpVer.Padding = New System.Windows.Forms.Padding(3)
        Me.TpVer.Size = New System.Drawing.Size(863, 548)
        Me.TpVer.TabIndex = 2
        Me.TpVer.Text = "Clientes"
        Me.TpVer.UseVisualStyleBackColor = True
        '
        'LsvCliente
        '
        Me.LsvCliente.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ChIdCliente, Me.ChNombreCompañia, Me.ChNombreContacto, Me.ChDireccion, Me.ChTelefono, Me.ChIdContratoCliente, Me.ChEstadoCliente})
        Me.LsvCliente.ContextMenuStrip = Me.CsmCliente
        Me.LsvCliente.GridLines = True
        Me.LsvCliente.Location = New System.Drawing.Point(19, 20)
        Me.LsvCliente.Name = "LsvCliente"
        Me.LsvCliente.Size = New System.Drawing.Size(824, 509)
        Me.LsvCliente.TabIndex = 2
        Me.LsvCliente.UseCompatibleStateImageBehavior = False
        Me.LsvCliente.View = System.Windows.Forms.View.Details
        '
        'ChIdCliente
        '
        Me.ChIdCliente.Text = "IdCliente"
        '
        'ChNombreCompañia
        '
        Me.ChNombreCompañia.Text = "NombreCompañia"
        Me.ChNombreCompañia.Width = 102
        '
        'ChNombreContacto
        '
        Me.ChNombreContacto.Text = "NombreContacto"
        Me.ChNombreContacto.Width = 98
        '
        'ChDireccion
        '
        Me.ChDireccion.Text = "Direccion"
        '
        'ChTelefono
        '
        Me.ChTelefono.Text = "Telefono"
        '
        'ChIdContratoCliente
        '
        Me.ChIdContratoCliente.Text = "ContratoCliente"
        Me.ChIdContratoCliente.Width = 94
        '
        'ChEstadoCliente
        '
        Me.ChEstadoCliente.Text = "EstadoCliente"
        Me.ChEstadoCliente.Width = 88
        '
        'CsmCliente
        '
        Me.CsmCliente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.CsmCliente.Name = "CsmCliente"
        Me.CsmCliente.Size = New System.Drawing.Size(105, 26)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 672)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TcCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TcCliente.ResumeLayout(False)
        Me.TpAgregar.ResumeLayout(False)
        Me.TpAgregar.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TpVer.ResumeLayout(False)
        Me.CsmCliente.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblVerCliente As Label
    Friend WithEvents BtnRegresarMenu As Button
    Friend WithEvents LblAgregarCliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TcCliente As TabControl
    Friend WithEvents TpAgregar As TabPage
    Friend WithEvents CboTipoContrato As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents MsktTelf1 As MaskedTextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RdbActibo As RadioButton
    Friend WithEvents RdbInactivo As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombreContacto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNombreCompañia As TextBox
    Friend WithEvents TpVer As TabPage
    Friend WithEvents LsvCliente As ListView
    Friend WithEvents ChIdCliente As ColumnHeader
    Friend WithEvents ChNombreCompañia As ColumnHeader
    Friend WithEvents ChNombreContacto As ColumnHeader
    Friend WithEvents ChDireccion As ColumnHeader
    Friend WithEvents ChTelefono As ColumnHeader
    Friend WithEvents ChIdContratoCliente As ColumnHeader
    Friend WithEvents ChEstadoCliente As ColumnHeader
    Friend WithEvents CsmCliente As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
