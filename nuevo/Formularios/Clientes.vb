Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Public Class FrmClientes
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim da As New SqlDataAdapter
    Dim User As String = FrmPantallaPrincipal.LblBienvenido.Text

    Dim op As Integer
    Private Sub LblAgregarCliente_MouseLeave(sender As Object, e As EventArgs) Handles LblAgregarCliente.MouseLeave
        LblAgregarCliente.ForeColor = Color.Black
    End Sub
    Private Sub LblAgregarCliente_MouseMove(sender As Object, e As MouseEventArgs) Handles LblAgregarCliente.MouseMove
        LblAgregarCliente.ForeColor = Color.Green
    End Sub

    Private Sub LblVerCliente_MouseLeave(sender As Object, e As EventArgs) Handles LblVerCliente.MouseLeave
        LblVerCliente.ForeColor = Color.Black
    End Sub

    Private Sub LblVerCliente_MouseMove(sender As Object, e As MouseEventArgs) Handles LblVerCliente.MouseMove
        LblVerCliente.ForeColor = Color.Green
    End Sub

    Private Sub AgregarCliente()
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@NombreCompañia", SqlDbType.NVarChar).Value = TxtNombreCompañia.Text
                    .Parameters.Add("@NombreContacto", SqlDbType.NVarChar).Value = TxtNombreContacto.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char).Value = MsktTelf1.Text
                    If RdbActibo.Checked = CheckState.Unchecked Then
                        .Parameters.Add("@EstadoCliente", SqlDbType.Bit).Value = 0
                        op = 0
                    Else
                        .Parameters.Add("@EstadoCliente", SqlDbType.Bit).Value = 1
                        op = 1
                    End If
                    .ExecuteNonQuery()
                    MsgBox("Guardado con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub LblAgregarCliente_Click_1(sender As Object, e As EventArgs) Handles LblAgregarCliente.Click
        sele = 1
        verificarHelp()
        TcCliente.Visible = True
        Me.TcCliente.SelectedTab = TpAgregar
        btnModificar.Enabled = False
    End Sub

    Private Sub LblVerCliente_Click_1(sender As Object, e As EventArgs) Handles LblVerCliente.Click
        sele = 2
        verificarHelp()
        TcCliente.Visible = True
        Me.TcCliente.SelectedTab = TpVer
        Call Cargar()
    End Sub

    Private Sub Cargar()

        Using cmd As New SqlCommand

            Try
                da = New SqlDataAdapter("select *
                                 from Cliente", cn)
                dt = New DataTable
                da.Fill(dt)
                DgvCliente.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al listar los clientes" + ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub BtnGuardar_Click_1(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNombreCompañia.Text = "" Then
            ErrorProvider1.SetError(TxtNombreCompañia, "Campo Obligatorio")
            TxtNombreCompañia.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtNombreCompañia, "")
        End If
        If TxtNombreContacto.Text = Nothing Then
            ErrorProvider1.SetError(TxtNombreContacto, "Campo Obligatorio")
            TxtNombreContacto.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtNombreContacto, "")
        End If

        If MsktTelf1.Text = "" Then
            MessageBox.Show("Campo Obligatorio")
            MsktTelf1.Focus()
            Return
        Else
            ErrorProvider1.SetError(MsktTelf1, "")
        End If

        If TxtDireccion.Text = Nothing Then
            ErrorProvider1.SetError(TxtDireccion, "Campo Obligatorio")
            TxtDireccion.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtDireccion, "")
        End If


        If RdbActibo.Checked = False And RdbInactivo.Checked = False Then
            ErrorProvider1.SetError(RdbActibo, "Campo Obligatorio")
            RdbActibo.Focus()
            Return
        Else
            ErrorProvider1.SetError(RdbInactivo, "")
        End If
        Call AgregarCliente()
        Call AudiLogInsert()
        Call Limpiar()
    End Sub

    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        FrmPantallaPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        txtIdCliente.Text = DgvCliente.CurrentRow.Cells(0).ToString()
        TxtNombreCompañia.Text = DgvCliente.CurrentRow.Cells(1).ToString()
        TxtNombreContacto.Text = DgvCliente.CurrentRow.Cells(2).ToString()
        TxtDireccion.Text = DgvCliente.CurrentRow.Cells(3).ToString()
        MsktTelf1.Text = DgvCliente.CurrentRow.Cells(4).ToString()
        If (DgvCliente.CurrentRow.Cells(5).ToString() = True) Then
            RdbActibo.Checked = CheckState.Checked
            op = 1
        Else
            If (DgvCliente.CurrentRow.Cells(5).ToString() = False) Then
                RdbInactivo.Checked = CheckState.Checked
                op = 0
            End If
        End If
        TcCliente.SelectedTab = TpAgregar
        btnModificar.Enabled = True
    End Sub

    'Actualizar un Cliente'
    Private Sub Editar()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ModificarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    'establecer los parametros que espera el procedimiento almacenado
                    .Parameters.Add("@NombreCompañia", SqlDbType.NVarChar, 100).Value = TxtNombreCompañia.Text
                    .Parameters.Add("@NombreContacto", SqlDbType.NVarChar, 100).Value = TxtNombreContacto.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = MsktTelf1.Text
                    If RdbActibo.Checked = CheckState.Unchecked Then
                        .Parameters.Add("@EstadoCliente", SqlDbType.Bit).Value = 0
                        op = 0
                    Else
                        .Parameters.Add("@EstadoCliente", SqlDbType.Bit).Value = 1
                        op = 1
                    End If
                    .Parameters.Add("@IdCliente", SqlDbType.Int).Value = txtIdCliente.Text
                    .ExecuteNonQuery()
                    MessageBox.Show("Registro Modificado satisfactoriamente", "SeguridadLeon")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al  Modificar el cliente" + ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Call Editar()
        Call AudiLogUpdate()
        Call Limpiar()
    End Sub

    Private Sub Limpiar()
        txtIdCliente.Clear()
        TxtNombreCompañia.Clear()
        TxtNombreContacto.Clear()
        TxtDireccion.Clear()
        MsktTelf1.Clear()
        RdbActibo.Checked = False
        RdbInactivo.Checked = False
    End Sub

    Private Sub LsvCliente_DoubleClick(sender As Object, e As EventArgs)
        FrmContrato.TxtCliente.Text = DgvCliente.CurrentRow.Cells(0).ToString()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reporte As New ReporteClientes()
        Dim viewer As New ReportPrintTool(reporte)
        viewer.ShowPreview()
    End Sub

    Private Sub AudiLogInsert()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO AudiLog (Descripcion, Usuario) VALUES (@Descripcion, @Usuario)", cn)
            da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = "Se inserto el Cliente con Nombre: " + TxtNombreContacto.Text
            da.InsertCommand.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = User

            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub AudiLogUpdate()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO AudiLog (Descripcion, Usuario) VALUES (@Descripcion, @Usuario)", cn)
            da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = "Se Modificó el cliente con Nombre: " + TxtNombreContacto.Text
            da.InsertCommand.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = User

            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("Ayuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        sele = 0
        verificarHelp()
    End Sub

    Private Sub verificarHelp()
        If sele = 1 Then
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.CLIENTE.AG")
        ElseIf sele = 2 Then
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.CLIENTE.VER")
        Else

        End If
    End Sub
End Class