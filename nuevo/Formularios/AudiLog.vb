﻿Imports System.Data.SqlClient
Public Class AudiLog
    Dim dt As DataTable
    Dim da As New SqlDataAdapter
    Private Sub AudiLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("Ayuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath

        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpKeyword(Me, "V.AUDILOG.PRIN")
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