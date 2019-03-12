Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class Form_Kasir_Kasir

    Public fk As Form_Kasir

    'untuk menghitung berapa jumlah row yang ada di datagrid
    Public rownumber As Integer

    'id dan nama karyawan
    Public id As String
    Public nama As String

    'gabungan semua nama makanan di datagrid
    Dim gabungannama As String
    Dim gabungankode As String

    Dim harga As Integer
    Dim i As Integer = 0
    Dim a As Integer = 0

    'kode tr terakhir pada table
    Dim kodecog As String
    'kode tr setelah dimanipulasi
    Dim id_tr2 As String

    Private Sub AddBT_Click(sender As Object, e As EventArgs) Handles AddBT.Click

        Dim quantity As Integer
        Dim hargasatuan As Integer

        KembalianTB.Clear()

        'di parse hanya untuk jaga-jaga tapi sepertinya gak perlu
        Integer.TryParse(QuantityNUD.Value, quantity)

        If Not BarangCB.Text = "" Then
            If DataGridView1.Rows.Count > 0 Then
                For Each row As DataGridViewRow In DataGridView1.Rows

                    If BarangCB.Text = row.Cells(1).Value Then

                        hargasatuan = row.Cells(3).Value / row.Cells(2).Value

                        row.Cells(2).Value += quantity
                        row.Cells(3).Value = hargasatuan * row.Cells(2).Value

                        QuantityNUD2_Update()
                        TotalHargaSub()

                        Exit Sub

                    End If

                Next

            End If

        Else

            Exit Sub

        End If

        InsertData()

    End Sub

    Private Sub Form_Kasir_Kasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridView2.DataSource = DAFillDS("select id_tr from table_mastertr", "table_mastertr").Tables("table_mastertr")

        DiskonDGV.DataSource = DAFillDS("select * from table_diskon", "table_diskon").Tables("table_diskon")

        PajakDGV.DataSource = DAFillDS("select * from table_pajak", "table_pajak").Tables("table_pajak")

        KondisiAwal()
        BarangCB.SelectedIndex = -1

    End Sub

    Sub Change()

        Try

            HargaCB.SelectedIndex = BarangCB.SelectedIndex
            KodeCB.SelectedIndex = BarangCB.SelectedIndex

            HargaTB.Text = HargaCB.Text
            KodeMakananTB.Text = KodeCB.Text

        Catch ex As Exception

        End Try

    End Sub

    Sub KondisiAwal()

        Dim dt As DataTable

        Dim query As String = "select nama_mkn from table_menu"

        dt = DAFillDT(query)
        BarangCB.DisplayMember = "nama_mkn"
        BarangCB.DataSource = dt

        query = "select harga_mkn from table_menu"

        dt = DAFillDT(query)
        HargaCB.DisplayMember = "harga_mkn"
        HargaCB.DataSource = dt

        query = "select kode_mkn from table_menu"

        dt = DAFillDT(query)
        KodeCB.DisplayMember = "kode_mkn"
        KodeCB.DataSource = dt

    End Sub

    Private Sub BarangCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BarangCB.SelectedIndexChanged

        Change()
        QuantityNUD.Value = 1

    End Sub

    Private Sub DeleteBT_Click(sender As Object, e As EventArgs) Handles DeleteBT.Click

        If DataGridView1.Rows.Count > 0 Then

            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentCell.RowIndex)
            rownumber = rownumber - 1
            QuantityNUD2_Update()
            TotalHargaSub()
            KembalianTB.Text = 0

        End If

    End Sub

    Sub TotalHargaSub()

        Dim mindiskon As Integer
        Dim maxdiskon As Integer
        Dim subtotal As Integer
        Dim persen As Double
        Dim diskon As Double
        Dim maxpotongan As Integer

        harga = 0

        While i < DataGridView1.Rows.Count

            harga += DataGridView1.Rows(i).Cells(3).Value
            i += 1

        End While

        SubTotalTB.Text = harga
        subtotal = harga

        i = 0

        For Each rows As DataGridViewRow In DiskonDGV.Rows

            mindiskon = rows.Cells(2).Value
            maxdiskon = rows.Cells(3).Value

            If subtotal >= mindiskon And (subtotal <= maxdiskon Or maxdiskon = 0) Then

                maxpotongan = rows.Cells(4).Value

                persen = rows.Cells(1).Value / 100

                diskon = subtotal * persen

                If diskon > maxpotongan And Not maxpotongan.Equals(0) Then

                    diskon = maxpotongan

                End If

                DiskonTB.Text = diskon

            End If

        Next

        If diskon <= 0 Then

            DiskonTB.Text = 0

        End If

        For Each rows2 As DataGridViewRow In PajakDGV.Rows

            If rows2.Cells(0).Value.Equals("PPN") Or rows2.Cells(0).Value.Equals("ppn") Then

                Dim persenpajak As Double

                persenpajak = rows2.Cells(2).Value / 100

                PPNTB.Text = (subtotal - diskon) * persenpajak

                Exit For

            End If

        Next

        Dim ppn As Integer

        If DataGridView1.Rows.Count > 0 Then

            subtotal = SubTotalTB.Text
            diskon = DiskonTB.Text
            ppn = PPNTB.Text

            TotalHargaTB.Text = subtotal - diskon + ppn

        Else

            TotalHargaTB.Text = 0

        End If

    End Sub

    Sub InsertData()

        Dim harga As Integer

        Integer.TryParse(HargaTB.Text, harga)

        If QuantityNUD.Value > 0 Then

            DataGridView1.Rows.Add()
            DataGridView1.Rows(rownumber).Cells(0).Value = KodeMakananTB.Text
            DataGridView1.Rows(rownumber).Cells(1).Value = BarangCB.Text
            DataGridView1.Rows(rownumber).Cells(2).Value = QuantityNUD.Value
            DataGridView1.Rows(rownumber).Cells(3).Value = harga * QuantityNUD.Value

            QuantityNUD2_Update()

            rownumber = rownumber + 1

        Else

            MsgBox("isi quantity ")

        End If

        TotalHargaSub()

    End Sub

    Private Sub HitungTB_Click(sender As Object, e As EventArgs) Handles HitungTB.Click

        If Not String.IsNullOrWhiteSpace(TotalHargaTB.Text) Then

            If String.IsNullOrWhiteSpace(PembayaranTB.Text) Then

                MsgBox("Isi pembayaran terlebih dahulu")

            Else

                Dim pembayaran As Integer
                Dim totalharga As Integer

                Integer.TryParse(PembayaranTB.Text, pembayaran)
                Integer.TryParse(TotalHargaTB.Text, totalharga)

                KembalianTB.Text = pembayaran - totalharga

            End If

        Else

            MsgBox("Total harga kosong")

        End If

    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click

        If KembalianTB.Text = "0" Or TotalHargaTB.Text = "0" Or TotalHargaTB.Text = "0" Then

            MsgBox("data belum lengkap")

        Else

            If KembalianTB.Text.Contains("-") Then

                MsgBox("Kembalian tidak boleh minus")

            Else

                Dim result As MsgBoxResult

                result = MsgBox("Save ?", vbYesNo, "Save")

                If result = vbYes Then

                    Dim query As String

                    id_tr2 = AutoIncrement("table_mastertr", "id_tr", DataGridView2)

                    'insert data id sesuai yang id paling terakhir +1
                    query = "insert into table_mastertr values ('" + id_tr2 + "', " & SubTotalTB.Text & ", " & DiskonTB.Text & ", " & PPNTB.Text & ", " + TotalHargaTB.Text + ", " + PembayaranTB.Text + ", " + KembalianTB.Text + ", '" + id + "', '" + nama + "', getdate() )"

                    ExecuteNonQuery_Func(query)

                    Insert_DetailTR()
                    MsgBox("Save Berhasil")

                    ClosingWithoutValidate(Me)
                    OpenForm(fk)

                End If

            End If

        End If

    End Sub

    Sub Insert_DetailTR()

        For Each rows As DataGridViewRow In DataGridView1.Rows

            Dim query As String

            Dim hargasatuan As String
            Dim quantity As String
            Dim hargatotal As String

            hargasatuan = rows.Cells(3).Value / rows.Cells(2).Value
            quantity = rows.Cells(2).Value.ToString()
            hargatotal = rows.Cells(3).Value

            query = "insert into table_detailtr values ('" + id_tr2 + "', '" + rows.Cells(0).Value + "','" + rows.Cells(1).Value + "', '" + hargasatuan + "', '" + quantity + "', '" + hargatotal + "' )"

            ExecuteNonQuery_Func(query)

        Next

    End Sub

    Private Sub PembayaranTB_LostFocus(sender As Object, e As EventArgs) Handles PembayaranTB.LostFocus

        If PembayaranTB.Text.Contains("-") Or PembayaranTB.Text.Contains("+") Or PembayaranTB.Text.Contains(",") Or PembayaranTB.Text.Contains(".") Or PembayaranTB.Text.Contains("$") Then

            MsgBox("Jangan pakai lambang aneh - aneh")
            PembayaranTB.Clear()

        Else

            If String.IsNullOrWhiteSpace(PembayaranTB.Text) Then

                PembayaranTB.Clear()

            Else

                If IsNumeric(PembayaranTB.Text) Then

                Else

                    MsgBox("Isi dengan angka")
                    KembalianTB.Clear()
                    PembayaranTB.Clear()

                End If

            End If

        End If

    End Sub

    Private Sub QuantityNUD_LostFocus(sender As Object, e As EventArgs) Handles QuantityNUD.LostFocus

        If QuantityNUD.Text = "" Then

            QuantityNUD.Text = "1"

        End If

    End Sub

    Sub QuantityNUD2_Update()

        If DataGridView1.Rows.Count > 0 Then

            QuantityNUD2.Enabled = True
            QuantityNUD2.Value = DataGridView1.CurrentRow.Cells(2).Value

        Else

            QuantityNUD2.Enabled = False
            QuantityNUD2.Value = 1

        End If

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        QuantityNUD2_Update()

    End Sub

    Private Sub QuantityNUD2_ValueChanged(sender As Object, e As EventArgs) Handles QuantityNUD2.ValueChanged

        Dim quantity As Integer
        Dim hargasatuan As Integer

        If DataGridView1.Rows.Count > 0 Then

            quantity = DataGridView1.CurrentRow.Cells(2).Value
            hargasatuan = DataGridView1.CurrentRow.Cells(3).Value / quantity

            DataGridView1.CurrentRow.Cells(2).Value = QuantityNUD2.Value
            DataGridView1.CurrentRow.Cells(3).Value = hargasatuan * DataGridView1.CurrentRow.Cells(2).Value

            KembalianTB.Clear()

            TotalHargaSub()

        End If

    End Sub

    Private Sub PembayaranTB_TextChanged(sender As Object, e As EventArgs) Handles PembayaranTB.TextChanged

        KembalianTB.Clear()

    End Sub

    Private Sub BackBT_Click(sender As Object, e As EventArgs) Handles BackBT.Click

        Me.Close()
        OpenForm(fk)

    End Sub

    Private Sub Form_Kasir_Kasir_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        ClosingValidate(e, Me)

    End Sub

End Class