<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDetallePlanilla
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
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CmsImpPlanillas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ImprimirVoucherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirPlanillasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Planillas = New nuevo.Planillas()
        Me.DetallePlanillaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetallePlanillaTableAdapter = New nuevo.PlanillasTableAdapters.DetallePlanillaTableAdapter()
        Me.TableAdapterManager = New nuevo.PlanillasTableAdapters.TableAdapterManager()
        Me.EmpleadoTableAdapter = New nuevo.PlanillasTableAdapters.EmpleadoTableAdapter()
        Me.DetallePlanillaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmsImpPlanillas.SuspendLayout()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallePlanillaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallePlanillaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guardar
        '
        Me.Guardar.BackColor = System.Drawing.Color.LawnGreen
        Me.Guardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guardar.Location = New System.Drawing.Point(994, 436)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(156, 49)
        Me.Guardar.TabIndex = 91
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(2, -3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1159, 38)
        Me.Panel2.TabIndex = 92
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel3.Location = New System.Drawing.Point(2, 501)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1159, 12)
        Me.Panel3.TabIndex = 93
        '
        'CmsImpPlanillas
        '
        Me.CmsImpPlanillas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimirVoucherToolStripMenuItem, Me.ImprimirToolStripMenuItem, Me.ImprimirPlanillasToolStripMenuItem})
        Me.CmsImpPlanillas.Name = "CmsImpPlanillas"
        Me.CmsImpPlanillas.Size = New System.Drawing.Size(220, 92)
        '
        'ImprimirVoucherToolStripMenuItem
        '
        Me.ImprimirVoucherToolStripMenuItem.Name = "ImprimirVoucherToolStripMenuItem"
        Me.ImprimirVoucherToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ImprimirVoucherToolStripMenuItem.Text = "Imprimir Voucher"
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir Todos los Voucher"
        '
        'ImprimirPlanillasToolStripMenuItem
        '
        Me.ImprimirPlanillasToolStripMenuItem.Name = "ImprimirPlanillasToolStripMenuItem"
        Me.ImprimirPlanillasToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ImprimirPlanillasToolStripMenuItem.Text = "Imprimir Planillas"
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.Planillas
        '
        'Planillas
        '
        Me.Planillas.DataSetName = "Planillas"
        Me.Planillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetallePlanillaBindingSource
        '
        Me.DetallePlanillaBindingSource.DataMember = "DetallePlanilla"
        Me.DetallePlanillaBindingSource.DataSource = Me.Planillas
        '
        'DetallePlanillaTableAdapter
        '
        Me.DetallePlanillaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        'Me.TableAdapterManager.ContratoEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.PlanillasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nuevo.PlanillasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'DetallePlanillaDataGridView
        '
        Me.DetallePlanillaDataGridView.AutoGenerateColumns = False
        Me.DetallePlanillaDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DetallePlanillaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetallePlanillaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.DetallePlanillaDataGridView.ContextMenuStrip = Me.CmsImpPlanillas
        Me.DetallePlanillaDataGridView.DataSource = Me.DetallePlanillaBindingSource
        Me.DetallePlanillaDataGridView.Location = New System.Drawing.Point(12, 48)
        Me.DetallePlanillaDataGridView.Name = "DetallePlanillaDataGridView"
        Me.DetallePlanillaDataGridView.Size = New System.Drawing.Size(1137, 382)
        Me.DetallePlanillaDataGridView.TabIndex = 94
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPlanilla"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPlanilla"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SueldoDiario"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SueldoDiario"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DiasTrabajados"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DiasTrabajados"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SueldoQuincenal"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SueldoQuincenal"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Complemento"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Complemento"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SubTotal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SubTotal"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DeduccionSeguro"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DeduccionSeguro"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "DeduccionUniforme"
        Me.DataGridViewTextBoxColumn8.HeaderText = "DeduccionUniforme"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Rap"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Rap"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "OtrasDeducciones"
        Me.DataGridViewTextBoxColumn10.HeaderText = "OtrasDeducciones"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TotalDeducciones"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TotalDeducciones"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "NetoPagar"
        Me.DataGridViewTextBoxColumn12.HeaderText = "NetoPagar"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "NumIdentidad"
        Me.DataGridViewTextBoxColumn13.HeaderText = "NumIdentidad"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'FrmDetallePlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 533)
        Me.Controls.Add(Me.DetallePlanillaDataGridView)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guardar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDetallePlanilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetallePlanilla"
        Me.CmsImpPlanillas.ResumeLayout(False)
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallePlanillaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallePlanillaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Planillas As Planillas
    Friend WithEvents DetallePlanillaBindingSource As BindingSource
    Friend WithEvents DetallePlanillaTableAdapter As PlanillasTableAdapters.DetallePlanillaTableAdapter
    Friend WithEvents TableAdapterManager As PlanillasTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As PlanillasTableAdapters.EmpleadoTableAdapter
    Friend WithEvents Guardar As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents CmsImpPlanillas As ContextMenuStrip
    Friend WithEvents ImprimirVoucherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirPlanillasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetallePlanillaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
