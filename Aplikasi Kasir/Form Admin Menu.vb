Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_Admin_Menu

    Public fa As Form_Admin
    Public a() As String

    Private Sub Form_Admin_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()

        DisplayMenu()

    End Sub

    Private Sub InputBT_Click(sender As Object, e As EventArgs) Handles InputBT.Click

        For Each form As Form In Form_Master.MdiChildren

            If form.Name.Equals(Me.Name) Or form.Name.Equals(Form_Admin.Name) Then

                'HARUS KEK GINI, GK BOLEH PAKE NOT DI IF

            Else

                form.Close()

            End If
        Next

        For Each form As Form In Form_Master.MdiChildren

            If form.Name.Equals(Me.Name) Or form.Name.Equals(Form_Admin.Name) Then

                'HARUS KEK GINI, GK BOLEH PAKE NOT DI IF

            Else


                Exit Sub

            End If

        Next

        ReDim a(DataGridView1.Rows.Count)

        For i As Integer = 0 To DataGridView1.Rows.Count - 1

            a(i) = DataGridView1.Rows(i).Cells(0).Value

        Next

        OpenForm(Form_Admin_Menu_Input)
        DeleteBT.Enabled = False

    End Sub

    Public Sub DisplayMenu()

        DataGridView1.DataSource = (DAFillDS("select * from table_menu", "table_menu").Tables("table_menu"))

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

            Form_Admin_Menu_Edit.kode = DataGridView1.CurrentRow.Cells(0).Value
            Form_Admin_Menu_Edit.nama = DataGridView1.CurrentRow.Cells(1).Value
            Form_Admin_Menu_Edit.harga = DataGridView1.CurrentRow.Cells(2).Value

            DeleteBT.Enabled = False
            OpenForm(Form_Admin_Menu_Edit)

        End If

    End Sub

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()

    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click

        Dim kode As Object
        Dim result As MsgBoxResult

        If DataGridView1.Rows.Count > 0 Then

            kode = DataGridView1.CurrentRow.Cells(0).Value
            result = MsgBox("Delete?", vbYesNo, "Delete")

            If result = vbYes Then

                Koneksi()
                Dim query As String = "delete from table_menu where kode_mkn = '" + kode + "' "
                ExecuteNonQuery_Func(query)
                MsgBox("Delete success")
                DisplayMenu()

            End If

        End If

    End Sub

    Private Sub Form_Admin_Menu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        OpenForm(fa)

    End Sub


End Class