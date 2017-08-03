Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Public Class FrmPlanilla
    Dim User As String = FrmPantallaPrincipal.LblBienvenido.Text
    ' LABEL PARA MOSTRAR TODAS LAS PLANILLAS
    Private Sub LblPlanillas_Click(sender As Object, e As EventArgs) Handles LblPlanillas.Click
        Call CargarPlanilla()
        TpPlanilla.Visible = True
        TpPlanilla.SelectedTab = TabPage3
    End Sub

    ' SUB PROCEDIMIENTO PARA CARGAR LAS PLANILLAS EN EL LISTVIEW
    Private Sub CargarPlanilla()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        Using cmd As New SqlCommand

            Try
                cn.Open()

                With cmd
                    .CommandText = "Sp_MostrarPlanilla"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                End With

                Dim MostrarEmpleado As SqlDataReader
                MostrarEmpleado = cmd.ExecuteReader
                LsvPlanilla.Items.Clear()

                While MostrarEmpleado.Read = True
                    With LsvPlanilla.Items.Add(MostrarEmpleado("IdPlanilla").ToString)
                        .SubItems.Add(MostrarEmpleado("SueldoDiario").ToString)
                        .SubItems.Add(MostrarEmpleado("DiasTrabajados").ToString)
                        .SubItems.Add(MostrarEmpleado("SueldoQuincenal").ToString)
                        .SubItems.Add(MostrarEmpleado("Complemento").ToString)
                        .SubItems.Add(MostrarEmpleado("SubTotal").ToString)
                        .SubItems.Add(MostrarEmpleado("DeduccionSeguro").ToString)
                        .SubItems.Add(MostrarEmpleado("DeduccionUniforme").ToString)
                        .SubItems.Add(MostrarEmpleado("Rap").ToString)
                        .SubItems.Add(MostrarEmpleado("OtrasDeducciones").ToString)
                        .SubItems.Add(MostrarEmpleado("TotalDeducciones").ToString)
                        .SubItems.Add(MostrarEmpleado("NetoPagar").ToString)
                        .SubItems.Add(MostrarEmpleado("NumIdentidad").ToString)
                    End With
                End While

            Catch ex As Exception
                MessageBox.Show("Error al listar los empleados" + ex.Message)
            Finally
                cn.Close()
            End Try
        End Using
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

        TpPlanilla.Visible = True
        Me.TpPlanilla.SelectedTab = TabPage2
        TxtSueldoDiario.Enabled = True
        TxtDiasTrabajados.Enabled = True
        TxtComplemento.Enabled = True
        TxtUniforme.Enabled = True
        TxtOtrasDeduc.Enabled = True
        BtnCalcular.Enabled = True
        BtnCancelar.Enabled = True

    End Sub

    ' BOTON PARA REGRESAR AL MENU PRINCIPAL
    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        Me.Close()
    End Sub

    ' BOTON CANCELAR
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        TpPlanilla.Visible = False
        TxtSueldoDiario.Enabled = False
        TxtDiasTrabajados.Enabled = False
        TxtComplemento.Enabled = False
        TxtUniforme.Enabled = False
        TxtOtrasDeduc.Enabled = False
        BtnGuardar.Enabled = False
        BtnCancelar.Enabled = False
        Call Limpiar()
    End Sub

    Private Sub Limpiar()
        TxtNumIdentidad.Clear()
        TxtNombreEmpleado.Clear()
        TxtSueldoDiario.Clear()
        TxtDiasTrabajados.Clear()
        TxtSueldoQuincenal.Clear()
        TxtComplemento.Clear()
        TxtSubTotal.Clear()
        TxtSeguro.Clear()
        TxtUniforme.Clear()
        TxtOtrasDeduc.Clear()
        TxtRap.Clear()
        TxtTotalDeducciones.Clear()
        TxtNetoPagar.Clear()
    End Sub

    ' PICTUREBOX PARA HACER LA BUSQUEDA DEL EMPLEADO AL QUE SE LE ASIGNA LA PLANILLA
    Private Sub PbxBuscar_Click(sender As Object, e As EventArgs) Handles PbxBuscar.Click
        sele = 1
        FrmEmpleado.Show()
        FrmEmpleado.TcEmpleado.Visible = True
        FrmEmpleado.TcEmpleado.SelectedTab = FrmEmpleado.TpVer
        TxtNumIdentidad.Text = FrmEmpleado.DgvVerEmpleado.CurrentRow.Cells(0).Value.ToString
        TxtNombreEmpleado.Text = FrmEmpleado.DgvVerEmpleado.CurrentRow.Cells(1).Value.ToString

    End Sub

    ' SUB PROCEDIMIENTO QUE HACE LOS CALCULOS DE LA PLANILLA
    Private Sub CalcularPlanilla()
        Dim DiasTrabajados, SueldoDiario, Complemento, SueldoQuincenal, SubTotal, Seguro, DeducUniforme, Rap, OtrasDeduc, TotalDeduc, TotalPagar As Double

        SueldoDiario = CDbl(TxtSueldoDiario.Text)
        DiasTrabajados = CDbl(TxtDiasTrabajados.Text)
        Complemento = CDbl(TxtComplemento.Text)
        DeducUniforme = CDbl(TxtUniforme.Text)
        OtrasDeduc = CDbl(TxtOtrasDeduc.Text)

        SueldoQuincenal = SueldoDiario * DiasTrabajados
        SubTotal = SueldoQuincenal + Complemento
        Seguro = 60
        Rap = SubTotal * 0.015
        TotalDeduc = Seguro + DeducUniforme + Rap + OtrasDeduc
        TotalPagar = SubTotal - TotalDeduc

        TxtSueldoQuincenal.Text = SueldoQuincenal.ToString
        TxtSubTotal.Text = SubTotal.ToString
        TxtSeguro.Text = Seguro.ToString
        TxtRap.Text = Rap.ToString
        TxtTotalDeducciones.Text = TotalDeduc.ToString
        TxtNetoPagar.Text = TotalPagar.ToString

    End Sub

    ' BOTON CALCULAR
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        If TxtNumIdentidad.Text = Nothing Then
            ErrorProvider1.SetError(TxtNumIdentidad, "Campo Oblogatorio")
            TxtNumIdentidad.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtNumIdentidad, "")
        End If

        If TxtSueldoDiario.Text = Nothing Then
            ErrorProvider1.SetError(TxtSueldoDiario, "Campo Obligatorio")
            TxtSueldoDiario.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtSueldoDiario, "")
        End If

        If TxtDiasTrabajados.Text = Nothing Then
            ErrorProvider1.SetError(TxtDiasTrabajados, "Campo Obligatorio")
            TxtDiasTrabajados.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtDiasTrabajados, "")
        End If
        If TxtComplemento.Text = Nothing Then
            ErrorProvider1.SetError(TxtComplemento, "Campo Obligatorio")
            TxtComplemento.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtComplemento, "")
        End If
        If TxtUniforme.Text = Nothing Then
            ErrorProvider1.SetError(TxtUniforme, "Campo Obligatorio")
            TxtUniforme.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtUniforme, "")
        End If
        If TxtOtrasDeduc.Text = Nothing Then
            ErrorProvider1.SetError(TxtOtrasDeduc, "Campo Obligatorio")
            TxtOtrasDeduc.Focus()
            Return
        Else
            ErrorProvider1.SetError(TxtOtrasDeduc, "")
        End If


        Call CalcularPlanilla()
        BtnGuardar.Enabled = True
    End Sub

    ' BOTON GUARDAR
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call GuardarPlanilla()
        Call AudiLogInsert()
        Call Limpiar()
    End Sub

    'SUB PROCEDIMIENTO QUE LLAMA AL PROCEDIMIENTO ALMACENADO PARA INSERTAR UNA NUEVA PLANILLA
    Private Sub GuardarPlanilla()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            cn.Open()
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarPlanilla"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@SueldoDiario", SqlDbType.Money).Value = CDbl(TxtSueldoDiario.Text)
                    .Parameters.Add("@DiasTrabajados", SqlDbType.Int).Value = CInt(TxtDiasTrabajados.Text)
                    .Parameters.Add("@SueldoQuincenal", SqlDbType.Money).Value = CDbl(TxtSueldoQuincenal.Text)
                    .Parameters.Add("@Complemento", SqlDbType.Money).Value = FormatCurrency(CDbl(TxtComplemento.Text))
                    .Parameters.Add("@SubTotal", SqlDbType.Money).Value = CDbl(TxtSubTotal.Text)
                    .Parameters.Add("@DeduccionSeguro", SqlDbType.Money).Value = CDbl(TxtSeguro.Text)
                    .Parameters.Add("@DeduccionUniforme", SqlDbType.Money).Value = CDbl(TxtUniforme.Text)
                    .Parameters.Add("@Rap", SqlDbType.Money).Value = CDbl(TxtRap.Text)
                    .Parameters.Add("@OtrasDeducciones", SqlDbType.Money).Value = CDbl(TxtOtrasDeduc.Text)
                    .Parameters.Add("@TotalDeducciones", SqlDbType.Money).Value = CDbl(TxtTotalDeducciones.Text)
                    .Parameters.Add("@NetoPagar", SqlDbType.Money).Value = CDbl(TxtNetoPagar.Text)
                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtNumIdentidad.Text
                    .ExecuteNonQuery()
                    MsgBox("Guardado con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    ' VALIDACION DE LAS TEXTBOX PARA QUE SOLO PERMITAN NUMEROS
    Private Sub TxtSueldoDiario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSueldoDiario.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtDiasTrabajados_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDiasTrabajados.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtComplemento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtComplemento.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtUniforme_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtUniforme.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TxtOtrasDeduc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtOtrasDeduc.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub AudiLogInsert()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO AudiLog (Descripcion, Usuario) VALUES (@Descripcion, @Usuario)", cn)
            da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = "Se inserto una planilla para el empleado: " + TxtNombreEmpleado.Text
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reporte As New ReportesPlanilla()
        Dim viewer As New ReportPrintTool(reporte)
        viewer.ShowPreview()
    End Sub
End Class