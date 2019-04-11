Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.MenuStrip.MultilineText
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
			Me.radMenu1 = New Telerik.WinControls.UI.RadMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem1 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem2 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem3 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1_6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem4 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1_9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItemSrc_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItemSrc_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItemSrc_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem5 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1_10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem6 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1_12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem1_13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem7 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem1_14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem8 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem2_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem9 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem2_8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem10 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem2_9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_15 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_16 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_8 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_9 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_10 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem6_12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Magenta
			Me.imageList1.Images.SetKeyName(0, "")
			Me.imageList1.Images.SetKeyName(1, "")
			Me.imageList1.Images.SetKeyName(2, "")
			Me.imageList1.Images.SetKeyName(3, "")
			Me.imageList1.Images.SetKeyName(4, "")
			Me.imageList1.Images.SetKeyName(5, "CloseSolution.bmp")
			' 
			' radMenu1
			' 
			Me.radMenu1.AllItemsEqualHeight = True
			Me.radMenu1.AllowMerge = False
			Me.radMenu1.BackColor = System.Drawing.Color.Transparent
			Me.radMenu1.ForeColor = System.Drawing.Color.Black
			Me.radMenu1.ImageList = Me.imageList1
			Me.radMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4, Me.radMenuItem5})
			Me.radMenu1.Location = New System.Drawing.Point(1, 1)
			Me.radMenu1.Name = "radMenu1"
			' 
			' 
			' 
			Me.radMenu1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenu1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radMenu1.RootElement.ToolTipText = Nothing
			Me.radMenu1.Size = New System.Drawing.Size(499, 70)
			Me.radMenu1.TabIndex = 0
			Me.radMenu1.Text = "radMenu1"
			Me.radMenu1.ThemeName = "ControlDefault"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1_1, Me.radMenuItem1_2, Me.radMenuSeparatorItem1, Me.radMenuItem1_3, Me.radMenuSeparatorItem2, Me.radMenuItem1_4, Me.radMenuItem1_5, Me.radMenuSeparatorItem3, Me.radMenuItem1_6, Me.radMenuItem1_7, Me.radMenuItem1_8, Me.radMenuSeparatorItem4, Me.radMenuItem1_9, Me.radMenuSeparatorItem5, Me.radMenuItem1_10, Me.radMenuItem1_11, Me.radMenuSeparatorItem6, Me.radMenuItem1_12, Me.radMenuItem1_13, Me.radMenuSeparatorItem7, Me.radMenuItem1_14})
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Padding = New System.Windows.Forms.Padding(2)
			Me.radMenuItem1.ShowArrow = False
			Me.radMenuItem1.Text = "Content" & Constants.vbCrLf & "Management"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.ToolTipText = Nothing
			' 
			' radMenuItem1_1
			' 
			Me.radMenuItem1_1.MinSize = New System.Drawing.Size(180, 25)
			Me.radMenuItem1_1.Name = "radMenuItem1_1"
			Me.radMenuItem1_1.Text = "New"
			Me.radMenuItem1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_1.ToolTipText = Nothing
			' 
			' radMenuItem1_2
			' 
			Me.radMenuItem1_2.Name = "radMenuItem1_2"
			Me.radMenuItem1_2.Text = "Open"
			Me.radMenuItem1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_2.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.Class = "RadMenuItem"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.Text = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.ToolTipText = Nothing
			' 
			' radMenuItem1_3
			' 
			Me.radMenuItem1_3.Name = "radMenuItem1_3"
			Me.radMenuItem1_3.Text = "Add"
			Me.radMenuItem1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_3.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.Class = "RadMenuItem"
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.Text = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.ToolTipText = Nothing
			' 
			' radMenuItem1_4
			' 
			Me.radMenuItem1_4.Name = "radMenuItem1_4"
			Me.radMenuItem1_4.Text = "Close"
			Me.radMenuItem1_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_4.ToolTipText = Nothing
			' 
			' radMenuItem1_5
			' 
			Me.radMenuItem1_5.Name = "radMenuItem1_5"
			Me.radMenuItem1_5.Text = "Close Solution"
			Me.radMenuItem1_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_5.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem3
			' 
			Me.radMenuSeparatorItem3.Class = "RadMenuItem"
			Me.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.Text = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.ToolTipText = Nothing
			' 
			' radMenuItem1_6
			' 
			Me.radMenuItem1_6.Name = "radMenuItem1_6"
			Me.radMenuItem1_6.Text = "Advanced Save Options..."
			Me.radMenuItem1_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_6.ToolTipText = Nothing
			' 
			' radMenuItem1_7
			' 
			Me.radMenuItem1_7.Name = "radMenuItem1_7"
			Me.radMenuItem1_7.Text = "Save All"
			Me.radMenuItem1_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_7.ToolTipText = Nothing
			' 
			' radMenuItem1_8
			' 
			Me.radMenuItem1_8.Name = "radMenuItem1_8"
			Me.radMenuItem1_8.Text = "Export Template..."
			Me.radMenuItem1_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_8.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem4
			' 
			Me.radMenuSeparatorItem4.Class = "RadMenuItem"
			Me.radMenuSeparatorItem4.Name = "radMenuSeparatorItem4"
			Me.radMenuSeparatorItem4.Text = "radMenuSeparatorItem4"
			Me.radMenuSeparatorItem4.ToolTipText = Nothing
			' 
			' radMenuItem1_9
			' 
			Me.radMenuItem1_9.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItemSrc_1, Me.radMenuItemSrc_2, Me.radMenuItemSrc_3})
			Me.radMenuItem1_9.Name = "radMenuItem1_9"
			Me.radMenuItem1_9.Text = "Source Control"
			Me.radMenuItem1_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_9.ToolTipText = Nothing
			' 
			' radMenuItemSrc_1
			' 
			Me.radMenuItemSrc_1.Name = "radMenuItemSrc_1"
			Me.radMenuItemSrc_1.Text = "View History"
			Me.radMenuItemSrc_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItemSrc_1.ToolTipText = Nothing
			' 
			' radMenuItemSrc_2
			' 
			Me.radMenuItemSrc_2.Name = "radMenuItemSrc_2"
			Me.radMenuItemSrc_2.Text = "Refresh Status"
			Me.radMenuItemSrc_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItemSrc_2.ToolTipText = Nothing
			' 
			' radMenuItemSrc_3
			' 
			Me.radMenuItemSrc_3.Name = "radMenuItemSrc_3"
			Me.radMenuItemSrc_3.Text = "Compare..."
			Me.radMenuItemSrc_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItemSrc_3.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem5
			' 
			Me.radMenuSeparatorItem5.Class = "RadMenuItem"
			Me.radMenuSeparatorItem5.Name = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.Text = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.ToolTipText = Nothing
			' 
			' radMenuItem1_10
			' 
			Me.radMenuItem1_10.Name = "radMenuItem1_10"
			Me.radMenuItem1_10.Text = "Page Setup..."
			Me.radMenuItem1_10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_10.ToolTipText = Nothing
			' 
			' radMenuItem1_11
			' 
			Me.radMenuItem1_11.Name = "radMenuItem1_11"
			Me.radMenuItem1_11.Text = "Print..."
			Me.radMenuItem1_11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_11.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem6
			' 
			Me.radMenuSeparatorItem6.Class = "RadMenuItem"
			Me.radMenuSeparatorItem6.Name = "radMenuSeparatorItem6"
			Me.radMenuSeparatorItem6.Text = "radMenuSeparatorItem6"
			Me.radMenuSeparatorItem6.ToolTipText = Nothing
			' 
			' radMenuItem1_12
			' 
			Me.radMenuItem1_12.Name = "radMenuItem1_12"
			Me.radMenuItem1_12.Text = "Recent Files"
			Me.radMenuItem1_12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_12.ToolTipText = Nothing
			' 
			' radMenuItem1_13
			' 
			Me.radMenuItem1_13.Name = "radMenuItem1_13"
			Me.radMenuItem1_13.Text = "Recent Projects"
			Me.radMenuItem1_13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_13.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem7
			' 
			Me.radMenuSeparatorItem7.Class = "RadMenuItem"
			Me.radMenuSeparatorItem7.Name = "radMenuSeparatorItem7"
			Me.radMenuSeparatorItem7.Text = "radMenuSeparatorItem7"
			Me.radMenuSeparatorItem7.ToolTipText = Nothing
			' 
			' radMenuItem1_14
			' 
			Me.radMenuItem1_14.Name = "radMenuItem1_14"
			Me.radMenuItem1_14.Text = "Exit"
			Me.radMenuItem1_14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_14.ToolTipText = Nothing
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem2_1, Me.radMenuItem2_2, Me.radMenuSeparatorItem8, Me.radMenuItem2_3, Me.radMenuItem2_4, Me.radMenuItem2_5, Me.radMenuItem2_6, Me.radMenuItem2_7, Me.radMenuSeparatorItem9, Me.radMenuItem2_8, Me.radMenuSeparatorItem10, Me.radMenuItem2_9, Me.radMenuItem2_10, Me.radMenuItem2_11, Me.radMenuItem2_12, Me.radMenuItem2_13, Me.radMenuItem2_14, Me.radMenuItem2_15, Me.radMenuItem2_16})
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Padding = New System.Windows.Forms.Padding(2)
			Me.radMenuItem2.ShowArrow = False
			Me.radMenuItem2.Text = "Customer" & Constants.vbCrLf & "Relations"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.ToolTipText = Nothing
			' 
			' radMenuItem2_1
			' 
			Me.radMenuItem2_1.Name = "radMenuItem2_1"
			Me.radMenuItem2_1.Text = "Undo"
			Me.radMenuItem2_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_1.ToolTipText = Nothing
			' 
			' radMenuItem2_2
			' 
			Me.radMenuItem2_2.Name = "radMenuItem2_2"
			Me.radMenuItem2_2.Text = "Redo"
			Me.radMenuItem2_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_2.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem8
			' 
			Me.radMenuSeparatorItem8.Class = "RadMenuItem"
			Me.radMenuSeparatorItem8.Name = "radMenuSeparatorItem8"
			Me.radMenuSeparatorItem8.Text = "radMenuSeparatorItem8"
			Me.radMenuSeparatorItem8.ToolTipText = Nothing
			' 
			' radMenuItem2_3
			' 
			Me.radMenuItem2_3.Name = "radMenuItem2_3"
			Me.radMenuItem2_3.Text = "Cut"
			Me.radMenuItem2_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_3.ToolTipText = Nothing
			' 
			' radMenuItem2_4
			' 
			Me.radMenuItem2_4.Name = "radMenuItem2_4"
			Me.radMenuItem2_4.Text = "Copy"
			Me.radMenuItem2_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_4.ToolTipText = Nothing
			' 
			' radMenuItem2_5
			' 
			Me.radMenuItem2_5.Name = "radMenuItem2_5"
			Me.radMenuItem2_5.Text = "Paste"
			Me.radMenuItem2_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_5.ToolTipText = Nothing
			' 
			' radMenuItem2_6
			' 
			Me.radMenuItem2_6.Name = "radMenuItem2_6"
			Me.radMenuItem2_6.Text = "Cycle Clipboard Ring"
			Me.radMenuItem2_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_6.ToolTipText = Nothing
			' 
			' radMenuItem2_7
			' 
			Me.radMenuItem2_7.Name = "radMenuItem2_7"
			Me.radMenuItem2_7.Text = "Delete"
			Me.radMenuItem2_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_7.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem9
			' 
			Me.radMenuSeparatorItem9.Class = "RadMenuItem"
			Me.radMenuSeparatorItem9.Name = "radMenuSeparatorItem9"
			Me.radMenuSeparatorItem9.Text = "radMenuSeparatorItem9"
			Me.radMenuSeparatorItem9.ToolTipText = Nothing
			' 
			' radMenuItem2_8
			' 
			Me.radMenuItem2_8.Name = "radMenuItem2_8"
			Me.radMenuItem2_8.Text = "Select All"
			Me.radMenuItem2_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_8.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem10
			' 
			Me.radMenuSeparatorItem10.Class = "RadMenuItem"
			Me.radMenuSeparatorItem10.Name = "radMenuSeparatorItem10"
			Me.radMenuSeparatorItem10.Text = "radMenuSeparatorItem10"
			Me.radMenuSeparatorItem10.ToolTipText = Nothing
			' 
			' radMenuItem2_9
			' 
			Me.radMenuItem2_9.Name = "radMenuItem2_9"
			Me.radMenuItem2_9.Text = "Find and Replace"
			Me.radMenuItem2_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_9.ToolTipText = Nothing
			' 
			' radMenuItem2_10
			' 
			Me.radMenuItem2_10.Name = "radMenuItem2_10"
			Me.radMenuItem2_10.Text = "Go To..."
			Me.radMenuItem2_10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_10.ToolTipText = Nothing
			' 
			' radMenuItem2_11
			' 
			Me.radMenuItem2_11.Name = "radMenuItem2_11"
			Me.radMenuItem2_11.Text = "Show Source File"
			Me.radMenuItem2_11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_11.ToolTipText = Nothing
			' 
			' radMenuItem2_12
			' 
			Me.radMenuItem2_12.Name = "radMenuItem2_12"
			Me.radMenuItem2_12.Text = "Insert File as Text..."
			Me.radMenuItem2_12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_12.ToolTipText = Nothing
			' 
			' radMenuItem2_13
			' 
			Me.radMenuItem2_13.Name = "radMenuItem2_13"
			Me.radMenuItem2_13.Text = "Advanced"
			Me.radMenuItem2_13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_13.ToolTipText = Nothing
			' 
			' radMenuItem2_14
			' 
			Me.radMenuItem2_14.Name = "radMenuItem2_14"
			Me.radMenuItem2_14.Text = "Bookmarks"
			Me.radMenuItem2_14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_14.ToolTipText = Nothing
			' 
			' radMenuItem2_15
			' 
			Me.radMenuItem2_15.Name = "radMenuItem2_15"
			Me.radMenuItem2_15.Text = "Outlining"
			Me.radMenuItem2_15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_15.ToolTipText = Nothing
			' 
			' radMenuItem2_16
			' 
			Me.radMenuItem2_16.Name = "radMenuItem2_16"
			Me.radMenuItem2_16.Text = "IntelliSense"
			Me.radMenuItem2_16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_16.ToolTipText = Nothing
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem3_1, Me.radMenuItem3_2, Me.radMenuItem3_3, Me.radMenuItem3_4, Me.radMenuItem3_5, Me.radMenuItem3_6, Me.radMenuItem3_7, Me.radMenuItem3_8, Me.radMenuItem3_9, Me.radMenuItem3_10})
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Padding = New System.Windows.Forms.Padding(2)
			Me.radMenuItem3.ShowArrow = False
			Me.radMenuItem3.Text = "Supply Chain" & Constants.vbCrLf & "Management"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3.ToolTipText = Nothing
			' 
			' radMenuItem3_1
			' 
			Me.radMenuItem3_1.Name = "radMenuItem3_1"
			Me.radMenuItem3_1.Text = "Code"
			Me.radMenuItem3_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_1.ToolTipText = Nothing
			' 
			' radMenuItem3_2
			' 
			Me.radMenuItem3_2.Name = "radMenuItem3_2"
			Me.radMenuItem3_2.Text = "Open"
			Me.radMenuItem3_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_2.ToolTipText = Nothing
			' 
			' radMenuItem3_3
			' 
			Me.radMenuItem3_3.Name = "radMenuItem3_3"
			Me.radMenuItem3_3.Text = "Open With..."
			Me.radMenuItem3_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_3.ToolTipText = Nothing
			' 
			' radMenuItem3_4
			' 
			Me.radMenuItem3_4.Name = "radMenuItem3_4"
			Me.radMenuItem3_4.Text = "Server Explorer"
			Me.radMenuItem3_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_4.ToolTipText = Nothing
			' 
			' radMenuItem3_5
			' 
			Me.radMenuItem3_5.Name = "radMenuItem3_5"
			Me.radMenuItem3_5.Text = "Solution Explorer"
			Me.radMenuItem3_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_5.ToolTipText = Nothing
			' 
			' radMenuItem3_6
			' 
			Me.radMenuItem3_6.Name = "radMenuItem3_6"
			Me.radMenuItem3_6.Text = "Bookmark Window"
			Me.radMenuItem3_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_6.ToolTipText = Nothing
			' 
			' radMenuItem3_7
			' 
			Me.radMenuItem3_7.Name = "radMenuItem3_7"
			Me.radMenuItem3_7.Text = "Class View"
			Me.radMenuItem3_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_7.ToolTipText = Nothing
			' 
			' radMenuItem3_8
			' 
			Me.radMenuItem3_8.Name = "radMenuItem3_8"
			Me.radMenuItem3_8.Text = "Code Definition Window"
			Me.radMenuItem3_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_8.ToolTipText = Nothing
			' 
			' radMenuItem3_9
			' 
			Me.radMenuItem3_9.Name = "radMenuItem3_9"
			Me.radMenuItem3_9.Text = "Object Browser"
			Me.radMenuItem3_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_9.ToolTipText = Nothing
			' 
			' radMenuItem3_10
			' 
			Me.radMenuItem3_10.Name = "radMenuItem3_10"
			Me.radMenuItem3_10.Text = "Error List"
			Me.radMenuItem3_10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_10.ToolTipText = Nothing
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem4_1, Me.radMenuItem4_2, Me.radMenuItem4_3})
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Padding = New System.Windows.Forms.Padding(2)
			Me.radMenuItem4.ShowArrow = False
			Me.radMenuItem4.Text = "Enterprise Resource" & Constants.vbCrLf & "Planning"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4.ToolTipText = Nothing
			' 
			' radMenuItem4_1
			' 
			Me.radMenuItem4_1.Name = "radMenuItem4_1"
			Me.radMenuItem4_1.Text = "Build Solution"
			Me.radMenuItem4_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_1.ToolTipText = Nothing
			' 
			' radMenuItem4_2
			' 
			Me.radMenuItem4_2.Name = "radMenuItem4_2"
			Me.radMenuItem4_2.Text = "Build Examples"
			Me.radMenuItem4_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_2.ToolTipText = Nothing
			' 
			' radMenuItem4_3
			' 
			Me.radMenuItem4_3.Name = "radMenuItem4_3"
			Me.radMenuItem4_3.Text = "Publish Examples"
			Me.radMenuItem4_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_3.ToolTipText = Nothing
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem5_1, Me.radMenuItem5_2})
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Padding = New System.Windows.Forms.Padding(2)
			Me.radMenuItem5.ShowArrow = False
			Me.radMenuItem5.Text = "Data"
			Me.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5.ToolTipText = Nothing
			' 
			' radMenuItem5_1
			' 
			Me.radMenuItem5_1.Name = "radMenuItem5_1"
			Me.radMenuItem5_1.Text = "Show Data Sources"
			Me.radMenuItem5_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_1.ToolTipText = Nothing
			' 
			' radMenuItem5_2
			' 
			Me.radMenuItem5_2.Name = "radMenuItem5_2"
			Me.radMenuItem5_2.Text = "Add New Data Source..."
			Me.radMenuItem5_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_2.ToolTipText = Nothing
			' 
			' radMenuItem6_1
			' 
			Me.radMenuItem6_1.Name = "radMenuItem6_1"
			Me.radMenuItem6_1.Text = "How Do I"
			Me.radMenuItem6_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_1.ToolTipText = Nothing
			' 
			' radMenuItem6_2
			' 
			Me.radMenuItem6_2.Name = "radMenuItem6_2"
			Me.radMenuItem6_2.Text = "Search"
			Me.radMenuItem6_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_2.ToolTipText = Nothing
			' 
			' radMenuItem6_3
			' 
			Me.radMenuItem6_3.Name = "radMenuItem6_3"
			Me.radMenuItem6_3.Text = "Contents"
			Me.radMenuItem6_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_3.ToolTipText = Nothing
			' 
			' radMenuItem6_4
			' 
			Me.radMenuItem6_4.Name = "radMenuItem6_4"
			Me.radMenuItem6_4.Text = "Index"
			Me.radMenuItem6_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_4.ToolTipText = Nothing
			' 
			' radMenuItem6_5
			' 
			Me.radMenuItem6_5.Name = "radMenuItem6_5"
			Me.radMenuItem6_5.Text = "Help Favorites"
			Me.radMenuItem6_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_5.ToolTipText = Nothing
			' 
			' radMenuItem6_6
			' 
			Me.radMenuItem6_6.Name = "radMenuItem6_6"
			Me.radMenuItem6_6.Text = "Dynamic Help"
			Me.radMenuItem6_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_6.ToolTipText = Nothing
			' 
			' radMenuItem6_7
			' 
			Me.radMenuItem6_7.Name = "radMenuItem6_7"
			Me.radMenuItem6_7.Text = "Index Results"
			Me.radMenuItem6_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_7.ToolTipText = Nothing
			' 
			' radMenuItem6_8
			' 
			Me.radMenuItem6_8.Name = "radMenuItem6_8"
			Me.radMenuItem6_8.Text = "Customer Feedback Options..."
			Me.radMenuItem6_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_8.ToolTipText = Nothing
			' 
			' radMenuItem6_9
			' 
			Me.radMenuItem6_9.Name = "radMenuItem6_9"
			Me.radMenuItem6_9.Text = "Register Product..."
			Me.radMenuItem6_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_9.ToolTipText = Nothing
			' 
			' radMenuItem6_10
			' 
			Me.radMenuItem6_10.Name = "radMenuItem6_10"
			Me.radMenuItem6_10.Text = "Check for Update"
			Me.radMenuItem6_10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_10.ToolTipText = Nothing
			' 
			' radMenuItem6_11
			' 
			Me.radMenuItem6_11.Name = "radMenuItem6_11"
			Me.radMenuItem6_11.Text = "Technical Support"
			Me.radMenuItem6_11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_11.ToolTipText = Nothing
			' 
			' radMenuItem6_12
			' 
			Me.radMenuItem6_12.Name = "radMenuItem6_12"
			Me.radMenuItem6_12.Text = "About Telerik WinControls Suite..."
			Me.radMenuItem6_12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_12.ToolTipText = Nothing
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanelDemoHolder.BackColor = System.Drawing.Color.White
			Me.radPanelDemoHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.radPanelDemoHolder.Controls.Add(Me.radMenu1)
			Me.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(362, 218)
			Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
			Me.radPanelDemoHolder.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.RootElement.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(500, 300)
			Me.radPanelDemoHolder.TabIndex = 2
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radPanelDemoHolder)
			Me.MaximumSize = New System.Drawing.Size(1280, 994)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1224, 737)
			Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region


		Private radMenu1 As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_11 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_12 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_13 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_14 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_11 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_12 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_13 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_14 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_15 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_16 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_10 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_11 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem6_12 As Telerik.WinControls.UI.RadMenuItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private radMenuItemSrc_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItemSrc_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItemSrc_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem3 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem4 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem5 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem6 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem8 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem9 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem10 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem7 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace