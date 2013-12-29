<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUpdateHarga
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
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.rdNm_brg = New System.Windows.Forms.RadioButton
        Me.rdKd_Brg = New System.Windows.Forms.RadioButton
        Me.btnClose = New Qios.DevSuite.Components.QButton
        Me.btnCancel = New Qios.DevSuite.Components.QButton
        Me.btnUpdate = New Qios.DevSuite.Components.QButton
        Me.txtDiskon = New QSS.Components.Windows.Forms.NumberBox
        Me.txtHrg_Jual = New QSS.Components.Windows.Forms.NumberBox
        Me.txtHrg_Beli = New QSS.Components.Windows.Forms.NumberBox
        Me.txtStok = New System.Windows.Forms.TextBox
        Me.txtNm_Brg = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtKd_brg = New System.Windows.Forms.TextBox
        Me.grdHarga = New System.Windows.Forms.DataGridView
        Me.QPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Blue, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.txtDiskon)
        Me.QPanel1.Controls.Add(Me.txtHrg_Jual)
        Me.QPanel1.Controls.Add(Me.txtHrg_Beli)
        Me.QPanel1.Controls.Add(Me.txtStok)
        Me.QPanel1.Controls.Add(Me.txtNm_Brg)
        Me.QPanel1.Controls.Add(Me.Label7)
        Me.QPanel1.Controls.Add(Me.Label6)
        Me.QPanel1.Controls.Add(Me.Label5)
        Me.QPanel1.Controls.Add(Me.Label4)
        Me.QPanel1.Controls.Add(Me.Label2)
        Me.QPanel1.Controls.Add(Me.Label1)
        Me.QPanel1.Controls.Add(Me.txtKd_brg)
        Me.QPanel1.Controls.Add(Me.grdHarga)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1190, 610)
        Me.QPanel1.TabIndex = 3
        Me.QPanel1.Text = "QPanel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtCari)
        Me.GroupBox1.Controls.Add(Me.rdNm_brg)
        Me.GroupBox1.Controls.Add(Me.rdKd_Brg)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnUpdate)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 217)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1174, 63)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(363, 26)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(288, 23)
        Me.txtCari.TabIndex = 27
        '
        'rdNm_brg
        '
        Me.rdNm_brg.AutoSize = True
        Me.rdNm_brg.ForeColor = System.Drawing.Color.White
        Me.rdNm_brg.Location = New System.Drawing.Point(199, 27)
        Me.rdNm_brg.Name = "rdNm_brg"
        Me.rdNm_brg.Size = New System.Drawing.Size(97, 19)
        Me.rdNm_brg.TabIndex = 25
        Me.rdNm_brg.TabStop = True
        Me.rdNm_brg.Text = "Nama Barang"
        Me.rdNm_brg.UseVisualStyleBackColor = True
        '
        'rdKd_Brg
        '
        Me.rdKd_Brg.AutoSize = True
        Me.rdKd_Brg.ForeColor = System.Drawing.Color.White
        Me.rdKd_Brg.Location = New System.Drawing.Point(36, 27)
        Me.rdKd_Brg.Name = "rdKd_Brg"
        Me.rdKd_Brg.Size = New System.Drawing.Size(92, 19)
        Me.rdKd_Brg.TabIndex = 24
        Me.rdKd_Brg.TabStop = True
        Me.rdKd_Brg.Text = "Kode Barang"
        Me.rdKd_Brg.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Image = Nothing
        Me.btnClose.Location = New System.Drawing.Point(1056, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(99, 31)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(949, 22)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(99, 31)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = Nothing
        Me.btnUpdate.Location = New System.Drawing.Point(842, 22)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(99, 31)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Update"
        '
        'txtDiskon
        '
        Me.txtDiskon.Location = New System.Drawing.Point(934, 149)
        Me.txtDiskon.Name = "txtDiskon"
        Me.txtDiskon.Size = New System.Drawing.Size(243, 23)
        Me.txtDiskon.TabIndex = 18
        Me.txtDiskon.Text = ""
        Me.txtDiskon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHrg_Jual
        '
        Me.txtHrg_Jual.Location = New System.Drawing.Point(934, 112)
        Me.txtHrg_Jual.Name = "txtHrg_Jual"
        Me.txtHrg_Jual.Size = New System.Drawing.Size(243, 23)
        Me.txtHrg_Jual.TabIndex = 17
        Me.txtHrg_Jual.Text = ""
        Me.txtHrg_Jual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtHrg_Beli
        '
        Me.txtHrg_Beli.Location = New System.Drawing.Point(934, 75)
        Me.txtHrg_Beli.Name = "txtHrg_Beli"
        Me.txtHrg_Beli.Size = New System.Drawing.Size(243, 23)
        Me.txtHrg_Beli.TabIndex = 16
        Me.txtHrg_Beli.Text = ""
        Me.txtHrg_Beli.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(148, 153)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.ReadOnly = True
        Me.txtStok.Size = New System.Drawing.Size(100, 23)
        Me.txtStok.TabIndex = 15
        '
        'txtNm_Brg
        '
        Me.txtNm_Brg.Location = New System.Drawing.Point(148, 115)
        Me.txtNm_Brg.Name = "txtNm_Brg"
        Me.txtNm_Brg.ReadOnly = True
        Me.txtNm_Brg.Size = New System.Drawing.Size(534, 23)
        Me.txtNm_Brg.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(763, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 21)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Diskon"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 21)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Stok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(763, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 21)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Harga Jual Satuan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(763, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Harga Beli Satuan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 21)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kode Barang"
        '
        'txtKd_brg
        '
        Me.txtKd_brg.Location = New System.Drawing.Point(148, 78)
        Me.txtKd_brg.Name = "txtKd_brg"
        Me.txtKd_brg.ReadOnly = True
        Me.txtKd_brg.Size = New System.Drawing.Size(238, 23)
        Me.txtKd_brg.TabIndex = 4
        '
        'grdHarga
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Lime
        Me.grdHarga.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.grdHarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdHarga.Location = New System.Drawing.Point(3, 296)
        Me.grdHarga.Name = "grdHarga"
        Me.grdHarga.ReadOnly = True
        Me.grdHarga.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdHarga.Size = New System.Drawing.Size(1174, 301)
        Me.grdHarga.TabIndex = 3
        '
        'FrmUpdateHarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 610)
        Me.Controls.Add(Me.QPanel1)
        Me.MaximizeBox = False
        Me.Name = "FrmUpdateHarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmUpdateHarga"
        Me.QPanel1.ResumeLayout(False)
        Me.QPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdHarga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKd_brg As System.Windows.Forms.TextBox
    Friend WithEvents grdHarga As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNm_Brg As System.Windows.Forms.TextBox
    Friend WithEvents txtDiskon As QSS.Components.Windows.Forms.NumberBox
    Friend WithEvents txtHrg_Jual As QSS.Components.Windows.Forms.NumberBox
    Friend WithEvents txtHrg_Beli As QSS.Components.Windows.Forms.NumberBox
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents rdNm_brg As System.Windows.Forms.RadioButton
    Friend WithEvents rdKd_Brg As System.Windows.Forms.RadioButton
    Friend WithEvents btnClose As Qios.DevSuite.Components.QButton
    Friend WithEvents btnCancel As Qios.DevSuite.Components.QButton
    Friend WithEvents btnUpdate As Qios.DevSuite.Components.QButton
End Class
