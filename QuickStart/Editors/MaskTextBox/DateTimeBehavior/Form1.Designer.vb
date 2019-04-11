Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Editors.MaskTextBox.DateTimeBehavior
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radMaskedEditBox1 = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.radMaskedEditBox2 = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.label3 = New System.Windows.Forms.Label()
			Me.radMaskedEditBox3 = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.label4 = New System.Windows.Forms.Label()
			Me.radMaskedEditBox4 = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.radMaskedEditBox5 = New Telerik.WinControls.UI.RadMaskedEditBox()
			CType(Me.radMaskedEditBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radMaskedEditBox1
			' 
			Me.radMaskedEditBox1.AcceptsReturn = False
			Me.radMaskedEditBox1.AcceptsTab = False
			Me.radMaskedEditBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox1.Culture = Nothing
			Me.radMaskedEditBox1.HideSelection = True
			Me.radMaskedEditBox1.Location = New System.Drawing.Point(34, 51)
			Me.radMaskedEditBox1.Mask = "u"
			Me.radMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.DateTime
			Me.radMaskedEditBox1.MaxLength = 32767
			Me.radMaskedEditBox1.Modified = False
			Me.radMaskedEditBox1.Multiline = False
			Me.radMaskedEditBox1.Name = "radMaskedEditBox1"
			Me.radMaskedEditBox1.NullText = ""
			Me.radMaskedEditBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
			Me.radMaskedEditBox1.PasswordChar = ControlChars.NullChar
			Me.radMaskedEditBox1.ReadOnly = False
			' 
			' 
			' 
			Me.radMaskedEditBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMaskedEditBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
			Me.radMaskedEditBox1.SelectedText = ""
			Me.radMaskedEditBox1.SelectionLength = 0
			Me.radMaskedEditBox1.SelectionStart = 0
			Me.radMaskedEditBox1.ShortcutsEnabled = True
			Me.radMaskedEditBox1.Size = New System.Drawing.Size(223, 20)
			Me.radMaskedEditBox1.TabIndex = 0
			Me.radMaskedEditBox1.Text = "2007-11-01 00:00:00Z"
			Me.radMaskedEditBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox1.Value = New System.DateTime(2007, 11, 1, 0, 0, 0, 0)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(31, 29)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(100, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Universal DateTime"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(31, 198)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(58, 13)
			Me.label2.TabIndex = 3
			Me.label2.Text = "Short Time"
			' 
			' radMaskedEditBox2
			' 
			Me.radMaskedEditBox2.AcceptsReturn = False
			Me.radMaskedEditBox2.AcceptsTab = False
			Me.radMaskedEditBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox2.Culture = Nothing
			Me.radMaskedEditBox2.HideSelection = True
			Me.radMaskedEditBox2.Location = New System.Drawing.Point(34, 220)
			Me.radMaskedEditBox2.Mask = "t"
			Me.radMaskedEditBox2.MaskType = Telerik.WinControls.UI.MaskType.DateTime
			Me.radMaskedEditBox2.MaxLength = 32767
			Me.radMaskedEditBox2.Modified = False
			Me.radMaskedEditBox2.Multiline = False
			Me.radMaskedEditBox2.Name = "radMaskedEditBox2"
			Me.radMaskedEditBox2.NullText = ""
			Me.radMaskedEditBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
			Me.radMaskedEditBox2.PasswordChar = ControlChars.NullChar
			Me.radMaskedEditBox2.ReadOnly = False
			' 
			' 
			' 
			Me.radMaskedEditBox2.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMaskedEditBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
			Me.radMaskedEditBox2.SelectedText = ""
			Me.radMaskedEditBox2.SelectionLength = 0
			Me.radMaskedEditBox2.SelectionStart = 0
			Me.radMaskedEditBox2.ShortcutsEnabled = True
			Me.radMaskedEditBox2.Size = New System.Drawing.Size(223, 20)
			Me.radMaskedEditBox2.TabIndex = 2
			Me.radMaskedEditBox2.Text = "12:00 AM"
			Me.radMaskedEditBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox2.Value = New System.DateTime(2007, 11, 1, 0, 0, 0, 0)
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(31, 85)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(72, 13)
			Me.label3.TabIndex = 5
			Me.label3.Text = "Full DateTime"
			' 
			' radMaskedEditBox3
			' 
			Me.radMaskedEditBox3.AcceptsReturn = False
			Me.radMaskedEditBox3.AcceptsTab = False
			Me.radMaskedEditBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox3.Culture = Nothing
			Me.radMaskedEditBox3.HideSelection = True
			Me.radMaskedEditBox3.Location = New System.Drawing.Point(34, 107)
			Me.radMaskedEditBox3.Mask = "F"
			Me.radMaskedEditBox3.MaskType = Telerik.WinControls.UI.MaskType.DateTime
			Me.radMaskedEditBox3.MaxLength = 32767
			Me.radMaskedEditBox3.Modified = False
			Me.radMaskedEditBox3.Multiline = False
			Me.radMaskedEditBox3.Name = "radMaskedEditBox3"
			Me.radMaskedEditBox3.NullText = ""
			Me.radMaskedEditBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
			Me.radMaskedEditBox3.PasswordChar = ControlChars.NullChar
			Me.radMaskedEditBox3.ReadOnly = False
			' 
			' 
			' 
			Me.radMaskedEditBox3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMaskedEditBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
			Me.radMaskedEditBox3.SelectedText = ""
			Me.radMaskedEditBox3.SelectionLength = 0
			Me.radMaskedEditBox3.SelectionStart = 0
			Me.radMaskedEditBox3.ShortcutsEnabled = True
			Me.radMaskedEditBox3.Size = New System.Drawing.Size(223, 20)
			Me.radMaskedEditBox3.TabIndex = 4
			Me.radMaskedEditBox3.Text = "Thursday, November 01, 2007 12:00:00 AM"
			Me.radMaskedEditBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox3.Value = New System.DateTime(2007, 11, 1, 0, 0, 0, 0)
            ' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(31, 140)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(49, 13)
			Me.label4.TabIndex = 7
			Me.label4.Text = "Full Time"
			' 
			' radMaskedEditBox4
			' 
			Me.radMaskedEditBox4.AcceptsReturn = False
			Me.radMaskedEditBox4.AcceptsTab = False
			Me.radMaskedEditBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox4.Culture = Nothing
			Me.radMaskedEditBox4.HideSelection = True
			Me.radMaskedEditBox4.Location = New System.Drawing.Point(34, 162)
			Me.radMaskedEditBox4.Mask = "T"
			Me.radMaskedEditBox4.MaskType = Telerik.WinControls.UI.MaskType.DateTime
			Me.radMaskedEditBox4.MaxLength = 32767
			Me.radMaskedEditBox4.Modified = False
			Me.radMaskedEditBox4.Multiline = False
			Me.radMaskedEditBox4.Name = "radMaskedEditBox4"
			Me.radMaskedEditBox4.NullText = ""
			Me.radMaskedEditBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
			Me.radMaskedEditBox4.PasswordChar = ControlChars.NullChar
			Me.radMaskedEditBox4.ReadOnly = False
			' 
			' 
			' 
			Me.radMaskedEditBox4.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMaskedEditBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
			Me.radMaskedEditBox4.SelectedText = ""
			Me.radMaskedEditBox4.SelectionLength = 0
			Me.radMaskedEditBox4.SelectionStart = 0
			Me.radMaskedEditBox4.ShortcutsEnabled = True
			Me.radMaskedEditBox4.Size = New System.Drawing.Size(223, 20)
			Me.radMaskedEditBox4.TabIndex = 6
			Me.radMaskedEditBox4.Text = "12:00:00 AM"
			Me.radMaskedEditBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox4.Value = New System.DateTime(2007, 11, 1, 0, 0, 0, 0)
            ' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(31, 258)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(131, 13)
			Me.label5.TabIndex = 9
			Me.label5.Text = "Sortable DateTime pattern"
			' 
			' radMaskedEditBox5
			' 
			Me.radMaskedEditBox5.AcceptsReturn = False
			Me.radMaskedEditBox5.AcceptsTab = False
			Me.radMaskedEditBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox5.Culture = Nothing
			Me.radMaskedEditBox5.HideSelection = True
			Me.radMaskedEditBox5.Location = New System.Drawing.Point(34, 280)
			Me.radMaskedEditBox5.Mask = "s"
			Me.radMaskedEditBox5.MaskType = Telerik.WinControls.UI.MaskType.DateTime
			Me.radMaskedEditBox5.MaxLength = 32767
			Me.radMaskedEditBox5.Modified = False
			Me.radMaskedEditBox5.Multiline = False
			Me.radMaskedEditBox5.Name = "radMaskedEditBox5"
			Me.radMaskedEditBox5.NullText = ""
			Me.radMaskedEditBox5.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
			Me.radMaskedEditBox5.PasswordChar = ControlChars.NullChar
			Me.radMaskedEditBox5.ReadOnly = False
			' 
			' 
			' 
			Me.radMaskedEditBox5.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMaskedEditBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
			Me.radMaskedEditBox5.SelectedText = ""
			Me.radMaskedEditBox5.SelectionLength = 0
			Me.radMaskedEditBox5.SelectionStart = 0
			Me.radMaskedEditBox5.ShortcutsEnabled = True
			Me.radMaskedEditBox5.Size = New System.Drawing.Size(223, 20)
			Me.radMaskedEditBox5.TabIndex = 8
			Me.radMaskedEditBox5.Text = "2007-11-01T00:00:00"
			Me.radMaskedEditBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox5.Value = New System.DateTime(2007, 11, 1, 0, 0, 0, 0)
            ' 
			' Form1
			' 
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.radMaskedEditBox5)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.radMaskedEditBox4)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.radMaskedEditBox3)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.radMaskedEditBox2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.radMaskedEditBox1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(934, 822)
			CType(Me.radMaskedEditBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditBox5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radMaskedEditBox1 As Telerik.WinControls.UI.RadMaskedEditBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private radMaskedEditBox2 As Telerik.WinControls.UI.RadMaskedEditBox
		Private label3 As System.Windows.Forms.Label
		Private radMaskedEditBox3 As Telerik.WinControls.UI.RadMaskedEditBox
		Private label4 As System.Windows.Forms.Label
		Private radMaskedEditBox4 As Telerik.WinControls.UI.RadMaskedEditBox
		Private label5 As System.Windows.Forms.Label
		Private radMaskedEditBox5 As Telerik.WinControls.UI.RadMaskedEditBox
	End Class
End Namespace