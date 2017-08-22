﻿Imports DevExpress.XtraReports.UI
Public Class FrmPrestacion

    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        Me.Dispose()
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Dim FechaInicial As Date
        Dim FechaActual As Date
        Me.TxtSOM.Text = FormatCurrency(CDbl(Me.TxtSOM.Text))
        Me.TxtSOD.Text = FormatCurrency(CDbl(Me.TxtSOM.Text) / 30, 2)
        Me.TxtSOPM.Text = FormatCurrency((CDbl(Me.TxtSOM.Text) * 14) / 12, 2)
        Me.TxtSOPD.Text = FormatCurrency(CDbl(TxtSOPM.Text) / 30, 2)
        FechaInicial = dtpFechaInicial.Value
        FechaActual = CDate(String.Format("{0}-{1}-{2}", TxtAño1.Text, TxtMes1.Text, TxtDia1.Text))
        Dim diaActual As Integer
        Dim mesActual As Integer
        Dim anioActual As Integer

        Dim diaInicio As Integer
        Dim mesInicio As Integer
        Dim anioInicio As Integer
        Dim B As Integer
        Dim Mes As Integer
        Dim Anios As Integer
        Dim Meses As Integer
        Dim Dias As Integer
        Dim Duracion_Meses As Integer
        Dim Preaviso As Integer
        Dim Vacaciones As Integer
        Dim Cesantia As Integer
        Dim DiasVacacionesProporcionales As Integer
        Dim TotalPrestaciones As Double = 0



        diaActual = DatePart("d", FechaActual)
        mesActual = DatePart("m", FechaActual)
        anioActual = DatePart("yyyy", FechaActual)
        '**************************************'
        diaInicio = DatePart("d", FechaInicial)
        mesInicio = DatePart("m", FechaInicial)
        anioInicio = DatePart("yyyy", FechaInicial)

        B = 0
        Mes = mesInicio - 1

        ' si el mes es febrero
        If (Mes = 2) Then   ' *
            If ((anioActual / 4 = 0 And anioActual / 100.0! = 0) Or anioActual / 400 = 0) Then
                B = 29
            Else
                B = 28
            End If
        ElseIf (Mes <= 7) Then  '*
            If (Mes = 0) Then
                B = 31
            ElseIf (Mes / 2 = 0) Then
                B = 30
            Else
                B = 31
            End If

        ElseIf (Mes > 7) Then
            If (Mes / 2 = 0) Then
                B = 31
            Else
                B = 30
            End If
        End If

        If ((anioInicio > anioActual) Or (anioInicio = anioActual And mesInicio > mesActual) Or (anioInicio = anioActual And mesInicio = mesActual And diaInicio > diaActual)) Then
            MessageBox.Show("La fecha de inicio ha de ser anterior a la fecha Actual")
        Else
            If (mesInicio <= mesActual) Then
                Anios = anioActual - anioInicio
                If (diaInicio <= diaActual) Then
                    Meses = mesActual - mesInicio
                    Dias = diaActual - diaInicio
                Else
                    If (mesActual = mesInicio) Then
                        Anios = Anios - 1
                    End If
                    Meses = (mesActual - mesInicio - 1 + 12) / 12
                    Dias = B - (diaInicio - diaActual)
                End If
            Else
                Anios = anioActual - anioInicio - 1

                If (diaInicio > diaActual) Then
                    Meses = mesActual - mesInicio - 1 + 12
                    Dias = B - (diaInicio - diaActual)
                Else
                    Meses = mesActual - mesInicio + 12
                    Dias = diaActual - diaInicio
                End If
            End If

        End If '*


        Me.TxtAnioAnti.Text = Anios
        Me.TxtMesAnti.Text = Meses
        Me.TxtDiaAnti.Text = (Dias + 1)
        Duracion_Meses = DateDiff(DateInterval.Month, FechaInicial, FechaActual)

        If Duracion_Meses < 3 Then
            Preaviso = 1
            Me.TxtPD1.Text = Preaviso
            Me.TxtPL1.Text = FormatCurrency(Preaviso * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtPL1.Text

        ElseIf Duracion_Meses >= 3 And Duracion_Meses < 6 Then
            Preaviso = 7
            Me.TxtPD2.Text = Preaviso
            Me.TxtPL2.Text = FormatCurrency(Preaviso * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtPL2.Text
        ElseIf Duracion_Meses >= 6 And Duracion_Meses < 12 Then
            Preaviso = 14
            Me.TxtPD3.Text = Preaviso
            Me.TxtPL3.Text = FormatCurrency(Preaviso * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtPL3.Text
        ElseIf Duracion_Meses >= 12 And Duracion_Meses < 24 Then
            Preaviso = 30
            Me.TxtPD4.Text = Preaviso
            Me.TxtPL4.Text = FormatCurrency(Preaviso * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtPL4.Text
        ElseIf Duracion_Meses >= 24 Then
            Preaviso = 60
            Me.TxtPD5.Text = Preaviso
            Me.TxtPL5.Text = FormatCurrency(Preaviso * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtPL5.Text
        End If


        If Duracion_Meses >= 3 And Duracion_Meses < 6 Then
            Cesantia = 10
            Me.TxtCD1.Text = Cesantia
            Me.TxtCL1.Text = FormatCurrency(Cesantia * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtCL1.Text

        ElseIf Duracion_Meses >= 6 And Duracion_Meses < 12 Then
            Cesantia = 20
            Me.TxtCD2.Text = Cesantia
            Me.TxtCL2.Text = FormatCurrency(Cesantia * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtCL2.Text

        ElseIf Duracion_Meses >= 12 Then
            'Cesantia = 30
            'Me.TxtCD3.Text = Cesantia
            Me.TxtCL3.Text = FormatCurrency(CDbl(Me.TxtAnioAnti.Text) * CDbl(Me.TxtSOPM.Text))
            TotalPrestaciones += Me.TxtCL3.Text
        End If


        If Duracion_Meses >= 12 And Duracion_Meses < 24 Then
            Vacaciones = 10
            Me.TxtVD1.Text = Vacaciones
            Me.TxtVL1.Text = FormatCurrency(Vacaciones * CDbl(Me.TxtSOPD.Text))
            'TotalPrestaciones += Me.TxtVL1.Text
            'DiasVacacionesProporcionales = 36


        ElseIf Duracion_Meses >= 24 And Duracion_Meses < 36 Then
            Vacaciones = 12
            Me.TxtVD2.Text = Vacaciones
            Me.TxtVL2.Text = FormatCurrency(Vacaciones * CDbl(Me.TxtSOPD.Text))
            ''TotalPrestaciones += Me.TxtVL2.Text
            'DiasVacacionesProporcionales = 30

        ElseIf Duracion_Meses >= 36 And Duracion_Meses < 48 Then
            Vacaciones = 15
            Me.TxtVD3.Text = Vacaciones
            Me.TxtVL3.Text = FormatCurrency(Vacaciones * CDbl(Me.TxtSOPD.Text))
            'TotalPrestaciones += Me.TxtVL3.Text
            'DiasVacacionesProporcionales = 24

        ElseIf Duracion_Meses >= 48 Then
            Vacaciones = 20
            Me.TxtVD4.Text = Vacaciones
            Me.TxtVL4.Text = FormatCurrency(Vacaciones * CDbl(Me.TxtSOPD.Text))
            'TotalPrestaciones += Me.TxtVL4.Text
            'DiasVacacionesProporcionales = 18
        End If

        If Duracion_Meses >= 60 Then
            '
        End If

        'Me.TxtVPD.Text = 
        'Me.TxtVPL.Text = 


        If Duracion_Meses < 8 Then
            DiasVacacionesProporcionales = (((TxtMesAnti.Text * 30) + TxtDiaAnti.Text))
            Me.TxtVPD.Text = DiasVacacionesProporcionales
            Me.TxtVPL.Text = FormatCurrency(((TxtVPD.Text) / 36) * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtVL2.Text

        ElseIf Duracion_Meses >= 8 And Duracion_Meses < 24 Then
            DiasVacacionesProporcionales = (((TxtMesAnti.Text * 30) + TxtDiaAnti.Text))
            Me.TxtVPD.Text = DiasVacacionesProporcionales
            Me.TxtVPL.Text = FormatCurrency(((TxtVPD.Text) / 24) * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtVL2.Text

        ElseIf Duracion_Meses >= 24 Then
            DiasVacacionesProporcionales = (((TxtMesAnti.Text * 30) + TxtDiaAnti.Text))
            Me.TxtVPD.Text = DiasVacacionesProporcionales
            Me.TxtVPL.Text = FormatCurrency(((TxtVPD.Text) / 18) * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtVL2.Text

        End If



        'CESANTIA
        Me.TxtCPD.Text = (((TxtMesAnti.Text * 30) + TxtDiaAnti.Text))
        Me.TxtCPL.Text = FormatCurrency(((TxtCPD.Text) / 12) * CDbl(Me.TxtSOPD.Text))
        TotalPrestaciones += Me.TxtCPL.Text

        If TxtDL1.Text Is Nothing Then
            TxtDL1.Text = 0
        End If
        If TxtDL2.Text Is Nothing Then
            TxtDL2.Text = 0
        End If
        If TxtDL3.Text Is Nothing Then
            TxtDL4.Text = 0
        End If
        If TxtDL4.Text Is Nothing Then
            TxtDL4.Text = 0
        End If

        Dim tiempo As String

        '13 año

        tiempo = Today.DayOfYear
        TextBox14.Text = (tiempo - 2)
        TextBox19.Text = FormatCurrency(CDbl(((tiempo - 2) / 360) * TxtSOM.Text))
        TotalPrestaciones += Me.TextBox19.Text

        '14 año
        Dim FechaAnt As New Date(Now.Year, 6, 1)
        If (Today < FechaAnt) Then
            FechaAnt = New Date(Now.Year - 1, 6, 1)
        End If

        TextBox24.Text = DateDiff(DateInterval.DayOfYear, FechaAnt, Today) - 30
        TextBox25.Text = FormatCurrency(Convert.ToDouble((TextBox24.Text / 360) * TxtSOM.Text))
        TotalPrestaciones += Me.TextBox25.Text

        ' = FormatCurrency(TotalPrestaciones + 993.37)
        TxtTotalD.Text = FormatCurrency(CDbl(TxtPL1.Text) + CDbl(TxtPL2.Text) + CDbl(TxtPL3.Text) + CDbl(TxtPL4.Text) + CDbl(TxtPL5.Text) + CDbl(TxtCL1.Text) + CDbl(TxtCL2.Text) + CDbl(TxtCL3.Text) + CDbl(TxtVPL.Text) + CDbl(TxtCPL.Text) + CDbl(TextBox19.Text) + CDbl(TextBox25.Text))

        TxtTotalP.Text = FormatCurrency(TxtTotalD.Text - (CDbl(TxtDL1.Text) + CDbl(TxtDL2.Text) + CDbl(TxtDL3.Text) + CDbl(TxtDL4.Text)))

    End Sub



    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Dim reporte As New ReportePrestaciones()
        reporte.XrlNumIdentidad.Text = txtNumIdentidadEmpleado.Text.ToString()
        reporte.XrlNombre.Text = TxtNombre.Text.ToString()
        reporte.XrlSOM.Text = TxtSOM.Text.ToString()
        reporte.XrlSOD.Text = TxtSOD.Text.ToString()
        reporte.XrlSubTotal.Text = TxtTotalD.Text.ToString()
        reporte.XrlTotalP.Text = TxtTotalP.Text.ToString()
        reporte.XrlSOPM.Text = TxtSOPM.Text.ToString()
        reporte.XrlSOPD.Text = TxtSOPD.Text.ToString()
        reporte.XrlFechaIngreso.Text = dtpFechaInicial.Value
        reporte.XrlFechaFinal.Text = String.Format("{0}-{1}-{2}", TxtDia1.Text, TxtMes1.Text, TxtAño1.Text)
        reporte.XrlAnio.Text = TxtAnioAnti.Text
        reporte.XrlMes.Text = TxtMesAnti.Text
        reporte.XrlDia.Text = TxtDiaAnti.Text
        reporte.XrlDeducciones.Text = (CDbl(TxtDL1.Text) + CDbl(TxtDL2.Text) + CDbl(TxtDL3.Text) + CDbl(TxtDL4.Text)).ToString

        Dim viewer As New ReportPrintTool(reporte)
        viewer.ShowPreview()

    End Sub

    Private Sub FrmPrestacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("Ayuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath

        Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpKeyword(Me, "V.PRESTACIONES")
    End Sub
End Class