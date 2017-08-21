<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTercerCuartoMes
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TercerCuartoMesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Planillas = New nuevo.Planillas()
        Me.TercerCuartoMesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TercerCuartoMesTableAdapter = New nuevo.PlanillasTableAdapters.TercerCuartoMesTableAdapter()
        Me.TableAdapterManager = New nuevo.PlanillasTableAdapters.TableAdapterManager()
        Me.TercerCuartoMesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TercerCuartoMesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TercerCuartoMesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TercerCuartoMesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(462, 38)
        Me.Panel2.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel1.Location = New System.Drawing.Point(0, 537)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(462, 12)
        Me.Panel1.TabIndex = 7

        'Planillas

        Me.Planillas.DataSetName = "Planillas"
        Me.Planillas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TercerCuartoMesBindingSource1
        '
        Me.TercerCuartoMesBindingSource1.DataMember = "TercerCuartoMes"
        Me.TercerCuartoMesBindingSource1.DataSource = Me.Planillas
        '
        'TercerCuartoMesTableAdapter
        '
        Me.TercerCuartoMesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.PlanillasTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = nuevo.PlanillasTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete

        'TercerCuartoMesDataGridView

        Me.TercerCuartoMesDataGridView.AutoGenerateColumns = False
        Me.TercerCuartoMesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TercerCuartoMesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TercerCuartoMesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.TercerCuartoMesDataGridView.DataSource = Me.TercerCuartoMesBindingSource1
        Me.TercerCuartoMesDataGridView.Location = New System.Drawing.Point(12, 55)
        Me.TercerCuartoMesDataGridView.Name = "TercerCuartoMesDataGridView"
        Me.TercerCuartoMesDataGridView.ReadOnly = True
        Me.TercerCuartoMesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TercerCuartoMesDataGridView.Size = New System.Drawing.Size(435, 462)
        Me.TercerCuartoMesDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Monto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Monto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "MesPago"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MesPago"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'FrmTercerCuartoMes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 544)
        Me.Controls.Add(Me.TercerCuartoMesDataGridView)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTercerCuartoMes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTercerCuartoMes"
        CType(Me.TercerCuartoMesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Planillas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TercerCuartoMesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TercerCuartoMesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TercerCuartoMesBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TercerCuartoMesBindingSource1 As BindingSource
    Friend WithEvents TercerCuartoMesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Planillas As nuevo.Planillas
    Friend WithEvents TercerCuartoMesTableAdapter As nuevo.PlanillasTableAdapters.TercerCuartoMesTableAdapter
    Friend WithEvents TableAdapterManager As nuevo.PlanillasTableAdapters.TableAdapterManager
End Class
