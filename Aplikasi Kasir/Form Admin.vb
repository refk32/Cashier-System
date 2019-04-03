Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Admin

    Public nama As String
    Public id As String

    Private Sub LogOutBT_Click(sender As Object, e As EventArgs) Handles LogOutBT.Click

        For Each form As Form In Form_Master.MdiChildren

            If Not form.Name = Me.Name Then

                form.Close()

            End If

        Next

        For Each form As Form In Form_Master.MdiChildren

            If Not form.Name = Me.Name Then

                Exit Sub

            End If

        Next

        OpenForm(Form_Login)
        Form_Login.idTB.Text = ""
        Form_Login.passTB.Text = ""

        Form_Master.ToolStrip1.Visible = False

        Me.Hide()

    End Sub

    Private Sub RiwayatTransaksiBT_Click(sender As Object, e As EventArgs)

        Form_Riwayat_Transaksi.Jabatan = "admin"
        Form_Riwayat_Transaksi.fa = Me
        Form_Riwayat_Transaksi.UpdateData()
        Form_Riwayat_Transaksi.Show()
        Me.Hide()

    End Sub

    Private Sub Form_Admin_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Form_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NamaLBL.Text = nama
        IDLBL.Text = id

        Form_Master.ToolStripDropDownButton3.Text = nama

    End Sub

    Private Sub Form_Admin_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing

        e.Cancel = True

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        XButton()

    End Sub
End Class