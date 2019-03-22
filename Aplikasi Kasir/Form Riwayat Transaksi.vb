Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Riwayat_Transaksi

    Public Jabatan As String
    Public fa As Form_Admin
    Dim header = New String() {"ID Transaksi", "Subtotal", "Diskon", "Pajak", "Total", "Pembayaran", "Kembalian", "ID Karyawan", "Nama Karyawan", "Tanggal Transaksi"}

    Private Sub Form_Riwayat_Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UpdateData()

        For i As Integer = 0 To DataGridView1.Columns.Count - 1

            DataGridView1.Columns(i).HeaderText = header(i)

        Next

    End Sub

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()
        OpenForm(fa)

    End Sub

    Public Sub UpdateData()

        Dim query As String = "select * from table_mastertr"

        DataGridView1.DataSource = (DAFillDS(query, "table_mastertr").Tables("table_mastertr"))

    End Sub

    Private Sub Form_Riwayat_Transaksi_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        OpenForm(fa)

    End Sub
End Class