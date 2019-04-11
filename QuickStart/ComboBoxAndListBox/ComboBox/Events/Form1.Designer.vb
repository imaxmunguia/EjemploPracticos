Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Events
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
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.dropDownElement1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement6 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement7 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement8 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement9 = New Telerik.WinControls.UI.RadListDataItem()
			Me.dropDownElement10 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radGroupSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radComboSort = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radCheckCase = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLblSort = New Telerik.WinControls.UI.RadLabel()
			Me.radLblDropDownStyle = New Telerik.WinControls.UI.RadLabel()
			Me.radComboDropDownStyle = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radGroupEvents = New Telerik.WinControls.UI.RadGroupBox()
			Me.radTxtEvents = New Telerik.WinControls.UI.RadTextBox()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radComboSort, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckCase, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblSort, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblDropDownStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDropDownStyle, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupEvents.SuspendLayout()
			CType(Me.radTxtEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(431, 194)
			Me.radPanelDemoHolder.MaximumSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.MinimumSize = New System.Drawing.Size(362, 100)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.RootElement.MaxSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.RootElement.MinSize = New System.Drawing.Size(362, 100)
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupEvents)
			Me.settingsPanel.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 486)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupEvents, 0)
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
			' radComboDemo
			' 
			Me.radComboDemo.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radComboDemo.BackColor = System.Drawing.Color.Transparent
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radComboDemo.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.Items.AddRange(New RadListDataItem() { Me.dropDownElement1, Me.dropDownElement2, Me.dropDownElement3, Me.dropDownElement4, Me.dropDownElement5, Me.dropDownElement6, Me.dropDownElement7, Me.dropDownElement8, Me.dropDownElement9, Me.dropDownElement10})
			Me.radComboDemo.Location = New System.Drawing.Point(28, 40)
			Me.radComboDemo.NullText = "Choose City..."
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.RootElement.ToolTipText = Nothing
			Me.radComboDemo.Size = New System.Drawing.Size(306, 20)
			Me.radComboDemo.TabIndex = 0
			Me.radComboDemo.TabStop = False
			Me.radComboDemo.Text = ""
			Me.radComboDemo.ThemeName = "ControlDefault"
			' 
			' dropDownElement1
			' 

			Me.dropDownElement1.Text = "Amsterdam"
			' 
			' dropDownElement2
			' 

			Me.dropDownElement2.Text = "Barcelona"
			' 
			' dropDownElement3
			' 

			Me.dropDownElement3.Text = "Bonn"
			' 
			' dropDownElement4
			' 

			Me.dropDownElement4.Text = "Brussels"
			' 
			' dropDownElement5
			' 

			Me.dropDownElement5.Text = "New York"
			' 
			' dropDownElement6
			' 

			Me.dropDownElement6.Text = "London"
			' 
			' dropDownElement7
			' 

			Me.dropDownElement7.Text = "Paris"
			' 
			' dropDownElement8
			' 

			Me.dropDownElement8.Text = "Sofia"
			' 
			' dropDownElement9
			' 
			 Me.dropDownElement9.Text = "Prague"
		   ' 
			' dropDownElement10
			' 
			Me.dropDownElement10.Text = "Hamburg"
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.radComboSort)
			Me.radGroupSettings.Controls.Add(Me.radCheckCase)
			Me.radGroupSettings.Controls.Add(Me.radLblSort)
			Me.radGroupSettings.Controls.Add(Me.radLblDropDownStyle)
			Me.radGroupSettings.Controls.Add(Me.radComboDropDownStyle)
			Me.radGroupSettings.FooterImageIndex = -1
			Me.radGroupSettings.FooterImageKey = ""
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.HeaderImageIndex = -1
			Me.radGroupSettings.HeaderImageKey = ""
			Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupSettings.HeaderText = "Settings"
			Me.radGroupSettings.Location = New System.Drawing.Point(10, 6)
			Me.radGroupSettings.Name = "radGroupSettings"
			Me.radGroupSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.Size = New System.Drawing.Size(163, 160)
			Me.radGroupSettings.TabIndex = 0
			Me.radGroupSettings.Text = "Settings"
			' 
			' radComboSort
			' 
			Me.radComboSort.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboSort.ForeColor = System.Drawing.Color.Black
			Me.radComboSort.Items.AddRange(New RadListDataItem() { Me.radComboBoxItem3, Me.radComboBoxItem4, Me.radComboBoxItem5})
			Me.radComboSort.Location = New System.Drawing.Point(18, 96)
			Me.radComboSort.Name = "radComboSort"
			' 
			' 
			' 
			Me.radComboSort.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboSort.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboSort.Size = New System.Drawing.Size(122, 20)
			Me.radComboSort.TabIndex = 1
			Me.radComboSort.Text = ""
			' 
			' radComboBoxItem3
			' 

			Me.radComboBoxItem3.Text = "Ascending"
			' 
			' radComboBoxItem4
			' 

			Me.radComboBoxItem4.Text = "Descending"
			' 
			' radComboBoxItem5
			' 

			Me.radComboBoxItem5.Text = "None"
			' 
			' radCheckCase
			' 
			Me.radCheckCase.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckCase.Location = New System.Drawing.Point(18, 125)
			Me.radCheckCase.Name = "radCheckCase"
			' 
			' 
			' 
			Me.radCheckCase.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckCase.Size = New System.Drawing.Size(96, 17)
			Me.radCheckCase.TabIndex = 4
			Me.radCheckCase.Text = "Case sensitive"
