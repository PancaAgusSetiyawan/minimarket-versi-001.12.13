
Imports MySql.Data.MySqlClient

Public Class FrmTutupPos

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If txtUserId.Text = "" Then
            MsgBox("Masukkan User Id Anda ", MsgBoxStyle.Information, "Info")
        Else
            Try
                mycon = New MySqlConnection(strCon)
                mycon.Open()
                strSql = "Select P.tgl_jual, SUM(D.Sub_Total), P.User_id FROM tb_penjualan P INNER JOIN tb_penjualan_detail D ON P.No_penjualan = D.No_Penjualan WHERE P.tgl_Jual = '" & lblTanggal.Text & "' and user_id = '" & txtUserId.Text & "' "
                objCommand = New MySqlCommand(strSql, mycon)
                objReader = objCommand.ExecuteReader(CommandBehavior.Default)
                If objReader.HasRows Then
                    objReader.Read()
                    lblTanggal.Text = objReader(0)
                    txtTotal.Text = Format(objReader(1), "Rp #,###")
                    lblUser.Text = objReader(2)
                Else
                    MsgBox("Belum di hitung")
                End If
            Catch ex As Exception
                MsgBox("Data Tanggal '" & lblTanggal.Text & "' Ini masih kosong")
                '                MsgBox(ex.Message.ToString)
            Finally
                mycon.Close()
                objCommand.Dispose()
                'objReader.Close()
                mycon = Nothing
                objReader = Nothing
                objCommand = Nothing
            End Try
        End If
    End Sub

    Private Sub FrmTutupPos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTanggal.Text = Now.Date
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        Lap_TutupKasir.Show()
    End Sub
End Class