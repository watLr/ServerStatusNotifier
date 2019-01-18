<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tb_Email = New System.Windows.Forms.TextBox()
        Me.tb_RefreshRate = New System.Windows.Forms.TextBox()
        Me.tb_TimeToOffline = New System.Windows.Forms.TextBox()
        Me.ep_Email = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ep_refresh = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ep_offlineTime = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tb_Phone = New System.Windows.Forms.TextBox()
        Me.btn_Phone = New System.Windows.Forms.Button()
        Me.iconClose = New System.Windows.Forms.PictureBox()
        Me.tb_User = New System.Windows.Forms.TextBox()
        Me.tb_Key = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveRecipientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.ServerLogo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ep_Email, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_refresh, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ep_offlineTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.ServerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Email:"
        '
        'tb_Email
        '
        Me.tb_Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Email.Location = New System.Drawing.Point(72, 64)
        Me.tb_Email.Name = "tb_Email"
        Me.tb_Email.Size = New System.Drawing.Size(192, 20)
        Me.tb_Email.TabIndex = 1
        '
        'tb_RefreshRate
        '
        Me.tb_RefreshRate.Location = New System.Drawing.Point(0, 41)
        Me.tb_RefreshRate.Name = "tb_RefreshRate"
        Me.tb_RefreshRate.Size = New System.Drawing.Size(12, 20)
        Me.tb_RefreshRate.TabIndex = 2
        Me.tb_RefreshRate.Text = "10000"
        Me.tb_RefreshRate.Visible = False
        '
        'tb_TimeToOffline
        '
        Me.tb_TimeToOffline.Location = New System.Drawing.Point(0, 66)
        Me.tb_TimeToOffline.Name = "tb_TimeToOffline"
        Me.tb_TimeToOffline.Size = New System.Drawing.Size(12, 20)
        Me.tb_TimeToOffline.TabIndex = 3
        Me.tb_TimeToOffline.Text = "3"
        Me.tb_TimeToOffline.Visible = False
        '
        'ep_Email
        '
        Me.ep_Email.ContainerControl = Me
        '
        'ep_refresh
        '
        Me.ep_refresh.ContainerControl = Me
        '
        'ep_offlineTime
        '
        Me.ep_offlineTime.ContainerControl = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(270, 62)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(22, 23)
        Me.btn_Save.TabIndex = 8
        Me.btn_Save.Text = "+"
        Me.btn_Save.UseVisualStyleBackColor = True
        Me.btn_Save.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Phone:"
        '
        'tb_Phone
        '
        Me.tb_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Phone.Location = New System.Drawing.Point(72, 38)
        Me.tb_Phone.Name = "tb_Phone"
        Me.tb_Phone.Size = New System.Drawing.Size(192, 20)
        Me.tb_Phone.TabIndex = 10
        '
        'btn_Phone
        '
        Me.btn_Phone.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btn_Phone.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Phone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Phone.Location = New System.Drawing.Point(270, 36)
        Me.btn_Phone.Name = "btn_Phone"
        Me.btn_Phone.Size = New System.Drawing.Size(47, 49)
        Me.btn_Phone.TabIndex = 11
        Me.btn_Phone.Text = "+"
        Me.btn_Phone.UseVisualStyleBackColor = False
        '
        'iconClose
        '
        Me.iconClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.iconClose.Image = Global.Online_Check_Server.My.Resources.Resources.cerrar
        Me.iconClose.Location = New System.Drawing.Point(301, 2)
        Me.iconClose.Name = "iconClose"
        Me.iconClose.Size = New System.Drawing.Size(25, 24)
        Me.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconClose.TabIndex = 13
        Me.iconClose.TabStop = False
        '
        'tb_User
        '
        Me.tb_User.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_User.Location = New System.Drawing.Point(72, 103)
        Me.tb_User.Name = "tb_User"
        Me.tb_User.Size = New System.Drawing.Size(192, 20)
        Me.tb_User.TabIndex = 17
        '
        'tb_Key
        '
        Me.tb_Key.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Key.Location = New System.Drawing.Point(72, 129)
        Me.tb_Key.Name = "tb_Key"
        Me.tb_Key.Size = New System.Drawing.Size(192, 20)
        Me.tb_Key.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(270, 101)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(47, 49)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "User:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "API Key:"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveRecipientToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.HelpToolStripMenuItem.Text = "Options"
        '
        'RemoveRecipientToolStripMenuItem
        '
        Me.RemoveRecipientToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveRecipientToolStripMenuItem.Name = "RemoveRecipientToolStripMenuItem"
        Me.RemoveRecipientToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoveRecipientToolStripMenuItem.Text = "Remove Recipient"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ContactUsToolStripMenuItem})
        Me.HelpToolStripMenuItem1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'ContactUsToolStripMenuItem
        '
        Me.ContactUsToolStripMenuItem.Name = "ContactUsToolStripMenuItem"
        Me.ContactUsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ContactUsToolStripMenuItem.Text = "Leave Feedback"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "About this Form"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(30, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(267, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.iconClose)
        Me.panelTitleBar.Controls.Add(Me.ServerLogo)
        Me.panelTitleBar.Controls.Add(Me.PictureBox1)
        Me.panelTitleBar.Controls.Add(Me.MenuStrip1)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(329, 29)
        Me.panelTitleBar.TabIndex = 22
        '
        'ServerLogo
        '
        Me.ServerLogo.Image = CType(resources.GetObject("ServerLogo.Image"), System.Drawing.Image)
        Me.ServerLogo.Location = New System.Drawing.Point(0, 0)
        Me.ServerLogo.Name = "ServerLogo"
        Me.ServerLogo.Size = New System.Drawing.Size(29, 29)
        Me.ServerLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ServerLogo.TabIndex = 5
        Me.ServerLogo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(584, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 164)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tb_Key)
        Me.Controls.Add(Me.tb_User)
        Me.Controls.Add(Me.btn_Phone)
        Me.Controls.Add(Me.tb_Phone)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.tb_TimeToOffline)
        Me.Controls.Add(Me.tb_RefreshRate)
        Me.Controls.Add(Me.tb_Email)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Settings"
        Me.Text = "Settings"
        CType(Me.ep_Email, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_refresh, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ep_offlineTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.ServerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Email As TextBox
    Friend WithEvents tb_RefreshRate As TextBox
    Friend WithEvents tb_TimeToOffline As TextBox
    Friend WithEvents ep_Email As ErrorProvider
    Friend WithEvents ep_refresh As ErrorProvider
    Friend WithEvents ep_offlineTime As ErrorProvider
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btn_Save As Button
    Friend WithEvents tb_Phone As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_Phone As Button
    Friend WithEvents iconClose As PictureBox
    Friend WithEvents tb_Key As TextBox
    Friend WithEvents tb_User As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveRecipientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContactUsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents ServerLogo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
