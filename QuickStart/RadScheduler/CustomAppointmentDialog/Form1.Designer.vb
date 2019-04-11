Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.CustomAppointmentDialog
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
			Me.radSchedulerDemo = New Telerik.WinControls.UI.RadScheduler()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(1016, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 832)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radSchedulerDemo
			' 
			Me.radSchedulerDemo.DataSource = Nothing
			Me.radSchedulerDemo.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radSchedulerDemo.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radSchedulerDemo.HeaderFormat = "dd dddd"
			Me.radSchedulerDemo.Location = New System.Drawing.Point(0, 0)
			Me.radSchedulerDemo.Name = "radSchedulerDemo"
			Me.radSchedulerDemo.Size = New System.Drawing.Size(1217, 834)
			Me.radSchedulerDemo.TabIndex = 0
'			Me.radSchedulerDemo.AppointmentEditDialogShowing += New System.EventHandler(Of Telerik.WinControls.UI.AppointmentEditDialogShowingEventArgs)(Me.radSchedulerDemo_AppointmentEditDialogShowing);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radSchedulerDemo)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1217, 834)
			Me.Controls.SetChildIndex(Me.radSchedulerDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radSchedulerDemo As Telerik.WinControls.UI.RadScheduler
	End Class
End Namespace
