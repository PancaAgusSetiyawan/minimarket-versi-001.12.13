Imports System
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient

Public Class Lap_Pj_harianVw

    Private RptDoc As ReportDocument
    Private objLapHarian As Lap_FrmPenjualan

    Private Sub harian()
        strSql = "Select P.Tgl_jual, SUM(D.Sub_total) As Sub_Total, P.User_id From Tb_penjualan P INNER JOIN tb_penjualan_Detail D On P.No_penjualan = D.No_penjualan WHERE P.tgl_jual BETWEEN '" & Format(dtPicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(dtPicker2.Value, "yyyy-MM-dd") & "' Group By P.tgl_jual Order By P.tgl_Jual Asc"

        mycon = New MySqlConnection(strCon)
        mycon.Open()
        objAdapter = New MySqlDataAdapter(strSql, mycon)

        Dim Hasil As New Ds_Pj_Harian
        objAdapter.Fill(Hasil, "Ds_pj_harian")

        RptDoc = New ReportDocument
        RptDoc.Load("D:\Portofolio\dedi\dedi\Laporan\Cr_Pj_Harian.rpt")
        RptDoc.SetDataSource(Hasil)
        CrystalReportViewer1.ReportSource = RptDoc
    End Sub

    Private Sub Frm_Lap_harianVw_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Call harian()
    End Sub

End Class