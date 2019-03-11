Public Class Form_Report_Transaksi_Karyawan
    Public karyawan As String

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        Dim report1 As New Report_Transaksi_Karyawan

        CrystalReportViewer1.ReportSource = report1
        CrystalReportViewer1.SelectionFormula = "{Table_MasterTR.nama_kry} = '" + karyawan + "'"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class