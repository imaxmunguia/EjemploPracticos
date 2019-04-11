Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports Telerik.WinControls.UI
Namespace Telerik.Examples.WinControls.Docking.VisualStudioIDE
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
			Dim radTreeNode1 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode2 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode3 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode4 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode5 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode6 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode7 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode8 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode9 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode10 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode11 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode12 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode13 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode14 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode15 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode16 As New Telerik.WinControls.UI.RadTreeNode()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim gridViewTextBoxColumn1 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn2 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn3 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn4 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridSortField1 As New Telerik.WinControls.UI.GridSortField()
			Dim gridViewImageColumn1 As New Telerik.WinControls.UI.GridViewImageColumn()
			Dim gridViewTextBoxColumn5 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn6 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn7 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn8 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn9 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridViewTextBoxColumn10 As New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Dim gridSortField2 As New Telerik.WinControls.UI.GridSortField()
			Dim themeSource1 As New Telerik.WinControls.ThemeSource()
			Dim themeSource2 As New Telerik.WinControls.ThemeSource()
			Dim themeSource3 As New Telerik.WinControls.ThemeSource()
			Dim themeSource4 As New Telerik.WinControls.ThemeSource()
			Dim themeSource5 As New Telerik.WinControls.ThemeSource()
			Dim themeSource6 As New Telerik.WinControls.ThemeSource()
			Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
			Me.toolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radPanel3 = New Telerik.WinControls.UI.RadPanel()
			Me.richTextBoxOutput = New System.Windows.Forms.RichTextBox()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.radListBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem6 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem7 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem8 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem9 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem10 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem11 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem12 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem13 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem14 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem15 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem16 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem17 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem18 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem19 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem20 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem21 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem22 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem23 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radListBoxItem24 = New Telerik.WinControls.UI.RadListDataItem()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow3 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.richTextBoxForm = New System.Windows.Forms.RichTextBox()
			Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.richTextBoxDesigner = New System.Windows.Forms.RichTextBox()
			Me.toolTabStrip4 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.toolTabStrip5 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow4 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radGridViewTasks = New Telerik.WinControls.UI.RadGridView()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radComboBox1 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
			Me.toolWindow5 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radGridViewErrors = New Telerik.WinControls.UI.RadGridView()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDock1.SuspendLayout()
			Me.toolWindow3.SuspendLayout()
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel3.SuspendLayout()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip3.SuspendLayout()
			Me.toolWindow1.SuspendLayout()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentContainer1.SuspendLayout()
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip1.SuspendLayout()
			Me.documentWindow3.SuspendLayout()
			Me.documentWindow1.SuspendLayout()
			CType(Me.toolTabStrip4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip4.SuspendLayout()
			Me.toolWindow2.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTabStrip5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip5.SuspendLayout()
			Me.toolWindow4.SuspendLayout()
			CType(Me.radGridViewTasks, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridViewTasks.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel2.SuspendLayout()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolWindow5.SuspendLayout()
			CType(Me.radGridViewErrors, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridViewErrors.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.toolWindow1
			Me.radDock1.AutoHideAnimation = Telerik.WinControls.UI.Docking.AutoHideAnimateMode.AnimateHide
			Me.radDock1.CausesValidation = False
			Me.radDock1.Controls.Add(Me.radSplitContainer1)
			Me.radDock1.Controls.Add(Me.toolTabStrip5)
			Me.radDock1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radDock1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
			Me.radDock1.EnableFloatingWindowTheming = False
			Me.radDock1.Location = New System.Drawing.Point(0, 0)
			Me.radDock1.MainDocumentContainer = Me.documentContainer1
			Me.radDock1.Name = "radDock1"
			Me.radDock1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' 
			' 
			Me.radDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radDock1.Size = New System.Drawing.Size(792, 687)
			Me.radDock1.TabIndex = 0
			Me.radDock1.TabStop = False
			Me.radDock1.Text = "radDock1"
			' 
			' toolWindow3
			' 
			Me.toolWindow3.Controls.Add(Me.radPanel3)
			Me.toolWindow3.Location = New System.Drawing.Point(1, 21)
			Me.toolWindow3.Name = "toolWindow3"
			Me.toolWindow3.Size = New System.Drawing.Size(790, 158)
			Me.toolWindow3.Text = "Output"
			' 
			' radPanel3
			' 
			Me.radPanel3.Controls.Add(Me.richTextBoxOutput)
			Me.radPanel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPanel3.Location = New System.Drawing.Point(0, 0)
			Me.radPanel3.Name = "radPanel3"
			Me.radPanel3.Padding = New System.Windows.Forms.Padding(1)
			' 
			' 
			' 
			Me.radPanel3.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.radPanel3.Size = New System.Drawing.Size(790, 158)
			Me.radPanel3.TabIndex = 1
			Me.radPanel3.Text = "radPanel3"
			' 
			' richTextBoxOutput
			' 
			Me.richTextBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.richTextBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBoxOutput.Location = New System.Drawing.Point(1, 1)
			Me.richTextBoxOutput.Name = "richTextBoxOutput"
			Me.richTextBoxOutput.Size = New System.Drawing.Size(788, 156)
			Me.richTextBoxOutput.TabIndex = 0
			Me.richTextBoxOutput.Text = ""
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.CausesValidation = False
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip3)
			Me.radSplitContainer1.Controls.Add(Me.documentContainer1)
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip4)
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radSplitContainer1.Size = New System.Drawing.Size(792, 484)
			Me.radSplitContainer1.TabIndex = 0
			Me.radSplitContainer1.TabStop = False
			' 
			' toolTabStrip3
			' 
			Me.toolTabStrip3.CausesValidation = False
			Me.toolTabStrip3.Controls.Add(Me.toolWindow1)
			Me.toolTabStrip3.Location = New System.Drawing.Point(0, 0)
			Me.toolTabStrip3.Name = "toolTabStrip3"
			' 
			' 
			' 
			Me.toolTabStrip3.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.toolTabStrip3.SelectedIndex = 0
			Me.toolTabStrip3.Size = New System.Drawing.Size(167, 484)
			Me.toolTabStrip3.SizeInfo.AbsoluteSize = New System.Drawing.Size(167, 200)
			Me.toolTabStrip3.SizeInfo.SplitterCorrection = New System.Drawing.Size(-33, 0)
			Me.toolTabStrip3.TabIndex = 1
			Me.toolTabStrip3.TabStop = False
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Controls.Add(Me.radListBox1)
			Me.toolWindow1.Location = New System.Drawing.Point(1, 21)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.Size = New System.Drawing.Size(165, 462)
			Me.toolWindow1.Text = "Toolbox"
			' 
			' radListBox1
			' 
			Me.radListBox1.BackColor = System.Drawing.Color.Transparent
			Me.radListBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radListBox1.FormatString = "{0}"
			Me.radListBox1.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radListBoxItem1, Me.radListBoxItem2, Me.radListBoxItem3, Me.radListBoxItem4, Me.radListBoxItem5, Me.radListBoxItem6, Me.radListBoxItem7, Me.radListBoxItem8, Me.radListBoxItem9, Me.radListBoxItem10, Me.radListBoxItem11, Me.radListBoxItem12, Me.radListBoxItem13, Me.radListBoxItem14, Me.radListBoxItem15, Me.radListBoxItem16, Me.radListBoxItem17, Me.radListBoxItem18, Me.radListBoxItem19, Me.radListBoxItem20, Me.radListBoxItem21, Me.radListBoxItem22, Me.radListBoxItem23, Me.radListBoxItem24}))
			Me.radListBox1.Location = New System.Drawing.Point(0, 0)
			Me.radListBox1.Name = "radListBox1"
			Me.radListBox1.Padding = New System.Windows.Forms.Padding(2)
			' 
			' 
			' 
			Me.radListBox1.RootElement.Padding = New System.Windows.Forms.Padding(2)
			Me.radListBox1.Size = New System.Drawing.Size(165, 462)
			Me.radListBox1.TabIndex = 0
			Me.radListBox1.Text = "RadPanel"
			' 
			' radListBoxItem1
			' 
			Me.radListBoxItem1.Image = My.Resources.RadButton
			Me.radListBoxItem1.Text = "RadButton"
			Me.radListBoxItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem2
			' 
			Me.radListBoxItem2.Image = My.Resources.RadCalendar
			Me.radListBoxItem2.Text = "RadCalendar"
			Me.radListBoxItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem3
			' 
			Me.radListBoxItem3.Image = My.Resources.RadLabel
			Me.radListBoxItem3.Text = "RadLabel"
			Me.radListBoxItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem4
			' 
			Me.radListBoxItem4.Image = My.Resources.RadCarousel
			Me.radListBoxItem4.Text = "RadCarousel"
			Me.radListBoxItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem5
			' 
			Me.radListBoxItem5.Image = My.Resources.RadRadioButton
			Me.radListBoxItem5.Text = "RadRadioButton"
			Me.radListBoxItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem6
			' 
			Me.radListBoxItem6.Image = My.Resources.RadCheckBox
			Me.radListBoxItem6.Text = "RadCheckBox"
			Me.radListBoxItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem7
			' 
			Me.radListBoxItem7.Image = My.Resources.RadPanel
			Me.radListBoxItem7.Text = "RadPanel"
			Me.radListBoxItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem8
			' 
			Me.radListBoxItem8.Image = My.Resources.RadProgressBar
			Me.radListBoxItem8.Text = "RadProgressBar"
			Me.radListBoxItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem9
			' 
			Me.radListBoxItem9.Image = My.Resources.RadTextBox
			Me.radListBoxItem9.Text = "RadTextBox"
			Me.radListBoxItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem10
			' 
			Me.radListBoxItem10.Image = My.Resources.RadPanelBar
			Me.radListBoxItem10.Text = "RadPanelBar"
			Me.radListBoxItem10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem11
			' 
			Me.radListBoxItem11.Image = My.Resources.RadTabStrip
			Me.radListBoxItem11.Text = "RadTabStrip"
			Me.radListBoxItem11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem12
			' 
			Me.radListBoxItem12.Image = My.Resources.RadMenu
			Me.radListBoxItem12.Text = "RadMenu"
			Me.radListBoxItem12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem13
			' 
			Me.radListBoxItem13.Image = My.Resources.RadContextMenuManager
			Me.radListBoxItem13.Text = "RadContextMenu"
			Me.radListBoxItem13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem14
			' 
			Me.radListBoxItem14.Image = My.Resources.RadSplitContainer
			Me.radListBoxItem14.Text = "RadSplitContainer"
			Me.radListBoxItem14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem15
			' 
			Me.radListBoxItem15.Image = My.Resources.RadTrackBar
			Me.radListBoxItem15.Text = "RadTrackBar"
			Me.radListBoxItem15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem16
			' 
			Me.radListBoxItem16.Image = My.Resources.RadRibbonBar
			Me.radListBoxItem16.Text = "RadRibbonBar"
			Me.radListBoxItem16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem17
			' 
			Me.radListBoxItem17.Image = My.Resources.RadRepeatButton
			Me.radListBoxItem17.Text = "RadRepeatButton"
			Me.radListBoxItem17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem18
			' 
			Me.radListBoxItem18.Image = My.Resources.RadGroupBox
			Me.radListBoxItem18.Text = "RadGroupBox"
			Me.radListBoxItem18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem19
			' 
			Me.radListBoxItem19.Image = My.Resources.RadSplitButton
			Me.radListBoxItem19.Text = "RadSplitButton"
			Me.radListBoxItem19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem20
			' 
			Me.radListBoxItem20.Image = My.Resources.RadForm
			Me.radListBoxItem20.Text = "RadForm"
			Me.radListBoxItem20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem21
			' 
			Me.radListBoxItem21.Image = My.Resources.RadMaskedEditBox
			Me.radListBoxItem21.Text = "RadMaskedEditBox"
			Me.radListBoxItem21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem22
			' 
			Me.radListBoxItem22.Image = My.Resources.RadComboBox
			Me.radListBoxItem22.Text = "RadComboxBox"
			Me.radListBoxItem22.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem23
			' 
			Me.radListBoxItem23.Image = My.Resources.RadDropDownButton
			Me.radListBoxItem23.Text = "RadDropDownButton"
			Me.radListBoxItem23.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radListBoxItem24
			' 
			Me.radListBoxItem24.Image = My.Resources.RadDateTimePicker
			Me.radListBoxItem24.Text = "RadDateTimePicker"
			Me.radListBoxItem24.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' documentContainer1
			' 
			Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer1.Location = New System.Drawing.Point(170, 0)
			Me.documentContainer1.Name = "documentContainer1"
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.documentContainer1.Size = New System.Drawing.Size(398, 484)
			Me.documentContainer1.SizeInfo.AbsoluteSize = New System.Drawing.Size(398, 200)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.SizeInfo.SplitterCorrection = New System.Drawing.Size(12, 0)
			Me.documentContainer1.TabIndex = 0
			Me.documentContainer1.TabStop = False
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.Controls.Add(Me.documentWindow3)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip1.Location = New System.Drawing.Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New System.Drawing.Size(398, 484)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' documentWindow3
			' 
			Me.documentWindow3.Controls.Add(Me.richTextBoxForm)
			Me.documentWindow3.Location = New System.Drawing.Point(1, 21)
			Me.documentWindow3.Name = "documentWindow3"
			Me.documentWindow3.Size = New System.Drawing.Size(396, 462)
			Me.documentWindow3.Text = "Form1.cs"
			' 
			' richTextBoxForm
			' 
			Me.richTextBoxForm.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBoxForm.Location = New System.Drawing.Point(0, 0)
			Me.richTextBoxForm.Name = "richTextBoxForm"
			Me.richTextBoxForm.Size = New System.Drawing.Size(396, 462)
			Me.richTextBoxForm.TabIndex = 0
			Me.richTextBoxForm.Text = ""
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Controls.Add(Me.richTextBoxDesigner)
			Me.documentWindow1.Location = New System.Drawing.Point(1, 21)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.Size = New System.Drawing.Size(396, 462)
			Me.documentWindow1.Text = "Form1.Designer.cs"
			' 
			' richTextBoxDesigner
			' 
			Me.richTextBoxDesigner.AutoWordSelection = True
			Me.richTextBoxDesigner.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richTextBoxDesigner.Location = New System.Drawing.Point(0, 0)
			Me.richTextBoxDesigner.Name = "richTextBoxDesigner"
			Me.richTextBoxDesigner.Size = New System.Drawing.Size(396, 462)
			Me.richTextBoxDesigner.TabIndex = 0
			Me.richTextBoxDesigner.Text = ""
			' 
			' toolTabStrip4
			' 
			Me.toolTabStrip4.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip4.Location = New System.Drawing.Point(571, 0)
			Me.toolTabStrip4.Name = "toolTabStrip4"
			' 
			' 
			' 
			Me.toolTabStrip4.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.toolTabStrip4.SelectedIndex = 0
			Me.toolTabStrip4.Size = New System.Drawing.Size(221, 484)
			Me.toolTabStrip4.SizeInfo.AbsoluteSize = New System.Drawing.Size(221, 200)
			Me.toolTabStrip4.SizeInfo.SplitterCorrection = New System.Drawing.Size(21, 0)
			Me.toolTabStrip4.TabIndex = 2
			Me.toolTabStrip4.TabStop = False
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Controls.Add(Me.radTreeView1)
			Me.toolWindow2.Location = New System.Drawing.Point(1, 21)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.Size = New System.Drawing.Size(219, 462)
			Me.toolWindow2.Text = "Solution Explorer - Solution 'ProjectTracker' (4 project)"
			' 
			' radTreeView1
			' 
			Me.radTreeView1.BackColor = System.Drawing.SystemColors.Window
			Me.radTreeView1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radTreeView1.Font = New System.Drawing.Font("Tahoma", 8.6F)
			Me.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radTreeView1.ImageList = Me.ImageList
			Me.radTreeView1.Location = New System.Drawing.Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			radTreeNode1.Expanded = True
			radTreeNode1.Image = (CType(resources.GetObject("radTreeNode1.Image"), System.Drawing.Image))
			radTreeNode1.ImageIndex = 7
			radTreeNode2.Image = (CType(resources.GetObject("radTreeNode2.Image"), System.Drawing.Image))
			radTreeNode2.ImageIndex = 6
			radTreeNode2.Text = "Common"
			radTreeNode3.Image = (CType(resources.GetObject("radTreeNode3.Image"), System.Drawing.Image))
			radTreeNode3.ImageIndex = 6
			radTreeNode3.Text = "DataAccess"
			radTreeNode4.Image = (CType(resources.GetObject("radTreeNode4.Image"), System.Drawing.Image))
			radTreeNode4.ImageIndex = 6
			radTreeNode4.Text = "Business"
			radTreeNode5.Expanded = True
			radTreeNode5.Image = (CType(resources.GetObject("radTreeNode5.Image"), System.Drawing.Image))
			radTreeNode5.ImageIndex = 6
			radTreeNode6.Expanded = True
			radTreeNode6.Image = (CType(resources.GetObject("radTreeNode6.Image"), System.Drawing.Image))
			radTreeNode6.ImageIndex = 9
			radTreeNode7.Image = (CType(resources.GetObject("radTreeNode7.Image"), System.Drawing.Image))
			radTreeNode7.ImageIndex = 0
			radTreeNode7.Text = "AssemblyInfo.cs"
			radTreeNode6.Nodes.Add(radTreeNode7)
			radTreeNode6.Text = "Properties"
			radTreeNode8.Expanded = True
			radTreeNode8.Image = (CType(resources.GetObject("radTreeNode8.Image"), System.Drawing.Image))
			radTreeNode8.ImageIndex = 8
			radTreeNode9.Image = (CType(resources.GetObject("radTreeNode9.Image"), System.Drawing.Image))
			radTreeNode9.ImageIndex = 10
			radTreeNode9.Text = "System"
			radTreeNode10.Image = (CType(resources.GetObject("radTreeNode10.Image"), System.Drawing.Image))
			radTreeNode10.ImageIndex = 10
			radTreeNode10.Text = "System.Data"
			radTreeNode11.Image = (CType(resources.GetObject("radTreeNode11.Image"), System.Drawing.Image))
			radTreeNode11.ImageIndex = 10
			radTreeNode11.Text = "System.Xml"
			radTreeNode8.Nodes.Add(radTreeNode9)
			radTreeNode8.Nodes.Add(radTreeNode10)
			radTreeNode8.Nodes.Add(radTreeNode11)
			radTreeNode8.Text = "References"
			radTreeNode12.Expanded = True
			radTreeNode12.Image = (CType(resources.GetObject("radTreeNode12.Image"), System.Drawing.Image))
			radTreeNode12.ImageIndex = 2
			radTreeNode13.Expanded = True
			radTreeNode13.Image = (CType(resources.GetObject("radTreeNode13.Image"), System.Drawing.Image))
			radTreeNode13.ImageIndex = 3
			radTreeNode14.Image = (CType(resources.GetObject("radTreeNode14.Image"), System.Drawing.Image))
			radTreeNode14.ImageIndex = 15
			radTreeNode14.Text = "Form1.Designer.cs"
			radTreeNode15.Image = (CType(resources.GetObject("radTreeNode15.Image"), System.Drawing.Image))
			radTreeNode15.ImageIndex = 15
			radTreeNode15.Text = "Form1.resx"
			radTreeNode13.Nodes.Add(radTreeNode14)
			radTreeNode13.Nodes.Add(radTreeNode15)
			radTreeNode13.Text = "Form1.cs"
			radTreeNode12.Nodes.Add(radTreeNode13)
			radTreeNode12.Text = "Forms"
			radTreeNode16.Image = (CType(resources.GetObject("radTreeNode16.Image"), System.Drawing.Image))
			radTreeNode16.ImageIndex = 0
			radTreeNode16.Text = "Program.cs"
			radTreeNode5.Nodes.Add(radTreeNode6)
			radTreeNode5.Nodes.Add(radTreeNode8)
			radTreeNode5.Nodes.Add(radTreeNode12)
			radTreeNode5.Nodes.Add(radTreeNode16)
			radTreeNode5.Text = "UI"
			radTreeNode1.Nodes.Add(radTreeNode2)
			radTreeNode1.Nodes.Add(radTreeNode3)
			radTreeNode1.Nodes.Add(radTreeNode4)
			radTreeNode1.Nodes.Add(radTreeNode5)
			radTreeNode1.Text = "Solution 'ProjectTracker' (4 projects)"
			Me.radTreeView1.Nodes.Add(radTreeNode1)
			Me.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radTreeView1.ShowLines = True
			Me.radTreeView1.Size = New System.Drawing.Size(219, 462)
			Me.radTreeView1.TabIndex = 0
			Me.radTreeView1.Text = "radTreeView1"
			' 
			' ImageList
			' 
			Me.ImageList.ImageStream = (CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.ImageList.Images.SetKeyName(0, "vss_csfile.ico")
			Me.ImageList.Images.SetKeyName(1, "vss_error.bmp")
			Me.ImageList.Images.SetKeyName(2, "vss_folder.png")
			Me.ImageList.Images.SetKeyName(3, "vss_form.ico")
			Me.ImageList.Images.SetKeyName(4, "vss_open_folder.png")
			Me.ImageList.Images.SetKeyName(5, "vss_output.bmp")
			Me.ImageList.Images.SetKeyName(6, "vss_project.ico")
			Me.ImageList.Images.SetKeyName(7, "vss_solution.ico")
			Me.ImageList.Images.SetKeyName(8, "vss_referencesfolder.png")
			Me.ImageList.Images.SetKeyName(9, "vss_propertiesfolder.png")
			Me.ImageList.Images.SetKeyName(10, "vss_refassembly.ico")
			Me.ImageList.Images.SetKeyName(11, "Control_ErrorProvider.png")
			Me.ImageList.Images.SetKeyName(12, "vss_Warning.bmp")
			Me.ImageList.Images.SetKeyName(13, "vss_Information.png")
			Me.ImageList.Images.SetKeyName(14, "vss_Task.png")
			Me.ImageList.Images.SetKeyName(15, "vss_formbehind.png")
			' 
			' toolTabStrip5
			' 
			Me.toolTabStrip5.Controls.Add(Me.toolWindow3)
			Me.toolTabStrip5.Controls.Add(Me.toolWindow4)
			Me.toolTabStrip5.Controls.Add(Me.toolWindow5)
			Me.toolTabStrip5.Location = New System.Drawing.Point(0, 487)
			Me.toolTabStrip5.Name = "toolTabStrip5"
			' 
			' 
			' 
			Me.toolTabStrip5.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.toolTabStrip5.SelectedIndex = 0
			Me.toolTabStrip5.Size = New System.Drawing.Size(792, 200)
			Me.toolTabStrip5.TabIndex = 3
			Me.toolTabStrip5.TabStop = False
			' 
			' toolWindow4
			' 
			Me.toolWindow4.Controls.Add(Me.radGridViewTasks)
			Me.toolWindow4.Controls.Add(Me.radPanel2)
			Me.toolWindow4.Location = New System.Drawing.Point(1, 17)
			Me.toolWindow4.Name = "toolWindow4"
			Me.toolWindow4.Size = New System.Drawing.Size(790, 162)
			Me.toolWindow4.Text = "Task List"
			' 
			' radGridViewTasks
			' 
			Me.radGridViewTasks.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254))))))
			Me.radGridViewTasks.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radGridViewTasks.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridViewTasks.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radGridViewTasks.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radGridViewTasks.ImeMode = System.Windows.Forms.ImeMode.NoControl
			Me.radGridViewTasks.Location = New System.Drawing.Point(0, 28)
			' 
			' 
			' 
			Me.radGridViewTasks.MasterTemplate.AllowAddNewRow = False
			Me.radGridViewTasks.MasterTemplate.AllowColumnReorder = False
			gridViewTextBoxColumn1.AllowGroup = False
			gridViewTextBoxColumn1.FieldName = "firstColumn"
			gridViewTextBoxColumn1.HeaderText = "!"
			gridViewTextBoxColumn1.MaxWidth = 20
			gridViewTextBoxColumn1.MinWidth = 20
			gridViewTextBoxColumn1.ReadOnly = True
			gridViewTextBoxColumn1.Name = "firstColumn"
			gridViewTextBoxColumn1.Width = 20
			gridViewTextBoxColumn2.AllowGroup = False
			gridViewTextBoxColumn2.FieldName = "Description"
			gridViewTextBoxColumn2.HeaderText = "Description"
			gridViewTextBoxColumn2.ReadOnly = True
			gridViewTextBoxColumn2.Name = "Description"
			gridViewTextBoxColumn2.Width = 239
			gridViewTextBoxColumn3.AllowGroup = False
			gridViewTextBoxColumn3.FieldName = "File"
			gridViewTextBoxColumn3.HeaderText = "File"
			gridViewTextBoxColumn3.MaxWidth = 100
			gridViewTextBoxColumn3.MinWidth = 100
			gridViewTextBoxColumn3.ReadOnly = True
			gridViewTextBoxColumn3.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
			gridViewTextBoxColumn3.Name = "File"
			gridViewTextBoxColumn3.Width = 100
			gridViewTextBoxColumn4.AllowGroup = False
			gridViewTextBoxColumn4.FieldName = "Line"
			gridViewTextBoxColumn4.HeaderText = "Line"
			gridViewTextBoxColumn4.MaxWidth = 80
			gridViewTextBoxColumn4.MinWidth = 80
			gridViewTextBoxColumn4.ReadOnly = True
			gridViewTextBoxColumn4.Name = "Line"
			gridViewTextBoxColumn4.Width = 80
			Me.radGridViewTasks.MasterTemplate.Columns.Add(gridViewTextBoxColumn1)
			Me.radGridViewTasks.MasterTemplate.Columns.Add(gridViewTextBoxColumn2)
			Me.radGridViewTasks.MasterTemplate.Columns.Add(gridViewTextBoxColumn3)
			Me.radGridViewTasks.MasterTemplate.Columns.Add(gridViewTextBoxColumn4)
			gridSortField1.FieldName = "File"
			gridSortField1.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
			Me.radGridViewTasks.MasterTemplate.SortDescriptors.Add(gridSortField1)
			Me.radGridViewTasks.Name = "radGridViewTasks"
			Me.radGridViewTasks.ReadOnly = True
			Me.radGridViewTasks.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radGridViewTasks.ShowGroupPanel = False
			Me.radGridViewTasks.Size = New System.Drawing.Size(790, 134)
			Me.radGridViewTasks.TabIndex = 1
			' 
			' radPanel2
			' 
			Me.radPanel2.Controls.Add(Me.radComboBox1)
			Me.radPanel2.Dock = System.Windows.Forms.DockStyle.Top
			Me.radPanel2.Location = New System.Drawing.Point(0, 0)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Size = New System.Drawing.Size(790, 28)
			Me.radPanel2.TabIndex = 0
			' 
			' radComboBox1
			' 
			Me.radComboBox1.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.radComboBox1.FormatString = "{0}"
			Me.radComboBox1.Items.AddRange(New List(Of RadListDataItem)(New RadListDataItem() { Me.radComboBoxItem1, Me.radComboBoxItem2}))
			Me.radComboBox1.Location = New System.Drawing.Point(3, 3)
			Me.radComboBox1.Name = "radComboBox1"
			' 
			' 
			' 
			Me.radComboBox1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radComboBox1.Size = New System.Drawing.Size(162, 20)
			Me.radComboBox1.TabIndex = 0
			Me.radComboBox1.TabStop = False
			Me.radComboBox1.Text = "Comments"
			' 
			' radComboBoxItem1
			' 
			Me.radComboBoxItem1.Text = "User Tasks"
			' 
			' radComboBoxItem2
			' 
			Me.radComboBoxItem2.Text = "Comments"
			' 
			' toolWindow5
			' 
			Me.toolWindow5.Controls.Add(Me.radGridViewErrors)
			Me.toolWindow5.Controls.Add(Me.radPanel1)
			Me.toolWindow5.Location = New System.Drawing.Point(1, 17)
			Me.toolWindow5.Name = "toolWindow5"
			Me.toolWindow5.Size = New System.Drawing.Size(790, 162)
			Me.toolWindow5.Text = "Error List"
			' 
			' radGridViewErrors
			' 
			Me.radGridViewErrors.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254))))))
			Me.radGridViewErrors.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radGridViewErrors.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGridViewErrors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radGridViewErrors.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radGridViewErrors.ImeMode = System.Windows.Forms.ImeMode.NoControl
			Me.radGridViewErrors.Location = New System.Drawing.Point(0, 31)
			' 
			' 
			' 
			Me.radGridViewErrors.MasterTemplate.AllowAddNewRow = False
			Me.radGridViewErrors.MasterTemplate.AllowColumnReorder = False
			gridViewImageColumn1.DataType = GetType(System.Drawing.Image)
			gridViewImageColumn1.FieldName = "columnImage"
			gridViewImageColumn1.HeaderText = "columnImage"
			gridViewImageColumn1.MaxWidth = 20
			gridViewImageColumn1.MinWidth = 20
			gridViewImageColumn1.Name = "columnImage"
			gridViewImageColumn1.Width = 20
			gridViewTextBoxColumn5.AllowGroup = False
			gridViewTextBoxColumn5.FieldName = "columnNumber"
			gridViewTextBoxColumn5.HeaderText = "columnNumber"
			gridViewTextBoxColumn5.MaxWidth = 20
			gridViewTextBoxColumn5.MinWidth = 20
			gridViewTextBoxColumn5.ReadOnly = True
			gridViewTextBoxColumn5.Name = "columnNumber"
			gridViewTextBoxColumn5.Width = 20
			gridViewTextBoxColumn6.AllowGroup = False
			gridViewTextBoxColumn6.FieldName = "Description"
			gridViewTextBoxColumn6.HeaderText = "Description"
			gridViewTextBoxColumn6.ReadOnly = True
			gridViewTextBoxColumn6.Name = "Description"
			gridViewTextBoxColumn6.Width = 200
			gridViewTextBoxColumn7.AllowGroup = False
			gridViewTextBoxColumn7.FieldName = "File"
			gridViewTextBoxColumn7.HeaderText = "File"
			gridViewTextBoxColumn7.MaxWidth = 80
			gridViewTextBoxColumn7.MinWidth = 80
			gridViewTextBoxColumn7.ReadOnly = True
			gridViewTextBoxColumn7.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
			gridViewTextBoxColumn7.Name = "File"
			gridViewTextBoxColumn7.Width = 80
			gridViewTextBoxColumn8.AllowGroup = False
			gridViewTextBoxColumn8.FieldName = "Line"
			gridViewTextBoxColumn8.HeaderText = "Line"
			gridViewTextBoxColumn8.MaxWidth = 50
			gridViewTextBoxColumn8.MinWidth = 50
			gridViewTextBoxColumn8.ReadOnly = True
			gridViewTextBoxColumn8.Name = "Line"
			gridViewTextBoxColumn9.AllowGroup = False
			gridViewTextBoxColumn9.FieldName = "Column"
			gridViewTextBoxColumn9.HeaderText = "Column"
			gridViewTextBoxColumn9.MaxWidth = 96
			gridViewTextBoxColumn9.MinWidth = 96
			gridViewTextBoxColumn9.ReadOnly = True
			gridViewTextBoxColumn9.Name = "Column"
			gridViewTextBoxColumn9.Width = 96
			gridViewTextBoxColumn10.AllowGroup = False
			gridViewTextBoxColumn10.FieldName = "Project"
			gridViewTextBoxColumn10.HeaderText = "Project"
			gridViewTextBoxColumn10.MaxWidth = 104
			gridViewTextBoxColumn10.MinWidth = 104
			gridViewTextBoxColumn10.ReadOnly = True
			gridViewTextBoxColumn10.Name = "Project"
			gridViewTextBoxColumn10.Width = 104
			Me.radGridViewErrors.MasterTemplate.Columns.Add(gridViewImageColumn1)
			Me.radGridViewErrors.MasterTemplate.Columns.Add(gridViewTextBoxColumn5)
			Me.radGridViewErrors.MasterTemplate.Columns.Add(gridViewTextBoxColumn6)
			Me.radGridViewErrors.MasterTemplate.Columns.Add(gridViewTextBoxColumn7)
			Me.radGridViewErrors.MasterTemplate.Columns.Add(gridViewTextBoxColumn8)
			Me.radGridViewErrors.MasterTemplate.Columns.Add(gridViewTextBoxColumn9)
			Me.radGridViewErrors.MasterTemplate.Columns.Add(gridViewTextBoxColumn10)
			gridSortField2.FieldName = "File"
			gridSortField2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
			Me.radGridViewErrors.MasterTemplate.SortDescriptors.Add(gridSortField2)
			Me.radGridViewErrors.Name = "radGridViewErrors"
			Me.radGridViewErrors.ReadOnly = True
			Me.radGridViewErrors.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radGridViewErrors.ShowGroupPanel = False
			Me.radGridViewErrors.Size = New System.Drawing.Size(790, 131)
			Me.radGridViewErrors.TabIndex = 1
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radButton3)
			Me.radPanel1.Controls.Add(Me.radButton2)
			Me.radPanel1.Controls.Add(Me.radButton1)
			Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radPanel1.Location = New System.Drawing.Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(790, 31)
			Me.radPanel1.TabIndex = 0
			' 
			' radButton3
			' 
			Me.radButton3.ImageIndex = 13
			Me.radButton3.ImageKey = "vss_Information.png"
			Me.radButton3.ImageList = Me.ImageList
			Me.radButton3.Location = New System.Drawing.Point(165, 3)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Size = New System.Drawing.Size(83, 23)
			Me.radButton3.TabIndex = 2
			Me.radButton3.Text = "0 Messages"
			Me.radButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton2
			' 
			Me.radButton2.ImageIndex = 12
			Me.radButton2.ImageList = Me.ImageList
			Me.radButton2.Location = New System.Drawing.Point(78, 3)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New System.Drawing.Size(81, 23)
			Me.radButton2.TabIndex = 1
			Me.radButton2.Text = "0 Warnings"
			Me.radButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radButton1
			' 
			Me.radButton1.ImageIndex = 11
			Me.radButton1.ImageList = Me.ImageList
			Me.radButton1.Location = New System.Drawing.Point(11, 3)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(61, 23)
			Me.radButton1.TabIndex = 0
			Me.radButton1.Text = "1 Error"
			Me.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radThemeManager1
			' 
			themeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource1.ThemeLocation = "RadDockTheme.DockQuickNavigator.xml"
			themeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource2.ThemeLocation = "RadDockTheme.DockSplitContainer.xml"
			themeSource3.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource3.ThemeLocation = "RadDockTheme.DockTabStrip.xml"
			themeSource4.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource4.ThemeLocation = "RadDockTheme.DockTitleBar.xml"
			themeSource5.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource5.ThemeLocation = "RadDockTheme.DockAutoHideTabStrip.xml"
			themeSource6.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource6.ThemeLocation = "RadDockTheme.DockMenu.xml"
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource1, themeSource2, themeSource3, themeSource4, themeSource5, themeSource6})
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(792, 687)
			Me.Controls.Add(Me.radDock1)
			Me.Name = "Form1"
			Me.Text = "Telerik Studio"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDock1.ResumeLayout(False)
			Me.toolWindow3.ResumeLayout(False)
			CType(Me.radPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel3.ResumeLayout(False)
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip3.ResumeLayout(False)
			Me.toolWindow1.ResumeLayout(False)
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentContainer1.ResumeLayout(False)
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip1.ResumeLayout(False)
			Me.documentWindow3.ResumeLayout(False)
			Me.documentWindow1.ResumeLayout(False)
			CType(Me.toolTabStrip4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip4.ResumeLayout(False)
			Me.toolWindow2.ResumeLayout(False)
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTabStrip5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip5.ResumeLayout(False)
			Me.toolWindow4.ResumeLayout(False)
			CType(Me.radGridViewTasks.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridViewTasks, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel2.ResumeLayout(False)
			Me.radPanel2.PerformLayout()
			CType(Me.radComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolWindow5.ResumeLayout(False)
			CType(Me.radGridViewErrors.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridViewErrors, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private documentWindow3 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private toolWindow5 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolTabStrip4 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolTabStrip5 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolWindow4 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radListBox1 As Telerik.WinControls.UI.RadListControl
		Private radListBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem3 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem4 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem5 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem6 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem7 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem8 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem9 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem10 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem11 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem12 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem13 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem14 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem15 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem16 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem17 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem18 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem19 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem20 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem21 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem22 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem23 As Telerik.WinControls.UI.RadListDataItem
		Private radListBoxItem24 As Telerik.WinControls.UI.RadListDataItem
		Private ImageList As System.Windows.Forms.ImageList
		Private richTextBoxForm As System.Windows.Forms.RichTextBox
		Private richTextBoxDesigner As System.Windows.Forms.RichTextBox
		Private richTextBoxOutput As System.Windows.Forms.RichTextBox
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radButton3 As Telerik.WinControls.UI.RadButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radGridViewErrors As Telerik.WinControls.UI.RadGridView
		Private radGridViewTasks As Telerik.WinControls.UI.RadGridView
		Private radPanel2 As Telerik.WinControls.UI.RadPanel
		Private radComboBox1 As Telerik.WinControls.UI.RadDropDownList
		Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
		Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radPanel3 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace

