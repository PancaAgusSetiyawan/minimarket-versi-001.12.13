Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Lap_Pb_Harian

    Private RptDoc As ReportDocument

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        strSql = "Select P.Tgl_beli,SUM(D.Sub_total) As Sub_total, P.User_id From Tb_pembelian P INNER JOIN tb_pembelian_Detail D On P.No_pembelian = D.No_pembelian WHERE P.tgl_beli BETWEEN '" & Format(dtPicker1.Value, "yyyy-MM-dd") & "' AND '" & Format(dtPicker2.Value, "yyyy-MM-dd") & "' Group By P.tgl_beli Order By P.tgl_beli Asc"

        mycon = New MySqlConnection(strCon)
        mycon.Open()
        objAdapter = New MySqlDataAdapter(strSql, mycon)

        Dim Hasil As New Ds_Pb_Harian
        objAdapter.Fill(Hasil, "Ds_Pb_harian")

        RptDoc = New ReportDocument
        RptDoc.Load("D:\Portofolio\dedi\dedi\Laporan\Cr_Pb_Harian.rpt")
        RptDoc.SetDataSource(Hasil)
        CrystalReportViewer1.ReportSource = RptDoc
    End Sub
End Class