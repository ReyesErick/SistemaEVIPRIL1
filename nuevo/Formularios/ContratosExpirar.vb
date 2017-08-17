Public Class ContratosExpirar
    Private Sub ContratoEmpleadoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.ContratoEmpleadoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Planillas)

    End Sub

    Private Sub ContratosExpirar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Planillas.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.Planillas.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'Planillas.ContratoEmpleado' Puede moverla o quitarla según sea necesario.
        Me.ContratoEmpleadoTableAdapter.Fill(Me.Planillas.ContratoEmpleado)

    End Sub
End Class