<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Main = New Panel()
        Footer = New Panel()
        lblStatus = New Label()
        Body = New Panel()
        lblLog = New Label()
        txtLog = New TextBox()
        btnToggle = New Button()
        Title = New Panel()
        lblTitle = New Label()
        lblCatchPhrase = New Label()
        TopBar = New Panel()
        btnClose = New Button()
        appIcon = New NotifyIcon(components)
        contextMenu = New ContextMenuStrip(components)
        OpenToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        Main.SuspendLayout()
        Footer.SuspendLayout()
        Body.SuspendLayout()
        Title.SuspendLayout()
        TopBar.SuspendLayout()
        contextMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' Main
        ' 
        Main.Controls.Add(Footer)
        Main.Controls.Add(Body)
        Main.Controls.Add(Title)
        Main.Controls.Add(TopBar)
        Main.Dock = DockStyle.Fill
        Main.Location = New Point(0, 0)
        Main.Name = "Main"
        Main.Size = New Size(600, 450)
        Main.TabIndex = 0
        ' 
        ' Footer
        ' 
        Footer.Controls.Add(lblStatus)
        Footer.Dock = DockStyle.Bottom
        Footer.Location = New Point(0, 370)
        Footer.Name = "Footer"
        Footer.Size = New Size(600, 80)
        Footer.TabIndex = 7
        ' 
        ' lblStatus
        ' 
        lblStatus.Dock = DockStyle.Fill
        lblStatus.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStatus.ForeColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        lblStatus.Location = New Point(0, 0)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(600, 80)
        lblStatus.TabIndex = 1
        lblStatus.Text = "Status: Running"
        lblStatus.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Body
        ' 
        Body.Controls.Add(lblLog)
        Body.Controls.Add(txtLog)
        Body.Controls.Add(btnToggle)
        Body.Dock = DockStyle.Top
        Body.Location = New Point(0, 86)
        Body.Name = "Body"
        Body.Size = New Size(600, 280)
        Body.TabIndex = 6
        ' 
        ' lblLog
        ' 
        lblLog.AutoSize = True
        lblLog.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLog.ForeColor = Color.FromArgb(CByte(181), CByte(181), CByte(181))
        lblLog.Location = New Point(278, 79)
        lblLog.Name = "lblLog"
        lblLog.Size = New Size(45, 19)
        lblLog.TabIndex = 2
        lblLog.Text = "Log:"
        ' 
        ' txtLog
        ' 
        txtLog.BackColor = Color.FromArgb(CByte(40), CByte(40), CByte(40))
        txtLog.BorderStyle = BorderStyle.None
        txtLog.Cursor = Cursors.IBeam
        txtLog.Font = New Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLog.ForeColor = Color.FromArgb(CByte(213), CByte(123), CByte(113))
        txtLog.Location = New Point(12, 101)
        txtLog.Multiline = True
        txtLog.Name = "txtLog"
        txtLog.PlaceholderText = "All keystrokes logged will be displayed here!"
        txtLog.ReadOnly = True
        txtLog.ScrollBars = ScrollBars.Vertical
        txtLog.Size = New Size(576, 166)
        txtLog.TabIndex = 1
        txtLog.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnToggle
        ' 
        btnToggle.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnToggle.FlatAppearance.BorderSize = 0
        btnToggle.FlatStyle = FlatStyle.Flat
        btnToggle.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnToggle.ForeColor = Color.FromArgb(CByte(234), CByte(189), CByte(184))
        btnToggle.Location = New Point(221, 24)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New Size(160, 40)
        btnToggle.TabIndex = 0
        btnToggle.Text = "Stop Keylogger"
        btnToggle.UseVisualStyleBackColor = False
        ' 
        ' Title
        ' 
        Title.Controls.Add(lblTitle)
        Title.Controls.Add(lblCatchPhrase)
        Title.Dock = DockStyle.Top
        Title.Location = New Point(0, 30)
        Title.Name = "Title"
        Title.Size = New Size(600, 56)
        Title.TabIndex = 5
        ' 
        ' lblTitle
        ' 
        lblTitle.Dock = DockStyle.Top
        lblTitle.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ForeColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        lblTitle.Location = New Point(0, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(600, 37)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Secret Strokes"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCatchPhrase
        ' 
        lblCatchPhrase.Dock = DockStyle.Bottom
        lblCatchPhrase.Font = New Font("Segoe UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCatchPhrase.ForeColor = Color.FromArgb(CByte(213), CByte(123), CByte(113))
        lblCatchPhrase.Location = New Point(0, 35)
        lblCatchPhrase.Name = "lblCatchPhrase"
        lblCatchPhrase.Size = New Size(600, 21)
        lblCatchPhrase.TabIndex = 3
        lblCatchPhrase.Text = "Swiftly steal your secrets."
        lblCatchPhrase.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TopBar
        ' 
        TopBar.Controls.Add(btnClose)
        TopBar.Dock = DockStyle.Top
        TopBar.Location = New Point(0, 0)
        TopBar.Name = "TopBar"
        TopBar.Size = New Size(600, 30)
        TopBar.TabIndex = 4
        ' 
        ' btnClose
        ' 
        btnClose.AutoSize = True
        btnClose.BackColor = Color.Transparent
        btnClose.Dock = DockStyle.Right
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClose.ForeColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnClose.Location = New Point(570, 0)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(30, 30)
        btnClose.TabIndex = 0
        btnClose.Text = "X"
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' appIcon
        ' 
        appIcon.Icon = CType(resources.GetObject("appIcon.Icon"), Icon)
        appIcon.Text = "SecretStroke"
        appIcon.Visible = True
        ' 
        ' contextMenu
        ' 
        contextMenu.Items.AddRange(New ToolStripItem() {OpenToolStripMenuItem, ExitToolStripMenuItem})
        contextMenu.Name = "contextMenu"
        contextMenu.Size = New Size(104, 48)
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(103, 22)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(103, 22)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        ClientSize = New Size(600, 450)
        Controls.Add(Main)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Secret Strokes"
        Main.ResumeLayout(False)
        Footer.ResumeLayout(False)
        Body.ResumeLayout(False)
        Body.PerformLayout()
        Title.ResumeLayout(False)
        TopBar.ResumeLayout(False)
        TopBar.PerformLayout()
        contextMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Main As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCatchPhrase As Label
    Friend WithEvents Title As Panel
    Friend WithEvents TopBar As Panel
    Friend WithEvents Footer As Panel
    Friend WithEvents Body As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnToggle As Button
    Friend WithEvents txtLog As TextBox
    Friend WithEvents lblLog As Label
    Friend WithEvents appIcon As NotifyIcon
    Friend WithEvents contextMenu As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem

End Class
