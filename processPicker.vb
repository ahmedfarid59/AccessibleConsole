Public Class processPicker
    Public Shared con As New Process
    Public Shared Sub runConsole(file As String, arguments As String)
        If con.StartInfo.FileName <> "" Then con.Kill()
        con = New Process
        con.StartInfo = New ProcessStartInfo
        con.StartInfo.FileName = file
        con.StartInfo.Arguments = arguments
        con.StartInfo.CreateNoWindow = True
        con.StartInfo.RedirectStandardInput = True
        con.StartInfo.RedirectStandardOutput = True
        con.StartInfo.RedirectStandardError = True
        con.StartInfo.UseShellExecute = False
        con.StartInfo.WorkingDirectory = "C:"
        con.Start()
        con.BeginOutputReadLine()
        con.BeginErrorReadLine()
        con.StandardInput.AutoFlush = True
    End Sub
End Class