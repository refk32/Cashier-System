Public Class Form_Report_Master_Transaksi

    Public id_tr As String

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        Dim reportdetail As New Report_Detail_Transaksi

        CrystalReportViewer1.ReportSource = reportdetail
        CrystalReportViewer1.SelectionFormula = "{Table_MasterTR.id_tr} = '" + id_tr + "'"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class