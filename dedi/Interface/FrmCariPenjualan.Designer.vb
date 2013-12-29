<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCariPenjualan
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
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.Rdtanggal = New System.Windows.Forms.RadioButton
        Me.RdNoTransaksi = New System.Windows.Forms.RadioButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.dtPiker = New System.Windows.Forms.DateTimePicker
        Me.grdCaripenjualan = New System.Windows.Forms.DataGridView
        Me.QPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdCaripenjualan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.LimeGreen, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.grdCaripenjualan)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1274, 625)
        Me.QPanel1.TabIndex = 0
        Me.QPanel1.Text = "QPanel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.Rdtanggal)
        Me.GroupBox1.Controls.Add(Me.RdNoTransaksi)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtPiker)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(11, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1250, 60)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian Berdasarkan"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(321, 24)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(347, 23)
        Me.txtCari.TabIndex = 9
        '
        'Rdtanggal
        '
        Me.Rdtanggal.AutoSize = True
        Me.Rdtanggal.Location = New System.Drawing.Point(187, 28)
        Me.Rdtanggal.Name = "Rdtanggal"
        Me.Rdtanggal.Size = New System.Drawing.Size(69, 19)
        Me.Rdtanggal.TabIndex = 8
        Me.Rdtanggal.TabStop = True
        Me.Rdtanggal.Text = "Tanggal"
        Me.Rdtanggal.UseVisualStyleBackColor = True
        '
        'RdNoTransaksi
        '
        Me.RdNoTransaksi.AutoSize = True
        Me.RdNoTransaksi.Location = New System.Drawing.Point(33, 29)
        Me.RdNoTransaksi.Name = "RdNoTransaksi"
        Me.RdNoTransaksi.Size = New System.Drawing.Size(93, 19)
        Me.RdNoTransaksi.TabIndex = 7
        Me.RdNoTransaksi.TabStop = True
        Me.RdNoTransaksi.Text = "No Transaksi"
        Me.RdNoTransaksi.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1036, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtPiker
        '
        Me.dtPiker.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.dtPiker.Location = New System.Drawing.Point(723, 21)
        Me.dtPiker.Name = "dtPiker"
        Me.dtPiker.Size = New System.Drawing.Size(252, 26)
        Me.dtPiker.TabIndex = 5
        '
        'grdCaripenjualan
        '
        Me.grdCaripenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCaripenjualan.Location = New System.Drawing.Point(3, 150)
        Me.grdCaripenjualan.Name = "grdCaripenjualan"
        Me.grdCaripenjualan.Size = New System.Drawing.Size(1266, 462)
        Me.grdCaripenjualan.TabIndex = 0
        '
        'FrmCariPenjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1274, 625)
        Me.Controls.Add(Me.QPanel1)
        Me.Name = "FrmCariPenjualan"
        Me.Text = "FrmCariPenjualan"
        Me.QPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdCaripenjualan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents grdCaripenjualan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdtanggal As System.Windows.Forms.RadioButton
    Friend WithEvents RdNoTransaksi As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dtPiker As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
End Class
