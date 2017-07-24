Imports System.Data.SqlClient
Public Class FrmClientes

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
                    .Parameters.Add("idContratoCliente", SqlDbType.Int).Value = CboTipoContrato.SelectedValue
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


    Private Sub CargarContrato()
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarContrato"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "IdContratoCliente")
                CboTipoContrato.DataSource = ds.Tables(0)
                CboTipoContrato.DisplayMember = ds.Tables(0).Columns("IdContratoCliente").ToString

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub LblAgregarCliente_Click_1(sender As Object, e As EventArgs) Handles LblAgregarCliente.Click
        TcCliente.Visible = True
        Me.TcCliente.SelectedTab = TpAgregar
        btnModificar.Enabled = False
        CboTipoContrato.Text = Nothing
    End Sub

    Private Sub LblVerCliente_Click_1(sender As Object, e As EventArgs) Handles LblVerCliente.Click
        TcCliente.Visible = True
        Me.TcCliente.SelectedTab = TpVer
        Call Cargar()
    End Sub

    Private Sub FrmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarContrato()
        CboTipoContrato.Text = Nothing

    End Sub

    Private Sub Cargar()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_MostrarCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                End With

                Dim MostrarEmpleado As SqlDataReader
                MostrarEmpleado = cmd.ExecuteReader
                LsvCliente.Items.Clear()

                While MostrarEmpleado.Read = True
                    With LsvCliente.Items.Add(MostrarEmpleado("IdCliente").ToString)
                        .SubItems.Add(MostrarEmpleado("NombreCompañia").ToString)
                        .SubItems.Add(MostrarEmpleado("NombreContacto").ToString)
                        .SubItems.Add(MostrarEmpleado("Direccion").ToString)
                        .SubItems.Add(MostrarEmpleado("Telefono").ToString)
                        .SubItems.Add(MostrarEmpleado("IdContratoCliente").ToString)
                        .SubItems.Add(MostrarEmpleado("EstadoCliente").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los empleados" + ex.Message)
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

        If CboTipoContrato.Text = Nothing Then
            ErrorProvider1.SetError(CboTipoContrato, "Campo Obligatorio")
            CboTipoContrato.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboTipoContrato, "")
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
    End Sub

    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        FrmPantallaPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        txtIdCliente.Text = LsvCliente.FocusedItem.SubItems(0).Text
        TxtNombreCompañia.Text = LsvCliente.FocusedItem.SubItems(1).Text
        TxtNombreContacto.Text = LsvCliente.FocusedItem.SubItems(2).Text
        TxtDireccion.Text = LsvCliente.FocusedItem.SubItems(3).Text
        MsktTelf1.Text = LsvCliente.FocusedItem.SubItems(4).Text
        CboTipoContrato.Text = LsvCliente.FocusedItem.SubItems(5).Text
        If (LsvCliente.FocusedItem.SubItems(6).Text = True) Then
            RdbActibo.Checked = CheckState.Checked
            op = 1
        Else
            If (LsvCliente.FocusedItem.SubItems(6).Text = False) Then
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
                    .Parameters.Add("@IdContratoCliente", SqlDbType.Int).Value = CboTipoContrato.Text
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
        Call Limpiar()
    End Sub

    Private Sub Limpiar()
        txtIdCliente.Clear()
        TxtNombreCompañia.Clear()
        TxtNombreContacto.Clear()
        TxtDireccion.Clear()
        MsktTelf1.Clear()
        CboTipoContrato.Text = Nothing
        RdbActibo.Checked = False
        RdbInactivo.Checked = False
    End Sub
End Class