Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.MenuStrip.MenuItemsWithImages
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
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuSeparatorItem8 = New Telerik.WinControls.UI.RadMenuSeparatorItem()
			Me.radMenuItem2_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3_4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4_3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.imageList1.Images.SetKeyName(6, "System.Windows.Forms.ContextMenu.bmp")
			Me.imageList1.Images.SetKeyName(7, "System.Windows.Forms.CheckedListBox.bmp")
			Me.imageList1.Images.SetKeyName(8, "System.Windows.Forms.ColorDialog.bmp")
			Me.imageList1.Images.SetKeyName(9, "System.Windows.Forms.ComboBox.bmp")
			Me.imageList1.Images.SetKeyName(10, "icon1.png")
			Me.imageList1.Images.SetKeyName(11, "icon2.png")
			Me.imageList1.Images.SetKeyName(12, "icon3.png")
			Me.imageList1.Images.SetKeyName(13, "icon4.png")
			' 
			' radMenuDemo
			' 
			Me.radMenuDemo.AllItemsEqualHeight = True
			Me.radMenuDemo.AllowMerge = False
			Me.radMenuDemo.BackColor = System.Drawing.Color.Transparent
			Me.radMenuDemo.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.ImageList = Me.imageList1
			Me.radMenuDemo.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem3, Me.radMenuItem4})
			Me.radMenuDemo.Location = New System.Drawing.Point(1, 1)
			Me.radMenuDemo.Name = "radMenuDemo"
			' 
			' 
			' 
			Me.radMenuDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radMenuDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radMenuDemo.RootElement.ToolTipText = Nothing
			Me.radMenuDemo.Size = New System.Drawing.Size(499, 80)
			Me.radMenuDemo.TabIndex = 0
			Me.radMenuDemo.Text = "radMenu1"
			Me.radMenuDemo.ThemeName = "ControlDefault"
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem1.Image = (CType(resources.GetObject("radMenuItem1.Image"), System.Drawing.Image))
			Me.radMenuItem1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radMenuItem1.ImageIndex = 10
			Me.radMenuItem1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1_1, Me.radMenuItem1_2, Me.radMenuSeparatorItem1, Me.radMenuItem1_3, Me.radMenuSeparatorItem2, Me.radMenuItem1_4})
			Me.radMenuItem1.MinSize = New System.Drawing.Size(80, 0)
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Padding = New System.Windows.Forms.Padding(2)
			Me.radMenuItem1.ShowArrow = False
			Me.radMenuItem1.Text = "RadCalendar"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radMenuItem1.ToolTipText = Nothing
			' 
			' radMenuItem1_1
			' 
			Me.radMenuItem1_1.MinSize = New System.Drawing.Size(180, 25)
			Me.radMenuItem1_1.Name = "radMenuItem1_1"
			Me.radMenuItem1_1.Text = "Features"
			Me.radMenuItem1_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_1.ToolTipText = Nothing
			' 
			' radMenuItem1_2
			' 
			Me.radMenuItem1_2.Name = "radMenuItem1_2"
			Me.radMenuItem1_2.Text = "Product Overview"
			Me.radMenuItem1_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_2.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem1
			' 
			Me.radMenuSeparatorItem1.AutoSize = False
			Me.radMenuSeparatorItem1.Bounds = New System.Drawing.Rectangle(0, 47, 154, 1)
			Me.radMenuSeparatorItem1.Class = "RadMenuItem"
			Me.radMenuSeparatorItem1.Name = "radMenuSeparatorItem1"
			Me.radMenuSeparatorItem1.PositionOffset = New System.Drawing.SizeF(26F, 0F)
			Me.radMenuSeparatorItem1.ToolTipText = Nothing
			' 
			' radMenuItem1_3
			' 
			Me.radMenuItem1_3.Name = "radMenuItem1_3"
			Me.radMenuItem1_3.Text = "Version History"
			Me.radMenuItem1_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_3.ToolTipText = Nothing
			' 
			' radMenuSeparatorItem2
			' 
			Me.radMenuSeparatorItem2.AutoSize = False
			Me.radMenuSeparatorItem2.Bounds = New System.Drawing.Rectangle(0, 70, 154, 1)
			Me.radMenuSeparatorItem2.Class = "RadMenuItem"
			Me.radMenuSeparatorItem2.Name = "radMenuSeparatorItem2"
			Me.radMenuSeparatorItem2.PositionOffset = New System.Drawing.SizeF(26F, 0F)
			Me.radMenuSeparatorItem2.ToolTipText = Nothing
			' 
			' radMenuItem1_4
			' 
			Me.radMenuItem1_4.Name = "radMenuItem1_4"
			Me.radMenuItem1_4.Text = "Close"
			Me.radMenuItem1_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1_4.ToolTipText = Nothing
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem2.Image = (CType(resources.GetObject("radMenuItem2.Image"), System.Drawing.Image))
			Me.radMenuItem2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radMenuItem2.ImageIndex = 11
			Me.radMenuItem2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem2_1, Me.radMenuItem2_2, Me.radMenuSeparatorItem8, Me.radMenuItem2_3, Me.radMenuItem2_4})
			Me.radMenuItem2.MinSize = New System.Drawing.Size(80, 0)
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Padding = New System.Windows.Forms.Padding(2)
			Me.radMenuItem2.ShowArrow = False
			Me.radMenuItem2.Text = "RadUpload"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radMenuItem2.ToolTipText = Nothing
			' 
			' radMenuItem2_1
			' 
			Me.radMenuItem2_1.Name = "radMenuItem2_1"
			Me.radMenuItem2_1.Text = "Product Overview"
			Me.radMenuItem2_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_1.ToolTipText = Nothing
			' 
			' radMenuItem2_2
			' 
			Me.radMenuItem2_2.Name = "radMenuItem2_2"
			Me.radMenuItem2_2.Text = "Features"
			Me.radMenuItem2_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_2.ToolTipText = Nothing
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
			Me.radMenuItem2_3.Text = "Benefits"
			Me.radMenuItem2_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_3.ToolTipText = Nothing
			' 
			' radMenuItem2_4
			' 
			Me.radMenuItem2_4.Name = "radMenuItem2_4"
			Me.radMenuItem2_4.Text = "Comparison Sheet"
			Me.radMenuItem2_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2_4.ToolTipText = Nothing
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem3.Image = (CType(resources.GetObject("radMenuItem3.Image"), System.Drawing.Image))
			Me.radMenuItem3.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radMenuItem3.ImageIndex = 12
			Me.radMenuItem3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem3_1, Me.radMenuItem3_2, Me.radMenuItem3_3, Me.radMenuItem3_4})
			Me.radMenuItem3.MinSize = New System.Drawing.Size(80, 0)
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Padding = New System.Windows.Forms.Padding(2)
			Me.radMenuItem3.ShowArrow = False
			Me.radMenuItem3.Text = "RadMenu"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radMenuItem3.ToolTipText = Nothing
			' 
			' radMenuItem3_1
			' 
			Me.radMenuItem3_1.Name = "radMenuItem3_1"
			Me.radMenuItem3_1.Text = "Product Overview"
			Me.radMenuItem3_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_1.ToolTipText = Nothing
			' 
			' radMenuItem3_2
			' 
			Me.radMenuItem3_2.Name = "radMenuItem3_2"
			Me.radMenuItem3_2.Text = "Features"
			Me.radMenuItem3_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_2.ToolTipText = Nothing
			' 
			' radMenuItem3_3
			' 
			Me.radMenuItem3_3.Name = "radMenuItem3_3"
			Me.radMenuItem3_3.Text = "Comparison Sheets"
			Me.radMenuItem3_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_3.ToolTipText = Nothing
			' 
			' radMenuItem3_4
			' 
			Me.radMenuItem3_4.Name = "radMenuItem3_4"
			Me.radMenuItem3_4.Text = "Benefits"
			Me.radMenuItem3_4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem3_4.ToolTipText = Nothing
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.ClickMode = Telerik.WinControls.ClickMode.Press
			Me.radMenuItem4.Image = (CType(resources.GetObject("radMenuItem4.Image"), System.Drawing.Image))
			Me.radMenuItem4.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radMenuItem4.ImageIndex = 13
			Me.radMenuItem4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem4_1, Me.radMenuItem4_2, Me.radMenuItem4_3})
			Me.radMenuItem4.MinSize = New System.Drawing.Size(80, 0)
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Padding = New System.Windows.Forms.Padding(2)
			Me.radMenuItem4.ShowArrow = False
			Me.radMenuItem4.Text = "RadGrid"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radMenuItem4.ToolTipText = Nothing
			' 
			' radMenuItem4_1
			' 
			Me.radMenuItem4_1.Name = "radMenuItem4_1"
			Me.radMenuItem4_1.Text = "Product Overview"
			Me.radMenuItem4_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_1.ToolTipText = Nothing
			' 
			' radMenuItem4_2
			' 
			Me.radMenuItem4_2.Name = "radMenuItem4_2"
			Me.radMenuItem4_2.Text = "Features"
			Me.radMenuItem4_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_2.ToolTipText = Nothing
			' 
			' radMenuItem4_3
			' 
			Me.radMenuItem4_3.Name = "radMenuItem4_3"
			Me.radMenuItem4_3.Text = "Comparison Sheet"
			Me.radMenuItem4_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem4_3.ToolTipText = Nothing
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanelDemoHolder.BackColor = System.Drawing.Color.White
			Me.radPanelDemoHolder.Controls.Add(Me.radMenuDemo)
			Me.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(362, 193)
			Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
			Me.radPanelDemoHolder.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.RootElement.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(500, 350)
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
			CType(Me.radMenuDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region


		Private radMenuDemo As Telerik.WinControls.UI.RadMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem1_4 As Telerik.WinControls.UI.RadMenuItem

		Private radMenuItem2_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2_4 As Telerik.WinControls.UI.RadMenuItem

		Private radMenuItem3_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3_4 As Telerik.WinControls.UI.RadMenuItem

		Private radMenuItem4_1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4_3 As Telerik.WinControls.UI.RadMenuItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private radMenuSeparatorItem1 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem2 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radMenuSeparatorItem8 As Telerik.WinControls.UI.RadMenuSeparatorItem
		Private radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace