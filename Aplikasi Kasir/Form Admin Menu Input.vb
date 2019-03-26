Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Form_Admin_Menu_Input

    Dim kode_mkn_array() As String
    Dim nama_mkn_array() As String

    Dim kode_mkn As String
    Dim nama_mkn As String

    Dim tmp As String

    Private Sub Form_Admin_Menu_Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'get array from form admin menu
        With Form_Admin_Menu

            kode_mkn_array = .kode_mkn
            nama_mkn_array = .nama_mkn

        End With

        DataGridView1.DataSource = DAFillDS("select kode_mkn from table_menu", "table_menu").Tables("table_menu")
        For Each row As DataGridViewRow In DataGridView1.Rows

            row.Cells(0).Value = row.Cells(0).Value.ToString().Remove(0, 1)

        Next

        DataGridView1.Sort(DataGridView1.Columns(0), ListSortDirection.Ascending)

        'harus diinvisible dari sini setelah sort karena kalau dimatiin sebelum disort, jadinya tidak tersort
        DataGridView1.Visible = False

    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        Dim result As MsgBoxResult
        result = MsgBox("Save?", vbYesNo, "Save")

        If result = vbYes Then

            Try

                Dim input As String = "insert into table_menu values ('" + KodeMakananTB.Text + "','" + NamaMakananTB.Text + "','" + HargaTB.Text + "' )  "

                ExecuteNonQuery_Func(input)

                MsgBox("Input berhasil")
                Form_Admin_Menu.DisplayMenu()
                KodeMakananTB.Text = ""
                NamaMakananTB.Text = ""
                HargaTB.Text = ""
                ClosingWithoutValidate(Me)

            Catch ex As SqlException

                If ex.Number = 2627 Then

                    MsgBox("Kode makanan sudah ada sebelumnya")

                End If

            End Try

        End If

    End Sub

    Private Sub NamaMakananTB_TextChanged(sender As Object, e As EventArgs) Handles NamaMakananTB.TextChanged

        For Each s As String In nama_mkn_array

            If Not String.IsNullOrWhiteSpace(s) Then

                tmp = s & " "

            End If

            If NamaMakananTB.Text.Equals(s) Or NamaMakananTB.Text.Equals(tmp) Then

                NamaMakananLBL.Visible = True
                NamaMakananLBL.Text = "Nama makanan sudah ada"

                Exit Sub

            End If

        Next

        If NamaMakananTB.Text.StartsWith(" ") Then

            NamaMakananLBL.Visible = True
            NamaMakananLBL.Text = DimulaiSpasi()

        ElseIf NamaMakananTB.Text.Contains("  ") Then

            NamaMakananLBL.Visible = True
            NamaMakananLBL.Text = DoubleSpace()

        ElseIf Not Regex.IsMatch(NamaMakananTB.Text, "^[A-Za-z ]+$") And Not String.IsNullOrWhiteSpace(NamaMakananTB.Text) Then

            NamaMakananLBL.Visible = True
            NamaMakananLBL.Text = "Hanya boleh huruf"

        Else

            NamaMakananLBL.Visible = False

        End If

        ControlSave()

    End Sub

    Private Sub HargaTB_TextChanged(sender As Object, e As EventArgs) Handles HargaTB.TextChanged

        Dim i As Integer = 0

        For Each a As Char In HargaTB.Text

            If a = "0" Then

                i += 1

            End If

        Next

        If HargaTB.Text.Contains(" ") Then

            HargaLBL.Visible = True
            HargaLBL.Text = "Tidak boleh ada spasi"

        ElseIf Not IsNumeric(HargaTB.Text) And Not String.IsNullOrWhiteSpace(HargaTB.Text) Then

            HargaLBL.Visible = True
            HargaLBL.Text = HanyaAngka()

        ElseIf HargaTB.Text.Contains("+") Or HargaTB.Text.Contains("-") Or HargaTB.Text.Contains(",") Then

            HargaLBL.Visible = True
            HargaLBL.Text = HanyaAngka()

        ElseIf i = HargaTB.Text.Count And Not String.IsNullOrWhiteSpace(HargaTB.Text) Then

            HargaLBL.Visible = True
            HargaLBL.Text = "Harga tidak bisa 0"
        Else

            HargaLBL.Visible = False

        End If

        ControlSave()

    End Sub

    Sub ControlSave()

        If KodeMakananLBL.Visible Or NamaMakananLBL.Visible Or HargaLBL.Visible Or String.IsNullOrWhiteSpace(KodeMakananTB.Text) Or String.IsNullOrWhiteSpace(NamaMakananTB.Text) Or String.IsNullOrWhiteSpace(HargaTB.Text) Then

            SaveBT.Enabled = False

        Else

            SaveBT.Enabled = True

        End If

    End Sub

    Private Function DimulaiSpasi() As String

        Return "Tidak bisa dimulai dengan spasi"

    End Function

    Private Function DoubleSpace() As String

        Return "Spasi tidak bisa beruntun"

    End Function

    Private Function HanyaAngka() As String

        Return "Hanya bisa angka"

    End Function

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()

    End Sub

    Private Sub Form_Admin_Menu_Input_Closing(sender As Object, e As FormClosingEventArgs) Handles Me.Closing

        If e.CloseReason = CloseReason.MdiFormClosing Then

            Exit Sub

        End If

        ClosingValidate(e, Me)

    End Sub

    Private Sub MakananRadio_CheckedChanged(sender As Object, e As EventArgs) Handles MakananRadio.CheckedChanged

        If MakananRadio.Checked Then

            Dim kode As String

            kode = AutoIncrement("table_menu", "kode_mkn", DataGridView1, True)

            kode_mkn = "F" & kode

            KodeMakananTB.Text = kode_mkn

        End If

    End Sub

    Private Sub MinumanRadio_CheckedChanged(sender As Object, e As EventArgs) Handles MinumanRadio.CheckedChanged

        If MinumanRadio.Checked Then

            Dim kode As String

            kode = AutoIncrement("table_menu", "kode_mkn", DataGridView1, True)

            kode_mkn = "D" & kode

            KodeMakananTB.Text = kode_mkn

        End If

    End Sub

    Private Sub Form_Admin_Menu_Input_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        Form_Admin_Menu.DeleteBT.Enabled = True

    End Sub

End Class