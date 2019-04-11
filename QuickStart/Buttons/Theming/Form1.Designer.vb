Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Namespace Telerik.Examples.WinControls.Buttons.Theming
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label8 = New System.Windows.Forms.Label()
			Me.label9 = New System.Windows.Forms.Label()
			Me.label10 = New System.Windows.Forms.Label()
			Me.label11 = New System.Windows.Forms.Label()
			Me.radDropDownButton1 = New Telerik.WinControls.UI.RadDropDownButton()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRepeatButton1 = New Telerik.WinControls.UI.RadRepeatButton()
			Me.radToggleButton1 = New Telerik.WinControls.UI.RadToggleButton()
			Me.progressBar1 = New System.Windows.Forms.ProgressBar()
			Me.radSplitButton1 = New Telerik.WinControls.UI.RadSplitButton()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRepeatButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSplitButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radButton1
			' 
			Me.radButton1.BackColor = System.Drawing.SystemColors.ControlLightLight
			Me.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radButton1.ForeColor = System.Drawing.Color.Black
			Me.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton1.Location = New System.Drawing.Point(148, 38)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton1.RootElement.ToolTipText = Nothing
			Me.radButton1.Size = New System.Drawing.Size(177, 24)
			Me.radButton1.TabIndex = 3
			Me.radButton1.Text = "Click me"
			Me.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			' 
			' label4
			' 
			Me.label4.Location = New System.Drawing.Point(30, 231)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(84, 13)
			Me.label4.TabIndex = 47
			Me.label4.Text = "RadSplitButton"
			' 
			' label7
			' 
			Me.label7.AutoSize = True
			Me.label7.Location = New System.Drawing.Point(30, 38)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(58, 13)
			Me.label7.TabIndex = 50
			Me.label7.Text = "RadButton"
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radCheckBox1.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radCheckBox1.Location = New System.Drawing.Point(148, 77)
			Me.radCheckBox1.Name = "radCheckBox1"
			' 
			' 
			' 
			Me.radCheckBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCheckBox1.Size = New System.Drawing.Size(17, 17)
			Me.radCheckBox1.TabIndex = 51
			Me.radCheckBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCheckBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.radCheckBox1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.Location = New System.Drawing.Point(30, 77)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(76, 13)
			Me.label5.TabIndex = 52
			Me.label5.Text = "RadCheckBox"
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Location = New System.Drawing.Point(30, 113)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(109, 13)
			Me.label8.TabIndex = 53
			Me.label8.Text = "RadDropDownButton"
			' 
			' label9
			' 
			Me.label9.AutoSize = True
			Me.label9.Location = New System.Drawing.Point(30, 151)
			Me.label9.Name = "label9"
			Me.label9.Size = New System.Drawing.Size(86, 13)
			Me.label9.TabIndex = 54
			Me.label9.Text = "RadRadioButton"
'			Me.label9.Click += New System.EventHandler(Me.label9_Click);
			' 
			' label10
			' 
			Me.label10.AutoSize = True
			Me.label10.Location = New System.Drawing.Point(30, 189)
			Me.label10.Name = "label10"
			Me.label10.Size = New System.Drawing.Size(93, 13)
			Me.label10.TabIndex = 55
			Me.label10.Text = "RadRepeatButton"
			' 
			' label11
			' 
			Me.label11.AutoSize = True
			Me.label11.Location = New System.Drawing.Point(30, 274)
			Me.label11.Name = "label11"
			Me.label11.Size = New System.Drawing.Size(91, 13)
			Me.label11.TabIndex = 56
			Me.label11.Text = "RadToggleButton"
