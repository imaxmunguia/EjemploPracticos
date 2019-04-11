Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.PageView.StripView.StripButtons
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
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.animatedScrollingCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.stripButtonsCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.selectedPageCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.animatedScrollingCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stripButtonsCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.selectedPageCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.selectedPageCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.stripButtonsCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Controls.Add(Me.animatedScrollingCheck)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1097, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 493)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.animatedScrollingCheck, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.stripButtonsCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.selectedPageCombo, 0)
			' 
			' radPageView1
			' 
			Me.radPageView1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPageView1.Location = New System.Drawing.Point(291, 58)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.Size = New System.Drawing.Size(610, 385)
			Me.radPageView1.TabIndex = 1
			Me.radPageView1.Text = "radPageView1"
			' 
			' animatedScrollingCheck
			' 
			Me.animatedScrollingCheck.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.animatedScrollingCheck.Location = New System.Drawing.Point(10, 146)
			Me.animatedScrollingCheck.Name = "animatedScrollingCheck"
			Me.animatedScrollingCheck.Size = New System.Drawing.Size(141, 18)
			Me.animatedScrollingCheck.TabIndex = 2
			Me.animatedScrollingCheck.Text = "Animated Strip Scrolling"
'			Me.animatedScrollingCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.animatedScrollingCheck_ToggleStateChanged);
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(10, 37)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(74, 16)
			Me.radLabel1.TabIndex = 3
			Me.radLabel1.Text = "Strip Buttons:"
			' 
			' stripButtonsCombo
			' 
			Me.stripButtonsCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.stripButtonsCombo.AutoCompleteDataSource = Nothing
			Me.stripButtonsCombo.AutoSize = True
			Me.stripButtonsCombo.DropDownAnimationEnabled = False
			Me.stripButtonsCombo.DropDownAnimationFrames = 1
			Me.stripButtonsCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.stripButtonsCombo.Location = New System.Drawing.Point(10, 59)
			Me.stripButtonsCombo.Name = "stripButtonsCombo"
			Me.stripButtonsCombo.Size = New System.Drawing.Size(180, 20)
			Me.stripButtonsCombo.TabIndex = 4
			Me.stripButtonsCombo.TabStop = False
			Me.stripButtonsCombo.Text = "radDropDownList1"
'			Me.stripButtonsCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.stripButtonsCombo_SelectedIndexChanged);
			' 
			' selectedPageCombo
			' 
			Me.selectedPageCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.selectedPageCombo.AutoCompleteDataSource = Nothing
			Me.selectedPageCombo.AutoSize = True
			Me.selectedPageCombo.DropDownAnimationEnabled = False
			Me.selectedPageCombo.DropDownAnimationFrames = 1
			Me.selectedPageCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.selectedPageCombo.Location = New System.Drawing.Point(10, 107)
			Me.selectedPageCombo.Name = "selectedPageCombo"
			Me.selectedPageCombo.Size = New System.Drawing.Size(180, 20)
			Me.selectedPageCombo.TabIndex = 6
			Me.selectedPageCombo.TabStop = False
			Me.selectedPageCombo.Text = "radDropDownList1"
'			Me.selectedPageCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.selectedPageCombo_SelectedIndexChanged);
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel2.Location = New System.Drawing.Point(10, 85)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(83, 16)
			Me.radLabel2.TabIndex = 5
			Me.radLabel2.Text = "Selected Page:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1298, 495)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.animatedScrollingCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stripButtonsCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.selectedPageCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private WithEvents selectedPageCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private WithEvents stripButtonsCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents animatedScrollingCheck As Telerik.WinControls.UI.RadCheckBox

	End Class
End Namespace