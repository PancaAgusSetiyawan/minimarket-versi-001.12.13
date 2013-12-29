
Imports MySql.Data.MySqlClient

Public Class FrmCariPenjualan

    Private objPenjualan As clsPenjualan

    Private Sub loadTgl()
        objPenjualan = New clsPenjualan
        objPenjualan.Tgl_Jual = dtPiker.Value
        grdCaripenjualan.DataSource = objPenjualan.getDataByTanggal
    End Sub

    Private Sub loadNo()
        objPenjualan = New clsPenjualan
        objPenjualan.No_Penjualan = txtCari.Text
        grdCaripenjualan.DataSource = objPenjualan.getDataByNo
    End Sub

    Private Sub pilih()
        If RdNoTransaksi.Checked = True Then
            Call loadNo()
        ElseIf Rdtanggal.Checked = True Then
            Call loadTgl()
        Else
            grdCaripenjualan = Nothing
        End If
    End Sub

    Private Sub FrmCariPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class