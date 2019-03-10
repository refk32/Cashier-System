Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Riwayat_Transaksi

    Public Jabatan As String
    Public fa As Form_Admin

    Private Sub Form_Riwayat_Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateData()

        If DataGridView1.Rows.Count > 0 Then

            DataGridView1.Columns(0).Width = 50

        End If

    End Sub

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()
        OpenForm(fa)

    End Sub

    Public Sub UpdateData()

        Dim query As String = "select * from table_mastertr"

        DataGridView1.DataSource = (DAFillDS(query, "table_mastertr").Tables("table_mastertr"))

    End Sub

End Class