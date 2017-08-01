Imports System.Data.SqlClient
Imports System.IO
Public Class PerfilEmpleado
    Dim cmd As New SqlCommand
    Dim dt As DataTable
    Dim da As SqlDataReader
    Dim datos As New DataSet

    Private Sub PerfilEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cn.State = ConnectionState.Open Then
            cn.Close()

        End If
        cn.Open()
        cmd = New SqlCommand("Select c.FechaInicio,c.FechaFinal,c.SueldoBase,t.TipoEmpleado,ti.TipoContrato
		From Empleado e inner join ContratoEmpleado c
						on e.NumIdentidad = c.NumIdentidad
						inner join TipoEmpleado t
						on c.IdTipoEmpleado = t.IdTipoEmpleado
						inner join TipoContrato ti
						on c.IdTipoContrato = ti.IdTipoContrato
		Where e.NumIdentidad = '" + FrmEmpleado.DgvVerEmpleado.CurrentRow.Cells(0).Value + "'", cn)

        Try
            da = cmd.ExecuteReader()
            da.Read()
            dtpFechaInicial.Value = da("FechaInicio")
            dtpFechaFinal.Value = da("FechaFinal")
            txtSueldo.Text = da("SueldoBase").ToString()
            txtTipoEmpleado.Text = da("TipoEmpleado").ToString()
            txtTipoContrato.Text = da("TipoContrato").ToString()
        Catch ex As Exception
            MessageBox.Show("Error al mostrar la informacion")
        Finally
            cn.Close()
            da.Close()
        End Try





    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click

        FrmPrestacion.txtNumIdentidadEmpleado.Text = TxtNumIdentidad.Text
        FrmPrestacion.TxtNombre.Text = TxtNombres.Text + " " + TxtApellidos.Text
        FrmPrestacion.TxtSOM.Text = txtSueldo.Text
        FrmPrestacion.DtpFIngreso.Value = dtpFechaInicial.Value
        FrmPrestacion.DtpFTerminacion.Value = dtpFechaFinal.Value
        FrmPrestacion.Show()
        Me.Close()

    End Sub
End Class