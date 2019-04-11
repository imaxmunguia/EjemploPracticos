Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.LayoutCustomization
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
			Me.radGroupDisplay = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadio7Cols = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadio21Cols = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadio14Cols = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupDisplay.SuspendLayout()
			CType(Me.radRadio7Cols, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadio21Cols, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadio14Cols, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupDisplay)
			Me.settingsPanel.Location = New System.Drawing.Point(729, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(250, 867)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupDisplay, 0)
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radCalendar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.radCalendar1.FocusedDate = System.DateTime.Now
			Me.radCalendar1.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(383, 336)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.SelectedDate = New System.DateTime((CLng(Fix(0))))
			Me.radCalendar1.SelectedDates.AddRange(New System.DateTime() { New System.DateTime((CLng(Fix(0))))})
			Me.radCalendar1.Size = New System.Drawing.Size(215, 196)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radGroupDisplay
			' 
			Me.radGroupDisplay.Controls.Add(Me.radRadio7Cols)
			Me.radGroupDisplay.Controls.Add(Me.radRadio21Cols)
			Me.radGroupDisplay.Controls.Add(Me.radRadio14Cols)
			Me.radGroupDisplay.FooterImageIndex = -1
			Me.radGroupDisplay.FooterImageKey = ""
			Me.radGroupDisplay.ForeColor = System.Drawing.Color.Black
			Me.radGroupDisplay.HeaderImageIndex = -1
			Me.radGroupDisplay.HeaderImageKey = ""
			Me.radGroupDisplay.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupDisplay.HeaderText = "Display Options"
			Me.radGroupDisplay.Location = New System.Drawing.Point(15, 6)
			Me.radGroupDisplay.Name = "radGroupDisplay"
			' 
			' 
			' 
			Me.radGroupDisplay.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupDisplay.Size = New System.Drawing.Size(162, 116)
			Me.radGroupDisplay.TabIndex = 2
			Me.radGroupDisplay.Text = "Display Options"
			' 
			' radRadio7Cols
			' 
			Me.radRadio7Cols.ForeColor = System.Drawing.Color.Black
			Me.radRadio7Cols.Location = New System.Drawing.Point(17, 34)
			Me.radRadio7Cols.Name = "radRadio7Cols"
			Me.radRadio7Cols.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadio7Cols.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadio7Cols.Size = New System.Drawing.Size(123, 16)
			Me.radRadio7Cols.TabIndex = 3
			Me.radRadio7Cols.Text = "7 columns by 6 rows"
'			Me.radRadio7Cols.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged);
			' 
			' radRadio21Cols
			' 
			Me.radRadio21Cols.ForeColor = System.Drawing.Color.Black
			Me.radRadio21Cols.Location = New System.Drawing.Point(17, 78)
			Me.radRadio21Cols.Name = "radRadio21Cols"
			Me.radRadio21Cols.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadio21Cols.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadio21Cols.Size = New System.Drawing.Size(129, 16)
			Me.radRadio21Cols.TabIndex = 3
			Me.radRadio21Cols.Text = "21 coulmns by 2 rows"
'			Me.radRadio21Cols.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged);
			' 
			' radRadio14Cols
			' 
			Me.radRadio14Cols.ForeColor = System.Drawing.Color.Black
			Me.radRadio14Cols.Location = New System.Drawing.Point(17, 56)
			Me.radRadio14Cols.Name = "radRadio14Cols"
			Me.radRadio14Cols.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadio14Cols.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadio14Cols.Size = New System.Drawing.Size(129, 16)
			Me.radRadio14Cols.TabIndex = 3
			Me.radRadio14Cols.Text = "14 coulmns by 3 rows"
'			Me.radRadio14Cols.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged);
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
			CType(Me.radGroupDisplay, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupDisplay.ResumeLayout(False)
			Me.radGroupDisplay.PerformLayout()
			CType(Me.radRadio7Cols, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadio21Cols, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadio14Cols, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private radGroupDisplay As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadio7Cols As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadio14Cols As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadio21Cols As Telerik.WinControls.UI.RadRadioButton


	End Class
End Namespace