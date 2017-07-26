Imports System.Data.SqlClient
Public Class FrmInventario
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

                Dim MostrarEmpleado As SqlDataReader
                MostrarEmpleado = cmd.ExecuteReader
                LsvInventarioArma.Items.Clear()

                While MostrarEmpleado.Read = True
                    With LsvInventarioArma.Items.Add(MostrarEmpleado("IdArma").ToString)
                        .SubItems.Add(MostrarEmpleado("Serie").ToString)
                        .SubItems.Add(MostrarEmpleado("Calibre").ToString)
                        .SubItems.Add(MostrarEmpleado("Modelo").ToString)
                        .SubItems.Add(MostrarEmpleado("TipoArma").ToString)
                        .SubItems.Add(MostrarEmpleado("LugarFabricacion").ToString)
                        .SubItems.Add(MostrarEmpleado("NumIdentidad").ToString)


                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los empleados" + ex.Message)
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

        If txtNumidentidad.Text = Nothing Then
            ErrorProvider1.SetError(txtNumidentidad, "Campo Obligatorio")
            txtNumidentidad.Focus()
            Return
        Else
            ErrorProvider1.SetError(txtNumidentidad, "")
        End If

        Call AgregarArma()
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
                    .Parameters.Add("@NumIDentidad", SqlDbType.Char).Value = txtNumidentidad.Text
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

    Private Sub btnEmpleado_Click(sender As Object, e As EventArgs) 
        Dim empleado As New FrmEmpleado()
        sele = 1
        FrmEmpleado.Show()
        FrmEmpleado.TcEmpleado.Visible = True
        FrmEmpleado.TcEmpleado.SelectedTab = FrmEmpleado.TpVer
        txtNumidentidad.Text = FrmEmpleado.DgvVerEmpleado.CurrentRow.Cells(0).Value.ToString
    End Sub

    Private Sub Limpiar()
        txtSerie.Clear()
        txtNumidentidad.Clear()
        MskCalibre.Clear()
        cboModelo.Text = ""
        cboPaisFabricacion.Text = ""
        CboTipoArma.Text = ""
    End Sub

End Class