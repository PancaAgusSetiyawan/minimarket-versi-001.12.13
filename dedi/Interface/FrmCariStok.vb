
Imports MySql.Data.MySqlClient

Public Class FrmCariStok

    Private Sub listGrid()
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select H.Kd_brg, B.Nm_brg, H.hrg_jual_satuan, H.Stok, H.Diskon FROM tb_barang B INNER JOIN Tb_harga H ON B.kd_brg = H.kd_brg"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            grdCariStok.DataSource = objDataTable
            grdCariStok.Columns(0).Width = 150
            grdCariStok.Columns(1).Width = 400
            grdCariStok.Columns(2).Width = 150
            grdCariStok.Columns(3).Width = 150
            grdCariStok.Columns(4).Width = 150
            objCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objCommand = Nothing
        End Try
    End Sub

    Private Sub crKode()
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select H.Kd_brg, B.Nm_brg, H.hrg_jual_satuan, H.Stok, H.Diskon FROM tb_barang B INNER JOIN Tb_harga H ON B.kd_brg = H.kd_brg Where kd_brg LIKE '%" & TextBox1.Text & "%'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            grdCariStok.DataSource = objDataTable
            grdCariStok.Columns(0).Width = 150
            grdCariStok.Columns(1).Width = 400
            grdCariStok.Columns(2).Width = 150
            grdCariStok.Columns(3).Width = 150
            grdCariStok.Columns(4).Width = 150
            objCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objCommand = Nothing
        End Try
    End Sub

    Private Sub CrNama()
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select H.Kd_brg, B.Nm_brg, H.hrg_jual_satuan, H.Stok, H.Diskon FROM tb_barang B INNER JOIN Tb_harga H ON B.kd_brg = H.kd_brg WHERE nm_brg LIKE '%" & TextBox1.Text & "%'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            grdCariStok.DataSource = objDataTable
            grdCariStok.Columns(0).Width = 150
            grdCariStok.Columns(1).Width = 400
            grdCariStok.Columns(2).Width = 150
            grdCariStok.Columns(3).Width = 150
            grdCariStok.Columns(4).Width = 150
            objCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objCommand = Nothing
        End Try
    End Sub

    Private Sub crJenis()
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select H.Kd_brg, B.Nm_brg, H.hrg_jual_satuan, H.Stok, H.Diskon FROM tb_barang B INNER JOIN Tb_harga H ON B.kd_brg = H.kd_brg WHERE jenis LIKE '%" & TextBox1.Text & "%'"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            grdCariStok.DataSource = objDataTable
            grdCariStok.Columns(0).Width = 150
            grdCariStok.Columns(1).Width = 400
            grdCariStok.Columns(2).Width = 150
            grdCariStok.Columns(3).Width = 150
            grdCariStok.Columns(4).Width = 150
            objCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objCommand = Nothing
        End Try
    End Sub

    Private Sub FrmCariStok_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call listGrid()
    End Sub

    Private Sub rdjenis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If rdKode.Checked = True Or rdnama.Checked = True Then
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If rdKode.Checked = True Then
            Call crKode()
        ElseIf rdnama.Checked = True Then
            Call CrNama()
        Else
            listGrid()
        End If
    End Sub

    Private Sub grdCariStok_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCariStok.CellClick
        My.Forms.POS.txtKd_brg.Text = grdCariStok.SelectedCells(0).Value.ToString
        Me.Hide()
        My.Forms.POS.txtKd_brg.Focus()
    End Sub

    Private Sub rdKode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdKode.CheckedChanged

    End Sub
End Class