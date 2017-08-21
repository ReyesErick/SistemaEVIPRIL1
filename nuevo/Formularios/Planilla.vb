Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Public Class FrmPlanilla
    Dim mes As String = Today.Month
    Dim User As String = FrmPantallaPrincipal.LblBienvenido.Text
    ' LABEL PARA MOSTRAR TODAS LAS PLANILLAS
    Private Sub LblPlanillas_Click(sender As Object, e As EventArgs) Handles LblPlanillas.Click
        sele = 2
        verificarHelp()
        Me.PlanillasTableAdapter.FillByIdDesc(Me.Planillas._Planillas)
        TpPlanilla.Visible = True
        TpPlanilla.SelectedTab = TabPage3
    End Sub

    ' PROCEDIMIENTOS PARA CAMBIAR EL COLOR DE LAS LABEL AL PONER EL MOUSE SOBRE ELLAS
    Private Sub LblAgregarPlanilla_MouseMove(sender As Object, e As MouseEventArgs) Handles LblAgregarPlanilla.MouseMove
        LblAgregarPlanilla.ForeColor = Color.Green
    End Sub

    Private Sub LblAgregarPlanilla_MouseLeave(sender As Object, e As EventArgs) Handles LblAgregarPlanilla.MouseLeave
        LblAgregarPlanilla.ForeColor = Color.Black
    End Sub

    Private Sub LblPlanillas_MouseMove(sender As Object, e As MouseEventArgs) Handles LblPlanillas.MouseMove
        LblPlanillas.ForeColor = Color.Green
    End Sub

    Private Sub LblPlanillas_MouseLeave(sender As Object, e As EventArgs) Handles LblPlanillas.MouseLeave
        LblPlanillas.ForeColor = Color.Black
    End Sub

    ' LABEL PARA AGREGAR UNA NUEVA PLANILLA
    Private Sub LblAgregarPlanilla_Click(sender As Object, e As EventArgs) Handles LblAgregarPlanilla.Click
        sele = 1
        Call CrearPlanilla()
        Call AudiLogInsert()
        Me.PlanillasTableAdapter.FillByIdDesc(Me.Planillas._Planillas)

    End Sub

    ' BOTON PARA REGRESAR AL MENU PRINCIPAL
    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        Me.Close()
    End Sub

    Private Sub CrearPlanilla()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_CrearPlanilla"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                    .Parameters.Add("@respuesta", SqlDbType.NVarChar, 70)
                    .Parameters("@respuesta").Direction = ParameterDirection.Output
                    .ExecuteNonQuery()
                    MsgBox(.Parameters("@respuesta").Value.ToString())
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub AudiLogInsert()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO AudiLog (Descripcion, Usuario) VALUES (@Descripcion, @Usuario)", cn)
            da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = "Se insertaron planillas para todos los empleados activos"
            da.InsertCommand.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = User

            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub FrmPlanilla_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Planillas._Planillas' Puede moverla o quitarla según sea necesario.
        Me.PlanillasTableAdapter.Fill(Me.Planillas._Planillas)
        'TODO: esta línea de código carga datos en la tabla 'Planillas._Planillas' Puede moverla o quitarla según sea necesario.
        Me.PlanillasTableAdapter.FillByIdDesc(Me.Planillas._Planillas)
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("Ayuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath

        sele = 0
        verificarHelp()
    End Sub

    Private Sub verificarHelp()
        If sele = 1 Then
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.PLANILLA.PRI")
        Else
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.PLANILLA.AG")

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        FrmTercerCuartoMes.MesPago = "DecimoTercero"
        FrmTercerCuartoMes.ShowDialog()
    End Sub

    Private Sub Label2_MouseMove(sender As Object, e As MouseEventArgs) Handles Label2.MouseMove
        Label2.ForeColor = Color.Green
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave
        Label2.ForeColor = Color.Black
    End Sub

    Private Sub CalcularTercerCuartoMes()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("Exec Sp_CalcularDecimoTercer", cn)

            Try
                cn.Open()
                da.InsertCommand.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        FrmTercerCuartoMes.MesPago = "DecimoCuarto"
        FrmTercerCuartoMes.ShowDialog()
    End Sub

    Private Sub Label3_MouseMove(sender As Object, e As MouseEventArgs) Handles Label3.MouseMove
        Label3.ForeColor = Color.Green
    End Sub

    Private Sub Label3_MouseLeave(sender As Object, e As EventArgs) Handles Label3.MouseLeave
        Label3.ForeColor = Color.Black
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If mes = "12" Then
            Call CalcularTercerCuartoMes()
            FrmTercerCuartoMes.MesPago = "DecimoTercero"
            FrmTercerCuartoMes.ShowDialog()
        Else
            MsgBox("No se puede calcular el decimo tercer mes en la fecha actual")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        If mes = "6" Then
            Call CalcularTercerCuartoMes()
            FrmTercerCuartoMes.MesPago = "DecimoCuarto"
            FrmTercerCuartoMes.ShowDialog()
        Else
            MsgBox("No se puede calcular el decimo cuarto mes en la fecha actual")
        End If
    End Sub

    Private Sub Label4_MouseMove(sender As Object, e As MouseEventArgs) Handles Label4.MouseMove
        Label4.ForeColor = Color.Green
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.ForeColor = Color.Black
    End Sub

    Private Sub Label5_MouseMove(sender As Object, e As MouseEventArgs) Handles Label5.MouseMove
        Label5.ForeColor = Color.Green
    End Sub

    Private Sub Label5_MouseLeave(sender As Object, e As EventArgs) Handles Label5.MouseLeave
        Label5.ForeColor = Color.Black
    End Sub

    Private Sub PlanillasDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles PlanillasDataGridView.CellContentClick
        FrmDetallePlanilla.IdPlanilla = PlanillasDataGridView.CurrentRow.Cells(0).Value
        FrmDetallePlanilla.ShowDialog()
    End Sub
End Class