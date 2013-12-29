<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembelian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.QBalloon1 = New Qios.DevSuite.Components.QBalloon
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.btnClose = New Qios.DevSuite.Components.QButton
        Me.btnUpdate = New Qios.DevSuite.Components.QButton
        Me.btnCancel = New Qios.DevSuite.Components.QButton
        Me.btnDelete = New Qios.DevSuite.Components.QButton
        Me.btnSave = New Qios.DevSuite.Components.QButton
        Me.txtCariSuplier = New Qios.DevSuite.Components.QButton
        Me.txtTotal_beli = New System.Windows.Forms.TextBox
        Me.lvPembelian = New System.Windows.Forms.ListView
        Me.Kd_brg = New System.Windows.Forms.ColumnHeader("(none)")
        Me.Nm_brg = New System.Windows.Forms.ColumnHeader
        Me.Satuan = New System.Windows.Forms.ColumnHeader
        Me.Jumlah = New System.Windows.Forms.ColumnHeader
        Me.Hrg_beli = New System.Windows.Forms.ColumnHeader
        Me.Hrg_jual = New System.Windows.Forms.ColumnHeader
        Me.Sub_total = New System.Windows.Forms.ColumnHeader
        Me.txtUserId = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtTotalSelisih = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtGrandtotal = New System.Windows.Forms.TextBox
        Me.txttotal_jual = New System.Windows.Forms.TextBox
        Me.txtTotalItem = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCariBarang = New Qios.DevSuite.Components.QButton
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtPersen = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtHrg_Jual_satauan = New System.Windows.Forms.TextBox
        Me.txtHrg_Beli_Satuan = New System.Windows.Forms.TextBox
        Me.txtJumlah = New System.Windows.Forms.TextBox
        Me.txtHrg_Beli = New System.Windows.Forms.TextBox
        Me.txtHrg_Jual = New System.Windows.Forms.TextBox
        Me.txtKd_barang = New System.Windows.Forms.TextBox
        Me.txtSatuan = New System.Windows.Forms.TextBox
        Me.txtNm_barang = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.txtNm_Siplier = New System.Windows.Forms.TextBox
        Me.txtKd_Suplier = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNo_pembelian = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.QPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QBalloon1
        '
        Me.QBalloon1.Configuration.BalloonWindowAppearance.GradientAngle = 2
        '
        'QPanel1
        '
        Me.QPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer)), False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.btnClose)
        Me.QPanel1.Controls.Add(Me.btnUpdate)
        Me.QPanel1.Controls.Add(Me.btnCancel)
        Me.QPanel1.Controls.Add(Me.btnDelete)
        Me.QPanel1.Controls.Add(Me.btnSave)
        Me.QPanel1.Controls.Add(Me.txtCariSuplier)
        Me.QPanel1.Controls.Add(Me.txtTotal_beli)
        Me.QPanel1.Controls.Add(Me.lvPembelian)
        Me.QPanel1.Controls.Add(Me.txtUserId)
        Me.QPanel1.Controls.Add(Me.Label16)
        Me.QPanel1.Controls.Add(Me.txtTotalSelisih)
        Me.QPanel1.Controls.Add(Me.Label15)
        Me.QPanel1.Controls.Add(Me.txtGrandtotal)
        Me.QPanel1.Controls.Add(Me.txttotal_jual)
        Me.QPanel1.Controls.Add(Me.txtTotalItem)
        Me.QPanel1.Controls.Add(Me.Label9)
        Me.QPanel1.Controls.Add(Me.Panel1)
        Me.QPanel1.Controls.Add(Me.txtAlamat)
        Me.QPanel1.Controls.Add(Me.txtNm_Siplier)
        Me.QPanel1.Controls.Add(Me.txtKd_Suplier)
        Me.QPanel1.Controls.Add(Me.Label4)
        Me.QPanel1.Controls.Add(Me.Label3)
        Me.QPanel1.Controls.Add(Me.Label1)
        Me.QPanel1.Controls.Add(Me.txtNo_pembelian)
        Me.QPanel1.Controls.Add(Me.Label2)
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1291, 624)
        Me.QPanel1.TabIndex = 101
        Me.QPanel1.Text = "QPanel1"
        '
        'btnClose
        '
        Me.btnClose.Image = Nothing
        Me.btnClose.Location = New System.Drawing.Point(1192, 242)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 29)
        Me.btnClose.TabIndex = 130
        Me.btnClose.Text = "Close"
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Nothing
        Me.btnUpdate.Location = New System.Drawing.Point(943, 242)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 29)
        Me.btnUpdate.TabIndex = 129
        Me.btnUpdate.Text = "Update"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(1109, 242)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 29)
        Me.btnCancel.TabIndex = 128
        Me.btnCancel.Text = "Cancel"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(1026, 242)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 29)
        Me.btnDelete.TabIndex = 127
        Me.btnDelete.Text = "Delete"
        '
        'btnSave
        '
        Me.btnSave.Image = Nothing
        Me.btnSave.Location = New System.Drawing.Point(860, 242)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 29)
        Me.btnSave.TabIndex = 126
        Me.btnSave.Text = "Save"
        '
        'txtCariSuplier
        '
        Me.txtCariSuplier.Image = Nothing
        Me.txtCariSuplier.Location = New System.Drawing.Point(501, 59)
        Me.txtCariSuplier.Name = "txtCariSuplier"
        Me.txtCariSuplier.Size = New System.Drawing.Size(40, 23)
        Me.txtCariSuplier.TabIndex = 125
        Me.txtCariSuplier.Text = "Cari"
        '
        'txtTotal_beli
        '
        Me.txtTotal_beli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal_beli.Location = New System.Drawing.Point(799, 547)
        Me.txtTotal_beli.Name = "txtTotal_beli"
        Me.txtTotal_beli.ReadOnly = True
        Me.txtTotal_beli.Size = New System.Drawing.Size(130, 21)
        Me.txtTotal_beli.TabIndex = 121
        Me.txtTotal_beli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lvPembelian
        '
        Me.lvPembelian.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvPembelian.BackColor = System.Drawing.SystemColors.Info
        Me.lvPembelian.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Kd_brg, Me.Nm_brg, Me.Satuan, Me.Jumlah, Me.Hrg_beli, Me.Hrg_jual, Me.Sub_total})
        Me.lvPembelian.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lvPembelian.FullRowSelect = True
        Me.lvPembelian.GridLines = True
        Me.lvPembelian.HoverSelection = True
        Me.lvPembelian.Location = New System.Drawing.Point(22, 277)
        Me.lvPembelian.Name = "lvPembelian"
        Me.lvPembelian.Size = New System.Drawing.Size(1246, 264)
        Me.lvPembelian.TabIndex = 120
        Me.lvPembelian.UseCompatibleStateImageBehavior = False
        Me.lvPembelian.View = System.Windows.Forms.View.Details
        '
        'Kd_brg
        '
        Me.Kd_brg.Text = "Kode Barang"
        Me.Kd_brg.Width = 160
        '
        'Nm_brg
        '
        Me.Nm_brg.Text = "Nama Barang"
        Me.Nm_brg.Width = 382
        '
        'Satuan
        '
        Me.Satuan.Text = "Satuan"
        Me.Satuan.Width = 110
        '
        'Jumlah
        '
        Me.Jumlah.Text = "Jumlah"
        Me.Jumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Jumlah.Width = 104
        '
        'Hrg_beli
        '
        Me.Hrg_beli.Text = "Harga  Beli"
        Me.Hrg_beli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Hrg_beli.Width = 147
        '
        'Hrg_jual
        '
        Me.Hrg_jual.Text = "Harga Jual"
        Me.Hrg_jual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Hrg_jual.Width = 143
        '
        'Sub_total
        '
        Me.Sub_total.Text = "Sub Total Pembelian"
        Me.Sub_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Sub_total.Width = 192
        '
        'txtUserId
        '
        Me.txtUserId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserId.Location = New System.Drawing.Point(1152, 103)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.ReadOnly = True
        Me.txtUserId.Size = New System.Drawing.Size(115, 21)
        Me.txtUserId.TabIndex = 119
        Me.txtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(1039, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 15)
        Me.Label16.TabIndex = 118
        Me.Label16.Text = "User"
        '
        'txtTotalSelisih
        '
        Me.txtTotalSelisih.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSelisih.Location = New System.Drawing.Point(799, 574)
        Me.txtTotalSelisih.Name = "txtTotalSelisih"
        Me.txtTotalSelisih.ReadOnly = True
        Me.txtTotalSelisih.Size = New System.Drawing.Size(130, 21)
        Me.txtTotalSelisih.TabIndex = 115
        Me.txtTotalSelisih.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(591, 577)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 15)
        Me.Label15.TabIndex = 114
        Me.Label15.Text = "Selisih"
        '
        'txtGrandtotal
        '
        Me.txtGrandtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGrandtotal.Location = New System.Drawing.Point(1096, 547)
        Me.txtGrandtotal.Name = "txtGrandtotal"
        Me.txtGrandtotal.ReadOnly = True
        Me.txtGrandtotal.Size = New System.Drawing.Size(171, 21)
        Me.txtGrandtotal.TabIndex = 113
        Me.txtGrandtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txttotal_jual
        '
        Me.txttotal_jual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal_jual.Location = New System.Drawing.Point(938, 547)
        Me.txttotal_jual.Name = "txttotal_jual"
        Me.txttotal_jual.ReadOnly = True
        Me.txttotal_jual.Size = New System.Drawing.Size(131, 21)
        Me.txttotal_jual.TabIndex = 112
        Me.txttotal_jual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalItem
        '
        Me.txtTotalItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalItem.Location = New System.Drawing.Point(680, 547)
        Me.txtTotalItem.Name = "txtTotalItem"
        Me.txtTotalItem.ReadOnly = True
        Me.txtTotalItem.Size = New System.Drawing.Size(95, 21)
        Me.txtTotalItem.TabIndex = 111
        Me.txtTotalItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(591, 555)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Total"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnCariBarang)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtPersen)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtHrg_Jual_satauan)
        Me.Panel1.Controls.Add(Me.txtHrg_Beli_Satuan)
        Me.Panel1.Controls.Add(Me.txtJumlah)
        Me.Panel1.Controls.Add(Me.txtHrg_Beli)
        Me.Panel1.Controls.Add(Me.txtHrg_Jual)
        Me.Panel1.Controls.Add(Me.txtKd_barang)
        Me.Panel1.Controls.Add(Me.txtSatuan)
        Me.Panel1.Controls.Add(Me.txtNm_barang)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(21, 136)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1246, 100)
        Me.Panel1.TabIndex = 109
        '
        'btnCariBarang
        '
        Me.btnCariBarang.AccessibleDescription = ""
        Me.btnCariBarang.Image = Nothing
        Me.btnCariBarang.Location = New System.Drawing.Point(447, 3)
        Me.btnCariBarang.Name = "btnCariBarang"
        Me.btnCariBarang.Size = New System.Drawing.Size(40, 23)
        Me.btnCariBarang.TabIndex = 101
        Me.btnCariBarang.Text = "Cari"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(980, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 20)
        Me.Label14.TabIndex = 96
        Me.Label14.Text = "%"
        '
        'txtPersen
        '
        Me.txtPersen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPersen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersen.Location = New System.Drawing.Point(1009, 6)
        Me.txtPersen.Name = "txtPersen"
        Me.txtPersen.ReadOnly = True
        Me.txtPersen.Size = New System.Drawing.Size(67, 26)
        Me.txtPersen.TabIndex = 95
        Me.txtPersen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(978, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 20)
        Me.Label13.TabIndex = 94
        Me.Label13.Text = "@"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(978, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(25, 20)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "@"
        '
        'txtHrg_Jual_satauan
        '
        Me.txtHrg_Jual_satauan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHrg_Jual_satauan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHrg_Jual_satauan.Location = New System.Drawing.Point(1009, 67)
        Me.txtHrg_Jual_satauan.Name = "txtHrg_Jual_satauan"
        Me.txtHrg_Jual_satauan.ReadOnly = True
        Me.txtHrg_Jual_satauan.Size = New System.Drawing.Size(215, 26)
        Me.txtHrg_Jual_satauan.TabIndex = 92
        Me.txtHrg_Jual_satauan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHrg_Beli_Satuan
        '
        Me.txtHrg_Beli_Satuan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHrg_Beli_Satuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHrg_Beli_Satuan.Location = New System.Drawing.Point(1009, 38)
        Me.txtHrg_Beli_Satuan.Name = "txtHrg_Beli_Satuan"
        Me.txtHrg_Beli_Satuan.ReadOnly = True
        Me.txtHrg_Beli_Satuan.Size = New System.Drawing.Size(215, 26)
        Me.txtHrg_Beli_Satuan.TabIndex = 91
        Me.txtHrg_Beli_Satuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtJumlah
        '
        Me.txtJumlah.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtJumlah.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJumlah.Location = New System.Drawing.Point(692, 6)
        Me.txtJumlah.Name = "txtJumlah"
        Me.txtJumlah.Size = New System.Drawing.Size(215, 26)
        Me.txtJumlah.TabIndex = 90
        Me.txtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHrg_Beli
        '
        Me.txtHrg_Beli.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHrg_Beli.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHrg_Beli.Location = New System.Drawing.Point(692, 38)
        Me.txtHrg_Beli.Name = "txtHrg_Beli"
        Me.txtHrg_Beli.Size = New System.Drawing.Size(215, 26)
        Me.txtHrg_Beli.TabIndex = 89
        Me.txtHrg_Beli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHrg_Jual
        '
        Me.txtHrg_Jual.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHrg_Jual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHrg_Jual.Location = New System.Drawing.Point(692, 67)
        Me.txtHrg_Jual.Name = "txtHrg_Jual"
        Me.txtHrg_Jual.Size = New System.Drawing.Size(215, 26)
        Me.txtHrg_Jual.TabIndex = 88
        Me.txtHrg_Jual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtKd_barang
        '
        Me.txtKd_barang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKd_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_barang.Location = New System.Drawing.Point(152, 3)
        Me.txtKd_barang.Name = "txtKd_barang"
        Me.txtKd_barang.Size = New System.Drawing.Size(289, 26)
        Me.txtKd_barang.TabIndex = 79
        '
        'txtSatuan
        '
        Me.txtSatuan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSatuan.Location = New System.Drawing.Point(152, 67)
        Me.txtSatuan.Name = "txtSatuan"
        Me.txtSatuan.ReadOnly = True
        Me.txtSatuan.Size = New System.Drawing.Size(289, 26)
        Me.txtSatuan.TabIndex = 80
        '
        'txtNm_barang
        '
        Me.txtNm_barang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNm_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNm_barang.Location = New System.Drawing.Point(152, 35)
        Me.txtNm_barang.Name = "txtNm_barang"
        Me.txtNm_barang.ReadOnly = True
        Me.txtNm_barang.Size = New System.Drawing.Size(402, 26)
        Me.txtNm_barang.TabIndex = 78
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(583, 73)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Harga Jual"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(583, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 20)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Harga Beli"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(5, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Nama Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(583, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 20)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Kode Barang"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 20)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Satuan"
        '
        'txtAlamat
        '
        Me.txtAlamat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(731, 29)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.ReadOnly = True
        Me.txtAlamat.Size = New System.Drawing.Size(536, 68)
        Me.txtAlamat.TabIndex = 108
        '
        'txtNm_Siplier
        '
        Me.txtNm_Siplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNm_Siplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNm_Siplier.Location = New System.Drawing.Point(195, 92)
        Me.txtNm_Siplier.Name = "txtNm_Siplier"
        Me.txtNm_Siplier.ReadOnly = True
        Me.txtNm_Siplier.Size = New System.Drawing.Size(500, 26)
        Me.txtNm_Siplier.TabIndex = 107
        '
        'txtKd_Suplier
        '
        Me.txtKd_Suplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKd_Suplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_Suplier.Location = New System.Drawing.Point(195, 59)
        Me.txtKd_Suplier.Name = "txtKd_Suplier"
        Me.txtKd_Suplier.Size = New System.Drawing.Size(289, 26)
        Me.txtKd_Suplier.TabIndex = 106
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(631, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(37, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Nama Suplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(38, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Kode Suplier"
        '
        'txtNo_pembelian
        '
        Me.txtNo_pembelian.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNo_pembelian.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNo_pembelian.Location = New System.Drawing.Point(195, 27)
        Me.txtNo_pembelian.Name = "txtNo_pembelian"
        Me.txtNo_pembelian.ReadOnly = True
        Me.txtNo_pembelian.Size = New System.Drawing.Size(289, 26)
        Me.txtNo_pembelian.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(37, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "No Pembelian"
        '
        'frmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(1291, 624)
        Me.ControlBox = False
        Me.Controls.Add(Me.QPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "frmPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembelian"
        Me.QPanel1.ResumeLayout(False)
        Me.QPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QBalloon1 As Qios.DevSuite.Components.QBalloon
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents txtCariSuplier As Qios.DevSuite.Components.QButton
    Friend WithEvents txtTotal_beli As System.Windows.Forms.TextBox
    Friend WithEvents lvPembelian As System.Windows.Forms.ListView
    Friend WithEvents Kd_brg As System.Windows.Forms.ColumnHeader
    Friend WithEvents Nm_brg As System.Windows.Forms.ColumnHeader
    Friend WithEvents Satuan As System.Windows.Forms.ColumnHeader
    Friend WithEvents Jumlah As System.Windows.Forms.ColumnHeader
    Friend WithEvents Hrg_beli As System.Windows.Forms.ColumnHeader
    Friend WithEvents Hrg_jual As System.Windows.Forms.ColumnHeader
    Friend WithEvents Sub_total As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSelisih As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtGrandtotal As System.Windows.Forms.TextBox
    Friend WithEvents txttotal_jual As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalItem As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCariBarang As Qios.DevSuite.Components.QButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtPersen As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtHrg_Jual_satauan As System.Windows.Forms.TextBox
    Friend WithEvents txtHrg_Beli_Satuan As System.Windows.Forms.TextBox
    Friend WithEvents txtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents txtHrg_Beli As System.Windows.Forms.TextBox
    Friend WithEvents txtHrg_Jual As System.Windows.Forms.TextBox
    Friend WithEvents txtKd_barang As System.Windows.Forms.TextBox
    Friend WithEvents txtSatuan As System.Windows.Forms.TextBox
    Friend WithEvents txtNm_barang As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNm_Siplier As System.Windows.Forms.TextBox
    Friend WithEvents txtKd_Suplier As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNo_pembelian As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnClose As Qios.DevSuite.Components.QButton
    Friend WithEvents btnUpdate As Qios.DevSuite.Components.QButton
    Friend WithEvents btnCancel As Qios.DevSuite.Components.QButton
    Friend WithEvents btnDelete As Qios.DevSuite.Components.QButton
    Friend WithEvents btnSave As Qios.DevSuite.Components.QButton
End Class
