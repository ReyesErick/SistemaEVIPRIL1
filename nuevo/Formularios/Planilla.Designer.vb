<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPlanilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPlanilla))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblPlanillas = New System.Windows.Forms.Label()
        Me.BtnRegresarMenu = New System.Windows.Forms.Button()
        Me.LblAgregarPlanilla = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlanillasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Planillas = New nuevo.Planillas()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.PlanillasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillasTableAdapter = New nuevo.PlanillasTableAdapters.PlanillasTableAdapter()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DgvPlanillas = New System.Windows.Forms.DataGridView()
        Me.IdPlanillaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TpPlanilla = New System.Windows.Forms.TabControl()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DgvPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpPlanilla.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblPlanillas)
        Me.Panel1.Controls.Add(Me.BtnRegresarMenu)
        Me.Panel1.Controls.Add(Me.LblAgregarPlanilla)
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
        Me.PictureBox4.Location = New System.Drawing.Point(14, 108)
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
        'LblPlanillas
        '
        Me.LblPlanillas.AutoSize = True
        Me.LblPlanillas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblPlanillas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblPlanillas.Location = New System.Drawing.Point(38, 108)
        Me.LblPlanillas.Name = "LblPlanillas"
        Me.LblPlanillas.Size = New System.Drawing.Size(96, 16)
        Me.LblPlanillas.TabIndex = 1
        Me.LblPlanillas.Text = "Ver Planillas"
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
        'LblAgregarPlanilla
        '
        Me.LblAgregarPlanilla.AutoSize = True
        Me.LblAgregarPlanilla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblAgregarPlanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblAgregarPlanilla.Location = New System.Drawing.Point(38, 82)
        Me.LblAgregarPlanilla.Name = "LblAgregarPlanilla"
        Me.LblAgregarPlanilla.Size = New System.Drawing.Size(169, 16)
        Me.LblAgregarPlanilla.TabIndex = 0
        Me.LblAgregarPlanilla.Text = "Agregar Nueva Planilla"
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
        'PlanillasBindingSource1
        '
        Me.PlanillasBindingSource1.DataMember = "Planillas"
        Me.PlanillasBindingSource1.DataSource = Me.Planillas
        '
        'Planillas
        '
        Me.Planillas.DataSetName = "Planillas"
        Me.Planillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel3.Location = New System.Drawing.Point(0, 662)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1143, 11)
        Me.Panel3.TabIndex = 6
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PlanillasBindingSource
        '
        Me.PlanillasBindingSource.DataSource = Me.Planillas
        Me.PlanillasBindingSource.Position = 0
        '
        'PlanillasTableAdapter
        '
        Me.PlanillasTableAdapter.ClearBeforeFill = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DgvPlanillas)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(863, 548)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Planillas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DgvPlanillas
        '
        Me.DgvPlanillas.AutoGenerateColumns = False
        Me.DgvPlanillas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvPlanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvPlanillas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPlanillaDataGridViewTextBoxColumn, Me.NumPagoDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.AnioDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.DgvPlanillas.DataSource = Me.PlanillasBindingSource1
        Me.DgvPlanillas.Location = New System.Drawing.Point(131, 23)
        Me.DgvPlanillas.Name = "DgvPlanillas"
        Me.DgvPlanillas.ReadOnly = True
        Me.DgvPlanillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvPlanillas.Size = New System.Drawing.Size(545, 479)
        Me.DgvPlanillas.TabIndex = 90
        '
        'IdPlanillaDataGridViewTextBoxColumn
        '
        Me.IdPlanillaDataGridViewTextBoxColumn.DataPropertyName = "IdPlanilla"
        Me.IdPlanillaDataGridViewTextBoxColumn.HeaderText = "IdPlanilla"
        Me.IdPlanillaDataGridViewTextBoxColumn.Name = "IdPlanillaDataGridViewTextBoxColumn"
        Me.IdPlanillaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumPagoDataGridViewTextBoxColumn
        '
        Me.NumPagoDataGridViewTextBoxColumn.DataPropertyName = "NumPago"
        Me.NumPagoDataGridViewTextBoxColumn.HeaderText = "NumPago"
        Me.NumPagoDataGridViewTextBoxColumn.Name = "NumPagoDataGridViewTextBoxColumn"
        Me.NumPagoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MesDataGridViewTextBoxColumn
        '
        Me.MesDataGridViewTextBoxColumn.DataPropertyName = "Mes"
        Me.MesDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.MesDataGridViewTextBoxColumn.Name = "MesDataGridViewTextBoxColumn"
        Me.MesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnioDataGridViewTextBoxColumn
        '
        Me.AnioDataGridViewTextBoxColumn.DataPropertyName = "Anio"
        Me.AnioDataGridViewTextBoxColumn.HeaderText = "Anio"
        Me.AnioDataGridViewTextBoxColumn.Name = "AnioDataGridViewTextBoxColumn"
        Me.AnioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TpPlanilla
        '
        Me.TpPlanilla.Controls.Add(Me.TabPage3)
        Me.TpPlanilla.Location = New System.Drawing.Point(267, 71)
        Me.TpPlanilla.Name = "TpPlanilla"
        Me.TpPlanilla.SelectedIndex = 0
        Me.TpPlanilla.Size = New System.Drawing.Size(871, 574)
        Me.TpPlanilla.TabIndex = 3
        Me.TpPlanilla.Visible = False
        '
        'FrmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 672)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TpPlanilla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.MaximizeBox = False
        Me.Name = "FrmPlanilla"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DgvPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpPlanilla.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblPlanillas As Label
    Friend WithEvents BtnRegresarMenu As Button
    Friend WithEvents LblAgregarPlanilla As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents PlanillasBindingSource As BindingSource
    Friend WithEvents Planillas As Planillas
    Friend WithEvents PlanillasBindingSource1 As BindingSource
    Friend WithEvents PlanillasTableAdapter As PlanillasTableAdapters.PlanillasTableAdapter
    Friend WithEvents TpPlanilla As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DgvPlanillas As DataGridView
    Friend WithEvents IdPlanillaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
