Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.TimeZones
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
			Dim dateTimeInterval2 As New Telerik.WinControls.UI.DateTimeInterval()
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			Me.radDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.radButton2)
			Me.settingsPanel.Controls.Add(Me.radDropDownList2)
			Me.settingsPanel.Location = New System.Drawing.Point(956, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(217, 1231)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radDropDownList2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButton2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			' 
			' radScheduler1
			' 
			dateTimeInterval2.End = New System.DateTime((CLng(Fix(0))))
			Me.radScheduler1.AccessibleInterval = dateTimeInterval2
			Me.radScheduler1.AppointmentTitleFormat = Nothing
			Me.radScheduler1.Culture = New System.Globalization.CultureInfo("en-US")
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radScheduler1.HeaderFormat = "MM/dd/yy (ddd)"
			Me.radScheduler1.Location = New System.Drawing.Point(0, 77)
			Me.radScheduler1.Name = "radScheduler1"
			Me.radScheduler1.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
			' 
			' 
			' 
			Me.radScheduler1.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
			Me.radScheduler1.Size = New System.Drawing.Size(1157, 578)
			Me.radScheduler1.TabIndex = 1
			Me.radScheduler1.Text = "radScheduler1"
			' 
			' radSchedulerNavigator1
			' 
			
			Me.radSchedulerNavigator1.DateFormat = "MMM dd, yyyy"
			Me.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radSchedulerNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.radSchedulerNavigator1.MinimumSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.MinSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New System.Drawing.Size(1157, 77)
			Me.radSchedulerNavigator1.TabIndex = 2
			Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.ThemeName = "ControlDefault"
			' 
			' radDropDownList2
			' 
			Me.radDropDownList2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radDropDownList2.DefaultItemsCountInDropDown = 30
			Me.radDropDownList2.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radDropDownList2.Location = New System.Drawing.Point(10, 59)
			Me.radDropDownList2.MaxDropDownItems = 30
			Me.radDropDownList2.Name = "radDropDownList2"
			Me.radDropDownList2.Size = New System.Drawing.Size(197, 20)
			Me.radDropDownList2.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending
			Me.radDropDownList2.TabIndex = 8
			Me.radDropDownList2.Text = "radDropDownList2"
			' 
			' radButton2
			' 
			Me.radButton2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButton2.Location = New System.Drawing.Point(10, 86)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New System.Drawing.Size(197, 24)
			Me.radButton2.TabIndex = 10
			Me.radButton2.Text = "Add New"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click);
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel2.Location = New System.Drawing.Point(10, 37)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(100, 16)
			Me.radLabel2.TabIndex = 12
			Me.radLabel2.Text = "Time Zones"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1157, 655)
			Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
		Private radDropDownList2 As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private radLabel2 As Telerik.WinControls.UI.RadLabel

	End Class
End Namespace