Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.FirstLook
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
			Me.contextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
			Me.scrollToToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
			Me.leftTopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.rightBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
			Me.pageLeftUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.pageRightBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
			Me.scrollLeftUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.scrollRightBottomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
			Me.radVScrollBar1 = New Telerik.WinControls.UI.RadVScrollBar()
			Me.radHScrollBar1 = New Telerik.WinControls.UI.RadHScrollBar()
			Me.spinMinThumb = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinThumbLength = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinValue = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinLargeChange = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinMax = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinMin = New Telerik.WinControls.UI.RadSpinEditor()
			Me.spinSmallChange = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radGroupCommonSettings = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblThumbLengthProp = New Telerik.WinControls.UI.RadLabel()
			Me.radLblMinThumbLength = New Telerik.WinControls.UI.RadLabel()
			Me.radLblValue = New Telerik.WinControls.UI.RadLabel()
			Me.radLblSmallChange = New Telerik.WinControls.UI.RadLabel()
			Me.radLblMinimum = New Telerik.WinControls.UI.RadLabel()
			Me.radLblLargeChange = New Telerik.WinControls.UI.RadLabel()
			Me.radLblMaximum = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			Me.contextMenuStrip1.SuspendLayout()
			CType(Me.radVScrollBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radHScrollBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinMinThumb, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinThumbLength, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinValue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinLargeChange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinMax, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinMin, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.spinSmallChange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupCommonSettings, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupCommonSettings.SuspendLayout()
			CType(Me.radLblThumbLengthProp, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblMinThumbLength, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblValue, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblSmallChange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblMinimum, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblLargeChange, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblMaximum, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radPanel1)
			Me.radPanelDemoHolder.Controls.Add(Me.radVScrollBar1)
			Me.radPanelDemoHolder.Controls.Add(Me.radHScrollBar1)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(257, 138)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(483, 357)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupCommonSettings)
			Me.settingsPanel.Location = New System.Drawing.Point(796, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 632)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupCommonSettings, 0)
			' 
			' contextMenuStrip1
			' 
			Me.contextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() { Me.scrollToToolStripMenuItem, Me.toolStripSeparator1, Me.leftTopToolStripMenuItem, Me.rightBottomToolStripMenuItem, Me.toolStripSeparator2, Me.pageLeftUpToolStripMenuItem, Me.pageRightBottomToolStripMenuItem, Me.toolStripSeparator3, Me.scrollLeftUpToolStripMenuItem, Me.scrollRightBottomToolStripMenuItem})
			Me.contextMenuStrip1.Name = "contextMenuStrip1"
			Me.contextMenuStrip1.Size = New System.Drawing.Size(177, 176)
			' 
			' scrollToToolStripMenuItem
			' 
			Me.scrollToToolStripMenuItem.Name = "scrollToToolStripMenuItem"
			Me.scrollToToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
			Me.scrollToToolStripMenuItem.Text = "Scroll To"
'			Me.scrollToToolStripMenuItem.Click += New System.EventHandler(Me.scrollToToolStripMenuItem_Click);
			' 
			' toolStripSeparator1
			' 
			Me.toolStripSeparator1.Name = "toolStripSeparator1"
			Me.toolStripSeparator1.Size = New System.Drawing.Size(173, 6)
			' 
			' leftTopToolStripMenuItem
			' 
			Me.leftTopToolStripMenuItem.Name = "leftTopToolStripMenuItem"
			Me.leftTopToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
			Me.leftTopToolStripMenuItem.Text = "Left / Top"
'			Me.leftTopToolStripMenuItem.Click += New System.EventHandler(Me.leftTopToolStripMenuItem_Click);
			' 
			' rightBottomToolStripMenuItem
			' 
			Me.rightBottomToolStripMenuItem.Name = "rightBottomToolStripMenuItem"
			Me.rightBottomToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
			Me.rightBottomToolStripMenuItem.Text = "Right  /Bottom"
'			Me.rightBottomToolStripMenuItem.Click += New System.EventHandler(Me.rightBottomToolStripMenuItem_Click);
			' 
			' toolStripSeparator2
			' 
			Me.toolStripSeparator2.Name = "toolStripSeparator2"
			Me.toolStripSeparator2.Size = New System.Drawing.Size(173, 6)
			' 
			' pageLeftUpToolStripMenuItem
			' 
			Me.pageLeftUpToolStripMenuItem.Name = "pageLeftUpToolStripMenuItem"
			Me.pageLeftUpToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
			Me.pageLeftUpToolStripMenuItem.Text = "Page Left / Up"
