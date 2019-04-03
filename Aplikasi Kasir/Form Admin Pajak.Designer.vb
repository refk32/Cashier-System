<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin_Pajak
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NicknameTB = New System.Windows.Forms.TextBox()
        Me.NamaTB = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BackBT = New System.Windows.Forms.Button()
        Me.DeleteBT = New System.Windows.Forms.Button()
        Me.InsertBT = New System.Windows.Forms.Button()
        Me.EditRadio = New System.Windows.Forms.RadioButton()
        Me.InputRadio = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PersenNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NicknameLBL = New System.Windows.Forms.Label()
        Me.NamaLBL = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersenNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NicknameTB
        '
        Me.NicknameTB.Enabled = False
        Me.NicknameTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NicknameTB.Location = New System.Drawing.Point(772, 227)
        Me.NicknameTB.MaxLength = 10
        Me.NicknameTB.Name = "NicknameTB"
        Me.NicknameTB.Size = New System.Drawing.Size(288, 40)
        Me.NicknameTB.TabIndex = 0
        '
        'NamaTB
        '
        Me.NamaTB.Enabled = False
        Me.NamaTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaTB.Location = New System.Drawing.Point(772, 336)
        Me.NamaTB.MaxLength = 30
        Me.NamaTB.Name = "NamaTB"
        Me.NamaTB.Size = New System.Drawing.Size(288, 40)
        Me.NamaTB.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(18, 80)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(549, 764)
        Me.DataGridView1.TabIndex = 3
        '
        'BackBT
        '
        Me.BackBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBT.Location = New System.Drawing.Point(1443, 26)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(135, 89)
        Me.BackBT.TabIndex = 4
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'DeleteBT
        '
        Me.DeleteBT.Enabled = False
        Me.DeleteBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBT.Location = New System.Drawing.Point(810, 767)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(118, 77)
        Me.DeleteBT.TabIndex = 15
        Me.DeleteBT.Text = "Delete"
        Me.DeleteBT.UseVisualStyleBackColor = True
        '
        'InsertBT
        '
        Me.InsertBT.Enabled = False
        Me.InsertBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertBT.Location = New System.Drawing.Point(601, 767)
        Me.InsertBT.Name = "InsertBT"
        Me.InsertBT.Size = New System.Drawing.Size(114, 77)
        Me.InsertBT.TabIndex = 14
        Me.InsertBT.Text = "Save"
        Me.InsertBT.UseVisualStyleBackColor = True
        '
        'EditRadio
        '
        Me.EditRadio.AutoSize = True
        Me.EditRadio.Font = New System.Drawing.Font("Microsoft YaHei UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditRadio.Location = New System.Drawing.Point(601, 149)
        Me.EditRadio.Name = "EditRadio"
        Me.EditRadio.Size = New System.Drawing.Size(103, 47)
        Me.EditRadio.TabIndex = 13
        Me.EditRadio.TabStop = True
        Me.EditRadio.Text = "Edit"
        Me.EditRadio.UseVisualStyleBackColor = True
        '
        'InputRadio
        '
        Me.InputRadio.AutoSize = True
        Me.InputRadio.Font = New System.Drawing.Font("Microsoft YaHei UI", 25.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputRadio.Location = New System.Drawing.Point(601, 80)
        Me.InputRadio.Name = "InputRadio"
        Me.InputRadio.Size = New System.Drawing.Size(129, 47)
        Me.InputRadio.TabIndex = 12
        Me.InputRadio.TabStop = True
        Me.InputRadio.Text = "Input"
        Me.InputRadio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(595, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 33)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nickname"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(648, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 33)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(634, 455)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 33)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Persen"
        '
        'PersenNUD
        '
        Me.PersenNUD.Enabled = False
        Me.PersenNUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersenNUD.Location = New System.Drawing.Point(772, 448)
        Me.PersenNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PersenNUD.Name = "PersenNUD"
        Me.PersenNUD.Size = New System.Drawing.Size(87, 40)
        Me.PersenNUD.TabIndex = 21
        Me.PersenNUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(865, 450)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 33)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "%"
        '
        'NicknameLBL
        '
        Me.NicknameLBL.AutoSize = True
        Me.NicknameLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NicknameLBL.ForeColor = System.Drawing.Color.Red
        Me.NicknameLBL.Location = New System.Drawing.Point(1066, 234)
        Me.NicknameLBL.Name = "NicknameLBL"
        Me.NicknameLBL.Size = New System.Drawing.Size(102, 33)
        Me.NicknameLBL.TabIndex = 23
        Me.NicknameLBL.Text = "Label5"
        Me.NicknameLBL.Visible = False
        '
        'NamaLBL
        '
        Me.NamaLBL.AutoSize = True
        Me.NamaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaLBL.ForeColor = System.Drawing.Color.Red
        Me.NamaLBL.Location = New System.Drawing.Point(1066, 339)
        Me.NamaLBL.Name = "NamaLBL"
        Me.NamaLBL.Size = New System.Drawing.Size(102, 33)
        Me.NamaLBL.TabIndex = 24
        Me.NamaLBL.Text = "Label6"
        Me.NamaLBL.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 33)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Form Pajak"
        '
        'Form_Admin_Pajak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NamaLBL)
        Me.Controls.Add(Me.NicknameLBL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PersenNUD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DeleteBT)
        Me.Controls.Add(Me.InsertBT)
        Me.Controls.Add(Me.EditRadio)
        Me.Controls.Add(Me.InputRadio)
        Me.Controls.Add(Me.BackBT)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.NamaTB)
        Me.Controls.Add(Me.NicknameTB)
        Me.Name = "Form_Admin_Pajak"
        Me.Text = "Form_Admin_Pajak"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersenNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NicknameTB As TextBox
    Friend WithEvents NamaTB As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackBT As Button
    Friend WithEvents DeleteBT As Button
    Friend WithEvents InsertBT As Button
    Friend WithEvents EditRadio As RadioButton
    Friend WithEvents InputRadio As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PersenNUD As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents NicknameLBL As Label
    Friend WithEvents NamaLBL As Label
    Friend WithEvents Label5 As Label
End Class
