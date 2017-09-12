Imports System.Data.SqlClient
Public Class FrmEmpleadoPlanilla

    Dim dt As DataTable
    Dim da As New SqlDataAdapter
    Public opc As Integer

    Private Sub FrmEmpleadoPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarEmpleados()
    End Sub

    Private Sub MostrarEmpleados()
        da = New SqlDataAdapter("exec Sp_ListarEmpleado", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvEmpleado.DataSource = dt
    End Sub

    Private Sub DgvEmpleado_DoubleClick(sender As Object, e As EventArgs) Handles DgvEmpleado.DoubleClick
        If opc = 1 Then
            FrmDetallePlanilla.TxtNumIdentidad.Text = DgvEmpleado.CurrentRow.Cells(0).Value
            FrmDetallePlanilla.TxtSueldoBase.Text = DgvEmpleado.CurrentRow.Cells(2).Value
        ElseIf opc = 2 Then
            FrmDetallePlanilla.TxtNumIdPermanente.Text = DgvEmpleado.CurrentRow.Cells(0).Value
            FrmDetallePlanilla.TxtSueldoPermanente.Text = DgvEmpleado.CurrentRow.Cells(2).Value
        ElseIf opc = 3 Then
            FrmDetallePlanilla.TxtNumIdTemporal.Text = DgvEmpleado.CurrentRow.Cells(0).Value
            FrmDetallePlanilla.TxtSueldoTemporal.Text = DgvEmpleado.CurrentRow.Cells(2).Value
        End If

        Me.Close()
    End Sub
End Class