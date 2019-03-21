Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Ubah_Password

    Public ID As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkBT.Click

        Dim query As String = "update table_karyawan set pass_kry = '" + PasswordTB.Text + "'  where id_kry = '" + ID + "' "

        Dim result As MsgBoxResult

        result = MsgBox("Ok?", vbYesNo, "Ok")
        If result = vbYes Then

            ExecuteNonQuery_Func(query)
            MsgBox("Edit berhasil")
            Me.Close()
            Form_Login.Show()

        End If

    End Sub

    Private Sub PasswordTB_TextChanged(sender As Object, e As EventArgs) Handles PasswordTB.TextChanged

        If PasswordTB.Text.Contains(" ") Then

            PasswordLBL.Visible = True
            PasswordLBL.Text = "Tidak boleh ada spasi"

        Else

            PasswordLBL.Visible = False

        End If

        ControlSave()

    End Sub


    Private Sub PasswordTB2_TextChanged(sender As Object, e As EventArgs) Handles ConfirmTB.TextChanged

        If Not String.Equals(PasswordTB.Text, ConfirmTB.Text) And Not String.IsNullOrWhiteSpace(ConfirmTB.Text) Then

            ConfirmLBL.Visible = True
            ConfirmLBL.Text = "Password harus sama"

        Else

            ConfirmLBL.Visible = False

        End If

        ControlSave()

    End Sub

    Sub ControlSave()

        If PasswordLBL.Visible Or ConfirmLBL.Visible Or String.IsNullOrWhiteSpace(PasswordTB.Text) Or String.IsNullOrWhiteSpace(ConfirmTB.Text) Then

            OkBT.Enabled = False

        Else

            OkBT.Enabled = True

        End If

    End Sub

    Private Sub Form_Ubah_Password_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Form_Login.Show()

    End Sub

    Private Sub PasswordCheck_CheckedChanged(sender As Object, e As EventArgs) Handles PasswordCheck.CheckedChanged

        If PasswordCheck.Checked Then

            PasswordTB.PasswordChar = ""

        Else

            PasswordTB.PasswordChar = "●"

        End If

    End Sub

    Private Sub ConfirmCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ConfirmCheck.CheckedChanged

        If ConfirmCheck.Checked Then

            ConfirmTB.PasswordChar = ""

        Else

            ConfirmTB.PasswordChar = "●"

        End If

    End Sub
End Class