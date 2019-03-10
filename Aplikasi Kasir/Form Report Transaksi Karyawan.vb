Public Class Form_Report_Transaksi_Karyawan
    Public karyawan As String

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        If karyawan = "(SEMUA)" Then

            Dim report1 As New Report_Transaksi_Karyawan
            Dim IDText As CrystalDecisions.CrystalReports.Engine.FieldObject =
                report1.Section2.ReportObjects("idkry1")

            Dim NamaText As CrystalDecisions.CrystalReports.Engine.FieldObject =
                report1.Section2.ReportObjects("namakry1")

            CrystalReportViewer1.ReportSource = report1
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()

        Else

            CrystalReportViewer1.ReportSource = "D:\Cashier-System-refk-dev\Aplikasi Kasir\Report Transaksi Karyawan.rpt"
            CrystalReportViewer1.SelectionFormula = "{Table_MasterTR.nama_kry} = '" + karyawan + "'"
            CrystalReportViewer1.Refresh()
            CrystalReportViewer1.RefreshReport()

        End If



    End Sub
End Class