'			Me.pageLeftUpToolStripMenuItem.Click += New System.EventHandler(Me.pageLeftUpToolStripMenuItem_Click);
			' 
			' pageRightBottomToolStripMenuItem
			' 
			Me.pageRightBottomToolStripMenuItem.Name = "pageRightBottomToolStripMenuItem"
			Me.pageRightBottomToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
			Me.pageRightBottomToolStripMenuItem.Text = "Page Right / Down"
'			Me.pageRightBottomToolStripMenuItem.Click += New System.EventHandler(Me.pageRightBottomToolStripMenuItem_Click);
			' 
			' toolStripSeparator3
			' 
			Me.toolStripSeparator3.Name = "toolStripSeparator3"
			Me.toolStripSeparator3.Size = New System.Drawing.Size(173, 6)
			' 
			' scrollLeftUpToolStripMenuItem
			' 
			Me.scrollLeftUpToolStripMenuItem.Name = "scrollLeftUpToolStripMenuItem"
			Me.scrollLeftUpToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
			Me.scrollLeftUpToolStripMenuItem.Text = "Scroll Left / Up"
'			Me.scrollLeftUpToolStripMenuItem.Click += New System.EventHandler(Me.scrollLeftUpToolStripMenuItem_Click);
			' 
			' scrollRightBottomToolStripMenuItem
			' 
			Me.scrollRightBottomToolStripMenuItem.Name = "scrollRightBottomToolStripMenuItem"
			Me.scrollRightBottomToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
			Me.scrollRightBottomToolStripMenuItem.Text = "Scroll Right / Down"
'			Me.scrollRightBottomToolStripMenuItem.Click += New System.EventHandler(Me.scrollRightBottomToolStripMenuItem_Click);
			' 
			' radVScrollBar1
			' 
			Me.radVScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radVScrollBar1.ContextMenuStrip = Me.contextMenuStrip1
			Me.radVScrollBar1.ForeColor = System.Drawing.Color.Black
			Me.radVScrollBar1.Location = New System.Drawing.Point(399, 20)
			Me.radVScrollBar1.Margin = New System.Windows.Forms.Padding(2)
			Me.radVScrollBar1.Name = "radVScrollBar1"
			' 
			' 
			' 
			Me.radVScrollBar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radVScrollBar1.RootElement.ToolTipText = Nothing
			Me.radVScrollBar1.Size = New System.Drawing.Size(18, 293)
			Me.radVScrollBar1.TabIndex = 36
			Me.radVScrollBar1.Text = "radVScrollBar1"
'			Me.radVScrollBar1.ValueChanged += New System.EventHandler(Me.radVScrollBar1_ValueChanged);
			' 
			' radHScrollBar1
			' 
			Me.radHScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radHScrollBar1.ContextMenuStrip = Me.contextMenuStrip1
			Me.radHScrollBar1.ForeColor = System.Drawing.Color.Black
			Me.radHScrollBar1.Location = New System.Drawing.Point(67, 318)
			Me.radHScrollBar1.Margin = New System.Windows.Forms.Padding(2)
			Me.radHScrollBar1.Name = "radHScrollBar1"
			' 
			' 
			' 
			Me.radHScrollBar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radHScrollBar1.RootElement.ToolTipText = Nothing
			Me.radHScrollBar1.Size = New System.Drawing.Size(325, 18)
			Me.radHScrollBar1.TabIndex = 35
			Me.radHScrollBar1.Text = "radHScrollBar1"
'			Me.radHScrollBar1.ValueChanged += New System.EventHandler(Me.radHScrollBar1_ValueChanged);
			' 
			' spinMinThumb
			' 
			Me.spinMinThumb.ForeColor = System.Drawing.Color.Black
			Me.spinMinThumb.Location = New System.Drawing.Point(16, 195)
			Me.spinMinThumb.Name = "spinMinThumb"
			' 
			' 
			' 
			Me.spinMinThumb.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinMinThumb.RootElement.ForeColor = System.Drawing.Color.Black
			Me.spinMinThumb.ShowBorder = True
			Me.spinMinThumb.Size = New System.Drawing.Size(113, 20)
			Me.spinMinThumb.TabIndex = 69
			Me.spinMinThumb.Text = "spinMinThumb"
