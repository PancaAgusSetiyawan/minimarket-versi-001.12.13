<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogIn2
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
        Me.QBalloon1 = New Qios.DevSuite.Components.QBalloon
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCancel = New Qios.DevSuite.Components.QButton
        Me.txtLogIn = New Qios.DevSuite.Components.QButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.QPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QBalloon1
        '
        Me.QBalloon1.ColorScheme.BalloonWindowBackground1.SetColor("VistaBlack", System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), False)
        Me.QBalloon1.ColorScheme.BalloonWindowPressedButtonBorder.SetColor("VistaBlack", System.Drawing.Color.Lime, False)
        Me.QBalloon1.Configuration.FontSource = Qios.DevSuite.Components.QBalloonWindowPropertySource.QBalloonWindow
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Blue, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.PictureBox1)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(993, 378)
        Me.QPanel1.TabIndex = 19
        Me.QPanel1.Text = "QPanel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.cboLevel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCancel)
        Me.GroupBox1.Controls.Add(Me.txtLogIn)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(413, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(567, 303)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.cboLevel.FormattingEnabled = True
        Me.cboLevel.Items.AddRange(New Object() {"--Pilih--", "Supervisor", "Admin", "Kasir"})
        Me.cboLevel.Location = New System.Drawing.Point(228, 146)
        Me.cboLevel.Name = "cboLevel"
        Me.cboLevel.Size = New System.Drawing.Size(274, 27)
        Me.cboLevel.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(79, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 24)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Level"
        '
        'txtCancel
        '
        Me.txtCancel.Image = Nothing
        Me.txtCancel.Location = New System.Drawing.Point(409, 244)
        Me.txtCancel.Name = "txtCancel"
        Me.txtCancel.Size = New System.Drawing.Size(93, 31)
        Me.txtCancel.TabIndex = 23
        Me.txtCancel.Text = "Cancel"
        '
        'txtLogIn
        '
        Me.txtLogIn.ColorScheme.ButtonFocusedInnerGlow.SetColor("VistaBlack", System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), False)
        Me.txtLogIn.ColorScheme.ButtonPressedBackground1.SetColor("VistaBlack", System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), False)
        Me.txtLogIn.Image = Nothing
        Me.txtLogIn.Location = New System.Drawing.Point(310, 244)
        Me.txtLogIn.Name = "txtLogIn"
        Me.txtLogIn.Size = New System.Drawing.Size(93, 31)
        Me.txtLogIn.TabIndex = 22
        Me.txtLogIn.Text = "Log In"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(80, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(233, 16)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "**Masukkan User Name dan Password Anda"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(228, 33)
        Me.txtUserName.MaxLength = 10
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(274, 29)
        Me.txtUserName.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 24)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "User Name"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Wingdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtPass.Location = New System.Drawing.Point(228, 88)
        Me.txtPass.MaxLength = 10
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(74)
        Me.txtPass.Size = New System.Drawing.Size(274, 29)
        Me.txtPass.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.dedi.My.Resources.Resources.Login
        Me.PictureBox1.Location = New System.Drawing.Point(11, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(365, 342)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'FrmLogIn2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 378)
        Me.Controls.Add(Me.QPanel1)
        Me.MaximizeBox = False
        Me.Name = "FrmLogIn2"
        Me.Text = "FrmLogIn Database"
        Me.QPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QBalloon1 As Qios.DevSuite.Components.QBalloon
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCancel As Qios.DevSuite.Components.QButton
    Friend WithEvents txtLogIn As Qios.DevSuite.Components.QButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
End Class
