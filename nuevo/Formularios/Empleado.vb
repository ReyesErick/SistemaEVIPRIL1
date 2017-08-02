Imports System.Data.SqlClient
Imports System.IO
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraReports.UI

Public Class FrmEmpleado
    Dim op As Integer
    Dim seleccion As Integer
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim da As New SqlDataAdapter

    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call CargarEstadoCivil()
        Call CargarProfesion()
        Call CargarNacionalidad()
        Call CargarSexo()
        Call CargarMunicipio()
        Call CargarEmpleado()
        CboEstadoCivil.SelectedValue = -1
        CboMunicipio.SelectedValue = -1
        CboNacionalidad.SelectedValue = -1
        CboProfesion.SelectedValue = -1
        CboSexo.SelectedValue = -1
        TxtBeneficiario.Text = ""
        TxtNumIdentidad.Enabled = False
        TxtNombres.Enabled = False
        TxtApellidos.Enabled = False
    End Sub

    Private Sub LblAgregarEmpleado_MouseLeave(sender As Object, e As EventArgs) Handles LblAgregarEmpleado.MouseLeave
        LblAgregarEmpleado.ForeColor = Color.Black
    End Sub

    Private Sub LblAgregarEmpleado_MouseMove(sender As Object, e As MouseEventArgs) Handles LblAgregarEmpleado.MouseMove
        LblAgregarEmpleado.ForeColor = Color.Green
    End Sub

    Private Sub LblVerContratoClien_MouseLeave(sender As Object, e As EventArgs) Handles LblVerContratoClien.MouseLeave
        LblVerContratoClien.ForeColor = Color.Black
    End Sub

    Private Sub LblVerContratoClien_MouseMove(sender As Object, e As MouseEventArgs) Handles LblVerContratoClien.MouseMove
        LblVerContratoClien.ForeColor = Color.Green
    End Sub

    Private Sub LblAgregarEmpleado_Click(sender As Object, e As EventArgs) Handles LblAgregarEmpleado.Click
        TcEmpleado.Visible = True
        Me.TcEmpleado.SelectedTab = TpAgregar
        BtnModificar.Enabled = False
        TxtNumIdentidad.Enabled = True
        TxtNombres.Enabled = True
        TxtApellidos.Enabled = True
    End Sub

    Private Sub LblVerContratoClien_Click(sender As Object, e As EventArgs) Handles LblVerContratoClien.Click
        TcEmpleado.Visible = True
        Me.TcEmpleado.SelectedTab = TpVer
        Call CargarEmpleado()
    End Sub



    Private Sub AgregarEmpleado()

        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If

        cn.Open()
        Dim foto As Byte()
        'para agregar la foto
        If FotoAgregar.Image Is Nothing Then
            foto = Nothing
        Else
            foto = ImageToByte(FotoAgregar.Image)
        End If

        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtNumIdentidad.Text
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = TxtNombres.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar).Value = TxtApellidos.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char).Value = MskTelefono.Text
                    .Parameters.Add("@Correo", SqlDbType.NVarChar).Value = TxtCorreo.Text
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CboProfesion.SelectedValue
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CboNacionalidad.SelectedValue
                    .Parameters.Add("@IdMunicipio", SqlDbType.Int).Value = CboMunicipio.SelectedValue
                    .Parameters.Add("@IdBeneficiario", SqlDbType.Int).Value = CInt(txtIdBeneficiario.Text)
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CboEstadoCivil.SelectedValue
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                    .Parameters.Add("@Rtn", SqlDbType.Char).Value = TxtRTN.Text
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar).Value = TxtObservacion.Text
                    .Parameters.Add("@NumSeguro", SqlDbType.Char).Value = TxtNumSeguro.Text
                    'esto es en los parametros
                    If foto Is Nothing Then
                        .Parameters.Add("@Fotografia", SqlDbType.Image).Value = DBNull.Value
                    Else
                        .Parameters.Add("@Fotografia", SqlDbType.Image).Value = foto
                    End If

                    If RdbActivo.Checked = CheckState.Unchecked Then
                        .Parameters.Add("@Estado", SqlDbType.Bit).Value = 0
                        op = 0
                    Else
                        .Parameters.Add("@Estado", SqlDbType.Bit).Value = 1
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

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNumIdentidad.Text = Nothing Then
            ErrorProvider1.SetError(TxtNumIdentidad, "Campo Obligatorio")
            TxtNumIdentidad.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtNumIdentidad, "")
        End If
        If TxtNombres.Text = Nothing Then
            ErrorProvider1.SetError(TxtNombres, "Campo Obligatorio")
            TxtNombres.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtNombres, "")
        End If
        If TxtApellidos.Text = Nothing Then
            ErrorProvider1.SetError(TxtApellidos, "Campo Obligatorio")
            TxtApellidos.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtApellidos, "")
        End If
        If TxtDireccion.Text = Nothing Then
            ErrorProvider1.SetError(TxtDireccion, "Campo Obligatorio")
            TxtDireccion.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtDireccion, "")
        End If
        If MskTelefono.Text = Nothing Then
            ErrorProvider1.SetError(MskTelefono, "Campo Obligatorio")
            MskTelefono.Focus()
            Return
        Else
            ErrorProvider1.SetError(MskTelefono, "")
        End If
        If CboEstadoCivil.Text = Nothing Then
            ErrorProvider1.SetError(CboEstadoCivil, "Campo Obligatorio")
            CboEstadoCivil.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboEstadoCivil, "")
        End If
        If CboSexo.Text = Nothing Then
            ErrorProvider1.SetError(CboSexo, "Campo Obligatorio")
            CboSexo.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboSexo, "")
        End If
        If TxtBeneficiario.Text = Nothing Then
            ErrorProvider1.SetError(TxtBeneficiario, "Campo Obligatorio")
            TxtBeneficiario.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtBeneficiario, "")
        End If
        If CboProfesion.Text = Nothing Then
            ErrorProvider1.SetError(CboProfesion, "Campo Obligatorio")
            CboProfesion.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboProfesion, "")
        End If
        If CboNacionalidad.Text = Nothing Then
            ErrorProvider1.SetError(CboNacionalidad, "Campo Obligatorio")
            CboNacionalidad.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboNacionalidad, "")
        End If
        If CboMunicipio.Text = Nothing Then
            ErrorProvider1.SetError(CboMunicipio, "Campo Obligatorio")
            CboMunicipio.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboMunicipio, "")
        End If

        Call AgregarEmpleado()
        Call Limpiar()
    End Sub

    Private Sub CargarEstadoCivil()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If

        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarEstadoCivil"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "EstadoCivil")
                CboEstadoCivil.DataSource = ds.Tables(0)
                CboEstadoCivil.DisplayMember = ds.Tables(0).Columns("EstadoCivil").ToString
                CboEstadoCivil.ValueMember = ds.Tables(0).Columns("IdEstadoCivil").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarProfesion()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If


        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarProfesion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Profesion")
                CboProfesion.DataSource = ds.Tables(0)
                CboProfesion.DisplayMember = ds.Tables(0).Columns("Profesion").ToString
                CboProfesion.ValueMember = ds.Tables(0).Columns("IdProfesion").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarNacionalidad()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If

        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarNacionalidad"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Nacionalidad")
                CboNacionalidad.DataSource = ds.Tables(0)
                CboNacionalidad.DisplayMember = ds.Tables(0).Columns("Nacionalidad").ToString
                CboNacionalidad.ValueMember = ds.Tables(0).Columns("IdNacionalidad").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarSexo()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If

        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_Mostrarsexo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Sexo")
                CboSexo.DataSource = ds.Tables(0)
                CboSexo.DisplayMember = ds.Tables(0).Columns("Sexo").ToString
                CboSexo.ValueMember = ds.Tables(0).Columns("IdSexo").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CargarMunicipio()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If

        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarMunicipio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Municipio")
                CboMunicipio.DataSource = ds.Tables(0)
                CboMunicipio.DisplayMember = ds.Tables(0).Columns("Municipio").ToString
                CboMunicipio.ValueMember = ds.Tables(0).Columns("IdMunicipio").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub


    Private Sub BtnAgregarImagen_Click(sender As Object, e As EventArgs) Handles BtnAgregarImagen.Click
        'Codigo para agregar una foto al picturebox	
        AbrirFoto.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        AbrirFoto.Filter = "Imágenes (*.png, *.jpg)|*.png;*.jpg"
        AbrirFoto.FileName = "Seleccionar Imagen"
        If AbrirFoto.ShowDialog = DialogResult.OK Then
            FotoAgregar.Image = Image.FromFile(AbrirFoto.FileName)
        End If
    End Sub

    Private Function ImageToByte(ByVal img As Image) As Byte()
        Dim ms As MemoryStream = New MemoryStream()

        img.Save(ms, Imaging.ImageFormat.Png)

        ms.Close()
        Dim byteArray As Byte() = ms.ToArray()
        ms.Dispose()

        Return byteArray

    End Function


    Private Sub ModificarEmpleado()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        'para agregar la foto
        Dim foto As Byte()
        If FotoAgregar.Image Is Nothing Then
            foto = Nothing
        Else
            foto = ImageToByte(FotoAgregar.Image)
        End If
        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ModificarEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    'establecer los parametros que espera el procedimiento almacenado

                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 100).Value = TxtNombres.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 100).Value = TxtApellidos.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 100).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = MskTelefono.Text
                    .Parameters.Add("@Correo", SqlDbType.NVarChar, 50).Value = TxtCorreo.Text
                    .Parameters.Add("@IdProfesion", SqlDbType.Int).Value = CboProfesion.SelectedValue
                    .Parameters.Add("@IdNacionalidad", SqlDbType.Int).Value = CboNacionalidad.SelectedValue
                    .Parameters.Add("@IdMunicipio", SqlDbType.Int).Value = CboMunicipio.SelectedValue
                    .Parameters.Add("@IdBeneficiario", SqlDbType.Int).Value = CInt(txtIdBeneficiario.Text)
                    .Parameters.Add("@IdEstadoCivil", SqlDbType.Int).Value = CboEstadoCivil.SelectedValue
                    .Parameters.Add("@IdSexo", SqlDbType.Int).Value = CboSexo.SelectedValue
                    .Parameters.Add("@Rtn", SqlDbType.Char, 14).Value = TxtRTN.Text
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar, 300).Value = TxtObservacion.Text
                    .Parameters.Add("@NumSeguro", SqlDbType.Char, 14).Value = TxtNumSeguro.Text
                    If FotoAgregar Is Nothing Then
                        .Parameters.Add("@Fotografia", SqlDbType.Image).Value = DBNull.Value
                    Else
                        .Parameters.Add("@Fotografia", SqlDbType.Image).Value = foto
                    End If

                    If RdbActivo.Checked = CheckState.Unchecked Then
                        .Parameters.Add("@Estado", SqlDbType.Bit).Value = 0
                        op = 0
                    Else
                        .Parameters.Add("@Estado", SqlDbType.Bit).Value = 1
                        op = 1
                    End If

                    .Parameters.Add("@NumIdentidad", SqlDbType.Char, 13).Value = TxtNumIdentidad.Text
                    .ExecuteNonQuery()
                    MessageBox.Show("Registro Modificado satisfactoriamente", "SeguridadLeon")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al  Modificar el empleado" + ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    'Llenar el datagridview de datos'
    Private Sub CargarEmpleado()
        da = New SqlDataAdapter("exec Sp_MostrarEmpleado", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvVerEmpleado.DataSource = dt

        Call CreateGraphics()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call ModificarEmpleado()
        Call Limpiar()
        Call CargarEmpleado()
        TcEmpleado.SelectedTab = TpVer
    End Sub


    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        FrmPantallaPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click

        Try
            If DgvVerEmpleado.CurrentRow.Cells(0).Value IsNot Nothing Then
                seleccion = 1
                If (sele = 2) Then

                Else
                    TxtNumIdentidad.Enabled = False
                    TxtNombres.Enabled = False
                    TxtApellidos.Enabled = False
                    TxtNumIdentidad.Text = DgvVerEmpleado.CurrentRow.Cells(0).Value
                    TxtNombres.Text = DgvVerEmpleado.CurrentRow.Cells(1).Value
                    TxtApellidos.Text = DgvVerEmpleado.CurrentRow.Cells(2).Value
                    TxtDireccion.Text = DgvVerEmpleado.CurrentRow.Cells(3).Value
                    MskTelefono.Text = DgvVerEmpleado.CurrentRow.Cells(4).Value
                    TxtCorreo.Text = DgvVerEmpleado.CurrentRow.Cells(5).Value
                    CboProfesion.Text = DgvVerEmpleado.CurrentRow.Cells(6).Value
                    CboNacionalidad.Text = DgvVerEmpleado.CurrentRow.Cells(7).Value
                    CboMunicipio.Text = DgvVerEmpleado.CurrentRow.Cells(8).Value
                    txtIdBeneficiario.Text = DgvVerEmpleado.CurrentRow.Cells(9).Value
                    TxtBeneficiario.Text = DgvVerEmpleado.CurrentRow.Cells(10).Value
                    CboEstadoCivil.Text = DgvVerEmpleado.CurrentRow.Cells(11).Value
                    CboSexo.Text = DgvVerEmpleado.CurrentRow.Cells(12).Value

                    Call MostrarImagen()
                    TcEmpleado.SelectedTab = TpAgregar

                    If DgvVerEmpleado.CurrentRow.Cells(13).Value IsNot Nothing Then
                        TxtRTN.Text = DgvVerEmpleado.CurrentRow.Cells(13).Value.ToString
                    Else
                        TxtRTN.Text = ""
                    End If

                    If DgvVerEmpleado.CurrentRow.Cells(14).Value IsNot Nothing Then
                        TxtObservacion.Text = DgvVerEmpleado.CurrentRow.Cells(14).Value.ToString
                    Else
                        TxtObservacion.Text = ""
                    End If

                    If DgvVerEmpleado.CurrentRow.Cells(16).Value IsNot Nothing Then
                        TxtNumSeguro.Text = DgvVerEmpleado.CurrentRow.Cells(16).Value.ToString
                    Else
                        TxtNumSeguro.Text = ""
                    End If

                    TcEmpleado.SelectedTab = TpAgregar
                    BtnModificar.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    'funcion para llenar el picturebox con la imagen cuando se le da a editar en listView

    Private Sub MostrarImagen()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        cn.Open()
        Dim command As New SqlCommand("SELECT Fotografia FROM Empleado where NumIdentidad = @char", cn)
        command.Parameters.Add("@char", SqlDbType.VarChar).Value = DgvVerEmpleado.CurrentRow.Cells(0).Value

        Dim table As New DataTable()
        Dim adapter As New SqlDataAdapter(command)
        adapter.Fill(table)
        If seleccion = 1 Then
            If IsDBNull(table.Rows(0)(0)) Then
            Else
                Dim img() As Byte
                img = table.Rows(0)(0)
                Dim ms As New MemoryStream(img)
                FotoAgregar.Image = Image.FromStream(ms)
            End If
        ElseIf seleccion = 2 Then
            If IsDBNull(table.Rows(0)(0)) Then
            Else
                Dim img() As Byte
                img = table.Rows(0)(0)
                Dim ms As New MemoryStream(img)
                PerfilEmpleado.FotoAgregar.Image = Image.FromStream(ms)
            End If
        End If
    End Sub


    Private Sub Limpiar()
        TxtNumIdentidad.Clear()
        TxtNombres.Clear()
        TxtApellidos.Clear()
        TxtDireccion.Clear()
        MskTelefono.Clear()
        TxtCorreo.Clear()
        TxtRTN.Clear()
        TxtObservacion.Clear()
        TxtNumSeguro.Clear()
        FotoAgregar.Image = Nothing
        CboEstadoCivil.SelectedValue = -1
        CboMunicipio.SelectedValue = -1
        CboNacionalidad.SelectedValue = -1
        CboProfesion.SelectedValue = -1
        CboSexo.SelectedValue = -1
        TxtBeneficiario.Clear()
        txtIdBeneficiario.Clear()
    End Sub

    Private Sub DgvVerEmpleado_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVerEmpleado.CellContentDoubleClick
        If sele = 1 Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnBuscarBeneficiario_Click(sender As Object, e As EventArgs) Handles BtnBuscarBeneficiario.Click
        sele = 1
        FrmBeneficiario.Show()
        FrmBeneficiario.TabControl1.SelectedTab = FrmBeneficiario.TabPage3
    End Sub


    Private Sub TxtNumIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumIdentidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Public Sub CreateGraphicsColumn()

        Dim treeIcon As New Icon(Me.GetType(), "tree.ico")
        Dim iconColumn As New DataGridViewImageColumn()

        With iconColumn
            .Image = treeIcon.ToBitmap()
            .Name = "Tree"
            .HeaderText = "Nice tree"
        End With

        DgvVerEmpleado.Columns.Insert(17, iconColumn)

    End Sub


    Private Sub TxtRTN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRTN.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Private Sub TxtNumSeguro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumSeguro.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    Private Sub DgvVerEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles DgvVerEmpleado.DoubleClick
        If sele = 2 Then
            FrmUsuario.txtEmpleado.Text = DgvVerEmpleado.CurrentRow.Cells(0).Value
            Me.Close()
        End If

        If sele = 5 Then
            FrmContrato.TxtNumIdentidad.Text = DgvVerEmpleado.CurrentRow.Cells(0).Value
            Me.Close()
        End If

        If sele = 6 Then
            FrmContrato.TxtGuardias.Text = DgvVerEmpleado.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub VerPerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPerfilToolStripMenuItem.Click
        seleccion = 2
        If (sele = 2) Then

        Else
            PerfilEmpleado.TxtNumIdentidad.Text = DgvVerEmpleado.CurrentRow.Cells(0).Value
            PerfilEmpleado.TxtNombres.Text = DgvVerEmpleado.CurrentRow.Cells(1).Value
            PerfilEmpleado.TxtApellidos.Text = DgvVerEmpleado.CurrentRow.Cells(2).Value
            PerfilEmpleado.TxtDireccion.Text = DgvVerEmpleado.CurrentRow.Cells(3).Value
            PerfilEmpleado.MskTelefono.Text = DgvVerEmpleado.CurrentRow.Cells(4).Value
            PerfilEmpleado.TxtCorreo.Text = DgvVerEmpleado.CurrentRow.Cells(5).Value
            PerfilEmpleado.txtProfesion.Text = DgvVerEmpleado.CurrentRow.Cells(6).Value
            PerfilEmpleado.txtNacionalidad.Text = DgvVerEmpleado.CurrentRow.Cells(7).Value
            PerfilEmpleado.txtMunicipio.Text = DgvVerEmpleado.CurrentRow.Cells(8).Value
            PerfilEmpleado.txtIdBeneficiario.Text = DgvVerEmpleado.CurrentRow.Cells(9).Value
            PerfilEmpleado.TxtBeneficiario.Text = DgvVerEmpleado.CurrentRow.Cells(10).Value
            PerfilEmpleado.txtEstadoCivil.Text = DgvVerEmpleado.CurrentRow.Cells(11).Value
            PerfilEmpleado.txtSexo.Text = DgvVerEmpleado.CurrentRow.Cells(12).Value

            Call MostrarImagen()

            If DgvVerEmpleado.CurrentRow.Cells(13).Value IsNot Nothing Then
                PerfilEmpleado.TxtRTN.Text = DgvVerEmpleado.CurrentRow.Cells(13).Value.ToString
            Else
                PerfilEmpleado.TxtRTN.Text = ""
            End If

            If DgvVerEmpleado.CurrentRow.Cells(14).Value IsNot Nothing Then
                PerfilEmpleado.TxtObservacion.Text = DgvVerEmpleado.CurrentRow.Cells(14).Value.ToString
            Else
                PerfilEmpleado.TxtObservacion.Text = ""
            End If

            If DgvVerEmpleado.CurrentRow.Cells(16).Value IsNot Nothing Then
                PerfilEmpleado.TxtNumSeguro.Text = DgvVerEmpleado.CurrentRow.Cells(16).Value.ToString
            Else
                PerfilEmpleado.TxtNumSeguro.Text = ""
            End If
        End If

        PerfilEmpleado.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reporte As New ReporteEmpleado()
        Dim viewer As New ReportPrintTool(reporte)
        viewer.ShowPreview()
    End Sub


    Private Sub DgvVerEmpleado_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles DgvVerEmpleado.DefaultValuesNeeded
        Dim id As Stream = DgvVerEmpleado.CurrentRow.Cells(0).Value
        Dim rpt As New Evipril()
        Dim printTool As New ReportPrintTool(rpt)
        printTool.ShowRibbonPreview()
    End Sub
End Class