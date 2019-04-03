﻿Imports System.ComponentModel

Public Class Form_Master

    'fa (form_admin) sekarang di pass dari login
    Public fa As Form_Admin
    Public fk As Form_Kasir

    Private Sub Form_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.WindowState = FormWindowState.Maximized

        OpenForm(Form_Login)

    End Sub

    Private Sub KaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KaryawanToolStripMenuItem.Click

        CloseAllForm()

        Form_Admin_Karyawan.fa = fa
        Form_Admin_Karyawan.id = fa.id
        fa.Hide()
        OpenForm(Form_Admin_Karyawan)

    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click

        CloseAllForm()

        Form_Admin_Menu.fa = fa
        fa.Hide()
        OpenForm(Form_Admin_Menu)

    End Sub

    Private Sub RiwayatTransaksiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RiwayatTransaksiToolStripMenuItem.Click

        CloseAllForm()

        Form_Riwayat_Transaksi.fa = fa
        fa.Hide()
        OpenForm(Form_Riwayat_Transaksi)

    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click

        CloseAllForm()

        Form_Report.fa = fa
        fa.Hide()
        OpenForm(Form_Report)

    End Sub

    Private Sub Form_Master_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing

        e.Cancel = True

    End Sub

    Private Sub KasirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KasirToolStripMenuItem.Click

        Form_Kasir_Kasir.fk = fk
        Form_Kasir_Kasir.id = fk.id
        Form_Kasir_Kasir.nama = fk.nama
        OpenForm(Form_Kasir_Kasir)
        fk.Hide()

    End Sub

    Private Sub DiskonToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiskonToolStripMenuItem.Click

        CloseAllForm()

        fa.Hide()
        Form_Admin_Diskon.fa = fa
        OpenForm(Form_Admin_Diskon)

    End Sub

    Private Sub PajakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PajakToolStripMenuItem.Click

        CloseAllForm()

        Form_Admin_Pajak.fa = fa
        fa.Hide()
        OpenForm(Form_Admin_Pajak)

    End Sub

    Private Sub UbahPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UbahPasswordToolStripMenuItem.Click

        CloseAllForm()

        OpenForm(Form_Ubah_Password)
        Form_Ubah_Password.PassForm(fa, fa.id)
        fa.Hide()

    End Sub

    Private Sub UbahPasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UbahPasswordToolStripMenuItem1.Click

        CloseAllForm()

        OpenForm(Form_Ubah_Password)
        Form_Ubah_Password.PassForm(fk, fk.id)
        fk.Hide()

    End Sub

    Sub CloseAllForm()

        For Each form As Form In Me.MdiChildren

            If form.Name = "Form_Admin" Then

                fa = form


            Else

                '_validate itu ada di module buat validasi close atau gak
                ClosingWithoutValidate(form)

            End If

        Next

    End Sub

End Class