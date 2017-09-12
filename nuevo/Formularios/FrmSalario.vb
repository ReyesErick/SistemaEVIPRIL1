Imports System.Data.SqlClient
Public Class FrmSalario
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call InsertarSalario()
        TxtMonto.Clear()
        TxtNumIdentidad.Clear()
        Me.Close()
    End Sub

    Private Sub InsertarSalario()
        Using da As New SqlDataAdapter
            da.InsertCommand = New SqlCommand("insert into Salarios (Salario, NumIdentidad, Descripcion) Values(@Salario, @NumIdentidad, @Descripcion)", cn)
            da.InsertCommand.Parameters.Add("@Salario", SqlDbType.Money).Value = CDbl(TxtMonto.Text)
            da.InsertCommand.Parameters.Add("@NumIdentidad", SqlDbType.Char, 13).Value = TxtNumIdentidad.Text
            da.InsertCommand.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 300).Value = "Aumento de Salario"

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
End Class