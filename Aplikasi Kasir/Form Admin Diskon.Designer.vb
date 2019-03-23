<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin_Diskon
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MinTB = New System.Windows.Forms.TextBox()
        Me.MaxTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InputRadio = New System.Windows.Forms.RadioButton()
        Me.EditRadio = New System.Windows.Forms.RadioButton()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.DeleteBT = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BackBT = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PotonganCheck = New System.Windows.Forms.CheckBox()
        Me.PotonganTB = New System.Windows.Forms.TextBox()
        Me.PersenNUD = New System.Windows.Forms.NumericUpDown()
        Me.MinLBL = New System.Windows.Forms.Label()
        Me.MaxLBL = New System.Windows.Forms.Label()
        Me.PotonganLBL = New System.Windows.Forms.Label()
        Me.MaxCheck = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersenNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 58)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(522, 789)
        Me.DataGridView1.TabIndex = 0
        '
        'MinTB
        '
        Me.MinTB.Enabled = False
        Me.MinTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinTB.Location = New System.Drawing.Point(811, 320)
        Me.MinTB.Name = "MinTB"
        Me.MinTB.Size = New System.Drawing.Size(148, 40)
        Me.MinTB.TabIndex = 2
        '
        'MaxTB
        '
        Me.MaxTB.Enabled = False
        Me.MaxTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxTB.Location = New System.Drawing.Point(811, 414)
        Me.MaxTB.Name = "MaxTB"
        Me.MaxTB.Size = New System.Drawing.Size(148, 40)
        Me.MaxTB.TabIndex = 3
        Me.MaxTB.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(581, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Persen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(581, 327)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(216, 33)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Min. Pembelian"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(581, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 33)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Max. Pembelian"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(885, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 33)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "%"
        '
        'InputRadio
        '
        Me.InputRadio.AutoSize = True
        Me.InputRadio.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputRadio.Location = New System.Drawing.Point(587, 58)
        Me.InputRadio.Name = "InputRadio"
        Me.InputRadio.Size = New System.Drawing.Size(123, 45)
        Me.InputRadio.TabIndex = 8
        Me.InputRadio.TabStop = True
        Me.InputRadio.Text = "Input"
        Me.InputRadio.UseVisualStyleBackColor = True
        '
        'EditRadio
        '
        Me.EditRadio.AutoSize = True
        Me.EditRadio.Font = New System.Drawing.Font("Microsoft YaHei UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditRadio.Location = New System.Drawing.Point(587, 109)
        Me.EditRadio.Name = "EditRadio"
        Me.EditRadio.Size = New System.Drawing.Size(97, 45)
        Me.EditRadio.TabIndex = 9
        Me.EditRadio.TabStop = True
        Me.EditRadio.Text = "Edit"
        Me.EditRadio.UseVisualStyleBackColor = True
        '
        'SaveBT
        '
        Me.SaveBT.Enabled = False
        Me.SaveBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBT.Location = New System.Drawing.Point(605, 748)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(139, 99)
        Me.SaveBT.TabIndex = 10
        Me.SaveBT.Text = "Save"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'DeleteBT
        '
        Me.DeleteBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBT.Location = New System.Drawing.Point(811, 748)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(139, 99)
        Me.DeleteBT.TabIndex = 11
        Me.DeleteBT.Text = "Delete"
        Me.DeleteBT.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(316, 288)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(218, 150)
        Me.DataGridView2.TabIndex = 12
        Me.DataGridView2.Visible = False
        '
        'BackBT
        '
        Me.BackBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBT.Location = New System.Drawing.Point(1438, 30)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(132, 82)
        Me.BackBT.TabIndex = 13
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(581, 515)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 33)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Max. Potongan"
        '
        'PotonganCheck
        '
        Me.PotonganCheck.AutoSize = True
        Me.PotonganCheck.Enabled = False
        Me.PotonganCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PotonganCheck.Location = New System.Drawing.Point(965, 521)
        Me.PotonganCheck.Name = "PotonganCheck"
        Me.PotonganCheck.Size = New System.Drawing.Size(78, 24)
        Me.PotonganCheck.TabIndex = 15
        Me.PotonganCheck.Text = "Enable"
        Me.PotonganCheck.UseVisualStyleBackColor = True
        '
        'PotonganTB
        '
        Me.PotonganTB.Enabled = False
        Me.PotonganTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PotonganTB.Location = New System.Drawing.Point(811, 508)
        Me.PotonganTB.Name = "PotonganTB"
        Me.PotonganTB.Size = New System.Drawing.Size(148, 40)
        Me.PotonganTB.TabIndex = 16
        Me.PotonganTB.Text = "0"
        '
        'PersenNUD
        '
        Me.PersenNUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PersenNUD.Location = New System.Drawing.Point(811, 226)
        Me.PersenNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PersenNUD.Name = "PersenNUD"
        Me.PersenNUD.Size = New System.Drawing.Size(68, 40)
        Me.PersenNUD.TabIndex = 17
        Me.PersenNUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MinLBL
        '
        Me.MinLBL.AutoSize = True
        Me.MinLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinLBL.ForeColor = System.Drawing.Color.Red
        Me.MinLBL.Location = New System.Drawing.Point(965, 327)
        Me.MinLBL.Name = "MinLBL"
        Me.MinLBL.Size = New System.Drawing.Size(66, 24)
        Me.MinLBL.TabIndex = 18
        Me.MinLBL.Text = "Label6"
        Me.MinLBL.Visible = False
        '
        'MaxLBL
        '
        Me.MaxLBL.AutoSize = True
        Me.MaxLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxLBL.ForeColor = System.Drawing.Color.Red
        Me.MaxLBL.Location = New System.Drawing.Point(1049, 421)
        Me.MaxLBL.Name = "MaxLBL"
        Me.MaxLBL.Size = New System.Drawing.Size(66, 24)
        Me.MaxLBL.TabIndex = 19
        Me.MaxLBL.Text = "Label6"
        Me.MaxLBL.Visible = False
        '
        'PotonganLBL
        '
        Me.PotonganLBL.AutoSize = True
        Me.PotonganLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PotonganLBL.ForeColor = System.Drawing.Color.Red
        Me.PotonganLBL.Location = New System.Drawing.Point(1049, 521)
        Me.PotonganLBL.Name = "PotonganLBL"
        Me.PotonganLBL.Size = New System.Drawing.Size(66, 24)
        Me.PotonganLBL.TabIndex = 20
        Me.PotonganLBL.Text = "Label6"
        Me.PotonganLBL.Visible = False
        '
        'MaxCheck
        '
        Me.MaxCheck.AutoSize = True
        Me.MaxCheck.Enabled = False
        Me.MaxCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaxCheck.Location = New System.Drawing.Point(965, 421)
        Me.MaxCheck.Name = "MaxCheck"
        Me.MaxCheck.Size = New System.Drawing.Size(78, 24)
        Me.MaxCheck.TabIndex = 21
        Me.MaxCheck.Text = "Enable"
        Me.MaxCheck.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(182, 33)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Form Diskon"
        '
        'Form_Admin_Diskon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MaxCheck)
        Me.Controls.Add(Me.PotonganLBL)
        Me.Controls.Add(Me.MaxLBL)
        Me.Controls.Add(Me.MinLBL)
        Me.Controls.Add(Me.PersenNUD)
        Me.Controls.Add(Me.PotonganTB)
        Me.Controls.Add(Me.PotonganCheck)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BackBT)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DeleteBT)
        Me.Controls.Add(Me.SaveBT)
        Me.Controls.Add(Me.EditRadio)
        Me.Controls.Add(Me.InputRadio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MaxTB)
        Me.Controls.Add(Me.MinTB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form_Admin_Diskon"
        Me.Text = "Form Diskon"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersenNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MinTB As TextBox
    Friend WithEvents MaxTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents InputRadio As RadioButton
    Friend WithEvents EditRadio As RadioButton
    Friend WithEvents SaveBT As Button
    Friend WithEvents DeleteBT As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BackBT As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PotonganCheck As CheckBox
    Friend WithEvents PotonganTB As TextBox
    Friend WithEvents PersenNUD As NumericUpDown
    Friend WithEvents MinLBL As Label
    Friend WithEvents MaxLBL As Label
    Friend WithEvents PotonganLBL As Label
    Friend WithEvents MaxCheck As CheckBox
    Friend WithEvents Label6 As Label
End Class
