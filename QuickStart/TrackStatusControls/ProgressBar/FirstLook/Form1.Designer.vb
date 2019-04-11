Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.TrackStatusControls.ProgressBar.FirstLook
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
			Me.components = New System.ComponentModel.Container()
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)
			Me.radTrackBar1 = New Telerik.WinControls.UI.RadTrackBar()
			Me.radProgressBar5 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radProgressBar2 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radProgressBar4 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radProgressBar1 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radProgressBar6 = New Telerik.WinControls.UI.RadProgressBar()
			Me.radGroupHorizontal = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupImage = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupSlider = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radProgressBar6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupHorizontal, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupHorizontal.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radGroupImage, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupImage.SuspendLayout()
			CType(Me.radGroupSlider, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupSlider.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 50
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick);
			' 
			' radTrackBar1
			' 
			Me.radTrackBar1.Location = New System.Drawing.Point(15, 27)
			Me.radTrackBar1.Maximum = 10
			Me.radTrackBar1.Name = "radTrackBar1"
			' 
			' 
			' 
			Me.radTrackBar1.Size = New System.Drawing.Size(368, 26)
			Me.radTrackBar1.TabIndex = 18
			Me.radTrackBar1.Text = "radTrackBar1"
            Me.radTrackBar1.Value = 10
			' 
			' radProgressBar5
			' 
			Me.radProgressBar5.BackgroundImage = My.Resources.WindowsUpdate
			Me.radProgressBar5.Dash = False
			Me.radProgressBar5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radProgressBar5.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar5.Image = My.Resources.ControlsLogoWF
			Me.radProgressBar5.Location = New System.Drawing.Point(16, 22)
			Me.radProgressBar5.Name = "radProgressBar5"
			' 
			' 
			' 
			Me.radProgressBar5.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar5.RootElement.ToolTipText = Nothing
			Me.radProgressBar5.SeparatorColor1 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
			Me.radProgressBar5.SeparatorColor2 = System.Drawing.Color.White
			Me.radProgressBar5.SeparatorWidth = 4
			Me.radProgressBar5.Size = New System.Drawing.Size(248, 64)
			Me.radProgressBar5.StepWidth = 13
			Me.radProgressBar5.TabIndex = 14
			Me.radProgressBar5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radProgressBar5.ThemeName = "ControlDefault"
			Me.radProgressBar5.Value1 = 100
			' 
			' radProgressBar2
			' 
			Me.radProgressBar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radProgressBar2.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar2.Location = New System.Drawing.Point(16, 69)
			Me.radProgressBar2.Name = "radProgressBar2"
			Me.radProgressBar2.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Right
			' 
			' 
			' 
			Me.radProgressBar2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar2.RootElement.ToolTipText = Nothing
			Me.radProgressBar2.SeparatorColor1 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
			Me.radProgressBar2.SeparatorColor2 = System.Drawing.Color.White
			Me.radProgressBar2.SeparatorWidth = 0
			Me.radProgressBar2.ShowProgressIndicators = True
			Me.radProgressBar2.Size = New System.Drawing.Size(248, 28)
			Me.radProgressBar2.StepWidth = 13
			Me.radProgressBar2.TabIndex = 13
			Me.radProgressBar2.Text = "60%"
			Me.radProgressBar2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radProgressBar2.ThemeName = "Vista"
			Me.radProgressBar2.Value1 = 60
			' 
			' radProgressBar4
			' 
			Me.radProgressBar4.Dash = False
			Me.radProgressBar4.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar4.Location = New System.Drawing.Point(68, 28)
			Me.radProgressBar4.Name = "radProgressBar4"
			Me.radProgressBar4.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Bottom
			' 
			' 
			' 
			Me.radProgressBar4.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar4.RootElement.ToolTipText = Nothing
			Me.radProgressBar4.SeparatorColor1 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
			Me.radProgressBar4.SeparatorColor2 = System.Drawing.Color.White
			Me.radProgressBar4.SeparatorWidth = 4
			Me.radProgressBar4.ShowProgressIndicators = True
			Me.radProgressBar4.Size = New System.Drawing.Size(28, 202)
			Me.radProgressBar4.StepWidth = 13
			Me.radProgressBar4.SweepAngle = 90
			Me.radProgressBar4.TabIndex = 12
			Me.radProgressBar4.Text = "60%"
			Me.radProgressBar4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radProgressBar4.Value1 = 60
			' 
			' radProgressBar1
			' 
			Me.radProgressBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radProgressBar1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radProgressBar1.ImageScalingSize = New System.Drawing.Size(0, 0)
			Me.radProgressBar1.Location = New System.Drawing.Point(16, 26)
			Me.radProgressBar1.Name = "radProgressBar1"
			' 
			' 
			' 
			Me.radProgressBar1.RootElement.ToolTipText = Nothing
			Me.radProgressBar1.SeparatorColor1 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
			Me.radProgressBar1.SeparatorColor2 = System.Drawing.Color.White
			Me.radProgressBar1.SeparatorWidth = 0
			Me.radProgressBar1.ShowProgressIndicators = True
			Me.radProgressBar1.Size = New System.Drawing.Size(248, 28)
			Me.radProgressBar1.StepWidth = 13
			Me.radProgressBar1.SweepAngle = 120
			Me.radProgressBar1.TabIndex = 6
			Me.radProgressBar1.Text = "60%"
			Me.radProgressBar1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radProgressBar1.ThemeName = "Vista"
			Me.radProgressBar1.Value1 = 60
			' 
			' radProgressBar6
			' 
			Me.radProgressBar6.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar6.Location = New System.Drawing.Point(16, 28)
			Me.radProgressBar6.Name = "radProgressBar6"
			Me.radProgressBar6.ProgressOrientation = Telerik.WinControls.ProgressOrientation.Bottom
			' 
			' 
			' 
			Me.radProgressBar6.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radProgressBar6.RootElement.ToolTipText = Nothing
			Me.radProgressBar6.SeparatorColor1 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(239))))))
			Me.radProgressBar6.SeparatorColor2 = System.Drawing.Color.White
			Me.radProgressBar6.SeparatorWidth = 0
			Me.radProgressBar6.ShowProgressIndicators = True
			Me.radProgressBar6.Size = New System.Drawing.Size(28, 202)
			Me.radProgressBar6.StepWidth = 13
			Me.radProgressBar6.SweepAngle = 90
			Me.radProgressBar6.TabIndex = 25
			Me.radProgressBar6.Text = "60%"
			Me.radProgressBar6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radProgressBar6.ThemeName = "Dash1"
			Me.radProgressBar6.Value1 = 60
			' 
			' radGroupHorizontal
			' 
			Me.radGroupHorizontal.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radGroupHorizontal.Controls.Add(Me.radProgressBar1)
			Me.radGroupHorizontal.Controls.Add(Me.radProgressBar2)
			Me.radGroupHorizontal.FooterImageIndex = -1
			Me.radGroupHorizontal.FooterImageKey = ""
			Me.radGroupHorizontal.FooterText = ""
			Me.radGroupHorizontal.ForeColor = System.Drawing.Color.Black
			Me.radGroupHorizontal.HeaderImageIndex = -1
			Me.radGroupHorizontal.HeaderImageKey = ""
			Me.radGroupHorizontal.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupHorizontal.HeaderText = "Horizontal"
			Me.radGroupHorizontal.Location = New System.Drawing.Point(413, 201)
			Me.radGroupHorizontal.Name = "radGroupHorizontal"
			Me.radGroupHorizontal.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupHorizontal.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupHorizontal.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupHorizontal.Size = New System.Drawing.Size(281, 122)
			Me.radGroupHorizontal.TabIndex = 30
			Me.radGroupHorizontal.Text = "Horizontal"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radGroupBox2.Controls.Add(Me.radProgressBar6)
			Me.radGroupBox2.Controls.Add(Me.radProgressBar4)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.FooterText = ""
			Me.radGroupBox2.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Vertical"
			Me.radGroupBox2.Location = New System.Drawing.Point(700, 201)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(112, 245)
			Me.radGroupBox2.TabIndex = 31
			Me.radGroupBox2.Text = "Vertical"
			' 
			' radGroupImage
			' 
			Me.radGroupImage.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radGroupImage.Controls.Add(Me.radProgressBar5)
			Me.radGroupImage.FooterImageIndex = -1
			Me.radGroupImage.FooterImageKey = ""
			Me.radGroupImage.FooterText = ""
			Me.radGroupImage.ForeColor = System.Drawing.Color.Black
			Me.radGroupImage.HeaderImageIndex = -1
			Me.radGroupImage.HeaderImageKey = ""
			Me.radGroupImage.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupImage.HeaderText = "Image"
			Me.radGroupImage.Location = New System.Drawing.Point(413, 346)
			Me.radGroupImage.Name = "radGroupImage"
			Me.radGroupImage.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupImage.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupImage.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupImage.Size = New System.Drawing.Size(281, 100)
			Me.radGroupImage.TabIndex = 32
			Me.radGroupImage.Text = "Image"
			' 
			' radGroupSlider
			' 
			Me.radGroupSlider.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radGroupSlider.Controls.Add(Me.radTrackBar1)
			Me.radGroupSlider.FooterImageIndex = -1
			Me.radGroupSlider.FooterImageKey = ""
			Me.radGroupSlider.FooterText = ""
			Me.radGroupSlider.ForeColor = System.Drawing.Color.Black
			Me.radGroupSlider.HeaderImageIndex = -1
			Me.radGroupSlider.HeaderImageKey = ""
			Me.radGroupSlider.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupSlider.HeaderText = "Slide me!"
			Me.radGroupSlider.Location = New System.Drawing.Point(413, 463)
			Me.radGroupSlider.Name = "radGroupSlider"
			Me.radGroupSlider.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupSlider.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupSlider.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupSlider.Size = New System.Drawing.Size(399, 75)
			Me.radGroupSlider.TabIndex = 33
			Me.radGroupSlider.Text = "Slide me!"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radGroupBox2)
			Me.Controls.Add(Me.radGroupSlider)
			Me.Controls.Add(Me.radGroupImage)
			Me.Controls.Add(Me.radGroupHorizontal)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1224, 737)
			Me.Controls.SetChildIndex(Me.radGroupHorizontal, 0)
			Me.Controls.SetChildIndex(Me.radGroupImage, 0)
			Me.Controls.SetChildIndex(Me.radGroupSlider, 0)
			Me.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radProgressBar6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupHorizontal, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupHorizontal.ResumeLayout(False)
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			CType(Me.radGroupImage, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupImage.ResumeLayout(False)
			CType(Me.radGroupSlider, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupSlider.ResumeLayout(False)
			Me.radGroupSlider.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private WithEvents radProgressBar1 As Telerik.WinControls.UI.RadProgressBar
		Private radProgressBar4 As Telerik.WinControls.UI.RadProgressBar
		Private radProgressBar2 As Telerik.WinControls.UI.RadProgressBar
		Private radProgressBar5 As Telerik.WinControls.UI.RadProgressBar
		Private WithEvents radTrackBar1 As Telerik.WinControls.UI.RadTrackBar
		Private radProgressBar6 As Telerik.WinControls.UI.RadProgressBar
		Private radGroupHorizontal As Telerik.WinControls.UI.RadGroupBox
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radGroupImage As Telerik.WinControls.UI.RadGroupBox
		Private radGroupSlider As Telerik.WinControls.UI.RadGroupBox


	End Class
End Namespace
