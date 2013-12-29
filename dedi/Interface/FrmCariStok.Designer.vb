<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariStok
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
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.rdnama = New System.Windows.Forms.RadioButton
        Me.rdKode = New System.Windows.Forms.RadioButton
        Me.grdCariStok = New System.Windows.Forms.DataGridView
        Me.QPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdCariStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.ForestGreen, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.grdCariStok)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1030, 577)
        Me.QPanel1.TabIndex = 0
        Me.QPanel1.Text = "QPanel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.rdnama)
        Me.GroupBox1.Controls.Add(Me.rdKode)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(711, 75)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(364, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(328, 23)
        Me.TextBox1.TabIndex = 3
        '
        'rdnama
        '
        Me.rdnama.AutoSize = True
        Me.rdnama.Location = New System.Drawing.Point(141, 34)
        Me.rdnama.Name = "rdnama"
        Me.rdnama.Size = New System.Drawing.Size(97, 19)
        Me.rdnama.TabIndex = 1
        Me.rdnama.TabStop = True
        Me.rdnama.Text = "Nama barang"
        Me.rdnama.UseVisualStyleBackColor = True
        '
        'rdKode
        '
        Me.rdKode.AutoSize = True
        Me.rdKode.Location = New System.Drawing.Point(22, 34)
        Me.rdKode.Name = "rdKode"
        Me.rdKode.Size = New System.Drawing.Size(92, 19)
        Me.rdKode.TabIndex = 0
        Me.rdKode.TabStop = True
        Me.rdKode.Text = "Kode Barang"
        Me.rdKode.UseVisualStyleBackColor = True
        '
        'grdCariStok
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime
        Me.grdCariStok.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCariStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCariStok.Location = New System.Drawing.Point(11, 117)
        Me.grdCariStok.Name = "grdCariStok"
        Me.grdCariStok.ReadOnly = True
        Me.grdCariStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCariStok.Size = New System.Drawing.Size(1012, 447)
        Me.grdCariStok.TabIndex = 0
        '
        'FrmCariStok
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 577)
        Me.Controls.Add(Me.QPanel1)
        Me.Name = "FrmCariStok"
        Me.Text = "FrmCariStok"
        Me.QPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdCariStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents grdCariStok As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents rdnama As System.Windows.Forms.RadioButton
    Friend WithEvents rdKode As System.Windows.Forms.RadioButton
End Class