'			Me.spinMinThumb.ValueChanged += New System.EventHandler(Me.spinMinThumb_ValueChanged);
			' 
			' spinThumbLength
			' 
			Me.spinThumbLength.DecimalPlaces = 2
			Me.spinThumbLength.ForeColor = System.Drawing.Color.Black
			Me.spinThumbLength.Increment = New Decimal(New Integer() { 1, 0, 0, 65536})
			Me.spinThumbLength.Location = New System.Drawing.Point(16, 245)
			Me.spinThumbLength.Maximum = New Decimal(New Integer() { 1, 0, 0, 0})
			Me.spinThumbLength.Minimum = New Decimal(New Integer() { 1, 0, 0, -2147483648})
			Me.spinThumbLength.Name = "spinThumbLength"
			' 
			' 
			' 
			Me.spinThumbLength.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinThumbLength.RootElement.ForeColor = System.Drawing.Color.Black
			Me.spinThumbLength.ShowBorder = True
			Me.spinThumbLength.Size = New System.Drawing.Size(113, 20)
			Me.spinThumbLength.TabIndex = 67
			Me.spinThumbLength.Text = "spinThumbLength"
			Me.spinThumbLength.Value = New Decimal(New Integer() { 10, 0, 0, 131072})
'			Me.spinThumbLength.ValueChanged += New System.EventHandler(Me.spinThumbLength_ValueChanged);
			' 
			' spinValue
			' 
			Me.spinValue.ForeColor = System.Drawing.Color.Black
			Me.spinValue.Location = New System.Drawing.Point(91, 147)
			Me.spinValue.Name = "spinValue"
			' 
			' 
			' 
			Me.spinValue.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinValue.RootElement.ForeColor = System.Drawing.Color.Black
			Me.spinValue.ShowBorder = True
			Me.spinValue.Size = New System.Drawing.Size(62, 20)
			Me.spinValue.TabIndex = 68
			Me.spinValue.Text = "spinValue"
'			Me.spinValue.ValueChanged += New System.EventHandler(Me.spinValue_ValueChanged);
			' 
			' spinLargeChange
			' 
			Me.spinLargeChange.ForeColor = System.Drawing.Color.Black
			Me.spinLargeChange.Location = New System.Drawing.Point(91, 91)
			Me.spinLargeChange.Name = "spinLargeChange"
			' 
			' 
			' 
			Me.spinLargeChange.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinLargeChange.RootElement.ForeColor = System.Drawing.Color.Black
			Me.spinLargeChange.ShowBorder = True
			Me.spinLargeChange.Size = New System.Drawing.Size(62, 20)
			Me.spinLargeChange.TabIndex = 66
			Me.spinLargeChange.Text = "spinLargeChange"
'			Me.spinLargeChange.ValueChanged += New System.EventHandler(Me.spinLargeChange_ValueChanged);
			' 
			' spinMax
			' 
			Me.spinMax.ForeColor = System.Drawing.Color.Black
			Me.spinMax.Location = New System.Drawing.Point(91, 35)
			Me.spinMax.Name = "spinMax"
			' 
			' 
			' 
			Me.spinMax.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinMax.RootElement.ForeColor = System.Drawing.Color.Black
			Me.spinMax.ShowBorder = True
			Me.spinMax.Size = New System.Drawing.Size(62, 20)
			Me.spinMax.TabIndex = 63
'			Me.spinMax.ValueChanged += New System.EventHandler(Me.spinMax_ValueChanged);
			' 
			' spinMin
			' 
			Me.spinMin.ForeColor = System.Drawing.Color.Black
			Me.spinMin.Location = New System.Drawing.Point(91, 63)
			Me.spinMin.Name = "spinMin"
			' 
			' 
			' 
			Me.spinMin.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinMin.RootElement.ForeColor = System.Drawing.Color.Black
			Me.spinMin.ShowBorder = True
			Me.spinMin.Size = New System.Drawing.Size(62, 20)
			Me.spinMin.TabIndex = 64
			Me.spinMin.Text = "spinMin"
