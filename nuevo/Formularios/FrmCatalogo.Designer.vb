<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatalogo
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
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCombo = New System.Windows.Forms.Label()
        Me.TxtNombreCato = New System.Windows.Forms.TextBox()
        Me.CboCombo = New System.Windows.Forms.ComboBox()
        Me.DgvCatalogo = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DgvCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(41, 54)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(0, 20)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'LblCombo
        '
        Me.LblCombo.AutoSize = True
        Me.LblCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCombo.Location = New System.Drawing.Point(19, 102)
        Me.LblCombo.Name = "LblCombo"
        Me.LblCombo.Size = New System.Drawing.Size(0, 20)
        Me.LblCombo.TabIndex = 1
        Me.LblCombo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TxtNombreCato
        '
        Me.TxtNombreCato.Enabled = False
        Me.TxtNombreCato.Location = New System.Drawing.Point(144, 56)
        Me.TxtNombreCato.Multiline = True
        Me.TxtNombreCato.Name = "TxtNombreCato"
        Me.TxtNombreCato.Size = New System.Drawing.Size(201, 20)
        Me.TxtNombreCato.TabIndex = 2
        '
        'CboCombo
        '
        Me.CboCombo.Enabled = False
        Me.CboCombo.FormattingEnabled = True
        Me.CboCombo.Location = New System.Drawing.Point(144, 104)
        Me.CboCombo.Name = "CboCombo"
        Me.CboCombo.Size = New System.Drawing.Size(201, 21)
        Me.CboCombo.TabIndex = 3
        '
        'DgvCatalogo
        '
        Me.DgvCatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvCatalogo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCatalogo.Location = New System.Drawing.Point(12, 192)
        Me.DgvCatalogo.Name = "DgvCatalogo"
        Me.DgvCatalogo.ReadOnly = True
        Me.DgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCatalogo.Size = New System.Drawing.Size(396, 189)
        Me.DgvCatalogo.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(422, 39)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(-1, 395)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(422, 14)
        Me.Panel2.TabIndex = 6
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnGuardar.Location = New System.Drawing.Point(144, 142)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(156, 40)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'FrmCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 409)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvCatalogo)
        Me.Controls.Add(Me.CboCombo)
        Me.Controls.Add(Me.TxtNombreCato)
        Me.Controls.Add(Me.LblCombo)
        Me.Controls.Add(Me.LblNombre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCatalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo"
        CType(Me.DgvCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCombo As Label
    Friend WithEvents TxtNombreCato As TextBox
    Friend WithEvents CboCombo As ComboBox
    Friend WithEvents DgvCatalogo As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnGuardar As Button
End Class
