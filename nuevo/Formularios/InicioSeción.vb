Imports System.Data.SqlClient
Public Class FrmInicioSeción
    Private Sub LblCerrar_Click(sender As Object, e As EventArgs) Handles LblCerrar.Click
        Me.Close()
    End Sub

    Private Function Conexion() As Boolean
        Try
            cn.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub FrmInicioSeción_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.ConexionTemporal = My.Settings.Conexion
        My.Settings.Save()
        TxtPassword.Clear()
        If Conexion() = False Then
            Me.Hide()
            Dim frm As New FrmConfiguracion()
            FrmConfiguracion.Show()
        End If
    End Sub

    Private Sub BtnInicioSesion_Click(sender As Object, e As EventArgs) Handles BtnInicioSesion.Click
        If Validar(TxtUser, "Debe ingresar un nombre de usuario") Then
        ElseIf Validar(TxtPassword, "Debe ingresar una contraseña") Then
        Else

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            Try
                cn.Open()
                Dim user As String = Replace(TxtUser.Text, "'", "")
                Dim pass As String = SHA1(TxtPassword.Text)
                Using cmd As New SqlCommand

                    With cmd
                        .CommandText = "Sp_Login"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = cn
                        .Parameters.Add("@UserName", SqlDbType.NVarChar).Value = user
                        .Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass
                    End With
                    Dim reader As SqlDataReader = cmd.ExecuteReader

                    If reader.HasRows Then
                        Me.Hide()
                        FrmPantallaPrincipal.Show()
                    Else
                        MsgBox("Usuario y Contrasena invalido")
                    End If
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    Function Validar(Control As Control, Mensaje As String) As Boolean

        If Control.Text.Trim = Nothing Then
            ErrorProvider1.SetError(Control, Mensaje)
            Control.Focus()
            Validar = True
        Else
            ErrorProvider1.SetError(Control, "")
            Validar = False
        End If
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class