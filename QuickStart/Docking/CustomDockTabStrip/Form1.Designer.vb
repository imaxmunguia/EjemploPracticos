Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Docking.CustomDockTabStrip
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
			Me.documentWindow2 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.toolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.docTabAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.toolTabAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.docTabsVisibleCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.toolTabsVisibleCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.docCloseButtonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.docTextOrientationCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.toolCloseButtonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.toolTextOrientationCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radDock1.SuspendLayout()
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer2.SuspendLayout()
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1.SuspendLayout()
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip1.SuspendLayout()
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentContainer1.SuspendLayout()
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.documentTabStrip1.SuspendLayout()
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip2.SuspendLayout()
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.toolTabStrip3.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docTabAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTabAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docTabsVisibleCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTabsVisibleCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.docCloseButtonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.docTextOrientationCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.toolCloseButtonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.toolTextOrientationCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(552, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 806)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.documentWindow2
			Me.radDock1.Controls.Add(Me.radSplitContainer2)
			Me.radDock1.Controls.Add(Me.toolTabStrip3)
			Me.radDock1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radDock1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radDock1.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront
			Me.radDock1.Location = New System.Drawing.Point(0, 0)
			Me.radDock1.MainDocumentContainer = Me.documentContainer1
			Me.radDock1.Name = "radDock1"
			' 
			' 
			' 
			Me.radDock1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radDock1.Size = New System.Drawing.Size(753, 808)
			Me.radDock1.TabIndex = 1
			Me.radDock1.TabStop = False
			Me.radDock1.Text = "radDock1"
			' 
			' documentWindow2
			' 
			Me.documentWindow2.Location = New System.Drawing.Point(5, 27)
			Me.documentWindow2.Name = "documentWindow2"
			Me.documentWindow2.Size = New System.Drawing.Size(337, 573)
			Me.documentWindow2.Text = "documentWindow2"
			' 
			' radSplitContainer2
			' 
			Me.radSplitContainer2.Controls.Add(Me.radSplitContainer1)
			Me.radSplitContainer2.Controls.Add(Me.toolTabStrip2)
			Me.radSplitContainer2.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radSplitContainer2.IsCleanUpTarget = True
			Me.radSplitContainer2.Location = New System.Drawing.Point(0, 0)
			Me.radSplitContainer2.Name = "radSplitContainer2"
			Me.radSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' 
			' 
			Me.radSplitContainer2.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radSplitContainer2.Size = New System.Drawing.Size(550, 808)
			Me.radSplitContainer2.TabIndex = 0
			Me.radSplitContainer2.TabStop = False
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip1)
			Me.radSplitContainer1.Controls.Add(Me.documentContainer1)
			Me.radSplitContainer1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radSplitContainer1.Size = New System.Drawing.Size(550, 605)
			Me.radSplitContainer1.TabIndex = 0
			Me.radSplitContainer1.TabStop = False
			' 
			' toolTabStrip1
			' 
			Me.toolTabStrip1.Controls.Add(Me.toolWindow1)
			Me.toolTabStrip1.Location = New System.Drawing.Point(0, 0)
			Me.toolTabStrip1.Name = "toolTabStrip1"
			' 
			' 
			' 
			Me.toolTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.toolTabStrip1.SelectedIndex = 0
			Me.toolTabStrip1.Size = New System.Drawing.Size(200, 605)
			Me.toolTabStrip1.TabIndex = 1
			Me.toolTabStrip1.TabStop = False
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Location = New System.Drawing.Point(1, 26)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.Size = New System.Drawing.Size(198, 578)
			Me.toolWindow1.Text = "toolWindow1"
			' 
			' documentContainer1
			' 
			Me.documentContainer1.Controls.Add(Me.documentTabStrip1)
			Me.documentContainer1.Location = New System.Drawing.Point(203, 0)
			Me.documentContainer1.Name = "documentContainer1"
			' 
			' 
			' 
			Me.documentContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.documentContainer1.Size = New System.Drawing.Size(347, 605)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.TabIndex = 0
			Me.documentContainer1.TabStop = False
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.Controls.Add(Me.documentWindow2)
			Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip1.Location = New System.Drawing.Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New System.Drawing.Size(347, 605)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Location = New System.Drawing.Point(5, 27)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.Size = New System.Drawing.Size(549, 296)
			Me.documentWindow1.Text = "documentWindow1"
			' 
			' toolTabStrip2
			' 
			Me.toolTabStrip2.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip2.Location = New System.Drawing.Point(0, 608)
			Me.toolTabStrip2.Name = "toolTabStrip2"
			' 
			' 
			' 
			Me.toolTabStrip2.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.toolTabStrip2.SelectedIndex = 0
			Me.toolTabStrip2.Size = New System.Drawing.Size(550, 200)
			Me.toolTabStrip2.TabIndex = 1
			Me.toolTabStrip2.TabStop = False
			' 
			' toolWindow2
			' 
			Me.toolWindow2.Location = New System.Drawing.Point(1, 26)
			Me.toolWindow2.Name = "toolWindow2"
			Me.toolWindow2.Size = New System.Drawing.Size(548, 173)
			Me.toolWindow2.Text = "toolWindow2"
			' 
			' toolTabStrip3
			' 
			Me.toolTabStrip3.Controls.Add(Me.toolWindow3)
			Me.toolTabStrip3.Location = New System.Drawing.Point(553, 0)
			Me.toolTabStrip3.Name = "toolTabStrip3"
			' 
			' 
			' 
			Me.toolTabStrip3.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.toolTabStrip3.SelectedIndex = 0
			Me.toolTabStrip3.Size = New System.Drawing.Size(200, 808)
			Me.toolTabStrip3.TabIndex = 1
			Me.toolTabStrip3.TabStop = False
			' 
			' toolWindow3
			' 
			Me.toolWindow3.Location = New System.Drawing.Point(1, 26)
			Me.toolWindow3.Name = "toolWindow3"
			Me.toolWindow3.Size = New System.Drawing.Size(198, 781)
			Me.toolWindow3.Text = "toolWindow3"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(13, 23)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(60, 16)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "Alignment:"
			' 
			' docTabAlignCombo
			' 
			Me.docTabAlignCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.docTabAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.docTabAlignCombo.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.docTabAlignCombo.FormatString = "{0}"
			Me.docTabAlignCombo.Location = New System.Drawing.Point(13, 43)
			Me.docTabAlignCombo.Name = "docTabAlignCombo"
			' 
			' 
			' 
			Me.docTabAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.docTabAlignCombo.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.docTabAlignCombo.Size = New System.Drawing.Size(154, 20)
			Me.docTabAlignCombo.TabIndex = 2
			Me.docTabAlignCombo.TabStop = False
			Me.docTabAlignCombo.Text = "radComboBox1"
