Imports processPicker
Imports JFWAPICTRLLib
Public Class Form1
	Dim jfw As New JFWApi
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		processPicker.runConsole("python", "-i")
		AddHandler processPicker.con.OutputDataReceived, AddressOf Process_OutputDataReceived
		AddHandler processPicker.con.ErrorDataReceived, AddressOf Process_errorDataReceived
	End Sub

	Private Sub Process_OutputDataReceived(sender As Object, e As DataReceivedEventArgs)
		If e.Data IsNot Nothing Then
			outputBox.AppendText(e.Data & Environment.NewLine)
			jfw.SayString(e.Data, 0)
		End If
	End Sub

	Private Sub Process_errorDataReceived(sender As Object, e As DataReceivedEventArgs)
		If e.Data IsNot Nothing Then
			outputBox.AppendText(e.Data & Environment.NewLine)
			My.Computer.Audio.Play("InconsistencyBuzzer.wav")
			jfw.SayString(e.Data, 0)
		End If
	End Sub

	Private Sub inputBox_KeyDown(sender As Object, e As KeyEventArgs) Handles inputBox.KeyDown
		If e.KeyCode = Keys.F6 Then
			outputBox.Focus()
		ElseIf e.KeyCode = Keys.Enter Then
			Dim lines() As String = inputBox.Lines
			Dim index As Integer = inputBox.GetLineFromCharIndex(inputBox.SelectionStart)
			Dim Input As String = inputBox.Lines(index)
			processPicker.con.StandardInput.WriteLine(Input)
			If Input <> "" Then
				outputBox.AppendText(Input & Environment.NewLine)
				If index <> lines.Length - 1 Then
					e.SuppressKeyPress = True
					inputBox.AppendText(Input & Environment.NewLine)
				End If
			Else
				e.SuppressKeyPress = True
			End If
		End If
	End Sub

	Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		processPicker.con.Kill()
		processPicker.con.Dispose()
	End Sub

	Private Sub saveItem_Click(sender As Object, e As EventArgs) Handles saveItem.Click
		Dim choice As New SaveFileDialog
		If choice.ShowDialog = DialogResult.OK Then System.IO.File.WriteAllText(choice.FileName, outputBox.Text)
	End Sub

	Private Sub exitItem_Click(sender As Object, e As EventArgs) Handles exitItem.Click
		Me.DestroyHandle()
	End Sub

	Private Sub copyInputItem_Click(sender As Object, e As EventArgs) Handles copyInputItem.Click

		If inputBox.SelectedText.Length = 0 Then
			inputBox.SelectAll()
			inputBox.Copy()
			inputBox.DeselectAll()
		Else
			inputBox.Copy()
		End If
	End Sub

	Private Sub switchConsole_Click(sender As Object, e As EventArgs) Handles switchConsole.Click
		switchConsoleDLG.ShowDialog()
	End Sub
End Class