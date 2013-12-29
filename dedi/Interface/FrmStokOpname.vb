
Imports MySql.Data.MySqlClient

Public Class FrmStokOpname

    Private objHarga As clsHarga

    Private Sub setGrid()
        grdOpname1.Columns(3).DefaultCellStyle.Format = "#,###"
        grdOpname1.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdOpname1.Columns(5).DefaultCellStyle.Format = "#,###"
        grdOpname1.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdOpname1.Columns(7).DefaultCellStyle.Format = "#,###"
        grdOpname1.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdOpname1.Columns(9).DefaultCellStyle.Format = "#,###"
        grdOpname1.Columns(9).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub LoadData()
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "select B.kd_brg, B.nm_brg, B.satuan, H.hrg_jual_satuan, H.stok FROM Tb_barang B INNER JOIN Tb_Harga H On B.kd_brg = H.Kd_brg"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub loadData2()
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select B.kd_brg, B.nm_brg, B.satuan, H.hrg_jual_satuan, H.stok FROM Tb_barang B INNER JOIN Tb_Harga H On B.kd_brg = H.Kd_brg"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            For i As Integer = 0 To objDataTable.Rows.Count - 1
                If objReader.HasRows Then
                    objReader.Read()
                    grdOpname1.Rows.Insert(0, New String() {objReader(0), objReader(1), objReader(2), objReader(3), objReader(4)})
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objCommand.Dispose()
            objCommand = Nothing
        End Try
    End Sub

    Private Sub HitungTotal()
        'menghitung total selsisih
        For i As Integer = 0 To grdOpname1.Rows.Count - 1
            Dim TotalSelisihStok As Integer
            Dim TotalSelisihHarga As Integer

            TotalSelisihHarga = TotalSelisihHarga + grdOpname1.Rows(i).Cells(9).Value
            lblTtlHarga.Text = Format(TotalSelisihHarga, "#,##0.00")

            TotalSelisihStok = TotalSelisihStok + grdOpname1.Rows(i).Cells(8).Value
            lblTtlStok.Text = TotalSelisihStok
        Next
    End Sub

    Private Sub HitungGrid()
        Dim intHarga As Integer = grdOpname1.SelectedCells(3).Value
        Dim intStokKomp As Integer = grdOpname1.SelectedCells(4).Value
        Dim intTtl_hrg_komp As Integer = grdOpname1.SelectedCells(5).Value '?
        Dim intStokFisik As Integer = grdOpname1.SelectedCells(6).Value
        Dim intTtl_hrg_fisik As Integer = grdOpname1.SelectedCells(7).Value '?
        Dim intSelisihStok As Integer = grdOpname1.SelectedCells(8).Value '?
        Dim intSelisihHrg As Integer = grdOpname1.SelectedCells(9).Value '?

        ' menghitung total harga dlm stok komputr
        intTtl_hrg_komp = intHarga * intStokKomp
        grdOpname1.SelectedCells(5).Value = intTtl_hrg_komp

        'menghitung  total harga fisik
        intTtl_hrg_fisik = intHarga * intStokFisik
        grdOpname1.SelectedCells(7).Value = intTtl_hrg_fisik

        'menghitung selisih stok
        intSelisihStok = intStokFisik - Math.Abs(intStokKomp)
        grdOpname1.SelectedCells(8).Value = intSelisihStok

        'menghitung selisih harga 
        intSelisihHrg = intSelisihStok * intHarga
        grdOpname1.SelectedCells(9).Value = intSelisihHrg
    End Sub

    Private Sub UpdateStok()
        For i As Integer = 0 To grdOpname1.Rows.Count - 1
            objHarga = New clsHarga
            With objHarga
                .kd_brg = grdOpname1.Rows(i).Cells(0).Value
                .Stok = grdOpname1.Rows(i).Cells(6).Value
                If .isUpdateStok() Then
                    'Exit For

                Else
                    'MsgBox("Gagal Menyesuaikan data")
                End If
            End With
        Next
        MsgBox("Data Sudah diSesuaikan")
    End Sub

    Private Sub FrmStokOpname_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadData()
        Call loadData2()
        Call setGrid()
    End Sub

    Private Sub grdOpname1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdOpname1.CellClick
        Call setGrid()
        Call HitungGrid()
        Call HitungTotal()
    End Sub

    Private Sub grdOpname1_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdOpname1.CellEndEdit
        Call HitungGrid()
        Call HitungTotal()
    End Sub

    Private Sub btnSesauikan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSesauikan.Click
        For i As Integer = 0 To grdOpname1.Rows.Count - 1
            Dim stokFisik As Integer = grdOpname1.Rows(i).Cells(6).Value
            If stokFisik = 0 Then
                MsgBox("Anda Belum mesaukkan Stok fisik")
            Else
                Dim pesan As String
                pesan = MsgBox("Data-data akan disesuaikan sesuai keadaan saat ini dan tidak dapat di kembalikan lagi, Anda Yakin Akan Menyesuaikan Data?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "WARNING")
                If pesan = vbYes Then
                    Call UpdateStok()
                End If
            End If
        Next
    End Sub

    'Private Sub grdOpname1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles grdOpname1.KeyPress
    '    If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(Asc(".")) Then
    '        e.Handled = True
    '    End If
    'End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Lap_Stok_OpNameVW.Show()
    End Sub
End Class