<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmStokOpname
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnPrint = New Qios.DevSuite.Components.QButton
        Me.btnSesauikan = New Qios.DevSuite.Components.QButton
        Me.lblTtlHarga = New System.Windows.Forms.Label
        Me.lblTtlStok = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdOpname1 = New System.Windows.Forms.DataGridView
        Me.kd_brg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nm_brg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Satuan = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hrg_Jual = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.stok = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hrg_komp = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Stok_Fisik = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hrg_fisik = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Selisih_stok = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.selisih_hrg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.QPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdOpname1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Lime, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.Label1)
        Me.QPanel1.Controls.Add(Me.grdOpname1)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1289, 619)
        Me.QPanel1.TabIndex = 0
        Me.QPanel1.Text = "QPanel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnSesauikan)
        Me.GroupBox1.Controls.Add(Me.lblTtlHarga)
        Me.GroupBox1.Controls.Add(Me.lblTtlStok)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(655, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(621, 159)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rekap"
        '
        'btnPrint
        '
        Me.btnPrint.ColorScheme.ButtonBackground1.SetColor("VistaBlack", System.Drawing.Color.Lime, False)
        Me.btnPrint.ColorScheme.ButtonBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.btnPrint.ColorScheme.ButtonText.SetColor("VistaBlack", System.Drawing.Color.Lime, False)
        Me.btnPrint.Image = Nothing
        Me.btnPrint.Location = New System.Drawing.Point(32, 104)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(129, 39)
        Me.btnPrint.TabIndex = 10
        Me.btnPrint.Text = "Print"
        '
        'btnSesauikan
        '
        Me.btnSesauikan.ColorScheme.ButtonBackground1.SetColor("VistaBlack", System.Drawing.Color.Lime, False)
        Me.btnSesauikan.ColorScheme.ButtonBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.btnSesauikan.ColorScheme.ButtonText.SetColor("VistaBlack", System.Drawing.Color.Lime, False)
        Me.btnSesauikan.Image = Nothing
        Me.btnSesauikan.Location = New System.Drawing.Point(188, 104)
        Me.btnSesauikan.Name = "btnSesauikan"
        Me.btnSesauikan.Size = New System.Drawing.Size(129, 39)
        Me.btnSesauikan.TabIndex = 9
        Me.btnSesauikan.Text = "Sesuaikan"
        '
        'lblTtlHarga
        '
        Me.lblTtlHarga.AutoSize = True
        Me.lblTtlHarga.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlHarga.Location = New System.Drawing.Point(270, 66)
        Me.lblTtlHarga.Name = "lblTtlHarga"
        Me.lblTtlHarga.Size = New System.Drawing.Size(23, 25)
        Me.lblTtlHarga.TabIndex = 8
        Me.lblTtlHarga.Text = "0"
        '
        'lblTtlStok
        '
        Me.lblTtlStok.AutoSize = True
        Me.lblTtlStok.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTtlStok.Location = New System.Drawing.Point(270, 35)
        Me.lblTtlStok.Name = "lblTtlStok"
        Me.lblTtlStok.Size = New System.Drawing.Size(23, 25)
        Me.lblTtlStok.TabIndex = 7
        Me.lblTtlStok.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Total Selisih Harga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total Selisih Stok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 79)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Stok Opname"
        '
        'grdOpname1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grdOpname1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdOpname1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdOpname1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.kd_brg, Me.Nm_brg, Me.Satuan, Me.Hrg_Jual, Me.stok, Me.hrg_komp, Me.Stok_Fisik, Me.hrg_fisik, Me.Selisih_stok, Me.selisih_hrg})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdOpname1.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdOpname1.GridColor = System.Drawing.Color.Blue
        Me.grdOpname1.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.grdOpname1.Location = New System.Drawing.Point(11, 176)
        Me.grdOpname1.Name = "grdOpname1"
        Me.grdOpname1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdOpname1.Size = New System.Drawing.Size(1265, 430)
        Me.grdOpname1.TabIndex = 0
        '
        'kd_brg
        '
        Me.kd_brg.HeaderText = "Kode Barang"
        Me.kd_brg.Name = "kd_brg"
        Me.kd_brg.ReadOnly = True
        Me.kd_brg.Width = 150
        '
        'Nm_brg
        '
        Me.Nm_brg.HeaderText = "Nama Barang"
        Me.Nm_brg.Name = "Nm_brg"
        Me.Nm_brg.ReadOnly = True
        Me.Nm_brg.Width = 300
        '
        'Satuan
        '
        Me.Satuan.FillWeight = 150.0!
        Me.Satuan.HeaderText = "Satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.ReadOnly = True
        Me.Satuan.Width = 90
        '
        'Hrg_Jual
        '
        Me.Hrg_Jual.HeaderText = "Harga Jual"
        Me.Hrg_Jual.Name = "Hrg_Jual"
        Me.Hrg_Jual.ReadOnly = True
        Me.Hrg_Jual.Width = 130
        '
        'stok
        '
        Me.stok.HeaderText = "Stok dlm Komputer"
        Me.stok.Name = "stok"
        Me.stok.ReadOnly = True
        Me.stok.Width = 70
        '
        'hrg_komp
        '
        Me.hrg_komp.HeaderText = "Ttl hrg dlm Komp"
        Me.hrg_komp.Name = "hrg_komp"
        Me.hrg_komp.ReadOnly = True
        Me.hrg_komp.Width = 125
        '
        'Stok_Fisik
        '
        Me.Stok_Fisik.FillWeight = 80.0!
        Me.Stok_Fisik.HeaderText = "Stok Fisik"
        Me.Stok_Fisik.Name = "Stok_Fisik"
        Me.Stok_Fisik.Width = 50
        '
        'hrg_fisik
        '
        Me.hrg_fisik.HeaderText = "Total Hrg Fisik"
        Me.hrg_fisik.Name = "hrg_fisik"
        Me.hrg_fisik.ReadOnly = True
        Me.hrg_fisik.Width = 125
        '
        'Selisih_stok
        '
        Me.Selisih_stok.FillWeight = 80.0!
        Me.Selisih_stok.HeaderText = "Selisih Stok"
        Me.Selisih_stok.Name = "Selisih_stok"
        Me.Selisih_stok.ReadOnly = True
        Me.Selisih_stok.Width = 50
        '
        'selisih_hrg
        '
        Me.selisih_hrg.HeaderText = "Selisih Harga"
        Me.selisih_hrg.Name = "selisih_hrg"
        Me.selisih_hrg.ReadOnly = True
        Me.selisih_hrg.Width = 130
        '
        'FrmStokOpname
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 619)
        Me.Controls.Add(Me.QPanel1)
        Me.MaximizeBox = False
        Me.Name = "FrmStokOpname"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmStokOpname"
        Me.QPanel1.ResumeLayout(False)
        Me.QPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdOpname1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents grdOpname1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSesauikan As Qios.DevSuite.Components.QButton
    Friend WithEvents lblTtlHarga As System.Windows.Forms.Label
    Friend WithEvents lblTtlStok As System.Windows.Forms.Label
    Friend WithEvents kd_brg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nm_brg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Satuan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hrg_Jual As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hrg_komp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Stok_Fisik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hrg_fisik As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Selisih_stok As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents selisih_hrg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Qios.DevSuite.Components.QButton
End Class
