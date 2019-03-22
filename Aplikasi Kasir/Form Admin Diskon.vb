Imports System.ComponentModel

Public Class Form_Admin_Diskon

    Public fa As Form_Admin
    Dim header = New String() {"ID", "Persen", "Minimal Diskon", "Maksimal Diskon", "Maksimal Potongan"}

    Private Sub Form_Admin_Diskon_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged

        RefreshData()

        For i As Integer = 0 To DataGridView1.Columns.Count - 1

            DataGridView1.Columns(i).HeaderText = header(i)

        Next

    End Sub

    Sub RefreshData()

        DataGridView1.DataSource = DAFillDS("select * from table_diskon", "table_diskon").Tables("table_diskon")
        DataGridView2.DataSource = DAFillDS("select id_disk from table_diskon", "table_diskon").Tables("table_diskon")

    End Sub

    Private Sub InputRadio_CheckedChanged(sender As Object, e As EventArgs) Handles InputRadio.CheckedChanged

        EnabledEverything()
        ClearData()

    End Sub

    Private Sub EditRadio_CheckedChanged(sender As Object, e As EventArgs) Handles EditRadio.CheckedChanged

        EnabledEverything()
        ClearData()
        DataGridView1.CurrentCell.Selected = False

    End Sub

    Sub EnabledEverything()

        PersenNUD.Enabled = True
        MinTB.Enabled = True
        MaxCheck.Enabled = True
        PotonganCheck.Enabled = True

    End Sub

    Private Sub MaxCheck_CheckedChanged(sender As Object, e As EventArgs) Handles MaxCheck.CheckedChanged

        MaxTB.Enabled = MaxCheck.Checked

        If MaxCheck.Checked Then

            MaxTB.Clear()

        Else

            MaxTB.Clear()
            MaxTB.Enabled = False
            MaxTB.Text = "0"



        End If

    End Sub

    Private Sub PotonganCheck_CheckedChanged(sender As Object, e As EventArgs) Handles PotonganCheck.CheckedChanged

        PotonganTB.Enabled = PotonganCheck.Checked

        If PotonganCheck.Checked Then

            PotonganTB.Clear()

        Else

            PotonganTB.Clear()
            PotonganTB.Enabled = False
            PotonganTB.Text = "0"

        End If

    End Sub

    Private Sub InsertBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        Dim result As MsgBoxResult

        If InputRadio.Checked Then

            result = MsgBox("Save ?", vbYesNo, "Save")

            If result = vbYes Then

                Dim id_disk As String

                id_disk = AutoIncrement("table_diskon", "id_disk", DataGridView2)

                ExecuteNonQuery_Func("insert into table_diskon values('" & id_disk & "', " & PersenNUD.Value & ", " & MinTB.Text & ", " & MaxTB.Text & ", " & PotonganTB.Text & "  )")

                MsgBox("Save berhasil")
                RefreshData()
                ClearData()

            End If

        ElseIf EditRadio.Checked Then

            result = MsgBox("Edit?", vbYesNo, "Edit")

            If result = vbYes Then

                Dim id_disk As String

                id_disk = DataGridView1.CurrentRow.Cells(0).Value

                ExecuteNonQuery_Func("update table_diskon set persen_disk = " & PersenNUD.Value & ", min_disk = " & MinTB.Text & ", max_disk = " & MaxTB.Text & ", maxpotongan_disk = " & PotonganTB.Text & " where id_disk = '" & id_disk & "' ")
                MsgBox("Edit berhasil")
                RefreshData()

                DataGridView1.CurrentCell.Selected = False
                ClearData()

            End If

        End If



    End Sub

    Sub ControlSave()

        If String.IsNullOrWhiteSpace(MinTB.Text) Or String.IsNullOrWhiteSpace(MaxTB.Text) Or String.IsNullOrWhiteSpace(PotonganTB.Text) Or MinLBL.Visible Or MaxLBL.Visible Or PotonganLBL.Visible Then

            SaveBT.Enabled = False

        Else

            SaveBT.Enabled = True

        End If

    End Sub

    Private Sub MinTB_TextChanged(sender As Object, e As EventArgs) Handles MinTB.TextChanged

        If MinTB.Text.Contains(" ") Then

            MinLBL.Visible = True
            MinLBL.Text = "Tidak boleh ada spasi"

        ElseIf Not IsNumeric(MinTB.Text) And Not String.IsNullOrWhiteSpace(MinTB.Text) Then

            MinLBL.Visible = True
            MinLBL.Text = "Hanya bisa angka"

        ElseIf MinTB.Text.Contains("+") Or MinTB.Text.Contains("-") Or MinTB.Text.Contains(",") Then

            MinLBL.Visible = True
            MinLBL.Text = "Hanya bisa angka"

        Else

            MinLBL.Visible = False

        End If

        ControlMinMax()
        ControlSave()

    End Sub

    Private Sub MaxTB_TextChanged(sender As Object, e As EventArgs) Handles MaxTB.TextChanged

        Dim i As Integer = 0

        For Each a As Char In MaxTB.Text

            If a = "0" Then

                i += 1

            End If

        Next

        If MaxTB.Text.Contains(" ") Then

            MaxLBL.Visible = True
            MaxLBL.Text = "Tidak boleh ada spasi"

        ElseIf Not IsNumeric(MaxTB.Text) And Not String.IsNullOrWhiteSpace(MaxTB.Text) Then

            MaxLBL.Visible = True
            MaxLBL.Text = "Hanya bisa angka"

        ElseIf MaxTB.Text.Contains("+") Or MaxTB.Text.Contains("-") Or MaxTB.Text.Contains(",") Then

            MaxLBL.Visible = True
            MaxLBL.Text = "Hanya bisa angka"

        ElseIf i = MaxTB.Text.Count And Not String.IsNullOrWhiteSpace(MaxTB.Text) And MaxCheck.Checked Then

            MaxLBL.Visible = True
            MaxLBL.Text = "Maks. pembelian tidak bisa 0 bila dienable"

            'harus manual mematikan minlbl dari sini
        ElseIf String.IsNullOrWhiteSpace(MaxTB.Text) And MaxCheck.Checked Then

            MinLBL.Visible = False

        Else

            MaxLBL.Visible = False

        End If

        ControlMinMax()
        ControlSave()

    End Sub

    Private Sub PotonganTB_TextChanged(sender As Object, e As EventArgs) Handles PotonganTB.TextChanged

        Dim i As Integer = 0

        For Each a As Char In PotonganTB.Text

            If a = "0" Then

                i += 1

            End If

        Next

        If PotonganTB.Text.Contains(" ") Then

            PotonganLBL.Visible = True
            PotonganLBL.Text = "Tidak boleh ada spasi"

        ElseIf Not IsNumeric(PotonganTB.Text) And Not String.IsNullOrWhiteSpace(PotonganTB.Text) Then

            PotonganLBL.Visible = True
            PotonganLBL.Text = "Hanya bisa angka"

        ElseIf PotonganTB.Text.Contains("+") Or PotonganTB.Text.Contains("-") Or PotonganTB.Text.Contains(",") Then

            PotonganLBL.Visible = True
            PotonganLBL.Text = "Hanya bisa angka"

        ElseIf i = PotonganTB.Text.Count And Not String.IsNullOrWhiteSpace(PotonganTB.Text) And PotonganCheck.Checked Then

            PotonganLBL.Visible = True
            PotonganLBL.Text = "Maks. potongan tidak bisa 0 bila dienable"
        Else

            PotonganLBL.Visible = False

        End If

        ControlSave()

    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click

        Dim result As MsgBoxResult

        result = MsgBox("Delete ?", vbYesNo, "Delete")

        If result = vbYes Then

            Dim query As String

            query = "delete from table_diskon where id_disk = '" & DataGridView1.CurrentRow.Cells(0).Value & "' "
            ExecuteNonQuery_Func(query)

            MsgBox("Delete berhasil")

            RefreshData()

        End If

    End Sub

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()

    End Sub

    Private Sub Form_Admin_Diskon_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing

        If e.CloseReason = CloseReason.MdiFormClosing Then

            Exit Sub

        End If

        ClosingValidate(e, Me)

    End Sub

    Sub ClearData()

        PersenNUD.Value = 1
        MinTB.Clear()
        MaxCheck.Checked = False
        PotonganCheck.Checked = False

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        If EditRadio.Checked Then

            Dim persen As Integer
            Dim min As Integer
            Dim max As Integer
            Dim potongan As Integer

            persen = DataGridView1.CurrentRow.Cells(1).Value
            min = DataGridView1.CurrentRow.Cells(2).Value
            max = DataGridView1.CurrentRow.Cells(3).Value
            potongan = DataGridView1.CurrentRow.Cells(4).Value

            PersenNUD.Value = persen
            MinTB.Text = min

            If max = 0 Then

                MaxCheck.Checked = False

            Else

                MaxCheck.Checked = True
                MaxTB.Text = max

            End If

            If potongan = 0 Then

                PotonganCheck.Checked = False

            Else

                PotonganCheck.Checked = True
                PotonganTB.Text = potongan

            End If

        End If

    End Sub

    Sub ControlMinMax()

        Dim min As Integer
        Dim max As Integer

        If Not String.IsNullOrWhiteSpace(MinTB.Text) And Not String.IsNullOrWhiteSpace(MaxTB.Text) And IsNumeric(MinTB.Text) And IsNumeric(MaxTB.Text) And MaxCheck.Checked Then

            min = MinTB.Text
            max = MaxTB.Text

            If min >= max Then

                MinLBL.Visible = True
                MinLBL.Text = "Min. pembelian terlalu besar"

            Else

                MinLBL.Visible = False

            End If

            ControlSave()

        End If

    End Sub

    Private Sub Form_Admin_Diskon_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        OpenForm(fa)

    End Sub

End Class