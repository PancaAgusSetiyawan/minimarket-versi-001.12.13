<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGolongan
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New Qios.DevSuite.Components.QButton
        Me.btnCancel = New Qios.DevSuite.Components.QButton
        Me.btnDelete = New Qios.DevSuite.Components.QButton
        Me.btnEdit = New Qios.DevSuite.Components.QButton
        Me.btnSave = New Qios.DevSuite.Components.QButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtKeterngan = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtGolongan = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtKd_gol = New System.Windows.Forms.TextBox
        Me.grdGolongan = New System.Windows.Forms.DataGridView
        Me.QPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdGolongan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Blue, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.GroupBox2)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.grdGolongan)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1177, 570)
        Me.QPanel1.TabIndex = 0
        Me.QPanel1.Text = "QPanel1"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(539, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(625, 62)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pencarian Data"
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.TextBox4.Location = New System.Drawing.Point(261, 22)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(342, 26)
        Me.TextBox4.TabIndex = 9
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(160, 29)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(77, 19)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Golongan"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.White
        Me.RadioButton1.Location = New System.Drawing.Point(20, 29)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(107, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Kode Golongan"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtKeterngan)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtGolongan)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtKd_gol)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(522, 458)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Image = Nothing
        Me.btnClose.Location = New System.Drawing.Point(414, 209)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 36)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(314, 209)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 36)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(214, 209)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 36)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.Image = Nothing
        Me.btnEdit.Location = New System.Drawing.Point(114, 209)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 36)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.Image = Nothing
        Me.btnSave.Location = New System.Drawing.Point(14, 209)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 36)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Keterangan"
        '
        'txtKeterngan
        '
        Me.txtKeterngan.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtKeterngan.Location = New System.Drawing.Point(155, 142)
        Me.txtKeterngan.Name = "txtKeterngan"
        Me.txtKeterngan.Size = New System.Drawing.Size(342, 26)
        Me.txtKeterngan.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(19, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Golongan"
        '
        'txtGolongan
        '
        Me.txtGolongan.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtGolongan.Location = New System.Drawing.Point(155, 98)
        Me.txtGolongan.Name = "txtGolongan"
        Me.txtGolongan.Size = New System.Drawing.Size(342, 26)
        Me.txtGolongan.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Kode Golongan"
        '
        'txtKd_gol
        '
        Me.txtKd_gol.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtKd_gol.Location = New System.Drawing.Point(155, 52)
        Me.txtKd_gol.Name = "txtKd_gol"
        Me.txtKd_gol.Size = New System.Drawing.Size(98, 26)
        Me.txtKd_gol.TabIndex = 8
        '
        'grdGolongan
        '
        Me.grdGolongan.BackgroundColor = System.Drawing.Color.White
        Me.grdGolongan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGolongan.Location = New System.Drawing.Point(539, 167)
        Me.grdGolongan.Name = "grdGolongan"
        Me.grdGolongan.Size = New System.Drawing.Size(625, 390)
        Me.grdGolongan.TabIndex = 1
        '
        'FrmGolongan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 570)
        Me.Controls.Add(Me.QPanel1)
        Me.MinimizeBox = False
        Me.Name = "FrmGolongan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Golongan"
        Me.QPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdGolongan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents grdGolongan As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtKeterngan As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGolongan As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKd_gol As System.Windows.Forms.TextBox
    Friend WithEvents btnClose As Qios.DevSuite.Components.QButton
    Friend WithEvents btnCancel As Qios.DevSuite.Components.QButton
    Friend WithEvents btnDelete As Qios.DevSuite.Components.QButton
    Friend WithEvents btnEdit As Qios.DevSuite.Components.QButton
    Friend WithEvents btnSave As Qios.DevSuite.Components.QButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
End Class
