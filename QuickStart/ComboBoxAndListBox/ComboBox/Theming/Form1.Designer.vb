Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Editors.ComboBox.Theming
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
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radComboBox1 = New Telerik.WinControls.UI.RadComboBox()
			Me.dropDownElement1 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.dropDownElement2 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.dropDownElement3 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.dropDownElement4 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.dropDownElement5 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.dropDownElement6 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.dropDownElement7 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.dropDownElement8 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.dropDownElement9 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.dropDownElement10 = New Telerik.WinControls.UI.RadComboBoxItem()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.label2 = New System.Windows.Forms.Label()
			Me.nudFramerate = New System.Windows.Forms.NumericUpDown()
			Me.comboBox1 = New System.Windows.Forms.ComboBox()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.label1 = New System.Windows.Forms.Label()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			CType(Me.nudFramerate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "WizardPicture.bmp")
			Me.imageList1.Images.SetKeyName(1, "bulb_on.GIF")
			Me.imageList1.Images.SetKeyName(2, "CLSDFOLD.BMP")
			Me.imageList1.Images.SetKeyName(3, "test.bmp")
			Me.imageList1.Images.SetKeyName(4, "untitled.bmp")
			' 
			' radComboBox1
			' 
			Me.radComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
			Me.radComboBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
			Me.radComboBox1.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboBox1.ImageList = Me.imageList1
			Me.radComboBox1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.dropDownElement1, Me.dropDownElement2, Me.dropDownElement3, Me.dropDownElement4, Me.dropDownElement5, Me.dropDownElement6, Me.dropDownElement7, Me.dropDownElement8, Me.dropDownElement9, Me.dropDownElement10})
			Me.radComboBox1.Location = New System.Drawing.Point(51, 22)
			Me.radComboBox1.MaxLength = 32767
			Me.radComboBox1.Name = "radComboBox1"
			Me.radComboBox1.NullText = "Choose City..."
			' 
			' 
			' 
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.RootElement.ToolTipText = Nothing
			Me.radComboBox1.IntegralHeight = True
			Me.radComboBox1.MaxDropDownItems = 6
			Me.radComboBox1.Size = New System.Drawing.Size(188, 19)
			Me.radComboBox1.TabIndex = 0
			Me.radComboBox1.TabStop = False
			Me.radComboBox1.ThemeName = "ControlDefault"
			' 
			' dropDownElement1
			' 
			Me.dropDownElement1.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement1.DescriptionText = ""
			Me.dropDownElement1.Text = "Amsterdam"
			Me.dropDownElement1.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement1.ToolTipText = Nothing
			' 
			' dropDownElement2
			' 
			Me.dropDownElement2.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement2.DescriptionText = ""
			Me.dropDownElement2.Text = "Barcelona"
			Me.dropDownElement2.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement2.ToolTipText = Nothing
			' 
			' dropDownElement3
			' 
			Me.dropDownElement3.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement3.DescriptionText = ""
			Me.dropDownElement3.Text = "Bonn"
			Me.dropDownElement3.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement3.ToolTipText = Nothing
			' 
			' dropDownElement4
			' 
			Me.dropDownElement4.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement4.DescriptionText = ""
			Me.dropDownElement4.Text = "Brussels"
			Me.dropDownElement4.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement4.ToolTipText = Nothing
			' 
			' dropDownElement5
			' 
			Me.dropDownElement5.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement5.DescriptionText = ""
			Me.dropDownElement5.Text = "New York"
			Me.dropDownElement5.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement5.ToolTipText = Nothing
			' 
			' dropDownElement6
			' 
			Me.dropDownElement6.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement6.DescriptionText = ""
			Me.dropDownElement6.Text = "London"
			Me.dropDownElement6.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement6.ToolTipText = Nothing
			' 
			' dropDownElement7
			' 
			Me.dropDownElement7.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement7.DescriptionText = ""
			Me.dropDownElement7.Text = "Paris"
			Me.dropDownElement7.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement7.ToolTipText = Nothing
			' 
			' dropDownElement8
			' 
			Me.dropDownElement8.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement8.DescriptionText = ""
			Me.dropDownElement8.Text = "Sofia"
			Me.dropDownElement8.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement8.ToolTipText = Nothing
			' 
			' dropDownElement9
			' 
			Me.dropDownElement9.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement9.DescriptionText = ""
			Me.dropDownElement9.Text = "Prague"
			Me.dropDownElement9.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement9.ToolTipText = Nothing
			' 
			' dropDownElement10
			' 
			Me.dropDownElement10.BorderThickness = New System.Windows.Forms.Padding(1)
			Me.dropDownElement10.DescriptionText = ""
			Me.dropDownElement10.Text = "Hamburg"
			Me.dropDownElement10.TextSeparatorVisibility = Telerik.WinControls.ElementVisibility.Visible
			Me.dropDownElement10.ToolTipText = Nothing
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label1)
			Me.groupBox1.Controls.Add(Me.checkBox1)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.nudFramerate)
			Me.groupBox1.Controls.Add(Me.comboBox1)
			Me.groupBox1.Location = New System.Drawing.Point(371, 19)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(300, 83)
			Me.groupBox1.TabIndex = 3
			Me.groupBox1.TabStop = False
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Checked = True
			Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
			Me.checkBox1.Location = New System.Drawing.Point(19, 51)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(65, 17)
			Me.checkBox1.TabIndex = 3
			Me.checkBox1.Text = "Enabled"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged);
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(180, 52)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(41, 13)
			Me.label2.TabIndex = 13
			Me.label2.Text = "Frames"
			' 
			' nudFramerate
			' 
			Me.nudFramerate.Location = New System.Drawing.Point(227, 48)
			Me.nudFramerate.Maximum = New Decimal(New Integer() { 20, 0, 0, 0})
			Me.nudFramerate.Minimum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.nudFramerate.Name = "nudFramerate"
			Me.nudFramerate.Size = New System.Drawing.Size(47, 20)
			Me.nudFramerate.TabIndex = 12
			Me.nudFramerate.Value = New Decimal(New Integer() { 7, 0, 0, 0})
