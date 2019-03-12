Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form_Admin_Karyawan_Input

    Public id() As String

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        Dim result As MsgBoxResult

        result = MsgBox("Save?", vbYesNo, "Save")
        If result = vbYes Then

            Try

                Dim query As String = "insert into table_karyawan values ('" + NamaTB.Text + "','" + JenisKelaminCB.Text + "','" + JabatanCB.Text + "','" + IDTB.Text + "','" + PasswordTB.Text + "','" + PertanyaanCB.Text + "','" + JawabanTB.Text + "'  )  "

                ExecuteNonQuery_Func(query)

                MsgBox("input data berhasil")
                Form_Admin_Karyawan.DisplayMenu()
                Me.Close()

            Catch ex As SqlException

                If ex.Number = 2627 Then

                    MsgBox("ID sudah terpakai")

                End If

            End Try

        End If

    End Sub

    Private Sub Form_Admin_Karyawan_Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        JenisKelaminCB.Items.Add("pria")
        JenisKelaminCB.Items.Add("wanita")
        JabatanCB.Items.Add("kasir")
        JabatanCB.Items.Add("admin")
        id = Form_Admin_Karyawan.a

    End Sub

    Private Sub NamaTB_TextChanged(sender As Object, e As EventArgs) Handles NamaTB.TextChanged

        If NamaTB.Text.StartsWith(" ") Then

            NamaLBL.Visible = True
            NamaLBL.Text = DimulaiSpasi()

        ElseIf NamaTB.Text.Contains("  ") Then

            NamaLBL.Visible = True
            NamaLBL.Text = DoubleSpace()

        ElseIf Not Regex.IsMatch(NamaTB.Text, "^[A-Za-z ]+$") And Not String.IsNullOrWhiteSpace(NamaTB.Text) Then

            NamaLBL.Visible = True
            NamaLBL.Text = "Hanya boleh huruf"

        Else

            NamaLBL.Visible = False

        End If

        ControlSave()

    End Sub

    Private Sub IDTB_TextChanged(sender As Object, e As EventArgs) Handles IDTB.TextChanged

        If IDTB.Text.Contains(" ") Then

            IDLBL.Visible = True
            IDLBL.Text = "Tidak boleh ada spasi"

        ElseIf id.Contains(IDTB.Text) Then

            IDLBL.Visible = True
            IDLBL.Text = "ID sudah dipakai"

        Else

            IDLBL.Visible = False

        End If

        ControlSave()

    End Sub

    Private Sub PasswordTB_TextChanged(sender As Object, e As EventArgs) Handles PasswordTB.TextChanged

        If PasswordTB.Text.Contains(" ") Then

            PasswordLBL.Visible = True
            PasswordLBL.Text = "Tidak boleh ada spasi"

        Else

            PasswordLBL.Visible = False

        End If

        ControlConfirm()
        ControlSave()

    End Sub

    Private Sub JawabanTB_TextChanged(sender As Object, e As EventArgs) Handles JawabanTB.TextChanged

        If JawabanTB.Text.StartsWith(" ") Then

            JawabanLBL.Visible = True
            JawabanLBL.Text = DimulaiSpasi()

        ElseIf JawabanTB.Text.Contains("  ") Then

            JawabanLBL.Visible = True
            JawabanLBL.Text = DoubleSpace()

        Else

            JawabanLBL.Visible = False

        End If

        ControlSave()

    End Sub

    Sub ControlSave()

        If NamaLBL.Visible Or IDLBL.Visible Or PasswordLBL.Visible Or ConfirmLBL.Visible Or JawabanLBL.Visible Or String.IsNullOrWhiteSpace(NamaTB.Text) Or String.IsNullOrWhiteSpace(JenisKelaminCB.Text) Or String.IsNullOrWhiteSpace(JabatanCB.Text) Or String.IsNullOrWhiteSpace(IDTB.Text) Or String.IsNullOrWhiteSpace(PasswordTB.Text) Or String.IsNullOrWhiteSpace(ConfirmTB.Text) Or String.IsNullOrWhiteSpace(PertanyaanCB.Text) Or String.IsNullOrWhiteSpace(JawabanTB.Text) Then

            SaveBT.Enabled = False

        Else

            SaveBT.Enabled = True

        End If

    End Sub

    Private Function DimulaiSpasi() As String

        Return "Tidak bisa dimulai dengan spasi"

    End Function

    Private Function DoubleSpace() As String

        Return "Spasi tidak bisa beruntun"

    End Function

    Private Sub JenisKelaminCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JenisKelaminCB.SelectedIndexChanged

        ControlSave()

    End Sub

    Private Sub JabatanCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles JabatanCB.SelectedIndexChanged

        ControlSave()

    End Sub

    Private Sub PertanyaanCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PertanyaanCB.SelectedIndexChanged

        ControlSave()

    End Sub

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()

    End Sub

    Private Sub Form_Admin_Karyawan_Input_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ClosingValidate(e, Me)

    End Sub

    Private Sub ConfirmTB_TextChanged(sender As Object, e As EventArgs) Handles ConfirmTB.TextChanged

        ControlConfirm()
        ControlSave()

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

    Sub ControlConfirm()

        If Not PasswordTB.Text.Equals(ConfirmTB.Text) Then

            ConfirmLBL.Visible = True
            ConfirmLBL.Text = "Password harus sama"

        Else

            ConfirmLBL.Visible = False

        End If

    End Sub

End Class