﻿Public Class Form_Report

    Public fa As Form_Admin

    Private Sub ReportBT_Click(sender As Object, e As EventArgs) Handles ReportBT.Click

        If KaryawanRB.Checked Then

            Form_Report_Karyawan.Show()

        ElseIf MenuRB.Checked Then

            Form_Report_Menu.Show()

        ElseIf TransaksiRB.Checked Then

            If KaryawanCB.Text = "(SEMUA)" Then

                Form_Report_Transaksi_Semua_Karyawan.Show()

            Else

                Form_Report_Transaksi_Karyawan.Show()

            End If

        End If

    End Sub

    Private Sub TransaksiRB_CheckedChanged(sender As Object, e As EventArgs) Handles TransaksiRB.CheckedChanged

        If TransaksiRB.Checked Then

            KaryawanCB.Enabled = True

        Else

            KaryawanCB.Enabled = False

        End If

    End Sub

    Private Sub KaryawanCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles KaryawanCB.SelectedIndexChanged

        Form_Report_Transaksi_Karyawan.karyawan = KaryawanCB.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ReportDetailTRBT.Click

        If IDTRLB.SelectedIndex >= 0 Then

            Form_Report_Master_Transaksi.id_tr = CType(IDTRLB.SelectedItem, DataRowView).Row.Item(0).ToString()
            Form_Report_Master_Transaksi.Show()

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles IDTRTB.TextChanged

        If Not String.IsNullOrWhiteSpace(IDTRTB.Text) Then

            Dim items As String

            For i As Integer = 0 To IDTRLB.Items.Count - 1

                items = CType(IDTRLB.Items(i), DataRowView).Row.Item(0).ToString()

                If items.Contains(IDTRTB.Text) Then

                    IDTRLB.SelectedItem = IDTRLB.Items(i)
                    Exit Sub

                End If

            Next

            IDTRLB.SelectedItems.Clear()

        Else

            IDTRLB.SelectedItems.Clear()

        End If

    End Sub

    Private Sub Form_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'simple configuration
        Me.WindowState = FormWindowState.Maximized

        Dim dt As DataTable
        Dim row As DataRow

        'ngambil data dari database dimasukkan ke combobox karyawan yang buat bikin report transaksi berdasarkan nama karyawan

        dt = DAFillDT("select nama_kry from Table_Karyawan where jabatan_kry ='kasir' ")

        row = dt.NewRow()
        row("nama_kry") = "(SEMUA)"
        dt.Rows.InsertAt(row, 0)
        KaryawanCB.DisplayMember = "nama_kry"

        KaryawanCB.DataSource = dt

        'ngambil data id transaksi buat bikin report detail transaksi

        dt = DAFillDT("select id_tr from Table_MasterTR")

        IDTRLB.DisplayMember = "id_tr"
        IDTRLB.DataSource = dt

        IDTRLB.SelectedIndex = -1

    End Sub

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()
        OpenForm(fa)

    End Sub
End Class