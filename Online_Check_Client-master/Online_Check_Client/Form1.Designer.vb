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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_Open = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_close = New System.Windows.Forms.ToolStripMenuItem()
        Me.tb_ip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ep_RefreshRate = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ep_ip = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.iconMinimize = New System.Windows.Forms.PictureBox()
        Me.iconClose = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.hiddenField = New System.Windows.Forms.Label()
        Me.startUp_checkBox = New System.Windows.Forms.CheckBox()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.ep_RefreshRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_ip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "a"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_Open, Me.tsmi_close})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.ShowImageMargin = False
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(79, 48)
        '
        'tsmi_Open
        '
        Me.tsmi_Open.Name = "tsmi_Open"
        Me.tsmi_Open.Size = New System.Drawing.Size(78, 22)
        Me.tsmi_Open.Text = "Open"
        '
        'tsmi_close
        '
        Me.tsmi_close.Name = "tsmi_close"
        Me.tsmi_close.Size = New System.Drawing.Size(78, 22)
        Me.tsmi_close.Text = "Exit"
        '
        'tb_ip
        '
        Me.tb_ip.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ip.Location = New System.Drawing.Point(130, 24)
        Me.tb_ip.Name = "tb_ip"
        Me.tb_ip.Size = New System.Drawing.Size(99, 24)
        Me.tb_ip.TabIndex = 0
        Me.tb_ip.Text = "192.168.1.9"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server IP:"
        '
        'ep_RefreshRate
        '
        Me.ep_RefreshRate.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ep_RefreshRate.ContainerControl = Me
        '
        'ep_ip
        '
        Me.ep_ip.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ep_ip.ContainerControl = Me
        '
        'btn_Save
        '
        Me.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Save.Location = New System.Drawing.Point(72, 55)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(114, 39)
        Me.btn_Save.TabIndex = 3
        Me.btn_Save.Text = "Save"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.Label2)
        Me.panelTitleBar.Controls.Add(Me.PictureBox1)
        Me.panelTitleBar.Controls.Add(Me.iconMinimize)
        Me.panelTitleBar.Controls.Add(Me.iconClose)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(269, 35)
        Me.panelTitleBar.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "IP Manager - Client"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'iconMinimize
        '
        Me.iconMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconMinimize.Image = CType(resources.GetObject("iconMinimize.Image"), System.Drawing.Image)
        Me.iconMinimize.Location = New System.Drawing.Point(198, 7)
        Me.iconMinimize.Name = "iconMinimize"
        Me.iconMinimize.Size = New System.Drawing.Size(22, 22)
        Me.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconMinimize.TabIndex = 3
        Me.iconMinimize.TabStop = False
        '
        'iconClose
        '
        Me.iconClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconClose.Image = CType(resources.GetObject("iconClose.Image"), System.Drawing.Image)
        Me.iconClose.Location = New System.Drawing.Point(235, 7)
        Me.iconClose.Name = "iconClose"
        Me.iconClose.Size = New System.Drawing.Size(22, 22)
        Me.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconClose.TabIndex = 2
        Me.iconClose.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.startUp_checkBox)
        Me.Panel2.Controls.Add(Me.hiddenField)
        Me.Panel2.Controls.Add(Me.tb_ip)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 35)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(269, 117)
        Me.Panel2.TabIndex = 5
        '
        'hiddenField
        '
        Me.hiddenField.AutoSize = True
        Me.hiddenField.Location = New System.Drawing.Point(227, 81)
        Me.hiddenField.Name = "hiddenField"
        Me.hiddenField.Size = New System.Drawing.Size(13, 13)
        Me.hiddenField.TabIndex = 4
        Me.hiddenField.Text = "0"
        Me.hiddenField.Visible = False
        '
        'startUp_checkBox
        '
        Me.startUp_checkBox.AutoSize = True
        Me.startUp_checkBox.Checked = True
        Me.startUp_checkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.startUp_checkBox.Location = New System.Drawing.Point(3, 100)
        Me.startUp_checkBox.Name = "startUp_checkBox"
        Me.startUp_checkBox.Size = New System.Drawing.Size(100, 17)
        Me.startUp_checkBox.TabIndex = 8
        Me.startUp_checkBox.Text = "Run at Start Up"
        Me.startUp_checkBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 152)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "IP Manager - Client"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.ep_RefreshRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_ip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents tb_ip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ep_RefreshRate As ErrorProvider
    Friend WithEvents ep_ip As ErrorProvider
    Friend WithEvents btn_Save As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents tsmi_Open As ToolStripMenuItem
    Friend WithEvents tsmi_close As ToolStripMenuItem
    Friend WithEvents Panel2 As Panel
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents iconMinimize As PictureBox
    Friend WithEvents iconClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents hiddenField As Label
    Friend WithEvents startUp_checkBox As CheckBox
End Class
