Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Admin

    Public nama As String
    Public id As String
    Public pass As String

    Private Sub RiwayatTransaksiBT_Click(sender As Object, e As EventArgs)

        With Form_Riwayat_Transaksi
            .Jabatan = "admin"
            .fa = Me
            .UpdateData()
            .Show()
        End With

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