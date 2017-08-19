Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Public Class FrmInventario
    Dim op As Integer
    Dim User As String = FrmPantallaPrincipal.LblBienvenido.Text
    'Consulta para llenar la listview de inventario'

    Private Sub LblVerArmas_Click(sender As Object, e As EventArgs) Handles LblVerArmas.Click
        sele = 2
        verificarHelp()
        Me.DataTable1TableAdapter.Fill(Me.Planillas.DataTable1)
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
                    If TxtContrato.Text = Nothing Then
                        .Parameters.Add("@IdContratoCliente", SqlDbType.Int).Value = DBNull.Value
                    Else
                        .Parameters.Add("@IdContratoCliente", SqlDbType.Int).Value = TxtContrato.Text
                    End If

                    If RdbActivo.Checked = CheckState.Unchecked Then
                        .Parameters.Add("@Estado", SqlDbType.Bit).Value = 0
                        op = 0
                    Else
                        .Parameters.Add("@Estado", SqlDbType.Bit).Value = 1
                        op = 1
                    End If
                    .Parameters.Add("@FechaPermiso", SqlDbType.Date).Value = DtpPermiso.Value
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

    Private Sub ModificarArma()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ModificarArma"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    If TxtContrato.Text = Nothing Then
                        .Parameters.Add("@IdContratoCliente", SqlDbType.Int).Value = DBNull.Value
                    Else
                        .Parameters.Add("@IdContratoCliente", SqlDbType.Int).Value = TxtContrato.Text
                    End If

                    If RdbActivo.Checked = CheckState.Unchecked Then
                        .Parameters.Add("@Estado", SqlDbType.Bit).Value = 0
                        op = 0
                    Else
                        .Parameters.Add("@Estado", SqlDbType.Bit).Value = 1
                        op = 1
                    End If
                    .Parameters.Add("@FechaPermiso", SqlDbType.Date).Value = DtpPermiso.Value
                    .Parameters.Add("@IdArma", SqlDbType.Int).Value = CInt(DgvArmas.CurrentRow.Cells(0).Value)

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
        'TODO: esta línea de código carga datos en la tabla 'Planillas.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.Fill(Me.Planillas.DataTable1)
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("Ayuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        sele = 0
        verificarHelp()
        TcArma.Visible = False
    End Sub
    Private Sub verificarHelp()
        If sele = 1 Then
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.INVENTARIO.AG")
        Else
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpKeyword(Me, "V.INVENTARIO.PRI")
        End If
    End Sub

    Private Sub LblAgregarArma_Click(sender As Object, e As EventArgs) Handles LblAgregarArma.Click
        sele = 1
        verificarHelp()
        TcArma.Visible = True
        TcArma.SelectedTab = TabPage2
        Call LlenarModelo()
        Call LlenarTipi()
        Call LlenarFabricacion()
        cboModelo.SelectedValue = -1
        CboTipoArma.SelectedValue = -1
        cboPaisFabricacion.SelectedValue = -1
        txtSerie.Enabled = True
        MskCalibre.Enabled = True
        cboModelo.Enabled = True
        CboTipoArma.Enabled = True
        cboPaisFabricacion.Enabled = True

    End Sub

    Private Sub Limpiar()
        txtSerie.Clear()
        TxtContrato.Clear()
        MskCalibre.Clear()
        cboModelo.Text = ""
        cboPaisFabricacion.Text = ""
        CboTipoArma.Text = ""
        TxtContrato.Clear()
    End Sub

    Private Sub PbxBuscar_Click(sender As Object, e As EventArgs) Handles PbxBuscar.Click
        FrmContrato.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reporte As New ReporteInventario()
        Dim viewer As New ReportPrintTool(reporte)
        viewer.ShowPreview()
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


    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call ModificarArma()
        Call Limpiar()
        Me.DataTable1TableAdapter.Fill(Me.Planillas.DataTable1)
        TcArma.SelectedTab = TabPage3
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        txtSerie.Text = DgvArmas.CurrentRow.Cells(1).Value
        MskCalibre.Text = DgvArmas.CurrentRow.Cells(2).Value
        cboModelo.Text = DgvArmas.CurrentRow.Cells(4).Value
        CboTipoArma.Text = DgvArmas.CurrentRow.Cells(5).Value
        cboPaisFabricacion.Text = DgvArmas.CurrentRow.Cells(6).Value

        If DgvArmas.CurrentRow.Cells(7).Value Is DBNull.Value Then
            TxtContrato.Text = Nothing
        Else
            TxtContrato.Text = DgvArmas.CurrentRow.Cells(7).Value
        End If

        DtpPermiso.Value = DgvArmas.CurrentRow.Cells(9).Value

        If DgvArmas.CurrentRow.Cells(8).Value = True Then
            RdbActivo.Checked = True
        Else
            RdbInactivo.Checked = True
        End If

        txtSerie.Enabled = False
        MskCalibre.Enabled = False
        cboModelo.Enabled = False
        CboTipoArma.Enabled = False
        cboPaisFabricacion.Enabled = False
        TcArma.SelectedTab = TabPage2
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        FrmPermisosArmas.ShowDialog()
    End Sub

    Private Sub Label11_MouseMove(sender As Object, e As MouseEventArgs) Handles Label11.MouseMove
        Label11.ForeColor = Color.Green
    End Sub

    Private Sub Label11_MouseLeave(sender As Object, e As EventArgs) Handles Label11.MouseLeave
        Label11.ForeColor = Color.Black
    End Sub

    Private Sub LblVerArmas_MouseMove(sender As Object, e As MouseEventArgs) Handles LblVerArmas.MouseMove
        LblVerArmas.ForeColor = Color.Green
    End Sub

    Private Sub LblVerArmas_MouseLeave(sender As Object, e As EventArgs) Handles LblVerArmas.MouseLeave
        LblVerArmas.ForeColor = Color.Black
    End Sub

    Private Sub LblAgregarArma_MouseMove(sender As Object, e As MouseEventArgs) Handles LblAgregarArma.MouseMove
        LblAgregarArma.ForeColor = Color.Green
    End Sub

    Private Sub LblAgregarArma_MouseLeave(sender As Object, e As EventArgs) Handles LblAgregarArma.MouseLeave
        LblAgregarArma.ForeColor = Color.Black
    End Sub
End Class