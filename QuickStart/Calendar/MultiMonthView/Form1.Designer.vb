Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.MultiMonthView
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
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radGroupRenderDir = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioRows = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioCols = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupRenderDir, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupRenderDir.SuspendLayout()
			CType(Me.radRadioRows, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioCols, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupRenderDir)
			Me.settingsPanel.Location = New System.Drawing.Point(729, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(250, 867)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupRenderDir, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radCalendar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.FocusedDate = New System.DateTime(2009, 3, 9, 0, 0, 0, 0)
			Me.radCalendar1.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(287, 227)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.SelectedDate = New System.DateTime((CLng(Fix(0))))
			Me.radCalendar1.SelectedDates.AddRange(New System.DateTime() { New System.DateTime((CLng(Fix(0))))})
			Me.radCalendar1.Size = New System.Drawing.Size(407, 415)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radGroupRenderDir
			' 
			Me.radGroupRenderDir.Controls.Add(Me.radRadioRows)
			Me.radGroupRenderDir.Controls.Add(Me.radRadioCols)
			Me.radGroupRenderDir.FooterImageIndex = -1
			Me.radGroupRenderDir.FooterImageKey = ""
			Me.radGroupRenderDir.ForeColor = System.Drawing.Color.Black
			Me.radGroupRenderDir.HeaderImageIndex = -1
			Me.radGroupRenderDir.HeaderImageKey = ""
			Me.radGroupRenderDir.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupRenderDir.HeaderText = "Rendering Direction"
			Me.radGroupRenderDir.Location = New System.Drawing.Point(15, 6)
			Me.radGroupRenderDir.Name = "radGroupRenderDir"
			' 
			' 
			' 
			Me.radGroupRenderDir.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupRenderDir.Size = New System.Drawing.Size(162, 88)
			Me.radGroupRenderDir.TabIndex = 5
			Me.radGroupRenderDir.Text = "Rendering Direction"
			' 
			' radRadioRows
			' 
			Me.radRadioRows.ForeColor = System.Drawing.Color.Black
			Me.radRadioRows.Location = New System.Drawing.Point(19, 29)
			Me.radRadioRows.Name = "radRadioRows"
			Me.radRadioRows.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioRows.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioRows.Size = New System.Drawing.Size(101, 16)
			Me.radRadioRows.TabIndex = 6
			Me.radRadioRows.Text = "Render In Rows"
'			Me.radRadioRows.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioRows_ToggleStateChanged);
			' 
			' radRadioCols
			' 
			Me.radRadioCols.ForeColor = System.Drawing.Color.Black
			Me.radRadioCols.Location = New System.Drawing.Point(19, 51)
			Me.radRadioCols.Name = "radRadioCols"
			Me.radRadioCols.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioCols.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioCols.Size = New System.Drawing.Size(118, 16)
			Me.radRadioCols.TabIndex = 6
			Me.radRadioCols.Text = "Render In Columns"
'			Me.radRadioCols.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioRows_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(980, 869)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupRenderDir, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupRenderDir.ResumeLayout(False)
			Me.radGroupRenderDir.PerformLayout()
			CType(Me.radRadioRows, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioCols, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private radGroupRenderDir As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioRows As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioCols As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace