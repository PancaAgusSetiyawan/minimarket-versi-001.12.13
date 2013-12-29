Imports MySql.Data.MySqlClient

Public Class Lap_FrmPembelian

    Private Sub BetWeen_UserId()
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            strSql = "Select P.tgl_beli, SUM(D.sub_total), P.user_id FROM Tb_pembelian P INNER JOIN tb_Pembelian_Detail D ON P.no_pembelian =  D.no_pembelian WHERE P.tgl_beli BETWEEN '" & Format(dtAwal.Value, "yyyy-MM-dd") & "' AND '" & Format(dtAkhir.Value, "yyyy-MM-dd") & "' GROUP BY P.tgl_beli " 'ORDER BY P.tgl_beli " 'And P.tgl_jual"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            objDataTable.Load(objReader)
            grdView.DataSource = objDataTable
            With grdView
                .Columns(0).Width = 150
                .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .Columns(1).Width = 200
                .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                .Columns(1).DefaultCellStyle.Format = "#,##"
                .Columns(2).Width = 240
                .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            End With
            objCommand.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            mycon.Close()
            mycon = Nothing
            objReader.Close()
            objReader = Nothing
        End Try
    End Sub

    Private Sub hitung()
        Dim total As Double

        For i As Double = 0 To grdView.RowCount - 1
            total = total + CDbl(grdView.Rows(i).Cells(1).Value)
        Next
        txtTotal.Text = Format(total, "#,###")
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Call BetWeen_UserId()
        Call hitung()
    End Sub
End Class