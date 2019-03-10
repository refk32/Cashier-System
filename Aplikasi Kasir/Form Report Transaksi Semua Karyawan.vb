Public Class Form_Report_Transaksi_Semua_Karyawan
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        Dim report1 As New Report_Transaksi_Semua_Karyawan

        CrystalReportViewer1.ReportSource = report1
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class