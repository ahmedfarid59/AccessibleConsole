<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.inputBox = New System.Windows.Forms.RichTextBox()
        Me.outputBox = New System.Windows.Forms.RichTextBox()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.fileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.saveItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.editMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.actionMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.helpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.copyInputItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.switchConsole = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'inputBox
        '
        Me.inputBox.AcceptsTab = True
        Me.inputBox.Location = New System.Drawing.Point(8, 8)
        Me.inputBox.Name = "inputBox"
        Me.inputBox.Size = New System.Drawing.Size(100, 96)
        Me.inputBox.TabIndex = 1
        Me.inputBox.Text = ""
        Me.inputBox.WordWrap = False
        '
        'outputBox
        '
        Me.outputBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.outputBox.Location = New System.Drawing.Point(0, 354)
        Me.outputBox.Name = "outputBox"
        Me.outputBox.ReadOnly = True
        Me.outputBox.Size = New System.Drawing.Size(800, 96)
        Me.outputBox.TabIndex = 3
        Me.outputBox.Text = ""
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fileMenu, Me.editMenu, Me.actionMenu, Me.helpMenu})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(800, 24)
        Me.menu.TabIndex = 4
        Me.menu.Text = "&file"
        '
        'fileMenu
        '
        Me.fileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.saveItem, Me.exitItem})
        Me.fileMenu.Name = "fileMenu"
        Me.fileMenu.Size = New System.Drawing.Size(37, 20)
        Me.fileMenu.Text = "&File"
        '
        'saveItem
        '
        Me.saveItem.Name = "saveItem"
        Me.saveItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.saveItem.Size = New System.Drawing.Size(180, 22)
        Me.saveItem.Text = "SaveHistory"
        Me.saveItem.ToolTipText = "Saves the cureent current input and output history in a file."
        '
        'exitItem
        '
        Me.exitItem.Name = "exitItem"
        Me.exitItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.exitItem.Size = New System.Drawing.Size(180, 22)
        Me.exitItem.Text = "Exit"
        '
        'editMenu
        '
        Me.editMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.copyInputItem, Me.ToolStripMenuItem2})
        Me.editMenu.Name = "editMenu"
        Me.editMenu.Size = New System.Drawing.Size(39, 20)
        Me.editMenu.Text = "&edit"
        '
        'actionMenu
        '
        Me.actionMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.switchConsole})
        Me.actionMenu.Name = "actionMenu"
        Me.actionMenu.Size = New System.Drawing.Size(54, 20)
        Me.actionMenu.Text = "&Action"
        '
        'helpMenu
        '
        Me.helpMenu.Name = "helpMenu"
        Me.helpMenu.Size = New System.Drawing.Size(42, 20)
        Me.helpMenu.Text = "&help"
        '
        'copyInputItem
        '
        Me.copyInputItem.Name = "copyInputItem"
        Me.copyInputItem.Size = New System.Drawing.Size(209, 22)
        Me.copyInputItem.Text = "copy selected commands"
        Me.copyInputItem.ToolTipText = "copies the selected commands from the input commands text box."
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(209, 22)
        Me.ToolStripMenuItem2.Text = "ToolStripMenuItem2"
        '
        'switchConsole
        '
        Me.switchConsole.Name = "switchConsole"
        Me.switchConsole.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.switchConsole.Size = New System.Drawing.Size(199, 22)
        Me.switchConsole.Text = "Change Console"
        Me.switchConsole.ToolTipText = "Changes the currnt current working console."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.outputBox)
        Me.Controls.Add(Me.inputBox)
        Me.Controls.Add(Me.menu)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menu
        Me.Name = "Form1"
        Me.Text = "Accessible Console"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents inputBox As RichTextBox
    Friend WithEvents outputBox As RichTextBox
    Friend WithEvents menu As MenuStrip
    Friend WithEvents fileMenu As ToolStripMenuItem
    Friend WithEvents editMenu As ToolStripMenuItem
    Friend WithEvents helpMenu As ToolStripMenuItem
    Friend WithEvents saveItem As ToolStripMenuItem
    Friend WithEvents exitItem As ToolStripMenuItem
    Friend WithEvents actionMenu As ToolStripMenuItem
    Friend WithEvents copyInputItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents switchConsole As ToolStripMenuItem
End Class
