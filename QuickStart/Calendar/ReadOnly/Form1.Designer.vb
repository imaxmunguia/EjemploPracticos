Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Calendar.ReadOnly
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
			Me.radCheckReadOnly = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckReadOnly, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckReadOnly)
			Me.settingsPanel.Location = New System.Drawing.Point(895, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 694)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckReadOnly, 0)
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
			Me.radCalendar1.Location = New System.Drawing.Point(404, 234)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			Me.radCalendar1.ReadOnly = True
			' 
			' 
			' 
			Me.radCalendar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radCalendar1.Size = New System.Drawing.Size(288, 229)
			Me.radCalendar1.TabIndex = 0
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radCheckReadOnly
			' 
			Me.radCheckReadOnly.AllowShowFocusCues = True
			Me.radCheckReadOnly.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckReadOnly.AutoSize = True
			Me.radCheckReadOnly.BackColor = System.Drawing.Color.Transparent
			Me.radCheckReadOnly.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckReadOnly.Location = New System.Drawing.Point(10, 6)
			Me.radCheckReadOnly.Name = "radCheckReadOnly"
			' 
			' 
			' 
			Me.radCheckReadOnly.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckReadOnly.Size = New System.Drawing.Size(116, 14)
			Me.radCheckReadOnly.TabIndex = 1
			Me.radCheckReadOnly.Text = "Read-only calendar"
			Me.radCheckReadOnly.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
'			Me.radCheckReadOnly.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckReadOnly_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radCalendar1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1096, 696)
			Me.Controls.SetChildIndex(Me.radCalendar1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckReadOnly, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private WithEvents radCheckReadOnly As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace