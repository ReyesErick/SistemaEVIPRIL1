Public Class frmTest
    Public Property IdPlanilla As Integer

    Private Sub DetallePlanillaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DetallePlanillaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DetallePlanillaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsPagos)

    End Sub

    Private Sub frmTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DsPagos.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.DsPagos.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'DsPagos.DetallePlanilla' Puede moverla o quitarla según sea necesario.
        Me.DetallePlanillaTableAdapter.FillByIdP(Me.DsPagos.DetallePlanilla, IdPlanilla)

    End Sub
End Class