'			Me.spinMin.ValueChanged += New System.EventHandler(Me.spinMin_ValueChanged);
			' 
			' spinSmallChange
			' 
			Me.spinSmallChange.ForeColor = System.Drawing.Color.Black
			Me.spinSmallChange.Location = New System.Drawing.Point(91, 119)
			Me.spinSmallChange.Name = "spinSmallChange"
			' 
			' 
			' 
			Me.spinSmallChange.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.spinSmallChange.RootElement.ForeColor = System.Drawing.Color.Black
			Me.spinSmallChange.ShowBorder = True
			Me.spinSmallChange.Size = New System.Drawing.Size(62, 20)
			Me.spinSmallChange.TabIndex = 65
			Me.spinSmallChange.Text = "spinSmallChange"
'			Me.spinSmallChange.ValueChanged += New System.EventHandler(Me.spinSmallChange_ValueChanged);
			' 
			' radPanel1
			' 
			Me.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanel1.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Location = New System.Drawing.Point(66, 20)
			Me.radPanel1.Name = "radPanel1"
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Size = New System.Drawing.Size(326, 293)
			Me.radPanel1.TabIndex = 63
			' 
			' radGroupCommonSettings
			' 
			Me.radGroupCommonSettings.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupCommonSettings.Controls.Add(Me.radLblThumbLengthProp)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblMinThumbLength)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblValue)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblSmallChange)
			Me.radGroupCommonSettings.Controls.Add(Me.spinMinThumb)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblMinimum)
			Me.radGroupCommonSettings.Controls.Add(Me.spinThumbLength)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblLargeChange)
			Me.radGroupCommonSettings.Controls.Add(Me.radLblMaximum)
			Me.radGroupCommonSettings.Controls.Add(Me.spinMax)
			Me.radGroupCommonSettings.Controls.Add(Me.spinSmallChange)
			Me.radGroupCommonSettings.Controls.Add(Me.spinMin)
			Me.radGroupCommonSettings.Controls.Add(Me.spinValue)
			Me.radGroupCommonSettings.Controls.Add(Me.spinLargeChange)
			Me.radGroupCommonSettings.FooterImageIndex = -1
			Me.radGroupCommonSettings.FooterImageKey = ""
			Me.radGroupCommonSettings.FooterText = ""
			Me.radGroupCommonSettings.ForeColor = System.Drawing.Color.Black
			Me.radGroupCommonSettings.HeaderImageIndex = -1
			Me.radGroupCommonSettings.HeaderImageKey = ""
			Me.radGroupCommonSettings.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupCommonSettings.HeaderText = "Settings"
			Me.radGroupCommonSettings.Location = New System.Drawing.Point(10, 6)
			Me.radGroupCommonSettings.Name = "radGroupCommonSettings"
			' 
			' 
			' 
			Me.radGroupCommonSettings.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupCommonSettings.Size = New System.Drawing.Size(180, 284)
			Me.radGroupCommonSettings.TabIndex = 0
			Me.radGroupCommonSettings.Text = "Settings"
			' 
			' radLblThumbLengthProp
			' 
			Me.radLblThumbLengthProp.ForeColor = System.Drawing.Color.Black
			Me.radLblThumbLengthProp.Location = New System.Drawing.Point(8, 223)
			Me.radLblThumbLengthProp.Name = "radLblThumbLengthProp"
			' 
			' 
			' 
			Me.radLblThumbLengthProp.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblThumbLengthProp.Size = New System.Drawing.Size(136, 14)
			Me.radLblThumbLengthProp.TabIndex = 69
			Me.radLblThumbLengthProp.Text = "Thumb Length Proportion:"
			' 
			' radLblMinThumbLength
			' 
			Me.radLblMinThumbLength.ForeColor = System.Drawing.Color.Black
			Me.radLblMinThumbLength.Location = New System.Drawing.Point(10, 173)
			Me.radLblMinThumbLength.Name = "radLblMinThumbLength"
			' 
			' 
			' 
			Me.radLblMinThumbLength.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblMinThumbLength.Size = New System.Drawing.Size(102, 14)
			Me.radLblMinThumbLength.TabIndex = 69
			Me.radLblMinThumbLength.Text = "Min Thumb Length:"
			' 
			' radLblValue
			' 
			Me.radLblValue.ForeColor = System.Drawing.Color.Black
			Me.radLblValue.Location = New System.Drawing.Point(10, 147)
			Me.radLblValue.Name = "radLblValue"
			' 
			' 
			' 
			Me.radLblValue.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblValue.Size = New System.Drawing.Size(36, 14)
			Me.radLblValue.TabIndex = 69
			Me.radLblValue.Text = "Value:"
			' 
			' radLblSmallChange
			' 
			Me.radLblSmallChange.ForeColor = System.Drawing.Color.Black
			Me.radLblSmallChange.Location = New System.Drawing.Point(7, 122)
			Me.radLblSmallChange.Name = "radLblSmallChange"
			' 
			' 
			' 
			Me.radLblSmallChange.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblSmallChange.Size = New System.Drawing.Size(78, 14)
			Me.radLblSmallChange.TabIndex = 69
			Me.radLblSmallChange.Text = "Small Change:"
			' 
			' radLblMinimum
			' 
			Me.radLblMinimum.ForeColor = System.Drawing.Color.Black
			Me.radLblMinimum.Location = New System.Drawing.Point(10, 66)
			Me.radLblMinimum.Name = "radLblMinimum"
			' 
			' 
			' 
			Me.radLblMinimum.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblMinimum.Size = New System.Drawing.Size(53, 14)
			Me.radLblMinimum.TabIndex = 69
			Me.radLblMinimum.Text = "Minimum:"
			' 
			' radLblLargeChange
			' 
			Me.radLblLargeChange.ForeColor = System.Drawing.Color.Black
			Me.radLblLargeChange.Location = New System.Drawing.Point(7, 94)
			Me.radLblLargeChange.Name = "radLblLargeChange"
			' 
			' 
			' 
			Me.radLblLargeChange.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblLargeChange.Size = New System.Drawing.Size(79, 14)
			Me.radLblLargeChange.TabIndex = 69
			Me.radLblLargeChange.Text = "Large Change:"
			' 
			' radLblMaximum
			' 
			Me.radLblMaximum.ForeColor = System.Drawing.Color.Black
			Me.radLblMaximum.Location = New System.Drawing.Point(8, 38)
			Me.radLblMaximum.Name = "radLblMaximum"
			' 
			' 
			' 
			Me.radLblMaximum.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblMaximum.Size = New System.Drawing.Size(56, 14)
			Me.radLblMaximum.TabIndex = 69
			Me.radLblMaximum.Text = "Maximum:"
			' 
			' Form1
			' 
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(997, 634)
			Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			Me.contextMenuStrip1.ResumeLayout(False)
			CType(Me.radVScrollBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radHScrollBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinMinThumb, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinThumbLength, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinValue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinLargeChange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinMax, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinMin, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.spinSmallChange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupCommonSettings, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupCommonSettings.ResumeLayout(False)
			Me.radGroupCommonSettings.PerformLayout()
			CType(Me.radLblThumbLengthProp, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblMinThumbLength, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblValue, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblSmallChange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblMinimum, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblLargeChange, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblMaximum, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radHScrollBar1 As Telerik.WinControls.UI.RadHScrollBar
		Private WithEvents radVScrollBar1 As Telerik.WinControls.UI.RadVScrollBar
		Private contextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
		Private WithEvents scrollToToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents leftTopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents rightBottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents pageLeftUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents pageRightBottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
		Private WithEvents scrollLeftUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents scrollRightBottomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
		Private WithEvents spinMinThumb As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents spinValue As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents spinLargeChange As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents spinMax As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents spinThumbLength As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents spinMin As Telerik.WinControls.UI.RadSpinEditor
		Private WithEvents spinSmallChange As Telerik.WinControls.UI.RadSpinEditor
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radGroupCommonSettings As Telerik.WinControls.UI.RadGroupBox
		Private radLblValue As Telerik.WinControls.UI.RadLabel
		Private radLblSmallChange As Telerik.WinControls.UI.RadLabel
		Private radLblMinimum As Telerik.WinControls.UI.RadLabel
		Private radLblLargeChange As Telerik.WinControls.UI.RadLabel
		Private radLblMaximum As Telerik.WinControls.UI.RadLabel
		Private radLblThumbLengthProp As Telerik.WinControls.UI.RadLabel
		Private radLblMinThumbLength As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace