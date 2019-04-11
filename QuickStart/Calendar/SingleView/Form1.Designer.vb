Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.SingleView
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
			Me.radRadioRows = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioCols = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioRows, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioCols, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(729, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(250, 867)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
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
			Me.radCalendar1.Location = New System.Drawing.Point(346, 320)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			' 
			' 
			' 
			Me.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.SelectedDate = New System.DateTime((CLng(Fix(0))))
			Me.radCalendar1.SelectedDates.AddRange(New System.DateTime() { New System.DateTime((CLng(Fix(0))))})
			Me.radCalendar1.Size = New System.Drawing.Size(288, 229)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radRadioRows
			' 
			Me.radRadioRows.ForeColor = System.Drawing.Color.Black
			Me.radRadioRows.Location = New System.Drawing.Point(22, 28)
			Me.radRadioRows.Name = "radRadioRows"
			Me.radRadioRows.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioRows.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioRows.Size = New System.Drawing.Size(101, 16)
			Me.radRadioRows.TabIndex = 2
			Me.radRadioRows.Text = "Render In Rows"
'			Me.radRadioRows.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioRows_ToggleStateChanged);
			' 
			' radRadioCols
			' 
			Me.radRadioCols.ForeColor = System.Drawing.Color.Black
			Me.radRadioCols.Location = New System.Drawing.Point(22, 50)
			Me.radRadioCols.Name = "radRadioCols"
			Me.radRadioCols.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioCols.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioCols.Size = New System.Drawing.Size(118, 16)
			Me.radRadioCols.TabIndex = 2
			Me.radRadioCols.Text = "Render In Columns"
'			Me.radRadioCols.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioRows_ToggleStateChanged);
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radRadioRows)
			Me.radGroupBox1.Controls.Add(Me.radRadioCols)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Rendering Options"
			Me.radGroupBox1.Location = New System.Drawing.Point(15, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.Size = New System.Drawing.Size(162, 84)
			Me.radGroupBox1.TabIndex = 3
			Me.radGroupBox1.Text = "Rendering Options"
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
			CType(Me.radRadioRows, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioCols, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private WithEvents radRadioRows As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioCols As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace