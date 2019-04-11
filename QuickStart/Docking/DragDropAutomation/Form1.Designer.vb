Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Docking.DragDropAutomation
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
			Me.components = New System.ComponentModel.Container()
			Me.radDock1 = New Telerik.WinControls.UI.Docking.RadDock()
			Me.toolWindow1 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.radSplitContainer2 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.radSplitContainer1 = New Telerik.WinControls.UI.RadSplitContainer()
			Me.toolTabStrip1 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.documentContainer1 = New Telerik.WinControls.UI.Docking.DocumentContainer()
			Me.documentTabStrip1 = New Telerik.WinControls.UI.Docking.DocumentTabStrip()
			Me.documentWindow1 = New Telerik.WinControls.UI.Docking.DocumentWindow()
			Me.toolTabStrip2 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow2 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.toolTabStrip3 = New Telerik.WinControls.UI.Docking.ToolTabStrip()
			Me.toolWindow3 = New Telerik.WinControls.UI.Docking.ToolWindow()
			Me.scenario1Button = New Telerik.WinControls.UI.RadButton()
			Me.initialStateButton = New Telerik.WinControls.UI.RadButton()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.scenario2Button = New Telerik.WinControls.UI.RadButton()
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
			CType(Me.scenario1Button, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.initialStateButton, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.scenario2Button, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.scenario2Button)
			Me.settingsPanel.Controls.Add(Me.initialStateButton)
			Me.settingsPanel.Controls.Add(Me.scenario1Button)
			Me.settingsPanel.Location = New System.Drawing.Point(552, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 723)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.scenario1Button, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.initialStateButton, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.scenario2Button, 0)
			' 
			' radDock1
			' 
			Me.radDock1.ActiveWindow = Me.toolWindow1
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
			Me.radDock1.Size = New System.Drawing.Size(753, 725)
			Me.radDock1.TabIndex = 1
			Me.radDock1.TabStop = False
			Me.radDock1.Text = "radDock1"
			' 
			' toolWindow1
			' 
			Me.toolWindow1.Location = New System.Drawing.Point(1, 26)
			Me.toolWindow1.Name = "toolWindow1"
			Me.toolWindow1.Size = New System.Drawing.Size(198, 495)
			Me.toolWindow1.Text = "toolWindow1"
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
			Me.radSplitContainer2.Size = New System.Drawing.Size(550, 725)
			Me.radSplitContainer2.TabIndex = 0
			Me.radSplitContainer2.TabStop = False
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1.Controls.Add(Me.toolTabStrip1)
			Me.radSplitContainer1.Controls.Add(Me.documentContainer1)
			Me.radSplitContainer1.IsCleanUpTarget = True
			Me.radSplitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.radSplitContainer1.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radSplitContainer1.Size = New System.Drawing.Size(550, 522)
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
			Me.toolTabStrip1.Size = New System.Drawing.Size(200, 522)
			Me.toolTabStrip1.TabIndex = 1
			Me.toolTabStrip1.TabStop = False
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
			Me.documentContainer1.Size = New System.Drawing.Size(347, 522)
			Me.documentContainer1.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill
			Me.documentContainer1.TabIndex = 0
			Me.documentContainer1.TabStop = False
			' 
			' documentTabStrip1
			' 
			Me.documentTabStrip1.Controls.Add(Me.documentWindow1)
			Me.documentTabStrip1.Location = New System.Drawing.Point(0, 0)
			Me.documentTabStrip1.Name = "documentTabStrip1"
			' 
			' 
			' 
			Me.documentTabStrip1.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.documentTabStrip1.SelectedIndex = 0
			Me.documentTabStrip1.Size = New System.Drawing.Size(347, 522)
			Me.documentTabStrip1.TabIndex = 0
			Me.documentTabStrip1.TabStop = False
			' 
			' documentWindow1
			' 
			Me.documentWindow1.Location = New System.Drawing.Point(5, 27)
			Me.documentWindow1.Name = "documentWindow1"
			Me.documentWindow1.Size = New System.Drawing.Size(337, 490)
			Me.documentWindow1.Text = "documentWindow1"
			' 
			' toolTabStrip2
			' 
			Me.toolTabStrip2.Controls.Add(Me.toolWindow2)
			Me.toolTabStrip2.Location = New System.Drawing.Point(0, 525)
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
			Me.toolTabStrip3.Size = New System.Drawing.Size(200, 725)
			Me.toolTabStrip3.TabIndex = 1
			Me.toolTabStrip3.TabStop = False
			' 
			' toolWindow3
			' 
			Me.toolWindow3.Location = New System.Drawing.Point(1, 26)
			Me.toolWindow3.Name = "toolWindow3"
			Me.toolWindow3.Size = New System.Drawing.Size(198, 698)
			Me.toolWindow3.Text = "toolWindow3"
			' 
			' scenario1Button
			' 
			Me.scenario1Button.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.scenario1Button.Location = New System.Drawing.Point(10, 37)
			Me.scenario1Button.Name = "scenario1Button"
			Me.scenario1Button.Size = New System.Drawing.Size(180, 23)
			Me.scenario1Button.TabIndex = 1
			Me.scenario1Button.Text = "Scenario 1"
'			Me.scenario1Button.Click += New System.EventHandler(Me.scenario1Button_Click);
			' 
			' initialStateButton
			' 
			Me.initialStateButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.initialStateButton.Location = New System.Drawing.Point(10, 95)
			Me.initialStateButton.Name = "initialStateButton"
			Me.initialStateButton.Size = New System.Drawing.Size(180, 23)
			Me.initialStateButton.TabIndex = 2
			Me.initialStateButton.Text = "Initial State"
'			Me.initialStateButton.Click += New System.EventHandler(Me.initialStateButton_Click);
			' 
			' timer1
			' 
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' scenario2Button
			' 
			Me.scenario2Button.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.scenario2Button.Location = New System.Drawing.Point(10, 66)
			Me.scenario2Button.Name = "scenario2Button"
			Me.scenario2Button.Size = New System.Drawing.Size(180, 23)
			Me.scenario2Button.TabIndex = 3
			Me.scenario2Button.Text = "Scenario 2"
'			Me.scenario2Button.Click += New System.EventHandler(Me.scenario2Button_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radDock1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(753, 725)
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
			CType(Me.scenario1Button, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.initialStateButton, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.scenario2Button, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents initialStateButton As Telerik.WinControls.UI.RadButton
		Private WithEvents scenario1Button As Telerik.WinControls.UI.RadButton
		Private radDock1 As Telerik.WinControls.UI.Docking.RadDock
		Private documentWindow1 As Telerik.WinControls.UI.Docking.DocumentWindow
		Private radSplitContainer2 As Telerik.WinControls.UI.RadSplitContainer
		Private radSplitContainer1 As Telerik.WinControls.UI.RadSplitContainer
		Private toolTabStrip1 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow1 As Telerik.WinControls.UI.Docking.ToolWindow
		Private documentContainer1 As Telerik.WinControls.UI.Docking.DocumentContainer
		Private documentTabStrip1 As Telerik.WinControls.UI.Docking.DocumentTabStrip
		Private toolTabStrip2 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow2 As Telerik.WinControls.UI.Docking.ToolWindow
		Private toolTabStrip3 As Telerik.WinControls.UI.Docking.ToolTabStrip
		Private toolWindow3 As Telerik.WinControls.UI.Docking.ToolWindow
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private WithEvents scenario2Button As Telerik.WinControls.UI.RadButton
	End Class
End Namespace
