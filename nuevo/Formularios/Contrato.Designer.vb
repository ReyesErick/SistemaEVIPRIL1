<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmContrato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContrato))
        Me.TpContrato = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PbxBuscar = New System.Windows.Forms.PictureBox()
        Me.TxtNumIdentidad = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.CboTipoContrato = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboTipoEmpleado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtsueldo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TxtCliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DgvContrato = New System.Windows.Forms.DataGridView()
        Me.CmsContrato = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TpAsignacion = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CboContratoCliente = New System.Windows.Forms.ComboBox()
        Me.PbxBuscarGuardia = New System.Windows.Forms.PictureBox()
        Me.TxtGuardias = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblGuardias = New System.Windows.Forms.Label()
        Me.DgvGuardias = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.LblAsignar = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblVerContratoClien = New System.Windows.Forms.Label()
        Me.BtnRegresarMenu = New System.Windows.Forms.Button()
        Me.LblVerContratoEmple = New System.Windows.Forms.Label()
        Me.LblAgregarContratoClien = New System.Windows.Forms.Label()
        Me.LblAgregarContratoEmp = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TpContrato.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PbxBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvContrato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsContrato.SuspendLayout()
        Me.TpAsignacion.SuspendLayout()
        CType(Me.PbxBuscarGuardia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvGuardias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TpContrato
        '
        Me.TpContrato.Controls.Add(Me.TabPage1)
        Me.TpContrato.Controls.Add(Me.TabPage2)
        Me.TpContrato.Controls.Add(Me.TabPage3)
        Me.TpContrato.Controls.Add(Me.TpAsignacion)
        Me.TpContrato.Location = New System.Drawing.Point(260, 66)
        Me.TpContrato.Name = "TpContrato"
        Me.TpContrato.SelectedIndex = 0
        Me.TpContrato.Size = New System.Drawing.Size(871, 574)
        Me.TpContrato.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnModificar)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.PbxBuscar)
        Me.TabPage1.Controls.Add(Me.TxtNumIdentidad)
        Me.TabPage1.Controls.Add(Me.BtnGuardar)
        Me.TabPage1.Controls.Add(Me.CboTipoContrato)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.CboTipoEmpleado)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.txtsueldo)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dtpfinal)
        Me.TabPage1.Controls.Add(Me.dtpInicio)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(863, 548)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contrato Empleado"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnModificar.Location = New System.Drawing.Point(471, 431)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(156, 40)
        Me.BtnModificar.TabIndex = 63
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(313, 325)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 18)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Num Identidad:"
        '
        'PbxBuscar
        '
        Me.PbxBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxBuscar.Image = CType(resources.GetObject("PbxBuscar.Image"), System.Drawing.Image)
        Me.PbxBuscar.Location = New System.Drawing.Point(600, 324)
        Me.PbxBuscar.Name = "PbxBuscar"
        Me.PbxBuscar.Size = New System.Drawing.Size(27, 23)
        Me.PbxBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxBuscar.TabIndex = 61
        Me.PbxBuscar.TabStop = False
        '
        'TxtNumIdentidad
        '
        Me.TxtNumIdentidad.Enabled = False
        Me.TxtNumIdentidad.Location = New System.Drawing.Point(439, 326)
        Me.TxtNumIdentidad.Name = "TxtNumIdentidad"
        Me.TxtNumIdentidad.Size = New System.Drawing.Size(155, 20)
        Me.TxtNumIdentidad.TabIndex = 5
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGuardar.Location = New System.Drawing.Point(630, 431)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(156, 40)
        Me.BtnGuardar.TabIndex = 6
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'CboTipoContrato
        '
        Me.CboTipoContrato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoContrato.FormattingEnabled = True
        Me.CboTipoContrato.Location = New System.Drawing.Point(439, 278)
        Me.CboTipoContrato.Name = "CboTipoContrato"
        Me.CboTipoContrato.Size = New System.Drawing.Size(155, 21)
        Me.CboTipoContrato.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(293, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo de Contrato:"
        '
        'CboTipoEmpleado
        '
        Me.CboTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoEmpleado.FormattingEnabled = True
        Me.CboTipoEmpleado.Location = New System.Drawing.Point(439, 231)
        Me.CboTipoEmpleado.Name = "CboTipoEmpleado"
        Me.CboTipoEmpleado.Size = New System.Drawing.Size(155, 21)
        Me.CboTipoEmpleado.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(284, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Tipo de Empleado:"
        '
        'txtsueldo
        '
        Me.txtsueldo.Location = New System.Drawing.Point(439, 181)
        Me.txtsueldo.Name = "txtsueldo"
        Me.txtsueldo.Size = New System.Drawing.Size(115, 20)
        Me.txtsueldo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(325, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sueldo Base:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(325, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha de Final:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(306, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Inicio:"
        '
        'dtpfinal
        '
        Me.dtpfinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfinal.Location = New System.Drawing.Point(439, 125)
        Me.dtpfinal.Name = "dtpfinal"
        Me.dtpfinal.Size = New System.Drawing.Size(200, 20)
        Me.dtpfinal.TabIndex = 1
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(439, 70)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpInicio.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox8)
        Me.TabPage2.Controls.Add(Me.TxtCliente)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.txtObservacion)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtMonto)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.dtpFechaFinal)
        Me.TabPage2.Controls.Add(Me.dtpFechaInicio)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(863, 548)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Contrato Cliente"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(559, 221)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(27, 23)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 62
        Me.PictureBox8.TabStop = False
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(370, 224)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(172, 20)
        Me.TxtCliente.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(299, 223)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 18)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Cliente:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LawnGreen
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(667, 481)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(370, 284)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(276, 114)
        Me.txtObservacion.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(268, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 18)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Observacion:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(370, 169)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(115, 20)
        Me.txtMonto.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "MontoEstipulado:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(241, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 18)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fecha de Final:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(237, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Fecha de Inicio:"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(370, 113)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaFinal.TabIndex = 1
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(370, 58)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaInicio.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.DgvContrato)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(863, 548)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Contratos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LawnGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(676, 489)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(181, 40)
        Me.Button3.TabIndex = 89
        Me.Button3.Text = "Imprimir Reporte"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'DgvContrato
        '
        Me.DgvContrato.AllowUserToAddRows = False
        Me.DgvContrato.AllowUserToDeleteRows = False
        Me.DgvContrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvContrato.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgvContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvContrato.ContextMenuStrip = Me.CmsContrato
        Me.DgvContrato.Location = New System.Drawing.Point(6, 6)
        Me.DgvContrato.Name = "DgvContrato"
        Me.DgvContrato.ReadOnly = True
        Me.DgvContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvContrato.Size = New System.Drawing.Size(851, 464)
        Me.DgvContrato.TabIndex = 0
        '
        'CmsContrato
        '
        Me.CmsContrato.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarToolStripMenuItem})
        Me.CmsContrato.Name = "CmsContrato"
        Me.CmsContrato.Size = New System.Drawing.Size(126, 26)
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'TpAsignacion
        '
        Me.TpAsignacion.Controls.Add(Me.Label12)
        Me.TpAsignacion.Controls.Add(Me.CboContratoCliente)
        Me.TpAsignacion.Controls.Add(Me.PbxBuscarGuardia)
        Me.TpAsignacion.Controls.Add(Me.TxtGuardias)
        Me.TpAsignacion.Controls.Add(Me.Button2)
        Me.TpAsignacion.Controls.Add(Me.LblGuardias)
        Me.TpAsignacion.Controls.Add(Me.DgvGuardias)
        Me.TpAsignacion.Location = New System.Drawing.Point(4, 22)
        Me.TpAsignacion.Name = "TpAsignacion"
        Me.TpAsignacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TpAsignacion.Size = New System.Drawing.Size(863, 548)
        Me.TpAsignacion.TabIndex = 3
        Me.TpAsignacion.Text = "Asignacion de Guardias"
        Me.TpAsignacion.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(103, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 18)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "Contratos:"
        '
        'CboContratoCliente
        '
        Me.CboContratoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboContratoCliente.FormattingEnabled = True
        Me.CboContratoCliente.Location = New System.Drawing.Point(197, 36)
        Me.CboContratoCliente.Name = "CboContratoCliente"
        Me.CboContratoCliente.Size = New System.Drawing.Size(188, 21)
        Me.CboContratoCliente.TabIndex = 0
        '
        'PbxBuscarGuardia
        '
        Me.PbxBuscarGuardia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbxBuscarGuardia.Image = CType(resources.GetObject("PbxBuscarGuardia.Image"), System.Drawing.Image)
        Me.PbxBuscarGuardia.Location = New System.Drawing.Point(732, 33)
        Me.PbxBuscarGuardia.Name = "PbxBuscarGuardia"
        Me.PbxBuscarGuardia.Size = New System.Drawing.Size(27, 23)
        Me.PbxBuscarGuardia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbxBuscarGuardia.TabIndex = 67
        Me.PbxBuscarGuardia.TabStop = False
        '
        'TxtGuardias
        '
        Me.TxtGuardias.Enabled = False
        Me.TxtGuardias.Location = New System.Drawing.Point(556, 36)
        Me.TxtGuardias.Name = "TxtGuardias"
        Me.TxtGuardias.Size = New System.Drawing.Size(170, 20)
        Me.TxtGuardias.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LawnGreen
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(581, 414)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 38)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Asignar Guardia"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LblGuardias
        '
        Me.LblGuardias.AutoSize = True
        Me.LblGuardias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblGuardias.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGuardias.Location = New System.Drawing.Point(469, 35)
        Me.LblGuardias.Name = "LblGuardias"
        Me.LblGuardias.Size = New System.Drawing.Size(81, 18)
        Me.LblGuardias.TabIndex = 64
        Me.LblGuardias.Text = "Guardias:"
        '
        'DgvGuardias
        '
        Me.DgvGuardias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvGuardias.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DgvGuardias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvGuardias.Location = New System.Drawing.Point(106, 96)
        Me.DgvGuardias.Name = "DgvGuardias"
        Me.DgvGuardias.Size = New System.Drawing.Size(653, 298)
        Me.DgvGuardias.TabIndex = 63
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.PictureBox10)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.PictureBox9)
        Me.Panel1.Controls.Add(Me.LblAsignar)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblVerContratoClien)
        Me.Panel1.Controls.Add(Me.BtnRegresarMenu)
        Me.Panel1.Controls.Add(Me.LblVerContratoEmple)
        Me.Panel1.Controls.Add(Me.LblAgregarContratoClien)
        Me.Panel1.Controls.Add(Me.LblAgregarContratoEmp)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(12, 66)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(242, 271)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox10
        '
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(6, 217)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 20
        Me.PictureBox10.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(30, 214)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(207, 32)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "Ver Contratos de Empleados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "por Expirar "
        '
        'PictureBox9
        '
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(6, 185)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 17
        Me.PictureBox9.TabStop = False
        '
        'LblAsignar
        '
        Me.LblAsignar.AutoSize = True
        Me.LblAsignar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAsignar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAsignar.Location = New System.Drawing.Point(30, 185)
        Me.LblAsignar.Name = "LblAsignar"
        Me.LblAsignar.Size = New System.Drawing.Size(128, 16)
        Me.LblAsignar.TabIndex = 18
        Me.LblAsignar.Text = "Asignar Guardias"
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
        Me.PictureBox4.Location = New System.Drawing.Point(6, 159)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(6, 107)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(6, 133)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 82)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LblVerContratoClien
        '
        Me.LblVerContratoClien.AutoSize = True
        Me.LblVerContratoClien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblVerContratoClien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVerContratoClien.Location = New System.Drawing.Point(30, 159)
        Me.LblVerContratoClien.Name = "LblVerContratoClien"
        Me.LblVerContratoClien.Size = New System.Drawing.Size(146, 16)
        Me.LblVerContratoClien.TabIndex = 3
        Me.LblVerContratoClien.Text = "Ver Contrato Cliente"
        '
        'BtnRegresarMenu
        '
        Me.BtnRegresarMenu.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnRegresarMenu.Cursor = System.Windows.Forms.Cursors.Hand
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
        'LblVerContratoEmple
        '
        Me.LblVerContratoEmple.AutoSize = True
        Me.LblVerContratoEmple.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblVerContratoEmple.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVerContratoEmple.Location = New System.Drawing.Point(30, 133)
        Me.LblVerContratoEmple.Name = "LblVerContratoEmple"
        Me.LblVerContratoEmple.Size = New System.Drawing.Size(173, 16)
        Me.LblVerContratoEmple.TabIndex = 2
        Me.LblVerContratoEmple.Text = "Ver Contrato Empleado "
        '
        'LblAgregarContratoClien
        '
        Me.LblAgregarContratoClien.AutoSize = True
        Me.LblAgregarContratoClien.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAgregarContratoClien.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregarContratoClien.Location = New System.Drawing.Point(30, 107)
        Me.LblAgregarContratoClien.Name = "LblAgregarContratoClien"
        Me.LblAgregarContratoClien.Size = New System.Drawing.Size(178, 16)
        Me.LblAgregarContratoClien.TabIndex = 1
        Me.LblAgregarContratoClien.Text = "Agregar Contrato Cliente"
        '
        'LblAgregarContratoEmp
        '
        Me.LblAgregarContratoEmp.AutoSize = True
        Me.LblAgregarContratoEmp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAgregarContratoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregarContratoEmp.Location = New System.Drawing.Point(30, 82)
        Me.LblAgregarContratoEmp.Name = "LblAgregarContratoEmp"
        Me.LblAgregarContratoEmp.Size = New System.Drawing.Size(201, 16)
        Me.LblAgregarContratoEmp.TabIndex = 0
        Me.LblAgregarContratoEmp.Text = "Agregar Contrato Empleado"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(-7, -5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1153, 38)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel3.Location = New System.Drawing.Point(3, 660)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1143, 11)
        Me.Panel3.TabIndex = 3
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 672)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TpContrato)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.MaximizeBox = False
        Me.Name = "FrmContrato"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrato"
        Me.TpContrato.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PbxBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvContrato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsContrato.ResumeLayout(False)
        Me.TpAsignacion.ResumeLayout(False)
        Me.TpAsignacion.PerformLayout()
        CType(Me.PbxBuscarGuardia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvGuardias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TpContrato As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblVerContratoClien As Label
    Friend WithEvents BtnRegresarMenu As Button
    Friend WithEvents LblVerContratoEmple As Label
    Friend WithEvents LblAgregarContratoClien As Label
    Friend WithEvents LblAgregarContratoEmp As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents DgvContrato As DataGridView
    Friend WithEvents CboTipoContrato As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CboTipoEmpleado As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsueldo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpfinal As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button1 As Button
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents TxtNumIdentidad As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents PbxBuscar As PictureBox
    Friend WithEvents TpAsignacion As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents CboContratoCliente As ComboBox
    Friend WithEvents PbxBuscarGuardia As PictureBox
    Friend WithEvents TxtGuardias As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents LblGuardias As Label
    Friend WithEvents DgvGuardias As DataGridView
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TxtCliente As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents LblAsignar As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents BtnModificar As Button
    Friend WithEvents CmsContrato As ContextMenuStrip
    Friend WithEvents ModificarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents Label14 As Label
End Class
