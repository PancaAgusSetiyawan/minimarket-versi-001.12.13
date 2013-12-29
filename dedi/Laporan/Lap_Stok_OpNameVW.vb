
Imports System.Data
Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Lap_Stok_OpNameVW

    Private RptDoc As ReportDocument

    Private Sub Lap_Stok_OpNameVW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            strSql = "SELECT B.kd_brg , B.nm_brg, H.Stok FROM tb_Barang B INNER JOIN TB_Harga H ON B.kd_brg = H.kd_brg " 'Order By ASC"
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            objAdapter = New MySqlDataAdapter(strSql, mycon)

            Dim hsl_report As New Ds_Stok
            objAdapter.Fill(hsl_report, "Ds_Stok")

            RptDoc = New ReportDocument
            RptDoc.Load("D:\Portofolio\dedi\dedi\Laporan\cr_Stok.rpt")
            RptDoc.SetDataSource(hsl_report)
            CrystalReportViewer1.ReportSource = RptDoc
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub
End Class