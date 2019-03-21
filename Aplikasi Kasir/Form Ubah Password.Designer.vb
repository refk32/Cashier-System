<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Ubah_Password
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PasswordTB = New System.Windows.Forms.TextBox()
        Me.OkBT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordLBL = New System.Windows.Forms.Label()
        Me.ConfirmTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConfirmLBL = New System.Windows.Forms.Label()
        Me.ConfirmCheck = New System.Windows.Forms.CheckBox()
        Me.PasswordCheck = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(494, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password"
        '
        'PasswordTB
        '
        Me.PasswordTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTB.Location = New System.Drawing.Point(643, 311)
        Me.PasswordTB.MaxLength = 20
        Me.PasswordTB.Name = "PasswordTB"
        Me.PasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTB.Size = New System.Drawing.Size(319, 40)
        Me.PasswordTB.TabIndex = 1
        '
        'OkBT
        '
        Me.OkBT.Enabled = False
        Me.OkBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkBT.Location = New System.Drawing.Point(734, 498)
        Me.OkBT.Name = "OkBT"
        Me.OkBT.Size = New System.Drawing.Size(137, 78)
        Me.OkBT.TabIndex = 3
        Me.OkBT.Text = "Ok"
        Me.OkBT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(672, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 39)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ubah Password"
        '
        'PasswordLBL
        '
        Me.PasswordLBL.AutoSize = True
        Me.PasswordLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLBL.ForeColor = System.Drawing.Color.Red
        Me.PasswordLBL.Location = New System.Drawing.Point(1095, 314)
        Me.PasswordLBL.Name = "PasswordLBL"
        Me.PasswordLBL.Size = New System.Drawing.Size(118, 33)
        Me.PasswordLBL.TabIndex = 19
        Me.PasswordLBL.Text = "Label10"
        Me.PasswordLBL.Visible = False
        '
        'ConfirmTB
        '
        Me.ConfirmTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmTB.Location = New System.Drawing.Point(643, 413)
        Me.ConfirmTB.MaxLength = 20
        Me.ConfirmTB.Name = "ConfirmTB"
        Me.ConfirmTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ConfirmTB.Size = New System.Drawing.Size(319, 40)
        Me.ConfirmTB.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 416)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 33)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Konfimasi Password"
        '
        'ConfirmLBL
        '
        Me.ConfirmLBL.AutoSize = True
        Me.ConfirmLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmLBL.ForeColor = System.Drawing.Color.Red
        Me.ConfirmLBL.Location = New System.Drawing.Point(1095, 420)
        Me.ConfirmLBL.Name = "ConfirmLBL"
        Me.ConfirmLBL.Size = New System.Drawing.Size(118, 33)
        Me.ConfirmLBL.TabIndex = 22
        Me.ConfirmLBL.Text = "Label10"
        Me.ConfirmLBL.Visible = False
        '
        'ConfirmCheck
        '
        Me.ConfirmCheck.AutoSize = True
        Me.ConfirmCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmCheck.Location = New System.Drawing.Point(968, 416)
        Me.ConfirmCheck.Name = "ConfirmCheck"
        Me.ConfirmCheck.Size = New System.Drawing.Size(121, 37)
        Me.ConfirmCheck.TabIndex = 27
        Me.ConfirmCheck.Text = "Visible"
        Me.ConfirmCheck.UseVisualStyleBackColor = True
        '
        'PasswordCheck
        '
        Me.PasswordCheck.AutoSize = True
        Me.PasswordCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordCheck.Location = New System.Drawing.Point(968, 314)
        Me.PasswordCheck.Name = "PasswordCheck"
        Me.PasswordCheck.Size = New System.Drawing.Size(121, 37)
        Me.PasswordCheck.TabIndex = 26
        Me.PasswordCheck.Text = "Visible"
        Me.PasswordCheck.UseVisualStyleBackColor = True
        '
        'Form_Ubah_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.ConfirmCheck)
        Me.Controls.Add(Me.PasswordCheck)
        Me.Controls.Add(Me.ConfirmLBL)
        Me.Controls.Add(Me.ConfirmTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PasswordLBL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OkBT)
        Me.Controls.Add(Me.PasswordTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Ubah_Password"
        Me.Text = "Form_Ubah_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PasswordTB As TextBox
    Friend WithEvents OkBT As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordLBL As Label
    Friend WithEvents ConfirmTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ConfirmLBL As Label
    Friend WithEvents ConfirmCheck As CheckBox
    Friend WithEvents PasswordCheck As CheckBox
End Class
