Imports System.Data.SqlClient
Imports DevExpress.XtraReports.UI
Public Class FrmContrato
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim da As New SqlDataAdapter
    Dim User As String = FrmPantallaPrincipal.LblBienvenido.Text

    'Consulta en sql para llenar el datagridview de contrato empleado y cliente'
    Public Sub MostrarDatosContratoEmpleado()
        da = New SqlDataAdapter("select c.IdContratoEmpleado,c.FechaInicio,c.FechaFinal,c.SueldoBase,t.TipoEmpleado,ti.TipoContrato, c.NumIdentidad, e.Nombres + ' ' + e.Apellidos as 'Nombre Empleado'
                                 from ContratoEmpleado c inner join TipoEmpleado t
							                                on c.IdTipoEmpleado = t.IdTipoEmpleado
						                                 inner join TipoContrato ti
							                                on c.IdTipoContrato = ti.IdTipoContrato
                                                         inner join Empleado e
                                                            on c.NumIdentidad = e.NumIdentidad", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvContrato.DataSource = dt
    End Sub

    Public Sub MostrarDatosContratoCliente()
        da = New SqlDataAdapter("select *
                                 from ContratoCliente", cn)
        dt = New DataTable
        da.Fill(dt)
        DgvContrato.DataSource = dt
    End Sub

    'llamamiento de la funcion para llenar el datagridview'
    Private Sub LblVerContratoEmple_Click(sender As Object, e As EventArgs) Handles LblVerContratoEmple.Click
        sele = 3
        verificarHelp()
        Call MostrarDatosContratoEmpleado()
        TpContrato.Visible = True
        TpContrato.SelectedTab = TabPage3
        sele = 1
    End Sub

    Private Sub LblVerContratoClien_Click(sender As Object, e As EventArgs) Handles LblVerContratoClien.Click
        Call MostrarDatosContratoCliente()
        TpContrato.Visible = True
        TpContrato.SelectedTab = TabPage3
        sele = 2
    End Sub

    Private Sub BtnRegresarMenu_Click(sender As Object, e As EventArgs) Handles BtnRegresarMenu.Click
        Me.Dispose()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim sueldo As Decimal
        Decimal.TryParse(txtsueldo.Text, sueldo)
        If (txtsueldo.Text = "") Then
            ErrorProvider1.SetError(txtsueldo, "Ingrese un Sueldo")
            txtsueldo.Focus()
            Return
        ElseIf sueldo <= 0 Then
            ErrorProvider1.SetError(txtsueldo, "Ingrese un sueldo valido")
            txtsueldo.Focus()
            Return
        Else
            ErrorProvider1.SetError(txtsueldo, "")
        End If

        If CboTipoEmpleado.Text = Nothing Then
            ErrorProvider1.SetError(CboTipoEmpleado, "Ingrese el tipo de empleado")
            CboTipoEmpleado.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboTipoEmpleado, "")
        End If

        If CboTipoContrato.Text = Nothing Then
            ErrorProvider1.SetError(CboTipoContrato, "Ingrese el tipo de contrato")
            CboTipoContrato.Focus()
            Return
        Else
            ErrorProvider1.SetError(CboTipoContrato, "")
        End If
        Call Agregarcontrato()
        Call AudiLogInsertEmpleado()
        Call Limpiar()

    End Sub

    Private Sub LlenarTipoEmpleado()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTipoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoEmpleado")
                CboTipoEmpleado.DataSource = ds.Tables(0)
                CboTipoEmpleado.DisplayMember = ds.Tables(0).Columns("TipoEmpleado").ToString
                CboTipoEmpleado.ValueMember = ds.Tables(0).Columns("IdTipoEmpleado").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub LlenarTipoContrato()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarTipoContrato"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "TipoContrato")
                CboTipoContrato.DataSource = ds.Tables(0)
                CboTipoContrato.DisplayMember = ds.Tables(0).Columns("TipoContrato").ToString
                CboTipoContrato.ValueMember = ds.Tables(0).Columns("IdTipoContrato").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Agregarcontrato()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarContratoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@FechaInicio", SqlDbType.Date).Value = dtpInicio.Value

                    If CboTipoContrato.Text = "Temporal" Then
                        .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = dtpfinal.Value
                    Else
                        .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = DBNull.Value
                    End If


                    .Parameters.Add("@SueldoBase", SqlDbType.Money).Value = Convert.ToDecimal(txtsueldo.Text)
                    .Parameters.Add("@IdTipoEmpleado", SqlDbType.Int).Value = CboTipoEmpleado.SelectedValue
                    .Parameters.Add("@IdTipoContrato", SqlDbType.Int).Value = CboTipoContrato.SelectedValue
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

    Private Sub Modificarcontrato()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_ModificarContratoEmpleado"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = dtpfinal.Value

                    .Parameters.Add("@IdContratoEmpleado", SqlDbType.Int).Value = DgvContrato.CurrentRow.Cells(0).Value

                    .ExecuteNonQuery()
                    MsgBox("Registro modificado con éxito")
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Limpiar()
        TxtNumIdentidad.Clear()
        txtsueldo.Clear()
        CboTipoContrato.Text = ""
        CboTipoEmpleado.Text = ""
    End Sub

    Private Sub FrmContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chmFilePath As String = HTMLHelpClass.GetLocalHelpFileName("Ayuda.chm")
        HelpProvider1.HelpNamespace = chmFilePath
        sele = 0
        verificarHelp()
        TpContrato.Visible = False
        Call LlenarTipoContrato()
        Call LlenarTipoEmpleado()
        Call CargarContratoCliente()
        CboTipoContrato.SelectedValue = -1
        CboTipoEmpleado.SelectedValue = -1
    End Sub

    Private Sub verificarHelp()
        If sele = 1 Then
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.CONTRATO.EMPLEADO.AG")
        ElseIf sele = 2 Then
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.CONTRATO.CLIENTE.AG")
        ElseIf sele = 3 Then
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.CONTRATO.EMPLEADO.VER")
        ElseIf sele = 4 Then
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.ASIGNACION.GUARDIA")
        Else
            Me.HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
            Me.HelpProvider1.SetHelpKeyword(Me, "V.CONTRATO.PRI")

        End If
    End Sub

    Private Sub LblAgregarContratoEmp_Click(sender As Object, e As EventArgs) Handles LblAgregarContratoEmp.Click
        sele = 1
        verificarHelp()
        TpContrato.Visible = True
        TpContrato.SelectedTab = TabPage1
        CboTipoContrato.Text = ""
        CboTipoEmpleado.Text = ""
        dtpFechaInicio.Enabled = True
        txtsueldo.Enabled = True
        CboTipoEmpleado.Enabled = True
        CboTipoContrato.Enabled = True
        BtnGuardar.Enabled = True
        BtnModificar.Enabled = False
    End Sub

    Private Sub LblAgregarContratoClien_Click(sender As Object, e As EventArgs) Handles LblAgregarContratoClien.Click
        sele = 2
        verificarHelp()
        TpContrato.Visible = True
        TpContrato.SelectedTab = TabPage2

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sueldo As Decimal
        Decimal.TryParse(txtMonto.Text, sueldo)
        If (txtMonto.Text = "") Then
            ErrorProvider1.SetError(txtMonto, "Ingrese un Monto Estipulado")
            txtMonto.Focus()
            Return
        ElseIf sueldo <= 0 Then
            ErrorProvider1.SetError(txtMonto, "Ingrese un Monto Estipulado valido")
            txtMonto.Focus()
            Return
        Else
            ErrorProvider1.SetError(txtMonto, "")
        End If

        Call AgregarcontratoCiente()
        Call AudiLogInsertCliente()
        Call LimpiarCliente()

    End Sub

    Private Sub AgregarcontratoCiente()

        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarContratoCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@FechaInicio", SqlDbType.Date).Value = dtpFechaInicio.Value
                    .Parameters.Add("@FechaFinal", SqlDbType.Date).Value = dtpFechaFinal.Value
                    .Parameters.Add("@Monto", SqlDbType.Money).Value = Convert.ToDecimal(txtMonto.Text)
                    .Parameters.Add("@IdCliente", SqlDbType.Int).Value = CInt(TxtCliente.Text)
                    .Parameters.Add("@Observacion", SqlDbType.NVarChar).Value = txtObservacion.Text
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
    Private Sub LimpiarCliente()
        txtMonto.Clear()
        txtObservacion.Clear()
    End Sub


    Private Sub txtsueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsueldo.KeyPress
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

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
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

    Private Sub DgvContrato_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvContrato.CellDoubleClick
        FrmInventario.TxtContrato.Text = DgvContrato.CurrentRow.Cells(0).Value.ToString()
        Me.Close()
    End Sub

    ' Cambiar el color de las Label
    Private Sub LblAgregarContratoEmp_MouseMove(sender As Object, e As MouseEventArgs) Handles LblAgregarContratoEmp.MouseMove
        LblAgregarContratoEmp.ForeColor = Color.Green
    End Sub

    Private Sub LblAgregarContratoEmp_MouseLeave(sender As Object, e As EventArgs) Handles LblAgregarContratoEmp.MouseLeave
        LblAgregarContratoEmp.ForeColor = Color.Black
    End Sub

    Private Sub LblAgregarContratoClien_MouseMove(sender As Object, e As MouseEventArgs) Handles LblAgregarContratoClien.MouseMove
        LblAgregarContratoClien.ForeColor = Color.Green
    End Sub

    Private Sub LblAgregarContratoClien_MouseLeave(sender As Object, e As EventArgs) Handles LblAgregarContratoClien.MouseLeave
        LblAgregarContratoClien.ForeColor = Color.Black
    End Sub

    Private Sub LblVerContratoEmple_MouseMove(sender As Object, e As MouseEventArgs) Handles LblVerContratoEmple.MouseMove
        LblVerContratoEmple.ForeColor = Color.Green
    End Sub

    Private Sub LblVerContratoEmple_MouseLeave(sender As Object, e As EventArgs) Handles LblVerContratoEmple.MouseLeave
        LblVerContratoEmple.ForeColor = Color.Black
    End Sub

    Private Sub LblVerContratoClien_MouseMove(sender As Object, e As MouseEventArgs) Handles LblVerContratoClien.MouseMove
        LblVerContratoClien.ForeColor = Color.Green
    End Sub

    Private Sub LblVerContratoClien_MouseLeave(sender As Object, e As EventArgs) Handles LblVerContratoClien.MouseLeave
        LblVerContratoClien.ForeColor = Color.Black
    End Sub

    Private Sub LblAsignar_MouseLeave(sender As Object, e As EventArgs) Handles LblAsignar.MouseLeave
        LblAsignar.ForeColor = Color.Black
    End Sub

    Private Sub LblAsignar_MouseMove(sender As Object, e As MouseEventArgs) Handles LblAsignar.MouseMove
        LblAsignar.ForeColor = Color.Green
    End Sub

    Private Sub PbxBuscar_Click(sender As Object, e As EventArgs) Handles PbxBuscar.Click
        FrmEmpleado.Show()
        FrmEmpleado.TcEmpleado.Visible = True
        FrmEmpleado.TcEmpleado.SelectedTab = FrmEmpleado.TpVer
        sele = 5
    End Sub

    Private Sub AsignarGuardias()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If

        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_InsertarECC"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn

                    .Parameters.Add("@NumIdentidad", SqlDbType.Char).Value = TxtGuardias.Text
                    .Parameters.Add("@IdContratoCliente", SqlDbType.Int).Value = CInt(CboContratoCliente.SelectedValue)

                    .ExecuteNonQuery()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub



    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Call AsignarGuardias()
        Call MostrarGuardias()
        TxtGuardias.Clear()
    End Sub

    Public Sub CargarContratoCliente()
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        cn.Open()
        Try
            Using cmd As New SqlCommand
                With cmd
                    .CommandText = "Sp_MostrarContratoCliente"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = cn
                End With
                Dim da As New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                da.Fill(ds, "ContratoCliente")
                CboContratoCliente.DataSource = ds.Tables(0)
                CboContratoCliente.DisplayMember = ds.Tables(0).Columns("IdContratoCliente").ToString
                CboContratoCliente.ValueMember = ds.Tables(0).Columns("IdContratoCliente").ToString
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub PbxBuscarGuardia_Click_1(sender As Object, e As EventArgs) Handles PbxBuscarGuardia.Click
        FrmEmpleado.Show()
        FrmEmpleado.TcEmpleado.Visible = True
        FrmEmpleado.TcEmpleado.SelectedTab = FrmEmpleado.TpVer
        sele = 6
    End Sub

    Private Sub MostrarGuardias()
        da = New SqlDataAdapter("exec Sp_MostrarGuardiasAsignados " + Convert.ToString(CboContratoCliente.SelectedValue), cn)
        dt = New DataTable
        da.Fill(dt)
        DgvGuardias.DataSource = dt
    End Sub

    Private Sub CboContratoCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboContratoCliente.SelectedIndexChanged
        If CboContratoCliente.DisplayMember IsNot "" Then
            MostrarGuardias()
        End If



    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        FrmClientes.Show()
        FrmClientes.TcCliente.Visible = True
        FrmClientes.TcCliente.SelectedTab = FrmClientes.TpVer
    End Sub

    Private Sub LblAsignar_Click(sender As Object, e As EventArgs) Handles LblAsignar.Click
        sele = 4
        verificarHelp()
        TpContrato.Visible = True
        TpContrato.SelectedTab = TpAsignacion
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If sele = 1 Then
            Dim reporte As New ReporteContratoEmpleado()
            Dim viewer As New ReportPrintTool(reporte)
            viewer.ShowPreview()
        Else
            If sele = 2 Then
                Dim reporte As New ReporteContratoCliente()
                Dim viewer As New ReportPrintTool(reporte)
                viewer.ShowPreview()
            End If
        End If
    End Sub

    Private Sub AudiLogInsertEmpleado()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO AudiLog (Descripcion, Usuario) VALUES (@Descripcion, @Usuario)", cn)
            da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = "Se inserto Contrato para empleado con ID: " + TxtNumIdentidad.Text
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

    Private Sub AudiLogInsertCliente()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO AudiLog (Descripcion, Usuario) VALUES (@Descripcion, @Usuario)", cn)
            da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = "Se inserto Contrato para cliente con ID: " + TxtCliente.Text
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

    Private Sub AudiLogModificarEmpleado()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("INSERT INTO AudiLog (Descripcion, Usuario) VALUES (@Descripcion, @Usuario)", cn)
            da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = "Se modificó Contrato para empleado con ID: " + TxtNumIdentidad.Text
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

    Private Sub BtnModificar_Click(sender As Object, e As EventArgs) Handles BtnModificar.Click
        Call Modificarcontrato()
        Call AudiLogModificarEmpleado()
        Call Limpiar()
        Call MostrarDatosContratoEmpleado()
        TpContrato.SelectedTab = TabPage3
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        dtpFechaInicio.Enabled = False
        txtsueldo.Enabled = False
        CboTipoEmpleado.Enabled = False
        CboTipoContrato.Enabled = False
        BtnModificar.Enabled = True
        BtnGuardar.Enabled = False
        dtpFechaInicio.Value = CDate(DgvContrato.CurrentRow.Cells(1).Value)
        txtsueldo.Text = DgvContrato.CurrentRow.Cells(3).Value
        CboTipoEmpleado.Text = DgvContrato.CurrentRow.Cells(4).Value
        CboTipoContrato.Text = DgvContrato.CurrentRow.Cells(5).Value
        TxtNumIdentidad.Text = DgvContrato.CurrentRow.Cells(6).Value



        TpContrato.SelectedTab = TabPage1

    End Sub

    Private Sub Label14_MouseMove(sender As Object, e As MouseEventArgs) Handles Label14.MouseMove
        Label14.ForeColor = Color.Green
    End Sub

    Private Sub Label14_MouseLeave(sender As Object, e As EventArgs) Handles Label14.MouseLeave
        Label14.ForeColor = Color.Black
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        ContratosExpirar.ShowDialog()
    End Sub
End Class
