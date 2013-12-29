Imports MySql.Data.MySqlClient

Public Class FrmUpdateHarga

    Private objHarga As clsHarga

    Private Sub ListGrid()
        objHarga = New clsHarga
        grdHarga.DataSource = objHarga.getData
        grdHarga.Columns(0).Width = 150
        grdHarga.Columns(1).Width = 400
        grdHarga.Columns(2).Width = 150
        grdHarga.Columns(3).Width = 150
        grdHarga.Columns(4).Width = 150
        grdHarga.Columns(5).Width = 125

        grdHarga.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
        grdHarga.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        grdHarga.Columns(3).DefaultCellStyle.Format = "#,##"
        grdHarga.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomRight
        grdHarga.Columns(4).DefaultCellStyle.Format = "#,##"
        grdHarga.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter
    End Sub

    Private Sub FrmUpdateHarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnCancel.PerformClick()
    End Sub

    Private Sub grdHarga_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdHarga.CellClick
        txtKd_brg.Text = grdHarga.SelectedCells(0).Value
        txtNm_Brg.Text = grdHarga.SelectedCells(1).Value
        txtStok.Text = grdHarga.SelectedCells(2).Value
        txtHrg_Beli.Text = Format(grdHarga.SelectedCells(3).Value, "#,###")
        txtHrg_Jual.Text = Format(grdHarga.SelectedCells(4).Value, "#,###")
        txtDiskon.Text = grdHarga.SelectedCells(5).Value
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        objHarga = New clsHarga
        With objHarga
            .kd_brg = txtKd_brg.Text
            .Stok = txtStok.Text
            .hrg_beli_satuan = txtHrg_Beli.Text
            .hrg_jual_satuan = txtHrg_Jual.Text
            .DIskon = txtDiskon.Text
            If .isUpdateHarga Then
                MsgBox("Berhasil Update Data ", MsgBoxStyle.Information, "Info")
            Else
                MsgBox("Gagal", MsgBoxStyle.Critical, "Info")
            End If
            btnCancel.PerformClick()
        End With
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Call ListGrid()
        txtCari.Text = ""
        txtDiskon.Text = ""
        txtHrg_Beli.Text = 0
        txtHrg_Jual.Text = 0
        txtKd_brg.Text = ""
        txtNm_Brg.Text = ""
        txtStok.Text = ""
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dim Pesan As String
        Pesan = MsgBox("Keluar Form ", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Info")
        If Pesan = vbYes Then
            Me.Close()
        End If
    End Sub
End Class