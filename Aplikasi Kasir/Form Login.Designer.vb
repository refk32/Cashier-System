<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idTB = New System.Windows.Forms.TextBox()
        Me.passTB = New System.Windows.Forms.TextBox()
        Me.LoginBT = New System.Windows.Forms.Button()
        Me.LupaPasswordBT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(351, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(188, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(188, 213)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'idTB
        '
        Me.idTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idTB.Location = New System.Drawing.Point(296, 157)
        Me.idTB.Name = "idTB"
        Me.idTB.Size = New System.Drawing.Size(302, 29)
        Me.idTB.TabIndex = 3
        '
        'passTB
        '
        Me.passTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passTB.Location = New System.Drawing.Point(296, 214)
        Me.passTB.Name = "passTB"
        Me.passTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passTB.Size = New System.Drawing.Size(302, 29)
        Me.passTB.TabIndex = 4
        '
        'LoginBT
        '
        Me.LoginBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBT.Location = New System.Drawing.Point(355, 295)
        Me.LoginBT.Name = "LoginBT"
        Me.LoginBT.Size = New System.Drawing.Size(128, 71)
        Me.LoginBT.TabIndex = 5
        Me.LoginBT.Text = "Login"
        Me.LoginBT.UseVisualStyleBackColor = True
        '
        'LupaPasswordBT
        '
        Me.LupaPasswordBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LupaPasswordBT.Location = New System.Drawing.Point(638, 379)
        Me.LupaPasswordBT.Name = "LupaPasswordBT"
        Me.LupaPasswordBT.Size = New System.Drawing.Size(106, 59)
        Me.LupaPasswordBT.TabIndex = 6
        Me.LupaPasswordBT.Text = "Lupa Password ?"
        Me.LupaPasswordBT.UseVisualStyleBackColor = True
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.LupaPasswordBT)
        Me.Controls.Add(Me.LoginBT)
        Me.Controls.Add(Me.passTB)
        Me.Controls.Add(Me.idTB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents idTB As TextBox
    Friend WithEvents passTB As TextBox
    Friend WithEvents LoginBT As Button
    Friend WithEvents LupaPasswordBT As Button
End Class
