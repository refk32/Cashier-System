<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin_Karyawan_Edit
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
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.PertanyaanCB = New System.Windows.Forms.ComboBox()
        Me.JawabanTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.IDTB = New System.Windows.Forms.TextBox()
        Me.JabatanCB = New System.Windows.Forms.ComboBox()
        Me.JenisKelaminCB = New System.Windows.Forms.ComboBox()
        Me.NamaTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.JawabanLBL = New System.Windows.Forms.Label()
        Me.PasswordLBL = New System.Windows.Forms.Label()
        Me.IDLBL = New System.Windows.Forms.Label()
        Me.NamaLBL = New System.Windows.Forms.Label()
        Me.BackBT = New System.Windows.Forms.Button()
        Me.ConfirmLBL = New System.Windows.Forms.Label()
        Me.ConfirmTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ConfirmCheck = New System.Windows.Forms.CheckBox()
        Me.PasswordCheck = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'SaveBT
        '
        Me.SaveBT.Location = New System.Drawing.Point(339, 420)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(75, 42)
        Me.SaveBT.TabIndex = 21
        Me.SaveBT.Text = "Save"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'PertanyaanCB
        '
        Me.PertanyaanCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PertanyaanCB.FormattingEnabled = True
        Me.PertanyaanCB.Items.AddRange(New Object() {"Siapa nama peliharaan anda ?", "Siapa nama guru pertama anda ?", "Apa nama sekolah SD anda ?", "Apa nama film favorit anda ?", "Apa nama Kartun favorit anda ?", "Siapa aktor kesukaan anda ?"})
        Me.PertanyaanCB.Location = New System.Drawing.Point(201, 322)
        Me.PertanyaanCB.Name = "PertanyaanCB"
        Me.PertanyaanCB.Size = New System.Drawing.Size(213, 21)
        Me.PertanyaanCB.TabIndex = 34
        '
        'JawabanTB
        '
        Me.JawabanTB.Location = New System.Drawing.Point(201, 372)
        Me.JawabanTB.MaxLength = 30
        Me.JawabanTB.Name = "JawabanTB"
        Me.JawabanTB.Size = New System.Drawing.Size(213, 20)
        Me.JawabanTB.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 370)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Jawaban Rahasia"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Pertanyaan Rahasia"
        '
        'PasswordTB
        '
        Me.PasswordTB.Location = New System.Drawing.Point(201, 238)
        Me.PasswordTB.MaxLength = 20
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTB.Size = New System.Drawing.Size(213, 20)
        Me.PasswordTB.TabIndex = 31
        '
        'IDTB
        '
        Me.IDTB.Enabled = False
        Me.IDTB.Location = New System.Drawing.Point(201, 190)
        Me.IDTB.MaxLength = 20
        Me.IDTB.Name = "IDTB"
        Me.IDTB.Size = New System.Drawing.Size(213, 20)
        Me.IDTB.TabIndex = 30
        '
        'JabatanCB
        '
        Me.JabatanCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JabatanCB.FormattingEnabled = True
        Me.JabatanCB.Items.AddRange(New Object() {"admin", "kasir"})
        Me.JabatanCB.Location = New System.Drawing.Point(201, 137)
        Me.JabatanCB.Name = "JabatanCB"
        Me.JabatanCB.Size = New System.Drawing.Size(213, 21)
        Me.JabatanCB.TabIndex = 29
        '
        'JenisKelaminCB
        '
        Me.JenisKelaminCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.JenisKelaminCB.FormattingEnabled = True
        Me.JenisKelaminCB.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.JenisKelaminCB.Items.AddRange(New Object() {"pria", "wanita"})
        Me.JenisKelaminCB.Location = New System.Drawing.Point(201, 79)
        Me.JenisKelaminCB.Name = "JenisKelaminCB"
        Me.JenisKelaminCB.Size = New System.Drawing.Size(213, 21)
        Me.JenisKelaminCB.TabIndex = 28
        '
        'NamaTB
        '
        Me.NamaTB.Location = New System.Drawing.Point(201, 27)
        Me.NamaTB.MaxLength = 50
        Me.NamaTB.Name = "NamaTB"
        Me.NamaTB.Size = New System.Drawing.Size(213, 20)
        Me.NamaTB.TabIndex = 27
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Jabatan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Jenis Kelamin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Nama"
        '
        'JawabanLBL
        '
        Me.JawabanLBL.AutoSize = True
        Me.JawabanLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JawabanLBL.ForeColor = System.Drawing.Color.Red
        Me.JawabanLBL.Location = New System.Drawing.Point(447, 376)
        Me.JawabanLBL.Name = "JawabanLBL"
        Me.JawabanLBL.Size = New System.Drawing.Size(56, 16)
        Me.JawabanLBL.TabIndex = 39
        Me.JawabanLBL.Text = "Label11"
        Me.JawabanLBL.Visible = False
        '
        'PasswordLBL
        '
        Me.PasswordLBL.AutoSize = True
        Me.PasswordLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLBL.ForeColor = System.Drawing.Color.Red
        Me.PasswordLBL.Location = New System.Drawing.Point(482, 241)
        Me.PasswordLBL.Name = "PasswordLBL"
        Me.PasswordLBL.Size = New System.Drawing.Size(56, 16)
        Me.PasswordLBL.TabIndex = 38
        Me.PasswordLBL.Text = "Label10"
        Me.PasswordLBL.Visible = False
        '
        'IDLBL
        '
        Me.IDLBL.AutoSize = True
        Me.IDLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLBL.ForeColor = System.Drawing.Color.Red
        Me.IDLBL.Location = New System.Drawing.Point(447, 194)
        Me.IDLBL.Name = "IDLBL"
        Me.IDLBL.Size = New System.Drawing.Size(49, 16)
        Me.IDLBL.TabIndex = 37
        Me.IDLBL.Text = "Label9"
        Me.IDLBL.Visible = False
        '
        'NamaLBL
        '
        Me.NamaLBL.AutoSize = True
        Me.NamaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaLBL.ForeColor = System.Drawing.Color.Red
        Me.NamaLBL.Location = New System.Drawing.Point(447, 31)
        Me.NamaLBL.Name = "NamaLBL"
        Me.NamaLBL.Size = New System.Drawing.Size(49, 16)
        Me.NamaLBL.TabIndex = 36
        Me.NamaLBL.Text = "Label8"
        Me.NamaLBL.Visible = False
        '
        'BackBT
        '
        Me.BackBT.Location = New System.Drawing.Point(854, 15)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(88, 42)
        Me.BackBT.TabIndex = 40
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'ConfirmLBL
        '
        Me.ConfirmLBL.AutoSize = True
        Me.ConfirmLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmLBL.ForeColor = System.Drawing.Color.Red
        Me.ConfirmLBL.Location = New System.Drawing.Point(482, 283)
        Me.ConfirmLBL.Name = "ConfirmLBL"
        Me.ConfirmLBL.Size = New System.Drawing.Size(56, 16)
        Me.ConfirmLBL.TabIndex = 43
        Me.ConfirmLBL.Text = "Label10"
        Me.ConfirmLBL.Visible = False
        '
        'ConfirmTB
        '
        Me.ConfirmTB.Location = New System.Drawing.Point(201, 278)
        Me.ConfirmTB.MaxLength = 20
        Me.ConfirmTB.Name = "ConfirmTB"
        Me.ConfirmTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ConfirmTB.Size = New System.Drawing.Size(213, 20)
        Me.ConfirmTB.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(156, 20)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Konfirmasi Password"
        '
        'ConfirmCheck
        '
        Me.ConfirmCheck.AutoSize = True
        Me.ConfirmCheck.Location = New System.Drawing.Point(420, 280)
        Me.ConfirmCheck.Name = "ConfirmCheck"
        Me.ConfirmCheck.Size = New System.Drawing.Size(56, 17)
        Me.ConfirmCheck.TabIndex = 45
        Me.ConfirmCheck.Text = "Visible"
        Me.ConfirmCheck.UseVisualStyleBackColor = True
        '
        'PasswordCheck
        '
        Me.PasswordCheck.AutoSize = True
        Me.PasswordCheck.Location = New System.Drawing.Point(420, 242)
        Me.PasswordCheck.Name = "PasswordCheck"
        Me.PasswordCheck.Size = New System.Drawing.Size(56, 17)
        Me.PasswordCheck.TabIndex = 44
        Me.PasswordCheck.Text = "Visible"
        Me.PasswordCheck.UseVisualStyleBackColor = True
        '
        'Form_Admin_Karyawan_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 595)
        Me.Controls.Add(Me.ConfirmCheck)
        Me.Controls.Add(Me.PasswordCheck)
        Me.Controls.Add(Me.ConfirmLBL)
        Me.Controls.Add(Me.ConfirmTB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BackBT)
        Me.Controls.Add(Me.JawabanLBL)
        Me.Controls.Add(Me.PasswordLBL)
        Me.Controls.Add(Me.IDLBL)
        Me.Controls.Add(Me.NamaLBL)
        Me.Controls.Add(Me.PertanyaanCB)
        Me.Controls.Add(Me.JawabanTB)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.IDTB)
        Me.Controls.Add(Me.JabatanCB)
        Me.Controls.Add(Me.JenisKelaminCB)
        Me.Controls.Add(Me.NamaTB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveBT)
        Me.Name = "Form_Admin_Karyawan_Edit"
        Me.Text = "Form_Admin_Karyawan_Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveBT As Button
    Friend WithEvents PertanyaanCB As ComboBox
    Friend WithEvents JawabanTB As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents IDTB As TextBox
    Friend WithEvents JabatanCB As ComboBox
    Friend WithEvents JenisKelaminCB As ComboBox
    Friend WithEvents NamaTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents JawabanLBL As Label
    Friend WithEvents PasswordLBL As Label
    Friend WithEvents IDLBL As Label
    Friend WithEvents NamaLBL As Label
    Friend WithEvents BackBT As Button
    Friend WithEvents ConfirmLBL As Label
    Friend WithEvents ConfirmTB As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ConfirmCheck As CheckBox
    Friend WithEvents PasswordCheck As CheckBox
End Class
