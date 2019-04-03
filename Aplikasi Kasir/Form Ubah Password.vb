Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Ubah_Password

    Public ID As String
    Public pass As String
    Private fa As Form_Admin
    Private fk As Form_Kasir

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles OkBT.Click

        Dim query As String = "update table_karyawan set pass_kry = '" + PasswordTB.Text + "'  where id_kry = '" + ID + "' "

        Dim result As MsgBoxResult

        result = MsgBox("Ok?", vbYesNo, "Ok")
        If result = vbYes Then

            ExecuteNonQuery_Func(query)
            MsgBox("Edit berhasil")
            Me.Close()

        End If

    End Sub

    Private Sub PasswordTB_TextChanged(sender As Object, e As EventArgs) Handles PasswordTB.TextChanged

        'special treatment untuk ubah password dari form admin
        If Not fa Is Nothing And PasswordTB.Text.Equals(pass) Then

            PasswordLBL.Visible = True
            PasswordLBL.Text = "Password tidak boleh sama dengan sebelumnya"


            'special treatment untuk ubah password dari form kasir
        ElseIf Not fk Is Nothing And PasswordTB.Text.Equals(pass) Then

            PasswordLBL.Visible = True
            PasswordLBL.Text = "Password tidak boleh sama dengan sebelumnya"

        ElseIf PasswordTB.Text.Contains(" ") Then

            PasswordLBL.Visible = True
            PasswordLBL.Text = "Tidak boleh ada spasi"

        Else

            PasswordLBL.Visible = False

        End If

        ControlConfirm()
        ControlSave()

    End Sub


    Private Sub PasswordTB2_TextChanged(sender As Object, e As EventArgs) Handles ConfirmTB.TextChanged

        ControlConfirm()
        ControlSave()

    End Sub

    Sub ControlSave()

        If PasswordLBL.Visible Or ConfirmLBL.Visible Or String.IsNullOrWhiteSpace(PasswordTB.Text) Or String.IsNullOrWhiteSpace(ConfirmTB.Text) Then

            OkBT.Enabled = False

        Else

            OkBT.Enabled = True

        End If

    End Sub

    Sub ControlConfirm()

        If Not String.Equals(PasswordTB.Text, ConfirmTB.Text) And Not String.IsNullOrWhiteSpace(ConfirmTB.Text) Then

            ConfirmLBL.Visible = True
            ConfirmLBL.Text = "Password harus sama"

        Else

            ConfirmLBL.Visible = False

        End If

    End Sub

    Private Sub Form_Ubah_Password_Closed(sender As Object, e As FormClosedEventArgs) Handles Me.Closed

        If Not fa Is Nothing Then

            OpenForm(fa)

        ElseIf Not fk Is Nothing Then

            OpenForm(fk)

        Else

            OpenForm(Form_Login)

        End If

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

    Public Sub PassForm(form As Form, id2 As String, Optional pass2 As String = "")

        If form.Name = Form_Admin.Name Then

            fa = form

        ElseIf form.Name = Form_Kasir.Name Then

            fk = form

        End If

        ID = id2
        pass = pass2

    End Sub

End Class