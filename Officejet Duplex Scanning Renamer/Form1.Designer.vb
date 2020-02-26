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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.RenameFilesButton = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DonateToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RemoveOriginalScansWhenFinishedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HowDoIUseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DevelopersWebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProgramStatus = New System.Windows.Forms.TextBox
        Me.SelectFolder_Button = New System.Windows.Forms.Button
        Me.OpenFolderButton = New System.Windows.Forms.Button
        Me.DonateLabel = New System.Windows.Forms.LinkLabel
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.CutePDFWriterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClearLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RenameFilesButton
        '
        Me.RenameFilesButton.Location = New System.Drawing.Point(12, 88)
        Me.RenameFilesButton.Name = "RenameFilesButton"
        Me.RenameFilesButton.Size = New System.Drawing.Size(138, 43)
        Me.RenameFilesButton.TabIndex = 2
        Me.RenameFilesButton.Text = "2) Rename Files"
        Me.RenameFilesButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(712, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DonateToolStripMenuItem1, Me.CutePDFWriterToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DonateToolStripMenuItem1
        '
        Me.DonateToolStripMenuItem1.Name = "DonateToolStripMenuItem1"
        Me.DonateToolStripMenuItem1.Size = New System.Drawing.Size(163, 22)
        Me.DonateToolStripMenuItem1.Text = "Donate"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveOriginalScansWhenFinishedToolStripMenuItem, Me.ClearLogToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'RemoveOriginalScansWhenFinishedToolStripMenuItem
        '
        Me.RemoveOriginalScansWhenFinishedToolStripMenuItem.CheckOnClick = True
        Me.RemoveOriginalScansWhenFinishedToolStripMenuItem.Name = "RemoveOriginalScansWhenFinishedToolStripMenuItem"
        Me.RemoveOriginalScansWhenFinishedToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.RemoveOriginalScansWhenFinishedToolStripMenuItem.Text = "Remove Originals when finished."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HowDoIUseToolStripMenuItem, Me.DevelopersWebsiteToolStripMenuItem, Me.ToolStripSeparator3, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HowDoIUseToolStripMenuItem
        '
        Me.HowDoIUseToolStripMenuItem.Name = "HowDoIUseToolStripMenuItem"
        Me.HowDoIUseToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.HowDoIUseToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.HowDoIUseToolStripMenuItem.Text = "How do I use?"
        '
        'DevelopersWebsiteToolStripMenuItem
        '
        Me.DevelopersWebsiteToolStripMenuItem.Name = "DevelopersWebsiteToolStripMenuItem"
        Me.DevelopersWebsiteToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.DevelopersWebsiteToolStripMenuItem.Text = "Developer's Website"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(271, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(274, 22)
        Me.AboutToolStripMenuItem.Text = "About K Ram Duplex Scan File Renamer"
        '
        'ProgramStatus
        '
        Me.ProgramStatus.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ProgramStatus.HideSelection = False
        Me.ProgramStatus.Location = New System.Drawing.Point(156, 39)
        Me.ProgramStatus.Multiline = True
        Me.ProgramStatus.Name = "ProgramStatus"
        Me.ProgramStatus.ReadOnly = True
        Me.ProgramStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ProgramStatus.Size = New System.Drawing.Size(544, 197)
        Me.ProgramStatus.TabIndex = 4
        '
        'SelectFolder_Button
        '
        Me.SelectFolder_Button.Location = New System.Drawing.Point(12, 39)
        Me.SelectFolder_Button.Name = "SelectFolder_Button"
        Me.SelectFolder_Button.Size = New System.Drawing.Size(138, 43)
        Me.SelectFolder_Button.TabIndex = 1
        Me.SelectFolder_Button.Text = "1) Select Folder"
        Me.SelectFolder_Button.UseVisualStyleBackColor = True
        '
        'OpenFolderButton
        '
        Me.OpenFolderButton.Location = New System.Drawing.Point(12, 137)
        Me.OpenFolderButton.Name = "OpenFolderButton"
        Me.OpenFolderButton.Size = New System.Drawing.Size(138, 43)
        Me.OpenFolderButton.TabIndex = 3
        Me.OpenFolderButton.Text = "3) Open Folder"
        Me.OpenFolderButton.UseVisualStyleBackColor = True
        '
        'DonateLabel
        '
        Me.DonateLabel.AutoSize = True
        Me.DonateLabel.Location = New System.Drawing.Point(8, 200)
        Me.DonateLabel.Name = "DonateLabel"
        Me.DonateLabel.Size = New System.Drawing.Size(142, 13)
        Me.DonateLabel.TabIndex = 6
        Me.DonateLabel.TabStop = True
        Me.DonateLabel.Text = "Donate to K Ram Computing"
        '
        'CutePDFWriterToolStripMenuItem
        '
        Me.CutePDFWriterToolStripMenuItem.Name = "CutePDFWriterToolStripMenuItem"
        Me.CutePDFWriterToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.CutePDFWriterToolStripMenuItem.Text = "Cute PDF Writer"
        '
        'ClearLogToolStripMenuItem
        '
        Me.ClearLogToolStripMenuItem.Name = "ClearLogToolStripMenuItem"
        Me.ClearLogToolStripMenuItem.Size = New System.Drawing.Size(241, 22)
        Me.ClearLogToolStripMenuItem.Text = "Clear Log"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 250)
        Me.Controls.Add(Me.DonateLabel)
        Me.Controls.Add(Me.OpenFolderButton)
        Me.Controls.Add(Me.SelectFolder_Button)
        Me.Controls.Add(Me.ProgramStatus)
        Me.Controls.Add(Me.RenameFilesButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "K Ram Duplex Scan File Renamer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents RenameFilesButton As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramStatus As System.Windows.Forms.TextBox
    Friend WithEvents SelectFolder_Button As System.Windows.Forms.Button
    Friend WithEvents OpenFolderButton As System.Windows.Forms.Button
    Friend WithEvents DevelopersWebsiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HowDoIUseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonateLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents DonateToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveOriginalScansWhenFinishedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutePDFWriterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearLogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
