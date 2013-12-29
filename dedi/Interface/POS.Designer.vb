<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class POS
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.QBalloon1 = New Qios.DevSuite.Components.QBalloon
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.btnCari = New Qios.DevSuite.Components.QButton
        Me.btnTutup = New Qios.DevSuite.Components.QButton
        Me.txtKembali = New System.Windows.Forms.TextBox
        Me.txtTotalDiskon = New System.Windows.Forms.TextBox
        Me.txtBayar = New System.Windows.Forms.TextBox
        Me.txtTotalKotor = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.r = New System.Windows.Forms.Label
        Me.t = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblKasir = New System.Windows.Forms.Label
        Me.lblBesar = New System.Windows.Forms.Label
        Me.lblNo = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.grdPos = New System.Windows.Forms.DataGridView
        Me.kd_brg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nm_brg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Harga = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Diskon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DiskonRp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtKd_brg = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.QPanel1.SuspendLayout()
        CType(Me.grdPos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Blue, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.btnCari)
        Me.QPanel1.Controls.Add(Me.btnTutup)
        Me.QPanel1.Controls.Add(Me.txtKembali)
        Me.QPanel1.Controls.Add(Me.txtTotalDiskon)
        Me.QPanel1.Controls.Add(Me.txtBayar)
        Me.QPanel1.Controls.Add(Me.txtTotalKotor)
        Me.QPanel1.Controls.Add(Me.Label4)
        Me.QPanel1.Controls.Add(Me.r)
        Me.QPanel1.Controls.Add(Me.t)
        Me.QPanel1.Controls.Add(Me.Label8)
        Me.QPanel1.Controls.Add(Me.Label7)
        Me.QPanel1.Controls.Add(Me.lblKasir)
        Me.QPanel1.Controls.Add(Me.lblBesar)
        Me.QPanel1.Controls.Add(Me.lblNo)
        Me.QPanel1.Controls.Add(Me.Label6)
        Me.QPanel1.Controls.Add(Me.grdPos)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.Label1)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1348, 712)
        Me.QPanel1.TabIndex = 0
        Me.QPanel1.Text = "QPanel1"
        '
        'btnCari
        '
        Me.btnCari.Image = Nothing
        Me.btnCari.Location = New System.Drawing.Point(508, 159)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(41, 23)
        Me.btnCari.TabIndex = 56
        Me.btnCari.Text = "Cari"
        '
        'btnTutup
        '
        Me.btnTutup.Image = Nothing
        Me.btnTutup.Location = New System.Drawing.Point(882, 627)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(75, 23)
        Me.btnTutup.TabIndex = 55
        Me.btnTutup.Text = "Tutup Kasir"
        '
        'txtKembali
        '
        Me.txtKembali.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKembali.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtKembali.Location = New System.Drawing.Point(1083, 624)
        Me.txtKembali.Name = "txtKembali"
        Me.txtKembali.ReadOnly = True
        Me.txtKembali.Size = New System.Drawing.Size(189, 26)
        Me.txtKembali.TabIndex = 54
        Me.txtKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDiskon
        '
        Me.txtTotalDiskon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDiskon.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtTotalDiskon.Location = New System.Drawing.Point(1083, 556)
        Me.txtTotalDiskon.Name = "txtTotalDiskon"
        Me.txtTotalDiskon.ReadOnly = True
        Me.txtTotalDiskon.Size = New System.Drawing.Size(189, 26)
        Me.txtTotalDiskon.TabIndex = 53
        Me.txtTotalDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBayar
        '
        Me.txtBayar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBayar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtBayar.Location = New System.Drawing.Point(1083, 590)
        Me.txtBayar.MaxLength = 10
        Me.txtBayar.Name = "txtBayar"
        Me.txtBayar.Size = New System.Drawing.Size(189, 26)
        Me.txtBayar.TabIndex = 52
        Me.txtBayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalKotor
        '
        Me.txtTotalKotor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalKotor.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtTotalKotor.Location = New System.Drawing.Point(1083, 522)
        Me.txtTotalKotor.Name = "txtTotalKotor"
        Me.txtTotalKotor.ReadOnly = True
        Me.txtTotalKotor.Size = New System.Drawing.Size(189, 26)
        Me.txtTotalKotor.TabIndex = 51
        Me.txtTotalKotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(972, 629)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 21)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Kembali"
        '
        'r
        '
        Me.r.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.r.AutoSize = True
        Me.r.BackColor = System.Drawing.Color.Transparent
        Me.r.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.r.ForeColor = System.Drawing.Color.White
        Me.r.Location = New System.Drawing.Point(972, 595)
        Me.r.Name = "r"
        Me.r.Size = New System.Drawing.Size(49, 21)
        Me.r.TabIndex = 49
        Me.r.Text = "Bayar"
        '
        't
        '
        Me.t.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.t.AutoSize = True
        Me.t.BackColor = System.Drawing.Color.Transparent
        Me.t.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t.ForeColor = System.Drawing.Color.White
        Me.t.Location = New System.Drawing.Point(972, 561)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(71, 21)
        Me.t.TabIndex = 48
        Me.t.Text = "Discount"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(972, 527)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 21)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Total"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 60.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(41, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(508, 97)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Dedi Accessories"
        '
        'lblKasir
        '
        Me.lblKasir.AutoSize = True
        Me.lblKasir.BackColor = System.Drawing.Color.Transparent
        Me.lblKasir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKasir.ForeColor = System.Drawing.Color.White
        Me.lblKasir.Location = New System.Drawing.Point(1040, 90)
        Me.lblKasir.Name = "lblKasir"
        Me.lblKasir.Size = New System.Drawing.Size(16, 24)
        Me.lblKasir.TabIndex = 40
        Me.lblKasir.Text = "-"
        '
        'lblBesar
        '
        Me.lblBesar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBesar.AutoSize = True
        Me.lblBesar.BackColor = System.Drawing.Color.Transparent
        Me.lblBesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBesar.ForeColor = System.Drawing.Color.White
        Me.lblBesar.Location = New System.Drawing.Point(908, 132)
        Me.lblBesar.Name = "lblBesar"
        Me.lblBesar.Size = New System.Drawing.Size(244, 59)
        Me.lblBesar.TabIndex = 39
        Me.lblBesar.Text = "Rp. 00,00"
        '
        'lblNo
        '
        Me.lblNo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNo.AutoSize = True
        Me.lblNo.BackColor = System.Drawing.Color.Transparent
        Me.lblNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNo.ForeColor = System.Drawing.Color.White
        Me.lblNo.Location = New System.Drawing.Point(103, 120)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(119, 24)
        Me.lblNo.TabIndex = 38
        Me.lblNo.Text = "NoPenjualan"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(53, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 15)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "No :"
        '
        'grdPos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.grdPos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdPos.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdPos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.grdPos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_brg, Me.nm_brg, Me.Harga, Me.Jumlah, Me.Diskon, Me.DiskonRp, Me.Total})
        Me.grdPos.Location = New System.Drawing.Point(-1, 243)
        Me.grdPos.Name = "grdPos"
        Me.grdPos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdPos.Size = New System.Drawing.Size(1348, 266)
        Me.grdPos.TabIndex = 35
        '
        'kd_brg
        '
        Me.kd_brg.HeaderText = "Kode Barang"
        Me.kd_brg.Name = "kd_brg"
        Me.kd_brg.ReadOnly = True
        Me.kd_brg.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.kd_brg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.kd_brg.Width = 250
        '
        'nm_brg
        '
        Me.nm_brg.HeaderText = "Nama Barang"
        Me.nm_brg.Name = "nm_brg"
        Me.nm_brg.ReadOnly = True
        Me.nm_brg.Width = 423
        '
        'Harga
        '
        Me.Harga.HeaderText = "Harga"
        Me.Harga.Name = "Harga"
        Me.Harga.ReadOnly = True
        Me.Harga.Width = 160
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 70
        '
        'Diskon
        '
        Me.Diskon.HeaderText = "Diskon (%)"
        Me.Diskon.Name = "Diskon"
        Me.Diskon.ReadOnly = True
        Me.Diskon.Width = 50
        '
        'DiskonRp
        '
        Me.DiskonRp.HeaderText = "Diskon (Rp)"
        Me.DiskonRp.Name = "DiskonRp"
        Me.DiskonRp.ReadOnly = True
        Me.DiskonRp.Width = 150
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtKd_brg)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(45, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(428, 48)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kode Barang"
        '
        'txtKd_brg
        '
        Me.txtKd_brg.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKd_brg.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_brg.Location = New System.Drawing.Point(14, 19)
        Me.txtKd_brg.Name = "txtKd_brg"
        Me.txtKd_brg.Size = New System.Drawing.Size(407, 23)
        Me.txtKd_brg.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(966, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Kasir :"
        '
        'POS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1348, 712)
        Me.Controls.Add(Me.QPanel1)
        Me.MaximizeBox = False
        Me.Name = "POS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.QPanel1.ResumeLayout(False)
        Me.QPanel1.PerformLayout()
        CType(Me.grdPos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QBalloon1 As Qios.DevSuite.Components.QBalloon
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblKasir As System.Windows.Forms.Label
    Friend WithEvents lblBesar As System.Windows.Forms.Label
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grdPos As System.Windows.Forms.DataGridView
    Friend WithEvents kd_brg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nm_brg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Harga As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Diskon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DiskonRp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtKd_brg As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents r As System.Windows.Forms.Label
    Friend WithEvents t As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtKembali As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDiskon As System.Windows.Forms.TextBox
    Friend WithEvents txtBayar As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalKotor As System.Windows.Forms.TextBox
    Friend WithEvents btnTutup As Qios.DevSuite.Components.QButton
    Friend WithEvents btnCari As Qios.DevSuite.Components.QButton
End Class
