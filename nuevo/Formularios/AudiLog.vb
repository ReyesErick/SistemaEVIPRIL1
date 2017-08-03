Imports System.Data.SqlClient
Public Class AudiLog
    Dim dt As DataTable
    Dim da As New SqlDataAdapter
    Private Sub AudiLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargarAudiLog()
    End Sub

    Private Sub CargarAudiLog()
        da = New SqlDataAdapter("exec Sp_MostrarAudiLog", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvAudiLog.DataSource = dt
    End Sub

    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        Me.Close()
    End Sub
End Class