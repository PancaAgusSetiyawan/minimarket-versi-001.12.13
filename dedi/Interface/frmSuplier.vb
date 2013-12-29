Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmSuplier

    Private objSuplier As clsSuplier

    Private Sub kosong()
        txtAlamat.Text = ""
        txtEmail.Text = ""
        'txtKd_suplier.Text = ""
        txtKota.Text = ""
        txtNm_suplier.Text = ""
        txtTelp.Text = ""
        txtCariSuplier.Text = ""
    End Sub

    Private Sub Aktif()
        txtAlamat.ReadOnly = False
        txtEmail.ReadOnly = False
        ' txtKd_suplier.ReadOnly = False
        txtKota.ReadOnly = False
        txtNm_suplier.ReadOnly = False
        txtTelp.ReadOnly = False
    End Sub

    Private Sub nonAktif()
        txtAlamat.ReadOnly = True
        txtEmail.ReadOnly = True
        txtKd_suplier.ReadOnly = True
        txtKota.ReadOnly = True
        txtNm_suplier.ReadOnly = True
        txtTelp.ReadOnly = True
    End Sub

    Private Sub listGrid()
        objSuplier = New clsSuplier
        GrdSuplier.DataSource = objSuplier.GetData
        GrdSuplier.Columns(0).Width = 100
        GrdSuplier.Columns(1).Width = 250
        GrdSuplier.Columns(2).Width = 300
        GrdSuplier.Columns(3).Width = 200
        GrdSuplier.Columns(4).Width = 100
        GrdSuplier.Columns(5).Width = 250
        Call AutoNumberRowsForGridView()
    End Sub

    Private Function AutoKd() As String
        mycon = New MySqlConnection(strCon)
        mycon.Open()
        strSql = "SELECT RIGHT(kd_suplier,4) AS kd_suplier FROM Tb_suplier WHERE LEFT(kd_suplier,4)='Spl/' ORDER BY RIGHT(kd_suplier,4) DESC"
        objCommand = New MySqlCommand(strSql, mycon)
        objReader = objCommand.ExecuteReader()
        If objReader.HasRows Then
            objReader.Read()
            Return Mid("Spl/0000", 1, 8 - (Val(objReader.Item(0)) + 1).ToString.Length) + (Val(objReader.Item(0)) + 1).ToString
        Else
            Return "Spl/0001"
        End If
    End Function

    Private Sub AutoNumberRowsForGridView() ' membuat no otomatis pada datagridview
        If GrdSuplier IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (GrdSuplier.Rows.Count - 2))
                GrdSuplier.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")
                count += 1
            End While
        End If
    End Sub

    'Private Sub txtKd_suplier_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    ' imputan huruf awal kapital
    '    Dim i As Integer = txtKd_suplier.SelectionStart
    '    txtKd_suplier.Text = StrConv(txtKd_suplier.Text, VbStrConv.ProperCase)
    '    txtKd_suplier.SelectionStart = i
    '    If Asc(e.KeyChar) = Keys.Enter Then
    '        txtNm_suplier.Focus()
    '    End If
    'End Sub

    Private Sub frmSuplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnCancel.PerformClick()
        txtKd_suplier.Text = AutoKd()
        Call listGrid()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtKd_suplier.Text = "" Or txtNm_suplier.Text = "" Or txtAlamat.Text = "" Then
            MsgBox("Data Harus Lengkap")
        Else
            objSuplier = New clsSuplier
            With objSuplier
                .kd_suplier = txtKd_suplier.Text
                .nm_suplier = txtNm_suplier.Text
                .alamat = txtAlamat.Text
                .kota = txtKota.Text
                .telp = txtTelp.Text
                .email = txtEmail.Text
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
            txtKd_suplier.Text = AutoKd()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtKd_suplier.Text = "" Or txtNm_suplier.Text = "" Or txtAlamat.Text = "" Then
            MsgBox("Data Harus Lengkap")
        Else
            If btnEdit.Text = "Edit" Then
                btnSave.Enabled = False
                btnEdit.Enabled = True
                btnDelete.Enabled = False
                btnCancel.Enabled = True
                btnClose.Enabled = False
                btnEdit.Text = "Update"
                Call Aktif()
                txtKd_suplier.ReadOnly = True
            Else
                objSuplier = New clsSuplier
                With objSuplier
                    .kd_suplier = txtKd_suplier.Text
                    .nm_suplier = txtNm_suplier.Text
                    .alamat = txtAlamat.Text
                    .kota = txtKota.Text
                    .telp = txtTelp.Text
                    .email = txtEmail.Text
                    If .isUpdate Then
                        MsgBox("Data Sudah Di Update ")
                    Else
                        MsgBox("Update Gagal")
                    End If
                    btnCancel.PerformClick()
                End With
            End If
        End If

    End Sub

    Private Sub btnDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtKd_suplier.Text = "" Or txtNm_suplier.Text = "" Or txtAlamat.Text = "" Then
            MsgBox("Pilih Data !")
        Else
            Dim pesan As String
            pesan = MsgBox("Data Akan di Hapus ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
            If pesan = vbYes Then
                objSuplier = New clsSuplier
                With objSuplier
                    .kd_suplier = txtKd_suplier.Text
                    .nm_suplier = txtNm_suplier.Text
                    .alamat = txtAlamat.Text
                    .kota = txtKota.Text
                    .telp = txtTelp.Text
                    .email = txtEmail.Text
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
        Call Aktif()
        Call listGrid()
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnClose.Enabled = True
        btnEdit.Text = "Edit"
        txtKd_suplier.Text = AutoKd()
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim pesan As String
        pesan = MsgBox("Keluar Form ? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Warning ")
        If pesan = vbYes Then
            Close()
        End If
    End Sub

    Private Sub GrdSuplier_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSuplier.CellClick
        Try
            txtKd_suplier.Text = GrdSuplier.SelectedCells(0).Value
            txtNm_suplier.Text = GrdSuplier.SelectedCells(1).Value
            txtAlamat.Text = GrdSuplier.SelectedCells(2).Value
            txtKota.Text = GrdSuplier.SelectedCells(3).Value
            txtTelp.Text = GrdSuplier.SelectedCells(4).Value
            txtEmail.Text = GrdSuplier.SelectedCells(5).Value
        Catch ex As Exception
            '            MsgBox(ex.Message.ToString)
        End Try
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = False
        txtKd_suplier.ReadOnly = True
        btnEdit.Text = "Edit"
        Call nonAktif()
    End Sub

    Private Sub txtCariSuplier_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariSuplier.TextChanged
        If rdKode.Checked = True Then
            objSuplier = New clsSuplier
            objSuplier.kd_suplier = txtCariSuplier.Text
            If objSuplier.GetKOdeSuplier.Rows.Count = 0 Then
                GrdSuplier.DataSource = objSuplier.GetKOdeSuplier
                txtCariSuplier.Focus()
            Else
                GrdSuplier.DataSource = objSuplier.GetKOdeSuplier
            End If
        ElseIf rdNama.Checked = True Then
            objSuplier = New clsSuplier
            objSuplier.nm_suplier = txtCariSuplier.Text
            If objSuplier.GetNamaSuplier.Rows.Count = 0 Then
                GrdSuplier.DataSource = objSuplier.GetNamaSuplier
                txtCariSuplier.Focus()
            Else
                GrdSuplier.DataSource = objSuplier.GetNamaSuplier
            End If
        ElseIf rdKota.Checked = True Then
            objSuplier = New clsSuplier
            objSuplier.kota = txtCariSuplier.Text
            If objSuplier.GetKotaSuplier.Rows.Count = 0 Then
                GrdSuplier.DataSource = objSuplier.GetKotaSuplier
                txtCariSuplier.Focus()
            Else
                GrdSuplier.DataSource = objSuplier.GetKotaSuplier
            End If
        Else
            GrdSuplier.DataSource = objSuplier.GetKotaSuplier
        End If

    End Sub

    Private Sub rdKode_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdKode.CheckedChanged
        txtCariSuplier.Focus()
    End Sub

    Private Sub rdNama_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdNama.CheckedChanged
        txtCariSuplier.Focus()
    End Sub

    Private Sub rdKota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdKota.CheckedChanged
        txtCariSuplier.Focus()
    End Sub

    Private Sub txtNm_suplier_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNm_suplier.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtNm_suplier.SelectionStart
        txtNm_suplier.Text = StrConv(txtNm_suplier.Text, VbStrConv.ProperCase)
        txtNm_suplier.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            txtAlamat.Focus()
        End If
    End Sub

    Private Sub txtAlamat_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAlamat.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtAlamat.SelectionStart
        txtAlamat.Text = StrConv(txtAlamat.Text, VbStrConv.ProperCase)
        txtAlamat.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            txtKota.Focus()
        End If

    End Sub

    Private Sub txtKota_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKota.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtKota.SelectionStart
        txtKota.Text = StrConv(txtKota.Text, VbStrConv.ProperCase)
        txtKota.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            txtTelp.Focus()
        End If
    End Sub

    Private Sub txtTelp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelp.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtTelp.SelectionStart()
        txtTelp.Text = StrConv(txtTelp.Text, VbStrConv.ProperCase)
        txtTelp.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            txtEmail.Focus()
        End If
    End Sub

    Private Sub txtEmail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEmail.KeyPress
        Dim i As Integer = txtEmail.SelectionStart()
        txtEmail.Text = StrConv(txtEmail.Text, VbStrConv.ProperCase)
        txtEmail.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            btnSave.Focus()
        End If
    End Sub
End Class