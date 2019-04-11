Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.MenuStrip.MenuItemWithCustomElement
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
			Me.radMenuDemo = New Telerik.WinControls.UI.RadMenu()
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
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
            Me.radMenuComboItem1 = New Telerik.WinControls.UI.RadMenuComboItem()
            Me.radComboBoxItem1 = New Telerik.WinControls.UI.RadListDataItem()
            Me.radComboBoxItem2 = New Telerik.WinControls.UI.RadListDataItem()
            Me.radComboBoxItem3 = New Telerik.WinControls.UI.RadListDataItem()
            Me.radComboBoxItem4 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radMenuComboItem2 = New Telerik.WinControls.UI.RadMenuComboItem()
            Me.radComboBoxItem5 = New Telerik.WinControls.UI.RadListDataItem()
            Me.radComboBoxItem6 = New Telerik.WinControls.UI.RadListDataItem()
            Me.radComboBoxItem7 = New Telerik.WinControls.UI.RadListDataItem()
            Me.radComboBoxItem8 = New Telerik.WinControls.UI.RadListDataItem()
			Me.radMenuSeparatorItem8 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem2_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_6 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_7 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem9 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem2_8 = New Telerik.WinControls.UI.RadMenuItem()
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
			Me.radMenuItem3_11 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_12 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_13 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_14 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_15 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_16 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_17 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_18 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_19 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_20 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_21 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_3 = New Telerik.WinControls.UI.RadMenuItem()
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
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenuComboItem1.ComboBoxElement, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenuComboItem2.ComboBoxElement, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
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
			' radMenuDemo
			' 
			Me.radMenuDemo.AllowMerge = False
			Me.radMenuDemo.BackColor = System.Drawing.Color.Transparent
			Me.radMenuDemo.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.ImageList = Me.imageList1
			Me.radMenuDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2})
			Me.radMenuDemo.Location = New System.Drawing.Point(1, 1)
			Me.radMenuDemo.Name = "radMenuDemo"
			Me.radMenuDemo.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			' 
			' 
			' 
			Me.radMenuDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenuDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.RootElement.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			Me.radMenuDemo.RootElement.ToolTipText = Nothing
			Me.radMenuDemo.Size = New System.Drawing.Size(499, 29)
			Me.radMenuDemo.TabIndex = 0
			Me.radMenuDemo.Text = "radMenu1"
			Me.radMenuDemo.ThemeName = "ControlDefault"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1_1, Me.radMenuItem1_2, Me.radMenuSeparatorItem1, Me.radMenuItem1_3, Me.radMenuSeparatorItem2, Me.radMenuItem1_4, Me.radMenuItem1_5, Me.radMenuSeparatorItem3, Me.radMenuItem1_6, Me.radMenuItem1_7, Me.radMenuItem1_8, Me.radMenuSeparatorItem4, Me.radMenuItem1_9, Me.radMenuSeparatorItem5})
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.PopupDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radMenuItem1.ShowArrow = False
			Me.radMenuItem1.Text = "Menu with nested controls"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.ToolTipText = Nothing
			' 
			' radMenuItem1_1
			' 
			Me.radMenuItem1_1.Name = "radMenuItem1_1"
			Me.radMenuItem1_1.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem1_1.Text = "New"
			Me.radMenuItem1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_1.ToolTipText = Nothing
			' 
			' radMenuItem1_2
			' 
			Me.radMenuItem1_2.Name = "radMenuItem1_2"
			Me.radMenuItem1_2.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem1_2.Text = "Open"
			Me.radMenuItem1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_2.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.Class = "RadMenuItem"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.ToolTipText = Nothing
			' 
			' radMenuItem1_3
			' 
			Me.radMenuItem1_3.Name = "radMenuItem1_3"
			Me.radMenuItem1_3.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem1_3.Text = "Add"
			Me.radMenuItem1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_3.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.Class = "RadMenuItem"
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.ToolTipText = Nothing
			' 
			' radMenuItem1_4
			' 
			Me.radMenuItem1_4.Image = (CType(resources.GetObject("radMenuItem1_4.Image"), System.Drawing.Image))
			Me.radMenuItem1_4.ImageIndex = 0
			Me.radMenuItem1_4.Name = "radMenuItem1_4"
			Me.radMenuItem1_4.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem1_4.Text = "Close"
			Me.radMenuItem1_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_4.ToolTipText = Nothing
			' 
			' radMenuItem1_5
			' 
			Me.radMenuItem1_5.Image = (CType(resources.GetObject("radMenuItem1_5.Image"), System.Drawing.Image))
			Me.radMenuItem1_5.ImageIndex = 5
			Me.radMenuItem1_5.Name = "radMenuItem1_5"
			Me.radMenuItem1_5.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem1_5.Text = "Close Solution"
			Me.radMenuItem1_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_5.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem3
			' 
			Me.radMenuSeparatorItem3.Class = "RadMenuItem"
			Me.radMenuSeparatorItem3.Name = "radMenuSeparatorItem3"
			Me.radMenuSeparatorItem3.ToolTipText = Nothing
			' 
			' radMenuItem1_6
			' 
			Me.radMenuItem1_6.Name = "radMenuItem1_6"
			Me.radMenuItem1_6.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem1_6.Text = "Advanced Save Options..."
			Me.radMenuItem1_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_6.ToolTipText = Nothing
			' 
			' radMenuItem1_7
			' 
			Me.radMenuItem1_7.Image = (CType(resources.GetObject("radMenuItem1_7.Image"), System.Drawing.Image))
			Me.radMenuItem1_7.ImageIndex = 0
			Me.radMenuItem1_7.Name = "radMenuItem1_7"
			Me.radMenuItem1_7.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem1_7.Text = "Save All"
			Me.radMenuItem1_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_7.ToolTipText = Nothing
			' 
			' radMenuItem1_8
			' 
			Me.radMenuItem1_8.Name = "radMenuItem1_8"
			Me.radMenuItem1_8.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem1_8.Text = "Export Template..."
			Me.radMenuItem1_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_8.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem4
			' 
			Me.radMenuSeparatorItem4.Class = "RadMenuItem"
			Me.radMenuSeparatorItem4.Name = "radMenuSeparatorItem4"
			Me.radMenuSeparatorItem4.ToolTipText = Nothing
			' 
			' radMenuItem1_9
			' 
			Me.radMenuItem1_9.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItemSrc_1, Me.radMenuItemSrc_2, Me.radMenuItemSrc_3})
			Me.radMenuItem1_9.Name = "radMenuItem1_9"
			Me.radMenuItem1_9.PopupDirection = Telerik.WinControls.UI.RadDirection.Right
			Me.radMenuItem1_9.Text = "Source Control"
			Me.radMenuItem1_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_9.ToolTipText = Nothing
			' 
			' radMenuItemSrc_1
			' 
			Me.radMenuItemSrc_1.Name = "radMenuItemSrc_1"
			Me.radMenuItemSrc_1.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItemSrc_1.Text = "View History"
			Me.radMenuItemSrc_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItemSrc_1.ToolTipText = Nothing
			' 
			' radMenuItemSrc_2
			' 
			Me.radMenuItemSrc_2.Name = "radMenuItemSrc_2"
			Me.radMenuItemSrc_2.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItemSrc_2.Text = "Refresh Status"
			Me.radMenuItemSrc_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItemSrc_2.ToolTipText = Nothing
			' 
			' radMenuItemSrc_3
			' 
			Me.radMenuItemSrc_3.Name = "radMenuItemSrc_3"
			Me.radMenuItemSrc_3.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItemSrc_3.Text = "Compare..."
			Me.radMenuItemSrc_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItemSrc_3.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem5
			' 
			Me.radMenuSeparatorItem5.Class = "RadMenuItem"
			Me.radMenuSeparatorItem5.Name = "radMenuSeparatorItem5"
			Me.radMenuSeparatorItem5.ToolTipText = Nothing
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.ClickMode = Telerik.WinControls.ClickMode.Press
            Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.radMenuComboItem1, Me.radMenuComboItem2, Me.radMenuSeparatorItem8, Me.radMenuItem2_3, Me.radMenuItem2_4, Me.radMenuItem2_5, Me.radMenuItem2_6, Me.radMenuItem2_7, Me.radMenuSeparatorItem9, Me.radMenuItem2_8})
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.PopupDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radMenuItem2.ShowArrow = False
			Me.radMenuItem2.Text = "Menu with embedded controls"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.ToolTipText = Nothing
			' 
			' radMenuComboItem1
			' 
			Me.radMenuComboItem1.Class = "RadMenuItem"
			' 
			' 
			' 
			Me.radMenuComboItem1.ComboBoxElement.ArrowButtonMinWidth = 16
			Me.radMenuComboItem1.ComboBoxElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.radMenuComboItem1.ComboBoxElement.DefaultValue = Nothing
			Me.radMenuComboItem1.ComboBoxElement.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radMenuComboItem1.ComboBoxElement.EditorElement = Me.radMenuComboItem1.ComboBoxElement
			Me.radMenuComboItem1.ComboBoxElement.EditorManager = Nothing
			Me.radMenuComboItem1.ComboBoxElement.Focusable = True
			Me.radMenuComboItem1.ComboBoxElement.MaxValue = Nothing
			Me.radMenuComboItem1.ComboBoxElement.MinSize = New System.Drawing.Size(100, 20)
			Me.radMenuComboItem1.ComboBoxElement.MinValue = Nothing
			Me.radMenuComboItem1.ComboBoxElement.NullText = "Undo"
			Me.radMenuComboItem1.ComboBoxElement.NullTextColor = System.Drawing.SystemColors.GrayText
			Me.radMenuComboItem1.ComboBoxElement.NullValue = Nothing
			Me.radMenuComboItem1.ComboBoxElement.OwnerOffset = 0
			Me.radMenuComboItem1.ComboBoxElement.Value = Nothing
            Me.radMenuComboItem1.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() {Me.radComboBoxItem1, Me.radComboBoxItem2, Me.radComboBoxItem3, Me.radComboBoxItem4})
			Me.radMenuComboItem1.Name = "radMenuComboItem1"
            ' 
			' radComboBoxItem1
			' 
            Me.radComboBoxItem1.Text = "Copy text"
            ' 
			' radComboBoxItem2
			' 
            Me.radComboBoxItem2.Text = "Type ""This is my.."""
            ' 
			' radComboBoxItem3
			' 
            Me.radComboBoxItem3.Text = "Font color"
            ' 
			' radComboBoxItem4
			' 
            Me.radComboBoxItem4.Text = "Font size"
            ' 
			' radMenuComboItem2
			' 
			Me.radMenuComboItem2.Class = "RadMenuItem"
			' 
			' 
			' 
			Me.radMenuComboItem2.ComboBoxElement.ArrowButtonMinWidth = 16
			Me.radMenuComboItem2.ComboBoxElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.FitToAvailableSize
			Me.radMenuComboItem2.ComboBoxElement.DefaultValue = Nothing
			Me.radMenuComboItem2.ComboBoxElement.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radMenuComboItem2.ComboBoxElement.EditorElement = Me.radMenuComboItem2.ComboBoxElement
			Me.radMenuComboItem2.ComboBoxElement.EditorManager = Nothing
			Me.radMenuComboItem2.ComboBoxElement.Focusable = True
			Me.radMenuComboItem2.ComboBoxElement.MaxValue = Nothing
			Me.radMenuComboItem2.ComboBoxElement.MinSize = New System.Drawing.Size(100, 20)
			Me.radMenuComboItem2.ComboBoxElement.MinValue = Nothing
			Me.radMenuComboItem2.ComboBoxElement.NullText = "Redo"
			Me.radMenuComboItem2.ComboBoxElement.NullTextColor = System.Drawing.SystemColors.GrayText
			Me.radMenuComboItem2.ComboBoxElement.NullValue = Nothing
			Me.radMenuComboItem2.ComboBoxElement.OwnerOffset = 0
			Me.radMenuComboItem2.ComboBoxElement.Value = Nothing
            Me.radMenuComboItem2.Items.AddRange(New Telerik.WinControls.UI.RadListDataItem() {Me.radComboBoxItem5, Me.radComboBoxItem6, Me.radComboBoxItem7, Me.radComboBoxItem8})
			Me.radMenuComboItem2.Name = "radMenuComboItem2"
            ' 
			' radComboBoxItem5
			' 
            Me.radComboBoxItem5.Text = "Format paragraph"
            ' 
			' radComboBoxItem6
			' 
            Me.radComboBoxItem6.Text = "Ordered list"
            ' 
			' radComboBoxItem7
			' 
            Me.radComboBoxItem7.Text = "Page Break"
            ' 
			' radComboBoxItem8
			' 
            Me.radComboBoxItem8.Text = "Rotate"
            ' 
			' radMenuSeparatorItem8
			' 
			Me.radMenuSeparatorItem8.Class = "RadMenuItem"
			Me.radMenuSeparatorItem8.Name = "radMenuSeparatorItem8"
			Me.radMenuSeparatorItem8.ToolTipText = Nothing
			' 
			' radMenuItem2_3
			' 
			Me.radMenuItem2_3.Name = "radMenuItem2_3"
			Me.radMenuItem2_3.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem2_3.Text = "Cut"
			Me.radMenuItem2_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_3.ToolTipText = Nothing
			' 
			' radMenuItem2_4
			' 
			Me.radMenuItem2_4.Name = "radMenuItem2_4"
			Me.radMenuItem2_4.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem2_4.Text = "Copy"
			Me.radMenuItem2_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_4.ToolTipText = Nothing
			' 
			' radMenuItem2_5
			' 
			Me.radMenuItem2_5.Name = "radMenuItem2_5"
			Me.radMenuItem2_5.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem2_5.Text = "Paste"
			Me.radMenuItem2_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_5.ToolTipText = Nothing
			' 
			' radMenuItem2_6
			' 
			Me.radMenuItem2_6.Name = "radMenuItem2_6"
			Me.radMenuItem2_6.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem2_6.Text = "Cycle Clipboard Ring"
			Me.radMenuItem2_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_6.ToolTipText = Nothing
			' 
			' radMenuItem2_7
			' 
			Me.radMenuItem2_7.Name = "radMenuItem2_7"
			Me.radMenuItem2_7.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem2_7.Text = "Delete"
			Me.radMenuItem2_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_7.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem9
			' 
			Me.radMenuSeparatorItem9.Class = "RadMenuItem"
			Me.radMenuSeparatorItem9.Name = "radMenuSeparatorItem9"
			Me.radMenuSeparatorItem9.ToolTipText = Nothing
			' 
			' radMenuItem2_8
			' 
			Me.radMenuItem2_8.Name = "radMenuItem2_8"
			Me.radMenuItem2_8.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem2_8.Text = "Select All"
			Me.radMenuItem2_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_8.ToolTipText = Nothing
			' 
			' radMenuItem3_1
			' 
			Me.radMenuItem3_1.Name = "radMenuItem3_1"
			Me.radMenuItem3_1.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_1.Text = "Code"
			Me.radMenuItem3_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_1.ToolTipText = Nothing
			' 
			' radMenuItem3_2
			' 
			Me.radMenuItem3_2.Name = "radMenuItem3_2"
			Me.radMenuItem3_2.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_2.Text = "Open"
			Me.radMenuItem3_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_2.ToolTipText = Nothing
			' 
			' radMenuItem3_3
			' 
			Me.radMenuItem3_3.Name = "radMenuItem3_3"
			Me.radMenuItem3_3.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_3.Text = "Open With..."
			Me.radMenuItem3_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_3.ToolTipText = Nothing
			' 
			' radMenuItem3_4
			' 
			Me.radMenuItem3_4.Name = "radMenuItem3_4"
			Me.radMenuItem3_4.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_4.Text = "Server Explorer"
			Me.radMenuItem3_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_4.ToolTipText = Nothing
			' 
			' radMenuItem3_5
			' 
			Me.radMenuItem3_5.Name = "radMenuItem3_5"
			Me.radMenuItem3_5.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_5.Text = "Solution Explorer"
			Me.radMenuItem3_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_5.ToolTipText = Nothing
			' 
			' radMenuItem3_6
			' 
			Me.radMenuItem3_6.Name = "radMenuItem3_6"
			Me.radMenuItem3_6.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_6.Text = "Bookmark Window"
			Me.radMenuItem3_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_6.ToolTipText = Nothing
			' 
			' radMenuItem3_7
			' 
			Me.radMenuItem3_7.Name = "radMenuItem3_7"
			Me.radMenuItem3_7.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_7.Text = "Class View"
			Me.radMenuItem3_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_7.ToolTipText = Nothing
			' 
			' radMenuItem3_8
			' 
			Me.radMenuItem3_8.Name = "radMenuItem3_8"
			Me.radMenuItem3_8.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_8.Text = "Code Definition Window"
			Me.radMenuItem3_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_8.ToolTipText = Nothing
			' 
			' radMenuItem3_9
			' 
			Me.radMenuItem3_9.Name = "radMenuItem3_9"
			Me.radMenuItem3_9.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_9.Text = "Object Browser"
			Me.radMenuItem3_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_9.ToolTipText = Nothing
			' 
			' radMenuItem3_10
			' 
			Me.radMenuItem3_10.Name = "radMenuItem3_10"
			Me.radMenuItem3_10.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_10.Text = "Error List"
			Me.radMenuItem3_10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_10.ToolTipText = Nothing
			' 
			' radMenuItem3_11
			' 
			Me.radMenuItem3_11.Name = "radMenuItem3_11"
			Me.radMenuItem3_11.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_11.Text = "Output"
			Me.radMenuItem3_11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_11.ToolTipText = Nothing
			' 
			' radMenuItem3_12
			' 
			Me.radMenuItem3_12.Name = "radMenuItem3_12"
			Me.radMenuItem3_12.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_12.Text = "Properties Window"
			Me.radMenuItem3_12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_12.ToolTipText = Nothing
			' 
			' radMenuItem3_13
			' 
			Me.radMenuItem3_13.Name = "radMenuItem3_13"
			Me.radMenuItem3_13.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_13.Text = "Task List"
			Me.radMenuItem3_13.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_13.ToolTipText = Nothing
			' 
			' radMenuItem3_14
			' 
			Me.radMenuItem3_14.Name = "radMenuItem3_14"
			Me.radMenuItem3_14.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_14.Text = "Toolbox"
			Me.radMenuItem3_14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_14.ToolTipText = Nothing
			' 
			' radMenuItem3_15
			' 
			Me.radMenuItem3_15.Name = "radMenuItem3_15"
			Me.radMenuItem3_15.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_15.Text = "Find Results"
			Me.radMenuItem3_15.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_15.ToolTipText = Nothing
			' 
			' radMenuItem3_16
			' 
			Me.radMenuItem3_16.Name = "radMenuItem3_16"
			Me.radMenuItem3_16.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_16.Text = "Other Windows"
			Me.radMenuItem3_16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_16.ToolTipText = Nothing
			' 
			' radMenuItem3_17
			' 
			Me.radMenuItem3_17.Name = "radMenuItem3_17"
			Me.radMenuItem3_17.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_17.Text = "Toolbars"
			Me.radMenuItem3_17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_17.ToolTipText = Nothing
			' 
			' radMenuItem3_18
			' 
			Me.radMenuItem3_18.Name = "radMenuItem3_18"
			Me.radMenuItem3_18.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_18.Text = "Full Screen"
			Me.radMenuItem3_18.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_18.ToolTipText = Nothing
			' 
			' radMenuItem3_19
			' 
			Me.radMenuItem3_19.Name = "radMenuItem3_19"
			Me.radMenuItem3_19.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_19.Text = "Pending Checkins"
			Me.radMenuItem3_19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_19.ToolTipText = Nothing
			' 
			' radMenuItem3_20
			' 
			Me.radMenuItem3_20.Name = "radMenuItem3_20"
			Me.radMenuItem3_20.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_20.Text = "Navigate Backward"
			Me.radMenuItem3_20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_20.ToolTipText = Nothing
			' 
			' radMenuItem3_21
			' 
			Me.radMenuItem3_21.Name = "radMenuItem3_21"
			Me.radMenuItem3_21.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem3_21.Text = "Navigate Forward"
			Me.radMenuItem3_21.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_21.ToolTipText = Nothing
			' 
			' radMenuItem4_1
			' 
			Me.radMenuItem4_1.Name = "radMenuItem4_1"
			Me.radMenuItem4_1.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem4_1.Text = "Build Solution"
			Me.radMenuItem4_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_1.ToolTipText = Nothing
			' 
			' radMenuItem4_2
			' 
			Me.radMenuItem4_2.Name = "radMenuItem4_2"
			Me.radMenuItem4_2.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem4_2.Text = "Build Examples"
			Me.radMenuItem4_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_2.ToolTipText = Nothing
			' 
			' radMenuItem4_3
			' 
			Me.radMenuItem4_3.Name = "radMenuItem4_3"
			Me.radMenuItem4_3.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem4_3.Text = "Publish Examples"
			Me.radMenuItem4_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_3.ToolTipText = Nothing
			' 
			' radMenuItem5_1
			' 
			Me.radMenuItem5_1.Name = "radMenuItem5_1"
			Me.radMenuItem5_1.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem5_1.Text = "Show Data Sources"
			Me.radMenuItem5_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_1.ToolTipText = Nothing
			' 
			' radMenuItem5_2
			' 
			Me.radMenuItem5_2.Name = "radMenuItem5_2"
			Me.radMenuItem5_2.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem5_2.Text = "Add New Data Source..."
			Me.radMenuItem5_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem5_2.ToolTipText = Nothing
			' 
			' radMenuItem6_1
			' 
			Me.radMenuItem6_1.Name = "radMenuItem6_1"
			Me.radMenuItem6_1.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_1.Text = "How Do I"
			Me.radMenuItem6_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_1.ToolTipText = Nothing
			' 
			' radMenuItem6_2
			' 
			Me.radMenuItem6_2.Name = "radMenuItem6_2"
			Me.radMenuItem6_2.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_2.Text = "Search"
			Me.radMenuItem6_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_2.ToolTipText = Nothing
			' 
			' radMenuItem6_3
			' 
			Me.radMenuItem6_3.Name = "radMenuItem6_3"
			Me.radMenuItem6_3.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_3.Text = "Contents"
			Me.radMenuItem6_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_3.ToolTipText = Nothing
			' 
			' radMenuItem6_4
			' 
			Me.radMenuItem6_4.Name = "radMenuItem6_4"
			Me.radMenuItem6_4.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_4.Text = "Index"
			Me.radMenuItem6_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_4.ToolTipText = Nothing
			' 
			' radMenuItem6_5
			' 
			Me.radMenuItem6_5.Name = "radMenuItem6_5"
			Me.radMenuItem6_5.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_5.Text = "Help Favorites"
			Me.radMenuItem6_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_5.ToolTipText = Nothing
			' 
			' radMenuItem6_6
			' 
			Me.radMenuItem6_6.Name = "radMenuItem6_6"
			Me.radMenuItem6_6.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_6.Text = "Dynamic Help"
			Me.radMenuItem6_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_6.ToolTipText = Nothing
			' 
			' radMenuItem6_7
			' 
			Me.radMenuItem6_7.Name = "radMenuItem6_7"
			Me.radMenuItem6_7.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_7.Text = "Index Results"
			Me.radMenuItem6_7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_7.ToolTipText = Nothing
			' 
			' radMenuItem6_8
			' 
			Me.radMenuItem6_8.Name = "radMenuItem6_8"
			Me.radMenuItem6_8.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_8.Text = "Customer Feedback Options..."
			Me.radMenuItem6_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_8.ToolTipText = Nothing
			' 
			' radMenuItem6_9
			' 
			Me.radMenuItem6_9.Name = "radMenuItem6_9"
			Me.radMenuItem6_9.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_9.Text = "Register Product..."
			Me.radMenuItem6_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_9.ToolTipText = Nothing
			' 
			' radMenuItem6_10
			' 
			Me.radMenuItem6_10.Name = "radMenuItem6_10"
			Me.radMenuItem6_10.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_10.Text = "Check for Update"
			Me.radMenuItem6_10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_10.ToolTipText = Nothing
			' 
			' radMenuItem6_11
			' 
			Me.radMenuItem6_11.Name = "radMenuItem6_11"
			Me.radMenuItem6_11.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_11.Text = "Technical Support"
			Me.radMenuItem6_11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_11.ToolTipText = Nothing
			' 
			' radMenuItem6_12
			' 
			Me.radMenuItem6_12.Name = "radMenuItem6_12"
			Me.radMenuItem6_12.PopupDirection = Telerik.WinControls.UI.RadDirection.Left
			Me.radMenuItem6_12.Text = "About Telerik WinControls Suite..."
			Me.radMenuItem6_12.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem6_12.ToolTipText = Nothing
			' 
			' radPanel1
			' 
			Me.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanel1.BackColor = System.Drawing.Color.White
			Me.radPanel1.Controls.Add(Me.radMenuDemo)
			Me.radPanel1.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Location = New System.Drawing.Point(362, 193)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.RootElement.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			Me.radPanel1.Size = New System.Drawing.Size(500, 350)
			Me.radPanel1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 737)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenuComboItem1.ComboBoxElement, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radMenuComboItem2.ComboBoxElement, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			Me.radPanel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region


		Private radMenuDemo As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_8 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_9 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_5 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_6 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_7 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_8 As Telerik.WinControls.UI.RadMenuItem
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
		Private radMenuItem3_11 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_12 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_13 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_14 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_15 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_16 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_17 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_18 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_19 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_20 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_21 As Telerik.WinControls.UI.RadMenuItem
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
		Private radMenuSeparatorItem8 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem9 As Telerik.WinControls.UI.RadMenuSeparatorItem
        Private radMenuComboItem1 As Telerik.WinControls.UI.RadMenuComboItem
        Private radComboBoxItem1 As Telerik.WinControls.UI.RadListDataItem
        Private radComboBoxItem2 As Telerik.WinControls.UI.RadListDataItem
        Private radComboBoxItem3 As Telerik.WinControls.UI.RadListDataItem
        Private radComboBoxItem4 As Telerik.WinControls.UI.RadListDataItem
		Private radMenuComboItem2 As Telerik.WinControls.UI.RadMenuComboItem
        Private radComboBoxItem5 As Telerik.WinControls.UI.RadListDataItem
        Private radComboBoxItem6 As Telerik.WinControls.UI.RadListDataItem
        Private radComboBoxItem7 As Telerik.WinControls.UI.RadListDataItem
        Private radComboBoxItem8 As Telerik.WinControls.UI.RadListDataItem
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace