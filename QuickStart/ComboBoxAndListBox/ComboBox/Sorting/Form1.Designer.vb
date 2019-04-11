Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.Sorting
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
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
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
			Me.radBtnAdd = New Telerik.WinControls.UI.RadButton()
			Me.radBtnRemove = New Telerik.WinControls.UI.RadButton()
			Me.radTxtText = New Telerik.WinControls.UI.RadTextBox()
			Me.radTxtIndex = New Telerik.WinControls.UI.RadTextBox()
			Me.radLblText = New Telerik.WinControls.UI.RadLabel()
			Me.radLblItemIndex = New Telerik.WinControls.UI.RadLabel()
			Me.radComboSortMode = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radLblSortMode = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSettings.SuspendLayout()
			CType(Me.radBtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtIndex, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblItemIndex, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboSortMode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblSortMode, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(431, 328)
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
			Me.settingsPanel.Controls.Add(Me.radGroupSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 755)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupSettings, 0)
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
			' radComboDemo
			' 
			Me.radComboDemo.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radComboDemo.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboDemo.ForeColor = System.Drawing.Color.Black
'			Me.radComboDemo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.UpdateDropDownList);
'			Me.radComboDemo.SelectedValueChanged += New System.EventHandler(radComboDemo_SelectedValueChanged);
			Me.radComboDemo.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() { Me.dropDownElement1, Me.dropDownElement2, Me.dropDownElement3, Me.dropDownElement4, Me.dropDownElement5, Me.dropDownElement6, Me.dropDownElement7, Me.dropDownElement8, Me.dropDownElement9, Me.dropDownElement10})
			Me.radComboDemo.Location = New System.Drawing.Point(28, 40)
			Me.radComboDemo.Name = "radComboDemo"
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
			Me.radComboDemo.ThemeName = "ControlDefault"
			' 
			' radGroupSettings
			' 
			Me.radGroupSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupSettings.Controls.Add(Me.radBtnAdd)
			Me.radGroupSettings.Controls.Add(Me.radBtnRemove)
			Me.radGroupSettings.Controls.Add(Me.radTxtText)
			Me.radGroupSettings.Controls.Add(Me.radTxtIndex)
			Me.radGroupSettings.Controls.Add(Me.radLblText)
			Me.radGroupSettings.Controls.Add(Me.radLblItemIndex)
			Me.radGroupSettings.Controls.Add(Me.radComboSortMode)
			Me.radGroupSettings.Controls.Add(Me.radLblSortMode)
			Me.radGroupSettings.FooterImageIndex = -1
			Me.radGroupSettings.FooterImageKey = ""
			Me.radGroupSettings.FooterText = ""
			Me.radGroupSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.HeaderImageIndex = -1
			Me.radGroupSettings.HeaderImageKey = ""
			Me.radGroupSettings.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupSettings.HeaderText = " Settings "
			Me.radGroupSettings.Location = New System.Drawing.Point(10, 6)
			Me.radGroupSettings.Name = "radGroupSettings"
			Me.radGroupSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSettings.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupSettings.Size = New System.Drawing.Size(180, 228)
			Me.radGroupSettings.TabIndex = 0
			Me.radGroupSettings.Text = " Settings "
			' 
			' radBtnAdd
			' 
			Me.radBtnAdd.Location = New System.Drawing.Point(20, 191)
			Me.radBtnAdd.Name = "radBtnAdd"
			Me.radBtnAdd.Size = New System.Drawing.Size(61, 23)
			Me.radBtnAdd.TabIndex = 14
			Me.radBtnAdd.Text = "Add"
'			Me.radBtnAdd.Click += New System.EventHandler(Me.btnAdd_Click);
			' 
			' radBtnRemove
			' 
			Me.radBtnRemove.Location = New System.Drawing.Point(87, 191)
			Me.radBtnRemove.Name = "radBtnRemove"
			Me.radBtnRemove.Size = New System.Drawing.Size(64, 23)
			Me.radBtnRemove.TabIndex = 13
			Me.radBtnRemove.Text = "Remove"
'			Me.radBtnRemove.Click += New System.EventHandler(Me.btnRemove_Click);
			' 
			' radTxtText
			' 
			Me.radTxtText.ForeColor = System.Drawing.Color.Black
			Me.radTxtText.Location = New System.Drawing.Point(55, 156)
			Me.radTxtText.Name = "radTxtText"
			' 
			' 
			' 
			Me.radTxtText.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtText.Size = New System.Drawing.Size(94, 20)
			Me.radTxtText.TabIndex = 12
			Me.radTxtText.TabStop = False
