<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin_Menu_Edit
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HargaTB = New System.Windows.Forms.TextBox()
        Me.NamaMakananTB = New System.Windows.Forms.TextBox()
        Me.KodeMakananTB = New System.Windows.Forms.TextBox()
        Me.HargaLBL = New System.Windows.Forms.Label()
        Me.NamaMakananLBL = New System.Windows.Forms.Label()
        Me.KodeMakananLBL = New System.Windows.Forms.Label()
        Me.BackBT = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SaveBT
        '
        Me.SaveBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBT.Location = New System.Drawing.Point(277, 654)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(141, 101)
        Me.SaveBT.TabIndex = 13
        Me.SaveBT.Text = "Save"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(177, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 33)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Harga"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 33)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nama Makanan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 33)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Kode Makanan"
        '
        'HargaTB
        '
        Me.HargaTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaTB.Location = New System.Drawing.Point(277, 425)
        Me.HargaTB.Name = "HargaTB"
        Me.HargaTB.Size = New System.Drawing.Size(323, 40)
        Me.HargaTB.TabIndex = 9
        '
        'NamaMakananTB
        '
        Me.NamaMakananTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaMakananTB.Location = New System.Drawing.Point(277, 299)
        Me.NamaMakananTB.MaxLength = 25
        Me.NamaMakananTB.Name = "NamaMakananTB"
        Me.NamaMakananTB.Size = New System.Drawing.Size(323, 40)
        Me.NamaMakananTB.TabIndex = 8
        '
        'KodeMakananTB
        '
        Me.KodeMakananTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeMakananTB.Location = New System.Drawing.Point(277, 173)
        Me.KodeMakananTB.MaxLength = 10
        Me.KodeMakananTB.Name = "KodeMakananTB"
        Me.KodeMakananTB.ReadOnly = True
        Me.KodeMakananTB.Size = New System.Drawing.Size(323, 40)
        Me.KodeMakananTB.TabIndex = 7
        '
        'HargaLBL
        '
        Me.HargaLBL.AutoSize = True
        Me.HargaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaLBL.ForeColor = System.Drawing.Color.Red
        Me.HargaLBL.Location = New System.Drawing.Point(619, 432)
        Me.HargaLBL.Name = "HargaLBL"
        Me.HargaLBL.Size = New System.Drawing.Size(102, 33)
        Me.HargaLBL.TabIndex = 16
        Me.HargaLBL.Text = "Label6"
        Me.HargaLBL.Visible = False
        '
        'NamaMakananLBL
        '
        Me.NamaMakananLBL.AutoSize = True
        Me.NamaMakananLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaMakananLBL.ForeColor = System.Drawing.Color.Red
        Me.NamaMakananLBL.Location = New System.Drawing.Point(619, 306)
        Me.NamaMakananLBL.Name = "NamaMakananLBL"
        Me.NamaMakananLBL.Size = New System.Drawing.Size(102, 33)
        Me.NamaMakananLBL.TabIndex = 15
        Me.NamaMakananLBL.Text = "Label5"
        Me.NamaMakananLBL.Visible = False
        '
        'KodeMakananLBL
        '
        Me.KodeMakananLBL.AutoSize = True
        Me.KodeMakananLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeMakananLBL.ForeColor = System.Drawing.Color.Red
        Me.KodeMakananLBL.Location = New System.Drawing.Point(619, 180)
        Me.KodeMakananLBL.Name = "KodeMakananLBL"
        Me.KodeMakananLBL.Size = New System.Drawing.Size(102, 33)
        Me.KodeMakananLBL.TabIndex = 14
        Me.KodeMakananLBL.Text = "Label4"
        Me.KodeMakananLBL.Visible = False
        '
        'BackBT
        '
        Me.BackBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBT.Location = New System.Drawing.Point(1398, 28)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(127, 104)
        Me.BackBT.TabIndex = 17
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(35, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(277, 39)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Form Edit Menu"
        '
        'Form_Admin_Menu_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.Label4)
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
        Me.Name = "Form_Admin_Menu_Edit"
        Me.Text = "Form_Admin_Menu_Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveBT As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents HargaTB As TextBox
    Friend WithEvents NamaMakananTB As TextBox
    Friend WithEvents KodeMakananTB As TextBox
    Friend WithEvents HargaLBL As Label
    Friend WithEvents NamaMakananLBL As Label
    Friend WithEvents KodeMakananLBL As Label
    Friend WithEvents BackBT As Button
    Friend WithEvents Label4 As Label
End Class
