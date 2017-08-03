Imports System.Data.SqlClient
Public Class FrmInventario
    Dim op As Integer
    Dim User As String = FrmPantallaPrincipal.LblBienvenido.Text
    'Consulta para llenar la listview de inventario'
    Private Sub CargarArma()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_MostrarArmas"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                End With

                Dim MostrarArmas As SqlDataReader
                MostrarArmas = cmd.ExecuteReader
                LsvInventarioArma.Items.Clear()

                While MostrarArmas.Read = True
                    With LsvInventarioArma.Items.Add(MostrarArmas("IdArma").ToString)
                        .SubItems.Add(MostrarArmas("Serie").ToString)
                        .SubItems.Add(MostrarArmas("Calibre").ToString)
                        .SubItems.Add(MostrarArmas("Marca").ToString)
                        .SubItems.Add(MostrarArmas("Modelo").ToString)
                        .SubItems.Add(MostrarArmas("TipoArma").ToString)
                        .SubItems.Add(MostrarArmas("LugarFabricacion").ToString)
                        .SubItems.Add(MostrarArmas("IdContratoCliente").ToString)
                        .SubItems.Add(MostrarArmas("Estado").ToString)


                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar las Armas" + ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub LblVerArmas_Click(sender As Object, e As EventArgs) Handles LblVerArmas.Click
        Call CargarArma()
        TcArma.Visible = True
        TcArma.SelectedTab = TabPage3
    End Sub

    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        FrmPantallaPrincipal.Show()
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        If txtSerie.Text = Nothing Then
            ErrorProvider1.SetError(txtSerie, "Campo Obligatorio")
            txtSerie.Focus()
            Return
        Else
            ErrorProvider1.SetError(txtSerie, "")
        End If

        If MskCalibre.Text = Nothing Then
            ErrorProvider1.SetError(MskCalibre, "Campo Obligatorio")
            MskCalibre.Focus()
            Return
        Else
            ErrorProvider1.SetError(MskCalibre, "")
        End If

        If cboModelo.Text = Nothing Then
            ErrorProvider1.SetError(cboModelo, "Campo Obligatorio")
            cboModelo.Focus()
            Return
        Else
            ErrorProvider1.SetError(cboModelo, "")
        End If

        If CboTipoArma.Text = Nothing Then
            ErrorProvider1.SetError(CboTipoArma, "Campo Obligatorio")
            CboTipoArma.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboTipoArma, "")
        End If

        If cboPaisFabricacion.Text = Nothing Then
            ErrorProvider1.SetError(cboPaisFabricacion, "Campo Obligatorio")
            cboPaisFabricacion.Focus()
            Return
        Else
            ErrorProvider1.SetError(cboPaisFabricacion, "")
        End If

        If TxtContrato.Text = Nothing Then
            ErrorProvider1.SetError(TxtContrato, "Campo Obligatorio")
            TxtContrato.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtContrato, "")
        End If

        Call AgregarArma()
        Call AudiLogInsert()
        Call Limpiar()
    End Sub

    Private Sub LlenarModelo()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarModelo"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Modelo")
                cboModelo.DataSource = ds.Tables(0)
                cboModelo.DisplayMember = ds.Tables(0).Columns("Modelo").ToString
                cboModelo.ValueMember = ds.Tables(0).Columns("IdModelo").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub LlenarTipi()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTipoArma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoArma")
                CboTipoArma.DataSource = ds.Tables(0)
                CboTipoArma.DisplayMember = ds.Tables(0).Columns("TipoArma").ToString
                CboTipoArma.ValueMember = ds.Tables(0).Columns("IdTipoArma").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub LlenarFabricacion()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarFabricacion"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "LugarFabricacion")
                cboPaisFabricacion.DataSource = ds.Tables(0)
                cboPaisFabricacion.DisplayMember = ds.Tables(0).Columns("LugarFabricacion").ToString
                cboPaisFabricacion.ValueMember = ds.Tables(0).Columns("IdFabricacion").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub AgregarArma()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarArma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@serie", SqlDbType.NVarChar).Value = txtSerie.Text
                    .Parameters.Add("@Calibre", SqlDbType.Int).Value = Int32.Parse(MskCalibre.Text)
                    .Parameters.Add("@IdModelo", SqlDbType.Int).Value = cboModelo.SelectedValue
                    .Parameters.Add("@IdTipoArma", SqlDbType.Int).Value = CboTipoArma.SelectedValue
                    .Parameters.Add("@IdFabricacion", SqlDbType.Int).Value = cboPaisFabricacion.SelectedValue
                    .Parameters.Add("@IdContratoCliente", SqlDbType.Int).Value = TxtContrato.Text
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

    Private Sub FrmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TcArma.Visible = False
    End Sub

    Private Sub LblAgregarArma_Click(sender As Object, e As EventArgs) Handles LblAgregarArma.Click
        TcArma.Visible = True
        TcArma.SelectedTab = TabPage2
        Call LlenarModelo()
        Call LlenarTipi()
        Call LlenarFabricacion()
        cboModelo.SelectedValue = -1
        CboTipoArma.SelectedValue = -1
        cboPaisFabricacion.SelectedValue = -1

    End Sub

    Private Sub Limpiar()
        txtSerie.Clear()
        TxtContrato.Clear()
        MskCalibre.Clear()
        cboModelo.Text = ""
        cboPaisFabricacion.Text = ""
        CboTipoArma.Text = ""
    End Sub

    Private Sub PbxBuscar_Click(sender As Object, e As EventArgs) Handles PbxBuscar.Click
        FrmContrato.Show()
    End Sub

    Private Sub AudiLogInsert()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO AudiLog (Descripcion, Usuario) VALUES (@Descripcion, @Usuario)", cn)
            da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = "Se inserto el Arma con Serie: " + txtSerie.Text
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
End Class