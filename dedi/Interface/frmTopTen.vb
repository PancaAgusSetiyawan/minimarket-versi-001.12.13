
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class frmTopTen

    Private Sub aturChart()
        Try
            mycon = New MySqlConnection(strCon)
            objDataSet = New DataSet
            mycon.Open()
            '            strSql = "Select B.kd_brg, B.nm_brg, P.jumlah FROM tb_barang B INNER JOIN Tb_Penjualan_Detail P ON B.kd_brg = P.kd_brg"
            strSql = "Select kd_brg, Jumlah FROM Tb_penjualan_Detail ORDER BY kd_brg"
            objAdapter = New MySqlDataAdapter(strSql, mycon)
            objAdapter.Fill(objDataSet, "Tb_penjualan_Detail")
            Chart1.Series("Series1").XValueMember = "kd_brg"
            Chart1.Series("Series1").YValueMembers = "Jumlah"
            Chart1.DataSource = objDataSet.Tables("Tb_penjualan_Detail")
            mycon.Close()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub chartKe1()
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Select kd_brg, SUM(Jumlah) FROM Tb_penjualan_Detail ORDER BY kd_brg"
            objCommand = New MySqlCommand(strSql, mycon)
            objReader = objCommand.ExecuteReader(CommandBehavior.Default)
            If objReader.HasRows Then
                objReader.Read()
                With Chart1
                    .ChartAreas(0).AxisX.Interval = 1
                    .ChartAreas(0).AxisX.IsStartedFromZero = True

                    .Series(0).Name = objReader.Item(1)
                    .Series(0).Points.Clear()
                    For Each seri As Series In .Series
                        seri.ChartType = SeriesChartType.Column
                        seri.XValueType = ChartValueType.Double
                        seri.YValueType = ChartValueType.String
                    Next
                    Do While objReader.Read
                        .Series(0).Points.AddXY(objReader.Item(0).ToString.Replace("#", ""), objReader.Item(1))
                    Loop
                End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
    End Sub

    Private Sub LOADcHART()
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            strSql = "Select kd_brg, SUM(Jumlah) FROM Tb_penjualan_Detail ORDER BY kd_brg"

            objAdapter = New MySqlDataAdapter(strSql, mycon)
            objDataTable = New DataTable
            objAdapter.Fill(objDataTable)



        Catch ex As Exception

        End Try

        'Try
        '    con = New Odbc.OdbcConnection(con_str)
        '    con.Open()

        '    'add combobox
        '    adp = New Odbc.OdbcDataAdapter(txt_sql0.Text, con)
        '    tbl = New DataTable
        '    adp.Fill(tbl)
        '    With ComboBox1
        '        .DataSource = tbl
        '        .ValueMember = "ProductID"
        '        .DisplayMember = "ProductName"
        '        .SelectedIndex = 0
        '    End With

        '    Call add_chart()
        '    is_formload = False
        'Catch ex As Exception
        '    MessageBox.Show(Err.Description, "DJIESOFT_Info", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try

    End Sub

    Private Sub frmTopTen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '    Call aturChart()
        Call chartKe1()
    End Sub
End Class