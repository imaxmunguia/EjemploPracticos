Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.TrackStatusControls.Theming
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
			Me.radTrackBar1 = New Telerik.WinControls.UI.RadTrackBar()
			Me.label1 = New System.Windows.Forms.Label()
			Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
			Me.scrollBarControl3 = New Telerik.WinControls.UI.RadScrollBar()
			Me.label2 = New System.Windows.Forms.Label()
			Me.label6 = New System.Windows.Forms.Label()
			Me.radWaitingBar1 = New Telerik.WinControls.UI.RadWaitingBar()
			Me.label3 = New System.Windows.Forms.Label()
			CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.scrollBarControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radTrackBar1
			' 
			Me.radTrackBar1.AutoScroll = True
			Me.radTrackBar1.BackColor = System.Drawing.Color.White
			Me.radTrackBar1.ForeColor = System.Drawing.Color.Black
			Me.radTrackBar1.LargeChange = 1
			Me.radTrackBar1.Location = New System.Drawing.Point(140, 122)
			Me.radTrackBar1.Maximum = 10
			Me.radTrackBar1.Minimum = 0
			Me.radTrackBar1.Name = "radTrackBar1"
			Me.radTrackBar1.Orientation = System.Windows.Forms.Orientation.Horizontal
			' 
			' 
			' 
			Me.radTrackBar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTrackBar1.RootElement.ToolTipText = Nothing
			Me.radTrackBar1.ShowSlideArea = False
			Me.radTrackBar1.Size = New System.Drawing.Size(177, 22)
			Me.radTrackBar1.TabIndex = 18
			Me.radTrackBar1.Text = "radTrackBar1"
			Me.radTrackBar1.TickStyle = Telerik.WinControls.Enumerations.TickStyles.Both
			Me.radTrackBar1.Value = 0
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(27, 73)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(69, 13)
			Me.label1.TabIndex = 16
			Me.label1.Text = "RadScrollBar"
			' 
			' radProgressBar1
			' 
			Me.radProgressBar1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))), (CInt(Fix((CByte(255))))))
			Me.radProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radProgressBar1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(172))))), (CInt(Fix((CByte(168))))), (CInt(Fix((CByte(153))))))
			Me.radProgressBar1.ImageScalingSize = New System.Drawing.Size(0, 0)
			Me.radProgressBar1.Location = New System.Drawing.Point(140, 26)
			Me.radProgressBar1.Name = "radProgressBar1"
			Me.radProgressBar1.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Left
			' 
			' 
			' 
			Me.radProgressBar1.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(172))))), (CInt(Fix((CByte(168))))), (CInt(Fix((CByte(153))))))
			Me.radProgressBar1.RootElement.ToolTipText = Nothing
			Me.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
			Me.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White
			Me.radProgressBar1.SeparatorWidth = 4
			Me.radProgressBar1.ShowProgressIndicators = True
			Me.radProgressBar1.Size = New System.Drawing.Size(177, 22)
			Me.radProgressBar1.StepWidth = 13
			Me.radProgressBar1.TabIndex = 25
			Me.radProgressBar1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radProgressBar1.Value1 = 60
			' 
			' scrollBarControl3
			' 
			Me.scrollBarControl3.BackColor = System.Drawing.Color.White
			Me.scrollBarControl3.Location = New System.Drawing.Point(140, 73)
			Me.scrollBarControl3.Margin = New System.Windows.Forms.Padding(2)
			Me.scrollBarControl3.Name = "scrollBarControl3"
			' 
			' 
			' 
			Me.scrollBarControl3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.scrollBarControl3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.scrollBarControl3.RootElement.ToolTipText = Nothing
			Me.scrollBarControl3.Size = New System.Drawing.Size(177, 22)
			Me.scrollBarControl3.TabIndex = 39
			Me.scrollBarControl3.Text = "scrollBarControl3"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(27, 26)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(84, 13)
			Me.label2.TabIndex = 48
			Me.label2.Text = "RadProgressBar"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.Location = New System.Drawing.Point(27, 122)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(71, 13)
			Me.label6.TabIndex = 49
			Me.label6.Text = "RadTrackBar"
			' 
			' radWaitingBar1
			' 
			Me.radWaitingBar1.Location = New System.Drawing.Point(140, 169)
			Me.radWaitingBar1.Name = "radWaitingBar1"
			' 
			' 
			' 
			Me.radWaitingBar1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radWaitingBar1.Size = New System.Drawing.Size(177, 22)
			Me.radWaitingBar1.TabIndex = 50
			Me.radWaitingBar1.Text = "radWaitingBar1"
			Me.radWaitingBar1.WaitingSpeed = 10
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.Location = New System.Drawing.Point(27, 169)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(79, 13)
			Me.label3.TabIndex = 51
			Me.label3.Text = "RadWaitingBar"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.radWaitingBar1)
			Me.Controls.Add(Me.label6)
			Me.Controls.Add(Me.radTrackBar1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.scrollBarControl3)
			Me.Controls.Add(Me.radProgressBar1)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(840, 852)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.scrollBarControl3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radWaitingBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radTrackBar1 As Telerik.WinControls.UI.RadTrackBar
		Private label1 As System.Windows.Forms.Label
		Private radProgressBar1 As Telerik.WinControls.UI.RadProgressBar
		Private scrollBarControl3 As Telerik.WinControls.UI.RadScrollBar
		Private label2 As System.Windows.Forms.Label
		Private label6 As System.Windows.Forms.Label
		Private radWaitingBar1 As Telerik.WinControls.UI.RadWaitingBar
		Private label3 As System.Windows.Forms.Label
	End Class
End Namespace