'			Me.label11.Click += New System.EventHandler(Me.label11_Click);
			' 
			' radDropDownButton1
			' 
			Me.radDropDownButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radDropDownButton1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButton1.ForeColor = System.Drawing.Color.Black
			Me.radDropDownButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radDropDownButton1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem3, Me.radMenuItem4})
			Me.radDropDownButton1.Location = New System.Drawing.Point(148, 113)
			Me.radDropDownButton1.Name = "radDropDownButton1"
			' 
			' 
			' 
			Me.radDropDownButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radDropDownButton1.Size = New System.Drawing.Size(177, 24)
			Me.radDropDownButton1.TabIndex = 57
			Me.radDropDownButton1.Text = "Click me"
			Me.radDropDownButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem3.Class = "RadMenuItem"
			Me.radMenuItem3.DescriptionText = ""
			Me.radMenuItem3.IsMainMenuItem = False
			Me.radMenuItem3.Text = "Item1"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem4.Class = "RadMenuItem"
			Me.radMenuItem4.DescriptionText = ""
			Me.radMenuItem4.IsMainMenuItem = False
			Me.radMenuItem4.Text = "Item2"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radRadioButton1.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radRadioButton1.Location = New System.Drawing.Point(148, 151)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioButton1.Size = New System.Drawing.Size(15, 15)
			Me.radRadioButton1.TabIndex = 58
			Me.radRadioButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radRadioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			' 
			' radRepeatButton1
			' 
			Me.radRepeatButton1.Delay = 500
			Me.radRepeatButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radRepeatButton1.ForeColor = System.Drawing.Color.Black
			Me.radRepeatButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radRepeatButton1.Interval = 33
			Me.radRepeatButton1.Location = New System.Drawing.Point(148, 189)
			Me.radRepeatButton1.Name = "radRepeatButton1"
			' 
			' 
			' 
			Me.radRepeatButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRepeatButton1.Size = New System.Drawing.Size(177, 24)
			Me.radRepeatButton1.TabIndex = 59
			Me.radRepeatButton1.Text = "Click and hold me"
			Me.radRepeatButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radRepeatButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.radRepeatButton1.ButtonClick += New System.EventHandler(Me.radRepeatButton1_ButtonClick);
			' 
			' radToggleButton1
			' 
			Me.radToggleButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radToggleButton1.ForeColor = System.Drawing.Color.Black
			Me.radToggleButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radToggleButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radToggleButton1.Location = New System.Drawing.Point(148, 274)
			Me.radToggleButton1.Name = "radToggleButton1"
			' 
			' 
			' 
			Me.radToggleButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radToggleButton1.Size = New System.Drawing.Size(177, 24)
			Me.radToggleButton1.TabIndex = 60
			Me.radToggleButton1.Text = "Press me"
			Me.radToggleButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radToggleButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.radToggleButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			' 
			' progressBar1
			' 
			Me.progressBar1.Location = New System.Drawing.Point(343, 190)
			Me.progressBar1.Name = "progressBar1"
			Me.progressBar1.Size = New System.Drawing.Size(175, 23)
			Me.progressBar1.TabIndex = 61
			' 
			' radSplitButton1
			' 
			Me.radSplitButton1.BackColor = System.Drawing.Color.White
			Me.radSplitButton1.DefaultItem = Nothing
			Me.radSplitButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.ImageAndText
			Me.radSplitButton1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radSplitButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radSplitButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radSplitButton1.ImageList = Me.imageList1
			Me.radSplitButton1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2})
			Me.radSplitButton1.Location = New System.Drawing.Point(148, 228)
			Me.radSplitButton1.Name = "radSplitButton1"
			' 
			' 
			' 
			Me.radSplitButton1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSplitButton1.RootElement.ToolTipText = Nothing
			Me.radSplitButton1.Size = New System.Drawing.Size(177, 29)
			Me.radSplitButton1.TabIndex = 62
			Me.radSplitButton1.Text = "Split Button"
			Me.radSplitButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Lime
			Me.imageList1.Images.SetKeyName(0, "2_redo.gif")
			Me.imageList1.Images.SetKeyName(1, "1_undo.gif")
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem1.Class = "RadMenuItem"
			Me.radMenuItem1.DescriptionText = ""
			Me.radMenuItem1.Image = (CType(resources.GetObject("radMenuItem1.Image"), System.Drawing.Image))
			Me.radMenuItem1.ImageIndex = 0
			Me.radMenuItem1.IsMainMenuItem = False
			Me.radMenuItem1.Text = "Rotate Clockwise"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem1.ToolTipText = Nothing
'			Me.radMenuItem1.Click += New System.EventHandler(Me.radMenuItem1_Click);
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.radMenuItem2.Class = "RadMenuItem"
			Me.radMenuItem2.DescriptionText = ""
			Me.radMenuItem2.Image = (CType(resources.GetObject("radMenuItem2.Image"), System.Drawing.Image))
			Me.radMenuItem2.ImageIndex = 1
			Me.radMenuItem2.IsMainMenuItem = False
			Me.radMenuItem2.Text = "Rotate Counter-clockwise"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.ToggleState = Telerik.WinControls.Enumerations.ToggleState.Off
			Me.radMenuItem2.ToolTipText = Nothing
'			Me.radMenuItem2.Click += New System.EventHandler(Me.radMenuItem2_Click);
			' 
			' radButton2
			' 
			Me.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton2.Image = My.Resources.telerikLogo1
			Me.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton2.Location = New System.Drawing.Point(343, 225)
			Me.radButton2.Name = "radButton2"
			' 
			' 
			' 
			Me.radButton2.RootElement.StretchHorizontally = False
			Me.radButton2.RootElement.StretchVertically = False
			Me.radButton2.Size = New System.Drawing.Size(35, 35)
			Me.radButton2.TabIndex = 63
			Me.radButton2.Text = "radButton2"
			Me.radButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			' 
			' Form1
			' 

			Me.Controls.Add(Me.radButton2)
			Me.Controls.Add(Me.radSplitButton1)
			Me.Controls.Add(Me.progressBar1)
			Me.Controls.Add(Me.radToggleButton1)
			Me.Controls.Add(Me.radRepeatButton1)
			Me.Controls.Add(Me.radRadioButton1)
			Me.Controls.Add(Me.radDropDownButton1)
			Me.Controls.Add(Me.label11)
			Me.Controls.Add(Me.label10)
			Me.Controls.Add(Me.label9)
			Me.Controls.Add(Me.label8)
			Me.Controls.Add(Me.label5)
			Me.Controls.Add(Me.radCheckBox1)
			Me.Controls.Add(Me.label7)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.radButton1)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(822, 739)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRepeatButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radToggleButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSplitButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private label4 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private label5 As System.Windows.Forms.Label
		Private label8 As System.Windows.Forms.Label
		Private WithEvents label9 As System.Windows.Forms.Label
		Private label10 As System.Windows.Forms.Label
		Private WithEvents label11 As System.Windows.Forms.Label
		Private radDropDownButton1 As Telerik.WinControls.UI.RadDropDownButton
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRepeatButton1 As Telerik.WinControls.UI.RadRepeatButton
		Private radToggleButton1 As Telerik.WinControls.UI.RadToggleButton
		Private progressBar1 As System.Windows.Forms.ProgressBar
		Private radSplitButton1 As Telerik.WinControls.UI.RadSplitButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private imageList1 As ImageList
	End Class
End Namespace