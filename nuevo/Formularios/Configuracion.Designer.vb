<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConfiguracion
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.gbConnConfig = New System.Windows.Forms.GroupBox()
        Me.btnTestConnection = New System.Windows.Forms.Button()
        Me.lblConnStatus = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtDB = New System.Windows.Forms.TextBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbConnConfig.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(421, 36)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LawnGreen
        Me.Panel2.Location = New System.Drawing.Point(-1, 339)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(421, 13)
        Me.Panel2.TabIndex = 1
        '
        'gbConnConfig
        '
        Me.gbConnConfig.BackColor = System.Drawing.Color.Transparent
        Me.gbConnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbConnConfig.Controls.Add(Me.btnTestConnection)
        Me.gbConnConfig.Controls.Add(Me.lblConnStatus)
        Me.gbConnConfig.Controls.Add(Me.txtPassword)
        Me.gbConnConfig.Controls.Add(Me.txtUsername)
        Me.gbConnConfig.Controls.Add(Me.txtDB)
        Me.gbConnConfig.Controls.Add(Me.txtServer)
        Me.gbConnConfig.Controls.Add(Me.Label4)
        Me.gbConnConfig.Controls.Add(Me.Label3)
        Me.gbConnConfig.Controls.Add(Me.Label2)
        Me.gbConnConfig.Controls.Add(Me.Label1)
        Me.gbConnConfig.Location = New System.Drawing.Point(22, 41)
        Me.gbConnConfig.Name = "gbConnConfig"
        Me.gbConnConfig.Size = New System.Drawing.Size(376, 268)
        Me.gbConnConfig.TabIndex = 10
        Me.gbConnConfig.TabStop = False
        '
        'btnTestConnection
        '
        Me.btnTestConnection.BackColor = System.Drawing.Color.White
        Me.btnTestConnection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTestConnection.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTestConnection.FlatAppearance.BorderSize = 0
        Me.btnTestConnection.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTestConnection.Location = New System.Drawing.Point(126, 168)
        Me.btnTestConnection.Name = "btnTestConnection"
        Me.btnTestConnection.Size = New System.Drawing.Size(129, 33)
        Me.btnTestConnection.TabIndex = 4
        Me.btnTestConnection.Text = "&Probar conexión"
        Me.btnTestConnection.UseVisualStyleBackColor = False
        '
        'lblConnStatus
        '
        Me.lblConnStatus.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnStatus.Location = New System.Drawing.Point(74, 204)
        Me.lblConnStatus.Name = "lblConnStatus"
        Me.lblConnStatus.Size = New System.Drawing.Size(235, 37)
        Me.lblConnStatus.TabIndex = 20
        Me.lblConnStatus.Text = "Conexión no comprobada"
        Me.lblConnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(135, 130)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(204, 21)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(135, 97)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(204, 21)
        Me.txtUsername.TabIndex = 2
        '
        'txtDB
        '
        Me.txtDB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDB.Location = New System.Drawing.Point(135, 61)
        Me.txtDB.Name = "txtDB"
        Me.txtDB.Size = New System.Drawing.Size(204, 21)
        Me.txtDB.TabIndex = 1
        '
        'txtServer
        '
        Me.txtServer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServer.Location = New System.Drawing.Point(135, 28)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(204, 21)
        Me.txtServer.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(80, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Base de datos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 19)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Servidor"
        '
        'FrmConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(420, 350)
        Me.Controls.Add(Me.gbConnConfig)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuracion"
        Me.gbConnConfig.ResumeLayout(False)
        Me.gbConnConfig.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents gbConnConfig As GroupBox
    Friend WithEvents btnTestConnection As Button
    Protected WithEvents lblConnStatus As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtDB As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
