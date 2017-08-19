<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInventario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInventario))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblVerArmas = New System.Windows.Forms.Label()
        Me.BtnRegresarMenu = New System.Windows.Forms.Button()
        Me.LblAgregarArma = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TcArma = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.DtpPermiso = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RdbActivo = New System.Windows.Forms.RadioButton()
        Me.RdbInactivo = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PbxBuscar = New System.Windows.Forms.PictureBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.cboPaisFabricacion = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboTipoArma = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboModelo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtContrato = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.MskCalibre = New System.Windows.Forms.MaskedTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvArmas = New System.Windows.Forms.DataGridView()
        Me.CmsArmas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Planillas = New nuevo.Planillas()
        Me.DataTable1TableAdapter = New nuevo.PlanillasTableAdapters.DataTable1TableAdapter()
        Me.TableAdapterManager = New nuevo.PlanillasTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TcArma.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.PbxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvArmas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsArmas.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1153, 38)
        Me.Panel2.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblVerArmas)
        Me.Panel1.Controls.Add(Me.BtnRegresarMenu)
        Me.Panel1.Controls.Add(Me.LblAgregarArma)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(19, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 186)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(12, 16)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(14, 110)
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
        'LblVerArmas
        '
        Me.LblVerArmas.AutoSize = True
        Me.LblVerArmas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblVerArmas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblVerArmas.Location = New System.Drawing.Point(38, 110)
        Me.LblVerArmas.Name = "LblVerArmas"
        Me.LblVerArmas.Size = New System.Drawing.Size(152, 16)
        Me.LblVerArmas.TabIndex = 10
        Me.LblVerArmas.Text = "Ver Inventario Armas"
        '
        'BtnRegresarMenu
        '
        Me.BtnRegresarMenu.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnRegresarMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRegresarMenu.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRegresarMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BtnRegresarMenu.Location = New System.Drawing.Point(3, 12)
        Me.BtnRegresarMenu.Name = "BtnRegresarMenu"
        Me.BtnRegresarMenu.Size = New System.Drawing.Size(225, 29)
        Me.BtnRegresarMenu.TabIndex = 0
        Me.BtnRegresarMenu.Text = "Regresar Menú Principal "
        Me.BtnRegresarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRegresarMenu.UseVisualStyleBackColor = False
        '
        'LblAgregarArma
        '
        Me.LblAgregarArma.AutoSize = True
        Me.LblAgregarArma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAgregarArma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.HelpProvider1.SetHelpNavigator(Me.LblAgregarArma, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.LblAgregarArma.Location = New System.Drawing.Point(38, 82)
        Me.LblAgregarArma.Name = "LblAgregarArma"
        Me.HelpProvider1.SetShowHelp(Me.LblAgregarArma, True)
        Me.LblAgregarArma.Size = New System.Drawing.Size(153, 16)
        Me.LblAgregarArma.TabIndex = 7
        Me.LblAgregarArma.Text = "Agregar Nueva Arma"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(20, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "GESTION DE DATOS"
        '
        'TcArma
        '
        Me.TcArma.Controls.Add(Me.TabPage2)
        Me.TcArma.Controls.Add(Me.TabPage3)
        Me.TcArma.Location = New System.Drawing.Point(267, 71)
        Me.TcArma.Name = "TcArma"
        Me.TcArma.SelectedIndex = 0
        Me.TcArma.Size = New System.Drawing.Size(871, 574)
        Me.TcArma.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.BtnModificar)
        Me.TabPage2.Controls.Add(Me.DtpPermiso)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.RdbActivo)
        Me.TabPage2.Controls.Add(Me.RdbInactivo)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.PbxBuscar)
        Me.TabPage2.Controls.Add(Me.BtnGuardar)
        Me.TabPage2.Controls.Add(Me.cboPaisFabricacion)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.CboTipoArma)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.cboModelo)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.TxtContrato)
        Me.TabPage2.Controls.Add(Me.txtSerie)
        Me.TabPage2.Controls.Add(Me.MskCalibre)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(863, 548)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Agregar Arma"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnModificar.Location = New System.Drawing.Point(477, 502)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(156, 40)
        Me.BtnModificar.TabIndex = 65
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'DtpPermiso
        '
        Me.DtpPermiso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPermiso.Location = New System.Drawing.Point(403, 374)
        Me.DtpPermiso.Name = "DtpPermiso"
        Me.DtpPermiso.Size = New System.Drawing.Size(121, 20)
        Me.DtpPermiso.TabIndex = 64
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(196, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(201, 36)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Fecha de terminacion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Permiso de operación"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RdbActivo
        '
        Me.RdbActivo.AutoSize = True
        Me.RdbActivo.Location = New System.Drawing.Point(423, 422)
        Me.RdbActivo.Name = "RdbActivo"
        Me.RdbActivo.Size = New System.Drawing.Size(55, 17)
        Me.RdbActivo.TabIndex = 6
        Me.RdbActivo.TabStop = True
        Me.RdbActivo.Text = "Activo"
        Me.RdbActivo.UseVisualStyleBackColor = True
        '
        'RdbInactivo
        '
        Me.RdbInactivo.AutoSize = True
        Me.RdbInactivo.Location = New System.Drawing.Point(423, 445)
        Me.RdbInactivo.Name = "RdbInactivo"
        Me.RdbInactivo.Size = New System.Drawing.Size(63, 17)
        Me.RdbInactivo.TabIndex = 7
        Me.RdbInactivo.TabStop = True
        Me.RdbInactivo.Text = "Inactivo"
        Me.RdbInactivo.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(292, 422)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 18)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Estado Arma"
        '
        'PbxBuscar
        '
        Me.PbxBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxBuscar.Image = CType(resources.GetObject("PbxBuscar.Image"), System.Drawing.Image)
        Me.PbxBuscar.Location = New System.Drawing.Point(509, 322)
        Me.PbxBuscar.Name = "PbxBuscar"
        Me.PbxBuscar.Size = New System.Drawing.Size(27, 23)
        Me.PbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxBuscar.TabIndex = 60
        Me.PbxBuscar.TabStop = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGuardar.Location = New System.Drawing.Point(639, 502)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(156, 40)
        Me.BtnGuardar.TabIndex = 8
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'cboPaisFabricacion
        '
        Me.cboPaisFabricacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPaisFabricacion.FormattingEnabled = True
        Me.cboPaisFabricacion.Location = New System.Drawing.Point(403, 274)
        Me.cboPaisFabricacion.Name = "cboPaisFabricacion"
        Me.cboPaisFabricacion.Size = New System.Drawing.Size(121, 21)
        Me.cboPaisFabricacion.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(331, 323)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Contrato"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(240, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Pais de Fabricacion"
        '
        'CboTipoArma
        '
        Me.CboTipoArma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoArma.FormattingEnabled = True
        Me.CboTipoArma.Location = New System.Drawing.Point(403, 225)
        Me.CboTipoArma.Name = "CboTipoArma"
        Me.CboTipoArma.Size = New System.Drawing.Size(121, 21)
        Me.CboTipoArma.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(289, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo de Arma"
        '
        'cboModelo
        '
        Me.cboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboModelo.FormattingEnabled = True
        Me.cboModelo.Location = New System.Drawing.Point(403, 176)
        Me.cboModelo.Name = "cboModelo"
        Me.cboModelo.Size = New System.Drawing.Size(121, 21)
        Me.cboModelo.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(333, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Modelo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(422, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "mm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Calibre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(350, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Serie"
        '
        'TxtContrato
        '
        Me.TxtContrato.Enabled = False
        Me.TxtContrato.Location = New System.Drawing.Point(403, 324)
        Me.TxtContrato.Name = "TxtContrato"
        Me.TxtContrato.Size = New System.Drawing.Size(100, 20)
        Me.TxtContrato.TabIndex = 5
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(403, 87)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(100, 20)
        Me.txtSerie.TabIndex = 0
        '
        'MskCalibre
        '
        Me.MskCalibre.Location = New System.Drawing.Point(403, 129)
        Me.MskCalibre.Mask = "99"
        Me.MskCalibre.Name = "MskCalibre"
        Me.MskCalibre.Size = New System.Drawing.Size(53, 20)
        Me.MskCalibre.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.DgvArmas)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(863, 548)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inventario Armas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvArmas
        '
        Me.DgvArmas.AutoGenerateColumns = False
        Me.DgvArmas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvArmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArmas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn9})
        Me.DgvArmas.ContextMenuStrip = Me.CmsArmas
        Me.DgvArmas.DataSource = Me.DataTable1BindingSource
        Me.DgvArmas.Location = New System.Drawing.Point(10, 15)
        Me.DgvArmas.Name = "DgvArmas"
        Me.DgvArmas.ReadOnly = True
        Me.DgvArmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArmas.Size = New System.Drawing.Size(847, 464)
        Me.DgvArmas.TabIndex = 89
        '
        'CmsArmas
        '
        Me.CmsArmas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.CmsArmas.Name = "CmsArmas"
        Me.CmsArmas.Size = New System.Drawing.Size(126, 26)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LawnGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(657, 496)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 40)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Imprimir Reporte"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel3.Location = New System.Drawing.Point(0, 665)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1143, 11)
        Me.Panel3.TabIndex = 6
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(38, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(153, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Permisos por Expirar"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdArma"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdArma"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Serie"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Serie"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Calibre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Calibre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TipoArma"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TipoArma"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LugarFabricacion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "LugarFabricacion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IdContratoCliente"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IdContratoCliente"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Estado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Estado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "FechaPermiso"
        Me.DataGridViewTextBoxColumn9.HeaderText = "FechaPermiso"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Planillas
        '
        'Planillas
        '
        Me.Planillas.DataSetName = "Planillas"
        Me.Planillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.ContratoEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.DetallePlanillaTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        'Me.TableAdapterManager.InventarioArmasTableAdapter = Nothing
        Me.TableAdapterManager.PlanillasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nuevo.PlanillasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 676)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TcArma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TcArma.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PbxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvArmas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsArmas.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblVerArmas As Label
    Friend WithEvents BtnRegresarMenu As Button
    Friend WithEvents LblAgregarArma As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TcArma As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents MskCalibre As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSerie As TextBox
    Friend WithEvents cboPaisFabricacion As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CboTipoArma As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboModelo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtContrato As TextBox
    Friend WithEvents PbxBuscar As PictureBox
    Friend WithEvents RdbActivo As RadioButton
    Friend WithEvents RdbInactivo As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label9 As Label
    Friend WithEvents DtpPermiso As DateTimePicker
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents Planillas As Planillas
    Friend WithEvents DataTable1TableAdapter As PlanillasTableAdapters.DataTable1TableAdapter
    Friend WithEvents TableAdapterManager As PlanillasTableAdapters.TableAdapterManager
    Friend WithEvents DgvArmas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents CmsArmas As ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnModificar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label11 As Label
End Class
