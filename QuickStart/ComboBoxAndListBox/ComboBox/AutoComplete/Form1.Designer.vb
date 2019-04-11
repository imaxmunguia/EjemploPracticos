Imports Microsoft.VisualBasic
Imports System
Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.AutoComplete
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
			Me.radGroupBoxSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radBtnAdd = New Telerik.WinControls.UI.RadButton()
			Me.radBtnRemove = New Telerik.WinControls.UI.RadButton()
			Me.radTxtText = New Telerik.WinControls.UI.RadTextBox()
			Me.radTxtIndex = New Telerik.WinControls.UI.RadTextBox()
			Me.radLblText = New Telerik.WinControls.UI.RadLabel()
			Me.radLblItemIndex = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckCaseSens = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLblAutoComplete = New Telerik.WinControls.UI.RadLabel()
			Me.radComboAutoCompl = New Telerik.WinControls.UI.RadDropDownList()
			Me.RadListDataItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboDemo = New Telerik.WinControls.UI.RadDropDownList()
			Me.RadListDataItem5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem6 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem7 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem8 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem9 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem10 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem11 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem12 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem13 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem14 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem15 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem16 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem17 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem18 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem19 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem20 = New Telerik.WinControls.UI.RadListDataItem()
			Me.RadListDataItem21 = New Telerik.WinControls.UI.RadListDataItem()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupBoxSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxSettings.SuspendLayout()
			CType(Me.radBtnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtIndex, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblText, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblItemIndex, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckCaseSens, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblAutoComplete, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboAutoCompl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radComboDemo)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(431, 318)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(362, 100)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBoxSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxSettings, 0)
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
			' radGroupBoxSettings
			' 
			Me.radGroupBoxSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBoxSettings.Controls.Add(Me.radBtnAdd)
			Me.radGroupBoxSettings.Controls.Add(Me.radBtnRemove)
			Me.radGroupBoxSettings.Controls.Add(Me.radTxtText)
			Me.radGroupBoxSettings.Controls.Add(Me.radTxtIndex)
			Me.radGroupBoxSettings.Controls.Add(Me.radLblText)
			Me.radGroupBoxSettings.Controls.Add(Me.radLblItemIndex)
			Me.radGroupBoxSettings.Controls.Add(Me.radCheckCaseSens)
			Me.radGroupBoxSettings.Controls.Add(Me.radLblAutoComplete)
			Me.radGroupBoxSettings.Controls.Add(Me.radComboAutoCompl)
			Me.radGroupBoxSettings.FooterImageIndex = -1
			Me.radGroupBoxSettings.FooterImageKey = ""
			Me.radGroupBoxSettings.FooterText = ""
			Me.radGroupBoxSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupBoxSettings.HeaderImageIndex = -1
			Me.radGroupBoxSettings.HeaderImageKey = ""
			Me.radGroupBoxSettings.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupBoxSettings.HeaderText = " Settings "
			Me.radGroupBoxSettings.Location = New System.Drawing.Point(10, 6)
			Me.radGroupBoxSettings.Name = "radGroupBoxSettings"
			Me.radGroupBoxSettings.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBoxSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBoxSettings.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBoxSettings.Size = New System.Drawing.Size(180, 198)
			Me.radGroupBoxSettings.TabIndex = 0
			Me.radGroupBoxSettings.Text = " Settings "
			' 
			' radBtnAdd
			' 
			Me.radBtnAdd.Location = New System.Drawing.Point(7, 165)
			Me.radBtnAdd.Name = "radBtnAdd"
			Me.radBtnAdd.Size = New System.Drawing.Size(66, 23)
			Me.radBtnAdd.TabIndex = 8
			Me.radBtnAdd.Text = "Add"
'			Me.radBtnAdd.Click += New System.EventHandler(Me.btnAdd_Click);
			' 
			' radBtnRemove
			' 
			Me.radBtnRemove.Location = New System.Drawing.Point(86, 165)
			Me.radBtnRemove.Name = "radBtnRemove"
			Me.radBtnRemove.Size = New System.Drawing.Size(67, 23)
			Me.radBtnRemove.TabIndex = 7
			Me.radBtnRemove.Text = "Remove"
'			Me.radBtnRemove.Click += New System.EventHandler(Me.btnRemove_Click);
			' 
			' radTxtText
			' 
			Me.radTxtText.ForeColor = System.Drawing.Color.Black
			Me.radTxtText.Location = New System.Drawing.Point(43, 138)
			Me.radTxtText.Name = "radTxtText"
			' 
			' 
			' 
			Me.radTxtText.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtText.Size = New System.Drawing.Size(110, 20)
			Me.radTxtText.TabIndex = 6
			Me.radTxtText.TabStop = False
