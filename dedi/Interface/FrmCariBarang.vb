Imports MySql.Data.MySqlClient

Public Class FrmCariBarang

    Private objBarang As clsBarang

    Private Sub listGrid()
        objBarang = New clsBarang
        grdBarang.DataSource = objBarang.getDataJoin
        grdBarang.Columns(0).Width = 150
        grdBarang.Columns(1).Width = 400
        grdBarang.Columns(2).Width = 150
        grdBarang.Columns(3).Width = 200
        grdBarang.Columns(4).Width = 100
        grdBarang.Columns(5).Width = 100
        grdBarang.Columns(6).Width = 100
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

    Private Sub FrmCariBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call listGrid()
    End Sub

    Private Sub txtCariBarang_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCariBarang.TextChanged
        If rdKode.Checked = True Then
            objBarang = New clsBarang
            objBarang.kd_brg = txtCariBarang.Text
            If objBarang.getKode.Rows.Count = 0 Then
                grdBarang.DataSource = objBarang.getKode
                txtCariBarang.Focus()
            Else
                grdBarang.DataSource = objBarang.getKode
            End If
        ElseIf rdNama.Checked = True Then
            objBarang = New clsBarang
            objBarang.nm_brg = txtCariBarang.Text
            If objBarang.getNmBarang.Rows.Count = 0 Then
                grdBarang.DataSource = objBarang.getNmBarang
                txtCariBarang.Focus()
            Else
                grdBarang.DataSource = objBarang.getNmBarang
            End If
        ElseIf rdKota.Checked = True Then
            objBarang = New clsBarang
            objBarang.Jenis = txtCariBarang.Text
            If objBarang.getJenisBrg.Rows.Count = 0 Then
                grdBarang.DataSource = objBarang.getJenisBrg
                txtCariBarang.Focus()
            Else
                grdBarang.DataSource = objBarang.getJenisBrg
            End If
        Else
            grdBarang.DataSource = objBarang.getKode
        End If
    End Sub

    Private Sub grdBarang_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdBarang.CellClick
        My.Forms.frmPembelian.txtKd_barang.Text = grdBarang.SelectedCells(0).Value.ToString
        My.Forms.frmPembelian.txtNm_barang.Text = grdBarang.SelectedCells(1).Value.ToString
        My.Forms.frmPembelian.txtSatuan.Text = grdBarang.SelectedCells(2).Value.ToString
        frmPembelian.Show()
        Me.Close()
    End Sub

    Private Sub rdKota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdKota.CheckedChanged
        If rdKode.Checked = True Or rdKota.Checked = True Or rdNama.Checked = True Then
            txtCariBarang.Focus()
        End If

    End Sub

    Private Sub rdKode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdKode.CheckedChanged
        If rdKode.Checked Then
            txtCariBarang.Focus()
        End If
    End Sub

    Private Sub rdNama_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdNama.CheckedChanged
        If rdNama.Checked Then
            txtCariBarang.Focus()
        End If
    End Sub
End Class