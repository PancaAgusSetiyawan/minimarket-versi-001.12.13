Imports MySql.Data.MySqlClient

Public Class FrmGolongan

    Private objGolongan As clsGolongan

    Private Sub aktif()
        txtKd_gol.ReadOnly = False
        txtGolongan.ReadOnly = False
        txtKeterngan.ReadOnly = False
    End Sub

    Private Sub NonAktif()
        txtKd_gol.ReadOnly = True
        txtGolongan.ReadOnly = True
        txtKeterngan.ReadOnly = True
    End Sub

    Private Sub Kosong()
        txtGolongan.Text = ""
        txtKd_gol.Text = ""
        txtKeterngan.Text = ""
    End Sub

    Private Sub ListGrid()
        objGolongan = New clsGolongan
        grdGolongan.DataSource = objGolongan.getData
        grdGolongan.Columns(0).Width = 100
        grdGolongan.Columns(1).Width = 200
        grdGolongan.Columns(2).Width = 300
    End Sub

    Private Sub Frm_Golongan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Kosong()
        Call ListGrid()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtKd_gol.Text = "" Or txtGolongan.Text = "" Then
            MsgBox("Data Harus Lengkap")
        Else
            objGolongan = New clsGolongan
            With objGolongan
                .Kd_Gol = txtKd_gol.Text
                .Golongan = txtGolongan.Text
                .Keterangan = txtKeterngan.Text
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

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If txtKd_gol.Text = "" Or txtGolongan.Text = "" Then
            MsgBox("Data Harus Lengkap")
        Else
            objGolongan = New clsGolongan
            With objGolongan
                .Kd_Gol = txtKd_gol.Text
                .Golongan = txtGolongan.Text
                .Keterangan = txtKeterngan.Text
                If .isDelete Then
                    MsgBox("Sukses Menghapus Data", MsgBoxStyle.Information, "Informasu")
                Else
                    MsgBox("Gagal Menghapus data", MsgBoxStyle.Information, "Informasi")
                End If
            End With
            btnCancel.PerformClick()
        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If txtKd_gol.Text = "" Or txtGolongan.Text = "" Then
            MsgBox("Klik No urut data...!")
        Else
            If btnEdit.Text = "Edit" Then
                btnSave.Enabled = False
                btnEdit.Enabled = True
                btnDelete.Enabled = False
                btnCancel.Enabled = True
                btnClose.Enabled = False
                btnEdit.Text = "Update"
                Call aktif()
                txtKd_gol.ReadOnly = True
            Else
                objGolongan = New clsGolongan
                With objGolongan
                    .Kd_Gol = txtKd_gol.Text
                    .Golongan = txtGolongan.Text
                    .Keterangan = txtKeterngan.Text
                    If .isDelete Then
                        MsgBox("Sukses Menghapus Data", MsgBoxStyle.Information, "Informasu")
                    Else
                        MsgBox("Gagal Menghapus data", MsgBoxStyle.Information, "Informasi")
                    End If
                End With
                btnCancel.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call Kosong()
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
        pesan = MsgBox("Keluar Form ? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Warning ")
        If pesan = vbYes Then
            Close()
        End If
    End Sub
End Class