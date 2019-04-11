Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Editors.MaskTextBox.StandardBehavior
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
			Me.maskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.maskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
			Me.radMaskedEditBox2 = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.maskedTextBox3 = New System.Windows.Forms.MaskedTextBox()
			Me.radMaskedEditBox3 = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.label8 = New System.Windows.Forms.Label()
			Me.maskedTextBox4 = New System.Windows.Forms.MaskedTextBox()
			Me.radMaskedEditBox4 = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.label10 = New System.Windows.Forms.Label()
			Me.maskedTextBox5 = New System.Windows.Forms.MaskedTextBox()
			Me.radMaskedEditBox5 = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.label12 = New System.Windows.Forms.Label()
			Me.maskedTextBox6 = New System.Windows.Forms.MaskedTextBox()
			Me.radMaskedEditBox6 = New Telerik.WinControls.UI.RadMaskedEditBox()
			Me.label3 = New System.Windows.Forms.Label()
			CType(Me.radMaskedEditBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMaskedEditBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radMaskedEditBox1
			' 
			Me.radMaskedEditBox1.AcceptsReturn = False
			Me.radMaskedEditBox1.AcceptsTab = False
			Me.radMaskedEditBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox1.Culture = Nothing
			Me.radMaskedEditBox1.HideSelection = True
			Me.radMaskedEditBox1.Location = New System.Drawing.Point(117, 43)
			Me.radMaskedEditBox1.Mask = "00000"
			Me.radMaskedEditBox1.MaskType = Telerik.WinControls.UI.MaskType.Standard
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
			Me.radMaskedEditBox1.Size = New System.Drawing.Size(114, 20)
			Me.radMaskedEditBox1.TabIndex = 0
			Me.radMaskedEditBox1.Text = "_____"
			Me.radMaskedEditBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox1.Value = ""
            ' 
			' maskedTextBox1
			' 
			Me.maskedTextBox1.Location = New System.Drawing.Point(262, 44)
			Me.maskedTextBox1.Mask = "00000"
			Me.maskedTextBox1.Name = "maskedTextBox1"
			Me.maskedTextBox1.Size = New System.Drawing.Size(114, 20)
			Me.maskedTextBox1.TabIndex = 1
			Me.maskedTextBox1.ValidatingType = GetType(Integer)
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(21, 46)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(85, 13)
			Me.label1.TabIndex = 2
			Me.label1.Text = "Numeric(5 digits)"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(259, 17)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(103, 13)
			Me.label2.TabIndex = 3
			Me.label2.Text = "MS MaskedTextBox"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New System.Drawing.Point(21, 87)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(78, 13)
			Me.label4.TabIndex = 6
			Me.label4.Text = "Phone Number"
			' 
			' maskedTextBox2
			' 
			Me.maskedTextBox2.Location = New System.Drawing.Point(262, 84)
			Me.maskedTextBox2.Mask = "(999) 000-0000"
			Me.maskedTextBox2.Name = "maskedTextBox2"
			Me.maskedTextBox2.Size = New System.Drawing.Size(114, 20)
			Me.maskedTextBox2.TabIndex = 5
			' 
			' radMaskedEditBox2
			' 
			Me.radMaskedEditBox2.AcceptsReturn = False
			Me.radMaskedEditBox2.AcceptsTab = False
			Me.radMaskedEditBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox2.Culture = Nothing
			Me.radMaskedEditBox2.HideSelection = True
			Me.radMaskedEditBox2.Location = New System.Drawing.Point(117, 83)
			Me.radMaskedEditBox2.Mask = "(999) 000-0000"
			Me.radMaskedEditBox2.MaskType = Telerik.WinControls.UI.MaskType.Standard
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
			Me.radMaskedEditBox2.Size = New System.Drawing.Size(114, 20)
			Me.radMaskedEditBox2.TabIndex = 4
			Me.radMaskedEditBox2.Text = "(___) ___-____"
			Me.radMaskedEditBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox2.Value = ""
            ' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(28, 126)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(58, 13)
			Me.label6.TabIndex = 10
			Me.label6.Text = "Short Date"
			' 
			' maskedTextBox3
			' 
			Me.maskedTextBox3.Location = New System.Drawing.Point(262, 123)
			Me.maskedTextBox3.Mask = "00/00/0000"
			Me.maskedTextBox3.Name = "maskedTextBox3"
			Me.maskedTextBox3.Size = New System.Drawing.Size(114, 20)
			Me.maskedTextBox3.TabIndex = 9
			Me.maskedTextBox3.ValidatingType = GetType(System.DateTime)
			' 
			' radMaskedEditBox3
			' 
			Me.radMaskedEditBox3.AcceptsReturn = False
			Me.radMaskedEditBox3.AcceptsTab = False
			Me.radMaskedEditBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox3.Culture = Nothing
			Me.radMaskedEditBox3.HideSelection = True
			Me.radMaskedEditBox3.Location = New System.Drawing.Point(117, 122)
			Me.radMaskedEditBox3.Mask = "00/00/0000"
			Me.radMaskedEditBox3.MaskType = Telerik.WinControls.UI.MaskType.Standard
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
			Me.radMaskedEditBox3.Size = New System.Drawing.Size(114, 20)
			Me.radMaskedEditBox3.TabIndex = 8
			Me.radMaskedEditBox3.Text = "__/__/____"
			Me.radMaskedEditBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox3.Value = ""
            ' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(3, 165)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(113, 13)
			Me.label8.TabIndex = 14
			Me.label8.Text = "Social security number"
			' 
			' maskedTextBox4
			' 
			Me.maskedTextBox4.Location = New System.Drawing.Point(262, 162)
			Me.maskedTextBox4.Mask = "000-00-0000"
			Me.maskedTextBox4.Name = "maskedTextBox4"
			Me.maskedTextBox4.Size = New System.Drawing.Size(114, 20)
			Me.maskedTextBox4.TabIndex = 13
			' 
			' radMaskedEditBox4
			' 
			Me.radMaskedEditBox4.AcceptsReturn = False
			Me.radMaskedEditBox4.AcceptsTab = False
			Me.radMaskedEditBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox4.Culture = Nothing
			Me.radMaskedEditBox4.HideSelection = True
			Me.radMaskedEditBox4.Location = New System.Drawing.Point(117, 161)
			Me.radMaskedEditBox4.Mask = "000-00-0000"
			Me.radMaskedEditBox4.MaskType = Telerik.WinControls.UI.MaskType.Standard
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
			Me.radMaskedEditBox4.Size = New System.Drawing.Size(114, 20)
			Me.radMaskedEditBox4.TabIndex = 12
			Me.radMaskedEditBox4.Text = "___-__-____"
			Me.radMaskedEditBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox4.Value = ""
            ' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(21, 207)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(51, 13)
			Me.label10.TabIndex = 18
			Me.label10.Text = "Time U.S"
			' 
			' maskedTextBox5
			' 
			Me.maskedTextBox5.Location = New System.Drawing.Point(262, 205)
			Me.maskedTextBox5.Mask = "90:00"
			Me.maskedTextBox5.Name = "maskedTextBox5"
			Me.maskedTextBox5.Size = New System.Drawing.Size(114, 20)
			Me.maskedTextBox5.TabIndex = 17
			Me.maskedTextBox5.ValidatingType = GetType(System.DateTime)
			' 
			' radMaskedEditBox5
			' 
			Me.radMaskedEditBox5.AcceptsReturn = False
			Me.radMaskedEditBox5.AcceptsTab = False
			Me.radMaskedEditBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox5.Culture = Nothing
			Me.radMaskedEditBox5.HideSelection = True
			Me.radMaskedEditBox5.Location = New System.Drawing.Point(117, 204)
			Me.radMaskedEditBox5.Mask = "90:00"
			Me.radMaskedEditBox5.MaskType = Telerik.WinControls.UI.MaskType.Standard
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
			Me.radMaskedEditBox5.Size = New System.Drawing.Size(114, 20)
			Me.radMaskedEditBox5.TabIndex = 16
			Me.radMaskedEditBox5.Text = "__:__"
			Me.radMaskedEditBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox5.Value = ""
            ' 
			' label12
			' 
			Me.label12.AutoSize = True
			Me.label12.Location = New System.Drawing.Point(28, 245)
			Me.label12.Name = "label12"
			Me.label12.Size = New System.Drawing.Size(50, 13)
			Me.label12.TabIndex = 22
            Me.label12.Text = "Zip Code"
			' 
			' maskedTextBox6
			' 
			Me.maskedTextBox6.Location = New System.Drawing.Point(262, 245)
			Me.maskedTextBox6.Mask = "00000-9999"
			Me.maskedTextBox6.Name = "maskedTextBox6"
			Me.maskedTextBox6.Size = New System.Drawing.Size(114, 20)
			Me.maskedTextBox6.TabIndex = 21
			' 
			' radMaskedEditBox6
			' 
			Me.radMaskedEditBox6.AcceptsReturn = False
			Me.radMaskedEditBox6.AcceptsTab = False
			Me.radMaskedEditBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
			Me.radMaskedEditBox6.Culture = Nothing
			Me.radMaskedEditBox6.HideSelection = True
			Me.radMaskedEditBox6.Location = New System.Drawing.Point(117, 244)
			Me.radMaskedEditBox6.Mask = "00000-9999"
			Me.radMaskedEditBox6.MaskType = Telerik.WinControls.UI.MaskType.Standard
			Me.radMaskedEditBox6.MaxLength = 32767
			Me.radMaskedEditBox6.Modified = False
			Me.radMaskedEditBox6.Multiline = False
			Me.radMaskedEditBox6.Name = "radMaskedEditBox6"
			Me.radMaskedEditBox6.NullText = ""
			Me.radMaskedEditBox6.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
			Me.radMaskedEditBox6.PasswordChar = ControlChars.NullChar
			Me.radMaskedEditBox6.ReadOnly = False
			' 
			' 
			' 
			Me.radMaskedEditBox6.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMaskedEditBox6.ScrollBars = System.Windows.Forms.ScrollBars.None
			Me.radMaskedEditBox6.SelectedText = ""
			Me.radMaskedEditBox6.SelectionLength = 0
			Me.radMaskedEditBox6.SelectionStart = 0
			Me.radMaskedEditBox6.ShortcutsEnabled = True
			Me.radMaskedEditBox6.Size = New System.Drawing.Size(114, 20)
			Me.radMaskedEditBox6.TabIndex = 20
			Me.radMaskedEditBox6.Text = "_____-____"
			Me.radMaskedEditBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
			Me.radMaskedEditBox6.Value = ""
            ' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(114, 17)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(101, 13)
			Me.label3.TabIndex = 23
			Me.label3.Text = "RadMaskedEditBox"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.label12)
			Me.Controls.Add(Me.maskedTextBox6)
			Me.Controls.Add(Me.radMaskedEditBox6)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.maskedTextBox5)
			Me.Controls.Add(Me.radMaskedEditBox5)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.maskedTextBox4)
			Me.Controls.Add(Me.radMaskedEditBox4)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.maskedTextBox3)
			Me.Controls.Add(Me.radMaskedEditBox3)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.maskedTextBox2)
			Me.Controls.Add(Me.radMaskedEditBox2)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.maskedTextBox1)
			Me.Controls.Add(Me.radMaskedEditBox1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(934, 822)
			CType(Me.radMaskedEditBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMaskedEditBox6, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radMaskedEditBox1 As Telerik.WinControls.UI.RadMaskedEditBox
		Private maskedTextBox1 As System.Windows.Forms.MaskedTextBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private maskedTextBox2 As System.Windows.Forms.MaskedTextBox
		Private radMaskedEditBox2 As Telerik.WinControls.UI.RadMaskedEditBox
		Private label6 As System.Windows.Forms.Label
		Private maskedTextBox3 As System.Windows.Forms.MaskedTextBox
		Private radMaskedEditBox3 As Telerik.WinControls.UI.RadMaskedEditBox
		Private label8 As System.Windows.Forms.Label
		Private maskedTextBox4 As System.Windows.Forms.MaskedTextBox
		Private radMaskedEditBox4 As Telerik.WinControls.UI.RadMaskedEditBox
		Private label10 As System.Windows.Forms.Label
		Private maskedTextBox5 As System.Windows.Forms.MaskedTextBox
		Private radMaskedEditBox5 As Telerik.WinControls.UI.RadMaskedEditBox
		Private label12 As System.Windows.Forms.Label
		Private maskedTextBox6 As System.Windows.Forms.MaskedTextBox
		Private radMaskedEditBox6 As Telerik.WinControls.UI.RadMaskedEditBox
		Private label3 As System.Windows.Forms.Label
	End Class
End Namespace