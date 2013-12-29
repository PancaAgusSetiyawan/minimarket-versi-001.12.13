Imports System
Imports MySql.Data.MySqlClient

Public Class FrmCariSuplier

    Private objSuplier As clsSuplier

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

    Private Sub AutoNumberRowsForGridView() ' membuat no otomatis pada datagridview
        If GrdSuplier IsNot Nothing Then
            Dim count As Integer = 0
            While (count <= (GrdSuplier.Rows.Count - 2))
                GrdSuplier.Rows(count).HeaderCell.Value = String.Format((count + 1).ToString(), "0")
                count += 1
            End While
        End If
    End Sub

    Private Sub FrmCariSuplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call listGrid()
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

    Private Sub GrdSuplier_CellClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GrdSuplier.CellClick
        Try ' kode ketika dklik maka form pembelian akan muncul beserta kode nama dan alamtnya yg dipilih akan muncul pada textbox
            My.Forms.frmPembelian.txtKd_Suplier.Text = GrdSuplier.SelectedCells(0).Value.ToString
            My.Forms.frmPembelian.txtNm_Siplier.Text = GrdSuplier.SelectedCells(1).Value.ToString
            My.Forms.frmPembelian.txtAlamat.Text = GrdSuplier.SelectedCells(2).Value.ToString
            frmPembelian.Show()
        Catch ex As Exception
            '            MsgBox(ex.Message.ToString)
        End Try
        Me.Close()

    End Sub

    Private Sub rdKota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdKota.CheckedChanged
        If rdKode.Checked = True Or rdKota.Checked = True Or rdNama.Checked = True Then
            txtCariSuplier.Focus()
        End If
    End Sub
End Class