Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.PageView.OutlookView.FirstLook
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
			Me.pageView = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radScrollablePanel2 = New Telerik.WinControls.UI.RadScrollablePanel()
			Me.pictureBox5 = New System.Windows.Forms.PictureBox()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radScrollablePanel5 = New Telerik.WinControls.UI.RadScrollablePanel()
			Me.pictureBox4 = New System.Windows.Forms.PictureBox()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radScrollablePanel4 = New Telerik.WinControls.UI.RadScrollablePanel()
			Me.pictureBox3 = New System.Windows.Forms.PictureBox()
			Me.radPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radScrollablePanel3 = New Telerik.WinControls.UI.RadScrollablePanel()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.radPageViewPage6 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radScrollablePanel1 = New Telerik.WinControls.UI.RadScrollablePanel()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pageView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pageView.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me.radScrollablePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radScrollablePanel2.PanelContainer.SuspendLayout()
			Me.radScrollablePanel2.SuspendLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage2.SuspendLayout()
			CType(Me.radScrollablePanel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radScrollablePanel5.PanelContainer.SuspendLayout()
			Me.radScrollablePanel5.SuspendLayout()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage3.SuspendLayout()
			CType(Me.radScrollablePanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radScrollablePanel4.PanelContainer.SuspendLayout()
			Me.radScrollablePanel4.SuspendLayout()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage4.SuspendLayout()
			CType(Me.radScrollablePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radScrollablePanel3.PanelContainer.SuspendLayout()
			Me.radScrollablePanel3.SuspendLayout()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPageViewPage6.SuspendLayout()
			CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radScrollablePanel1.PanelContainer.SuspendLayout()
			Me.radScrollablePanel1.SuspendLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Location = New System.Drawing.Point(680, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 806)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' pageView
			' 
			Me.pageView.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.pageView.Controls.Add(Me.radPageViewPage1)
			Me.pageView.Controls.Add(Me.radPageViewPage2)
			Me.pageView.Controls.Add(Me.radPageViewPage3)
			Me.pageView.Controls.Add(Me.radPageViewPage4)
			Me.pageView.Controls.Add(Me.radPageViewPage6)
			Me.pageView.Location = New System.Drawing.Point(298, 178)
			Me.pageView.Name = "pageView"
			Me.pageView.SelectedPage = Me.radPageViewPage1
			Me.pageView.Size = New System.Drawing.Size(285, 453)
			Me.pageView.TabIndex = 1
			Me.pageView.ViewMode = Telerik.WinControls.UI.PageViewMode.Outlook
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radScrollablePanel2)
			Me.radPageViewPage1.Location = New System.Drawing.Point(5, 28)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(275, 221)
			Me.radPageViewPage1.Text = "Notes"
			Me.radPageViewPage1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radScrollablePanel2
			' 
			Me.radScrollablePanel2.AutoScroll = True
			Me.radScrollablePanel2.AutoScrollMargin = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel2.Location = New System.Drawing.Point(0, 0)
			Me.radScrollablePanel2.Name = "radScrollablePanel2"
			Me.radScrollablePanel2.Padding = New System.Windows.Forms.Padding(1)
			' 
			' radScrollablePanel2.PanelContainer
			' 
			Me.radScrollablePanel2.PanelContainer.AutoScroll = True
			Me.radScrollablePanel2.PanelContainer.Controls.Add(Me.pictureBox5)
			Me.radScrollablePanel2.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel2.PanelContainer.Location = New System.Drawing.Point(1, 1)
			Me.radScrollablePanel2.PanelContainer.Name = "PanelContainer"
			Me.radScrollablePanel2.PanelContainer.Size = New System.Drawing.Size(256, 202)
			Me.radScrollablePanel2.PanelContainer.TabIndex = 0
			' 
			' 
			' 
			Me.radScrollablePanel2.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.radScrollablePanel2.Size = New System.Drawing.Size(275, 221)
			Me.radScrollablePanel2.TabIndex = 3
			' 
			' pictureBox5
			' 
			Me.pictureBox5.Image = My.Resources.Notes
			Me.pictureBox5.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New System.Drawing.Size(279, 269)
			Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.pictureBox5.TabIndex = 0
			Me.pictureBox5.TabStop = False
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Controls.Add(Me.radScrollablePanel5)
			Me.radPageViewPage2.Location = New System.Drawing.Point(5, 28)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(275, 221)
			Me.radPageViewPage2.Text = "Tasks"
			Me.radPageViewPage2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radScrollablePanel5
			' 
			Me.radScrollablePanel5.AutoScroll = True
			Me.radScrollablePanel5.AutoScrollMargin = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel5.AutoScrollMinSize = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel5.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel5.Location = New System.Drawing.Point(0, 0)
			Me.radScrollablePanel5.Name = "radScrollablePanel5"
			Me.radScrollablePanel5.Padding = New System.Windows.Forms.Padding(1)
			' 
			' radScrollablePanel5.PanelContainer
			' 
			Me.radScrollablePanel5.PanelContainer.AutoScroll = True
			Me.radScrollablePanel5.PanelContainer.Controls.Add(Me.pictureBox4)
			Me.radScrollablePanel5.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel5.PanelContainer.Location = New System.Drawing.Point(1, 1)
			Me.radScrollablePanel5.PanelContainer.Name = "PanelContainer"
			Me.radScrollablePanel5.PanelContainer.Size = New System.Drawing.Size(256, 202)
			Me.radScrollablePanel5.PanelContainer.TabIndex = 0
			' 
			' 
			' 
			Me.radScrollablePanel5.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.radScrollablePanel5.Size = New System.Drawing.Size(275, 221)
			Me.radScrollablePanel5.TabIndex = 3
			' 
			' pictureBox4
			' 
			Me.pictureBox4.Image = My.Resources.Tasks
			Me.pictureBox4.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New System.Drawing.Size(279, 454)
			Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.pictureBox4.TabIndex = 0
			Me.pictureBox4.TabStop = False
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.Controls.Add(Me.radScrollablePanel4)
			Me.radPageViewPage3.Location = New System.Drawing.Point(5, 28)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New System.Drawing.Size(275, 221)
			Me.radPageViewPage3.Text = "Contacts"
			Me.radPageViewPage3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radScrollablePanel4
			' 
			Me.radScrollablePanel4.AutoScroll = True
			Me.radScrollablePanel4.AutoScrollMargin = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel4.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel4.Location = New System.Drawing.Point(0, 0)
			Me.radScrollablePanel4.Name = "radScrollablePanel4"
			Me.radScrollablePanel4.Padding = New System.Windows.Forms.Padding(1)
			' 
			' radScrollablePanel4.PanelContainer
			' 
			Me.radScrollablePanel4.PanelContainer.AutoScroll = True
			Me.radScrollablePanel4.PanelContainer.Controls.Add(Me.pictureBox3)
			Me.radScrollablePanel4.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel4.PanelContainer.Location = New System.Drawing.Point(1, 1)
			Me.radScrollablePanel4.PanelContainer.Name = "PanelContainer"
			Me.radScrollablePanel4.PanelContainer.Size = New System.Drawing.Size(256, 202)
			Me.radScrollablePanel4.PanelContainer.TabIndex = 0
			' 
			' 
			' 
			Me.radScrollablePanel4.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.radScrollablePanel4.Size = New System.Drawing.Size(275, 221)
			Me.radScrollablePanel4.TabIndex = 3
			' 
			' pictureBox3
			' 
			Me.pictureBox3.Image = My.Resources.Contacts
			Me.pictureBox3.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New System.Drawing.Size(279, 326)
			Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.pictureBox3.TabIndex = 0
			Me.pictureBox3.TabStop = False
			' 
			' radPageViewPage4
			' 
			Me.radPageViewPage4.Controls.Add(Me.radScrollablePanel3)
			Me.radPageViewPage4.Location = New System.Drawing.Point(5, 28)
			Me.radPageViewPage4.Name = "radPageViewPage4"
			Me.radPageViewPage4.Size = New System.Drawing.Size(275, 221)
			Me.radPageViewPage4.Text = "Calendar"
			Me.radPageViewPage4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radScrollablePanel3
			' 
			Me.radScrollablePanel3.AutoScroll = True
			Me.radScrollablePanel3.AutoScrollMargin = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel3.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel3.Location = New System.Drawing.Point(0, 0)
			Me.radScrollablePanel3.Name = "radScrollablePanel3"
			Me.radScrollablePanel3.Padding = New System.Windows.Forms.Padding(1)
			' 
			' radScrollablePanel3.PanelContainer
			' 
			Me.radScrollablePanel3.PanelContainer.AutoScroll = True
			Me.radScrollablePanel3.PanelContainer.Controls.Add(Me.pictureBox2)
			Me.radScrollablePanel3.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel3.PanelContainer.Location = New System.Drawing.Point(1, 1)
			Me.radScrollablePanel3.PanelContainer.Name = "PanelContainer"
			Me.radScrollablePanel3.PanelContainer.Size = New System.Drawing.Size(256, 202)
			Me.radScrollablePanel3.PanelContainer.TabIndex = 0
			' 
			' 
			' 
			Me.radScrollablePanel3.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.radScrollablePanel3.Size = New System.Drawing.Size(275, 221)
			Me.radScrollablePanel3.TabIndex = 3
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Image = My.Resources.Calendar
			Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(279, 556)
			Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.pictureBox2.TabIndex = 0
			Me.pictureBox2.TabStop = False
			' 
			' radPageViewPage6
			' 
			Me.radPageViewPage6.Controls.Add(Me.radScrollablePanel1)
			Me.radPageViewPage6.Location = New System.Drawing.Point(5, 28)
			Me.radPageViewPage6.Name = "radPageViewPage6"
			Me.radPageViewPage6.Size = New System.Drawing.Size(275, 221)
			Me.radPageViewPage6.Text = "Mail"
			Me.radPageViewPage6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radScrollablePanel1
			' 
			Me.radScrollablePanel1.AutoScroll = True
			Me.radScrollablePanel1.AutoScrollMargin = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
			Me.radScrollablePanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel1.Location = New System.Drawing.Point(0, 0)
			Me.radScrollablePanel1.Name = "radScrollablePanel1"
			Me.radScrollablePanel1.Padding = New System.Windows.Forms.Padding(1)
			' 
			' radScrollablePanel1.PanelContainer
			' 
			Me.radScrollablePanel1.PanelContainer.AutoScroll = True
			Me.radScrollablePanel1.PanelContainer.Controls.Add(Me.pictureBox1)
			Me.radScrollablePanel1.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radScrollablePanel1.PanelContainer.Location = New System.Drawing.Point(1, 1)
			Me.radScrollablePanel1.PanelContainer.Name = "PanelContainer"
			Me.radScrollablePanel1.PanelContainer.Size = New System.Drawing.Size(256, 202)
			Me.radScrollablePanel1.PanelContainer.TabIndex = 0
			' 
			' 
			' 
			Me.radScrollablePanel1.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.radScrollablePanel1.Size = New System.Drawing.Size(275, 221)
			Me.radScrollablePanel1.TabIndex = 2
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Image = My.Resources.Mail
			Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(278, 385)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pageView)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(881, 808)
			Me.Controls.SetChildIndex(Me.pageView, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pageView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pageView.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			Me.radScrollablePanel2.PanelContainer.ResumeLayout(False)
			Me.radScrollablePanel2.PanelContainer.PerformLayout()
			CType(Me.radScrollablePanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radScrollablePanel2.ResumeLayout(False)
			Me.radScrollablePanel2.PerformLayout()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage2.ResumeLayout(False)
			Me.radScrollablePanel5.PanelContainer.ResumeLayout(False)
			Me.radScrollablePanel5.PanelContainer.PerformLayout()
			CType(Me.radScrollablePanel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radScrollablePanel5.ResumeLayout(False)
			Me.radScrollablePanel5.PerformLayout()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage3.ResumeLayout(False)
			Me.radScrollablePanel4.PanelContainer.ResumeLayout(False)
			Me.radScrollablePanel4.PanelContainer.PerformLayout()
			CType(Me.radScrollablePanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radScrollablePanel4.ResumeLayout(False)
			Me.radScrollablePanel4.PerformLayout()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage4.ResumeLayout(False)
			Me.radScrollablePanel3.PanelContainer.ResumeLayout(False)
			Me.radScrollablePanel3.PanelContainer.PerformLayout()
			CType(Me.radScrollablePanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radScrollablePanel3.ResumeLayout(False)
			Me.radScrollablePanel3.PerformLayout()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPageViewPage6.ResumeLayout(False)
			Me.radScrollablePanel1.PanelContainer.ResumeLayout(False)
			Me.radScrollablePanel1.PanelContainer.PerformLayout()
			CType(Me.radScrollablePanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radScrollablePanel1.ResumeLayout(False)
			Me.radScrollablePanel1.PerformLayout()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pageView As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage6 As Telerik.WinControls.UI.RadPageViewPage
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private radScrollablePanel1 As Telerik.WinControls.UI.RadScrollablePanel
		Private radScrollablePanel3 As Telerik.WinControls.UI.RadScrollablePanel
		Private pictureBox2 As System.Windows.Forms.PictureBox
		Private radScrollablePanel2 As Telerik.WinControls.UI.RadScrollablePanel
		Private radScrollablePanel4 As Telerik.WinControls.UI.RadScrollablePanel
		Private pictureBox3 As System.Windows.Forms.PictureBox
		Private radScrollablePanel5 As Telerik.WinControls.UI.RadScrollablePanel
		Private pictureBox4 As System.Windows.Forms.PictureBox
		Private pictureBox5 As System.Windows.Forms.PictureBox
	End Class
End Namespace