'			Me.radTxtText.TextChanged += New System.EventHandler(Me.tBoxText_TextChanged);
			' 
			' radTxtIndex
			' 
			Me.radTxtIndex.ForeColor = System.Drawing.Color.Black
			Me.radTxtIndex.Location = New System.Drawing.Point(55, 120)
			Me.radTxtIndex.Name = "radTxtIndex"
			Me.radTxtIndex.ReadOnly = True
			' 
			' 
			' 
			Me.radTxtIndex.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtIndex.Size = New System.Drawing.Size(94, 20)
			Me.radTxtIndex.TabIndex = 11
			Me.radTxtIndex.TabStop = False
			' 
			' radLblText
			' 
			Me.radLblText.ForeColor = System.Drawing.Color.Black
			Me.radLblText.Location = New System.Drawing.Point(20, 159)
			Me.radLblText.Name = "radLblText"
			' 
			' 
			' 
			Me.radLblText.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblText.Size = New System.Drawing.Size(31, 16)
			Me.radLblText.TabIndex = 10
			Me.radLblText.Text = "Text:"
			' 
			' radLblItemIndex
			' 
			Me.radLblItemIndex.ForeColor = System.Drawing.Color.Black
			Me.radLblItemIndex.Location = New System.Drawing.Point(14, 123)
			Me.radLblItemIndex.Name = "radLblItemIndex"
			' 
			' 
			' 
			Me.radLblItemIndex.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblItemIndex.Size = New System.Drawing.Size(37, 16)
			Me.radLblItemIndex.TabIndex = 9
			Me.radLblItemIndex.Text = "Index:"
			' 
			' radComboBoxItem1
			' 
			Me.radComboBoxItem1.Text = "Ascending"
			' 
			' radComboBoxItem2
			' 
			Me.radComboBoxItem2.Text = "Descending"
			' 
			' radComboBoxItem3
			' 
			Me.radComboBoxItem3.Text = "None"
			' 
			' radComboSortMode
			' 
			Me.radComboSortMode.ForeColor = System.Drawing.Color.Black
			Me.radComboSortMode.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() { Me.radComboBoxItem1, Me.radComboBoxItem2, Me.radComboBoxItem3})
			Me.radComboSortMode.Location = New System.Drawing.Point(14, 52)
			Me.radComboSortMode.Name = "radComboSortMode"
			' 
			' 
			' 
			Me.radComboSortMode.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboSortMode.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboSortMode.Size = New System.Drawing.Size(135, 20)
			Me.radComboSortMode.TabIndex = 1
			Me.radComboSortMode.TabStop = False
'			Me.radComboSortMode.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.comboSortStyle_SelectedIndexChanged);
			' 
			' radLblSortMode
			' 
			Me.radLblSortMode.ForeColor = System.Drawing.Color.Black
			Me.radLblSortMode.Location = New System.Drawing.Point(12, 28)
			Me.radLblSortMode.Name = "radLblSortMode"
			' 
			' 
			' 
			Me.radLblSortMode.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblSortMode.Size = New System.Drawing.Size(61, 16)
			Me.radLblSortMode.TabIndex = 0
			Me.radLblSortMode.Text = "Sort mode:"
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1224, 757)
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
			CType(Me.radBtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnRemove, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtIndex, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblItemIndex, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboSortMode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblSortMode, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub


		#End Region

		Private WithEvents radComboDemo As Telerik.WinControls.UI.RadDropDownList
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
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private radGroupSettings As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radComboSortMode As Telerik.WinControls.UI.RadDropDownList
		Private radLblSortMode As Telerik.WinControls.UI.RadLabel
		Private WithEvents radBtnAdd As Telerik.WinControls.UI.RadButton
		Private WithEvents radBtnRemove As Telerik.WinControls.UI.RadButton
		Private WithEvents radTxtText As Telerik.WinControls.UI.RadTextBox
		Private radTxtIndex As Telerik.WinControls.UI.RadTextBox
		Private radLblText As Telerik.WinControls.UI.RadLabel
		Private radLblItemIndex As Telerik.WinControls.UI.RadLabel
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem3 As Telerik.WinControls.UI.RadListDataItem
	End Class
End Namespace