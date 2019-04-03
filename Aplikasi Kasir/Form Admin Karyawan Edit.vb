Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form_Admin_Karyawan_Edit

    Public data(6) As Object

    Sub KondisiAwal()

        NamaTB.Text = data(0)
        JenisKelaminCB.SelectedIndex = JenisKelaminCB.FindStringExact(data(1))
        JabatanCB.SelectedIndex = JabatanCB.FindStringExact(data(2))
        IDTB.Text = data(3)
        PasswordTB.Text = data(4)
        ConfirmTB.Text = data(4)
        PertanyaanCB.SelectedIndex = PertanyaanCB.FindStringExact(data(5))
        JawabanTB.Text = data(6)

        Form_Master.ToolStrip1.Visible = False

    End Sub

    Private Sub Form_Admin_Karyawan_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KondisiAwal()

    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        Dim result As MsgBoxResult
        result = MsgBox("Save?", vbYesNo, "Save")

        If result = vbYes Then

            Dim query As String = "update table_karyawan set nama_kry = '" + NamaTB.Text + "', jk_kry = '" + JenisKelaminCB.Text + "', jabatan_kry = '" + JabatanCB.Text + "', id_kry = '" + IDTB.Text + "', pass_kry = '" + PasswordTB.Text + "', tanya_kry = '" + PertanyaanCB.Text + "', jawab_kry = '" + JawabanTB.Text + "'  where id_kry = '" + IDTB.Text + "' "
            ExecuteNonQuery_Func(query)

            MsgBox("Edit berhasil")
            Form_Admin_Karyawan.DisplayMenu()
            OpenForm(Form_Admin_Karyawan)
            ClosingWithoutValidate(Me)

        End If

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

    Private Sub Form_Admin_Karyawan_Edit_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing

        If e.CloseReason = CloseReason.MdiFormClosing Then

            Exit Sub

        End If

        ClosingValidate(e, Me)

    End Sub

    Private Sub ConfirmTB_TextChanged(sender As Object, e As EventArgs) Handles ConfirmTB.TextChanged

        ControlConfirm()
        ControlSave()

    End Sub

    Sub ControlConfirm()

        If Not PasswordTB.Text.Equals(ConfirmTB.Text) And Not String.IsNullOrWhiteSpace(ConfirmTB.Text) Then

            ConfirmLBL.Visible = True
            ConfirmLBL.Text = "Password harus sama"

        Else

            ConfirmLBL.Visible = False

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

    Private Sub Form_Admin_Karyawan_Edit_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        OpenForm(Form_Admin_Karyawan)
        Form_Master.ToolStrip1.Visible = True
        Form_Admin_Karyawan.DeleteBT.Enabled = True

    End Sub
End Class