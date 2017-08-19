Public Class FrmPermisosArmas
    Private Sub FrmPermisosArmas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Planillas.InventarioArmas' Puede moverla o quitarla según sea necesario.
        Me.InventarioArmasTableAdapter.FillFechaPermiso(Me.Planillas.InventarioArmas)
        'TODO: esta línea de código carga datos en la tabla 'Planillas.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.Fill(Me.Planillas.DataTable1)

    End Sub
End Class