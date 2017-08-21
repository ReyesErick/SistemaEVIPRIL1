Imports DevExpress.XtraReports.UI
Public Class FrmDetallePlanilla
    Public Property IdPlanilla As Integer

    Private Sub FrmDetallePlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Planillas.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.Planillas.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Planillas.DetallePlanilla' Puede moverla o quitarla según sea necesario.
        Me.DetallePlanillaTableAdapter.FillByIdPlanilla(Me.Planillas.DetallePlanilla, IdPlanilla)

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Me.Validate()
        Me.DetallePlanillaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Planillas)
    End Sub

    Private Sub ImprimirVoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirVoucherToolStripMenuItem.Click
        Dim idp As Integer = DetallePlanillaDataGridView.CurrentRow.Cells(0).Value
        Dim numid As String = DetallePlanillaDataGridView.CurrentRow.Cells(12).Value

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

End Class