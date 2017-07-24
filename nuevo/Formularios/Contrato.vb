﻿Imports System.Data.SqlClient
Public Class FrmContrato
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim da As New SqlDataAdapter

    'Consulta en sql para llenar el datagridview de contrato empleado y cliente'
    Public Sub MostrarDatosContratoEmpleado()
        da = New SqlDataAdapter("select c.IdContratoEmpleado,c.FechaInicio,c.FechaFinal,c.SueldoBase,t.TipoEmpleado,ti.TipoContrato
                                 from ContratoEmpleado c inner join TipoEmpleado t
							                                on c.IdTipoEmpleado = t.IdTipoEmpleado
						                                 inner join TipoContrato ti
							                                on c.IdTipoContrato = ti.IdTipoContrato", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvContrato.DataSource = dt
    End Sub

    Public Sub MostrarDatosContratoCliente()
        da = New SqlDataAdapter("select *
                                 from ContratoCliente", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvContrato.DataSource = dt
    End Sub

    'llamamiento de la funcion para llenar el datagridview'
    Private Sub LblVerContratoEmple_Click(sender As Object, e As EventArgs) Handles LblVerContratoEmple.Click
        Call MostrarDatosContratoEmpleado()
        TpContrato.Visible = True
        TpContrato.SelectedTab = TabPage3
    End Sub

    Private Sub LblVerContratoClien_Click(sender As Object, e As EventArgs) Handles LblVerContratoClien.Click
        Call MostrarDatosContratoCliente()
        TpContrato.Visible = True
        TpContrato.SelectedTab = TabPage3
    End Sub

    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim sueldo As Decimal
        Decimal.TryParse(txtsueldo.Text, sueldo)
        If (txtsueldo.Text = "") Then
            ErrorProvider1.SetError(txtsueldo, "Ingrese un Sueldo")
            txtsueldo.Focus()
            Return
        ElseIf sueldo <= 0 Then
            ErrorProvider1.SetError(txtsueldo, "Ingrese un sueldo valido")
            txtsueldo.Focus()
            Return
        Else
            ErrorProvider1.SetError(txtsueldo, "")
        End If

        If CboTipoEmpleado.Text = Nothing Then
            ErrorProvider1.SetError(CboTipoEmpleado, "Ingrese el tipo de empleado")
            CboTipoEmpleado.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboTipoEmpleado, "")
        End If

        If CboTipoContrato.Text = Nothing Then
            ErrorProvider1.SetError(CboTipoContrato, "Ingrese el tipo de contrato")
            CboTipoContrato.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboTipoContrato, "")
        End If
        Call Agregarcontrato()
        Call Limpiar()

    End Sub

    Private Sub LlenarTipoEmpleado()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTipoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoEmpleado")
                CboTipoEmpleado.DataSource = ds.Tables(0)
                CboTipoEmpleado.DisplayMember = ds.Tables(0).Columns("TipoEmpleado").ToString
                CboTipoEmpleado.ValueMember = ds.Tables(0).Columns("IdTipoEmpleado").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub LlenarTipoContrato()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTipoContrato"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoContrato")
                CboTipoContrato.DataSource = ds.Tables(0)
                CboTipoContrato.DisplayMember = ds.Tables(0).Columns("TipoContrato").ToString
                CboTipoContrato.ValueMember = ds.Tables(0).Columns("IdTipoContrato").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Agregarcontrato()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarContratoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@FechaInicio", SqlDbType.Date).Value = dtpInicio.Value
                    .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = dtpfinal.Value
                    .Parameters.Add("@SueldoBase", SqlDbType.Money).Value = Convert.ToDecimal(txtsueldo.Text)
                    .Parameters.Add("@IdTipoEmpleado", SqlDbType.Int).Value = CboTipoEmpleado.SelectedValue
                    .Parameters.Add("@IdTipoContrato", SqlDbType.Int).Value = CboTipoContrato.SelectedValue
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
        txtsueldo.Clear()
        CboTipoContrato.Text = ""
        CboTipoEmpleado.Text = ""
    End Sub

    Private Sub FrmContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TpContrato.Visible = False
        Call LlenarTipoContrato()
        Call LlenarTipoEmpleado()
    End Sub

    Private Sub LblAgregarContratoEmp_Click(sender As Object, e As EventArgs) Handles LblAgregarContratoEmp.Click
        TpContrato.Visible = True
        TpContrato.SelectedTab = TabPage1
        CboTipoContrato.Text = ""
        CboTipoEmpleado.Text = ""
    End Sub

    Private Sub LblAgregarContratoClien_Click(sender As Object, e As EventArgs) Handles LblAgregarContratoClien.Click
        TpContrato.Visible = True
        TpContrato.SelectedTab = TabPage2

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sueldo As Decimal
        Decimal.TryParse(txtMonto.Text, sueldo)
        If (txtMonto.Text = "") Then
            ErrorProvider1.SetError(txtMonto, "Ingrese un Monto Estipulado")
            txtMonto.Focus()
            Return
        ElseIf sueldo <= 0 Then
            ErrorProvider1.SetError(txtMonto, "Ingrese un Monto Estipulado valido")
            txtMonto.Focus()
            Return
        Else
            ErrorProvider1.SetError(txtMonto, "")
        End If

        Call AgregarcontratoCiente()
        Call LimpiarCliente()

    End Sub

    Private Sub AgregarcontratoCiente()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarContratoCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@FechaInicio", SqlDbType.Date).Value = dtpFechaInicio.Value
                    .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = dtpFechaFinal.Value
                    .Parameters.Add("@Monto", SqlDbType.Money).Value = Convert.ToDecimal(txtMonto.Text)
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar).Value = txtObservacion.Text
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
    Private Sub LimpiarCliente()
        txtMonto.Clear()
        txtObservacion.Clear()
    End Sub


    Private Sub txtsueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsueldo.KeyPress
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

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
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
End Class
