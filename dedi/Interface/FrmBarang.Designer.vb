<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBarang
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.txtKd_barang = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCariJenis = New System.Windows.Forms.TextBox
        Me.txtCariKode = New System.Windows.Forms.TextBox
        Me.txtCariBrg = New System.Windows.Forms.TextBox
        Me.grdBarang = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtMode = New System.Windows.Forms.TextBox
        Me.txtWarna = New System.Windows.Forms.TextBox
        Me.cboSatuan = New System.Windows.Forms.ComboBox
        Me.cboJns_Brg = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNm_brg = New System.Windows.Forms.TextBox
        Me.txtKd_jns = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.QPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Blue, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.txtKd_barang)
        Me.QPanel1.Controls.Add(Me.GroupBox2)
        Me.QPanel1.Controls.Add(Me.grdBarang)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.txtMode)
        Me.QPanel1.Controls.Add(Me.txtWarna)
        Me.QPanel1.Controls.Add(Me.cboSatuan)
        Me.QPanel1.Controls.Add(Me.cboJns_Brg)
        Me.QPanel1.Controls.Add(Me.Label6)
        Me.QPanel1.Controls.Add(Me.Label5)
        Me.QPanel1.Controls.Add(Me.Label4)
        Me.QPanel1.Controls.Add(Me.Label3)
        Me.QPanel1.Controls.Add(Me.txtNm_brg)
        Me.QPanel1.Controls.Add(Me.txtKd_jns)
        Me.QPanel1.Controls.Add(Me.Label2)
        Me.QPanel1.Controls.Add(Me.Label1)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1265, 630)
        Me.QPanel1.TabIndex = 32
        Me.QPanel1.Text = "QPanel1"
        '
        'txtKd_barang
        '
        Me.txtKd_barang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_barang.Location = New System.Drawing.Point(657, 24)
        Me.txtKd_barang.MaxLength = 15
        Me.txtKd_barang.Name = "txtKd_barang"
        Me.txtKd_barang.ReadOnly = True
        Me.txtKd_barang.Size = New System.Drawing.Size(323, 29)
        Me.txtKd_barang.TabIndex = 47
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCariJenis)
        Me.GroupBox2.Controls.Add(Me.txtCariKode)
        Me.GroupBox2.Controls.Add(Me.txtCariBrg)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(11, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(784, 65)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Berdasarkan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(527, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 17)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Jns Brg"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(196, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Nm Brg"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(9, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Kode"
        '
        'txtCariJenis
        '
        Me.txtCariJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariJenis.Location = New System.Drawing.Point(601, 24)
        Me.txtCariJenis.Name = "txtCariJenis"
        Me.txtCariJenis.Size = New System.Drawing.Size(177, 29)
        Me.txtCariJenis.TabIndex = 36
        '
        'txtCariKode
        '
        Me.txtCariKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariKode.Location = New System.Drawing.Point(56, 24)
        Me.txtCariKode.Name = "txtCariKode"
        Me.txtCariKode.Size = New System.Drawing.Size(134, 29)
        Me.txtCariKode.TabIndex = 35
        '
        'txtCariBrg
        '
        Me.txtCariBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariBrg.Location = New System.Drawing.Point(257, 24)
        Me.txtCariBrg.Name = "txtCariBrg"
        Me.txtCariBrg.Size = New System.Drawing.Size(264, 29)
        Me.txtCariBrg.TabIndex = 34
        '
        'grdBarang
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red
        Me.grdBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdBarang.BackgroundColor = System.Drawing.Color.White
        Me.grdBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grdBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBarang.Location = New System.Drawing.Point(10, 298)
        Me.grdBarang.Name = "grdBarang"
        Me.grdBarang.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBarang.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdBarang.RowHeadersWidth = 70
        Me.grdBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdBarang.Size = New System.Drawing.Size(1242, 303)
        Me.grdBarang.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(801, 212)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 65)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(361, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(85, 34)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(272, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(85, 34)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(183, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(85, 34)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(94, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 34)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(5, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(85, 34)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtMode
        '
        Me.txtMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMode.Location = New System.Drawing.Point(163, 163)
        Me.txtMode.MaxLength = 15
        Me.txtMode.Name = "txtMode"
        Me.txtMode.Size = New System.Drawing.Size(272, 29)
        Me.txtMode.TabIndex = 43
        '
        'txtWarna
        '
        Me.txtWarna.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWarna.Location = New System.Drawing.Point(708, 161)
        Me.txtWarna.MaxLength = 15
        Me.txtWarna.Name = "txtWarna"
        Me.txtWarna.Size = New System.Drawing.Size(272, 29)
        Me.txtWarna.TabIndex = 42
        '
        'cboSatuan
        '
        Me.cboSatuan.AllowDrop = True
        Me.cboSatuan.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboSatuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSatuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSatuan.FormattingEnabled = True
        Me.cboSatuan.Items.AddRange(New Object() {"PCS", "Lusin"})
        Me.cboSatuan.Location = New System.Drawing.Point(163, 120)
        Me.cboSatuan.Name = "cboSatuan"
        Me.cboSatuan.Size = New System.Drawing.Size(272, 32)
        Me.cboSatuan.TabIndex = 41
        '
        'cboJns_Brg
        '
        Me.cboJns_Brg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboJns_Brg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJns_Brg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJns_Brg.FormattingEnabled = True
        Me.cboJns_Brg.Location = New System.Drawing.Point(163, 24)
        Me.cboJns_Brg.Name = "cboJns_Brg"
        Me.cboJns_Brg.Size = New System.Drawing.Size(272, 32)
        Me.cboJns_Brg.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(19, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 24)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(561, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 24)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Warna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(18, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 24)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Model"
        '
        'txtNm_brg
        '
        Me.txtNm_brg.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNm_brg.Location = New System.Drawing.Point(163, 75)
        Me.txtNm_brg.MaxLength = 40
        Me.txtNm_brg.Name = "txtNm_brg"
        Me.txtNm_brg.Size = New System.Drawing.Size(816, 29)
        Me.txtNm_brg.TabIndex = 35
        '
        'txtKd_jns
        '
        Me.txtKd_jns.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_jns.Location = New System.Drawing.Point(576, 24)
        Me.txtKd_jns.MaxLength = 15
        Me.txtKd_jns.Name = "txtKd_jns"
        Me.txtKd_jns.ReadOnly = True
        Me.txtKd_jns.Size = New System.Drawing.Size(75, 29)
        Me.txtKd_jns.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Jenis Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(450, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Kode Barang"
        '
        'FrmBarang
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1265, 630)
        Me.Controls.Add(Me.QPanel1)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.MaximizeBox = False
        Me.Name = "FrmBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBarang"
        Me.QPanel1.ResumeLayout(False)
        Me.QPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.grdBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCariJenis As System.Windows.Forms.TextBox
    Friend WithEvents txtCariKode As System.Windows.Forms.TextBox
    Friend WithEvents txtCariBrg As System.Windows.Forms.TextBox
    Friend WithEvents grdBarang As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtMode As System.Windows.Forms.TextBox
    Friend WithEvents txtWarna As System.Windows.Forms.TextBox
    Friend WithEvents cboSatuan As System.Windows.Forms.ComboBox
    Friend WithEvents cboJns_Brg As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNm_brg As System.Windows.Forms.TextBox
    Friend WithEvents txtKd_jns As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKd_barang As System.Windows.Forms.TextBox
End Class
