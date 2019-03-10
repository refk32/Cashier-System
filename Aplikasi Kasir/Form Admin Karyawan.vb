Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Admin_Karyawan

    Public fa As Form_Admin
    Public id As String
    Public a() As String

    Public Sub DisplayMenu()

        DataGridView1.DataSource = (DAFillDS("select * from table_karyawan", "table_karyawan").Tables("table_karyawan"))

    End Sub

    Private Sub InputBT_Click(sender As Object, e As EventArgs) Handles InputBT.Click

        'Pass array berisi id ke form input

        ReDim a(DataGridView1.Rows.Count)

        For i As Integer = 0 To DataGridView1.Rows.Count - 1

            a(i) = DataGridView1.Rows(i).Cells(3).Value

        Next

        For Each form As Form In Form_Master.MdiChildren

            If form.Name.Equals(Me.Name) Or form.Name.Equals(Form_Admin.Name) Then

                'some buggy shit here

            Else

                form.Close()

            End If


        Next

        For Each form As Form In Form_Master.MdiChildren

            If form.Name.Equals(Me.Name) Or form.Name.Equals(Form_Admin.Name) Then

                'some buggy shit here

            Else

                Exit Sub

            End If

        Next

        OpenForm(Form_Admin_Karyawan_Input)

    End Sub

    Private Sub EditBT_Click(sender As Object, e As EventArgs) Handles EditBT.Click

        If DataGridView1.Rows.Count > 0 Then

            For Each form As Form In Form_Master.MdiChildren

                If form.Name.Equals(Me.Name) Or form.Name.Equals(Form_Admin.Name) Then

                    'some buggy shit here

                Else

                    form.Close()

                End If


            Next

            For Each form As Form In Form_Master.MdiChildren

                If form.Name.Equals(Me.Name) Or form.Name.Equals(Form_Admin.Name) Then

                    'some buggy shit here

                Else

                    Exit Sub

                End If

            Next

            Form_Admin_Karyawan_Edit.nama = DataGridView1.CurrentRow.Cells(0).Value
            Form_Admin_Karyawan_Edit.jeniskelamin = DataGridView1.CurrentRow.Cells(1).Value
            Form_Admin_Karyawan_Edit.jabatan = DataGridView1.CurrentRow.Cells(2).Value
            Form_Admin_Karyawan_Edit.id = DataGridView1.CurrentRow.Cells(3).Value
            Form_Admin_Karyawan_Edit.password = DataGridView1.CurrentRow.Cells(4).Value
            Form_Admin_Karyawan_Edit.pertanyaan = DataGridView1.CurrentRow.Cells(5).Value
            Form_Admin_Karyawan_Edit.jawaban = DataGridView1.CurrentRow.Cells(6).Value

            OpenForm(Form_Admin_Karyawan_Edit)

        End If

    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click

        Dim kode As Object
        Dim result As MsgBoxResult

        If DataGridView1.Rows.Count > 0 Then

            kode = DataGridView1.CurrentRow.Cells(3).Value

            If Not kode = id Then

                result = MsgBox("Delete?", vbYesNo, "Delete")

                If result = vbYes Then

                    Dim query As String = "delete from table_karyawan where id_kry = '" + kode + "' "

                    ExecuteNonQuery_Func(query)

                    MsgBox("Delete success")
                    DisplayMenu()

                End If

            Else

                MsgBox("Tidak bisa delete diri sendiri")

            End If

        End If

    End Sub

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()
        OpenForm(fa)

    End Sub

    Private Sub Form_Admin_Karyawan_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        DisplayMenu()

    End Sub

    Private Sub Form_Admin_Karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class