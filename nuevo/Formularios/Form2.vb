Imports System.Data.SqlClient

Public Class FrmPantallaPrincipal
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmInicioSeción.Close()
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        FrmInicioSeción.Close()
        Me.Close()
    End Sub


    Private Sub PbxEmpleado_Click(sender As Object, e As EventArgs) Handles PbxEmpleado.Click
        FrmEmpleado.ShowDialog()
    End Sub

    Private Sub PbxContrato_Click(sender As Object, e As EventArgs) Handles PbxContrato.Click
        FrmContrato.ShowDialog()
    End Sub

    Private Sub PbxClientes_Click(sender As Object, e As EventArgs) Handles PbxClientes.Click
        FrmClientes.ShowDialog()
    End Sub

    Private Sub PbxInventario_Click(sender As Object, e As EventArgs) Handles PbxInventario.Click
        FrmInventario.ShowDialog()
    End Sub

    Private Sub PbxPlanilla_Click(sender As Object, e As EventArgs) Handles PbxPlanilla.Click
        FrmPlanilla.ShowDialog()
    End Sub

    Private Sub PbxUsuario_Click(sender As Object, e As EventArgs) Handles PbxUsuario.Click
        FrmUsuario.ShowDialog()
    End Sub

    Private Sub PbxPrestaciones_Click(sender As Object, e As EventArgs) Handles PbxPrestaciones.Click
        AudiLog.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmInicioSeción.Show()
        Me.Close()
        sele = 1
    End Sub
End Class