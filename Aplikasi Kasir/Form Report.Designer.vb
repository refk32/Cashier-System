<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Report
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
        Me.IDTRTB = New System.Windows.Forms.TextBox()
        Me.IDTRLB = New System.Windows.Forms.ListBox()
        Me.ReportDetailTRBT = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.KaryawanCB = New System.Windows.Forms.ComboBox()
        Me.ReportBT = New System.Windows.Forms.Button()
        Me.TransaksiRB = New System.Windows.Forms.RadioButton()
        Me.MenuRB = New System.Windows.Forms.RadioButton()
        Me.KaryawanRB = New System.Windows.Forms.RadioButton()
        Me.BackBT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IDTRTB
        '
        Me.IDTRTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTRTB.Location = New System.Drawing.Point(279, 337)
        Me.IDTRTB.Name = "IDTRTB"
        Me.IDTRTB.Size = New System.Drawing.Size(228, 40)
        Me.IDTRTB.TabIndex = 19
        '
        'IDTRLB
        '
        Me.IDTRLB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTRLB.FormattingEnabled = True
        Me.IDTRLB.ItemHeight = 33
        Me.IDTRLB.Location = New System.Drawing.Point(279, 392)
        Me.IDTRLB.Name = "IDTRLB"
        Me.IDTRLB.Size = New System.Drawing.Size(228, 103)
        Me.IDTRLB.TabIndex = 18
        '
        'ReportDetailTRBT
        '
        Me.ReportDetailTRBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportDetailTRBT.Location = New System.Drawing.Point(31, 428)
        Me.ReportDetailTRBT.Name = "ReportDetailTRBT"
        Me.ReportDetailTRBT.Size = New System.Drawing.Size(215, 158)
        Me.ReportDetailTRBT.TabIndex = 16
        Me.ReportDetailTRBT.Text = "Report Detail Transaksi"
        Me.ReportDetailTRBT.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.KaryawanCB)
        Me.GroupBox1.Controls.Add(Me.ReportBT)
        Me.GroupBox1.Controls.Add(Me.IDTRTB)
        Me.GroupBox1.Controls.Add(Me.TransaksiRB)
        Me.GroupBox1.Controls.Add(Me.IDTRLB)
        Me.GroupBox1.Controls.Add(Me.MenuRB)
        Me.GroupBox1.Controls.Add(Me.KaryawanRB)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(802, 521)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report"
        '
        'KaryawanCB
        '
        Me.KaryawanCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KaryawanCB.Enabled = False
        Me.KaryawanCB.FormattingEnabled = True
        Me.KaryawanCB.Location = New System.Drawing.Point(446, 159)
        Me.KaryawanCB.Name = "KaryawanCB"
        Me.KaryawanCB.Size = New System.Drawing.Size(266, 41)
        Me.KaryawanCB.TabIndex = 8
        '
        'ReportBT
        '
        Me.ReportBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportBT.Location = New System.Drawing.Point(19, 39)
        Me.ReportBT.Name = "ReportBT"
        Me.ReportBT.Size = New System.Drawing.Size(204, 158)
        Me.ReportBT.TabIndex = 4
        Me.ReportBT.Text = "Report"
        Me.ReportBT.UseVisualStyleBackColor = True
        '
        'TransaksiRB
        '
        Me.TransaksiRB.AutoSize = True
        Me.TransaksiRB.Location = New System.Drawing.Point(279, 159)
        Me.TransaksiRB.Name = "TransaksiRB"
        Me.TransaksiRB.Size = New System.Drawing.Size(161, 37)
        Me.TransaksiRB.TabIndex = 7
        Me.TransaksiRB.TabStop = True
        Me.TransaksiRB.Text = "Transaksi"
        Me.TransaksiRB.UseVisualStyleBackColor = True
        '
        'MenuRB
        '
        Me.MenuRB.AutoSize = True
        Me.MenuRB.Location = New System.Drawing.Point(279, 98)
        Me.MenuRB.Name = "MenuRB"
        Me.MenuRB.Size = New System.Drawing.Size(232, 37)
        Me.MenuRB.TabIndex = 6
        Me.MenuRB.TabStop = True
        Me.MenuRB.Text = "Menu Makanan"
        Me.MenuRB.UseVisualStyleBackColor = True
        '
        'KaryawanRB
        '
        Me.KaryawanRB.AutoSize = True
        Me.KaryawanRB.Location = New System.Drawing.Point(279, 37)
        Me.KaryawanRB.Name = "KaryawanRB"
        Me.KaryawanRB.Size = New System.Drawing.Size(162, 37)
        Me.KaryawanRB.TabIndex = 5
        Me.KaryawanRB.TabStop = True
        Me.KaryawanRB.Text = "Karyawan"
        Me.KaryawanRB.UseVisualStyleBackColor = True
        '
        'BackBT
        '
        Me.BackBT.Location = New System.Drawing.Point(1497, 12)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(95, 56)
        Me.BackBT.TabIndex = 20
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 39)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Form Report"
        '
        'Form_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBT)
        Me.Controls.Add(Me.ReportDetailTRBT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Report"
        Me.Text = "Form_Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDTRTB As TextBox
    Friend WithEvents IDTRLB As ListBox
    Friend WithEvents ReportDetailTRBT As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents KaryawanCB As ComboBox
    Friend WithEvents ReportBT As Button
    Friend WithEvents TransaksiRB As RadioButton
    Friend WithEvents MenuRB As RadioButton
    Friend WithEvents KaryawanRB As RadioButton
    Friend WithEvents BackBT As Button
    Friend WithEvents Label1 As Label
End Class
