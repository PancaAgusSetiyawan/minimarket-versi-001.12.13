<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUser
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
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNm_user = New System.Windows.Forms.TextBox
        Me.label = New System.Windows.Forms.Label
        Me.txtKd_user = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnClose = New Qios.DevSuite.Components.QButton
        Me.btnCancel = New Qios.DevSuite.Components.QButton
        Me.btnDelete = New Qios.DevSuite.Components.QButton
        Me.btnEdit = New Qios.DevSuite.Components.QButton
        Me.btnSave = New Qios.DevSuite.Components.QButton
        Me.grdUser = New System.Windows.Forms.DataGridView
        Me.QPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Blue, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.grdUser)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1241, 536)
        Me.QPanel1.TabIndex = 0
        Me.QPanel1.Text = "QPanel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cboLevel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNm_user)
        Me.GroupBox1.Controls.Add(Me.label)
        Me.GroupBox1.Controls.Add(Me.txtKd_user)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 424)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboLevel.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Items.AddRange(New Object() {"--Pilih Level--", "Supervisor", "Admin", "Kasir"})
        Me.cboLevel.Location = New System.Drawing.Point(145, 202)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(243, 27)
        Me.cboLevel.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(11, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 24)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Level"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(145, 151)
        Me.txtPass.MaxLength = 10
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(243, 29)
        Me.txtPass.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(11, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Password"
        '
        'txtNm_user
        '
        Me.txtNm_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNm_user.Location = New System.Drawing.Point(145, 102)
        Me.txtNm_user.MaxLength = 30
        Me.txtNm_user.Name = "txtNm_user"
        Me.txtNm_user.Size = New System.Drawing.Size(393, 29)
        Me.txtNm_user.TabIndex = 33
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(11, 105)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(104, 24)
        Me.label.TabIndex = 32
        Me.label.Text = "Nama User"
        '
        'txtKd_user
        '
        Me.txtKd_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_user.Location = New System.Drawing.Point(145, 53)
        Me.txtKd_user.MaxLength = 15
        Me.txtKd_user.Name = "txtKd_user"
        Me.txtKd_user.Size = New System.Drawing.Size(243, 29)
        Me.txtKd_user.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 24)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Kode User"
        '
        'btnClose
        '
        Me.btnClose.Image = Nothing
        Me.btnClose.Location = New System.Drawing.Point(413, 297)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(92, 36)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "Close"
        '
        'btnCancel
        '
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(313, 297)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(92, 36)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        '
        'btnDelete
        '
        Me.btnDelete.Image = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(213, 297)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 36)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        '
        'btnEdit
        '
        Me.btnEdit.Image = Nothing
        Me.btnEdit.Location = New System.Drawing.Point(113, 297)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(92, 36)
        Me.btnEdit.TabIndex = 20
        Me.btnEdit.Text = "Edit"
        '
        'btnSave
        '
        Me.btnSave.Image = Nothing
        Me.btnSave.Location = New System.Drawing.Point(13, 297)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(92, 36)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "Save"
        '
        'grdUser
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime
        Me.grdUser.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdUser.BackgroundColor = System.Drawing.Color.White
        Me.grdUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.grdUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdUser.GridColor = System.Drawing.Color.Blue
        Me.grdUser.Location = New System.Drawing.Point(580, 105)
        Me.grdUser.Name = "grdUser"
        Me.grdUser.ReadOnly = True
        Me.grdUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        Me.grdUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdUser.Size = New System.Drawing.Size(648, 418)
        Me.grdUser.TabIndex = 32
        '
        'frmUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 536)
        Me.Controls.Add(Me.QPanel1)
        Me.MinimizeBox = False
        Me.Name = "frmUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmUser"
        Me.QPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.grdUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNm_user As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents txtKd_user As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As Qios.DevSuite.Components.QButton
    Friend WithEvents btnCancel As Qios.DevSuite.Components.QButton
    Friend WithEvents btnDelete As Qios.DevSuite.Components.QButton
    Friend WithEvents btnEdit As Qios.DevSuite.Components.QButton
    Friend WithEvents btnSave As Qios.DevSuite.Components.QButton
    Friend WithEvents grdUser As System.Windows.Forms.DataGridView
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
End Class
