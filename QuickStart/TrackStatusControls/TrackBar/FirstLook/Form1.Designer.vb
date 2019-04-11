Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.TrackStatusControls.TrackBar.FirstLook
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
			Me.radHorizontalTrackBar = New Telerik.WinControls.UI.RadTrackBar()
			Me.radVerticalTrackbar = New Telerik.WinControls.UI.RadTrackBar()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radHorizontalTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radVerticalTrackbar, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radVerticalTrackbar)
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel2)
			Me.radPanelDemoHolder.Controls.Add(Me.radLabel1)
			Me.radPanelDemoHolder.Controls.Add(Me.radHorizontalTrackBar)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(396, 123)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(432, 290)
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
			' radHorizontalTrackBar
			' 
			Me.radHorizontalTrackBar.BackColor = System.Drawing.Color.Transparent
			Me.radHorizontalTrackBar.ForeColor = System.Drawing.Color.Black
			Me.radHorizontalTrackBar.Location = New System.Drawing.Point(182, 140)
			Me.radHorizontalTrackBar.Name = "radHorizontalTrackBar"
			' 
			' 
			' 
			Me.radHorizontalTrackBar.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radHorizontalTrackBar.RootElement.ToolTipText = Nothing
			Me.radHorizontalTrackBar.Size = New System.Drawing.Size(217, 30)
			Me.radHorizontalTrackBar.SlideAreaWidth = 2
			Me.radHorizontalTrackBar.SliderAreaColor1 = System.Drawing.Color.WhiteSmoke
			Me.radHorizontalTrackBar.SliderAreaColor2 = System.Drawing.Color.DarkGray
			Me.radHorizontalTrackBar.TabIndex = 0
'			Me.radHorizontalTrackBar.Scroll += New System.Windows.Forms.ScrollEventHandler(Me.OnHorizontalTrackBar_Scroll);
			' 
			' radVerticalTrackbar
			' 
			Me.radVerticalTrackbar.BackColor = System.Drawing.Color.Transparent
			Me.radVerticalTrackbar.ForeColor = System.Drawing.Color.Black
			Me.radVerticalTrackbar.Location = New System.Drawing.Point(62, 63)
			Me.radVerticalTrackbar.Maximum = 50
			Me.radVerticalTrackbar.Name = "radVerticalTrackbar"
			Me.radVerticalTrackbar.Orientation = System.Windows.Forms.Orientation.Vertical
			' 
			' 
			' 
			Me.radVerticalTrackbar.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radVerticalTrackbar.RootElement.ToolTipText = Nothing
			Me.radVerticalTrackbar.Size = New System.Drawing.Size(30, 201)
			Me.radVerticalTrackbar.SlideAreaWidth = 2
			Me.radVerticalTrackbar.SliderAreaColor1 = System.Drawing.Color.WhiteSmoke
			Me.radVerticalTrackbar.SliderAreaColor2 = System.Drawing.Color.DarkGray
			Me.radVerticalTrackbar.TabIndex = 2
'			Me.radVerticalTrackbar.Scroll += New System.Windows.Forms.ScrollEventHandler(Me.OnVerticalTrackBar_Scroll);
			' 
			' radLabel1
			' 
			Me.radLabel1.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Location = New System.Drawing.Point(34, 26)
			Me.radLabel1.Name = "radLabel1"
			' 
			' 
			' 
			Me.radLabel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel1.Size = New System.Drawing.Size(91, 14)
			Me.radLabel1.TabIndex = 6
			Me.radLabel1.Text = "Vertical TrackBar"
			' 
			' radLabel2
			' 
			Me.radLabel2.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Location = New System.Drawing.Point(182, 104)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Size = New System.Drawing.Size(104, 14)
			Me.radLabel2.TabIndex = 6
			Me.radLabel2.Text = "Horizontal TrackBar"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 536)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radHorizontalTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radVerticalTrackbar, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radHorizontalTrackBar As Telerik.WinControls.UI.RadTrackBar
		Private WithEvents radVerticalTrackbar As Telerik.WinControls.UI.RadTrackBar
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace