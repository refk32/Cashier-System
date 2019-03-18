
Public Class Form_Report_Semua_Detail_Transaksi

    Public idtr() As String

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        Dim report1 As New Report_Semua_Detail_Transaksi

        CrystalReportViewer1.ReportSource = report1
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class