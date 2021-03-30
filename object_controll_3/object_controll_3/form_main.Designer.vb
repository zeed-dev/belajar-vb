<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_main))
        Me.StripMenu = New System.Windows.Forms.MenuStrip()
        Me.PengaturanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfromationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetProflToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarAplikasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuildToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.labelJam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.labelTanggal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NavigationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StripMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StripMenu
        '
        Me.StripMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StripMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PengaturanToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.FormatToolStripMenuItem, Me.HelpToolStripMenuItem, Me.BuildToolStripMenuItem})
        Me.StripMenu.Location = New System.Drawing.Point(0, 0)
        Me.StripMenu.Name = "StripMenu"
        Me.StripMenu.Size = New System.Drawing.Size(1360, 28)
        Me.StripMenu.TabIndex = 0
        Me.StripMenu.Text = "MenuStrip1"
        '
        'PengaturanToolStripMenuItem
        '
        Me.PengaturanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingDatabaseToolStripMenuItem, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ToolStripSeparator1, Me.InfromationToolStripMenuItem, Me.PenggunaToolStripMenuItem, Me.KeluarAplikasiToolStripMenuItem})
        Me.PengaturanToolStripMenuItem.Name = "PengaturanToolStripMenuItem"
        Me.PengaturanToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.PengaturanToolStripMenuItem.Text = "Pengaturan"
        '
        'SettingDatabaseToolStripMenuItem
        '
        Me.SettingDatabaseToolStripMenuItem.Image = CType(resources.GetObject("SettingDatabaseToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingDatabaseToolStripMenuItem.Name = "SettingDatabaseToolStripMenuItem"
        Me.SettingDatabaseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.SettingDatabaseToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.SettingDatabaseToolStripMenuItem.Text = "Setting Database"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = CType(resources.GetObject("LogoutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(248, 6)
        '
        'InfromationToolStripMenuItem
        '
        Me.InfromationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetProflToolStripMenuItem, Me.InfoPenggunaToolStripMenuItem})
        Me.InfromationToolStripMenuItem.Image = CType(resources.GetObject("InfromationToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InfromationToolStripMenuItem.Name = "InfromationToolStripMenuItem"
        Me.InfromationToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.InfromationToolStripMenuItem.Text = "Infromation"
        '
        'SetProflToolStripMenuItem
        '
        Me.SetProflToolStripMenuItem.Image = CType(resources.GetObject("SetProflToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SetProflToolStripMenuItem.Name = "SetProflToolStripMenuItem"
        Me.SetProflToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.SetProflToolStripMenuItem.Text = "Set Profl"
        '
        'InfoPenggunaToolStripMenuItem
        '
        Me.InfoPenggunaToolStripMenuItem.Image = CType(resources.GetObject("InfoPenggunaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InfoPenggunaToolStripMenuItem.Name = "InfoPenggunaToolStripMenuItem"
        Me.InfoPenggunaToolStripMenuItem.Size = New System.Drawing.Size(179, 26)
        Me.InfoPenggunaToolStripMenuItem.Text = "Info Pengguna"
        '
        'PenggunaToolStripMenuItem
        '
        Me.PenggunaToolStripMenuItem.Image = CType(resources.GetObject("PenggunaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PenggunaToolStripMenuItem.Name = "PenggunaToolStripMenuItem"
        Me.PenggunaToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.PenggunaToolStripMenuItem.Text = "Pengguna"
        '
        'KeluarAplikasiToolStripMenuItem
        '
        Me.KeluarAplikasiToolStripMenuItem.Image = CType(resources.GetObject("KeluarAplikasiToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarAplikasiToolStripMenuItem.Name = "KeluarAplikasiToolStripMenuItem"
        Me.KeluarAplikasiToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.KeluarAplikasiToolStripMenuItem.Text = "Keluar Aplikasi"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(56, 24)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'BuildToolStripMenuItem
        '
        Me.BuildToolStripMenuItem.Name = "BuildToolStripMenuItem"
        Me.BuildToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.BuildToolStripMenuItem.Text = "Build"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.ToolStripComboBox1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1360, 37)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(112, 34)
        Me.ToolStripButton1.Text = "Pilih Cetak"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(0, 34)
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Lap. Akhir tahun", "Lap. Awal tahun", "Lap. Tengah tahun"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(160, 37)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(94, 34)
        Me.ToolStripButton2.Text = "Preview"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.labelTanggal, Me.labelJam})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 708)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1360, 25)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Image = CType(resources.GetObject("ToolStripProgressBar1.Image"), System.Drawing.Image)
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(92, 20)
        Me.ToolStripProgressBar1.Text = "Database"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(28, 20)
        Me.ToolStripStatusLabel1.Text = "[...]"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(1118, 20)
        Me.ToolStripStatusLabel2.Spring = True
        Me.ToolStripStatusLabel2.Text = "Sistem Infrormasi Mahasiswa"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Image = CType(resources.GetObject("ToolStripStatusLabel3.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(77, 20)
        Me.ToolStripStatusLabel3.Text = "Waktu :"
        '
        'labelJam
        '
        Me.labelJam.Name = "labelJam"
        Me.labelJam.Size = New System.Drawing.Size(15, 20)
        Me.labelJam.Text = "_"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'labelTanggal
        '
        Me.labelTanggal.Name = "labelTanggal"
        Me.labelTanggal.Size = New System.Drawing.Size(15, 20)
        Me.labelTanggal.Text = "_"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshDataToolStripMenuItem, Me.NavigationToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 52)
        '
        'RefreshDataToolStripMenuItem
        '
        Me.RefreshDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DataPenggunaToolStripMenuItem})
        Me.RefreshDataToolStripMenuItem.Name = "RefreshDataToolStripMenuItem"
        Me.RefreshDataToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.RefreshDataToolStripMenuItem.Text = "Refresh Data"
        '
        'NavigationToolStripMenuItem
        '
        Me.NavigationToolStripMenuItem.Name = "NavigationToolStripMenuItem"
        Me.NavigationToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.NavigationToolStripMenuItem.Text = "Navigation"
        '
        'DataPenggunaToolStripMenuItem
        '
        Me.DataPenggunaToolStripMenuItem.Name = "DataPenggunaToolStripMenuItem"
        Me.DataPenggunaToolStripMenuItem.Size = New System.Drawing.Size(185, 26)
        Me.DataPenggunaToolStripMenuItem.Text = "Data Pengguna"
        '
        'form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 733)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StripMenu)
        Me.MainMenuStrip = Me.StripMenu
        Me.Name = "form_main"
        Me.Text = "MAIN FORM"
        Me.StripMenu.ResumeLayout(False)
        Me.StripMenu.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StripMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents PengaturanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents InfromationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarAplikasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetProflToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoPenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BuildToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents labelJam As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents labelTanggal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataPenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NavigationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
