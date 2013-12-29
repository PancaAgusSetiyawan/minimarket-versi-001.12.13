<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lap_PerTransVW
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
        Me.components = New System.ComponentModel.Container
        Me.crVwHarian = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.QButton1 = New Qios.DevSuite.Components.QButton
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'crVwHarian
        '
        Me.crVwHarian.ActiveViewIndex = -1
        Me.crVwHarian.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crVwHarian.DisplayGroupTree = False
        Me.crVwHarian.Location = New System.Drawing.Point(0, 52)
        Me.crVwHarian.Name = "crVwHarian"
        Me.crVwHarian.SelectionFormula = ""
        Me.crVwHarian.Size = New System.Drawing.Size(1134, 477)
        Me.crVwHarian.TabIndex = 0
        Me.crVwHarian.ViewTimeSelectionFormula = ""
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'QButton1
        '
        Me.QButton1.Image = Nothing
        Me.QButton1.Location = New System.Drawing.Point(409, 15)
        Me.QButton1.Name = "QButton1"
        Me.QButton1.Size = New System.Drawing.Size(75, 23)
        Me.QButton1.TabIndex = 1
        Me.QButton1.Text = "Show"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(162, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(221, 24)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No  Transaksi"
        '
        'Lap_PerTransVW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1146, 529)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.QButton1)
        Me.Controls.Add(Me.crVwHarian)
        Me.MaximizeBox = False
        Me.Name = "Lap_PerTransVW"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laporan Penjualan PerTransaksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crVwHarian As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents QButton1 As Qios.DevSuite.Components.QButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
