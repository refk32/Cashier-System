Imports System.ComponentModel

Public Class Form_Admin_Pajak

    Dim nick As String()

    Private Sub Form_Admin_Pajak_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        RefreshData()
        DataGridView1.ClearSelection()

    End Sub

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()

    End Sub

    Private Sub Form_Admin_Pajak_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ClosingValidate(e, Me)

    End Sub

    Sub RefreshData()

        Dim query As String
        Dim ds As DataSet

        query = "select * from table_pajak"

        ds = DAFillDS(query, "table_pajak")

        DataGridView1.DataSource = ds.Tables("table_pajak")

        If DataGridView1.Rows.Count > 0 Then

            ReDim nick(DataGridView1.Rows.Count)

            For i As Integer = 0 To DataGridView1.Rows.Count - 1

                nick(i) = DataGridView1.Rows(i).Cells(0).Value

            Next

        End If

    End Sub

    Private Sub InsertBT_Click(sender As Object, e As EventArgs) Handles InsertBT.Click

        Dim result As MsgBoxResult

        If InputRadio.Checked Then

            result = MsgBox("Save ?", vbYesNo, "Save")

            If result = vbYes Then

                ExecuteNonQuery_Func("insert into table_pajak values('" & NicknameTB.Text & "', '" & NamaTB.Text & "', " & PersenNUD.Value & "  )")
                MsgBox("Save berhasil")
                RefreshData()

            End If

        ElseIf EditRadio.Checked Then

            result = MsgBox("Edit ?", vbYesNo, "Edit")

            If result = vbYes Then

                Dim query As String

                query = "update table_pajak set nama_pajak = '" & NamaTB.Text & "', persen_pajak = " & PersenNUD.Value & " where nick_pajak = '" & NicknameTB.Text & "'  "
                ExecuteNonQuery_Func(query)
                MsgBox("Edit berhasil")
                RefreshData()
                DataGridView1.CurrentCell.Selected = False

                NicknameTB.Clear() : NamaTB.Clear() : PersenNUD.Value = 1

            End If

        End If

    End Sub

    Sub ControlSave()

        If String.IsNullOrWhiteSpace(NicknameTB.Text) Or String.IsNullOrWhiteSpace(NamaTB.Text) Or String.IsNullOrWhiteSpace(PersenNUD.Value) Or NicknameLBL.Visible Or NamaLBL.Visible Then

            InsertBT.Enabled = False

        Else

            InsertBT.Enabled = True

        End If

    End Sub

    Private Sub NicknameTB_TextChanged(sender As Object, e As EventArgs) Handles NicknameTB.TextChanged

        If NicknameTB.Text.StartsWith(" ") Then

            NicknameLBL.Visible = True
            NicknameLBL.Text = "Tidak bisa dimulai dengan spasi"

        ElseIf NicknameTB.Text.Contains("  ") Then

            NicknameLBL.Visible = True
            NicknameLBL.Text = "Tidak boleh ada spasi beruntun"

        ElseIf nick.Contains(NicknameTB.Text) And InputRadio.Checked Then

            NicknameLBL.Visible = True
            NicknameLBL.Text = "Nickname sudah dipakai"

        Else

            NicknameLBL.Visible = False

        End If

        ControlSave()

    End Sub

    Private Sub NamaTB_TextChanged(sender As Object, e As EventArgs) Handles NamaTB.TextChanged

        If NamaTB.Text.StartsWith(" ") Then

            NamaLBL.Visible = True
            NamaLBL.Text = "Tidak bisa dimulai dengan spasi"

        ElseIf NamaTB.Text.Contains("  ") Then

            NamaLBL.Visible = True
            NamaLBL.Text = "Tidak boleh ada spasi beruntun"

        Else

            NamaLBL.Visible = False

        End If

        ControlSave()

    End Sub

    Private Sub PersenNUD_ValueChanged(sender As Object, e As EventArgs) Handles PersenNUD.ValueChanged

        ControlSave()

    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click

        Dim nick As String
        Dim result As MsgBoxResult

        nick = DataGridView1.CurrentRow.Cells(0).Value

        result = MsgBox("Delete ?", vbYesNo, "Delete")

        If result = vbYes Then

            ExecuteNonQuery_Func("delete from table_pajak where nick_pajak = '" & nick & "' ")
            MsgBox("Delete Sukses")
            RefreshData()

        End If

    End Sub

    Private Sub InputRadio_CheckedChanged(sender As Object, e As EventArgs) Handles InputRadio.CheckedChanged

        NicknameTB.Enabled = True : NamaTB.Enabled = True : PersenNUD.Enabled = True : DeleteBT.Enabled = False

    End Sub

    Private Sub EditRadio_CheckedChanged(sender As Object, e As EventArgs) Handles EditRadio.CheckedChanged

        NicknameTB.Enabled = False : NamaTB.Enabled = True : PersenNUD.Enabled = True
        NicknameTB.Clear() : NamaTB.Clear() : PersenNUD.Value = 1

        If DataGridView1.Rows.Count > 0 Then

            DataGridView1.CurrentCell.Selected = False

        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Dim persen As Integer

        If DataGridView1.CurrentCell.Selected = True Then

            DeleteBT.Enabled = True

        End If

        If EditRadio.Checked Then

            NicknameTB.Text = DataGridView1.CurrentRow.Cells(0).Value
            NamaTB.Text = DataGridView1.CurrentRow.Cells(1).Value
            persen = DataGridView1.CurrentRow.Cells(2).Value
            PersenNUD.Value = persen

        End If

    End Sub

End Class