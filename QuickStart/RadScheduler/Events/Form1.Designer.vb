Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.Events
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
			Me.radTxtEventList = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupEventLog = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSchedulerDemo = New Telerik.WinControls.UI.RadScheduler()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTxtEventList, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupEventLog, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupEventLog.SuspendLayout()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupEventLog)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1016, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 832)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupEventLog, 0)
			' 
			' radTxtEventList
			' 
			Me.radTxtEventList.AutoScroll = True
			Me.radTxtEventList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radTxtEventList.ForeColor = System.Drawing.Color.Black
			Me.radTxtEventList.Location = New System.Drawing.Point(6, 23)
			Me.radTxtEventList.Multiline = True
			Me.radTxtEventList.Name = "radTxtEventList"
			' 
			' 
			' 
			Me.radTxtEventList.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTxtEventList.RootElement.StretchVertically = True
			Me.radTxtEventList.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
			Me.radTxtEventList.Size = New System.Drawing.Size(162, 415)
			Me.radTxtEventList.TabIndex = 1
			Me.radTxtEventList.TabStop = False
			' 
			' radGroupEventLog
			' 
			Me.radGroupEventLog.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupEventLog.AutoScroll = True
			Me.radGroupEventLog.Controls.Add(Me.radTxtEventList)
			Me.radGroupEventLog.FooterImageIndex = -1
			Me.radGroupEventLog.FooterImageKey = ""
			Me.radGroupEventLog.FooterText = ""
			Me.radGroupEventLog.ForeColor = System.Drawing.Color.Black
			Me.radGroupEventLog.HeaderImageIndex = -1
			Me.radGroupEventLog.HeaderImageKey = ""
			Me.radGroupEventLog.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupEventLog.HeaderText = "Event Log"
			Me.radGroupEventLog.Location = New System.Drawing.Point(10, 8)
			Me.radGroupEventLog.Name = "radGroupEventLog"
			Me.radGroupEventLog.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupEventLog.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupEventLog.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupEventLog.Size = New System.Drawing.Size(180, 445)
			Me.radGroupEventLog.TabIndex = 0
			Me.radGroupEventLog.Text = "Event Log"
			' 
			' radSchedulerDemo
			' 
			Me.radSchedulerDemo.BackColor = System.Drawing.Color.White
			Me.radSchedulerDemo.DataSource = Nothing
			Me.radSchedulerDemo.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radSchedulerDemo.ForeColor = System.Drawing.Color.Black
			Me.radSchedulerDemo.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radSchedulerDemo.HeaderFormat = "dd dddd"
			Me.radSchedulerDemo.Location = New System.Drawing.Point(0, 0)
			Me.radSchedulerDemo.Name = "radSchedulerDemo"
			' 
			' 
			' 
			Me.radSchedulerDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSchedulerDemo.Size = New System.Drawing.Size(1217, 834)
			Me.radSchedulerDemo.TabIndex = 0
			Me.radSchedulerDemo.Text = "radScheduler1"
'			Me.radSchedulerDemo.ActiveViewChanged += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerViewChangedEventArgs)(Me.radScheduler1_ActiveViewChanged);
'			Me.radSchedulerDemo.AppointmentSelected += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerAppointmentEventArgs)(Me.radScheduler1_AppointmentSelected);
'			Me.radSchedulerDemo.RecurrenceEditDialogShowing += New System.EventHandler(Of Telerik.WinControls.UI.RecurrenceEditDialogShowingEventArgs)(Me.radSchedulerDemo_RecurrenceEditDialogShowing);
'			Me.radSchedulerDemo.CellClick += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerCellEventArgs)(Me.radScheduler1_CellClick);
'			Me.radSchedulerDemo.AppointmentMouseDown += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerAppointmentMouseEventArgs)(Me.radScheduler1_AppointmentMouseDown);
'			Me.radSchedulerDemo.ActiveViewChanging += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerViewChangingEventArgs)(Me.radScheduler1_ActiveViewChanging);
'			Me.radSchedulerDemo.AppointmentEditDialogShowing += New System.EventHandler(Of Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs)(Me.radScheduler1_AppointmentEditDialogShowing);
'			Me.radSchedulerDemo.AppointmentMouseUp += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerAppointmentMouseEventArgs)(Me.radScheduler1_AppointmentMouseUp);
'			Me.radSchedulerDemo.AppointmentSelecting += New System.EventHandler(Of Telerik.WinControls.UI.SchedulerAppointmentCancelEventArgs)(Me.radScheduler1_AppointmentSelecting);
			' 
			' Form1
			' 
			Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.Controls.Add(Me.radSchedulerDemo)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1217, 834)
			Me.Controls.SetChildIndex(Me.radSchedulerDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radTxtEventList, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupEventLog, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupEventLog.ResumeLayout(False)
			Me.radGroupEventLog.PerformLayout()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radSchedulerDemo As Telerik.WinControls.UI.RadScheduler
		Private radTxtEventList As Telerik.WinControls.UI.RadTextBox
		Private radGroupEventLog As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace
