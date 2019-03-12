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
        Me.ConfirmTB = New System.Windows.Forms.TextBox()
        Me.OkBT = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordLBL = New System.Windows.Forms.Label()
        Me.PasswordTB2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PasswordLBL2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password"
        '
        'ConfirmTB
        '
        Me.ConfirmTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmTB.Location = New System.Drawing.Point(196, 128)
        Me.ConfirmTB.MaxLength = 20
        Me.ConfirmTB.Name = "ConfirmTB"
        Me.ConfirmTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.ConfirmTB.Size = New System.Drawing.Size(236, 29)
        Me.ConfirmTB.TabIndex = 1
        '
        'OkBT
        '
        Me.OkBT.Enabled = False
        Me.OkBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OkBT.Location = New System.Drawing.Point(283, 246)
        Me.OkBT.Name = "OkBT"
        Me.OkBT.Size = New System.Drawing.Size(107, 40)
        Me.OkBT.TabIndex = 3
        Me.OkBT.Text = "Ok"
        Me.OkBT.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 31)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ubah Password"
        '
        'PasswordLBL
        '
        Me.PasswordLBL.AutoSize = True
        Me.PasswordLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLBL.ForeColor = System.Drawing.Color.Red
        Me.PasswordLBL.Location = New System.Drawing.Point(438, 137)
        Me.PasswordLBL.Name = "PasswordLBL"
        Me.PasswordLBL.Size = New System.Drawing.Size(66, 20)
        Me.PasswordLBL.TabIndex = 19
        Me.PasswordLBL.Text = "Label10"
        Me.PasswordLBL.Visible = False
        '
        'PasswordTB2
        '
        Me.PasswordTB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTB2.Location = New System.Drawing.Point(196, 181)
        Me.PasswordTB2.MaxLength = 20
        Me.PasswordTB2.Name = "PasswordTB2"
        Me.PasswordTB2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTB2.Size = New System.Drawing.Size(236, 29)
        Me.PasswordTB2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Konfimasi Password"
        '
        'PasswordLBL2
        '
        Me.PasswordLBL2.AutoSize = True
        Me.PasswordLBL2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLBL2.ForeColor = System.Drawing.Color.Red
        Me.PasswordLBL2.Location = New System.Drawing.Point(438, 190)
        Me.PasswordLBL2.Name = "PasswordLBL2"
        Me.PasswordLBL2.Size = New System.Drawing.Size(66, 20)
        Me.PasswordLBL2.TabIndex = 22
        Me.PasswordLBL2.Text = "Label10"
        Me.PasswordLBL2.Visible = False
        '
        'Form_Ubah_Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 332)
        Me.Controls.Add(Me.PasswordLBL2)
        Me.Controls.Add(Me.PasswordTB2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PasswordLBL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OkBT)
        Me.Controls.Add(Me.ConfirmTB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Ubah_Password"
        Me.Text = "Form_Ubah_Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ConfirmTB As TextBox
    Friend WithEvents OkBT As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordLBL As Label
    Friend WithEvents PasswordTB2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PasswordLBL2 As Label
End Class