'			Me.radTxtText.TextChanged += New System.EventHandler(Me.radTxtText_TextChanged);
			' 
			' radTxtIndex
			' 
			Me.radTxtIndex.ForeColor = System.Drawing.Color.Black
			Me.radTxtIndex.Location = New System.Drawing.Point(43, 111)
			Me.radTxtIndex.Name = "radTxtIndex"
			Me.radTxtIndex.ReadOnly = True
			' 
			' 
			' 
			Me.radTxtIndex.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtIndex.Size = New System.Drawing.Size(109, 20)
			Me.radTxtIndex.TabIndex = 5
			Me.radTxtIndex.TabStop = False
			' 
			' radLblText
			' 
			Me.radLblText.ForeColor = System.Drawing.Color.Black
			Me.radLblText.Location = New System.Drawing.Point(13, 141)
			Me.radLblText.Name = "radLblText"
			' 
			' 
			' 
			Me.radLblText.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblText.Size = New System.Drawing.Size(31, 16)
			Me.radLblText.TabIndex = 4
			Me.radLblText.Text = "Text:"
			' 
			' radLblItemIndex
			' 
			Me.radLblItemIndex.ForeColor = System.Drawing.Color.Black
			Me.radLblItemIndex.Location = New System.Drawing.Point(7, 114)
			Me.radLblItemIndex.Name = "radLblItemIndex"
			' 
			' 
			' 
			Me.radLblItemIndex.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblItemIndex.Size = New System.Drawing.Size(37, 16)
			Me.radLblItemIndex.TabIndex = 3
			Me.radLblItemIndex.Text = "Index:"
			' 
			' radCheckCaseSens
			' 
			Me.radCheckCaseSens.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckCaseSens.Location = New System.Drawing.Point(8, 76)
			Me.radCheckCaseSens.Name = "radCheckCaseSens"
			' 
			' 
			' 
			Me.radCheckCaseSens.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckCaseSens.Size = New System.Drawing.Size(105, 29)
			Me.radCheckCaseSens.TabIndex = 2
			Me.radCheckCaseSens.Text = "Case sensitive " & Constants.vbCrLf & "AutoComplete"
'			Me.radCheckCaseSens.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.chBoxCaseSensitive_CheckedChanged);
			' 
			' radLblAutoComplete
			' 
			Me.radLblAutoComplete.ForeColor = System.Drawing.Color.Black
			Me.radLblAutoComplete.Location = New System.Drawing.Point(16, 28)
			Me.radLblAutoComplete.Name = "radLblAutoComplete"
			' 
			' 
			' 
			Me.radLblAutoComplete.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblAutoComplete.Size = New System.Drawing.Size(113, 16)
			Me.radLblAutoComplete.TabIndex = 1
			Me.radLblAutoComplete.Text = "AutoComplete Mode:"
			' 
			' radComboAutoCompl
			' 
			Me.radComboAutoCompl.ForeColor = System.Drawing.Color.Black
			Me.radComboAutoCompl.FormatString = "{0}"
			Me.radComboAutoCompl.Items.AddRange(New RadListDataItem() { Me.RadListDataItem1, Me.RadListDataItem2, Me.RadListDataItem3, Me.RadListDataItem4})
			Me.radComboAutoCompl.Location = New System.Drawing.Point(13, 49)
			Me.radComboAutoCompl.Name = "radComboAutoCompl"
			' 
			' 
			' 
			Me.radComboAutoCompl.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboAutoCompl.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboAutoCompl.Size = New System.Drawing.Size(139, 20)
			Me.radComboAutoCompl.TabIndex = 0
			Me.radComboAutoCompl.TabStop = False
			Me.radComboAutoCompl.Text = "Select mode:"
'			Me.radComboAutoCompl.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.OnAutoCompleteMode_SelectedIndexChanged);
			' 
			' RadListDataItem1
			' 

			Me.RadListDataItem1.Text = "None"
			' 
			' RadListDataItem2
			' 

			Me.RadListDataItem2.Text = "Suggest"
			' 
			' RadListDataItem3
			' 

			Me.RadListDataItem3.Text = "Append"
			' 
			' RadListDataItem4
			' 

			Me.RadListDataItem4.Text = "SuggestAppend"
			' 
			' radComboDemo
			' 
			Me.radComboDemo.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radComboDemo.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.FormatString = "{0}"
