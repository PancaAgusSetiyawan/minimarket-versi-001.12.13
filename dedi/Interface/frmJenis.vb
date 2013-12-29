Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class frmJenis
    Private objJns_brg As clsJns_Brg

    Private Sub kosong()
        txtJenis.Text = ""
        txtKd_Jenis.Text = ""
        txtCari.Text = ""
    End Sub

    Private Sub nonaktif()
        txtJenis.ReadOnly = True
        txtKd_Jenis.ReadOnly = True
    End Sub

    Private Sub aktif()
        txtJenis.ReadOnly = False
        '        txtKd_Jenis.ReadOnly = False
    End Sub

    Private Sub ListGrid()
        objJns_brg = New clsJns_Brg
        grdJenis.DataSource = objJns_brg.GetData
        grdJenis.Columns(0).Width = 150
        grdJenis.Columns(1).Width = 320
        Call AutoNumberRowsForGridView()
    End Sub

    Private Sub AutoNumberRowsForGridView() ' membuat no otomatis pada datagridview
        If grdJenis IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (grdJenis.Rows.Count - 2))
                grdJenis.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")
                count += 1
            End While
        End If
    End Sub

    Private Sub frmJenis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ListGrid()
        Call kosong()
        txtKd_Jenis.Text = auto()
        txtJenis.Focus()
        btnDelete.Enabled = False
        btnEdit.Enabled = False
    End Sub

    Private Function auto() As String
        mycon = New MySqlConnection(strCon)
        MyCon.Open()
        strSql = "SELECT kd_jns_brg FROM tb_jns_brg ORDER BY Kd_jns_brg DESC"
        objCommand = New MySqlCommand(strSql, mycon)
        Objreader = Objcommand.ExecuteReader()
        If Objreader.HasRows Then
            Objreader.Read()
            Return Mid("0000", 1, 4 - (Val(objReader.Item(0)) + 1).ToString.Length) + (Val(objReader.Item(0)) + 1).ToString
        Else
            Return "0001"
        End If
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtJenis.Text = "" Or txtKd_Jenis.Text = "" Then
            MsgBox("Data Harus lengkap", )
        Else
            objJns_brg = New clsJns_Brg
            With objJns_brg
                .Kd_Jenis = txtKd_Jenis.Text
                .jenis = txtJenis.Text
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
        txtKd_Jenis.Text = auto()
        txtJenis.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtJenis.Text = "" Or txtKd_Jenis.Text = "" Then
            MsgBox("Pilih Data !")
        Else
            Dim pesan As String
            pesan = MsgBox("Data Akan di Hapus ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
            If pesan = vbYes Then
                objJns_brg = New clsJns_Brg
                With objJns_brg
                    .Kd_Jenis = txtKd_Jenis.Text
                    .jenis = txtJenis.Text
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

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtJenis.Text = "" Or txtKd_Jenis.Text = "" Then
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
                txtKd_Jenis.ReadOnly = True
            Else
                objJns_brg = New clsJns_Brg
                With objJns_brg
                    .Kd_Jenis = txtKd_Jenis.Text
                    .jenis = txtJenis.Text
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call kosong()
        Call ListGrid()
        btnSave.Enabled = True
        btnEdit.Enabled = False
        btnDelete.Enabled = False
        btnCancel.Enabled = True
        btnClose.Enabled = True
        btnEdit.Text = "Edit"
        Call aktif()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim pesan As String
        pesan = MsgBox("keluar Form ? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Warning ")
        If pesan = vbYes Then
            Close()
        End If
    End Sub

    Private Sub txtKd_Jenis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKd_Jenis.KeyPress
        txtKd_Jenis.CharacterCasing = CharacterCasing.Upper
        If Asc(e.KeyChar) = Keys.Enter Then
            txtJenis.Focus()
        End If
    End Sub

    Private Sub txtJenis_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJenis.KeyPress
        ' imputan huruf awal kapital
        Dim i As Integer = txtJenis.SelectionStart
        txtJenis.Text = StrConv(txtJenis.Text, VbStrConv.ProperCase)
        txtJenis.SelectionStart = i
        If Asc(e.KeyChar) = Keys.Enter Then
            btnSave.Focus()
        End If
    End Sub

    Private Sub grdJenis_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdJenis.Click
        Try
            txtKd_Jenis.Text = grdJenis.SelectedCells(0).Value
            txtJenis.Text = grdJenis.SelectedCells(1).Value
        Catch ex As Exception

        End Try
        btnSave.Enabled = False
        btnEdit.Enabled = True
        btnDelete.Enabled = True
        btnCancel.Enabled = True
        btnClose.Enabled = False
        txtKd_Jenis.ReadOnly = True
        btnEdit.Text = "Edit"
        Call nonaktif()
    End Sub

    Private Sub txtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCari.TextChanged
        If rdKode.Checked = True Then
            objJns_brg = New clsJns_Brg
            objJns_brg.Kd_Jenis = txtCari.Text
            With objJns_brg
                If .getKode.Rows.Count = 0 Then
                    grdJenis.DataSource = .getKode
                    txtCari.Focus()
                Else
                    grdJenis.DataSource = .getKode
                End If
            End With
        ElseIf rdJenis.Checked = True Then
            objJns_brg = New clsJns_Brg
            objJns_brg.jenis = txtCari.Text
            With objJns_brg
                If .getJenis.Rows.Count = 0 Then
                    grdJenis.DataSource = .getJenis
                    txtCari.Focus()
                Else
                    grdJenis.DataSource = .getJenis
                End If
            End With
        Else
            objJns_brg = New clsJns_Brg
            grdJenis.DataSource = objJns_brg.getKode
        End If
    End Sub

    Private Sub rdJenis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdJenis.CheckedChanged
        txtCari.Focus()
    End Sub

    Private Sub rdKode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdKode.CheckedChanged
        txtCari.Focus()
    End Sub
End Class