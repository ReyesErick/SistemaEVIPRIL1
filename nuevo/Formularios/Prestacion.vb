Public Class FrmPrestacion
    Private Sub LblPrestación_MouseLeave(sender As Object, e As EventArgs) Handles LblPrestación.MouseLeave
        LblPrestación.ForeColor = Color.Black
    End Sub

    Private Sub LblPrestación_MouseMove(sender As Object, e As MouseEventArgs) Handles LblPrestación.MouseMove
        LblPrestación.ForeColor = Color.Green
    End Sub

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
        FechaInicial = CDate(String.Format("{0}-{1}-{2}", TxtAño.Text, TxtMes.Text, TxtDia.Text))
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
        Me.TxtDiaAnti.Text = Dias
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
            Cesantia = 30
            Me.TxtCD3.Text = Cesantia
            Me.TxtCL3.Text = FormatCurrency(Cesantia * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtCL3.Text
        End If


        If Duracion_Meses >= 12 And Duracion_Meses < 24 Then
            Vacaciones = 10
            Me.TxtVD1.Text = Vacaciones
            Me.TxtVL1.Text = FormatCurrency(Vacaciones * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtVL1.Text
            DiasVacacionesProporcionales = 36


        ElseIf Duracion_Meses >= 24 And Duracion_Meses < 36 Then
            Vacaciones = 12
            Me.TxtVD2.Text = Vacaciones
            Me.TxtVL2.Text = FormatCurrency(Vacaciones * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtVL2.Text
            DiasVacacionesProporcionales = 30

        ElseIf Duracion_Meses >= 36 And Duracion_Meses < 48 Then
            Vacaciones = 15
            Me.TxtVD3.Text = Vacaciones
            Me.TxtVL3.Text = FormatCurrency(Vacaciones * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtVL3.Text
            DiasVacacionesProporcionales = 24

        ElseIf Duracion_Meses >= 48 Then
            Vacaciones = 20
            Me.TxtVD4.Text = Vacaciones
            Me.TxtVL4.Text = FormatCurrency(Vacaciones * CDbl(Me.TxtSOPD.Text))
            TotalPrestaciones += Me.TxtVL4.Text
            DiasVacacionesProporcionales = 18
        End If

        If Duracion_Meses >= 60 Then
            DiasVacacionesProporcionales = 12
        End If



        Me.TxtVPD.Text = DiasVacacionesProporcionales
        Me.TxtVPL.Text = FormatCurrency((Duracion_Meses / DiasVacacionesProporcionales) * CDbl(Me.TxtSOPD.Text))
        TotalPrestaciones += Me.TxtVPL.Text

        Me.TxtCPD.Text = 12
        Me.TxtCPL.Text = FormatCurrency((Duracion_Meses / 12) * CDbl(Me.TxtSOPD.Text))
        TotalPrestaciones += Me.TxtCPL.Text
        TxtTotalD.Text = FormatCurrency(TotalPrestaciones)
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
        TxtTotalP.Text = FormatCurrency(TotalPrestaciones - (CDbl(TxtDL1.Text) + CDbl(TxtDL2.Text) + CDbl(TxtDL3.Text) + CDbl(TxtDL4.Text)))


    End Sub
End Class