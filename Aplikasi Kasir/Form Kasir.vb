Imports System.ComponentModel

Public Class Form_Kasir
    Public nama As String
    Public id As String

    Private Sub Form_Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NamaLBL.Text = nama
        IDLBL.Text = id

    End Sub


    Private Sub LogOutBt_(sender As Object, e As EventArgs) Handles LogOutBT.Click

        For Each form As Form In Form_Master.MdiChildren

            If Not form.Name = Me.Name Then

                form.Close()

            End If

        Next

        Form_Login.idTB.Text = ""
        Form_Login.passTB.Text = ""

        OpenForm(Form_Login)
        Me.Close()

        Form_Master.ToolStrip2.Visible = False

    End Sub

    Private Sub Form_Kasir_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        Form_Master.ToolStrip2.Visible = True

    End Sub

    Private Sub Form_Kasir_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        e.Cancel = True

    End Sub
End Class