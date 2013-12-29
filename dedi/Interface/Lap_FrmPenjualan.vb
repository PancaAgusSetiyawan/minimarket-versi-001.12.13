
Imports MySql.Data.MySqlClient


Public Class Lap_FrmPenjualan
    Private strSqlLap As String

    Public Property sqlLap()
        Get
            Return strSqlLap
        End Get
        Set(ByVal value)
            strSqlLap = value
        End Set
    End Property

    Private Sub BetWeen_UserId()
        Try
            mycon = New MySqlConnection(strCon)
            objDataTable = New DataTable
            mycon.Open()
            sqlLap = "Select P.tgl_jual, SUM(D.sub_total), P.user_id FROM Tb_penjualan P INNER JOIN tb_Penjualan_Detail D ON P.no_penjualan =  D.no_penjualan WHERE P.tgl_Jual BETWEEN '" & Format(dtAwal.Value, "yyyy-MM-dd") & "' AND '" & Format(dtAkhir.Value, "yyyy-MM-dd") & "' GROUP BY P.tgl_jual"
            objCommand = New MySqlCommand(sqlLap, mycon)
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

    'Private Sub BetWeen()
    '    Try
    '        mycon = New MySqlConnection(strCon)
    '        objDataTable = New DataTable
    '        mycon.Open()
    '        strSql = "Select P.tgl_jual, SUM(D.sub_total) FROM Tb_penjualan P INNER JOIN tb_Penjualan_Detail D ON P.no_penjualan =  D.no_penjualan WHERE P.tgl_jual BETWEEN '" & Format(dtAwal2.Value, "yyyy-MM-dd") & "' AND '" & Format(dtAkhir2.Value, "yyyy-MM-dd") & "' GROUP BY P.tgl_jual " ' "
    '        objCommand = New MySqlCommand(strSql, mycon)
    '        objReader = objCommand.ExecuteReader(CommandBehavior.Default)
    '        objDataTable.Load(objReader)
    '        grdView.DataSource = objDataTable
    '        With grdView
    '            .Columns(0).Width = 200
    '            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    '            .Columns(1).Width = 390
    '            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    '            .Columns(1).DefaultCellStyle.Format = "#,##"
    '        End With
    '        objCommand.Dispose()
    '    Catch ex As Exception
    '        MsgBox(ex.Message.ToString)
    '        'MsgBox("Data kosong")
    '    Finally
    '        mycon.Close()
    '        mycon = Nothing
    '        objReader.Close()
    '        objReader = Nothing
    '    End Try
    'End Sub

    Private Sub Total()
        Dim total As Double
        For i As Integer = 0 To grdView.RowCount - 2
            total = total + grdView.Rows(i).Cells(1).Value
        Next
        txtTotal.Text = Format(total, "#,###")
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Call BetWeen_UserId()
        Call Total()
    End Sub

    Private Sub Lap_Harian_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Lap_Pj_harianVw.Show()
    End Sub
End Class