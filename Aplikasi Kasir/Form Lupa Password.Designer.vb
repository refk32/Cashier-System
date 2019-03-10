<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Lupa_Password
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IDTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.JawabanTB = New System.Windows.Forms.TextBox()
        Me.JawabanLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OkBT = New System.Windows.Forms.Button()
        Me.ContinueBT = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BackBT = New System.Windows.Forms.Button()
        Me.PertanyaanCB = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'IDTB
        '
        Me.IDTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTB.Location = New System.Drawing.Point(91, 19)
        Me.IDTB.Name = "IDTB"
        Me.IDTB.Size = New System.Drawing.Size(296, 26)
        Me.IDTB.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(136, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(265, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lupa Password ?"
        '
        'JawabanTB
        '
        Me.JawabanTB.Enabled = False
        Me.JawabanTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JawabanTB.Location = New System.Drawing.Point(143, 343)
        Me.JawabanTB.Name = "JawabanTB"
        Me.JawabanTB.Size = New System.Drawing.Size(287, 26)
        Me.JawabanTB.TabIndex = 4
        '
        'JawabanLabel
        '
        Me.JawabanLabel.AutoSize = True
        Me.JawabanLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JawabanLabel.Location = New System.Drawing.Point(50, 349)
        Me.JawabanLabel.Name = "JawabanLabel"
        Me.JawabanLabel.Size = New System.Drawing.Size(73, 20)
        Me.JawabanLabel.TabIndex = 3
        Me.JawabanLabel.Text = "Jawaban"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 285)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pertanyaan"
        '
        'OkBT
        '
        Me.OkBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkBT.Location = New System.Drawing.Point(289, 75)
        Me.OkBT.Name = "OkBT"
        Me.OkBT.Size = New System.Drawing.Size(98, 38)
        Me.OkBT.TabIndex = 7
        Me.OkBT.Text = "Ok"
        Me.OkBT.UseVisualStyleBackColor = True
        '
        'ContinueBT
        '
        Me.ContinueBT.Enabled = False
        Me.ContinueBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueBT.Location = New System.Drawing.Point(332, 389)
        Me.ContinueBT.Name = "ContinueBT"
        Me.ContinueBT.Size = New System.Drawing.Size(98, 38)
        Me.ContinueBT.TabIndex = 8
        Me.ContinueBT.Text = "Lanjut"
        Me.ContinueBT.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IDTB)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.OkBT)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 138)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'BackBT
        '
        Me.BackBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBT.Location = New System.Drawing.Point(13, 13)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(73, 38)
        Me.BackBT.TabIndex = 10
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'PertanyaanCB
        '
        Me.PertanyaanCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PertanyaanCB.Enabled = False
        Me.PertanyaanCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PertanyaanCB.FormattingEnabled = True
        Me.PertanyaanCB.Items.AddRange(New Object() {"Siapa nama peliharaan anda ?", "Siapa nama guru pertama anda ?", "Apa nama sekolah SD anda ?", "Apa nama film favorit anda ?", "Apa nama Kartun favorit anda ?", "Siapa aktor kesukaan anda ?"})
        Me.PertanyaanCB.Location = New System.Drawing.Point(143, 284)
        Me.PertanyaanCB.Name = "PertanyaanCB"
        Me.PertanyaanCB.Size = New System.Drawing.Size(281, 28)
        Me.PertanyaanCB.TabIndex = 16
        '
        'Form_Lupa_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 450)
        Me.Controls.Add(Me.PertanyaanCB)
        Me.Controls.Add(Me.BackBT)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ContinueBT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.JawabanTB)
        Me.Controls.Add(Me.JawabanLabel)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Form_Lupa_Password"
        Me.Text = "Form_Lupa_Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IDTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents JawabanTB As TextBox
    Friend WithEvents JawabanLabel As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents OkBT As Button
    Friend WithEvents ContinueBT As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackBT As Button
    Friend WithEvents PertanyaanCB As ComboBox
End Class
