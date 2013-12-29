Imports System
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient

Public Class Lap_TutupKasir

    Private RptDoc As ReportDocument

    Private Sub Lap_TutupKasir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        strSql = "Select P.User_id , P.tgl_jual, SUM(D.sub_total) AS total FROM tb_penjualan P INNER JOIN tb_penjualan_detail D ON P.No_penjualan = D.No_Penjualan WHERE P.tgl_jual = Date(now())"

        mycon = New MySqlConnection(strCon)
        mycon.Open()
        objAdapter = New MySqlDataAdapter(strSql, mycon)

        Dim HasilQuery As New Ds_Tutup_Kasir
        objAdapter.Fill(HasilQuery, "Ds_Tutup_Kasir")

        RptDoc = New ReportDocument
        RptDoc.Load("D:\Portofolio\dedi\dedi\Laporan\Cr_TutupKasir.rpt")
        RptDoc.SetDataSource(HasilQuery)
        CrystalReportViewer1.ReportSource = RptDoc
    End Sub
End Class