'			Me.docTabAlignCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(docTabAlignCombo_SelectedIndexChanged);
			' 
			' toolTabAlignCombo
			' 
			Me.toolTabAlignCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.toolTabAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.toolTabAlignCombo.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.toolTabAlignCombo.FormatString = "{0}"
			Me.toolTabAlignCombo.Location = New System.Drawing.Point(13, 43)
			Me.toolTabAlignCombo.Name = "toolTabAlignCombo"
			' 
			' 
			' 
			Me.toolTabAlignCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.toolTabAlignCombo.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.toolTabAlignCombo.Size = New System.Drawing.Size(154, 20)
			Me.toolTabAlignCombo.TabIndex = 4
			Me.toolTabAlignCombo.TabStop = False
			Me.toolTabAlignCombo.Text = "radComboBox1"
'			Me.toolTabAlignCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.toolTabAlignCombo_SelectedIndexChanged);
			' 
			' docTabsVisibleCheck
			' 
			Me.docTabsVisibleCheck.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.docTabsVisibleCheck.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.docTabsVisibleCheck.Location = New System.Drawing.Point(13, 139)
			Me.docTabsVisibleCheck.Name = "docTabsVisibleCheck"
			' 
			' 
			' 
			Me.docTabsVisibleCheck.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.docTabsVisibleCheck.Size = New System.Drawing.Size(154, 18)
			Me.docTabsVisibleCheck.TabIndex = 5
			Me.docTabsVisibleCheck.Text = "Visible"
'			Me.docTabsVisibleCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.docTabsVisibleCheck_ToggleStateChanged);
			' 
			' toolTabsVisibleCheck
			' 
			Me.toolTabsVisibleCheck.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.toolTabsVisibleCheck.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.toolTabsVisibleCheck.Location = New System.Drawing.Point(13, 139)
			Me.toolTabsVisibleCheck.Name = "toolTabsVisibleCheck"
			' 
			' 
			' 
			Me.toolTabsVisibleCheck.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.toolTabsVisibleCheck.Size = New System.Drawing.Size(154, 18)
			Me.toolTabsVisibleCheck.TabIndex = 6
			Me.toolTabsVisibleCheck.Text = "Visible"
'			Me.toolTabsVisibleCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.toolTabsVisibleCheck_ToggleStateChanged);
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.docCloseButtonCheck)
			Me.radGroupBox1.Controls.Add(Me.docTextOrientationCombo)
			Me.radGroupBox1.Controls.Add(Me.radLabel3)
			Me.radGroupBox1.Controls.Add(Me.radLabel1)
			Me.radGroupBox1.Controls.Add(Me.docTabAlignCombo)
			Me.radGroupBox1.Controls.Add(Me.docTabsVisibleCheck)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Document Tabs"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 37)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 167)
			Me.radGroupBox1.TabIndex = 7
			Me.radGroupBox1.Text = "Document Tabs"
			' 
			' docCloseButtonCheck
			' 
			Me.docCloseButtonCheck.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.docCloseButtonCheck.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.docCloseButtonCheck.Location = New System.Drawing.Point(13, 115)
			Me.docCloseButtonCheck.Name = "docCloseButtonCheck"
			' 
			' 
			' 
			Me.docCloseButtonCheck.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.docCloseButtonCheck.Size = New System.Drawing.Size(154, 18)
			Me.docCloseButtonCheck.TabIndex = 8
			Me.docCloseButtonCheck.Text = "Show Close Button"
