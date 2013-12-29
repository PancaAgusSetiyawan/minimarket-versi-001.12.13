<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRubahPass
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnCancel = New Qios.DevSuite.Components.QButton
        Me.btnOk = New Qios.DevSuite.Components.QButton
        Me.txtPassBaru2 = New System.Windows.Forms.TextBox
        Me.txtPassbaru1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.QBalloon1 = New Qios.DevSuite.Components.QBalloon
        Me.QPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Blue, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.PictureBox1)
        Me.QPanel1.Controls.Add(Me.btnCancel)
        Me.QPanel1.Controls.Add(Me.btnOk)
        Me.QPanel1.Controls.Add(Me.txtPassBaru2)
        Me.QPanel1.Controls.Add(Me.txtPassbaru1)
        Me.QPanel1.Controls.Add(Me.Label5)
        Me.QPanel1.Controls.Add(Me.Label4)
        Me.QPanel1.Controls.Add(Me.Label3)
        Me.QPanel1.Controls.Add(Me.txtPass)
        Me.QPanel1.Controls.Add(Me.txtUserName)
        Me.QPanel1.Controls.Add(Me.Label2)
        Me.QPanel1.Controls.Add(Me.Label1)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(843, 455)
        Me.QPanel1.TabIndex = 0
        Me.QPanel1.Text = "QPanel1"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.dedi.My.Resources.Resources.login_icon_2
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(257, 358)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 45
        Me.PictureBox1.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Image = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(744, 370)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 32)
        Me.btnCancel.TabIndex = 44
        Me.btnCancel.Text = "Cancel"
        '
        'btnOk
        '
        Me.btnOk.Image = Nothing
        Me.btnOk.Location = New System.Drawing.Point(632, 370)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(82, 32)
        Me.btnOk.TabIndex = 43
        Me.btnOk.Text = "OK"
        '
        'txtPassBaru2
        '
        Me.txtPassBaru2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassBaru2.Location = New System.Drawing.Point(466, 276)
        Me.txtPassBaru2.MaxLength = 10
        Me.txtPassBaru2.Name = "txtPassBaru2"
        Me.txtPassBaru2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassBaru2.Size = New System.Drawing.Size(364, 29)
        Me.txtPassBaru2.TabIndex = 42
        '
        'txtPassbaru1
        '
        Me.txtPassbaru1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassbaru1.Location = New System.Drawing.Point(466, 235)
        Me.txtPassbaru1.MaxLength = 10
        Me.txtPassbaru1.Name = "txtPassbaru1"
        Me.txtPassbaru1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassbaru1.Size = New System.Drawing.Size(364, 29)
        Me.txtPassbaru1.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(264, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 24)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Password Baru"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(264, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 24)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Password Baru"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(265, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "**Masukkan User Name dan Password Anda"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(466, 189)
        Me.txtPass.MaxLength = 10
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(364, 29)
        Me.txtPass.TabIndex = 35
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(466, 144)
        Me.txtUserName.MaxLength = 15
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(364, 29)
        Me.txtUserName.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(264, 194)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Password Lama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(264, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 24)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "User Id"
        '
        'QBalloon1
        '
        Me.QBalloon1.AddListener(Me.txtPassBaru2, "10 Karakter")
        Me.QBalloon1.AddListener(Me.txtPassbaru1, "10 Karakter")
        Me.QBalloon1.AddListener(Me.txtPass, "10 Karakter")
        '
        'frmRubahPass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 455)
        Me.Controls.Add(Me.QPanel1)
        Me.MinimizeBox = False
        Me.Name = "frmRubahPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perubahan Password"
        Me.QPanel1.ResumeLayout(False)
        Me.QPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents btnCancel As Qios.DevSuite.Components.QButton
    Friend WithEvents btnOk As Qios.DevSuite.Components.QButton
    Friend WithEvents txtPassBaru2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPassbaru1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents QBalloon1 As Qios.DevSuite.Components.QBalloon
End Class
