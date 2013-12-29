Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmUser

    Private objUser As clsUser

    Private Sub kosong()
        txtKd_user.Text = ""
        txtNm_user.Text = ""
        txtPass.Text = ""
        cboLevel.SelectedIndex = 0
    End Sub

    Private Sub aktif()
        txtKd_user.ReadOnly = False
        txtNm_user.ReadOnly = False
        txtPass.ReadOnly = False
    End Sub

    Private Sub nonAktif()
        txtKd_user.ReadOnly = True
        txtNm_user.ReadOnly = True
        txtPass.ReadOnly = True
    End Sub

    Private Sub AutoNumberRowsForGridView() ' membuat no otomatis pada datagridview
        If grdUser IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (grdUser.Rows.Count - 2))
                grdUser.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")
                count += 1
            End While
        End If
    End Sub

    Private Sub listGrid()
        objUser = New clsUser
        grdUser.DataSource = objUser.GetData
        grdUser.Columns(0).Width = 150
        grdUser.Columns(1).Width = 250
        grdUser.Columns(2).Width = 100
        grdUser.Columns(3).Width = 100
        Call AutoNumberRowsForGridView()
    End Sub

    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call kosong()
        Call listGrid()
        btnSave.Enabled = True
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Sub btnSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtKd_user.Text = "" Or txtNm_user.Text = "" Or txtPass.Text = "" Or cboLevel.Text = "" Then
            MsgBox("Data Harus lengkap", )
        Else
            objUser = New clsUser
            With objUser
                .User_id = txtKd_user.Text
                .User_name = txtNm_user.Text
                .pass = txtPass.Text
                .Level1 = cboLevel.SelectedItem
                If .isExist Then
                    MsgBox("Kode sudah ada")
                Else
                    If .isSave Then
                        MsgBox("Data Tersimpan")
                    Else
                        MsgBox("Gagal Menyimpan")
                    End If
                End If
                btnCancel.PerformClick()
            End With
        End If
    End Sub

    Private Sub btnEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtKd_user.Text = "" Or txtNm_user.Text = "" Or txtPass.Text = "" Or cboLevel.Text = "" Then
            MsgBox("Lengkapi data ")
        Else
            If btnEdit.Text = "Edit" Then
                btnSave.Enabled = False
                btnEdit.Enabled = True
                btnDelete.Enabled = False
                btnCancel.Enabled = True
                btnClose.Enabled = False
                btnEdit.Text = "Update"
                Call aktif()
                txtKd_user.ReadOnly = True
            Else
                objUser = New clsUser
                With objUser
                    .User_id = txtKd_user.Text
                    .User_name = txtNm_user.Text
                    .pass = txtPass.Text
                    .Level1 = cboLevel.SelectedItem
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
        If txtKd_user.Text = "" Or txtNm_user.Text = "" Or txtPass.Text = "" Then
            MsgBox("Pilih Data !")
        Else
            Dim pesan As String
            pesan = MsgBox("Data Akan di Hapus ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
            If pesan = vbYes Then
                objUser = New clsUser
                With objUser
                    .User_id = txtKd_user.Text
                    .User_name = txtNm_user.Text
                    .pass = txtPass.Text
                    .Level1 = cboLevel.SelectedItem
                    If .isDelete Then
                        MsgBox("Data telah dihapus")
                    Else
                        MsgBox("Gagal menghapus ")
                    End If
                End With
                btnCancel.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call kosong()
        Call listGrid()
        Call aktif()
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnClose.Enabled = True
        btnEdit.Text = "Edit"
    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim pesan As String
        pesan = MsgBox("keluar Form ? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Warning ")
        If pesan = vbYes Then
            Close()
        End If
    End Sub

    Private Sub txtKd_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKd_user.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtKd_user.SelectionStart
        txtKd_user.Text = StrConv(txtKd_user.Text, VbStrConv.ProperCase)
        txtKd_user.SelectionStart = i
    End Sub

    Private Sub txtNm_user_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNm_user.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtNm_user.SelectionStart
        txtNm_user.Text = StrConv(txtNm_user.Text, VbStrConv.ProperCase)
        txtNm_user.SelectionStart = i
    End Sub

    Private Sub grdUser_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdUser.CellClick
        Try
            txtKd_user.Text = grdUser.SelectedCells(0).Value
            txtNm_user.Text = grdUser.SelectedCells(1).Value
            txtPass.Text = grdUser.SelectedCells(2).Value
            cboLevel.SelectedItem = grdUser.SelectedCells(3).Value
        Catch ex As Exception

        End Try
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = False
        txtKd_user.ReadOnly = True
        btnEdit.Text = "Edit"
        Call nonAktif()
    End Sub
End Class