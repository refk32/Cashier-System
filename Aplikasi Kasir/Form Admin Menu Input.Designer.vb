<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MakananRadio = New System.Windows.Forms.RadioButton()
        Me.MinumanRadio = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'KodeMakananTB
        '
        Me.KodeMakananTB.Enabled = False
        Me.KodeMakananTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeMakananTB.Location = New System.Drawing.Point(248, 285)
        Me.KodeMakananTB.MaxLength = 10
        Me.KodeMakananTB.Name = "KodeMakananTB"
        Me.KodeMakananTB.Size = New System.Drawing.Size(273, 40)
        Me.KodeMakananTB.TabIndex = 0
        '
        'NamaMakananTB
        '
        Me.NamaMakananTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaMakananTB.Location = New System.Drawing.Point(248, 398)
        Me.NamaMakananTB.MaxLength = 25
        Me.NamaMakananTB.Name = "NamaMakananTB"
        Me.NamaMakananTB.Size = New System.Drawing.Size(273, 40)
        Me.NamaMakananTB.TabIndex = 1
        '
        'HargaTB
        '
        Me.HargaTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaTB.Location = New System.Drawing.Point(248, 511)
        Me.HargaTB.Name = "HargaTB"
        Me.HargaTB.Size = New System.Drawing.Size(273, 40)
        Me.HargaTB.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 292)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Makanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 405)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 33)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Makanan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(148, 518)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 33)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Harga"
        '
        'SaveBT
        '
        Me.SaveBT.Enabled = False
        Me.SaveBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBT.Location = New System.Drawing.Point(280, 637)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(158, 137)
        Me.SaveBT.TabIndex = 6
        Me.SaveBT.Text = "Save"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'KodeMakananLBL
        '
        Me.KodeMakananLBL.AutoSize = True
        Me.KodeMakananLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeMakananLBL.ForeColor = System.Drawing.Color.Red
        Me.KodeMakananLBL.Location = New System.Drawing.Point(527, 292)
        Me.KodeMakananLBL.Name = "KodeMakananLBL"
        Me.KodeMakananLBL.Size = New System.Drawing.Size(102, 33)
        Me.KodeMakananLBL.TabIndex = 7
        Me.KodeMakananLBL.Text = "Label4"
        Me.KodeMakananLBL.Visible = False
        '
        'NamaMakananLBL
        '
        Me.NamaMakananLBL.AutoSize = True
        Me.NamaMakananLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaMakananLBL.ForeColor = System.Drawing.Color.Red
        Me.NamaMakananLBL.Location = New System.Drawing.Point(527, 401)
        Me.NamaMakananLBL.Name = "NamaMakananLBL"
        Me.NamaMakananLBL.Size = New System.Drawing.Size(102, 33)
        Me.NamaMakananLBL.TabIndex = 8
        Me.NamaMakananLBL.Text = "Label5"
        Me.NamaMakananLBL.Visible = False
        '
        'HargaLBL
        '
        Me.HargaLBL.AutoSize = True
        Me.HargaLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaLBL.ForeColor = System.Drawing.Color.Red
        Me.HargaLBL.Location = New System.Drawing.Point(527, 514)
        Me.HargaLBL.Name = "HargaLBL"
        Me.HargaLBL.Size = New System.Drawing.Size(102, 33)
        Me.HargaLBL.TabIndex = 9
        Me.HargaLBL.Text = "Label6"
        Me.HargaLBL.Visible = False
        '
        'BackBT
        '
        Me.BackBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBT.Location = New System.Drawing.Point(1424, 37)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(133, 83)
        Me.BackBT.TabIndex = 10
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 33)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Jenis :"
        '
        'MakananRadio
        '
        Me.MakananRadio.AutoSize = True
        Me.MakananRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MakananRadio.Location = New System.Drawing.Point(139, 144)
        Me.MakananRadio.Name = "MakananRadio"
        Me.MakananRadio.Size = New System.Drawing.Size(152, 37)
        Me.MakananRadio.TabIndex = 12
        Me.MakananRadio.Text = "Makanan"
        Me.MakananRadio.UseVisualStyleBackColor = True
        '
        'MinumanRadio
        '
        Me.MinumanRadio.AutoSize = True
        Me.MinumanRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinumanRadio.Location = New System.Drawing.Point(139, 187)
        Me.MinumanRadio.Name = "MinumanRadio"
        Me.MinumanRadio.Size = New System.Drawing.Size(153, 37)
        Me.MinumanRadio.TabIndex = 13
        Me.MinumanRadio.Text = "Minuman"
        Me.MinumanRadio.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(966, 171)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(95, 150)
        Me.DataGridView1.TabIndex = 14
        Me.DataGridView1.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(294, 39)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Form Menu Input"
        '
        'Form_Admin_Menu_Input
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 882)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MinumanRadio)
        Me.Controls.Add(Me.MakananRadio)
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
        Me.Name = "Form_Admin_Menu_Input"
        Me.Text = "Form_Admin_Menu_Input"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MinumanRadio As RadioButton
    Friend WithEvents MakananRadio As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
End Class
