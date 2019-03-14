Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports System.Data.SqlClient

Public Class Form_Admin_Menu_Edit

    Public kode As Object
    Public nama As Object
    Public harga As Object

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        Dim result As MsgBoxResult
        result = MsgBox("Save?", vbYesNo, "Save")

        If result = vbYes Then

            Dim edit As String = "update table_menu set nama_mkn = '" + NamaMakananTB.Text + "', harga_mkn = '" + HargaTB.Text + "'  where kode_mkn = '" + KodeMakananTB.Text + "' "
            ExecuteNonQuery_Func(edit)

            MsgBox("Edit berhasil")
            Form_Admin_Menu.DisplayMenu()
            ClosingWithoutValidate(Me)

        End If

    End Sub

    Private Sub Form_Admin_Menu_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KondisiAwal()

    End Sub

    Sub KondisiAwal()

        KodeMakananTB.Text = kode
        NamaMakananTB.Text = nama
        HargaTB.Text = harga

    End Sub

    Private Sub NamaMakananTB_TextChanged(sender As Object, e As EventArgs) Handles NamaMakananTB.TextChanged

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

        ElseIf HargaTB.Text.Contains("+") Or HargaTB.Text.Contains("-") Or HargaTB.Text.Contains(",") Or HargaTB.Text.Contains(".") Or HargaTB.Text.Contains("$") Then

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

    Private Sub Form_Admin_Menu_Edit_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ClosingValidate(e, Me)
        If e.Cancel = False Then

            Form_Admin_Menu.DeleteBT.Enabled = True

        End If

    End Sub

End Class