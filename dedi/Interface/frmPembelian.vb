Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmPembelian
    Private objBarang As clsBarang
    Private objSuplier As clsSuplier
    Private objPembelian As clsPemblian
    Private objHarga As clsHarga
    '    Private BarisEdit As Integer = 0

    Private Sub kosong()
        txtHrg_Jual.Text = CInt(0)
        txtHrg_Beli.Text = CInt(0)
        txtJumlah.Text = CInt(0)
        txtKd_barang.Text = ""
        'txtKd_Suplier.Text = ""
        'txtAlamat.Text = ""
        txtNm_barang.Text = ""
        'txtNm_Siplier.Text = ""
        'txtNo_pembelian.Text = ""
        txtSatuan.Text = ""
    End Sub

    Private Sub AllKosong()
        txtHrg_Jual.Text = 0
        txtHrg_Beli.Text = 0
        txtJumlah.Text = 0
        txtKd_barang.Text = ""
        txtKd_Suplier.Text = ""
        txtAlamat.Text = ""
        txtNm_barang.Text = ""
        txtNm_Siplier.Text = ""
        'txtNo_pembelian.Text = ""
        txtSatuan.Text = ""
        txtTotal_beli.Text = ""
        txttotal_jual.Text = ""
        txtTotalItem.Text = ""
        txtTotalSelisih.Text = ""
        txtGrandtotal.Text = ""
        For i As Integer = 0 To lvPembelian.Items.Count - 1
            lvPembelian.Items.Clear()
        Next
    End Sub

    Function autoPembelian() As String
        Try ' auto number pada no_pembelian
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "select right(no_pembelian,4) as no_pembelian FROM tb_pembelian WHERE year(left(no_pembelian,8))+month(left(no_pembelian,8))=Year(now())+month(now()) order by right(no_pembelian,4) desc"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                objReader.Read()
                Return Format(Now.Date, "yyyyMMdd") + "-" + Mid("0000", 1, 4 - (Val(Trim(objReader.Item(0)).ToString) + 1).ToString.Length) + (Val(Trim(objReader.Item(0).ToString) + 1).ToString)
            Else
                Return Format(Now.Date, "yyyyMMdd") + "-0001"
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Return Nothing
    End Function

    Private Sub InsertListview()
        If lvPembelian.Items.Count = 0 Then
            Dim ARR(6) As String
            ARR(0) = txtKd_barang.Text
            ARR(1) = txtNm_barang.Text
            ARR(2) = txtSatuan.Text
            ARR(3) = txtJumlah.Text
            ARR(4) = txtHrg_Beli_Satuan.Text
            ARR(5) = txtHrg_Jual_satauan.Text
            ARR(6) = CInt(txtJumlah.Text) * CInt(txtHrg_Beli_Satuan.Text)
            '' memyimpan data ke dalam listview
            Dim ListItem As ListViewItem
            ListItem = New ListViewItem
            ListItem = lvPembelian.Items.Add(ARR(0))
            ListItem.SubItems.Add(ARR(1))
            ListItem.SubItems.Add(ARR(2))
            ListItem.SubItems.Add(ARR(3))
            ListItem.SubItems.Add(ARR(4))
            ListItem.SubItems.Add(ARR(5))
            ListItem.SubItems.Add(ARR(6))
        Else
            Dim result As Boolean = False
            Dim itemindex As Integer
            For Each item As ListViewItem In lvPembelian.Items
                If item.Text = txtKd_barang.Text Then
                    result = True
                    itemindex = item.Index
                    Exit For
                End If
            Next
            If result = True Then
                Dim ARR(6) As String
                ARR(0) = txtKd_barang.Text
                ARR(1) = txtNm_barang.Text
                ARR(2) = txtSatuan.Text
                ARR(3) = txtJumlah.Text
                ARR(4) = txtHrg_Beli_Satuan.Text
                ARR(5) = txtHrg_Jual_satauan.Text
                ARR(6) = CInt(txtJumlah.Text) * CInt(txtHrg_Beli_Satuan.Text)
                lvPembelian.Items(itemindex).SubItems(3).Text = (CDbl(lvPembelian.Items(itemindex).SubItems(3).Text) + CDbl(ARR(3))).ToString
                lvPembelian.Items(itemindex).SubItems(6).Text = (CDbl(lvPembelian.Items(itemindex).SubItems(3).Text) * CDbl(ARR(4))).ToString
            Else
                Dim ARR(6) As String
                ARR(0) = txtKd_barang.Text
                ARR(1) = txtNm_barang.Text
                ARR(2) = txtSatuan.Text
                ARR(3) = txtJumlah.Text
                ARR(4) = txtHrg_Beli_Satuan.Text
                ARR(5) = txtHrg_Jual_satauan.Text
                ARR(6) = CInt(txtJumlah.Text) * CInt(txtHrg_Beli_Satuan.Text)
                '' memyimpan data ke dalam listview
                Dim ListItem As ListViewItem
                ListItem = lvPembelian.Items.Add(ARR(0))
                ListItem.SubItems.Add(ARR(1))
                ListItem.SubItems.Add(ARR(2))
                ListItem.SubItems.Add(ARR(3))
                ListItem.SubItems.Add(ARR(4))
                ListItem.SubItems.Add(ARR(5))
                ListItem.SubItems.Add(ARR(6))
            End If
        End If
        'menghitung total
        Dim totalItem As Integer
        Dim totalBeli As Integer
        Dim totalJual As Integer
        Dim totalSub As Integer
        For i As Integer = 0 To lvPembelian.Items.Count - 1
            totalItem = totalItem + lvPembelian.Items(i).SubItems(3).Text
            totalBeli = totalBeli + lvPembelian.Items(i).SubItems(4).Text
            totalJual = totalJual + lvPembelian.Items(i).SubItems(5).Text
            totalSub = totalSub + lvPembelian.Items(i).SubItems(6).Text
        Next
        txtTotal_beli.Text = totalBeli
        txttotal_jual.Text = totalJual
        txtTotalItem.Text = totalItem
        txtGrandtotal.Text = totalSub
        txtTotalSelisih.Text = totalJual - totalBeli
    End Sub

    Private Sub UpdateList()
        Dim result As Boolean = False
        Dim itemindex As Integer
        For Each item As ListViewItem In lvPembelian.Items
            If item.Text = txtKd_barang.Text Then
                result = True
                itemindex = item.Index
                Exit For
            End If
        Next
        Dim ARR(6) As String
        ARR(0) = txtKd_barang.Text
        ARR(1) = txtNm_barang.Text
        ARR(2) = txtSatuan.Text
        ARR(3) = txtJumlah.Text
        ARR(4) = txtHrg_Beli_Satuan.Text
        ARR(5) = txtHrg_Jual_satauan.Text
        ARR(6) = CInt(txtJumlah.Text) * CInt(txtHrg_Beli_Satuan.Text)
        lvPembelian.Items(itemindex).SubItems(3).Text = ARR(3) 'CDbl(lvPembelian.Items(itemindex).SubItems(3).Text) ' + CDbl(ARR(3))).ToString
        lvPembelian.Items(itemindex).SubItems(4).Text = ARR(4)
        lvPembelian.Items(itemindex).SubItems(5).Text = ARR(5)
        lvPembelian.Items(itemindex).SubItems(6).Text = (CDbl(lvPembelian.Items(itemindex).SubItems(3).Text) * CDbl(ARR(4))).ToString

        'menghitung total
        Dim totalItem As Integer
        Dim totalBeli As Integer
        Dim totalJual As Integer
        Dim totalSub As Integer
        For i As Integer = 0 To lvPembelian.Items.Count - 1
            totalItem = totalItem + lvPembelian.Items(i).SubItems(3).Text
            totalBeli = totalBeli + lvPembelian.Items(i).SubItems(4).Text
            totalJual = totalJual + lvPembelian.Items(i).SubItems(5).Text
            totalSub = totalSub + lvPembelian.Items(i).SubItems(6).Text
        Next
        txtTotal_beli.Text = totalBeli
        txttotal_jual.Text = totalJual
        txtTotalItem.Text = totalItem
        txtGrandtotal.Text = totalSub
        txtTotalSelisih.Text = totalJual - totalBeli
    End Sub

    Private Sub UpdateStok() 'update harga dan stok
        'mencari stok awal
        Dim stokAwal As Integer
        For i As Integer = 0 To lvPembelian.Items.Count - 1
            objHarga = New clsHarga
            objHarga.kd_brg = lvPembelian.Items(i).SubItems(0).Text
            objReader = objHarga.getDataStok
            If objReader.HasRows Then
                objReader.Read()
                stokAwal = objReader(0)
                '                MsgBox("" + CStr(stokAwal))
            End If
        Next
        'update stok setelah stok awal d jumlah dengan pembelian (stok/jumlah beli)
        For i As Integer = 0 To lvPembelian.Items.Count - 1
            objHarga = New clsHarga
            With objHarga
                .kd_brg = lvPembelian.Items(i).SubItems(0).Text
                .Stok = CDbl(lvPembelian.Items(i).SubItems(3).Text) + CDbl(stokAwal)
                .hrg_beli_satuan = lvPembelian.Items(i).SubItems(4).Text
                .hrg_jual_satuan = lvPembelian.Items(i).SubItems(5).Text
                If .isExist Then
                    .isUpdateHarga()
                Else
                    .isSave()
                End If
            End With
        Next
    End Sub

    Private Sub frmPembelian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kosong()
        txtNo_pembelian.Text = autoPembelian()
        txtUserId.Text = UserId_LogIn
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtKd_Suplier.Text = "" Or lvPembelian.Items.Count = 0 Then
            MsgBox("Masukkan Data Pembelian")
        Else
            objPembelian = New clsPemblian
            With objPembelian
                .no_pembelian = txtNo_pembelian.Text
                .tanggal = Now.Date
                .kd_suplier = txtKd_Suplier.Text
                .UserId = txtUserId.Text
                If .isSavePembelian() Then
                    ' MsgBox("save 1 OK")
                    objPembelian = New clsPemblian
                    With objPembelian
                        For i As Integer = 0 To lvPembelian.Items.Count - 1
                            .no_pembelian = txtNo_pembelian.Text
                            .kd_brg = lvPembelian.Items(i).SubItems(0).Text
                            .jumlah = lvPembelian.Items(i).SubItems(3).Text
                            .hrg_beli = lvPembelian.Items(i).SubItems(4).Text
                            .subTotal = lvPembelian.Items(i).SubItems(6).Text
                            .isSavePembelianDetail()
                        Next
                        Call UpdateStok()
                    End With
                    MsgBox("Sukses")
                    Call AllKosong()
                Else
                    MsgBox("Gagal")
                End If
            End With
            txtNo_pembelian.Text = autoPembelian()
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtKd_barang.Text = "" Or txtKd_barang.ReadOnly = False Then
            MsgBox("Pilih yang mau di edit ... ! ")
        Else
            Call UpdateList()
            Call kosong()
            txtHrg_Beli_Satuan.ReadOnly = True
            txtHrg_Jual_satauan.ReadOnly = True
            txtKd_barang.ReadOnly = False
            btnSave.Enabled = True
        End If
        btnCariBarang.Enabled = True
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If lvPembelian.SelectedItems.Count > 0 AndAlso MessageBox.Show("Yakin Akan Menghapus data ini...?", "Confirm", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            lvPembelian.SelectedItems(0).Remove()
            Call kosong()
        End If
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call kosong()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim pesan As String
        pesan = MsgBox("Keluar Form ?, Data Yang belum disimpan akan Hilang...!?", MsgBoxStyle.YesNo + MsgBoxStyle.MsgBoxSetForeground, "Warning")
        If pesan = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtCariSuplier_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariSuplier.Click
        FrmCariSuplier.Show()
    End Sub

    Private Sub btnCariBarang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCariBarang.Click
        FrmCariBarang.Show()
    End Sub

    Private Sub txtKd_Suplier_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKd_Suplier.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Try ' mencari data suplier
                objSuplier = New clsSuplier
                objSuplier.kd_suplier = txtKd_Suplier.Text
                objReader = objSuplier.getAutoSuplier
                If objReader.HasRows Then
                    objReader.Read()
                    txtNm_Siplier.Text = objReader("nm_suplier")
                    txtAlamat.Text = objReader("alamat")
                    txtKd_barang.Focus()
                Else
                    objReader.Read()
                    txtNm_Siplier.Text = ""
                    txtAlamat.Text = ""
                    txtKd_Suplier.Text = ""
                    MsgBox("Data Tidak Ada ")
                    txtKd_Suplier.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub txtKd_barang_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKd_barang.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Try ' mencari data barang
                objBarang = New clsBarang
                objBarang.kd_brg = txtKd_barang.Text
                objReader = objBarang.getAutoBrg
                If objReader.HasRows Then
                    objReader.Read()
                    txtNm_barang.Text = objReader("nm_brg")
                    txtSatuan.Text = objReader("satuan")
                    txtJumlah.Focus()
                Else
                    objReader.Read()
                    txtKd_barang.Text = ""
                    txtNm_barang.Text = ""
                    txtSatuan.Text = ""
                    MsgBox("Data Tidak Ada")
                    txtKd_barang.Focus()
                End If
                objReader.Close()
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End If
    End Sub

    Private Sub txtHrg_Beli_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHrg_Beli.TextChanged
        If txtHrg_Beli.Text = "" Then
            txtHrg_Beli.Text = 0
        End If
        Dim hrg_beli As Decimal = txtHrg_Beli.Text
        Dim hrg_satuan_beli As Decimal
        If txtSatuan.Text = "PCS" Then
            hrg_satuan_beli = hrg_beli / 1
        ElseIf txtSatuan.Text = "Lusin" Then
            hrg_satuan_beli = hrg_beli / 12
        Else
            txtHrg_Beli_Satuan.Text = 0
        End If
        txtHrg_Beli_Satuan.Text = hrg_satuan_beli ' Format(hrg_satuan_beli, "#,##0.00")
    End Sub

    Private Sub txtHrg_Jual_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHrg_Jual.TextChanged
        If txtHrg_Jual.Text = "" Then
            txtHrg_Jual.Text = 0
        End If
        Dim hrg_jual As Decimal = txtHrg_Jual.Text
        Dim hrg_jual_satuan As Decimal

        If txtSatuan.Text = "PCS" Then
            hrg_jual_satuan = hrg_jual / 1
        ElseIf txtSatuan.Text = "Lusin" Then
            hrg_jual_satuan = hrg_jual / 12
        Else
            txtHrg_Jual_satauan.Text = hrg_jual_satuan 'Format(hrg_jual_satuan, "#,##0.00")
        End If
        txtHrg_Jual_satauan.Text = hrg_jual_satuan ' Format(hrg_jual_satuan, "#,##0.00")
    End Sub

    Private Sub txtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJumlah.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(Asc(".")) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            txtHrg_Beli.Focus()
        End If
    End Sub

    Private Sub txtHrg_Beli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHrg_Beli.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(Asc(".")) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            txtHrg_Jual.Focus()
        End If
    End Sub

    Private Sub txtHrg_Jual_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtHrg_Jual.KeyPress
        If (e.KeyChar < Chr(48) Or e.KeyChar > Chr(57)) And e.KeyChar <> Chr(8) And e.KeyChar <> Chr(Asc(".")) Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            Call InsertListview()
            Call kosong()
            txtKd_barang.Focus()
        End If
    End Sub

    Private Sub lvPembelian_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvPembelian.SelectedIndexChanged
        ' pilih data unt d tampilkan d textbox
        If lvPembelian.SelectedItems.Count > 0 Then
            txtKd_barang.Text = lvPembelian.SelectedItems(0).Text
            txtNm_barang.Text = lvPembelian.SelectedItems(0).SubItems(1).Text
            txtSatuan.Text = lvPembelian.SelectedItems(0).SubItems(2).Text
            txtJumlah.Text = lvPembelian.SelectedItems(0).SubItems(3).Text
            txtHrg_Beli_Satuan.Text = lvPembelian.SelectedItems(0).SubItems(4).Text
            txtHrg_Jual_satauan.Text = lvPembelian.SelectedItems(0).SubItems(5).Text

            txtHrg_Beli_Satuan.ReadOnly = False
            txtHrg_Jual_satauan.ReadOnly = False
            txtKd_barang.ReadOnly = True
            btnSave.Enabled = False

            Dim hrg_jual_satuan As Integer = txtHrg_Jual_satauan.Text
            Dim hrg As Integer
            If txtSatuan.Text = "PCS" Then
                hrg = hrg_jual_satuan * 1
                txtHrg_Jual.Text = hrg
            ElseIf txtSatuan.Text = "Lusin" Then
                hrg = hrg_jual_satuan * 12
                txtHrg_Jual.Text = hrg
            Else
                txtHrg_Jual.Text = hrg
            End If


            Dim hrg_Beli_satuan As Integer = txtHrg_Beli_Satuan.Text
            Dim hrg1 As Integer
            If txtSatuan.Text = "PCS" Then
                hrg1 = hrg_Beli_satuan * 1
                txtHrg_Beli.Text = hrg1
            ElseIf txtSatuan.Text = "Lusin" Then
                hrg1 = hrg_Beli_satuan * 12
                txtHrg_Beli.Text = hrg1
            Else
                txtHrg_Beli.Text = hrg1
            End If

        End If
        btnCariBarang.Enabled = False
    End Sub

    Private Sub txtHrg_Jual_satauan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHrg_Jual_satauan.TextChanged
        'Dim beli As Integer = CInt(txtHrg_Beli_Satuan.Text)
        'Dim jual As Integer = CInt(txtHrg_Jual_satauan.Text)
        'Dim persen As Integer
        'persen = ((jual - beli) / beli) * 100
        'txtPersen.Text = persen
    End Sub
End Class