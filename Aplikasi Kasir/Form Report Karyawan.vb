Public Class Form_Report_Karyawan
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        Dim shit As Report_Karyawan

        shit = New Report_Karyawan()
        CrystalReportViewer1.ReportSource = shit

    End Sub
End Class