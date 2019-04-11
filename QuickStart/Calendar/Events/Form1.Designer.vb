Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.Events
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radListBoxEvents = New Telerik.WinControls.UI.RadListControl()
			Me.radButtonClear = New Telerik.WinControls.UI.RadButton()
			Me.radGroupEvents = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListBoxEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupEvents.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupEvents)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 818)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupEvents, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.DayNameFormat = Telerik.WinControls.UI.DayNameFormat.Full
			Me.radCalendar1.FocusedDate = New System.DateTime(2009, 3, 15, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(364, 287)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.SelectedDate = New System.DateTime((CLng(Fix(0))))
			Me.radCalendar1.SelectedDates.AddRange(New System.DateTime() { New System.DateTime((CLng(Fix(0))))})
			Me.radCalendar1.Size = New System.Drawing.Size(496, 246)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radListBoxEvents
			' 
			Me.radListBoxEvents.AutoScroll = True
			Me.radListBoxEvents.BackColor = System.Drawing.Color.White
			Me.radListBoxEvents.Font = New System.Drawing.Font("Verdana", 8F)
			Me.radListBoxEvents.ForeColor = System.Drawing.Color.Black
			Me.radListBoxEvents.Location = New System.Drawing.Point(23, 21)
			Me.radListBoxEvents.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
			Me.radListBoxEvents.Name = "radListBoxEvents"
			' 
			' 
			' 
			Me.radListBoxEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radListBoxEvents.Size = New System.Drawing.Size(135, 200)
			Me.radListBoxEvents.TabIndex = 6
			' 
			' radButtonClear
			' 
			Me.radButtonClear.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radButtonClear.Location = New System.Drawing.Point(23, 227)
			Me.radButtonClear.Name = "radButtonClear"
			Me.radButtonClear.Size = New System.Drawing.Size(135, 23)
			Me.radButtonClear.TabIndex = 8
			Me.radButtonClear.Text = "Clear"
'			Me.radButtonClear.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radGroupEvents
			' 
			Me.radGroupEvents.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupEvents.Controls.Add(Me.radButtonClear)
			Me.radGroupEvents.Controls.Add(Me.radListBoxEvents)
			Me.radGroupEvents.FooterImageIndex = -1
			Me.radGroupEvents.FooterImageKey = ""
			Me.radGroupEvents.ForeColor = System.Drawing.Color.Black
			Me.radGroupEvents.HeaderImageIndex = -1
			Me.radGroupEvents.HeaderImageKey = ""
			Me.radGroupEvents.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupEvents.HeaderText = "Events"
			Me.radGroupEvents.Location = New System.Drawing.Point(10, 6)
			Me.radGroupEvents.Name = "radGroupEvents"
			Me.radGroupEvents.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupEvents.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupEvents.Size = New System.Drawing.Size(180, 263)
			Me.radGroupEvents.TabIndex = 6
			Me.radGroupEvents.Text = "Events"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 820)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListBoxEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonClear, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupEvents.ResumeLayout(False)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private WithEvents radButtonClear As Telerik.WinControls.UI.RadButton
		Private radListBoxEvents As Telerik.WinControls.UI.RadListControl
		Private radGroupEvents As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace