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
        Me.error_ip = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransferClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.listView_Connections = New System.Windows.Forms.ListView()
        Me.col_ip = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_sendEmail = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.col_MinSinceLastCheck = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.gb_IpRange = New System.Windows.Forms.GroupBox()
        Me.lbl_IPRangeTo = New System.Windows.Forms.Label()
        Me.lbl_IPRangeFrom = New System.Windows.Forms.Label()
        Me.tb_higherIPRange = New System.Windows.Forms.TextBox()
        Me.tb_lowerIPRange = New System.Windows.Forms.TextBox()
        Me.gb_ServerName = New System.Windows.Forms.GroupBox()
        Me.gb_serverControls = New System.Windows.Forms.GroupBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnTransClient = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.tb_ServerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_forceRefresh = New System.Windows.Forms.Button()
        Me.btn_toggleServerCheck = New System.Windows.Forms.Button()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ServerLogo = New System.Windows.Forms.PictureBox()
        Me.iconMinimize = New System.Windows.Forms.PictureBox()
        Me.iconClose = New System.Windows.Forms.PictureBox()
        CType(Me.error_ip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.gb_IpRange.SuspendLayout()
        Me.gb_serverControls.SuspendLayout()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.ServerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'error_ip
        '
        Me.error_ip.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.error_ip.ContainerControl = Me
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.TransferClientToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1001, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'TransferClientToolStripMenuItem
        '
        Me.TransferClientToolStripMenuItem.Name = "TransferClientToolStripMenuItem"
        Me.TransferClientToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.TransferClientToolStripMenuItem.Text = "Transfer Client"
        '
        'listView_Connections
        '
        Me.listView_Connections.AllowColumnReorder = True
        Me.listView_Connections.BackColor = System.Drawing.SystemColors.Window
        Me.listView_Connections.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listView_Connections.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.col_ip, Me.col_Name, Me.col_status, Me.col_sendEmail, Me.col_MinSinceLastCheck})
        Me.listView_Connections.ForeColor = System.Drawing.SystemColors.WindowText
        Me.listView_Connections.FullRowSelect = True
        Me.listView_Connections.GridLines = True
        Me.listView_Connections.LabelEdit = True
        Me.listView_Connections.Location = New System.Drawing.Point(123, 31)
        Me.listView_Connections.Name = "listView_Connections"
        Me.listView_Connections.Size = New System.Drawing.Size(618, 313)
        Me.listView_Connections.TabIndex = 0
        Me.listView_Connections.UseCompatibleStateImageBehavior = False
        Me.listView_Connections.View = System.Windows.Forms.View.Details
        '
        'col_ip
        '
        Me.col_ip.Text = "Server IP"
        Me.col_ip.Width = 122
        '
        'col_Name
        '
        Me.col_Name.Text = "Server Name"
        Me.col_Name.Width = 153
        '
        'col_status
        '
        Me.col_status.Text = "Server Status"
        Me.col_status.Width = 87
        '
        'col_sendEmail
        '
        Me.col_sendEmail.Text = "Send Email On Crash"
        Me.col_sendEmail.Width = 115
        '
        'col_MinSinceLastCheck
        '
        Me.col_MinSinceLastCheck.Text = "Time Since Last Check"
        Me.col_MinSinceLastCheck.Width = 141
        '
        'gb_IpRange
        '
        Me.gb_IpRange.Controls.Add(Me.lbl_IPRangeTo)
        Me.gb_IpRange.Controls.Add(Me.lbl_IPRangeFrom)
        Me.gb_IpRange.Controls.Add(Me.tb_higherIPRange)
        Me.gb_IpRange.Controls.Add(Me.tb_lowerIPRange)
        Me.gb_IpRange.Location = New System.Drawing.Point(144, 383)
        Me.gb_IpRange.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_IpRange.Name = "gb_IpRange"
        Me.gb_IpRange.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_IpRange.Size = New System.Drawing.Size(233, 87)
        Me.gb_IpRange.TabIndex = 1
        Me.gb_IpRange.TabStop = False
        Me.gb_IpRange.Text = "IP Range"
        Me.gb_IpRange.Visible = False
        '
        'lbl_IPRangeTo
        '
        Me.lbl_IPRangeTo.AutoSize = True
        Me.lbl_IPRangeTo.Location = New System.Drawing.Point(118, 35)
        Me.lbl_IPRangeTo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_IPRangeTo.Name = "lbl_IPRangeTo"
        Me.lbl_IPRangeTo.Size = New System.Drawing.Size(23, 13)
        Me.lbl_IPRangeTo.TabIndex = 3
        Me.lbl_IPRangeTo.Text = "To:"
        '
        'lbl_IPRangeFrom
        '
        Me.lbl_IPRangeFrom.AutoSize = True
        Me.lbl_IPRangeFrom.Location = New System.Drawing.Point(3, 35)
        Me.lbl_IPRangeFrom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_IPRangeFrom.Name = "lbl_IPRangeFrom"
        Me.lbl_IPRangeFrom.Size = New System.Drawing.Size(30, 13)
        Me.lbl_IPRangeFrom.TabIndex = 2
        Me.lbl_IPRangeFrom.Text = "From"
        '
        'tb_higherIPRange
        '
        Me.tb_higherIPRange.Location = New System.Drawing.Point(145, 33)
        Me.tb_higherIPRange.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_higherIPRange.Name = "tb_higherIPRange"
        Me.tb_higherIPRange.Size = New System.Drawing.Size(84, 20)
        Me.tb_higherIPRange.TabIndex = 1
        '
        'tb_lowerIPRange
        '
        Me.tb_lowerIPRange.Location = New System.Drawing.Point(38, 33)
        Me.tb_lowerIPRange.Margin = New System.Windows.Forms.Padding(2)
        Me.tb_lowerIPRange.Name = "tb_lowerIPRange"
        Me.tb_lowerIPRange.Size = New System.Drawing.Size(76, 20)
        Me.tb_lowerIPRange.TabIndex = 0
        '
        'gb_ServerName
        '
        Me.gb_ServerName.Location = New System.Drawing.Point(400, 383)
        Me.gb_ServerName.Name = "gb_ServerName"
        Me.gb_ServerName.Size = New System.Drawing.Size(130, 87)
        Me.gb_ServerName.TabIndex = 4
        Me.gb_ServerName.TabStop = False
        Me.gb_ServerName.Text = "Server Name"
        Me.gb_ServerName.Visible = False
        '
        'gb_serverControls
        '
        Me.gb_serverControls.BackColor = System.Drawing.Color.WhiteSmoke
        Me.gb_serverControls.Controls.Add(Me.btnRemove)
        Me.gb_serverControls.Controls.Add(Me.btnTransClient)
        Me.gb_serverControls.Controls.Add(Me.btnSettings)
        Me.gb_serverControls.Controls.Add(Me.tb_ServerName)
        Me.gb_serverControls.Controls.Add(Me.Label1)
        Me.gb_serverControls.Controls.Add(Me.btn_forceRefresh)
        Me.gb_serverControls.Controls.Add(Me.btn_toggleServerCheck)
        Me.gb_serverControls.Dock = System.Windows.Forms.DockStyle.Left
        Me.gb_serverControls.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_serverControls.ForeColor = System.Drawing.SystemColors.ControlText
        Me.gb_serverControls.Location = New System.Drawing.Point(0, 0)
        Me.gb_serverControls.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_serverControls.Name = "gb_serverControls"
        Me.gb_serverControls.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_serverControls.Size = New System.Drawing.Size(123, 344)
        Me.gb_serverControls.TabIndex = 2
        Me.gb_serverControls.TabStop = False
        Me.gb_serverControls.Text = "Server Controls"
        '
        'btnRemove
        '
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(8, 268)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(108, 29)
        Me.btnRemove.TabIndex = 6
        Me.btnRemove.Text = "Clear Manager"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnTransClient
        '
        Me.btnTransClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTransClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransClient.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransClient.Location = New System.Drawing.Point(8, 239)
        Me.btnTransClient.Name = "btnTransClient"
        Me.btnTransClient.Size = New System.Drawing.Size(108, 23)
        Me.btnTransClient.TabIndex = 5
        Me.btnTransClient.Text = "Transfer Client"
        Me.btnTransClient.UseVisualStyleBackColor = True
        Me.btnTransClient.Visible = False
        '
        'btnSettings
        '
        Me.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSettings.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(8, 303)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(108, 28)
        Me.btnSettings.TabIndex = 4
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'tb_ServerName
        '
        Me.tb_ServerName.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ServerName.Location = New System.Drawing.Point(8, 63)
        Me.tb_ServerName.Name = "tb_ServerName"
        Me.tb_ServerName.Size = New System.Drawing.Size(108, 21)
        Me.tb_ServerName.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server Name"
        '
        'btn_forceRefresh
        '
        Me.btn_forceRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_forceRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_forceRefresh.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_forceRefresh.Location = New System.Drawing.Point(8, 89)
        Me.btn_forceRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_forceRefresh.Name = "btn_forceRefresh"
        Me.btn_forceRefresh.Size = New System.Drawing.Size(108, 24)
        Me.btn_forceRefresh.TabIndex = 1
        Me.btn_forceRefresh.Text = "Refresh "
        Me.btn_forceRefresh.UseVisualStyleBackColor = True
        '
        'btn_toggleServerCheck
        '
        Me.btn_toggleServerCheck.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_toggleServerCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_toggleServerCheck.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_toggleServerCheck.Location = New System.Drawing.Point(8, 19)
        Me.btn_toggleServerCheck.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_toggleServerCheck.Name = "btn_toggleServerCheck"
        Me.btn_toggleServerCheck.Size = New System.Drawing.Size(108, 24)
        Me.btn_toggleServerCheck.TabIndex = 0
        Me.btn_toggleServerCheck.Text = "Enable / DIsable"
        Me.btn_toggleServerCheck.UseVisualStyleBackColor = True
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.Label2)
        Me.panelTitleBar.Controls.Add(Me.ServerLogo)
        Me.panelTitleBar.Controls.Add(Me.iconMinimize)
        Me.panelTitleBar.Controls.Add(Me.iconClose)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(123, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(618, 29)
        Me.panelTitleBar.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "IP Manager - Server"
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
        'iconMinimize
        '
        Me.iconMinimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconMinimize.Image = CType(resources.GetObject("iconMinimize.Image"), System.Drawing.Image)
        Me.iconMinimize.Location = New System.Drawing.Point(547, 3)
        Me.iconMinimize.Name = "iconMinimize"
        Me.iconMinimize.Size = New System.Drawing.Size(22, 22)
        Me.iconMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconMinimize.TabIndex = 1
        Me.iconMinimize.TabStop = False
        '
        'iconClose
        '
        Me.iconClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iconClose.Image = CType(resources.GetObject("iconClose.Image"), System.Drawing.Image)
        Me.iconClose.Location = New System.Drawing.Point(584, 3)
        Me.iconClose.Name = "iconClose"
        Me.iconClose.Size = New System.Drawing.Size(22, 22)
        Me.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconClose.TabIndex = 0
        Me.iconClose.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 344)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.gb_ServerName)
        Me.Controls.Add(Me.gb_serverControls)
        Me.Controls.Add(Me.gb_IpRange)
        Me.Controls.Add(Me.listView_Connections)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "IP Manager - Server"
        CType(Me.error_ip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gb_IpRange.ResumeLayout(False)
        Me.gb_IpRange.PerformLayout()
        Me.gb_serverControls.ResumeLayout(False)
        Me.gb_serverControls.PerformLayout()
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.ServerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents error_ip As ErrorProvider
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransferClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents gb_ServerName As GroupBox
    Friend WithEvents gb_serverControls As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnTransClient As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents tb_ServerName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_forceRefresh As Button
    Friend WithEvents btn_toggleServerCheck As Button
    Friend WithEvents gb_IpRange As GroupBox
    Friend WithEvents lbl_IPRangeTo As Label
    Friend WithEvents lbl_IPRangeFrom As Label
    Friend WithEvents tb_higherIPRange As TextBox
    Friend WithEvents tb_lowerIPRange As TextBox
    Friend WithEvents listView_Connections As ListView
    Friend WithEvents col_ip As ColumnHeader
    Friend WithEvents col_Name As ColumnHeader
    Friend WithEvents col_status As ColumnHeader
    Friend WithEvents col_sendEmail As ColumnHeader
    Friend WithEvents col_MinSinceLastCheck As ColumnHeader
    Friend WithEvents iconMinimize As PictureBox
    Friend WithEvents iconClose As PictureBox
    Friend WithEvents ServerLogo As PictureBox
    Friend WithEvents Label2 As Label
End Class
