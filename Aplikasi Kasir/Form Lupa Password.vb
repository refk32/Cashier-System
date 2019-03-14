Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Lupa_Password
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Hide()
        OpenForm(Form_Login)

    End Sub

    Private Sub OkBT_Click(sender As Object, e As EventArgs) Handles OkBT.Click

        dt = DAFillDT("select id_kry from Table_Karyawan where id_kry = '" + IDTB.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS")

        If dt.Rows.Count > 0 Then

            PertanyaanCB.Enabled = True
            JawabanTB.Enabled = True
            ContinueBT.Enabled = True
            IDTB.Enabled = False
            OkBT.Enabled = False

        Else

            MsgBox("ID tidak ditemukan")
            PertanyaanCB.Enabled = False
            JawabanTB.Enabled = False
            ContinueBT.Enabled = False

        End If

    End Sub

    Private Sub ContinueBT_Click(sender As Object, e As EventArgs) Handles ContinueBT.Click

        dt = DAFillDT("select tanya_kry,jawab_kry from Table_Karyawan where id_kry = '" + IDTB.Text + "' and tanya_kry = '" + PertanyaanCB.Text + "' and jawab_kry = '" + JawabanTB.Text + "' ")

        If dt.Rows.Count > 0 Then

            Form_Ubah_Password.ID = IDTB.Text

            Me.Hide()
            OpenForm(Form_Ubah_Password)

        Else

            MsgBox("Pertanyaan / jawaban anda salah")

        End If

    End Sub

    Private Sub Form_Lupa_Password_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        IDTB.Clear()
        IDTB.Enabled = True
        OkBT.Enabled = True

        PertanyaanCB.Enabled = False
        PertanyaanCB.SelectedIndex = -1
        JawabanTB.Enabled = False
        JawabanTB.Clear()
        ContinueBT.Enabled = False

    End Sub

    Private Sub Form_Lupa_Password_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing

        Dim result As MsgBoxResult

        If e.CloseReason = CloseReason.UserClosing Then

            result = MsgBox("Exit ?", vbYesNo, "Exit")

            If result = vbYes Then

                Mati()

            Else

                e.Cancel = True

            End If

        End If

    End Sub

End Class