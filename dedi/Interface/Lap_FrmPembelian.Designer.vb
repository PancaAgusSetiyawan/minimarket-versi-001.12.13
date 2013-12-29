<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lap_FrmPembelian
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series
        Me.QPanel1 = New Qios.DevSuite.Components.QPanel
        Me.grdView = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnShow = New Qios.DevSuite.Components.QButton
        Me.btnPrint = New Qios.DevSuite.Components.QButton
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.dtAwal = New System.Windows.Forms.DateTimePicker
        Me.dtAkhir = New System.Windows.Forms.DateTimePicker
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.QPanel1.SuspendLayout()
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QPanel1
        '
        Me.QPanel1.Controls.Add(Me.grdView)
        Me.QPanel1.Controls.Add(Me.GroupBox1)
        Me.QPanel1.Controls.Add(Me.Chart1)
        Me.QPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.QPanel1.Location = New System.Drawing.Point(0, 0)
        Me.QPanel1.Name = "QPanel1"
        Me.QPanel1.Size = New System.Drawing.Size(1276, 605)
        Me.QPanel1.TabIndex = 1
        Me.QPanel1.Text = "QPanel1"
        '
        'grdView
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.PaleTurquoise
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime
        Me.grdView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdView.Location = New System.Drawing.Point(625, 188)
        Me.grdView.Name = "grdView"
        Me.grdView.ReadOnly = True
        Me.grdView.Size = New System.Drawing.Size(638, 404)
        Me.grdView.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnShow)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.dtAwal)
        Me.GroupBox1.Controls.Add(Me.dtAkhir)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1252, 142)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilih Laporan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(99, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 21)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Tanggal Akhir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Tanggal Akhir"
        '
        'btnShow
        '
        Me.btnShow.Image = Nothing
        Me.btnShow.Location = New System.Drawing.Point(1020, 34)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(110, 77)
        Me.btnShow.TabIndex = 22
        Me.btnShow.Text = "Show"
        '
        'btnPrint
        '
        Me.btnPrint.Image = Nothing
        Me.btnPrint.Location = New System.Drawing.Point(1136, 34)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(110, 77)
        Me.btnPrint.TabIndex = 16
        Me.btnPrint.Text = "Print"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Segoe UI", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(711, 39)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(303, 71)
        Me.txtTotal.TabIndex = 14
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtAwal
        '
        Me.dtAwal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAwal.Location = New System.Drawing.Point(294, 46)
        Me.dtAwal.Name = "dtAwal"
        Me.dtAwal.Size = New System.Drawing.Size(298, 29)
        Me.dtAwal.TabIndex = 12
        '
        'dtAkhir
        '
        Me.dtAkhir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAkhir.Location = New System.Drawing.Point(294, 81)
        Me.dtAkhir.Name = "dtAkhir"
        Me.dtAkhir.Size = New System.Drawing.Size(298, 29)
        Me.dtAkhir.TabIndex = 11
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(11, 188)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(608, 404)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart1"
        '
        'Lap_FrmPembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 605)
        Me.Controls.Add(Me.QPanel1)
        Me.MaximizeBox = False
        Me.Name = "Lap_FrmPembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rekap Pembelian"
        Me.QPanel1.ResumeLayout(False)
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents QPanel1 As Qios.DevSuite.Components.QPanel
    Friend WithEvents grdView As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnShow As Qios.DevSuite.Components.QButton
    Friend WithEvents btnPrint As Qios.DevSuite.Components.QButton
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents dtAwal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
