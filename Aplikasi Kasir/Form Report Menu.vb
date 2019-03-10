Public Class Form_Report_Menu
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        CrystalReportViewer1.ReportSource = Application.StartupPath + "\Report Menu.rpt"
        CrystalReportViewer1.SelectionFormula = "{Table_Menu.harga_mkn} > 0"
        CrystalReportViewer1.Refresh()
        CrystalReportViewer1.RefreshReport()

    End Sub
End Class