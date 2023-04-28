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
        Me.inputBox = New System.Windows.Forms.RichTextBox()
        Me.outputBox = New System.Windows.Forms.RichTextBox()
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.outputBox)
        Me.Controls.Add(Me.inputBox)
        Me.KeyPreview = True
        Me.Name = "Form1"
        Me.Text = "Accessible Console"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents inputBox As RichTextBox
    Friend WithEvents outputBox As RichTextBox
End Class
