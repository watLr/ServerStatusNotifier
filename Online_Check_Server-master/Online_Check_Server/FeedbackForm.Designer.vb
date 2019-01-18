<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeedbackForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FeedbackForm))
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iconClose = New System.Windows.Forms.PictureBox()
        Me.ServerLogo = New System.Windows.Forms.PictureBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServerLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.Label1)
        Me.panelTitleBar.Controls.Add(Me.iconClose)
        Me.panelTitleBar.Controls.Add(Me.ServerLogo)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(252, 29)
        Me.panelTitleBar.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Feedback Form"
        '
        'iconClose
        '
        Me.iconClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.iconClose.Image = Global.Online_Check_Server.My.Resources.Resources.cerrar
        Me.iconClose.Location = New System.Drawing.Point(223, 3)
        Me.iconClose.Name = "iconClose"
        Me.iconClose.Size = New System.Drawing.Size(25, 24)
        Me.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.iconClose.TabIndex = 13
        Me.iconClose.TabStop = False
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
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 29)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(245, 103)
        Me.RichTextBox1.TabIndex = 24
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(173, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FeedbackForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 170)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.panelTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FeedbackForm"
        Me.Text = "FeedbackForm"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.iconClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServerLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents iconClose As PictureBox
    Friend WithEvents ServerLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
End Class
