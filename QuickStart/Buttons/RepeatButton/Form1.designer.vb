Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Buttons.RepeatButton
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
			Me.radRepeatButton3 = New Telerik.WinControls.UI.RadRepeatButton()
			Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRepeatButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radRepeatButton3)
			Me.radPanelDemoHolder.Controls.Add(Me.radProgressBar1)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(502, 206)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(219, 124)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(250, 534)
			' 
			' radRepeatButton3
			' 
			Me.radRepeatButton3.BackColor = System.Drawing.Color.Transparent
			Me.radRepeatButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radRepeatButton3.ForeColor = System.Drawing.Color.Black
			Me.radRepeatButton3.Location = New System.Drawing.Point(39, 30)
			Me.radRepeatButton3.Name = "radRepeatButton3"
			' 
			' 
			' 
			Me.radRepeatButton3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRepeatButton3.RootElement.ToolTipText = Nothing
			Me.radRepeatButton3.Size = New System.Drawing.Size(140, 23)
			Me.radRepeatButton3.TabIndex = 6
			Me.radRepeatButton3.Text = "Press and Hold"
'			Me.radRepeatButton3.ButtonClick += New System.EventHandler(Me.radRepeatButton3_ButtonClick);
			' 
			' radProgressBar1
			' 
			Me.radProgressBar1.BackColor = System.Drawing.Color.Transparent
			Me.radProgressBar1.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar1.Location = New System.Drawing.Point(39, 71)
			Me.radProgressBar1.Name = "radProgressBar1"
			' 
			' 
			' 
			Me.radProgressBar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
			Me.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White
			Me.radProgressBar1.SeparatorWidth = 4
			Me.radProgressBar1.Size = New System.Drawing.Size(140, 23)
			Me.radProgressBar1.StepWidth = 13
			Me.radProgressBar1.TabIndex = 7
			Me.radProgressBar1.Text = "radProgressBar1"
			Me.radProgressBar1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1224, 536)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRepeatButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radRepeatButton3 As Telerik.WinControls.UI.RadRepeatButton
		Private radProgressBar1 As Telerik.WinControls.UI.RadProgressBar

	End Class
End Namespace