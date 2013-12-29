Imports System.Data
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class Lap_PerTransVW

    Private RptDoc As ReportDocument

    Private Sub Lap_harian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QButton1.Click
        Try
            strSql = "Select P.No_penjualan, P.tgl_jual, D.kd_brg, B.Nm_brg, D.jumlah, D.hrg_jual, D.Sub_total, P.user_id FROM (Tb_penjualan P INNER JOIN tb_Penjualan_detail D ON P.no_penjualan = D.No_penjualan) " & _
                                                                                        "INNER JOIN tb_barang B ON B.kd_brg = D.Kd_brg  WHERE P.no_penjualan = '" & TextBox1.Text & "'"

            mycon = New MySqlConnection(strCon)
            mycon.Open()
            objAdapter = New MySqlDataAdapter(strSql, mycon)

            Dim hsl_rpt As New DS_PerTrans
            objAdapter.Fill(hsl_rpt, "DS_PerTrans")

            RptDoc = New ReportDocument
            RptDoc.Load("D:\Portofolio\dedi\dedi\Laporan\Cr_PerTrans.rpt")
            RptDoc.SetDataSource(hsl_rpt)
            crVwHarian.ReportSource = RptDoc
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class