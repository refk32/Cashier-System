﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin
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
        Me.NamaLBL = New System.Windows.Forms.Label()
        Me.IDLBL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LogOutBT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(321, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Admin"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(595, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Welcome"
        '
        'NamaLBL
        '
        Me.NamaLBL.AutoSize = True
        Me.NamaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaLBL.Location = New System.Drawing.Point(690, 9)
        Me.NamaLBL.Name = "NamaLBL"
        Me.NamaLBL.Size = New System.Drawing.Size(81, 20)
        Me.NamaLBL.TabIndex = 4
        Me.NamaLBL.Text = "NamaText"
        '
        'IDLBL
        '
        Me.IDLBL.AutoSize = True
        Me.IDLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDLBL.Location = New System.Drawing.Point(690, 54)
        Me.IDLBL.Name = "IDLBL"
        Me.IDLBL.Size = New System.Drawing.Size(81, 20)
        Me.IDLBL.TabIndex = 5
        Me.IDLBL.Text = "NamaText"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(595, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ID"
        '
        'LogOutBT
        '
        Me.LogOutBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutBT.Location = New System.Drawing.Point(262, 148)
        Me.LogOutBT.Name = "LogOutBT"
        Me.LogOutBT.Size = New System.Drawing.Size(236, 170)
        Me.LogOutBT.TabIndex = 9
        Me.LogOutBT.Text = "Log Out"
        Me.LogOutBT.UseVisualStyleBackColor = True
        '
        'Form_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 450)
        Me.Controls.Add(Me.LogOutBT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IDLBL)
        Me.Controls.Add(Me.NamaLBL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Admin"
        Me.Text = "Form_Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NamaLBL As Label
    Friend WithEvents IDLBL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LogOutBT As Button
End Class