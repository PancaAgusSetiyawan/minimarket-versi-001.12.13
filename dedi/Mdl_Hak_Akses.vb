
Module Mdl_Hak_Akses

    Public Sub LogOut()
        MenuMain.LogInToolStripMenuItem.Enabled = True
        MenuMain.ManagementUserToolStripMenuItem.Enabled = False
        MenuMain.LogOutToolStripMenuItem.Enabled = False
        MenuMain.GantiPasswordToolStripMenuItem.Enabled = False
        MenuMain.ExitToolStripMenuItem.Enabled = True

        MenuMain.BarangToolStripMenuItem.Enabled = False
        MenuMain.SuplierToolStripMenuItem.Enabled = False
        MenuMain.JenisBarangToolStripMenuItem.Enabled = False

        MenuMain.PembelianToolStripMenuItem.Enabled = False
        MenuMain.POSToolStripMenuItem.Enabled = False
        MenuMain.POSToolStripMenuItem.Enabled = False
        MenuMain.LaporanToolStripMenuItem.Enabled = False
        MenuMain.StokOpnameToolStripMenuItem.Enabled = False
        MenuMain.PetunjukToolStripMenuItem1.Enabled = False
        MenuMain.AboutToolStripMenuItem2.Enabled = True
    End Sub

    Public Sub Spv()
        MenuMain.LogInToolStripMenuItem.Enabled = True
        MenuMain.ManagementUserToolStripMenuItem.Enabled = True
        MenuMain.LogOutToolStripMenuItem.Enabled = True
        MenuMain.GantiPasswordToolStripMenuItem.Enabled = True
        MenuMain.ExitToolStripMenuItem.Enabled = True

        MenuMain.BarangToolStripMenuItem.Enabled = True
        MenuMain.SuplierToolStripMenuItem.Enabled = True
        MenuMain.JenisBarangToolStripMenuItem.Enabled = True

        MenuMain.PembelianToolStripMenuItem.Enabled = True
        MenuMain.POSToolStripMenuItem.Enabled = True
        MenuMain.LaporanToolStripMenuItem.Enabled = True
        MenuMain.StokOpnameToolStripMenuItem.Enabled = True
        MenuMain.PetunjukToolStripMenuItem1.Enabled = True
        MenuMain.AboutToolStripMenuItem2.Enabled = True
    End Sub

    Public Sub Kasir()
        MenuMain.LogInToolStripMenuItem.Enabled = True
        MenuMain.ManagementUserToolStripMenuItem.Enabled = False
        MenuMain.LogOutToolStripMenuItem.Enabled = False
        MenuMain.GantiPasswordToolStripMenuItem.Enabled = True
        MenuMain.ExitToolStripMenuItem.Enabled = True

        MenuMain.BarangToolStripMenuItem.Enabled = False
        MenuMain.SuplierToolStripMenuItem.Enabled = False
        MenuMain.JenisBarangToolStripMenuItem.Enabled = False

        MenuMain.PembelianToolStripMenuItem.Enabled = False
        MenuMain.POSToolStripMenuItem.Enabled = True
        MenuMain.LaporanToolStripMenuItem.Enabled = False
        MenuMain.StokOpnameToolStripMenuItem.Enabled = False
        MenuMain.PetunjukToolStripMenuItem1.Enabled = False
        MenuMain.AboutToolStripMenuItem2.Enabled = True
    End Sub

    Public Sub OperatorAdmin()
        MenuMain.LogInToolStripMenuItem.Enabled = True
        MenuMain.ManagementUserToolStripMenuItem.Enabled = False
        MenuMain.LogOutToolStripMenuItem.Enabled = False
        MenuMain.GantiPasswordToolStripMenuItem.Enabled = True
        MenuMain.ExitToolStripMenuItem.Enabled = True

        MenuMain.BarangToolStripMenuItem.Enabled = True
        MenuMain.SuplierToolStripMenuItem.Enabled = True
        MenuMain.JenisBarangToolStripMenuItem.Enabled = True

        MenuMain.PembelianToolStripMenuItem.Enabled = True
        MenuMain.POSToolStripMenuItem.Enabled = False
        MenuMain.LaporanToolStripMenuItem.Enabled = True
        MenuMain.StokOpnameToolStripMenuItem.Enabled = True
        MenuMain.PetunjukToolStripMenuItem1.Enabled = True
        MenuMain.AboutToolStripMenuItem2.Enabled = True
    End Sub

    Public UserId_LogIn As String
End Module
