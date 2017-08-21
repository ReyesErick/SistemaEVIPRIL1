<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContratosExpirar
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
        Me.ContratoEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContratoEmpleadoTableAdapter = New nuevo.PlanillasTableAdapters.ContratoEmpleadoTableAdapter()
        Me.TableAdapterManager = New nuevo.PlanillasTableAdapters.TableAdapterManager()
        Me.EmpleadoTableAdapter = New nuevo.PlanillasTableAdapters.EmpleadoTableAdapter()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ContratoEmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratoEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ContratoEmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Planillas
        '
        Me.Planillas.DataSetName = "Planillas"
        Me.Planillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ContratoEmpleadoBindingSource
        '
        Me.ContratoEmpleadoBindingSource.DataMember = "ContratoEmpleado"
        Me.ContratoEmpleadoBindingSource.DataSource = Me.Planillas
        '
        'ContratoEmpleadoTableAdapter
        '
        Me.ContratoEmpleadoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpleadoTableAdapter = Me.EmpleadoTableAdapter
        Me.TableAdapterManager.PlanillasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nuevo.PlanillasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.Planillas
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 35)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 478)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(766, 13)
        Me.Panel2.TabIndex = 3
        '
        'ContratoEmpleadoDataGridView
        '
        Me.ContratoEmpleadoDataGridView.AutoGenerateColumns = False
        Me.ContratoEmpleadoDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ContratoEmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ContratoEmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.ContratoEmpleadoDataGridView.DataSource = Me.ContratoEmpleadoBindingSource
        Me.ContratoEmpleadoDataGridView.Location = New System.Drawing.Point(12, 52)
        Me.ContratoEmpleadoDataGridView.Name = "ContratoEmpleadoDataGridView"
        Me.ContratoEmpleadoDataGridView.ReadOnly = True
        Me.ContratoEmpleadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ContratoEmpleadoDataGridView.Size = New System.Drawing.Size(742, 420)
        Me.ContratoEmpleadoDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdContratoEmpleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdContratoEmpleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FechaInicio"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FechaInicio"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "FechaFinal"
        Me.DataGridViewTextBoxColumn3.HeaderText = "FechaFinal"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "SueldoBase"
        Me.DataGridViewTextBoxColumn4.HeaderText = "SueldoBase"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TipoContrato"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TipoContrato"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "TipoEmpleado"
        Me.DataGridViewTextBoxColumn9.HeaderText = "TipoEmpleado"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'ContratosExpirar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 489)
        Me.Controls.Add(Me.ContratoEmpleadoDataGridView)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ContratosExpirar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ContratosExpirar"
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratoEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ContratoEmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Planillas As Planillas
    Friend WithEvents ContratoEmpleadoBindingSource As BindingSource
    Friend WithEvents ContratoEmpleadoTableAdapter As PlanillasTableAdapters.ContratoEmpleadoTableAdapter
    Friend WithEvents TableAdapterManager As PlanillasTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadoTableAdapter As PlanillasTableAdapters.EmpleadoTableAdapter
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewComboBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContratoEmpleadoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
