<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.cbStatusKawin = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTGL = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtGajiPokok = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbStatusAng = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnSimpan = New System.Windows.Forms.ToolStripButton()
        Me.btnBatal = New System.Windows.Forms.ToolStripButton()
        Me.txtGajiBersih = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TGL_LAHIR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GAJI_POKOK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS_PERKAWINAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATUS_ANGSURAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GAJI_BERSIH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtJmlhAnak = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(352, 149)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(115, 21)
        Me.rbPerempuan.TabIndex = 26
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "PEREMPUAN"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(225, 150)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(92, 21)
        Me.rbLaki.TabIndex = 25
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "LAKI-LAKI"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'cbStatusKawin
        '
        Me.cbStatusKawin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatusKawin.FormattingEnabled = True
        Me.cbStatusKawin.Items.AddRange(New Object() {"BELUM MENIKAH", "MENIKAH"})
        Me.cbStatusKawin.Location = New System.Drawing.Point(874, 36)
        Me.cbStatusKawin.Name = "cbStatusKawin"
        Me.cbStatusKawin.Size = New System.Drawing.Size(240, 30)
        Me.cbStatusKawin.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 149)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 20)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "JENIS KELAMIN"
        '
        'txtNama
        '
        Me.txtNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.Location = New System.Drawing.Point(227, 92)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(240, 28)
        Me.txtNama.TabIndex = 21
        '
        'txtNIP
        '
        Me.txtNIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIP.Location = New System.Drawing.Point(227, 33)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(240, 28)
        Me.txtNIP.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(647, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(190, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "STATUS PERKAWINAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "NAMA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "NIP"
        '
        'txtTGL
        '
        Me.txtTGL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTGL.Location = New System.Drawing.Point(227, 200)
        Me.txtTGL.Name = "txtTGL"
        Me.txtTGL.Size = New System.Drawing.Size(240, 28)
        Me.txtTGL.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "TANGGAL LAHIR"
        '
        'txtGajiPokok
        '
        Me.txtGajiPokok.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGajiPokok.Location = New System.Drawing.Point(874, 192)
        Me.txtGajiPokok.Name = "txtGajiPokok"
        Me.txtGajiPokok.Size = New System.Drawing.Size(240, 28)
        Me.txtGajiPokok.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(647, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "GAJI POKOK"
        '
        'cbStatusAng
        '
        Me.cbStatusAng.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatusAng.FormattingEnabled = True
        Me.cbStatusAng.Items.AddRange(New Object() {"RUMAH ", "KENDARAAN", "LISTRIK + AIR "})
        Me.cbStatusAng.Location = New System.Drawing.Point(874, 139)
        Me.cbStatusAng.Name = "cbStatusAng"
        Me.cbStatusAng.Size = New System.Drawing.Size(240, 30)
        Me.cbStatusAng.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(647, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 20)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "STATUS ANGSURAN"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSimpan, Me.btnBatal})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 292)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(252, 47)
        Me.ToolStrip1.TabIndex = 39
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnSimpan
        '
        Me.btnSimpan.Image = CType(resources.GetObject("btnSimpan.Image"), System.Drawing.Image)
        Me.btnSimpan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(106, 44)
        Me.btnSimpan.Text = "SIMPAN"
        '
        'btnBatal
        '
        Me.btnBatal.Image = CType(resources.GetObject("btnBatal.Image"), System.Drawing.Image)
        Me.btnBatal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(95, 44)
        Me.btnBatal.Text = "BATAL"
        '
        'txtGajiBersih
        '
        Me.txtGajiBersih.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGajiBersih.Location = New System.Drawing.Point(874, 247)
        Me.txtGajiBersih.Name = "txtGajiBersih"
        Me.txtGajiBersih.Size = New System.Drawing.Size(240, 28)
        Me.txtGajiBersih.TabIndex = 41
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(647, 249)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(114, 20)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "GAJI BERSIH"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 364)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1233, 321)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NIP, Me.NAMA, Me.JK, Me.TGL_LAHIR, Me.GAJI_POKOK, Me.STATUS_PERKAWINAN, Me.STATUS_ANGSURAN, Me.GAJI_BERSIH})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1227, 300)
        Me.DataGridView1.TabIndex = 40
        '
        'NIP
        '
        Me.NIP.HeaderText = "NIP"
        Me.NIP.Name = "NIP"
        Me.NIP.Width = 120
        '
        'NAMA
        '
        Me.NAMA.HeaderText = "NAMA"
        Me.NAMA.Name = "NAMA"
        Me.NAMA.Width = 150
        '
        'JK
        '
        Me.JK.HeaderText = "JK"
        Me.JK.Name = "JK"
        Me.JK.Width = 50
        '
        'TGL_LAHIR
        '
        Me.TGL_LAHIR.HeaderText = "TGL LAHIR"
        Me.TGL_LAHIR.Name = "TGL_LAHIR"
        Me.TGL_LAHIR.Width = 150
        '
        'GAJI_POKOK
        '
        Me.GAJI_POKOK.HeaderText = "GAJI POKOK"
        Me.GAJI_POKOK.Name = "GAJI_POKOK"
        '
        'STATUS_PERKAWINAN
        '
        Me.STATUS_PERKAWINAN.HeaderText = "STATUS PERKAWINAN"
        Me.STATUS_PERKAWINAN.Name = "STATUS_PERKAWINAN"
        '
        'STATUS_ANGSURAN
        '
        Me.STATUS_ANGSURAN.HeaderText = "STATUS ANGSURAN"
        Me.STATUS_ANGSURAN.Name = "STATUS_ANGSURAN"
        '
        'GAJI_BERSIH
        '
        Me.GAJI_BERSIH.HeaderText = "GAJI BERSIH"
        Me.GAJI_BERSIH.Name = "GAJI_BERSIH"
        Me.GAJI_BERSIH.Width = 150
        '
        'txtJmlhAnak
        '
        Me.txtJmlhAnak.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJmlhAnak.Location = New System.Drawing.Point(874, 83)
        Me.txtJmlhAnak.Name = "txtJmlhAnak"
        Me.txtJmlhAnak.Size = New System.Drawing.Size(240, 28)
        Me.txtJmlhAnak.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(647, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 20)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "JUMLAH ANAK"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 685)
        Me.Controls.Add(Me.txtJmlhAnak)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtGajiBersih)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cbStatusAng)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtGajiPokok)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTGL)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rbPerempuan)
        Me.Controls.Add(Me.rbLaki)
        Me.Controls.Add(Me.cbStatusKawin)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNIP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents rbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents cbStatusKawin As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTGL As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtGajiPokok As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbStatusAng As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnSimpan As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnBatal As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtGajiBersih As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NIP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TGL_LAHIR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GAJI_POKOK As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS_PERKAWINAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATUS_ANGSURAN As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GAJI_BERSIH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtJmlhAnak As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
