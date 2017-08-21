Public Class FrmTercerCuartoMes
    Public MesPago As String
    Private Sub FrmTercerCuartoMes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Planillas.TercerCuartoMes' Puede moverla o quitarla según sea necesario.
        Me.TercerCuartoMesTableAdapter.Fill(Me.Planillas.TercerCuartoMes, MesPago)

    End Sub
End Class