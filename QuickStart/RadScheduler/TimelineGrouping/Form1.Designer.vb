Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.TimelineGrouping
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
			Me.radScheduler1 = New Telerik.WinControls.UI.RadScheduler()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(1056, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 631)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radScheduler1
			' 
			Me.radScheduler1.DataSource = Nothing
			Me.radScheduler1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScheduler1.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radScheduler1.HeaderFormat = "dd dddd"
			Me.radScheduler1.Location = New System.Drawing.Point(0, 0)
			Me.radScheduler1.Name = "radScheduler1"
			Me.radScheduler1.Size = New System.Drawing.Size(1257, 633)
			Me.radScheduler1.TabIndex = 1
			Me.radScheduler1.Text = "radScheduler1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radScheduler1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1257, 633)
			Me.Controls.SetChildIndex(Me.radScheduler1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radScheduler1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radScheduler1 As Telerik.WinControls.UI.RadScheduler
	End Class
End Namespace