'			Me.radComboDemo.SelectedIndexChanged += Me.UpdateDropDown;
'			Me.radComboDemo.SelectedValueChanged += Me.UpdateDropDown;
			Me.radComboDemo.Items.AddRange(New RadListDataItem() { Me.RadListDataItem5, Me.RadListDataItem6, Me.RadListDataItem7, Me.RadListDataItem8, Me.RadListDataItem9, Me.RadListDataItem10, Me.RadListDataItem11, Me.RadListDataItem12, Me.RadListDataItem13, Me.RadListDataItem14, Me.RadListDataItem15, Me.RadListDataItem16, Me.RadListDataItem17, Me.RadListDataItem18, Me.RadListDataItem19, Me.RadListDataItem20, Me.RadListDataItem21})
			Me.radComboDemo.Location = New System.Drawing.Point(28, 40)
			Me.radComboDemo.Name = "radComboDemo"
			' 
			' 
			' 
			Me.radComboDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radComboDemo.Size = New System.Drawing.Size(306, 20)
			Me.radComboDemo.TabIndex = 0
			Me.radComboDemo.TabStop = False
			Me.radComboDemo.Text = "Choose country:"
			' 
			' RadListDataItem5
			' 
			Me.RadListDataItem5.Image = My.Resources.BUL

			Me.RadListDataItem5.Text = "Bulgaria"
			Me.RadListDataItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem6
			' 
			Me.RadListDataItem6.Image = My.Resources.DE

			Me.RadListDataItem6.Text = "Germany"
			Me.RadListDataItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem7
			' 
			Me.RadListDataItem7.Image = My.Resources.FR

			Me.RadListDataItem7.Text = "France"
			Me.RadListDataItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem8
			' 
			Me.RadListDataItem8.Image = My.Resources._IN

			Me.RadListDataItem8.Text = "India"
			Me.RadListDataItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem9
			' 
			Me.RadListDataItem9.Image = My.Resources.US

			Me.RadListDataItem9.Text = "USA"
			Me.RadListDataItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem10
			' 
			Me.RadListDataItem10.Image = My.Resources.CN

			Me.RadListDataItem10.Text = "China"
			Me.RadListDataItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem11
			' 
			Me.RadListDataItem11.Image = My.Resources.JP

			Me.RadListDataItem11.Text = "Japan"
			Me.RadListDataItem11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem12
			' 
			Me.RadListDataItem12.Image = My.Resources.NL

			Me.RadListDataItem12.Text = "Netherlands"
			Me.RadListDataItem12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem13
			' 
			Me.RadListDataItem13.Image = My.Resources.BE

			Me.RadListDataItem13.Text = "Belgium"
			Me.RadListDataItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem14
			' 
			Me.RadListDataItem14.Image = My.Resources.SP

			Me.RadListDataItem14.Text = "Spain"
			Me.RadListDataItem14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem15
			' 
			Me.RadListDataItem15.Image = My.Resources.PT

			Me.RadListDataItem15.Text = "Portugal"
			Me.RadListDataItem15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem16
			' 
			Me.RadListDataItem16.Image = My.Resources.CH

			Me.RadListDataItem16.Text = "Switzerland"
			Me.RadListDataItem16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem17
			' 
			Me.RadListDataItem17.Image = My.Resources.SE

			Me.RadListDataItem17.Text = "Sweden"
			Me.RadListDataItem17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem18
			' 
			Me.RadListDataItem18.Image = My.Resources.EG

			Me.RadListDataItem18.Text = "Egypt"
			Me.RadListDataItem18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem19
			' 
			Me.RadListDataItem19.Image = My.Resources.CA

			Me.RadListDataItem19.Text = "Canada"
			Me.RadListDataItem19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem20
			' 
			Me.RadListDataItem20.Image = My.Resources.RU

			Me.RadListDataItem20.Text = "Russia"
			Me.RadListDataItem20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' RadListDataItem21
			' 
			Me.RadListDataItem21.Image = My.Resources.BR

			Me.RadListDataItem21.Text = "Brazil"
			Me.RadListDataItem21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1224, 737)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGroupBoxSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxSettings.ResumeLayout(False)
			Me.radGroupBoxSettings.PerformLayout()
			CType(Me.radBtnAdd, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnRemove, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtIndex, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblText, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblItemIndex, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckCaseSens, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblAutoComplete, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboAutoCompl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		'private Telerik.WinControls.UI.RadListDataItem dropDownElement1;
		'private Telerik.WinControls.UI.RadListDataItem dropDownElement2;
		'private Telerik.WinControls.UI.RadListDataItem dropDownElement3;
		'private Telerik.WinControls.UI.RadListDataItem dropDownElement4;
		'private Telerik.WinControls.UI.RadListDataItem dropDownElement5;
		'private Telerik.WinControls.UI.RadListDataItem dropDownElement6;
		'private Telerik.WinControls.UI.RadListDataItem dropDownElement7;
		'private Telerik.WinControls.UI.RadListDataItem dropDownElement8;
		'private Telerik.WinControls.UI.RadListDataItem dropDownElement9;
		'private Telerik.WinControls.UI.RadListDataItem dropDownElement10;
		Private imageList1 As System.Windows.Forms.ImageList
		Private radGroupBoxSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblAutoComplete As Telerik.WinControls.UI.RadLabel
		Private WithEvents radComboAutoCompl As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radBtnAdd As Telerik.WinControls.UI.RadButton
		Private WithEvents radBtnRemove As Telerik.WinControls.UI.RadButton
		Private WithEvents radTxtText As Telerik.WinControls.UI.RadTextBox
		Private radTxtIndex As Telerik.WinControls.UI.RadTextBox
		Private radLblText As Telerik.WinControls.UI.RadLabel
		Private radLblItemIndex As Telerik.WinControls.UI.RadLabel
		Private WithEvents radCheckCaseSens As Telerik.WinControls.UI.RadCheckBox
		Private RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem
		Private WithEvents radComboDemo As Telerik.WinControls.UI.RadDropDownList
		Private RadListDataItem5 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem6 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem7 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem8 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem9 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem10 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem11 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem12 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem13 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem14 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem15 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem16 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem17 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem18 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem19 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem20 As Telerik.WinControls.UI.RadListDataItem
		Private RadListDataItem21 As Telerik.WinControls.UI.RadListDataItem
	End Class
End Namespace
