<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariSuplier
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
        Me.QCompositeBalloon1 = New Qios.DevSuite.Components.QCompositeBalloon
        Me.QBalloon1 = New Qios.DevSuite.Components.QBalloon
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.GrdSuplier = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdKota = New System.Windows.Forms.RadioButton
        Me.rdNama = New System.Windows.Forms.RadioButton
        Me.rdKode = New System.Windows.Forms.RadioButton
        Me.txtCariSuplier = New Qios.DevSuite.Components.QInputBox
        Me.QPanel1.SuspendLayout()
        CType(Me.GrdSuplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.LimeGreen, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.GrdSuplier)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1208, 546)
        Me.QPanel1.TabIndex = 41
        Me.QPanel1.Text = "QPanel1"
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
        Me.GrdSuplier.Location = New System.Drawing.Point(9, 112)
        Me.GrdSuplier.Name = "GrdSuplier"
        Me.GrdSuplier.ReadOnly = True
        Me.GrdSuplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdSuplier.Size = New System.Drawing.Size(1188, 400)
        Me.GrdSuplier.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdKota)
        Me.GroupBox1.Controls.Add(Me.rdNama)
        Me.GroupBox1.Controls.Add(Me.rdKode)
        Me.GroupBox1.Controls.Add(Me.txtCariSuplier)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1184, 64)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilih Pencarian"
        '
        'rdKota
        '
        Me.rdKota.AutoSize = True
        Me.rdKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdKota.Location = New System.Drawing.Point(291, 31)
        Me.rdKota.Name = "rdKota"
        Me.rdKota.Size = New System.Drawing.Size(55, 21)
        Me.rdKota.TabIndex = 3
        Me.rdKota.TabStop = True
        Me.rdKota.Text = "Kota"
        Me.rdKota.UseVisualStyleBackColor = True
        '
        'rdNama
        '
        Me.rdNama.AutoSize = True
        Me.rdNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdNama.Location = New System.Drawing.Point(157, 31)
        Me.rdNama.Name = "rdNama"
        Me.rdNama.Size = New System.Drawing.Size(111, 21)
        Me.rdNama.TabIndex = 2
        Me.rdNama.TabStop = True
        Me.rdNama.Text = "Nama Suplier"
        Me.rdNama.UseVisualStyleBackColor = True
        '
        'rdKode
        '
        Me.rdKode.AutoSize = True
        Me.rdKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdKode.Location = New System.Drawing.Point(22, 31)
        Me.rdKode.Name = "rdKode"
        Me.rdKode.Size = New System.Drawing.Size(107, 21)
        Me.rdKode.TabIndex = 1
        Me.rdKode.TabStop = True
        Me.rdKode.Text = "Kode Suplier"
        Me.rdKode.UseVisualStyleBackColor = True
        '
        'txtCariSuplier
        '
        Me.txtCariSuplier.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariSuplier.Location = New System.Drawing.Point(468, 22)
        Me.txtCariSuplier.Name = "txtCariSuplier"
        Me.txtCariSuplier.Size = New System.Drawing.Size(331, 30)
        Me.txtCariSuplier.TabIndex = 0
        '
        'FrmCariSuplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 546)
        Me.Controls.Add(Me.QPanel1)
        Me.MaximizeBox = False
        Me.Name = "FrmCariSuplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCariSuplier"
        Me.QPanel1.ResumeLayout(False)
        CType(Me.GrdSuplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QCompositeBalloon1 As Qios.DevSuite.Components.QCompositeBalloon
    Friend WithEvents QBalloon1 As Qios.DevSuite.Components.QBalloon
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents GrdSuplier As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdKota As System.Windows.Forms.RadioButton
    Friend WithEvents rdNama As System.Windows.Forms.RadioButton
    Friend WithEvents rdKode As System.Windows.Forms.RadioButton
    Friend WithEvents txtCariSuplier As Qios.DevSuite.Components.QInputBox
End Class
