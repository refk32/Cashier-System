﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin_Menu_Input
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
        Me.components = New System.ComponentModel.Container()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.KodeMakananTB = New System.Windows.Forms.TextBox()
        Me.NamaMakananTB = New System.Windows.Forms.TextBox()
        Me.HargaTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.KodeMakananLBL = New System.Windows.Forms.Label()
        Me.NamaMakananLBL = New System.Windows.Forms.Label()
        Me.HargaLBL = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BackBT = New System.Windows.Forms.Button()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'KodeMakananTB
        '
        Me.KodeMakananTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeMakananTB.Location = New System.Drawing.Point(160, 64)
        Me.KodeMakananTB.MaxLength = 10
        Me.KodeMakananTB.Name = "KodeMakananTB"
        Me.KodeMakananTB.Size = New System.Drawing.Size(156, 26)
        Me.KodeMakananTB.TabIndex = 0
        '
        'NamaMakananTB
        '
        Me.NamaMakananTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaMakananTB.Location = New System.Drawing.Point(160, 124)
        Me.NamaMakananTB.MaxLength = 25
        Me.NamaMakananTB.Name = "NamaMakananTB"
        Me.NamaMakananTB.Size = New System.Drawing.Size(156, 26)
        Me.NamaMakananTB.TabIndex = 1
        '
        'HargaTB
        '
        Me.HargaTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaTB.Location = New System.Drawing.Point(160, 179)
        Me.HargaTB.Name = "HargaTB"
        Me.HargaTB.Size = New System.Drawing.Size(156, 26)
        Me.HargaTB.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Makanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Makanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Harga"
        '
        'SaveBT
        '
        Me.SaveBT.Enabled = False
        Me.SaveBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBT.Location = New System.Drawing.Point(230, 285)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(86, 43)
        Me.SaveBT.TabIndex = 6
        Me.SaveBT.Text = "Save"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'KodeMakananLBL
        '
        Me.KodeMakananLBL.AutoSize = True
        Me.KodeMakananLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeMakananLBL.ForeColor = System.Drawing.Color.Red
        Me.KodeMakananLBL.Location = New System.Drawing.Point(332, 64)
        Me.KodeMakananLBL.Name = "KodeMakananLBL"
        Me.KodeMakananLBL.Size = New System.Drawing.Size(49, 16)
        Me.KodeMakananLBL.TabIndex = 7
        Me.KodeMakananLBL.Text = "Label4"
        Me.KodeMakananLBL.Visible = False
        '
        'NamaMakananLBL
        '
        Me.NamaMakananLBL.AutoSize = True
        Me.NamaMakananLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaMakananLBL.ForeColor = System.Drawing.Color.Red
        Me.NamaMakananLBL.Location = New System.Drawing.Point(332, 124)
        Me.NamaMakananLBL.Name = "NamaMakananLBL"
        Me.NamaMakananLBL.Size = New System.Drawing.Size(49, 16)
        Me.NamaMakananLBL.TabIndex = 8
        Me.NamaMakananLBL.Text = "Label5"
        Me.NamaMakananLBL.Visible = False
        '
        'HargaLBL
        '
        Me.HargaLBL.AutoSize = True
        Me.HargaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaLBL.ForeColor = System.Drawing.Color.Red
        Me.HargaLBL.Location = New System.Drawing.Point(332, 179)
        Me.HargaLBL.Name = "HargaLBL"
        Me.HargaLBL.Size = New System.Drawing.Size(49, 16)
        Me.HargaLBL.TabIndex = 9
        Me.HargaLBL.Text = "Label6"
        Me.HargaLBL.Visible = False
        '
        'BackBT
        '
        Me.BackBT.Location = New System.Drawing.Point(510, 12)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(88, 42)
        Me.BackBT.TabIndex = 10
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'Form_Admin_Menu_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 340)
        Me.Controls.Add(Me.BackBT)
        Me.Controls.Add(Me.HargaLBL)
        Me.Controls.Add(Me.NamaMakananLBL)
        Me.Controls.Add(Me.KodeMakananLBL)
        Me.Controls.Add(Me.SaveBT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HargaTB)
        Me.Controls.Add(Me.NamaMakananTB)
        Me.Controls.Add(Me.KodeMakananTB)
        Me.Name = "Form_Admin_Menu_Input"
        Me.Text = "Form_Admin_Menu_Input"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HargaTB As TextBox
    Friend WithEvents NamaMakananTB As TextBox
    Friend WithEvents KodeMakananTB As TextBox
    Friend WithEvents SaveBT As Button
    Friend WithEvents HargaLBL As Label
    Friend WithEvents NamaMakananLBL As Label
    Friend WithEvents KodeMakananLBL As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BackBT As Button
End Class