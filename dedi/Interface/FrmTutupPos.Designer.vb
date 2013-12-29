<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTutupPos
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
        Me.lblTanggal = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.BtnPrint = New Qios.DevSuite.Components.QButton
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.lblUser = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnOk = New Qios.DevSuite.Components.QButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtUserId = New System.Windows.Forms.TextBox
        Me.QPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.ColorScheme.PanelBackground1.SetColor("VistaBlack", System.Drawing.Color.Blue, False)
        Me.QPanel1.ColorScheme.PanelBackground2.SetColor("VistaBlack", System.Drawing.Color.Black, False)
        Me.QPanel1.Controls.Add(Me.lblTanggal)
        Me.QPanel1.Controls.Add(Me.Label4)
        Me.QPanel1.Controls.Add(Me.BtnPrint)
        Me.QPanel1.Controls.Add(Me.txtTotal)
        Me.QPanel1.Controls.Add(Me.lblUser)
        Me.QPanel1.Controls.Add(Me.Label3)
        Me.QPanel1.Controls.Add(Me.Label1)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(972, 305)
        Me.QPanel1.TabIndex = 0
        Me.QPanel1.Text = "QPanel1"
        '
        'lblTanggal
        '
        Me.lblTanggal.AutoSize = True
        Me.lblTanggal.BackColor = System.Drawing.Color.Transparent
        Me.lblTanggal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.lblTanggal.ForeColor = System.Drawing.Color.White
        Me.lblTanggal.Location = New System.Drawing.Point(583, 170)
        Me.lblTanggal.Name = "lblTanggal"
        Me.lblTanggal.Size = New System.Drawing.Size(89, 19)
        Me.lblTanggal.TabIndex = 11
        Me.lblTanggal.Text = "TanggalLabel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(436, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Tanggal"
        '
        'BtnPrint
        '
        Me.BtnPrint.Image = Nothing
        Me.BtnPrint.Location = New System.Drawing.Point(763, 217)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(196, 56)
        Me.BtnPrint.TabIndex = 9
        Me.BtnPrint.Text = "Print"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtTotal.Location = New System.Drawing.Point(586, 77)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(373, 74)
        Me.txtTotal.TabIndex = 8
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.lblUser.ForeColor = System.Drawing.Color.White
        Me.lblUser.Location = New System.Drawing.Point(583, 205)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(69, 19)
        Me.lblUser.TabIndex = 7
        Me.lblUser.Text = "UserLabel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(436, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "User "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(436, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Total Pendapatan "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnOk)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUserId)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(25, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(383, 246)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan User Id"
        '
        'btnOk
        '
        Me.btnOk.Image = Nothing
        Me.btnOk.Location = New System.Drawing.Point(215, 165)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(108, 39)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "User Id"
        '
        'txtUserId
        '
        Me.txtUserId.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtUserId.Location = New System.Drawing.Point(107, 72)
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(216, 26)
        Me.txtUserId.TabIndex = 5
        '
        'FrmTutupPos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 305)
        Me.Controls.Add(Me.QPanel1)
        Me.MaximizeBox = False
        Me.Name = "FrmTutupPos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmTutupPos"
        Me.QPanel1.ResumeLayout(False)
        Me.QPanel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOk As Qios.DevSuite.Components.QButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUserId As System.Windows.Forms.TextBox
    Friend WithEvents BtnPrint As Qios.DevSuite.Components.QButton
    Friend WithEvents lblTanggal As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
