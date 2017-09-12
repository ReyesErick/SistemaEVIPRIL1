<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPermisosArmas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Planillas = New nuevo.Planillas()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New nuevo.PlanillasTableAdapters.DataTable1TableAdapter()
        Me.TableAdapterManager = New nuevo.PlanillasTableAdapters.TableAdapterManager()
        Me.DataTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioArmasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioArmasTableAdapter = New nuevo.PlanillasTableAdapters.InventarioArmasTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InventarioArmasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventarioArmasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioArmasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioArmasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventarioArmasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Planillas
        '
        Me.Planillas.DataSetName = "Planillas"
        Me.Planillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.Planillas
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        'Me.TableAdapterManager.ContratoEmpleadoTableAdapter = Nothing
        'Me.TableAdapterManager.DetallePlanillaTableAdapter = Nothing
        'Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.PlanillasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nuevo.PlanillasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataTable1BindingSource1
        '
        Me.DataTable1BindingSource1.DataMember = "DataTable1"
        Me.DataTable1BindingSource1.DataSource = Me.Planillas
        '
        'InventarioArmasBindingSource
        '
        Me.InventarioArmasBindingSource.DataMember = "InventarioArmas"
        Me.InventarioArmasBindingSource.DataSource = Me.Planillas
        '
        'InventarioArmasTableAdapter
        '
        Me.InventarioArmasTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1055, 38)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 503)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1055, 15)
        Me.Panel1.TabIndex = 7
        '
        'InventarioArmasBindingSource1
        '
        Me.InventarioArmasBindingSource1.DataMember = "InventarioArmas"
        Me.InventarioArmasBindingSource1.DataSource = Me.Planillas
        '
        'InventarioArmasDataGridView
        '
        Me.InventarioArmasDataGridView.AutoGenerateColumns = False
        Me.InventarioArmasDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.InventarioArmasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InventarioArmasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.InventarioArmasDataGridView.DataSource = Me.InventarioArmasBindingSource1
        Me.InventarioArmasDataGridView.Location = New System.Drawing.Point(5, 56)
        Me.InventarioArmasDataGridView.Name = "InventarioArmasDataGridView"
        Me.InventarioArmasDataGridView.ReadOnly = True
        Me.InventarioArmasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InventarioArmasDataGridView.Size = New System.Drawing.Size(1043, 432)
        Me.InventarioArmasDataGridView.TabIndex = 7
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
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IdContratoCliente"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IdContratoCliente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Estado"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Estado"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "FechaPermiso"
        Me.DataGridViewTextBoxColumn8.HeaderText = "FechaPermiso"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Marca"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Marca"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Modelo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "TipoArma"
        Me.DataGridViewTextBoxColumn11.HeaderText = "TipoArma"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "LugarFabricacion"
        Me.DataGridViewTextBoxColumn12.HeaderText = "LugarFabricacion"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'FrmPermisosArmas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 518)
        Me.Controls.Add(Me.InventarioArmasDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPermisosArmas"
        Me.Text = "PermisosArmas"
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioArmasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioArmasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventarioArmasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Planillas As Planillas
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As PlanillasTableAdapters.DataTable1TableAdapter
    Friend WithEvents TableAdapterManager As PlanillasTableAdapters.TableAdapterManager
    Friend WithEvents DataTable1BindingSource1 As BindingSource
    Friend WithEvents InventarioArmasBindingSource As BindingSource
    Friend WithEvents InventarioArmasTableAdapter As PlanillasTableAdapters.InventarioArmasTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents InventarioArmasBindingSource1 As BindingSource
    Friend WithEvents InventarioArmasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
