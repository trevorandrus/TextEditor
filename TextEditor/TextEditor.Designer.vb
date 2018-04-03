<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTextEditor
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
        Me.mnuOptions = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCopy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCut = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPaste = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbEntry = New System.Windows.Forms.TextBox()
        Me.mnuOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuOptions
        '
        Me.mnuOptions.AccessibleName = "mnuOptions"
        Me.mnuOptions.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.mnuOptions.Location = New System.Drawing.Point(0, 0)
        Me.mnuOptions.Name = "mnuOptions"
        Me.mnuOptions.Size = New System.Drawing.Size(676, 28)
        Me.mnuOptions.TabIndex = 0
        Me.mnuOptions.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.AccessibleName = "mnuFile"
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(44, 24)
        Me.mnuFile.Text = "&File"
        '
        'mnuNew
        '
        Me.mnuNew.AccessibleName = "mnuNew"
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(182, 26)
        Me.mnuNew.Text = "&New    Ctrl + N"
        '
        'mnuOpen
        '
        Me.mnuOpen.AccessibleName = "mnuOpen"
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(182, 26)
        Me.mnuOpen.Text = "&Open  Ctrl + O"
        '
        'mnuSave
        '
        Me.mnuSave.AccessibleName = "mnuSave"
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(182, 26)
        Me.mnuSave.Text = "&Save   Ctrl + S"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.AccessibleName = "mnuSaveAs"
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(182, 26)
        Me.mnuSaveAs.Text = "Save &As"
        '
        'mnuExit
        '
        Me.mnuExit.AccessibleName = "mnuExit"
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(182, 26)
        Me.mnuExit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.AccessibleName = "mnuEdit"
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCopy, Me.mnuCut, Me.mnuPaste})
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(47, 24)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuCopy
        '
        Me.mnuCopy.AccessibleName = "mnuCopy"
        Me.mnuCopy.Name = "mnuCopy"
        Me.mnuCopy.Size = New System.Drawing.Size(180, 26)
        Me.mnuCopy.Text = "&Copy   Ctrl + C"
        '
        'mnuCut
        '
        Me.mnuCut.AccessibleName = "mnuCut"
        Me.mnuCut.Name = "mnuCut"
        Me.mnuCut.Size = New System.Drawing.Size(180, 26)
        Me.mnuCut.Text = "Cu&t      Ctrl + X"
        '
        'mnuPaste
        '
        Me.mnuPaste.AccessibleName = "mnuPaste"
        Me.mnuPaste.Name = "mnuPaste"
        Me.mnuPaste.Size = New System.Drawing.Size(180, 26)
        Me.mnuPaste.Text = "&Paste   Ctrl + V"
        '
        'mnuHelp
        '
        Me.mnuHelp.AccessibleName = "mnuHelp"
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(53, 24)
        Me.mnuHelp.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.AccessibleName = "mnuAbout"
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(125, 26)
        Me.mnuAbout.Text = "About"
        '
        'tbEntry
        '
        Me.tbEntry.AccessibleName = "tbEntry"
        Me.tbEntry.Location = New System.Drawing.Point(0, 32)
        Me.tbEntry.Multiline = True
        Me.tbEntry.Name = "tbEntry"
        Me.tbEntry.Size = New System.Drawing.Size(676, 446)
        Me.tbEntry.TabIndex = 1
        '
        'frmTextEditor
        '
        Me.AccessibleName = "frmTextEditor"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 475)
        Me.Controls.Add(Me.tbEntry)
        Me.Controls.Add(Me.mnuOptions)
        Me.MainMenuStrip = Me.mnuOptions
        Me.Name = "frmTextEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text Editor"
        Me.mnuOptions.ResumeLayout(False)
        Me.mnuOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuOptions As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents mnuCopy As ToolStripMenuItem
    Friend WithEvents mnuCut As ToolStripMenuItem
    Friend WithEvents mnuPaste As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents tbEntry As TextBox
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
