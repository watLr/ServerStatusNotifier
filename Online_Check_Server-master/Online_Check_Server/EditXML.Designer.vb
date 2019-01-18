<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditXML
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditXML))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveRecipientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.ServerLogo = New System.Windows.Forms.PictureBox()
        Me.iconMinimize = New System.Windows.Forms.PictureBox()
        Me.iconClose = New System.Windows.Forms.PictureBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MenuStrip1.SuspendLayout()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconMinimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(121, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 37)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(32, 4)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(59, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveRecipientToolStripMenuItem})
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Padding = New System.Windows.Forms.Padding(6, 0, 4, 0)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RemoveRecipientToolStripMenuItem
        '
        Me.RemoveRecipientToolStripMenuItem.Name = "RemoveRecipientToolStripMenuItem"
        Me.RemoveRecipientToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoveRecipientToolStripMenuItem.Text = "About this Form"
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.closeBtn)
        Me.panelTitleBar.Controls.Add(Me.MenuStrip1)
        Me.panelTitleBar.Controls.Add(Me.ServerLogo)
        Me.panelTitleBar.Controls.Add(Me.iconMinimize)
        Me.panelTitleBar.Controls.Add(Me.iconClose)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(368, 29)
        Me.panelTitleBar.TabIndex = 7
        '
        'closeBtn
        '
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.Image = CType(resources.GetObject("closeBtn.Image"), System.Drawing.Image)
        Me.closeBtn.Location = New System.Drawing.Point(343, 4)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(22, 22)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.closeBtn.TabIndex = 6
        Me.closeBtn.TabStop = False
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
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(32, 40)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(310, 86)
        Me.ListView1.TabIndex = 8
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Phone"
        Me.ColumnHeader1.Width = 122
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Email"
        Me.ColumnHeader2.Width = 183
        '
        'EditXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 192)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "EditXML"
        Me.Text = "EditXML"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconMinimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveRecipientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents ServerLogo As PictureBox
    Friend WithEvents iconMinimize As PictureBox
    Friend WithEvents iconClose As PictureBox
    Friend WithEvents closeBtn As PictureBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
End Class
