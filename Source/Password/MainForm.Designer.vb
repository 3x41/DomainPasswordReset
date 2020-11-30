'
' Created by SharpDevelop.
' User: Alex
' Date: 25/11/2020
' Time: 22:39
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Partial Class MainForm
	Inherits System.Windows.Forms.Form
	
	''' <summary>
	''' Designer variable used to keep track of non-visual components.
	''' </summary>
	Private components As System.ComponentModel.IContainer
	
	''' <summary>
	''' Disposes resources used by the form.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		If disposing Then
			If components IsNot Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(disposing)
	End Sub
	
	''' <summary>
	''' This method is required for Windows Forms designer support.
	''' Do not change the method contents inside the source code editor. The Forms designer might
	''' not be able to load this method if it was changed manually.
	''' </summary>
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.button1 = New System.Windows.Forms.Button()
		Me.comboBox1 = New System.Windows.Forms.ComboBox()
		Me.label1 = New System.Windows.Forms.Label()
		Me.textBox1 = New System.Windows.Forms.TextBox()
		Me.checkBox1 = New System.Windows.Forms.CheckBox()
		Me.label2 = New System.Windows.Forms.Label()
		Me.label3 = New System.Windows.Forms.Label()
		Me.linkLabel1 = New System.Windows.Forms.LinkLabel()
		Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
		Me.button2 = New System.Windows.Forms.Button()
		Me.label4 = New System.Windows.Forms.Label()
		Me.button3 = New System.Windows.Forms.Button()
		Me.SuspendLayout
		'
		'button1
		'
		Me.button1.Image = CType(resources.GetObject("button1.Image"),System.Drawing.Image)
		Me.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.button1.Location = New System.Drawing.Point(19, 193)
		Me.button1.Name = "button1"
		Me.button1.Size = New System.Drawing.Size(234, 76)
		Me.button1.TabIndex = 0
		Me.button1.Text = "Reset Password"
		Me.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
		Me.button1.UseVisualStyleBackColor = true
		AddHandler Me.button1.Click, AddressOf Me.Button1Click
		'
		'comboBox1
		'
		Me.comboBox1.AllowDrop = true
		Me.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
		Me.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
		Me.comboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.comboBox1.FormattingEnabled = true
		Me.comboBox1.Location = New System.Drawing.Point(18, 47)
		Me.comboBox1.Name = "comboBox1"
		Me.comboBox1.Size = New System.Drawing.Size(235, 28)
		Me.comboBox1.TabIndex = 1
		'
		'label1
		'
		Me.label1.Location = New System.Drawing.Point(18, 93)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(100, 23)
		Me.label1.TabIndex = 2
		Me.label1.Text = "New Password"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'textBox1
		'
		Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
		Me.textBox1.Location = New System.Drawing.Point(18, 119)
		Me.textBox1.Name = "textBox1"
		Me.textBox1.Size = New System.Drawing.Size(235, 26)
		Me.textBox1.TabIndex = 3
		Me.textBox1.Text = "password1"
		'
		'checkBox1
		'
		Me.checkBox1.Checked = true
		Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
		Me.checkBox1.Location = New System.Drawing.Point(18, 151)
		Me.checkBox1.Name = "checkBox1"
		Me.checkBox1.Size = New System.Drawing.Size(104, 24)
		Me.checkBox1.TabIndex = 4
		Me.checkBox1.Text = "Unlock Account"
		Me.checkBox1.UseVisualStyleBackColor = true
		'
		'label2
		'
		Me.label2.Location = New System.Drawing.Point(18, 19)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(100, 23)
		Me.label2.TabIndex = 5
		Me.label2.Text = "Select User"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
		'
		'label3
		'
		Me.label3.Location = New System.Drawing.Point(277, 9)
		Me.label3.Name = "label3"
		Me.label3.Size = New System.Drawing.Size(100, 23)
		Me.label3.TabIndex = 6
		Me.label3.Text = "Output"
		'
		'linkLabel1
		'
		Me.linkLabel1.Location = New System.Drawing.Point(171, 78)
		Me.linkLabel1.Name = "linkLabel1"
		Me.linkLabel1.Size = New System.Drawing.Size(81, 23)
		Me.linkLabel1.TabIndex = 9
		Me.linkLabel1.TabStop = true
		Me.linkLabel1.Text = "User Info"
		Me.linkLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight
		AddHandler Me.linkLabel1.LinkClicked, AddressOf Me.LinkLabel1LinkClicked
		'
		'richTextBox1
		'
		Me.richTextBox1.BackColor = System.Drawing.Color.LightGray
		Me.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.richTextBox1.Location = New System.Drawing.Point(277, 28)
		Me.richTextBox1.Name = "richTextBox1"
		Me.richTextBox1.Size = New System.Drawing.Size(443, 241)
		Me.richTextBox1.TabIndex = 10
		Me.richTextBox1.Text = ""
		'
		'button2
		'
		Me.button2.Location = New System.Drawing.Point(223, 281)
		Me.button2.Name = "button2"
		Me.button2.Size = New System.Drawing.Size(29, 23)
		Me.button2.TabIndex = 11
		Me.button2.Text = ">"
		Me.button2.UseVisualStyleBackColor = true
		AddHandler Me.button2.Click, AddressOf Me.Button2Click
		'
		'label4
		'
		Me.label4.Location = New System.Drawing.Point(449, 281)
		Me.label4.Name = "label4"
		Me.label4.Size = New System.Drawing.Size(271, 23)
		Me.label4.TabIndex = 12
		Me.label4.Text = "Reset Password Tool by Alex Garwood (2020)"
		Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'button3
		'
		Me.button3.Location = New System.Drawing.Point(172, 151)
		Me.button3.Name = "button3"
		Me.button3.Size = New System.Drawing.Size(81, 23)
		Me.button3.TabIndex = 13
		Me.button3.Text = "Random"
		Me.button3.UseVisualStyleBackColor = true
		AddHandler Me.button3.Click, AddressOf Me.Button3Click
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(733, 316)
		Me.Controls.Add(Me.button3)
		Me.Controls.Add(Me.label4)
		Me.Controls.Add(Me.button2)
		Me.Controls.Add(Me.richTextBox1)
		Me.Controls.Add(Me.linkLabel1)
		Me.Controls.Add(Me.label3)
		Me.Controls.Add(Me.label2)
		Me.Controls.Add(Me.checkBox1)
		Me.Controls.Add(Me.textBox1)
		Me.Controls.Add(Me.label1)
		Me.Controls.Add(Me.comboBox1)
		Me.Controls.Add(Me.button1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
		Me.MaximizeBox = false
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Reset Password Tool"
		Me.TopMost = true
		AddHandler Load, AddressOf Me.MainFormLoad
		Me.ResumeLayout(false)
		Me.PerformLayout
	End Sub
	Private button3 As System.Windows.Forms.Button
	Private label4 As System.Windows.Forms.Label
	Public button2 As System.Windows.Forms.Button
	Private richTextBox1 As System.Windows.Forms.RichTextBox
	Private linkLabel1 As System.Windows.Forms.LinkLabel
	Private label3 As System.Windows.Forms.Label
	Private label2 As System.Windows.Forms.Label
	Private checkBox1 As System.Windows.Forms.CheckBox
	Private textBox1 As System.Windows.Forms.TextBox
	Private label1 As System.Windows.Forms.Label
	Private comboBox1 As System.Windows.Forms.ComboBox
	Private button1 As System.Windows.Forms.Button
End Class
