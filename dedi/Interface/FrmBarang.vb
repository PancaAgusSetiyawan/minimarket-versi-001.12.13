Imports System.Data
Imports MySql.Data.MySqlClient

Public Class FrmBarang
    Private objBarang As clsBarang
    Private objJns_brg As clsJns_Brg

    Private Sub kosong()
        txtKd_jns.Text = ""
        txtKd_barang.Text = ""
        txtNm_brg.Text = ""
        txtMode.Text = ""
        txtWarna.Text = ""
        cboJns_Brg.SelectedIndex = -1
        cboSatuan.SelectedIndex = -1

        txtCariBrg.Text = ""
        txtCariJenis.Text = ""
        txtCariKode.Text = ""
    End Sub

    Private Sub aktf()
        ' txtKd_jns.ReadOnly = False
        txtNm_brg.ReadOnly = False
        txtMode.ReadOnly = False
        txtWarna.ReadOnly = False
    End Sub

    Private Sub nonaktif()
        txtKd_jns.ReadOnly = True
        txtNm_brg.ReadOnly = True
        txtMode.ReadOnly = True
        txtWarna.ReadOnly = True
    End Sub

    Private Sub listGrid()
        objBarang = New clsBarang
        grdBarang.DataSource = objBarang.getData
        grdBarang.Columns(0).Width = 150
        grdBarang.Columns(1).Width = 400
        grdBarang.Columns(2).Width = 150
        grdBarang.Columns(3).Width = 200
        grdBarang.Columns(4).Width = 150
        grdBarang.Columns(5).Width = 150

        ' Call djieChangeColorGrid(grdBarang)
        Call AutoNumberRowsForGridView()
    End Sub

    Private Sub AutoNumberRowsForGridView() ' membuat no otomatis pada datagridview
        If grdBarang IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (grdBarang.Rows.Count - 2))
                grdBarang.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")
                count += 1
            End While
        End If
    End Sub

    Private Sub setCombo()
        'mengisi(ccboJnsKend)
        objJns_brg = New clsJns_Brg
        objReader = objJns_brg.PopulateList
        If objReader.HasRows Then
            While objReader.Read
                cboJns_Brg.Items.Add(objReader(1))
            End While
        End If
    End Sub

    Private Sub FrmBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnDelete.Enabled = False
        btnEdit.Enabled = False
        '        Call djieChangeColorGrid(grdBarang)
        Call AutoNumberRowsForGridView()
        Call kosong()
        Call setCombo()
        Call listGrid()
        cboJns_Brg.Focus()
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtKd_jns.Text = "" Or txtNm_brg.Text = "" Or cboJns_Brg.Text = "" Or cboSatuan.Text = "" Then
            MsgBox("Data Harus Lengkap")
        Else
            objBarang = New clsBarang
            With objBarang
                .kd_brg = CStr(txtKd_jns.Text) + CStr(txtKd_barang.Text)
                .nm_brg = txtNm_brg.Text
                .Jenis = cboJns_Brg.Text
                .model = txtMode.Text
                .warna = txtWarna.Text
                .satuan = cboSatuan.Text
                If .isExist Then
                    MsgBox("Kode Sudah Ada ")
                Else
                    If .isSave Then
                        MsgBox("Data Tersimpan ")
                    Else
                        MsgBox("Gagal Menyimpan")
                    End If
                End If
            End With
            btnCancel.PerformClick()
        End If
    End Sub

    Private Sub btnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtKd_barang.Text = "" Or txtNm_brg.Text = "" Then
            MsgBox("Klik No urut data...!")
        Else
            If btnEdit.Text = "Edit" Then
                btnSave.Enabled = False
                btnEdit.Enabled = True
                btnDelete.Enabled = False
                btnCancel.Enabled = True
                btnClose.Enabled = False
                btnEdit.Text = "Update"
                Call aktf()
                txtKd_jns.ReadOnly = True
            Else
                objBarang = New clsBarang
                With objBarang
                    .kd_brg = txtKd_barang.Text
                    .nm_brg = txtNm_brg.Text
                    .Jenis = cboJns_Brg.Text
                    .warna = txtWarna.Text
                    .model = txtMode.Text
                    .satuan = cboSatuan.Text
                    If .isUpdate Then
                        MsgBox("Data Sudah Di Update ")
                    Else
                        MsgBox("Update Gagal")
                    End If
                    btnCancel.PerformClick()
                    cboJns_Brg.Focus()
                End With
            End If
        End If
    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtKd_barang.Text = "" Or txtNm_brg.Text = "" Then
            MsgBox("Pilih Data !")
        Else
            Dim pesan As String
            pesan = MsgBox("Data Akan di Hapus ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
            If pesan = vbYes Then
                objBarang = New clsBarang
                With objBarang
                    .kd_brg = txtKd_barang.Text
                    .nm_brg = txtNm_brg.Text
                    .Jenis = cboJns_Brg.Text
                    .warna = txtWarna.Text
                    .model = txtMode.Text
                    .satuan = cboSatuan.Text
                    If .isDelete Then
                        MsgBox("Data telah dihapus")
                    Else
                        MsgBox("Gagal menghapus ")
                    End If
                    btnCancel.PerformClick()
                End With
            End If
        End If
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call kosong()
        Call listGrid()
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnClose.Enabled = True
        btnEdit.Text = "Edit"
        cboJns_Brg.Enabled = True
        Call aktf()
    End Sub

    Private Sub grdBarang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdBarang.CellClick
        Try
            txtKd_barang.Text = grdBarang.SelectedCells(0).Value
            txtNm_brg.Text = grdBarang.SelectedCells(1).Value
            cboSatuan.SelectedItem = grdBarang.SelectedCells(2).Value
            cboJns_Brg.SelectedItem = grdBarang.SelectedCells(3).Value
            txtMode.Text = grdBarang.SelectedCells(4).Value
            txtWarna.Text = grdBarang.SelectedCells(5).Value
        Catch ex As Exception
            '            MsgBox(ex.Message.ToString)
        End Try
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = False
        txtKd_jns.ReadOnly = True
        btnEdit.Text = "Edit"
        Call nonaktif()
        cboJns_Brg.Enabled = False
        txtCariBrg.Text = ""
        txtCariJenis.Text = ""
        txtCariKode.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim pesan As String
        pesan = MsgBox("Keluar Form ? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Warning ")
        If pesan = vbYes Then
            Close()
        End If
    End Sub

    Private Sub txtCariKode_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariKode.TextChanged
        objBarang = New clsBarang
        objBarang.kd_brg = txtCariKode.Text
        '        objReader = objBarang.getKode
        With objBarang
            If .getKode.Rows.Count = 0 Then
                grdBarang.DataSource = .getKode
                txtKd_jns.Focus()
            Else
                grdBarang.DataSource = .getKode
            End If
        End With
        txtCariKode.Focus()
    End Sub

    Private Sub txtCariBrg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariBrg.TextChanged
        objBarang = New clsBarang
        objBarang.nm_brg = txtCariBrg.Text
        '        objReader = objBarang.getKode
        With objBarang
            If .getNmBarang.Rows.Count = 0 Then
                grdBarang.DataSource = .getNmBarang
                txtCariBrg.Focus()
            Else
                grdBarang.DataSource = .getNmBarang
            End If
        End With
        txtCariBrg.Focus()
    End Sub

    Private Sub txtCariJenis_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariJenis.TextChanged
        objBarang = New clsBarang
        objBarang.Jenis = txtCariJenis.Text
        '        objReader = objBarang.getKode
        If objBarang.getJenisBrg.Rows.Count = 0 Then
            grdBarang.DataSource = objBarang.getJenisBrg
            txtCariJenis.Focus()
        Else
            grdBarang.DataSource = objBarang.getJenisBrg
        End If
        txtCariJenis.Focus()
    End Sub

    Private Sub txtKd_brg_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKd_jns.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtKd_jns.SelectionStart
        txtKd_jns.Text = StrConv(txtKd_jns.Text, VbStrConv.ProperCase)
        txtKd_jns.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            txtNm_brg.Focus()
        End If
    End Sub

    Private Sub txtNm_brg_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNm_brg.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtNm_brg.SelectionStart
        txtNm_brg.Text = StrConv(txtNm_brg.Text, VbStrConv.ProperCase)
        txtNm_brg.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            cboSatuan.Focus()
        End If
    End Sub

    Private Sub txtMode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMode.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtMode.SelectionStart
        txtMode.Text = StrConv(txtMode.Text, VbStrConv.ProperCase)
        txtMode.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            txtWarna.Focus()
        End If
    End Sub

    Private Sub txtWarna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWarna.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtWarna.SelectionStart
        txtWarna.Text = StrConv(txtWarna.Text, VbStrConv.ProperCase)
        txtWarna.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub cboJns_Brg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboJns_Brg.LostFocus
        'menampilkan kode jenis ketika cboJenis di pilih
        objJns_brg = New clsJns_Brg
        objJns_brg.jenis = cboJns_Brg.Text
        objReader = objJns_brg.isGetKode
        If objReader.HasRows Then
            objReader.Read()
            txtKd_jns.Text = objReader(0)
        End If
    End Sub

    Private Sub cboJns_Brg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboJns_Brg.SelectedIndexChanged
        txtNm_brg.Focus()
        'menampilkan kode jenis ketika cboJenis di pilih
        'objJns_brg = New clsJns_Brg
        'objJns_brg.jenis = cboJns_Brg.Text
        'objReader = objJns_brg.isGetKode
        'If objReader.HasRows Then
        '    objReader.Read()
        '    txtKd_jns.Text = objReader(0)
        'End If
    End Sub

    Private Sub cboSatuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSatuan.SelectedIndexChanged
        txtMode.Focus()
    End Sub

    Private Sub txtKd_brg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKd_jns.TextChanged
        'MEMBUAT NO auto berdasarkan jenis yg dipilih
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "SELECT RIGHT(kd_brg,4) AS kd_brg FROM Tb_barang WHERE jns_brg = '" & cboJns_Brg.Text & "' ORDER BY  RIGHT(kd_brg,4) DESC " ' = '" & txtKd_barang.Text & "' DESC"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                objReader.Read()
                txtKd_barang.Text = Mid(" 00000", 1, 6 - (Val(objReader.Item(0)) + 1).ToString.Length) + (Val(objReader.Item(0)) + 1).ToString
            Else
                txtKd_barang.Text = " 00001"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            'mycon.Close()
            'mycon = Nothing
            'objCommand.Dispose()
            'objCommand = Nothing
        End Try
    End Sub

End Class