'			Me.nudFramerate.ValueChanged += New System.EventHandler(Me.nudMaxFramerate_ValueChanged);
			' 
			' comboBox1
			' 
			Me.comboBox1.FormattingEnabled = True
			Me.comboBox1.Location = New System.Drawing.Point(127, 19)
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(147, 21)
			Me.comboBox1.TabIndex = 3
'			Me.comboBox1.SelectedIndexChanged += New System.EventHandler(Me.comboBox1_SelectedIndexChanged);
			' 
			' radPanel1
			' 
			Me.radPanel1.BackgroundImage = (CType(resources.GetObject("radPanel1.BackgroundImage"), System.Drawing.Image))
			Me.radPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
			Me.radPanel1.Controls.Add(Me.radComboBox1)
			Me.radPanel1.Location = New System.Drawing.Point(16, 19)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(300, 350)
			Me.radPanel1.TabIndex = 4
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(16, 22)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(110, 13)
			Me.label1.TabIndex = 14
			Me.label1.Text = "DropDown Animation:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Controls.Add(Me.groupBox1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(941, 732)
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			CType(Me.nudFramerate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList
		Private radComboBox1 As Telerik.WinControls.UI.RadComboBox
		Private dropDownElement1 As Telerik.WinControls.UI.RadComboBoxItem
		Private dropDownElement2 As Telerik.WinControls.UI.RadComboBoxItem
		Private dropDownElement3 As Telerik.WinControls.UI.RadComboBoxItem
		Private dropDownElement4 As Telerik.WinControls.UI.RadComboBoxItem
		Private dropDownElement5 As Telerik.WinControls.UI.RadComboBoxItem
		Private dropDownElement6 As Telerik.WinControls.UI.RadComboBoxItem
		Private dropDownElement7 As Telerik.WinControls.UI.RadComboBoxItem
		Private dropDownElement8 As Telerik.WinControls.UI.RadComboBoxItem
		Private dropDownElement9 As Telerik.WinControls.UI.RadComboBoxItem
		Private dropDownElement10 As Telerik.WinControls.UI.RadComboBoxItem
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
		Private label2 As System.Windows.Forms.Label
		Private WithEvents nudFramerate As System.Windows.Forms.NumericUpDown
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private label1 As System.Windows.Forms.Label
	End Class
End Namespace