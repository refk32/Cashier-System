<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Admin_Menu
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.InputBT = New System.Windows.Forms.Button()
        Me.EditBT = New System.Windows.Forms.Button()
        Me.DeleteBT = New System.Windows.Forms.Button()
        Me.BackBT = New System.Windows.Forms.Button()
        Me.Filter = New System.Windows.Forms.GroupBox()
        Me.AZRadio = New System.Windows.Forms.RadioButton()
        Me.ZARadio = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TertinggiRadio = New System.Windows.Forms.RadioButton()
        Me.TerendahRadio = New System.Windows.Forms.RadioButton()
        Me.Jenis = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MinumanRadio = New System.Windows.Forms.RadioButton()
        Me.SemuaRadio = New System.Windows.Forms.RadioButton()
        Me.MakananRadio = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Filter.SuspendLayout()
        Me.Jenis.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(55, 102)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 50
        Me.DataGridView1.Size = New System.Drawing.Size(1211, 569)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Daftar Makanan"
        '
        'InputBT
        '
        Me.InputBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputBT.Location = New System.Drawing.Point(55, 734)
        Me.InputBT.Name = "InputBT"
        Me.InputBT.Size = New System.Drawing.Size(139, 98)
        Me.InputBT.TabIndex = 2
        Me.InputBT.Text = "Input"
        Me.InputBT.UseVisualStyleBackColor = True
        '
        'EditBT
        '
        Me.EditBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBT.Location = New System.Drawing.Point(230, 734)
        Me.EditBT.Name = "EditBT"
        Me.EditBT.Size = New System.Drawing.Size(139, 98)
        Me.EditBT.TabIndex = 3
        Me.EditBT.Text = "Edit"
        Me.EditBT.UseVisualStyleBackColor = True
        '
        'DeleteBT
        '
        Me.DeleteBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBT.Location = New System.Drawing.Point(406, 734)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(159, 98)
        Me.DeleteBT.TabIndex = 4
        Me.DeleteBT.Text = "Delete"
        Me.DeleteBT.UseVisualStyleBackColor = True
        '
        'BackBT
        '
        Me.BackBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBT.Location = New System.Drawing.Point(1413, 746)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(145, 77)
        Me.BackBT.TabIndex = 5
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'Filter
        '
        Me.Filter.Controls.Add(Me.AZRadio)
        Me.Filter.Controls.Add(Me.ZARadio)
        Me.Filter.Controls.Add(Me.Label4)
        Me.Filter.Controls.Add(Me.Label2)
        Me.Filter.Controls.Add(Me.TertinggiRadio)
        Me.Filter.Controls.Add(Me.TerendahRadio)
        Me.Filter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Filter.Location = New System.Drawing.Point(1305, 102)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(263, 263)
        Me.Filter.TabIndex = 6
        Me.Filter.TabStop = False
        Me.Filter.Text = "Sort"
        '
        'AZRadio
        '
        Me.AZRadio.AutoSize = True
        Me.AZRadio.Location = New System.Drawing.Point(23, 169)
        Me.AZRadio.Name = "AZRadio"
        Me.AZRadio.Size = New System.Drawing.Size(69, 28)
        Me.AZRadio.TabIndex = 5
        Me.AZRadio.TabStop = True
        Me.AZRadio.Text = "A - Z"
        Me.AZRadio.UseVisualStyleBackColor = True
        '
        'ZARadio
        '
        Me.ZARadio.AutoSize = True
        Me.ZARadio.Location = New System.Drawing.Point(23, 203)
        Me.ZARadio.Name = "ZARadio"
        Me.ZARadio.Size = New System.Drawing.Size(69, 28)
        Me.ZARadio.TabIndex = 6
        Me.ZARadio.TabStop = True
        Me.ZARadio.Text = "Z - A"
        Me.ZARadio.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nama Makanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Harga"
        '
        'TertinggiRadio
        '
        Me.TertinggiRadio.AutoSize = True
        Me.TertinggiRadio.Location = New System.Drawing.Point(23, 67)
        Me.TertinggiRadio.Name = "TertinggiRadio"
        Me.TertinggiRadio.Size = New System.Drawing.Size(102, 28)
        Me.TertinggiRadio.TabIndex = 1
        Me.TertinggiRadio.TabStop = True
        Me.TertinggiRadio.Text = "Tertinggi"
        Me.TertinggiRadio.UseVisualStyleBackColor = True
        '
        'TerendahRadio
        '
        Me.TerendahRadio.AutoSize = True
        Me.TerendahRadio.Location = New System.Drawing.Point(23, 101)
        Me.TerendahRadio.Name = "TerendahRadio"
        Me.TerendahRadio.Size = New System.Drawing.Size(111, 28)
        Me.TerendahRadio.TabIndex = 2
        Me.TerendahRadio.TabStop = True
        Me.TerendahRadio.Text = "Terendah"
        Me.TerendahRadio.UseVisualStyleBackColor = True
        '
        'Jenis
        '
        Me.Jenis.Controls.Add(Me.Label5)
        Me.Jenis.Controls.Add(Me.Label3)
        Me.Jenis.Controls.Add(Me.MinumanRadio)
        Me.Jenis.Controls.Add(Me.SemuaRadio)
        Me.Jenis.Controls.Add(Me.MakananRadio)
        Me.Jenis.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jenis.Location = New System.Drawing.Point(1305, 411)
        Me.Jenis.Name = "Jenis"
        Me.Jenis.Size = New System.Drawing.Size(263, 260)
        Me.Jenis.TabIndex = 7
        Me.Jenis.TabStop = False
        Me.Jenis.Text = "Filter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 24)
        Me.Label3.TabIndex = 3
        '
        'MinumanRadio
        '
        Me.MinumanRadio.AutoSize = True
        Me.MinumanRadio.Location = New System.Drawing.Point(23, 128)
        Me.MinumanRadio.Name = "MinumanRadio"
        Me.MinumanRadio.Size = New System.Drawing.Size(107, 28)
        Me.MinumanRadio.TabIndex = 6
        Me.MinumanRadio.Text = "Minuman"
        Me.MinumanRadio.UseVisualStyleBackColor = True
        '
        'SemuaRadio
        '
        Me.SemuaRadio.AutoSize = True
        Me.SemuaRadio.Checked = True
        Me.SemuaRadio.Location = New System.Drawing.Point(23, 61)
        Me.SemuaRadio.Name = "SemuaRadio"
        Me.SemuaRadio.Size = New System.Drawing.Size(88, 28)
        Me.SemuaRadio.TabIndex = 4
        Me.SemuaRadio.TabStop = True
        Me.SemuaRadio.Text = "Semua"
        Me.SemuaRadio.UseVisualStyleBackColor = True
        '
        'MakananRadio
        '
        Me.MakananRadio.AutoSize = True
        Me.MakananRadio.Location = New System.Drawing.Point(23, 94)
        Me.MakananRadio.Name = "MakananRadio"
        Me.MakananRadio.Size = New System.Drawing.Size(105, 28)
        Me.MakananRadio.TabIndex = 5
        Me.MakananRadio.Text = "Makanan"
        Me.MakananRadio.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(19, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Jenis"
        '
        'Form_Admin_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.Filter)
        Me.Controls.Add(Me.Jenis)
        Me.Controls.Add(Me.BackBT)
        Me.Controls.Add(Me.DeleteBT)
        Me.Controls.Add(Me.EditBT)
        Me.Controls.Add(Me.InputBT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form_Admin_Menu"
        Me.Text = "Daftar Makanan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Filter.ResumeLayout(False)
        Me.Filter.PerformLayout()
        Me.Jenis.ResumeLayout(False)
        Me.Jenis.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents InputBT As Button
    Friend WithEvents EditBT As Button
    Friend WithEvents DeleteBT As Button
    Friend WithEvents BackBT As Button
    Friend WithEvents Filter As GroupBox
    Friend WithEvents TerendahRadio As RadioButton
    Friend WithEvents TertinggiRadio As RadioButton
    Friend WithEvents MinumanRadio As RadioButton
    Friend WithEvents MakananRadio As RadioButton
    Friend WithEvents SemuaRadio As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Jenis As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AZRadio As RadioButton
    Friend WithEvents ZARadio As RadioButton
    Friend WithEvents Label5 As Label
End Class
