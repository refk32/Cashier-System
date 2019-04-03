Imports System.ComponentModel

Public Class Form_Kasir
    Public nama As String
    Public id As String
    Public pass As String

    Private Sub Form_Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NamaLBL.Text = nama
        IDLBL.Text = id

        Form_Master.ToolStripDropDownButton4.Text = nama

    End Sub

    Private Sub Form_Kasir_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        Form_Master.ToolStrip2.Visible = True

    End Sub

    Private Sub Form_Kasir_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing

        If e.CloseReason = CloseReason.MdiFormClosing Then

            Exit Sub

        End If

        ClosingWithoutValidate(Me)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        XButton()

    End Sub
End Class