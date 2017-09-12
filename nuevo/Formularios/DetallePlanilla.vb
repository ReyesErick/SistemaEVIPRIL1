Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Public Class FrmDetallePlanilla
    Public Property IdPlanilla As Integer


    Private Sub ImprimirVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirVoucherToolStripMenuItem.Click
        Dim idp As Integer = DetallePlanillaDataGridView.CurrentRow.Cells(0).Value
        Dim numid As String = DetallePlanillaDataGridView.CurrentRow.Cells(1).Value

        Dim Voucher As New RptVoucher(idp, numid)
        Using tool As New ReportPrintTool(Voucher)
            tool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Dim idp As Integer = DetallePlanillaDataGridView.CurrentRow.Cells(0).Value

        Dim Voucher As New RptVoucher(idp)
        Using tool As New ReportPrintTool(Voucher)
            tool.ShowPreviewDialog()
        End Using
    End Sub


    Private Sub ImprimirPlanillasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirPlanillasToolStripMenuItem.Click
        Dim idp As Integer = DetallePlanillaDataGridView.CurrentRow.Cells(0).Value

        Dim Planillas As New RptPlanillas(idp)

        Using tool As New ReportPrintTool(Planillas)
            tool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub CrearPlanillaPermanente()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarPlanillaPermanente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtNumIdentidad.Text
                    .Parameters.Add("@SueldoBase", SqlDbType.Money).Value = CDbl(TxtSueldoBase.Text)
                    .Parameters.Add("@IdPlanilla", SqlDbType.Int).Value = IdPlanilla

                    .ExecuteNonQuery()

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CrearPlanillaContrato()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarPlanillaContrato"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtNumIdPermanente.Text
                    .Parameters.Add("@SueldoBase", SqlDbType.Money).Value = CDbl(TxtSueldoPermanente.Text)
                    .Parameters.Add("@IdPlanilla", SqlDbType.Int).Value = IdPlanilla

                    .ExecuteNonQuery()

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub CrearPlanillaTemporal()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarPlanillaTemporal"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtNumIdTemporal.Text
                    .Parameters.Add("@SueldoBase", SqlDbType.Money).Value = CDbl(TxtSueldoTemporal.Text)
                    .Parameters.Add("@IdPlanilla", SqlDbType.Int).Value = IdPlanilla

                    .ExecuteNonQuery()

                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call CrearPlanillaPermanente()
        Me.DetallePlanillaTableAdapter.FillByIdP(Me.DsPagos.DetallePlanilla, IdPlanilla)
        TxtNumIdentidad.Clear()
        TxtSueldoBase.Clear()
    End Sub

    Private Sub FrmDetallePlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPlanillaTemporal.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter2.Fill(Me.DsPlanillaTemporal.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'DsPlanillaTemporal.DetallePlanillaTemporal' Puede moverla o quitarla según sea necesario.
        Me.DetallePlanillaTemporalTableAdapter.FillByIdPlanilla(Me.DsPlanillaTemporal.DetallePlanillaTemporal, IdPlanilla)
        'TODO: esta línea de código carga datos en la tabla 'DsPlanillaContrato.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter1.Fill(Me.DsPlanillaContrato.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'DsPlanillaContrato.DetallePlanillaContrato' Puede moverla o quitarla según sea necesario.
        Me.DetallePlanillaContratoTableAdapter.FillByIdPlanilla(Me.DsPlanillaContrato.DetallePlanillaContrato, IdPlanilla)
        'TODO: esta línea de código carga datos en la tabla 'DsPagos.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.DsPagos.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'DsPagos.DetallePlanilla' Puede moverla o quitarla según sea necesario.
        Me.DetallePlanillaTableAdapter.FillByIdP(Me.DsPagos.DetallePlanilla, IdPlanilla)


    End Sub


    Private Sub BtnGuardarTemporal_Click(sender As Object, e As EventArgs) Handles BtnGuardarTemporal.Click
        Me.Validate()
        Me.DetallePlanillaTemporalBindingSource.EndEdit()
        Me.TableAdapterManager2.UpdateAll(Me.DsPlanillaTemporal)
    End Sub

    Private Sub BtnGuardarPermanente_Click(sender As Object, e As EventArgs) Handles BtnGuardarPermanente.Click
        Me.Validate()
        Me.DetallePlanillaContratoBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DsPlanillaContrato)
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Me.Validate()
        Me.DetallePlanillaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagos)
    End Sub

    Private Sub BtnAceptarP_Click(sender As Object, e As EventArgs) Handles BtnAceptarP.Click
        Call CrearPlanillaContrato()
        Me.DetallePlanillaContratoTableAdapter.FillByIdPlanilla(Me.DsPlanillaContrato.DetallePlanillaContrato, IdPlanilla)
        TxtNumIdPermanente.Clear()
        TxtSueldoPermanente.Clear()
    End Sub

    Private Sub BtnAceptTemporal_Click(sender As Object, e As EventArgs) Handles BtnAceptTemporal.Click
        Call CrearPlanillaTemporal()
        Me.DetallePlanillaTemporalTableAdapter.FillByIdPlanilla(Me.DsPlanillaTemporal.DetallePlanillaTemporal, IdPlanilla)
        TxtNumIdTemporal.Clear()
        TxtSueldoTemporal.Clear()
    End Sub

    Private Sub PbxBuscarPermanente_Click(sender As Object, e As EventArgs) Handles PbxBuscarPermanente.Click
        FrmEmpleadoPlanilla.opc = 1
        FrmEmpleadoPlanilla.ShowDialog()
    End Sub

    Private Sub PbxPorContrato_Click(sender As Object, e As EventArgs) Handles PbxPorContrato.Click
        FrmEmpleadoPlanilla.opc = 2
        FrmEmpleadoPlanilla.ShowDialog()
    End Sub

    Private Sub PbxTemporal_Click(sender As Object, e As EventArgs) Handles PbxTemporal.Click
        FrmEmpleadoPlanilla.opc = 3
        FrmEmpleadoPlanilla.ShowDialog()
    End Sub

    Private Sub ImprimirVoucherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImprimirVoucherToolStripMenuItem1.Click
        Dim idp As Integer = DetallePlanillaContratoDataGridView.CurrentRow.Cells(0).Value
        Dim numid As String = DetallePlanillaContratoDataGridView.CurrentRow.Cells(1).Value

        Dim Voucher As New RptVoucherContrato(idp, numid)
        Using tool As New ReportPrintTool(Voucher)
            tool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub ImprimirTodosLosVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirTodosLosVoucherToolStripMenuItem.Click
        Dim idp As Integer = DetallePlanillaContratoDataGridView.CurrentRow.Cells(0).Value

        Dim Voucher As New RptVoucherContrato(idp)
        Using tool As New ReportPrintTool(Voucher)
            tool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub ImprimirPlanillaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirPlanillaToolStripMenuItem.Click
        Dim idp As Integer = DetallePlanillaContratoDataGridView.CurrentRow.Cells(0).Value

        Dim Planillas As New RptPlanillaContrato(idp)

        Using tool As New ReportPrintTool(Planillas)
            tool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub ImprimirVoucherToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ImprimirVoucherToolStripMenuItem2.Click
        Dim idp As Integer = DetallePlanillaTemporalDataGridView.CurrentRow.Cells(0).Value
        Dim numid As String = DetallePlanillaTemporalDataGridView.CurrentRow.Cells(1).Value

        Dim Voucher As New RptVoucherTemporal(idp, numid)
        Using tool As New ReportPrintTool(Voucher)
            tool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub ImprimirTodosLosVoucherToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImprimirTodosLosVoucherToolStripMenuItem1.Click
        Dim idp As Integer = DetallePlanillaTemporalDataGridView.CurrentRow.Cells(0).Value

        Dim Voucher As New RptVoucherTemporal(idp)
        Using tool As New ReportPrintTool(Voucher)
            tool.ShowPreviewDialog()
        End Using
    End Sub

    Private Sub ImprimirPlanillaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ImprimirPlanillaToolStripMenuItem1.Click
        Dim idp As Integer = DetallePlanillaTemporalDataGridView.CurrentRow.Cells(0).Value

        Dim Planillas As New RptPlanillaTemporal(idp)

        Using tool As New ReportPrintTool(Planillas)
            tool.ShowPreviewDialog()
        End Using
    End Sub
End Class