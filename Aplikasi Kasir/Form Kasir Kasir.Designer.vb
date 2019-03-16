<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Kasir_Kasir
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
        Me.BarangCB = New System.Windows.Forms.ComboBox()
        Me.AddBT = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Kode_Makanan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityNUD = New System.Windows.Forms.NumericUpDown()
        Me.HargaCB = New System.Windows.Forms.ComboBox()
        Me.HargaTB = New System.Windows.Forms.TextBox()
        Me.DeleteBT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TotalHargaTB = New System.Windows.Forms.TextBox()
        Me.PembayaranTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.KembalianTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.HitungTB = New System.Windows.Forms.Button()
        Me.SaveBT = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.KodeMakananTB = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.KodeCB = New System.Windows.Forms.ComboBox()
        Me.QuantityNUD2 = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.BackBT = New System.Windows.Forms.Button()
        Me.DiskonDGV = New System.Windows.Forms.DataGridView()
        Me.PajakDGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.PPNTB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SubTotalTB = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DiskonTB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantityNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.QuantityNUD2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiskonDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PajakDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarangCB
        '
        Me.BarangCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BarangCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BarangCB.FormattingEnabled = True
        Me.BarangCB.Location = New System.Drawing.Point(137, 19)
        Me.BarangCB.Name = "BarangCB"
        Me.BarangCB.Size = New System.Drawing.Size(172, 24)
        Me.BarangCB.TabIndex = 0
        '
        'AddBT
        '
        Me.AddBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBT.Location = New System.Drawing.Point(375, 35)
        Me.AddBT.Name = "AddBT"
        Me.AddBT.Size = New System.Drawing.Size(82, 56)
        Me.AddBT.TabIndex = 2
        Me.AddBT.Text = "Add"
        Me.AddBT.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Kode_Makanan, Me.Column1, Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(483, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(429, 737)
        Me.DataGridView1.TabIndex = 3
        '
        'Kode_Makanan
        '
        Me.Kode_Makanan.FillWeight = 81.21828!
        Me.Kode_Makanan.HeaderText = "Kode"
        Me.Kode_Makanan.Name = "Kode_Makanan"
        Me.Kode_Makanan.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.FillWeight = 106.2606!
        Me.Column1.HeaderText = "Makanan"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 106.2606!
        Me.Column2.HeaderText = "Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 106.2606!
        Me.Column3.HeaderText = "Harga Total"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'QuantityNUD
        '
        Me.QuantityNUD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityNUD.Location = New System.Drawing.Point(137, 109)
        Me.QuantityNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantityNUD.Name = "QuantityNUD"
        Me.QuantityNUD.Size = New System.Drawing.Size(73, 23)
        Me.QuantityNUD.TabIndex = 4
        Me.QuantityNUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'HargaCB
        '
        Me.HargaCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HargaCB.Enabled = False
        Me.HargaCB.FormattingEnabled = True
        Me.HargaCB.Location = New System.Drawing.Point(1022, 124)
        Me.HargaCB.Name = "HargaCB"
        Me.HargaCB.Size = New System.Drawing.Size(102, 21)
        Me.HargaCB.TabIndex = 6
        Me.HargaCB.Visible = False
        '
        'HargaTB
        '
        Me.HargaTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HargaTB.Location = New System.Drawing.Point(137, 80)
        Me.HargaTB.Name = "HargaTB"
        Me.HargaTB.ReadOnly = True
        Me.HargaTB.Size = New System.Drawing.Size(172, 23)
        Me.HargaTB.TabIndex = 7
        '
        'DeleteBT
        '
        Me.DeleteBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBT.Location = New System.Drawing.Point(375, 124)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(82, 56)
        Me.DeleteBT.TabIndex = 8
        Me.DeleteBT.Text = "Delete"
        Me.DeleteBT.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nama Makanan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 24)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total Harga"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(448, 272)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 24)
        Me.Label5.TabIndex = 13
        '
        'TotalHargaTB
        '
        Me.TotalHargaTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalHargaTB.Location = New System.Drawing.Point(139, 32)
        Me.TotalHargaTB.Name = "TotalHargaTB"
        Me.TotalHargaTB.ReadOnly = True
        Me.TotalHargaTB.Size = New System.Drawing.Size(156, 26)
        Me.TotalHargaTB.TabIndex = 14
        Me.TotalHargaTB.Text = "0"
        '
        'PembayaranTB
        '
        Me.PembayaranTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PembayaranTB.Location = New System.Drawing.Point(139, 79)
        Me.PembayaranTB.Name = "PembayaranTB"
        Me.PembayaranTB.Size = New System.Drawing.Size(156, 26)
        Me.PembayaranTB.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(366, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 24)
        Me.Label6.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 24)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Pembayaran"
        '
        'KembalianTB
        '
        Me.KembalianTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KembalianTB.Location = New System.Drawing.Point(137, 123)
        Me.KembalianTB.Name = "KembalianTB"
        Me.KembalianTB.ReadOnly = True
        Me.KembalianTB.Size = New System.Drawing.Size(156, 26)
        Me.KembalianTB.TabIndex = 22
        Me.KembalianTB.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(82, 369)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 24)
        Me.Label8.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 24)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Kembalian"
        '
        'HitungTB
        '
        Me.HitungTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HitungTB.Location = New System.Drawing.Point(206, 165)
        Me.HitungTB.Name = "HitungTB"
        Me.HitungTB.Size = New System.Drawing.Size(89, 59)
        Me.HitungTB.TabIndex = 23
        Me.HitungTB.Text = "Hitung"
        Me.HitungTB.UseVisualStyleBackColor = True
        '
        'SaveBT
        '
        Me.SaveBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaveBT.Location = New System.Drawing.Point(15, 723)
        Me.SaveBT.Name = "SaveBT"
        Me.SaveBT.Size = New System.Drawing.Size(105, 60)
        Me.SaveBT.TabIndex = 24
        Me.SaveBT.Text = "Save"
        Me.SaveBT.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PembayaranTB)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TotalHargaTB)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.HitungTB)
        Me.GroupBox1.Controls.Add(Me.KembalianTB)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 487)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 230)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.KodeMakananTB)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.BarangCB)
        Me.GroupBox2.Controls.Add(Me.QuantityNUD)
        Me.GroupBox2.Controls.Add(Me.HargaTB)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(15, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 154)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        '
        'KodeMakananTB
        '
        Me.KodeMakananTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeMakananTB.Location = New System.Drawing.Point(137, 49)
        Me.KodeMakananTB.Name = "KodeMakananTB"
        Me.KodeMakananTB.ReadOnly = True
        Me.KodeMakananTB.Size = New System.Drawing.Size(172, 23)
        Me.KodeMakananTB.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 16)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Kode Makanan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(479, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 20)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Order"
        '
        'KodeCB
        '
        Me.KodeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.KodeCB.FormattingEnabled = True
        Me.KodeCB.Location = New System.Drawing.Point(1146, 124)
        Me.KodeCB.Name = "KodeCB"
        Me.KodeCB.Size = New System.Drawing.Size(121, 21)
        Me.KodeCB.TabIndex = 34
        Me.KodeCB.Visible = False
        '
        'QuantityNUD2
        '
        Me.QuantityNUD2.Enabled = False
        Me.QuantityNUD2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityNUD2.Location = New System.Drawing.Point(375, 226)
        Me.QuantityNUD2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.QuantityNUD2.Name = "QuantityNUD2"
        Me.QuantityNUD2.Size = New System.Drawing.Size(82, 26)
        Me.QuantityNUD2.TabIndex = 35
        Me.QuantityNUD2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(1091, 226)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(22, 23)
        Me.DataGridView2.TabIndex = 37
        Me.DataGridView2.Visible = False
        '
        'BackBT
        '
        Me.BackBT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBT.Location = New System.Drawing.Point(1378, 12)
        Me.BackBT.Name = "BackBT"
        Me.BackBT.Size = New System.Drawing.Size(112, 58)
        Me.BackBT.TabIndex = 38
        Me.BackBT.Text = "Back"
        Me.BackBT.UseVisualStyleBackColor = True
        '
        'DiskonDGV
        '
        Me.DiskonDGV.AllowUserToAddRows = False
        Me.DiskonDGV.AllowUserToDeleteRows = False
        Me.DiskonDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DiskonDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiskonDGV.Location = New System.Drawing.Point(944, 55)
        Me.DiskonDGV.Name = "DiskonDGV"
        Me.DiskonDGV.ReadOnly = True
        Me.DiskonDGV.Size = New System.Drawing.Size(397, 395)
        Me.DiskonDGV.TabIndex = 39
        '
        'PajakDGV
        '
        Me.PajakDGV.AllowUserToAddRows = False
        Me.PajakDGV.AllowUserToDeleteRows = False
        Me.PajakDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PajakDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PajakDGV.Location = New System.Drawing.Point(944, 537)
        Me.PajakDGV.Name = "PajakDGV"
        Me.PajakDGV.ReadOnly = True
        Me.PajakDGV.Size = New System.Drawing.Size(397, 246)
        Me.PajakDGV.TabIndex = 40
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.PPNTB)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.SubTotalTB)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.DiskonTB)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 251)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 200)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'PPNTB
        '
        Me.PPNTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PPNTB.Location = New System.Drawing.Point(139, 130)
        Me.PPNTB.Name = "PPNTB"
        Me.PPNTB.ReadOnly = True
        Me.PPNTB.Size = New System.Drawing.Size(156, 26)
        Me.PPNTB.TabIndex = 19
        Me.PPNTB.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Sub Total"
        '
        'SubTotalTB
        '
        Me.SubTotalTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubTotalTB.Location = New System.Drawing.Point(139, 32)
        Me.SubTotalTB.Name = "SubTotalTB"
        Me.SubTotalTB.ReadOnly = True
        Me.SubTotalTB.Size = New System.Drawing.Size(156, 26)
        Me.SubTotalTB.TabIndex = 14
        Me.SubTotalTB.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 130)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 24)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "PPN"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(17, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 24)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Diskon"
        '
        'DiskonTB
        '
        Me.DiskonTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiskonTB.Location = New System.Drawing.Point(139, 79)
        Me.DiskonTB.Name = "DiskonTB"
        Me.DiskonTB.ReadOnly = True
        Me.DiskonTB.Size = New System.Drawing.Size(156, 26)
        Me.DiskonTB.TabIndex = 22
        Me.DiskonTB.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(940, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(87, 20)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "List Diskon"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(940, 514)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 20)
        Me.Label16.TabIndex = 42
        Me.Label16.Text = "List Pajak"
        '
        'Form_Kasir_Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1502, 795)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PajakDGV)
        Me.Controls.Add(Me.DiskonDGV)
        Me.Controls.Add(Me.BackBT)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.QuantityNUD2)
        Me.Controls.Add(Me.KodeCB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SaveBT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DeleteBT)
        Me.Controls.Add(Me.HargaCB)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.AddBT)
        Me.Name = "Form_Kasir_Kasir"
        Me.Text = "Kasir"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantityNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.QuantityNUD2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiskonDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PajakDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarangCB As ComboBox
    Friend WithEvents AddBT As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents QuantityNUD As NumericUpDown
    Friend WithEvents HargaCB As ComboBox
    Friend WithEvents HargaTB As TextBox
    Friend WithEvents DeleteBT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TotalHargaTB As TextBox
    Friend WithEvents PembayaranTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents KembalianTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents HitungTB As Button
    Friend WithEvents SaveBT As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Kode_Makanan As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents KodeCB As ComboBox
    Friend WithEvents KodeMakananTB As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents QuantityNUD2 As NumericUpDown
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BackBT As Button
    Friend WithEvents DiskonDGV As DataGridView
    Friend WithEvents PajakDGV As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PPNTB As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents SubTotalTB As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DiskonTB As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
