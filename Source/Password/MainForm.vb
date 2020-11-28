' Created by SharpDevelop.
' User: Alex
' Date: 25/11/2020
' Time: 22:39

Imports System.IO

Public Partial Class MainForm
	
Dim tempPath As String = System.IO.Path.GetTempPath()	
Dim ProgramPath As String = My.Application.Info.DirectoryPath.ToString

	Public Sub New()
		Me.InitializeComponent()
	End Sub
	
	Sub PopulateUsers()
		Try
			comboBox1.Items.Clear
		    For Each line As String In File.ReadLines(ProgramPath + "\users.txt")
			    comboBox1.Items.Add(line)
		    Next line
	    If comboBox1.Items.Count > 1 Then
	    	comboBox1.SelectedIndex = 0
	    End If
	    Catch ex As Exception
			MessageBox.Show("An Error Occurred"+vbCrLf+ex.ToString,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
		End Try
	End Sub
	
	Sub CreateBatchFile(GenCommand As String)
		Try
			richTextBox1.Text = ""
			Dim Filewriter As StreamWriter = New StreamWriter(tempPath + "PW_Temp.bat", False)
            Filewriter.WriteLine(GenCommand)
            Filewriter.Close()
		Catch ex As Exception
			MessageBox.Show("An Error Occurred"+vbCrLf+ex.ToString,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
		End Try
	End Sub
	
	Sub ProcessFile()
		try
			Dim proc As New Process
			proc.StartInfo.FileName = tempPath + "PW_Temp.bat"   
			proc.StartInfo.UseShellExecute = False
			proc.StartInfo.RedirectStandardOutput = True
			Proc.StartInfo.CreateNoWindow = true
			proc.Start()
			proc.WaitForExit()
			Dim output() As String = proc.StandardOutput.ReadToEnd.Split(CChar(vbLf))
		    For Each ln As String In output
		        RichTextBox1.AppendText(ln & vbNewLine)
		    Next
			MessageBox.Show("Done, Please check output for any errors.","Compleate",MessageBoxButtons.OK,MessageBoxIcon.Information)
	    Catch ex As Exception
			MessageBox.Show("An Error Occurred"+vbCrLf+ex.ToString,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
		End Try
	End Sub
	
	Sub MainFormLoad(sender As Object, e As EventArgs)
		Me.Size = New Size(277, 345)
		Me.CenterToScreen()
		PopulateUsers()
		comboBox1.Focus()
	End Sub
	
	Sub Button1Click(sender As Object, e As EventArgs)
		try
			Dim SelectedUsername As String = comboBox1.SelectedItem.ToString
			Dim NewPassword As String = textBox1.Text
			Dim FullCommand As String = ""
			
			If checkBox1.Checked = True Then
				FullCommand = "net user " + SelectedUsername + " " + NewPassword + " /active:yes /domain"
			Else
				FullCommand = "net user " + SelectedUsername + " " + NewPassword + " /domain"
			End If
			
			CreateBatchFile(FullCommand)
			ProcessFile()
		Catch ex As Exception
			'MessageBox.Show("An Error Occurred"+vbCrLf+ex.ToString,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
			MessageBox.Show("An Error Occurred"+vbCrLf+"Username is not in the list.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
		End Try
	End Sub
	
	Sub Button2Click(sender As Object, e As EventArgs)
		If button2.Text = ">" Then
			button2.Text = "<"
			Me.Size = New Size(740, 345)
			Exit Sub
		End If
		
		If button2.Text = "<" Then
			button2.Text = ">"
			Me.Size = New Size(277, 345)
			Exit Sub
		End If
	End Sub
	
	Sub LinkLabel1LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
		try
			Dim SelectedUsername As String = comboBox1.SelectedItem.ToString
			Dim NewPassword As String = textBox1.Text
			Dim FullCommand As String = ""
			
			FullCommand = "net user " + SelectedUsername + " /domain"
			CreateBatchFile(FullCommand)
			ProcessFile()
		
		Catch ex As Exception
			MessageBox.Show("An Error Occurred"+vbCrLf+ex.ToString,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error)
		End Try
	End Sub
	
	Sub Button3Click(sender As Object, e As EventArgs)
		dim validchars as string = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"
		dim sb As String = ""
		dim rand as new Random()
		for i as Integer = 1 to 10
		    dim idx as Integer = rand.Next(0, validchars.Length)
		    Dim randomChar As Char = validchars(idx)
		    sb = sb + randomChar.ToString
	    
		next i
		
		Dim randomString = sb.ToString()
		textBox1.Text = randomString
	End Sub
	
End Class
