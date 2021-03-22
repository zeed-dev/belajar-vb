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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnMahasiswa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnReset = New System.Windows.Forms.ToolStripButton()
        Me.cb1 = New System.Windows.Forms.ToolStripComboBox()
        Me.tb1 = New System.Windows.Forms.ToolStripTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(884, 77)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMahasiswa, Me.ToolStripSeparator1, Me.btnReset, Me.cb1, Me.tb1})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 18)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(878, 47)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnMahasiswa
        '
        Me.btnMahasiswa.Image = CType(resources.GetObject("btnMahasiswa.Image"), System.Drawing.Image)
        Me.btnMahasiswa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMahasiswa.Name = "btnMahasiswa"
        Me.btnMahasiswa.Size = New System.Drawing.Size(193, 44)
        Me.btnMahasiswa.Text = "Add Data Mahasiswa"
        Me.btnMahasiswa.ToolTipText = "ToolStripButton1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 47)
        '
        'btnReset
        '
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(125, 44)
        Me.btnReset.Text = "Reset Data"
        '
        'cb1
        '
        Me.cb1.AutoCompleteCustomSource.AddRange(New String() {"AYAM ", "SAPI", "BEBEK"})
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(200, 47)
        '
        'tb1
        '
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(200, 47)
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(15, 318)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(299, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 485)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnMahasiswa As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReset As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cb1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents tb1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
