Imports System.Data.SqlClient
Public Class FrmCatalogo
    Public catalogo As String
    Dim dt As DataTable
    Dim da As New SqlDataAdapter

    Private Sub FrmCatalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If catalogo = "profesion" Then
            Profesion()
        ElseIf catalogo = "municipio" Then
            Municipio()
            LlenarComboBox()
        ElseIf catalogo = "tipoarma" Then
            TipoArma()
        ElseIf catalogo = "marca" Then
            Marca()
            LlenarComboBox()
        ElseIf catalogo = "modelo" Then
            Modelo()
            LlenarComboBox()
        ElseIf catalogo = "fabricacion" Then
            Fabricacion()
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If catalogo = "profesion" Then
            InsertarProfesion()
        ElseIf catalogo = "municipio" Then
            InsertarMunicipio()
        ElseIf catalogo = "tipoarma" Then
            InsertarTipoArma()
        ElseIf catalogo = "marca" Then
            InsertarMarca()
        ElseIf catalogo = "modelo" Then
            InsertarModelo()
        ElseIf catalogo = "fabricacion" Then
            InsertarFabricacion()
        End If
    End Sub

    Private Sub LlenarComboBox()
        If catalogo = "municipio" Then

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            Try
                cn.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Select * from Departamento"
                        .CommandType = CommandType.Text
                        .Connection = cn
                    End With

                    Dim da As New SqlDataAdapter(cmd)
                    Dim ds As New DataSet
                    da.Fill(ds, "Departamento")
                    CboCombo.DataSource = ds.Tables("Departamento")
                    CboCombo.DisplayMember = "Departamento"
                    CboCombo.ValueMember = "IdDepto"

                    CboCombo.SelectedValue = -1
                End Using
            Catch ex As Exception
            Finally
                cn.Close()
            End Try

        ElseIf catalogo = "marca" Then

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            Try
                cn.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Select * from TipoArma"
                        .CommandType = CommandType.Text
                        .Connection = cn
                    End With

                    Dim da As New SqlDataAdapter(cmd)
                    Dim ds As New DataSet
                    da.Fill(ds, "TipoArma")
                    CboCombo.DataSource = ds.Tables("TipoArma")
                    CboCombo.DisplayMember = "TipoArma"
                    CboCombo.ValueMember = "IdTipoArma"

                    CboCombo.SelectedValue = -1
                End Using
            Catch ex As Exception
            Finally
                cn.Close()
            End Try

        ElseIf catalogo = "modelo" Then

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If

            Try
                cn.Open()
                Using cmd As New SqlCommand
                    With cmd
                        .CommandText = "Select * from Marca"
                        .CommandType = CommandType.Text
                        .Connection = cn
                    End With

                    Dim da As New SqlDataAdapter(cmd)
                    Dim ds As New DataSet
                    da.Fill(ds, "Marca")
                    CboCombo.DataSource = ds.Tables("Marca")
                    CboCombo.DisplayMember = "Marca"
                    CboCombo.ValueMember = "IdMarca"

                    CboCombo.SelectedValue = -1
                End Using
            Catch ex As Exception
            Finally
                cn.Close()
            End Try

        End If
    End Sub

    Private Sub Profesion()
        da = New SqlDataAdapter("Select * from Profesion", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvCatalogo.DataSource = dt
    End Sub

    Private Sub InsertarProfesion()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO Profesion (Profesion) VALUES (@Profesion)", cn)
            da.InsertCommand.Parameters.Add("@Profesion", SqlDbType.NVarChar).Value = TxtNombreCato.Text

            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()
                Profesion()
                TxtNombreCato.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub Municipio()
        da = New SqlDataAdapter("Select m.Municipio, d.Departamento from Municipio m inner join Departamento d on m.IdDepto = d.IdDepto", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvCatalogo.DataSource = dt
    End Sub

    Private Sub InsertarMunicipio()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO Municipio (Municipio, IdDepto) VALUES (@Municipio, @IdDepto)", cn)
            da.InsertCommand.Parameters.Add("@Municipio", SqlDbType.NVarChar).Value = TxtNombreCato.Text
            da.InsertCommand.Parameters.Add("@IdDepto", SqlDbType.Int).Value = CInt(CboCombo.SelectedValue)


            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()
                Municipio()
                TxtNombreCato.Clear()
                CboCombo.SelectedValue = -1

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub TipoArma()
        da = New SqlDataAdapter("Select * from TipoArma", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvCatalogo.DataSource = dt
    End Sub

    Private Sub InsertarTipoArma()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO TipoArma (TipoArma) VALUES (@TipoArma)", cn)
            da.InsertCommand.Parameters.Add("@TipoArma", SqlDbType.NVarChar).Value = TxtNombreCato.Text

            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()
                TipoArma()
                TxtNombreCato.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub Marca()
        da = New SqlDataAdapter("Select m.Marca, t.TipoArma from Marca m inner join TipoArma t on m.IdTipoArma = t.IdTipoArma", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvCatalogo.DataSource = dt
    End Sub

    Private Sub InsertarMarca()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO Marca (Marca, IdTipoArma) VALUES (@Marca, @IdTipoArma)", cn)
            da.InsertCommand.Parameters.Add("@Marca", SqlDbType.NVarChar).Value = TxtNombreCato.Text
            da.InsertCommand.Parameters.Add("@IdTipoArma", SqlDbType.Int).Value = CInt(CboCombo.SelectedValue)


            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()
                Marca()
                TxtNombreCato.Clear()
                CboCombo.SelectedValue = -1

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub Modelo()
        da = New SqlDataAdapter("Select m.Modelo, t.Marca from Modelo m inner join Marca t on m.IdMarca = t.IdMarca", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvCatalogo.DataSource = dt
    End Sub

    Private Sub InsertarModelo()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO Modelo (Modelo, IdMarca) VALUES (@Modelo, @IdMarca)", cn)
            da.InsertCommand.Parameters.Add("@Modelo", SqlDbType.NVarChar).Value = TxtNombreCato.Text
            da.InsertCommand.Parameters.Add("@IdMarca", SqlDbType.Int).Value = CInt(CboCombo.SelectedValue)


            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()
                Modelo()
                TxtNombreCato.Clear()
                CboCombo.SelectedValue = -1

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub Fabricacion()
        da = New SqlDataAdapter("Select * from Fabricacion", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvCatalogo.DataSource = dt
    End Sub

    Private Sub InsertarFabricacion()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO Fabricacion (LugarFabricacion) VALUES (@Fabricacion)", cn)
            da.InsertCommand.Parameters.Add("@Fabricacion", SqlDbType.NVarChar).Value = TxtNombreCato.Text

            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()
                Fabricacion()
                TxtNombreCato.Clear()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

End Class