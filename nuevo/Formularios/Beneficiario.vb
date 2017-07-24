Imports System.Data.SqlClient
Public Class FrmBeneficiario
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim da As New SqlDataAdapter
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TxtNumIdentidad.TextChanged

    End Sub

    Private Sub FrmBeneficiario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (sele = 1) Then
            Call CargarBeneficiario()
            TabControl1.Visible = True
            TabControl1.SelectedTab = TabPage2
        Else
            TabControl1.Visible = False
            txtIdBeneficiario.Enabled = False
            TxtNumIdentidad.Enabled = False
            TxtApellidosBeneficiario.Enabled = False
            TxtNombreBeneficiario.Enabled = False
        End If
    End Sub

    Private Sub LblAgregarBeneficiario_Click(sender As Object, e As EventArgs) Handles LblAgregarBeneficiario.Click
        TxtNombreBeneficiario.Enabled = True
        TxtApellidosBeneficiario.Enabled = True
        TxtNumIdentidad.Enabled = True
        TabControl1.SelectedTab = TabPage2
        TabControl1.Visible = True
    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        If (sele = 1) Then
            FrmEmpleado.TxtBeneficiario.Text = DgvBeneficiario.CurrentRow.Cells(1).Value.ToString()
            FrmEmpleado.txtIdBeneficiario.Text = DgvBeneficiario.CurrentRow.Cells(0).Value.ToString()
            Me.Dispose()
        Else
            txtIdBeneficiario.Enabled = False
            TxtNumIdentidad.Enabled = False
            TxtApellidosBeneficiario.Enabled = False
            TxtNombreBeneficiario.Enabled = False
            txtIdBeneficiario.Text = DgvBeneficiario.CurrentRow.Cells(0).Value
            TxtNombreBeneficiario.Text = DgvBeneficiario.CurrentRow.Cells(1).Value
            TxtApellidosBeneficiario.Text = DgvBeneficiario.CurrentRow.Cells(2).Value
            TxtDireccion.Text = DgvBeneficiario.CurrentRow.Cells(3).Value
            MsktTelf1.Text = DgvBeneficiario.CurrentRow.Cells(4).Value
            MskTel2.Text = DgvBeneficiario.CurrentRow.Cells(5).Value
            TxtNumIdentidad.Text = DgvBeneficiario.CurrentRow.Cells(6).Value
            TabControl1.SelectedTab = TabPage2
        End If
    End Sub

    'Funcion para llenar el datagridview'
    Private Sub CargarBeneficiario()
        da = New SqlDataAdapter("Sp_MostrarBeneficiario", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvBeneficiario.DataSource = dt
    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If TxtNombreBeneficiario.Text = Nothing Then
            ErrorProvider1.SetError(TxtNombreBeneficiario, "Campo Obligatorio")
            TxtNombreBeneficiario.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtNombreBeneficiario, "")
        End If
        If TxtApellidosBeneficiario.Text = Nothing Then
            ErrorProvider1.SetError(TxtApellidosBeneficiario, "Campo Obligatorio")
            TxtApellidosBeneficiario.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtApellidosBeneficiario, "")
        End If
        If TxtNumIdentidad.Text = Nothing Then
            ErrorProvider1.SetError(TxtNumIdentidad, "Campo Obligatorio")
            TxtNumIdentidad.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtNumIdentidad, "")
        End If
        If TxtDireccion.Text = Nothing Then
            ErrorProvider1.SetError(TxtDireccion, "Campo Obligatorio")
            TxtDireccion.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtDireccion, "")
        End If
        If MsktTelf1.Text = Nothing Then
            ErrorProvider1.SetError(MsktTelf1, "Campo Obligatorio")
            MsktTelf1.Focus()
            Return
        Else
            ErrorProvider1.SetError(MsktTelf1, "")
        End If
        Call AgregarBeneficiario()
        Call Limpiar()
    End Sub

    Private Sub AgregarBeneficiario()
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarBeneficiario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@Nombres", SqlDbType.NVarChar).Value = TxtNombreBeneficiario.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar).Value = TxtApellidosBeneficiario.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char).Value = MsktTelf1.Text
                    .Parameters.Add("@TelefonoAuxiliar", SqlDbType.Char).Value = MskTel2.Text
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtNumIdentidad.Text
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

    Private Sub Limpiar()
        TxtNumIdentidad.Clear()
        TxtNombreBeneficiario.Clear()
        TxtApellidosBeneficiario.Clear()
        TxtDireccion.Clear()
        MsktTelf1.Clear()
        MskTel2.Clear()
        txtIdBeneficiario.Clear()
    End Sub

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call EditarBeneficiario()
        Call Limpiar()
    End Sub

    'Funcion para Modificar a un Beneficiario'
    Private Sub EditarBeneficiario()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ModificarBeneficiario"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    'establecer los parametros que espera el procedimiento almacenado
                    .Parameters.Add("@Nombres", SqlDbType.NVarChar, 100).Value = TxtNombreBeneficiario.Text
                    .Parameters.Add("@Apellidos", SqlDbType.NVarChar, 100).Value = TxtApellidosBeneficiario.Text
                    .Parameters.Add("@Direccion", SqlDbType.NVarChar, 300).Value = TxtDireccion.Text
                    .Parameters.Add("@Telefono", SqlDbType.Char, 9).Value = MsktTelf1.Text
                    .Parameters.Add("@TelefonoAuxiliar", SqlDbType.Char, 9).Value = MskTel2.Text
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char, 13).Value = TxtNumIdentidad.Text
                    .Parameters.Add("@IdBeneficiario", SqlDbType.Int).Value = txtIdBeneficiario.Text
                    .ExecuteNonQuery()
                    MessageBox.Show("Registro Modificado satisfactoriamente", "SeguridadLeon")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al  Modificar el Beneficiario" + ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub LblVerBeneficiario_Click(sender As Object, e As EventArgs) Handles LblVerBeneficiario.Click
        TabControl1.SelectedTab = TabPage3
        TabControl1.Visible = True
        Call CargarBeneficiario()
    End Sub

    Private Sub DgvBeneficiario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvBeneficiario.CellContentClick
        If sele = 1 Then
            FrmEmpleado.txtIdBeneficiario.Text = DgvBeneficiario.CurrentRow.Cells(0).Value.ToString
            FrmEmpleado.TxtBeneficiario.Text = DgvBeneficiario.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        Else

        End If
    End Sub
End Class