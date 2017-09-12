<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicioSeción
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicioSeción))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnInicioSesion = New System.Windows.Forms.Button()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.LblCerrar = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.AbrirFoto = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(129, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(700, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnInicioSesion
        '
        Me.BtnInicioSesion.BackColor = System.Drawing.Color.LawnGreen
        Me.BtnInicioSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnInicioSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicioSesion.Location = New System.Drawing.Point(580, 239)
        Me.BtnInicioSesion.Name = "BtnInicioSesion"
        Me.BtnInicioSesion.Size = New System.Drawing.Size(188, 42)
        Me.BtnInicioSesion.TabIndex = 2
        Me.BtnInicioSesion.Text = "INICIAR  SESIÓN"
        Me.BtnInicioSesion.UseVisualStyleBackColor = False
        '
        'TxtUser
        '
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUser.Location = New System.Drawing.Point(589, 127)
        Me.TxtUser.Multiline = True
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(173, 21)
        Me.TxtUser.TabIndex = 0
        '
        'LblCerrar
        '
        Me.LblCerrar.AutoSize = True
        Me.LblCerrar.BackColor = System.Drawing.Color.Red
        Me.LblCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCerrar.ForeColor = System.Drawing.Color.Black
        Me.LblCerrar.Location = New System.Drawing.Point(768, 33)
        Me.LblCerrar.Name = "LblCerrar"
        Me.LblCerrar.Size = New System.Drawing.Size(20, 20)
        Me.LblCerrar.TabIndex = 5
        Me.LblCerrar.Text = "X"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TxtPassword
        '
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.Black
        Me.TxtPassword.Location = New System.Drawing.Point(589, 180)
        Me.TxtPassword.Multiline = True
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(179, 20)
        Me.TxtPassword.TabIndex = 1
        '
        'AbrirFoto
        '
        Me.AbrirFoto.FileName = "OpenFileDialog1"
        '
        'FrmInicioSeción
        '
        Me.AcceptButton = Me.BtnInicioSesion
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(791, 339)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.LblCerrar)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.BtnInicioSesion)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInicioSeción"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InicioSeción"
        Me.TransparencyKey = System.Drawing.Color.Maroon
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnInicioSesion As Button
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents LblCerrar As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents AbrirFoto As OpenFileDialog
End Class
