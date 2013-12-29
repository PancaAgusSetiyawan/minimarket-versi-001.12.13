<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lap_Pb_Harian
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.btnShow = New Qios.DevSuite.Components.QButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.tgl = New System.Windows.Forms.Label
        Me.dtPicker2 = New System.Windows.Forms.DateTimePicker
        Me.dtPicker1 = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 50)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1044, 492)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnShow
        '
        Me.btnShow.Image = Nothing
        Me.btnShow.Location = New System.Drawing.Point(691, 12)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 10
        Me.btnShow.Text = "Show"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(366, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Tanggal Awal"
        '
        'tgl
        '
        Me.tgl.AutoSize = True
        Me.tgl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgl.Location = New System.Drawing.Point(17, 15)
        Me.tgl.Name = "tgl"
        Me.tgl.Size = New System.Drawing.Size(93, 17)
        Me.tgl.TabIndex = 8
        Me.tgl.Text = "Tanggal Awal"
        '
        'dtPicker2
        '
        Me.dtPicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPicker2.Location = New System.Drawing.Point(470, 12)
        Me.dtPicker2.Name = "dtPicker2"
        Me.dtPicker2.Size = New System.Drawing.Size(200, 23)
        Me.dtPicker2.TabIndex = 7
        '
        'dtPicker1
        '
        Me.dtPicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPicker1.Location = New System.Drawing.Point(123, 12)
        Me.dtPicker1.Name = "dtPicker1"
        Me.dtPicker1.Size = New System.Drawing.Size(200, 23)
        Me.dtPicker1.TabIndex = 6
        '
        'Lap_Pb_Harian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 546)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tgl)
        Me.Controls.Add(Me.dtPicker2)
        Me.Controls.Add(Me.dtPicker1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.MaximizeBox = False
        Me.Name = "Lap_Pb_Harian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lap Pembelian Harian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnShow As Qios.DevSuite.Components.QButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tgl As System.Windows.Forms.Label
    Friend WithEvents dtPicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtPicker1 As System.Windows.Forms.DateTimePicker
End Class
