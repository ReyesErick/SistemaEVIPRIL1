Imports System.Data.SqlClient
Public Class FrmCatalogo_Depa
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        AgergarDepartamento()
        TxtNombre.Clear()
        CboCatalogo.Text = ""
        Call CargarDepatamento()
    End Sub
    Private Sub AgergarDepartamento()
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@Departamento", SqlDbType.NVarChar).Value = TxtNombre.Text
                    .Parameters.Add("@IdPais", SqlDbType.Int).Value = CboCatalogo.SelectedValue
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

    Private Sub CargarDepatamento()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_MostrarDepartamento"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                End With

                Dim MostrarDepartamento As SqlDataReader
                MostrarDepartamento = cmd.ExecuteReader
                LsvCatalogo.Items.Clear()

                While MostrarDepartamento.Read = True
                    With LsvCatalogo.Items.Add(MostrarDepartamento("IdDepto").ToString)
                        .SubItems.Add(MostrarDepartamento("Departamento").ToString)
                        .SubItems.Add(MostrarDepartamento("Pais").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los Departamentos" + ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmCatalogo_Depa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarDepatamento()
        Call CargarPais()
        CboCatalogo.Text = ""
    End Sub

    Private Sub CargarPais()
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_CargarPais"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "Pais")
                CboCatalogo.DataSource = ds.Tables(0)
                CboCatalogo.DisplayMember = ds.Tables(0).Columns("Pais").ToString
                CboCatalogo.ValueMember = ds.Tables(0).Columns("IdPais").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub
End Class