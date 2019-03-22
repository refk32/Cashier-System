Imports System.Data.SqlClient

Module Koneksi_Module

    Dim LokasiDB As String

    Public Conn As SqlConnection
    Dim cmd As SqlCommand

    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter

    Dim dt As DataTable
    Dim ds As DataSet

    Public _validate As Boolean = True

    Public Sub Koneksi()

        LokasiDB = "Data Source=localhost\SQLEXPRESS;Initial Catalog=Kasir_db;integrated security=true"
        Conn = New SqlConnection(LokasiDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()

    End Sub

    Public Sub Mati()

        Application.Exit()

    End Sub

    Public Function SqlCommand_Func(query As String)

        Koneksi()

        cmd = New SqlCommand(query, Conn)

        Return cmd

    End Function

    Public Function DAFillDT(query As String) As DataTable

        cmd = SqlCommand_Func(query)

        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)

        Return dt

    End Function

    Public Function SqlDataReader_Func(query As String)

        Koneksi()

        cmd = SqlCommand_Func(query)
        dr = cmd.ExecuteReader()

        Return dr

    End Function

    Public Function GetFromSqlDataReader(query As String, type As String)

        dr = SqlDataReader_Func(query)

        Koneksi()

        If type = "String" Or type = "string" Then
            Dim hasilread As String

            dr.Read()
            hasilread = dr.GetString(0)

            Return hasilread

        End If

        Return Nothing

    End Function

    Public Sub ExecuteNonQuery_Func(query As String)

        Koneksi()

        cmd = New SqlCommand(query, Conn)

        cmd.ExecuteNonQuery()

    End Sub

    Public Function DAFillDS(query As String, tablename As String) As DataSet

        Koneksi()

        da = New SqlDataAdapter(query, Conn)
        ds = New DataSet()
        da.Fill(ds, tablename)

        Return ds

    End Function

    Public Sub OpenForm(form As Form)

        form.MdiParent = Form_Master
        form.Show()
        form.WindowState = FormWindowState.Maximized

    End Sub

    Public Function AutoIncrement(tablename As String, pkname As String, _datagridview As DataGridView, Optional menu As Boolean = False) As String

        Dim id As Integer = 0
        Dim id2 As String
        Dim kodecog As String

        Dim dt As DataTable

        dt = DAFillDT("select " + pkname + " from " + tablename + " ")

        If dt.Rows.Count > 0 Then

            'mengambil data id paling pertama
            kodecog = _datagridview.Rows(0).Cells(0).Value

            'supaya 0 di awal dibuang semua
            Integer.TryParse(kodecog, id)

            'apakah id pertama itu 1 atau bukan...
            If Not id = 1 Then

                'kalau belum ada id 1, maka id berikutnya akan 1
                Return "00001"

            End If

            'Ambil kode transaksi yg terakhir pada transaksi
            kodecog = _datagridview.Rows(_datagridview.Rows.Count - 1).Cells(0).Value

            Integer.TryParse(kodecog, id)

            '+1 id paling terakhir
            id += 100001
            id2 = id.ToString()

            id2 = id2.Remove(0, 1)

            'mengecek apakah ada id yang terlongkap
            For i As Integer = 0 To _datagridview.Rows.Count - 2

                Dim pertama As Integer
                Dim kedua As Integer

                pertama = _datagridview.Rows(i).Cells(0).Value.ToString()
                kedua = _datagridview.Rows(i + 1).Cells(0).Value.ToString()

                'cek apakah selisih antar 2 baris bukan lah 1
                If Not kedua - pertama = 1 Then

                    pertama += 100001
                    id = pertama

                    id2 = id.ToString()

                    id2 = id2.Remove(0, 1)

                    Return id2

                End If

            Next

            Return id2

        Else

            Return "00001"

        End If

        Return Nothing

    End Function

    Public Sub ClosingValidate(e As FormClosingEventArgs, meform As Form, Optional validate As Boolean = True)
        Dim result As MsgBoxResult

        If Not validate Or Not _validate Then

            e.Cancel = False
            Exit Sub

        End If

        result = MsgBox("Keluar dari Form '" + meform.Name + "' ? Data tidak akan tersimpan", vbYesNo, "Back")

        If result = vbNo Then

            e.Cancel = True

        End If

    End Sub

    Public Sub ClosingWithoutValidate(form As Form)

        _validate = False
        form.Close()
        _validate = True

    End Sub

End Module