'			Me.radCheckCase.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.chBoxCaseSensitive_CheckedChanged);
			' 
			' radLblSort
			' 
			Me.radLblSort.ForeColor = System.Drawing.Color.Black
			Me.radLblSort.Location = New System.Drawing.Point(18, 72)
			Me.radLblSort.Name = "radLblSort"
			' 
			' 
			' 
			Me.radLblSort.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblSort.Size = New System.Drawing.Size(74, 14)
			Me.radLblSort.TabIndex = 3
			Me.radLblSort.Text = "Sort direction:"
			' 
			' radLblDropDownStyle
			' 
			Me.radLblDropDownStyle.ForeColor = System.Drawing.Color.Black
			Me.radLblDropDownStyle.Location = New System.Drawing.Point(18, 19)
			Me.radLblDropDownStyle.Name = "radLblDropDownStyle"
			' 
			' 
			' 
			Me.radLblDropDownStyle.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblDropDownStyle.Size = New System.Drawing.Size(89, 14)
			Me.radLblDropDownStyle.TabIndex = 2
			Me.radLblDropDownStyle.Text = "Drop-down style:"
			' 
			' radComboDropDownStyle
			' 
			Me.radComboDropDownStyle.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDropDownStyle.ForeColor = System.Drawing.Color.Black
			Me.radComboDropDownStyle.Items.AddRange(New RadListDataItem() { Me.radComboBoxItem1, Me.radComboBoxItem2})
			Me.radComboDropDownStyle.Location = New System.Drawing.Point(18, 43)
			Me.radComboDropDownStyle.Name = "radComboDropDownStyle"
			' 
			' 
			' 
			Me.radComboDropDownStyle.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDropDownStyle.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDropDownStyle.Size = New System.Drawing.Size(122, 20)
			Me.radComboDropDownStyle.TabIndex = 0
			Me.radComboDropDownStyle.Text = ""
			' 
			' radComboBoxItem1
			' 

			Me.radComboBoxItem1.Text = "DropDown"
			' 
			' radComboBoxItem2
			' 

			Me.radComboBoxItem2.Text = "DropDownList"
			' 
			' radGroupEvents
			' 
			Me.radGroupEvents.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupEvents.Controls.Add(Me.radTxtEvents)
			Me.radGroupEvents.FooterImageIndex = -1
			Me.radGroupEvents.FooterImageKey = ""
			Me.radGroupEvents.FooterText = ""
			Me.radGroupEvents.ForeColor = System.Drawing.Color.Black
			Me.radGroupEvents.HeaderImageIndex = -1
			Me.radGroupEvents.HeaderImageKey = ""
			Me.radGroupEvents.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupEvents.HeaderText = " Events "
			Me.radGroupEvents.Location = New System.Drawing.Point(10, 172)
			Me.radGroupEvents.Name = "radGroupEvents"
			Me.radGroupEvents.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupEvents.Size = New System.Drawing.Size(163, 322)
			Me.radGroupEvents.TabIndex = 1
			Me.radGroupEvents.Text = " Events "
			' 
			' radTxtEvents
			' 
			Me.radTxtEvents.ForeColor = System.Drawing.Color.Black
			Me.radTxtEvents.Location = New System.Drawing.Point(22, 26)
			Me.radTxtEvents.Multiline = True
			Me.radTxtEvents.Name = "radTxtEvents"
			' 
			' 
			' 
			Me.radTxtEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtEvents.RootElement.StretchVertically = True
			Me.radTxtEvents.Size = New System.Drawing.Size(136, 283)
			Me.radTxtEvents.TabIndex = 0
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1224, 488)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSettings.ResumeLayout(False)
			Me.radGroupSettings.PerformLayout()
			CType(Me.radComboSort, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckCase, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblSort, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblDropDownStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDropDownStyle, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupEvents.ResumeLayout(False)
			Me.radGroupEvents.PerformLayout()
			CType(Me.radTxtEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private dropDownElement1 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement2 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement3 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement4 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement5 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement6 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement7 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement8 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement9 As Telerik.WinControls.UI.RadListDataItem
		Private dropDownElement10 As Telerik.WinControls.UI.RadListDataItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private radGroupEvents As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radCheckCase As Telerik.WinControls.UI.RadCheckBox
		Private radLblSort As Telerik.WinControls.UI.RadLabel
		Private radLblDropDownStyle As Telerik.WinControls.UI.RadLabel
		Private radComboSort As Telerik.WinControls.UI.RadDropDownList
		Private radComboDropDownStyle As Telerik.WinControls.UI.RadDropDownList
		Private radTxtEvents As Telerik.WinControls.UI.RadTextBox
		Private radComboBoxItem3 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem4 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem5 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
	End Class
End Namespace