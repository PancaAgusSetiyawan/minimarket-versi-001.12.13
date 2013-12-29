<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuplier
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdKota = New System.Windows.Forms.RadioButton
        Me.rdNama = New System.Windows.Forms.RadioButton
        Me.rdKode = New System.Windows.Forms.RadioButton
        Me.txtCariSuplier = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New Qios.DevSuite.Components.QButton
        Me.btnCancel = New Qios.DevSuite.Components.QButton
        Me.btnDelete = New Qios.DevSuite.Components.QButton
        Me.btnEdit = New Qios.DevSuite.Components.QButton
        Me.btnSave = New Qios.DevSuite.Components.QButton
        Me.GrdSuplier = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.txtTelp = New System.Windows.Forms.TextBox
        Me.txtKota = New System.Windows.Forms.TextBox
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.txtNm_suplier = New System.Windows.Forms.TextBox
        Me.txtKd_suplier = New System.Windows.Forms.TextBox
        Me.QPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GrdSuplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Blue, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.GroupBox2)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.GrdSuplier)
        Me.QPanel1.Controls.Add(Me.Label2)
        Me.QPanel1.Controls.Add(Me.Label3)
        Me.QPanel1.Controls.Add(Me.Label4)
        Me.QPanel1.Controls.Add(Me.Label5)
        Me.QPanel1.Controls.Add(Me.Label6)
        Me.QPanel1.Controls.Add(Me.Label1)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1212, 590)
        Me.QPanel1.TabIndex = 41
        Me.QPanel1.Text = "QPanel1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.rdKota)
        Me.GroupBox2.Controls.Add(Me.rdNama)
        Me.GroupBox2.Controls.Add(Me.rdKode)
        Me.GroupBox2.Controls.Add(Me.txtCariSuplier)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 198)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(679, 65)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Barang"
        '
        'rdKota
        '
        Me.rdKota.AutoSize = True
        Me.rdKota.Location = New System.Drawing.Point(234, 29)
        Me.rdKota.Name = "rdKota"
        Me.rdKota.Size = New System.Drawing.Size(49, 19)
        Me.rdKota.TabIndex = 37
        Me.rdKota.TabStop = True
        Me.rdKota.Text = "Kota"
        Me.rdKota.UseVisualStyleBackColor = True
        '
        'rdNama
        '
        Me.rdNama.AutoSize = True
        Me.rdNama.Location = New System.Drawing.Point(120, 29)
        Me.rdNama.Name = "rdNama"
        Me.rdNama.Size = New System.Drawing.Size(57, 19)
        Me.rdNama.TabIndex = 36
        Me.rdNama.TabStop = True
        Me.rdNama.Text = "Nama"
        Me.rdNama.UseVisualStyleBackColor = True
        '
        'rdKode
        '
        Me.rdKode.AutoSize = True
        Me.rdKode.Location = New System.Drawing.Point(21, 29)
        Me.rdKode.Name = "rdKode"
        Me.rdKode.Size = New System.Drawing.Size(52, 19)
        Me.rdKode.TabIndex = 35
        Me.rdKode.TabStop = True
        Me.rdKode.Text = "Kode"
        Me.rdKode.UseVisualStyleBackColor = True
        '
        'txtCariSuplier
        '
        Me.txtCariSuplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariSuplier.Location = New System.Drawing.Point(323, 19)
        Me.txtCariSuplier.Name = "txtCariSuplier"
        Me.txtCariSuplier.Size = New System.Drawing.Size(332, 29)
        Me.txtCariSuplier.TabIndex = 34
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(696, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 69)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Image = Nothing
        Me.btnClose.Location = New System.Drawing.Point(403, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(90, 36)
        Me.btnClose.TabIndex = 65
        Me.btnClose.Text = "Close"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(304, 22)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 36)
        Me.btnCancel.TabIndex = 64
        Me.btnCancel.Text = "Cancel"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(205, 22)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(90, 36)
        Me.btnDelete.TabIndex = 63
        Me.btnDelete.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.Image = Nothing
        Me.btnEdit.Location = New System.Drawing.Point(106, 22)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(90, 36)
        Me.btnEdit.TabIndex = 62
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.Image = Nothing
        Me.btnSave.Location = New System.Drawing.Point(7, 22)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 36)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "Save"
        '
        'GrdSuplier
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red
        Me.GrdSuplier.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdSuplier.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GrdSuplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdSuplier.Location = New System.Drawing.Point(11, 278)
        Me.GrdSuplier.Name = "GrdSuplier"
        Me.GrdSuplier.ReadOnly = True
        Me.GrdSuplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdSuplier.Size = New System.Drawing.Size(1188, 299)
        Me.GrdSuplier.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 24)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Kode Suplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(738, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 24)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Kota"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(738, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 24)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Telp"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(738, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 24)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 24)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Nama Suplier"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 24)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Alamat"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(814, 160)
        Me.txtEmail.MaxLength = 30
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(386, 29)
        Me.txtEmail.TabIndex = 53
        '
        'txtTelp
        '
        Me.txtTelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelp.Location = New System.Drawing.Point(814, 123)
        Me.txtTelp.MaxLength = 15
        Me.txtTelp.Name = "txtTelp"
        Me.txtTelp.Size = New System.Drawing.Size(386, 29)
        Me.txtTelp.TabIndex = 52
        '
        'txtKota
        '
        Me.txtKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKota.Location = New System.Drawing.Point(814, 86)
        Me.txtKota.MaxLength = 30
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(386, 29)
        Me.txtKota.TabIndex = 51
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(165, 116)
        Me.txtAlamat.MaxLength = 70
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(457, 73)
        Me.txtAlamat.TabIndex = 50
        '
        'txtNm_suplier
        '
        Me.txtNm_suplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNm_suplier.Location = New System.Drawing.Point(165, 77)
        Me.txtNm_suplier.MaxLength = 30
        Me.txtNm_suplier.Name = "txtNm_suplier"
        Me.txtNm_suplier.Size = New System.Drawing.Size(457, 29)
        Me.txtNm_suplier.TabIndex = 49
        '
        'txtKd_suplier
        '
        Me.txtKd_suplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_suplier.Location = New System.Drawing.Point(165, 42)
        Me.txtKd_suplier.MaxLength = 15
        Me.txtKd_suplier.Name = "txtKd_suplier"
        Me.txtKd_suplier.ReadOnly = True
        Me.txtKd_suplier.Size = New System.Drawing.Size(289, 29)
        Me.txtKd_suplier.TabIndex = 43
        '
        'frmSuplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1212, 590)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtTelp)
        Me.Controls.Add(Me.txtKota)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtNm_suplier)
        Me.Controls.Add(Me.txtKd_suplier)
        Me.Controls.Add(Me.QPanel1)
        Me.MaximizeBox = False
        Me.Name = "frmSuplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSuplier"
        Me.QPanel1.ResumeLayout(False)
        Me.QPanel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.GrdSuplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rdKota As System.Windows.Forms.RadioButton
    Friend WithEvents rdNama As System.Windows.Forms.RadioButton
    Friend WithEvents rdKode As System.Windows.Forms.RadioButton
    Friend WithEvents txtCariSuplier As System.Windows.Forms.TextBox
    Friend WithEvents GrdSuplier As System.Windows.Forms.DataGridView
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtKota As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtNm_suplier As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtKd_suplier As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As Qios.DevSuite.Components.QButton
    Friend WithEvents btnCancel As Qios.DevSuite.Components.QButton
    Friend WithEvents btnDelete As Qios.DevSuite.Components.QButton
    Friend WithEvents btnEdit As Qios.DevSuite.Components.QButton
    Friend WithEvents btnSave As Qios.DevSuite.Components.QButton
End Class
