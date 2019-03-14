Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Login
    Dim id As String
    Dim pass As String
    Dim nama As String

    Private Sub LoginBT_Click(sender As Object, e As EventArgs) Handles LoginBT.Click

        'JANGAN BUANG DATATABLE BUAT CEK APAKAH ID DAN PASS BENAR
        Dim dt As DataTable

        id = idTB.Text
        pass = passTB.Text

        dt = DAFillDT("select id_kry, pass_kry from Table_Karyawan where id_kry = '" + id + "' COLLATE SQL_Latin1_General_CP1_CS_AS and pass_kry = '" + pass + "' COLLATE SQL_Latin1_General_CP1_CS_AS ")

        If dt.Rows.Count > 0 Then

            Dim jabatan As String

            'Panggil function dari module koneksi, Itu function dalam function lol (dua-dua nya di koneksi module)
            jabatan = GetFromSqlDataReader("select jabatan_kry from table_karyawan where id_kry = '" + id + "' ", "String")

            'sama kek yang atas cuman ambil nama instead of jabatan
            nama = GetFromSqlDataReader("select nama_kry from table_karyawan where id_kry = '" + idTB.Text + "' ", "String")

            If jabatan = "admin" Then

                Dim fa As Form_Admin

                fa = New Form_Admin With {
                    .nama = nama,
                    .id = idTB.Text
                }

                Form_Master.fa = fa

                Me.Hide()
                OpenForm(fa)
                Form_Master.ToolStrip1.Visible = True

            ElseIf jabatan = "kasir" Then

                Dim fk As Form_Kasir

                fk = New Form_Kasir With {
                    .id = id,
                    .nama = nama
                }

                Me.Hide()

                Form_Master.fk = fk
                OpenForm(fk)

            End If

        Else

            MsgBox("invalid id or password")

        End If

    End Sub

    Private Sub LupaPasswordBT_Click(sender As Object, e As EventArgs) Handles LupaPasswordBT.Click

        Me.Hide()
        OpenForm(Form_Lupa_Password)

    End Sub

    Private Sub Form_Login_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing

        e.Cancel = True

    End Sub

End Class
