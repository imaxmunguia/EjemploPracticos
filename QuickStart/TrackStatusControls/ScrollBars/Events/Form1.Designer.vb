Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.TrackStatusControls.ScrollBars.Events
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
			Me.radPanelDemo = New Telerik.WinControls.UI.RadPanel()
			Me.radBtnClear = New Telerik.WinControls.UI.RadButton()
			Me.radTxtEvents = New Telerik.WinControls.UI.RadTextBox()
			Me.radLblEvents = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.contextMenuStrip1.SuspendLayout()
			CType(Me.radVScrollBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radHScrollBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radBtnClear, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTxtEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radPanelDemo)
			Me.radPanelDemoHolder.Controls.Add(Me.radHScrollBar1)
			Me.radPanelDemoHolder.Controls.Add(Me.radTxtEvents)
			Me.radPanelDemoHolder.Controls.Add(Me.radLblEvents)
			Me.radPanelDemoHolder.Controls.Add(Me.radBtnClear)
			Me.radPanelDemoHolder.Controls.Add(Me.radVScrollBar1)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(295, 84)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(634, 584)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 750)
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
			Me.radVScrollBar1.LargeChange = 1
			Me.radVScrollBar1.Location = New System.Drawing.Point(561, 42)
			Me.radVScrollBar1.Margin = New System.Windows.Forms.Padding(2)
			Me.radVScrollBar1.Maximum = 20
			Me.radVScrollBar1.Minimum = 10
			Me.radVScrollBar1.Name = "radVScrollBar1"
			' 
			' 
			' 
			Me.radVScrollBar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radVScrollBar1.RootElement.ToolTipText = Nothing
			Me.radVScrollBar1.Size = New System.Drawing.Size(18, 226)
			Me.radVScrollBar1.TabIndex = 36
			Me.radVScrollBar1.Text = "radVScrollBar1"
			Me.radVScrollBar1.Value = 15
'			Me.radVScrollBar1.Scroll += New System.Windows.Forms.ScrollEventHandler(Me.radVScrollBar1_Scroll);
'			Me.radVScrollBar1.ValueChanged += New System.EventHandler(Me.radVScrollBar1_ValueChanged);
			' 
			' radHScrollBar1
			' 
			Me.radHScrollBar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radHScrollBar1.ContextMenuStrip = Me.contextMenuStrip1
			Me.radHScrollBar1.ForeColor = System.Drawing.Color.Black
			Me.radHScrollBar1.Location = New System.Drawing.Point(56, 272)
			Me.radHScrollBar1.Margin = New System.Windows.Forms.Padding(2)
			Me.radHScrollBar1.Name = "radHScrollBar1"
			' 
			' 
			' 
			Me.radHScrollBar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radHScrollBar1.RootElement.ToolTipText = Nothing
			Me.radHScrollBar1.Size = New System.Drawing.Size(501, 18)
			Me.radHScrollBar1.TabIndex = 35
			Me.radHScrollBar1.Text = "radHScrollBar1"
'			Me.radHScrollBar1.Scroll += New System.Windows.Forms.ScrollEventHandler(Me.radHScrollBar1_Scroll);
'			Me.radHScrollBar1.ValueChanged += New System.EventHandler(Me.radHScrollBar1_ValueChanged);
			' 
			' radPanelDemo
			' 
			Me.radPanelDemo.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanelDemo.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemo.Location = New System.Drawing.Point(57, 42)
			Me.radPanelDemo.Name = "radPanelDemo"
			' 
			' 
			' 
			Me.radPanelDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemo.Size = New System.Drawing.Size(499, 225)
			Me.radPanelDemo.TabIndex = 55
			' 
			' radBtnClear
			' 
			Me.radBtnClear.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radBtnClear.Location = New System.Drawing.Point(279, 519)
			Me.radBtnClear.Name = "radBtnClear"
			Me.radBtnClear.Size = New System.Drawing.Size(77, 23)
			Me.radBtnClear.TabIndex = 56
			Me.radBtnClear.Text = "Clear"
'			Me.radBtnClear.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radTxtEvents
			' 
			Me.radTxtEvents.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radTxtEvents.ForeColor = System.Drawing.Color.Black
			Me.radTxtEvents.Location = New System.Drawing.Point(57, 309)
			Me.radTxtEvents.Multiline = True
			Me.radTxtEvents.Name = "radTxtEvents"
			' 
			' 
			' 
			Me.radTxtEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtEvents.RootElement.StretchVertically = True
			Me.radTxtEvents.Size = New System.Drawing.Size(522, 204)
			Me.radTxtEvents.TabIndex = 57
			Me.radTxtEvents.TabStop = False
			' 
			' radLblEvents
			' 
			Me.radLblEvents.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radLblEvents.ForeColor = System.Drawing.Color.Black
			Me.radLblEvents.Location = New System.Drawing.Point(57, 295)
			Me.radLblEvents.Name = "radLblEvents"
			' 
			' 
			' 
			Me.radLblEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblEvents.Size = New System.Drawing.Size(141, 16)
			Me.radLblEvents.TabIndex = 58
			Me.radLblEvents.Text = "Received Scrolling Events:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Margin = New System.Windows.Forms.Padding(2)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 752)
			Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.contextMenuStrip1.ResumeLayout(False)
			CType(Me.radVScrollBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radHScrollBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radBtnClear, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTxtEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblEvents, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private radPanelDemo As Telerik.WinControls.UI.RadPanel
		Private WithEvents radBtnClear As Telerik.WinControls.UI.RadButton
		Private radTxtEvents As Telerik.WinControls.UI.RadTextBox
		Private radLblEvents As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace