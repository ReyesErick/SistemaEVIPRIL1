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
End Class