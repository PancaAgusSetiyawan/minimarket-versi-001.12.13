
Imports System.Data
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Lap_Pembelian

    Private RptDoc As ReportDocument

    Private Sub QButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QButton1.Click

        If TextBox1.Text = "" Then
            MsgBox("Masukkan No Pembelian ")
        Else
            Try
                strSql = "SELECT P.no_pembelian, P.tgl_beli, P.kd_suplier, S.nm_suplier, P.user_id, D.kd_brg, B.nm_brg,D.Hrg_beli, D.jumlah, D.sub_total FROM ((tb_pembelian P INNER JOIN tb_Suplier S ON P.kd_suplier = S.kd_suplier)" & _
                                                                                                             "INNER JOIN tb_pembelian_detail D ON P.no_pembelian = D.No_pembelian)" & _
                                                                                                             "INNER JOIN tb_barang B ON D.kd_brg = B.kd_brg " & _
                                                                                                             "WHERE P.no_pembelian = '" & TextBox1.Text & "'"

                mycon = New MySqlConnection(strCon)
                mycon.Open()
                objAdapter = New MySqlDataAdapter(strSql, mycon)

                Dim hsl_rpt As New Ds_pembelian
                objAdapter.Fill(hsl_rpt, "Ds_pembelian")

                RptDoc = New ReportDocument
                RptDoc.Load("D:\Portofolio\dedi\dedi\Laporan\Cr_pembelian.rpt")
                RptDoc.SetDataSource(hsl_rpt)
                CrystalReportViewer1.ReportSource = RptDoc
            Catch ex As Exception
                MsgBox("No Pembelian Tidak ada ")
            End Try
        End If

     End Sub
End Class