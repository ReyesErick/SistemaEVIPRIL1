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
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblPlanillas = New System.Windows.Forms.Label()
        Me.BtnRegresarMenu = New System.Windows.Forms.Button()
        Me.LblAgregarPlanilla = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PlanillasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlanillasBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Planillas = New nuevo.Planillas()
        Me.PlanillasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TpPlanilla = New System.Windows.Forms.TabControl()
        Me.PlanillasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PlanillasTableAdapter = New nuevo.PlanillasTableAdapters.PlanillasTableAdapter()
        Me.TableAdapterManager = New nuevo.PlanillasTableAdapters.TableAdapterManager()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PlanillasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillasBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanillasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TpPlanilla.SuspendLayout()
        CType(Me.PlanillasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.PictureBox7)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LblPlanillas)
        Me.Panel1.Controls.Add(Me.BtnRegresarMenu)
        Me.Panel1.Controls.Add(Me.LblAgregarPlanilla)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 263)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(14, 107)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 26
        Me.PictureBox7.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(14, 132)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 25
        Me.PictureBox6.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(37, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(203, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Agregar Decimo Cuarto Mes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(37, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 16)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Agregar Decimo Tercer Mes"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(14, 156)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(14, 180)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(21, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 21
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(38, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Ver Decimo Cuarto Mes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(38, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Ver Decimo Tercer Mes"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(20, 16)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(23, 21)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 16
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(14, 204)
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
        Me.LblPlanillas.Location = New System.Drawing.Point(38, 205)
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
        Me.BtnRegresarMenu.Location = New System.Drawing.Point(11, 12)
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PlanillasDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(863, 548)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Planillas"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PlanillasDataGridView
        '
        Me.PlanillasDataGridView.AllowUserToOrderColumns = True
        Me.PlanillasDataGridView.AutoGenerateColumns = False
        Me.PlanillasDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PlanillasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PlanillasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PlanillasDataGridView.DataSource = Me.PlanillasBindingSource2
        Me.PlanillasDataGridView.Location = New System.Drawing.Point(221, 50)
        Me.PlanillasDataGridView.Name = "PlanillasDataGridView"
        Me.PlanillasDataGridView.ReadOnly = True
        Me.PlanillasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PlanillasDataGridView.Size = New System.Drawing.Size(444, 433)
        Me.PlanillasDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPlanilla"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPlanilla"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NumPago"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NumPago"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Mes"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Mes"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Anio"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Anio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'PlanillasBindingSource2
        '
        Me.PlanillasBindingSource2.DataMember = "Planillas"
        Me.PlanillasBindingSource2.DataSource = Me.Planillas
        '
        'Planillas
        '
        Me.Planillas.DataSetName = "Planillas"
        Me.Planillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'PlanillasTableAdapter
        '
        Me.PlanillasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetallePlanillaContratoTableAdapter = Nothing
        Me.TableAdapterManager.DetallePlanillaTemporalTableAdapter = Nothing
        Me.TableAdapterManager.PlanillasTableAdapter = Me.PlanillasTableAdapter
        Me.TableAdapterManager.UpdateOrder = nuevo.PlanillasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FrmPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 673)
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
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PlanillasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillasBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanillasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TpPlanilla.ResumeLayout(False)
        CType(Me.PlanillasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PlanillasBindingSource1 As BindingSource
    Friend WithEvents TpPlanilla As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Planillas As Planillas
    Friend WithEvents PlanillasBindingSource2 As BindingSource
    Friend WithEvents PlanillasTableAdapter As PlanillasTableAdapters.PlanillasTableAdapter
    Friend WithEvents TableAdapterManager As PlanillasTableAdapters.TableAdapterManager
    Friend WithEvents PlanillasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
End Class
