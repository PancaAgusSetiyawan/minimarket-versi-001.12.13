<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariBarang
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.QBalloon1 = New Qios.DevSuite.Components.QBalloon
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdKota = New System.Windows.Forms.RadioButton
        Me.rdNama = New System.Windows.Forms.RadioButton
        Me.rdKode = New System.Windows.Forms.RadioButton
        Me.txtCariBarang = New Qios.DevSuite.Components.QInputBox
        Me.grdBarang = New System.Windows.Forms.DataGridView
        Me.QPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.LimeGreen, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.SystemColors.ActiveCaptionText, False)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.grdBarang)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1267, 546)
        Me.QPanel1.TabIndex = 33
        Me.QPanel1.Text = "QPanel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdKota)
        Me.GroupBox1.Controls.Add(Me.rdNama)
        Me.GroupBox1.Controls.Add(Me.rdKode)
        Me.GroupBox1.Controls.Add(Me.txtCariBarang)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1243, 64)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilih Pencarian"
        '
        'rdKota
        '
        Me.rdKota.AutoSize = True
        Me.rdKota.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdKota.ForeColor = System.Drawing.Color.White
        Me.rdKota.Location = New System.Drawing.Point(291, 31)
        Me.rdKota.Name = "rdKota"
        Me.rdKota.Size = New System.Drawing.Size(109, 21)
        Me.rdKota.TabIndex = 3
        Me.rdKota.TabStop = True
        Me.rdKota.Text = "Jenis Barang"
        Me.rdKota.UseVisualStyleBackColor = True
        '
        'rdNama
        '
        Me.rdNama.AutoSize = True
        Me.rdNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdNama.ForeColor = System.Drawing.Color.White
        Me.rdNama.Location = New System.Drawing.Point(157, 31)
        Me.rdNama.Name = "rdNama"
        Me.rdNama.Size = New System.Drawing.Size(113, 21)
        Me.rdNama.TabIndex = 2
        Me.rdNama.TabStop = True
        Me.rdNama.Text = "Nama Barang"
        Me.rdNama.UseVisualStyleBackColor = True
        '
        'rdKode
        '
        Me.rdKode.AutoSize = True
        Me.rdKode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdKode.ForeColor = System.Drawing.Color.White
        Me.rdKode.Location = New System.Drawing.Point(22, 31)
        Me.rdKode.Name = "rdKode"
        Me.rdKode.Size = New System.Drawing.Size(109, 21)
        Me.rdKode.TabIndex = 1
        Me.rdKode.TabStop = True
        Me.rdKode.Text = "Kode Barang"
        Me.rdKode.UseVisualStyleBackColor = True
        '
        'txtCariBarang
        '
        Me.txtCariBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCariBarang.Location = New System.Drawing.Point(468, 22)
        Me.txtCariBarang.Name = "txtCariBarang"
        Me.txtCariBarang.Size = New System.Drawing.Size(331, 30)
        Me.txtCariBarang.TabIndex = 0
        '
        'grdBarang
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LawnGreen
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Red
        Me.grdBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBarang.Location = New System.Drawing.Point(12, 103)
        Me.grdBarang.Name = "grdBarang"
        Me.grdBarang.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCyan
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdBarang.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdBarang.RowHeadersWidth = 40
        Me.grdBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdBarang.Size = New System.Drawing.Size(1242, 409)
        Me.grdBarang.TabIndex = 33
        '
        'FrmCariBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 546)
        Me.Controls.Add(Me.QPanel1)
        Me.MaximizeBox = False
        Me.Name = "FrmCariBarang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCariBarang"
        Me.QPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QBalloon1 As Qios.DevSuite.Components.QBalloon
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdKota As System.Windows.Forms.RadioButton
    Friend WithEvents rdNama As System.Windows.Forms.RadioButton
    Friend WithEvents rdKode As System.Windows.Forms.RadioButton
    Friend WithEvents txtCariBarang As Qios.DevSuite.Components.QInputBox
    Friend WithEvents grdBarang As System.Windows.Forms.DataGridView
End Class
