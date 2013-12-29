Imports System
Imports MySql.Data.MySqlClient

Public Class POS

    Private objBarang As clsBarang
    Private objHarga As clsHarga
    Private objPenjualan As clsPenjualan

    Private intObjStok As Integer 'deklarasi hasil pencarian kdbrg & stok  pada datagridview
    Private strKd_brgCellKlik As Integer 'deklarasi hasil unt pencarian kode pada grd saat d klik
    Private intStokCellKlik As Integer 'deklarasi hasil unt pencarian kode pada grd saat d klik

    Private Sub listGrid()
        'objPOSsementara = New cls_Pos_sementara
        'grdPos.DataSource = objPOSsementara.getData
        grdPos.Columns(0).Width = 250
        grdPos.Columns(1).Width = 410
        grdPos.Columns(2).Width = 100
        grdPos.Columns(3).Width = 200
        grdPos.Columns(4).Width = 90
        'grdPos.Columns(5).Width = 250
        'grdPos.Columns(6).Width = 80
    End Sub

    Private Sub AllKosong()
        txtKd_brg.Text = ""
        '        txtTotalBesar.Text = Format(txtTotalBesar.Text, "#,##0.00")
        txtTotalKotor.Text = "0"
        txtKembali.Text = "0"
        txtTotalDiskon.Text = "0"
        txtTotalKotor.Text = "0"
        txtBayar.Text = CDbl(0)
        Call DeleteTabel()
    End Sub

    Private Sub Batal()
        For i As Integer = 0 To grdPos.Rows.Count - 1
            grdPos.Rows.RemoveAt(i)
        Next
    End Sub

    Function autoPenjualan() As String
        Try ' auto number pada no_pembelian
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            'strSql = "SELECT RIGHT(Id_RstTgl,3) AS Id_RstTgl FROM Tb_Auto WHERE YEAR(LEFT(Id_RstTgl,8))+MONTH(LEFT(Id_RstTgl,8))+DAY(LEFT(Id_RstTgl,8))=YEAR(GETDATE())+MONTH(GETDATE())+DAY(GETDATE()) ORDER BY RIGHT(Id_RstTgl,3) DESC"

            strSql = "select right(no_penjualan,4) as no_pembelian FROM tb_penjualan WHERE year(left(no_penjualan,8))+month(left(no_penjualan,8))+DAY(LEFT(no_penjualan,8))=Year(now())+month(now())+Day(now()) order by right(no_penjualan,4) desc"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                objReader.Read()
                Return Format(Now.Date, "yyyyMMdd") + Mid("0000", 1, 4 - (Val(Trim(objReader.Item(0)).ToString) + 1).ToString.Length) + (Val(Trim(objReader.Item(0).ToString) + 1).ToString)
            Else
                Return Format(Now.Date, "yyyyMMdd") + "0001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return Nothing
    End Function

    Private Sub DeleteTabel() ' menghapus tabel dgview tanpa dtabase
        For i As Integer = 0 To grdPos.Rows.Count - 2
            grdPos.Rows.Clear()
        Next
    End Sub

    Private Sub getDataBrg() ' memasukkan data ke dalam datagridview stelah pencarian brg
        Dim kd_brg As String
        Dim nm_brg As String
        ' Dim stok As Integer
        Dim harga As Integer
        Dim diskon As Integer

        If grdPos.Rows.Count - 1 = 0 Then ' cek grdview kosong
            objBarang = New clsBarang
            objBarang.kd_brg = txtKd_brg.Text
            objReader = objBarang.getAutoBrg
            If objReader.HasRows Then
                objReader.Read()
                kd_brg = objReader(0)
                nm_brg = objReader(1)

                objHarga = New clsHarga
                objHarga.kd_brg = txtKd_brg.Text
                objReader = objHarga.getDataPOS
                If objReader.HasRows Then
                    objReader.Read()
                    harga = objReader(0)
                    diskon = objReader(1)
                    'memasukkan data ke dlm grdview 
                    grdPos.Rows.Insert(0, New String() {kd_brg, nm_brg, Format(harga, "#,##"), CInt(1), diskon})
                    Call HitungTotal() ' menghitung jumlah kali harga 
                    Call HitungTotalKotor() ' mengitung total kotor
                    txtKd_brg.Focus()
                End If
            Else
                MsgBox("Data Tidak Ada")
                txtKd_brg.Text = ""
                txtKd_brg.Focus()
            End If
        Else 'mencari kd_brg yang sama
            Dim ketemu As Boolean
            Dim ItemIndx As Integer
            For ind As Integer = 0 To grdPos.RowCount - 2
                If ketemu = False And grdPos.Item(0, ind).Value = txtKd_brg.Text Then
                    ketemu = True
                    ItemIndx = ind
                    Exit For
                End If
            Next ' jika ketemu maka update jumlahnya
            If ketemu = True Then
                objBarang = New clsBarang
                objBarang.kd_brg = txtKd_brg.Text
                objReader = objBarang.getAutoBrg
                If objReader.HasRows Then
                    objReader.Read()
                    kd_brg = objReader(0)
                    nm_brg = objReader(1)
                    objHarga = New clsHarga
                    objHarga.kd_brg = txtKd_brg.Text
                    objReader = objHarga.getDataPOS
                    If objReader.HasRows Then
                        objReader.Read()
                        harga = objReader(0)
                        diskon = objReader(1)

                        grdPos.Item(0, ItemIndx).Value = kd_brg
                        grdPos.Item(1, ItemIndx).Value = nm_brg
                        grdPos.Item(2, ItemIndx).Value = Format(harga, "#,##")
                        grdPos.Item(3, ItemIndx).Value = grdPos.Item(3, ItemIndx).Value + CInt(1)
                        grdPos.Item(4, ItemIndx).Value = diskon
                        Call HitungTotal() ' menghitung jumlah kali harga 
                        Call HitungTotalKotor() ' mengitung total kotor
                    Else
                        MsgBox("Gagal Menambah Item")
                    End If
                    txtKd_brg.Focus()
                End If
            Else ' cek jika tidak kosong 
                objBarang = New clsBarang
                objBarang.kd_brg = txtKd_brg.Text
                objReader = objBarang.getAutoBrg
                If objReader.HasRows Then
                    objReader.Read()
                    kd_brg = objReader(0)
                    nm_brg = objReader(1)
                    'pencarian data pos
                    objHarga = New clsHarga
                    objHarga.kd_brg = txtKd_brg.Text
                    objReader = objHarga.getDataPOS
                    If objReader.HasRows Then
                        objReader.Read()
                        harga = objReader(0)
                        diskon = objReader(1)
                        grdPos.Rows.Insert(0, New String() {kd_brg, nm_brg, Format(harga, "#,##"), CInt(1), diskon})
                        Call HitungTotal() ' menghitung jumlah kali harga 
                        Call HitungTotalKotor() ' mengitung total kotor
                        txtKd_brg.Focus()
                    End If
                Else
                    MsgBox("Data Tidak Ada")
                    txtKd_brg.Text = ""
                    txtKd_brg.Focus()
                End If
                Call HitungTotal() ' menghitung jumlah kali harga 
            End If
        End If
    End Sub

    'Private Sub getStokBrg() 'update stok barang pd tb_harga
    '    'pencaraian stok
    '    objHarga = New clsHarga
    '    objHarga.kd_brg = txtKd_brg.Text
    '    objReader = objHarga.getDataStok
    '    If objReader.HasRows Then
    '        objReader.Read()
    '        intObjStok = objReader(0)
    '        If intObjStok < 1 Then
    '            MsgBox("Stok Habis")
    '        Else
    '            'updtate stok
    '            objHarga = New clsHarga
    '            With objHarga
    '                .kd_brg = txtKd_brg.Text
    '                .Stok = CInt(intObjStok) - CInt("1")
    '                'MsgBox("" + CStr(intObjStok)) '+ CStr(.Stok))
    '                .isUpdateStok()
    '                Call getDataBrg()
    '                'If .isUpdateStok Then
    '                '    MsgBox("sukses update")
    '                'Else
    '                '    MsgBox("update gagal")
    '                'End If
    '            End With
    '        End If
    '    End If
    '    intObjStok = Nothing
    'End Sub

    Private Sub UpdateStok()
        'pencaraian stok
        For i As Integer = 0 To grdPos.Rows.Count - 1
            objHarga = New clsHarga
            objHarga.kd_brg = grdPos.Rows(i).Cells(0).Value
            objReader = objHarga.getDataStok

            If objReader.HasRows Then
                objReader.Read()
                intObjStok = objReader(0)

                objHarga = New clsHarga
                With objHarga
                    .kd_brg = grdPos.Rows(i).Cells(0).Value
                    .Stok = Val(CInt(intObjStok)) - (Val(CInt(grdPos.Rows(i).Cells(3).Value)))
                    .isUpdateStok() ' update stok setealah d kurangi
                    'If .isUpdateStok Then
                    '    MsgBox("sukses update")
                    'Else
                    '    MsgBox("update gagal")
                    'End If
                End With
            End If
            intObjStok = Nothing
        Next
    End Sub

    Private Sub HitungTotal() ' menghitung jumlah kali harga dibagi diskon pada dgview
        For i As Integer = 0 To grdPos.Rows.Count - 2
            Dim hrg As Integer = CInt(grdPos.Rows(i).Cells(2).Value)
            Dim jml As Integer = CInt(grdPos.Rows(i).Cells(3).Value)
            Dim dis As Integer = CInt(grdPos.Rows(i).Cells(4).Value)
            Dim subTotal As Integer = CInt(grdPos.Rows(i).Cells(5).Value)
            Dim rpDis As Integer
            grdPos.Rows(i).Cells(6).Value = hrg 'Format(hrg * jml, "#,###")

            rpDis = grdPos.Rows(i).Cells(6).Value * (grdPos.Rows(i).Cells(4).Value / 100)
            grdPos.Rows(i).Cells(5).Value = rpDis
        Next
    End Sub

    Private Sub HitungTotalKotor()

        Dim totalKotor As Integer
        Dim totalDiskon As Integer
        'menghitung total
        For i As Integer = 0 To grdPos.Rows.Count - 1

            totalKotor = totalKotor + grdPos.Rows(i).Cells(6).Value
            totalDiskon = totalDiskon + grdPos.Rows(i).Cells(5).Value

            txtTotalKotor.Text = totalKotor 'Format(totalKotor, "Rp #,##")
            txtTotalDiskon.Text = totalDiskon 'Format(totalDiskon, "Rp #,##0")
            lblBesar.Text = Format(totalKotor, "Rp #,##0.00")
        Next
    End Sub

    Private Sub SavePenjualan()
        objPenjualan = New clsPenjualan
        With objPenjualan
            .No_Penjualan = lblNo.Text
            .Tgl_Jual = Format(Now.Date, "yyyy-MM-dd")
            .UserId = lblKasir.Text
            .isSavePenjualan()

            For i As Integer = 0 To grdPos.RowCount - 2
                objPenjualan = New clsPenjualan
                With objPenjualan
                    .No_Penjualan = lblNo.Text
                    .kd_brg = grdPos.Rows(i).Cells(0).Value
                    .Hrg_jual_satuan = grdPos.Rows(i).Cells(2).Value
                    .Jumlah = grdPos.Rows(i).Cells(3).Value
                    .Diskon = grdPos.Rows(i).Cells(4).Value
                    .Sub_Total = CDbl(grdPos.Rows(i).Cells(6).Value) - CDbl(grdPos.Rows(i).Cells(5).Value)
                    .isSavePenjualanDetail()
                End With
            Next
        End With
    End Sub

    Private Sub POS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.F2 Then
            Call DeleteTabel()
        End If
    End Sub

    'Private Sub HitungDiskon()
    '    Dim RpDiskon As Integer
    '    Dim Diskon As Integer = grdPos.Rows(grdPos.RowCount - 2).Cells(4).Value
    '    Dim subTotal As Integer = grdPos.Rows(grdPos.RowCount - 2).Cells(6).Value

    '    RpDiskon = Val(grdPos.Rows(grdPos.RowCount - 2).Cells(6).Value) * Diskon / 100
    '    grdPos.Rows(grdPos.RowCount - 2).Cells(5).Value = RpDiskon
    'End Sub


    Private Sub POS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBayar.ReadOnly = True
        txtKd_brg.Focus()
        Call AllKosong()
        lblKasir.Text = UserId_LogIn
        lblNo.Text = autoPenjualan()
    End Sub

    'Private Sub grdPos_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPos.CellClick
    '    strKd_brgCellKlik = grdPos.SelectedCells(0).Value
    '    intStokCellKlik = grdPos.SelectedCells(3).Value
    '    MsgBox("" + CStr(intStokCellKlik) + CStr(strKd_brgCellKlik))
    'End Sub

    Private Sub grdPos_CellEndEdit1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPos.CellEndEdit
        Call HitungTotal() ' menghitung jumlah kali harga 
        Call HitungTotalKotor() ' mengitung total kotor
    End Sub

    Private Sub txtKd_brg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKd_brg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call getDataBrg()
            'Call getStokBrg()
            txtKd_brg.Text = ""
        ElseIf Asc(e.KeyChar) = Keys.Space Then
            txtBayar.ReadOnly = False
            txtBayar.Focus()
        End If
    End Sub

    Private Sub txtBayar_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBayar.KeyPress
        If Not IsNumeric(txtBayar.Text) Then
            txtBayar.Text = "0"
        Else
            Dim totalBersih As Double
            Dim kembali As Double
            Dim bayar As Double = txtBayar.Text
            Dim totKotor As Double = txtTotalKotor.Text
            Dim totDiskon As Double = txtTotalDiskon.Text

            If txtBayar.Text = "" Then
                txtBayar.Text = CInt(0)
            End If ' menghitung pembayaran
            txtBayar.Text = Format(bayar, "#,###") 'menjadikan format corrency
            txtBayar.SelectionStart = Len(txtBayar.Text)


            totalBersih = totKotor - totDiskon
            kembali = bayar - totalBersih

            lblBesar.Text = Format(totalBersih, "Rp #,##0.00")

            If Asc(e.KeyChar) = Keys.Enter Then
                If bayar < totalBersih Then
                    MsgBox("Maaf, Uang Bayar Kurang...!")
                ElseIf totalBersih = 0 Then
                    MsgBox("Maaf, Masukkan dulu barag yang dibeli ")
                Else
                    lblBesar.Text = Format(kembali, "Rp #,##")
                    txtKembali.Text = Format(kembali, "Rp #,##")

                    Call SavePenjualan() 'menyimpan penjualan
                    Call UpdateStok() ' update stok setealah d kurangi
                    lblNo.Text = autoPenjualan()
                    Call DeleteTabel()
                    Call AllKosong()
                    txtBayar.ReadOnly = True
                    txtKd_brg.Focus()
                End If
            Else
                lblBesar.Text = Format(totalBersih, "Rp #,##0.00")
            End If
        End If
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        FrmTutupPos.Show()
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        FrmCariStok.Show()
    End Sub

    Private Sub txtKd_brg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKd_brg.LostFocus
        txtBayar.Focus()
    End Sub
End Class