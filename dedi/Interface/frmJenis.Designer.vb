<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmJenis
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.txtJenis = New System.Windows.Forms.TextBox
        Me.txtKd_Jenis = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.grdJenis = New System.Windows.Forms.DataGridView
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rdJenis = New System.Windows.Forms.RadioButton
        Me.rdKode = New System.Windows.Forms.RadioButton
        Me.txtCari = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdJenis, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtJenis
        '
        Me.txtJenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJenis.Location = New System.Drawing.Point(156, 107)
        Me.txtJenis.MaxLength = 15
        Me.txtJenis.Name = "txtJenis"
        Me.txtJenis.Size = New System.Drawing.Size(360, 29)
        Me.txtJenis.TabIndex = 24
        '
        'txtKd_Jenis
        '
        Me.txtKd_Jenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKd_Jenis.Location = New System.Drawing.Point(156, 69)
        Me.txtKd_Jenis.MaxLength = 3
        Me.txtKd_Jenis.Name = "txtKd_Jenis"
        Me.txtKd_Jenis.ReadOnly = True
        Me.txtKd_Jenis.Size = New System.Drawing.Size(207, 29)
        Me.txtKd_Jenis.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 24)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Jenis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Kode Jenis"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnClose)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnEdit)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 64)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(401, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(91, 34)
        Me.btnClose.TabIndex = 26
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(302, 19)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(91, 34)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(203, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(91, 34)
        Me.btnDelete.TabIndex = 24
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(104, 19)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(91, 34)
        Me.btnEdit.TabIndex = 23
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(5, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 35)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'grdJenis
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Cyan
        Me.grdJenis.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.grdJenis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdJenis.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdJenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdJenis.Location = New System.Drawing.Point(12, 285)
        Me.grdJenis.Name = "grdJenis"
        Me.grdJenis.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdJenis.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grdJenis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdJenis.Size = New System.Drawing.Size(516, 325)
        Me.grdJenis.TabIndex = 28
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdJenis)
        Me.GroupBox2.Controls.Add(Me.rdKode)
        Me.GroupBox2.Controls.Add(Me.txtCari)
        Me.GroupBox2.Font = New System.Drawing.Font("Monotype Corsiva", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(516, 55)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Masukkan Jenis Barang"
        '
        'rdJenis
        '
        Me.rdJenis.AutoSize = True
        Me.rdJenis.ForeColor = System.Drawing.Color.White
        Me.rdJenis.Location = New System.Drawing.Point(94, 27)
        Me.rdJenis.Name = "rdJenis"
        Me.rdJenis.Size = New System.Drawing.Size(50, 20)
        Me.rdJenis.TabIndex = 27
        Me.rdJenis.TabStop = True
        Me.rdJenis.Text = "Jenis"
        Me.rdJenis.UseVisualStyleBackColor = True
        '
        'rdKode
        '
        Me.rdKode.AutoSize = True
        Me.rdKode.ForeColor = System.Drawing.Color.White
        Me.rdKode.Location = New System.Drawing.Point(6, 27)
        Me.rdKode.Name = "rdKode"
        Me.rdKode.Size = New System.Drawing.Size(52, 20)
        Me.rdKode.TabIndex = 26
        Me.rdKode.TabStop = True
        Me.rdKode.Text = "Kode"
        Me.rdKode.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCari.Location = New System.Drawing.Point(192, 20)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(312, 29)
        Me.txtCari.TabIndex = 25
        '
        'frmJenis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(543, 622)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grdJenis)
        Me.Controls.Add(Me.txtJenis)
        Me.Controls.Add(Me.txtKd_Jenis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmJenis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmJenis"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdJenis, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtJenis As System.Windows.Forms.TextBox
    Friend WithEvents txtKd_Jenis As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grdJenis As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents rdJenis As System.Windows.Forms.RadioButton
    Friend WithEvents rdKode As System.Windows.Forms.RadioButton
End Class
