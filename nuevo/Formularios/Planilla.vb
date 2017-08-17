Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Public Class FrmPlanilla
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

    Private Sub DgvPlanillas_DoubleClick_1(sender As Object, e As EventArgs) Handles DgvPlanillas.DoubleClick
        Dim Id As Integer = DgvPlanillas.CurrentRow.Cells(0).Value
        FrmDetallePlanilla.IdPlanilla = Id
        FrmDetallePlanilla.ShowDialog()
    End Sub
End Class