'			Me.docCloseButtonCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.docCloseButtonCheck_ToggleStateChanged);
			' 
			' docTextOrientationCombo
			' 
			Me.docTextOrientationCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.docTextOrientationCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.docTextOrientationCombo.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.docTextOrientationCombo.FormatString = "{0}"
			Me.docTextOrientationCombo.Location = New System.Drawing.Point(13, 89)
			Me.docTextOrientationCombo.Name = "docTextOrientationCombo"
			' 
			' 
			' 
			Me.docTextOrientationCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.docTextOrientationCombo.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.docTextOrientationCombo.Size = New System.Drawing.Size(154, 20)
			Me.docTextOrientationCombo.TabIndex = 7
			Me.docTextOrientationCombo.TabStop = False
			Me.docTextOrientationCombo.Text = "radComboBox1"
'			Me.docTextOrientationCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.docTextOrientationCombo_SelectedIndexChanged);
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel3.Location = New System.Drawing.Point(13, 69)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(90, 16)
			Me.radLabel3.TabIndex = 6
			Me.radLabel3.Text = "Text Orientation:"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.toolCloseButtonCheck)
			Me.radGroupBox2.Controls.Add(Me.toolTextOrientationCombo)
			Me.radGroupBox2.Controls.Add(Me.radLabel4)
			Me.radGroupBox2.Controls.Add(Me.toolTabsVisibleCheck)
			Me.radGroupBox2.Controls.Add(Me.radLabel5)
			Me.radGroupBox2.Controls.Add(Me.toolTabAlignCombo)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Tool Tabs"
			Me.radGroupBox2.Location = New System.Drawing.Point(10, 210)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(180, 167)
			Me.radGroupBox2.TabIndex = 8
			Me.radGroupBox2.Text = "Tool Tabs"
			' 
			' toolCloseButtonCheck
			' 
			Me.toolCloseButtonCheck.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.toolCloseButtonCheck.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.toolCloseButtonCheck.Location = New System.Drawing.Point(13, 115)
			Me.toolCloseButtonCheck.Name = "toolCloseButtonCheck"
			' 
			' 
			' 
			Me.toolCloseButtonCheck.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.toolCloseButtonCheck.Size = New System.Drawing.Size(154, 18)
			Me.toolCloseButtonCheck.TabIndex = 8
			Me.toolCloseButtonCheck.Text = "Show Close Button"
'			Me.toolCloseButtonCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.toolCloseButtonCheck_ToggleStateChanged);
			' 
			' toolTextOrientationCombo
			' 
			Me.toolTextOrientationCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.toolTextOrientationCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.toolTextOrientationCombo.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.toolTextOrientationCombo.FormatString = "{0}"
			Me.toolTextOrientationCombo.Location = New System.Drawing.Point(13, 89)
			Me.toolTextOrientationCombo.Name = "toolTextOrientationCombo"
			' 
			' 
			' 
			Me.toolTextOrientationCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.toolTextOrientationCombo.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))), (CInt(Fix((CByte(17))))))
			Me.toolTextOrientationCombo.Size = New System.Drawing.Size(154, 20)
			Me.toolTextOrientationCombo.TabIndex = 7
			Me.toolTextOrientationCombo.TabStop = False
			Me.toolTextOrientationCombo.Text = "radComboBox1"
'			Me.toolTextOrientationCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.toolTextOrientationCombo_SelectedIndexChanged);
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel4.Location = New System.Drawing.Point(13, 69)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(90, 16)
			Me.radLabel4.TabIndex = 6
			Me.radLabel4.Text = "Text Orientation:"
			' 
			' radLabel5
			' 
			Me.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel5.Location = New System.Drawing.Point(13, 23)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(60, 16)
			Me.radLabel5.TabIndex = 1
			Me.radLabel5.Text = "Alignment:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radDock1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(753, 808)
			Me.Controls.SetChildIndex(Me.radDock1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radDock1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radDock1.ResumeLayout(False)
			CType(Me.radSplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer2.ResumeLayout(False)
			CType(Me.radSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1.ResumeLayout(False)
			CType(Me.toolTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip1.ResumeLayout(False)
			CType(Me.documentContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentContainer1.ResumeLayout(False)
			CType(Me.documentTabStrip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.documentTabStrip1.ResumeLayout(False)
			CType(Me.toolTabStrip2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip2.ResumeLayout(False)
			CType(Me.toolTabStrip3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.toolTabStrip3.ResumeLayout(False)
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docTabAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTabAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docTabsVisibleCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTabsVisibleCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.docCloseButtonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.docTextOrientationCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			CType(Me.toolCloseButtonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.toolTextOrientationCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private WithEvents docTabAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents toolTabsVisibleCheck As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents docTabsVisibleCheck As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents toolTabAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private documentWindow2 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents docTextOrientationCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents toolTextOrientationCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel4 As Telerik.WinControls.UI.RadLabel
		Private radLabel5 As Telerik.WinControls.UI.RadLabel
		Private WithEvents docCloseButtonCheck As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents toolCloseButtonCheck As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
