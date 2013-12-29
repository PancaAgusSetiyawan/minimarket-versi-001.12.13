Imports System
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class MenuMain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmLogIn2.Show()
        FrmLogIn2.MdiParent = Me
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            mycon = New MySqlConnection(strCon)
            mycon.Open()
            mycon.Close()
        Catch ex As Exception
            MsgBox("cek koneksi")
        End Try
    End Sub

    Private Sub btnSuplier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmSuplier.Show()
        frmSuplier.MdiParent = Me
    End Sub

    Private Sub picLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmLogIn2.MdiParent = Me
        FrmLogIn2.Show()

        'FormBarang.MdiParent = Me
        'FormBarang.Show()
    End Sub

    Private Sub LogInToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInToolStripMenuItem.Click
        FrmLogIn2.MdiParent = Me
        FrmLogIn2.Show()
    End Sub

    Private Sub ManagementUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagementUserToolStripMenuItem.Click
        frmUser.MdiParent = Me
        frmUser.Show()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarangToolStripMenuItem.Click
        FrmBarang.MdiParent = Me
        FrmBarang.Show()
    End Sub

    Private Sub SuplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuplierToolStripMenuItem.Click
        frmSuplier.MdiParent = Me
        frmSuplier.Show()
    End Sub

    Private Sub JenisBarangToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JenisBarangToolStripMenuItem.Click
        frmJenis.MdiParent = Me
        frmJenis.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PembelianToolStripMenuItem.Click
        frmPembelian.MdiParent = Me
        frmPembelian.Show()
    End Sub

    Private Sub POSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles POSToolStripMenuItem.Click
        POS.MdiParent = Me
        POS.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim pesan As String
        pesan = MsgBox("Keluar Form ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Warning")
        If pesan = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub GolonganToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmGolongan.MdiParent = Me
        FrmGolongan.Show()
    End Sub

    Private Sub StokOpnameToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StokOpnameToolStripMenuItem.Click
        FrmStokOpname.MdiParent = Me
        FrmStokOpname.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Call LogOut()
    End Sub

    Private Sub GantiPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GantiPasswordToolStripMenuItem.Click
        frmRubahPass.MdiParent = Me
        frmRubahPass.Show()
    End Sub

    Private Sub PerTransaksiToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerTransaksiToolStripMenuItem1.Click
        Lap_Pembelian.MdiParent = Me
        Lap_Pembelian.Show()
    End Sub

    Private Sub HarianToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HarianToolStripMenuItem1.Click
        Lap_Pb_Harian.MdiParent = Me
        Lap_Pb_Harian.Show()
    End Sub

    Private Sub PerTransaksiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PerTransaksiToolStripMenuItem.Click
        Lap_PerTransVW.MdiParent = Me
        Lap_PerTransVW.Show()
    End Sub

    Private Sub HarianToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HarianToolStripMenuItem.Click
        Lap_Pj_harianVw.MdiParent = Me
        Lap_Pj_harianVw.Show()
    End Sub

    Private Sub StokToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StokToolStripMenuItem.Click
        Lap_Stok.MdiParent = Me
        Lap_Stok.Show()
    End Sub

    Private Sub AboutToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem2.Click
        AboutF.MdiParent = Me
        AboutF.Show()
    End Sub
End Class