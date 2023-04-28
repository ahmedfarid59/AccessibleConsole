Public Class Form1
	Dim con As New Process()
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		con.StartInfo = New ProcessStartInfo
		con.StartInfo.FileName = "python.exe"
		con.StartInfo.WorkingDirectory = "C:"
		con.StartInfo.Arguments = "-i"
		con.StartInfo.UseShellExecute = False
		con.StartInfo.RedirectStandardInput = True
		con.StartInfo.RedirectStandardOutput = True
		con.StartInfo.RedirectStandardError = True
		con.StartInfo.CreateNoWindow = True
		AddHandler con.OutputDataReceived, AddressOf Process_OutputDataReceived
		AddHandler con.ErrorDataReceived, AddressOf Process_OutputDataReceived
		con.Start()
		con.BeginOutputReadLine()
		con.BeginErrorReadLine()
		con.StandardInput.AutoFlush = True
	End Sub

	Private Sub Process_OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
		If e.Data IsNot Nothing Then
			outputBox.AppendText(e.Data & Environment.NewLine)
		End If
	End Sub

	Private Sub inputBox_KeyDown(sender As Object, e As KeyEventArgs) Handles inputBox.KeyDown
		If e.KeyCode = Keys.F6 Then
			outputBox.Focus()
		ElseIf e.KeyCode = Keys.Enter Then
			Dim lines() As String = inputBox.Lines
			Dim index As Integer = inputBox.GetLineFromCharIndex(inputBox.SelectionStart)
			Dim Input As String = inputBox.Lines(index)
			con.StandardInput.WriteLine(Input)
			If Input <> "" Then
				outputBox.AppendText(Input & Environment.NewLine)
				If index <> lines.Length - 1 Then
					e.SuppressKeyPress = True
				End If
			Else
				e.SuppressKeyPress = True
			End If
		End If
	End Sub

	Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		con.Kill()
		con.Dispose()
	End Sub

	Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
		If e.KeyCode = Keys.Escape Then
			Me.Close()
		ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
			Dim filePath As String
			Dim choice As New SaveFileDialog
			If choice.ShowDialog = DialogResult.OK Then
				filePath = choice.FileName
				Dim content As String = outputBox.Text
				System.IO.File.WriteAllText(filePath, content)
			End If
		ElseIf e.Control And e.KeyCode = Keys.L Then
			outputBox.Clear()
			inputBox.Clear()
		End If
	End Sub
End Class