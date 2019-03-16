<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Kasir
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
        Me.NamaLBL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IDLBL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LogOutBT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(708, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Kasir"
        '
        'NamaLBL
        '
        Me.NamaLBL.AutoSize = True
        Me.NamaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaLBL.Location = New System.Drawing.Point(1396, 41)
        Me.NamaLBL.Name = "NamaLBL"
        Me.NamaLBL.Size = New System.Drawing.Size(102, 33)
        Me.NamaLBL.TabIndex = 3
        Me.NamaLBL.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1245, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Welcome "
        '
        'IDLBL
        '
        Me.IDLBL.AutoSize = True
        Me.IDLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLBL.Location = New System.Drawing.Point(1396, 91)
        Me.IDLBL.Name = "IDLBL"
        Me.IDLBL.Size = New System.Drawing.Size(102, 33)
        Me.IDLBL.TabIndex = 7
        Me.IDLBL.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1245, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 33)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ID"
        '
        'LogOutBT
        '
        Me.LogOutBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutBT.Location = New System.Drawing.Point(727, 602)
        Me.LogOutBT.Name = "LogOutBT"
        Me.LogOutBT.Size = New System.Drawing.Size(150, 93)
        Me.LogOutBT.TabIndex = 9
        Me.LogOutBT.Text = "Log Out"
        Me.LogOutBT.UseVisualStyleBackColor = True
        '
        'Form_Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.LogOutBT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.IDLBL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NamaLBL)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Kasir"
        Me.Text = "`"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NamaLBL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents IDLBL As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LogOutBT As Button
End Class
