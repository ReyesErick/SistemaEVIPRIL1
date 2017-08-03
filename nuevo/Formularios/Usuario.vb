Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class FrmUsuario
    Private Sub LblAgregarUsuario_MouseLeave(sender As Object, e As EventArgs) Handles LblAgregarUsuario.MouseLeave
        LblAgregarUsuario.ForeColor = Color.Black
    End Sub

    Private Sub LblAgregarUsuario_MouseMove(sender As Object, e As MouseEventArgs) Handles LblAgregarUsuario.MouseMove
        LblAgregarUsuario.ForeColor = Color.Green
    End Sub

    Private Sub LblVerUsuarios_MouseLeave(sender As Object, e As EventArgs) Handles LblVerUsuarios.MouseLeave
        LblVerUsuarios.ForeColor = Color.Black
    End Sub

    Private Sub LblVerUsuarios_MouseMove(sender As Object, e As MouseEventArgs) Handles LblVerUsuarios.MouseMove
        LblVerUsuarios.ForeColor = Color.Green
    End Sub

    Private Sub LblVerUsuarios_Click(sender As Object, e As EventArgs) Handles LblVerUsuarios.Click
        TabControl1.SelectedIndex = 1
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("Ayuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath

        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpKeyword(Me, "V.USUARIO.AG")
        LLenarComboEstado()
        MostrarUsuario()

    End Sub

    Private Sub MostrarUsuario()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_MostraUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim VerUsuario As SqlDataReader
                VerUsuario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerUsuario.Read = True
                    With Me.lsvMostrar.Items.Add(VerUsuario("IdUsuario").ToString)
                        .SubItems.Add(VerUsuario("Usuario").ToString)
                        .SubItems.Add(VerUsuario("Contraseña").ToString)
                        If VerUsuario("Estado").ToString = "True" Then
                            .SubItems.Add("Activo")
                        Else
                            .SubItems.Add("Inactivo")
                        End If
                        .SubItems.Add(VerUsuario("Nombre Completo").ToString)
                        .SubItems.Add(VerUsuario("NumIdentidad").ToString)
                    End With
                End While
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Sub LLenarComboEstado()
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Valor")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Valor") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Valor") = "0"
        dr("Descripcion") = "Desactivo"
        dt.Rows.Add(dr)

        CboEstado.DataSource = dt
        CboEstado.ValueMember = "Valor"
        CboEstado.DisplayMember = "Descripcion"
    End Sub

    Private Sub CboEstado_SelectedIndexChanged(sender As Object, e As EventArgs)
        LLenarComboEstado()
    End Sub

    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        FrmPantallaPrincipal.Show()
        Me.Close()
    End Sub

    Private Sub LblAgregarUsuario_Click(sender As Object, e As EventArgs) Handles LblAgregarUsuario.Click
        LblAgregarUsuario.Enabled = False
        BtnGuardar.Enabled = True
        TabControl1.SelectedIndex = 0
    End Sub
    Private Sub lsvMostrar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsvMostrar.SelectedIndexChanged
        btnEditar.Enabled = True
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        LblAgregarUsuario.Enabled = False
        BtnModificar.Enabled = True
        LblIdUsuario.Visible = True
        LblIdNun.Text = lsvMostrar.FocusedItem.SubItems(0).Text
        TxtUsuario.Text = lsvMostrar.FocusedItem.SubItems(1).Text
        txtEmpleado.Text = lsvMostrar.FocusedItem.SubItems(5).Text
        Dim var As String = lsvMostrar.FocusedItem.SubItems(3).Text
        If var = "True" Then
            cboEstado.SelectedValue = 0
        Else
            cboEstado.SelectedValue = 1
        End If
        TabControl1.SelectedIndex = 0
        btnEditar.Enabled = False
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If Validar(TxtUsuario, "Debe ingresar un nombre de usuario") Then
        ElseIf Validar(TxtContraseña, "Debe ingresar una contraseña") Then
        ElseIf Validar(CboEstado, "Debe seleccionar un estado") Then
        ElseIf Validar(txtEmpleado, "Debe ingresar un empleado") Then
        Else
            AgregarUsuario()
            Limpiar()
            MostrarUsuario()
        End If
    End Sub
    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            ErrorProvider1.SetError(Control, Mensaje)
            Control.Focus()
            Validar = True
        Else
            Validar = False
        End If
    End Function
    Private Sub Limpiar()
        TxtUsuario.Clear()
        TxtContraseña.Clear()
        CboEstado.SelectedIndex = -1
        txtEmpleado.Clear()
        BtnGuardar.Enabled = False
        BtnModificar.Enabled = False
        LblIdNun.Visible = False
        LblIdUsuario.Visible = False
        LblAgregarUsuario.Enabled = True
    End Sub
    Private Sub AgregarUsuario()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = TxtUsuario.Text.Trim
                    .Parameters.Add("@Password", SqlDbType.NVarChar).Value = SHA1(TxtContraseña.Text.Trim)
                    .Parameters.Add("@Activo", SqlDbType.Int).Value = CInt(CboEstado.SelectedValue)
                    .Parameters.Add("@IdEmpleado", SqlDbType.Char).Value = txtEmpleado.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de usuario ha sido agregado", "MamiManda", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        If Validar(TxtUsuario, "Debe ingresar un nombre de usuario") Then
        ElseIf Validar(TxtContraseña, "Debe ingresar una contraseña") Then
        ElseIf Validar(CboEstado, "Debe seleccionar un estado") Then
        ElseIf Validar(txtEmpleado, "Debe ingresar un empleado") Then
        Else
            ActualizarUsuario()
            Limpiar()
            MostrarUsuario()

        End If
    End Sub
    Private Sub ActualizarUsuario()
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ActualizarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(LblIdNun.Text)
                    .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = TxtUsuario.Text.Trim
                    .Parameters.Add("@Password", SqlDbType.NVarChar).Value = SHA1(TxtContraseña.Text.Trim)
                    .Parameters.Add("@Activo", SqlDbType.Int).Value = CInt(CboEstado.SelectedValue)
                    .Parameters.Add("@IdEmpleado", SqlDbType.Char).Value = txtEmpleado.Text.Trim
                    .ExecuteNonQuery()
                    MessageBox.Show("El registro de usuario ha sido actualizado", "Usuario", MessageBoxButtons.OK)
                End With
            End Using
        Catch ex As Exception
            If ex.ToString.Contains("clave duplicada") Then
                MessageBox.Show("Ya se encuentra registrado este usuario", "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MsgBox(ex.Message)
            End If

        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        ListarUsuario()
        btnEditar.Enabled = False
    End Sub
    Private Sub ListarUsuario()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()

        Using cmd As New SqlCommand
            Try
                With cmd
                    .CommandText = "Sp_ListarUsuario"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@var", SqlDbType.NVarChar).Value = txtBuscar.Text.Trim
                    .Connection = cn
                End With
                Dim VerUsuario As SqlDataReader
                VerUsuario = cmd.ExecuteReader()
                lsvMostrar.Items.Clear()
                While VerUsuario.Read = True
                    With Me.lsvMostrar.Items.Add(VerUsuario("IdUsuario").ToString)
                        .SubItems.Add(VerUsuario("Usuario").ToString)
                        .SubItems.Add(VerUsuario("Contraseña").ToString)
                        If VerUsuario("Estado").ToString = "True" Then
                            .SubItems.Add("Activo")
                        Else
                            .SubItems.Add("Inactivo")
                        End If
                        .SubItems.Add(VerUsuario("Nombre Completo").ToString)
                        .SubItems.Add(VerUsuario("NumIdentidad").ToString)
                    End With
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) Handles btnEmpleado.Click
        sele = 2
        Dim BuscarEmpleado As New FrmEmpleado()
        BuscarEmpleado.Show(Me)
        BuscarEmpleado.TcEmpleado.Visible = True
        BuscarEmpleado.TcEmpleado.SelectedTab = BuscarEmpleado.TpVer
    End Sub
End Class