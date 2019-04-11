Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.GridView.RowsReorder
	Partial Public Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As Global.System.ComponentModel.IContainer = Nothing

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
			Me.components = New Global.System.ComponentModel.Container()
			Dim resources As New Global.System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radGridView1 = New Global.Telerik.WinControls.UI.RadGridView()
			Me.btnMoveUp = New Global.Telerik.WinControls.UI.RadButton()
			Me.btnMoveDown = New Global.Telerik.WinControls.UI.RadButton()
			Me.imageList1 = New Global.System.Windows.Forms.ImageList(Me.components)
			CType(Me.settingsPanel, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGridView1, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGridView1.MasterTemplate, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnMoveUp, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnMoveDown, Global.System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.btnMoveUp)
			Me.settingsPanel.Controls.Add(Me.btnMoveDown)
			Me.settingsPanel.Location = New Global.System.Drawing.Point(751, 1)
			Me.settingsPanel.Size = New Global.System.Drawing.Size(200, 723)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.btnMoveDown, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.btnMoveUp, 0)
			' 
			' radGridView1
			' 
			Me.radGridView1.Dock = Global.System.Windows.Forms.DockStyle.Fill
			Me.radGridView1.Location = New Global.System.Drawing.Point(0, 0)
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Padding = New Global.System.Windows.Forms.Padding(0, 0, 0, 1)
			' 
			' 
			' 
			Me.radGridView1.RootElement.Padding = New Global.System.Windows.Forms.Padding(0, 0, 0, 1)
			Me.radGridView1.Size = New Global.System.Drawing.Size(952, 725)
			Me.radGridView1.TabIndex = 1
			Me.radGridView1.Text = "radGridView1"
			' 
			' btnMoveUp
			' 
			Me.btnMoveUp.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.btnMoveUp.Image = My.Resources.arrow_up2
			Me.btnMoveUp.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.btnMoveUp.Location = New Global.System.Drawing.Point(10, 37)
            Me.btnMoveUp.Name = "btnMoveUp"
            Me.btnMoveUp.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
			Me.btnMoveUp.Size = New Global.System.Drawing.Size(180, 26)
			Me.btnMoveUp.TabIndex = 1
			Me.btnMoveUp.Text = "Move Up"
'			Me.btnMoveUp.Click += New System.EventHandler(Me.btnMoveUp_Click);
			' 
			' btnMoveDown
			' 
			Me.btnMoveDown.Anchor = Global.System.Windows.Forms.AnchorStyles.Top
			Me.btnMoveDown.Image = My.Resources.arrow_down1
			Me.btnMoveDown.ImageScalingSize = New Global.System.Drawing.Size(24, 24)
			Me.btnMoveDown.Location = New Global.System.Drawing.Point(10, 69)
            Me.btnMoveDown.Name = "btnMoveDown"
            Me.btnMoveDown.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
			Me.btnMoveDown.Size = New Global.System.Drawing.Size(180, 26)
			Me.btnMoveDown.TabIndex = 2
			Me.btnMoveDown.Text = "Move Down"
'			Me.btnMoveDown.Click += New System.EventHandler(Me.btnMoveDown_Click);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), Global.System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = Global.System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "TaskCompleted.png")
			Me.imageList1.Images.SetKeyName(1, "TaskNotCompleted.png")
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New Global.System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = Global.System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radGridView1)
			Me.Name = "Form1"
			Me.Size = New Global.System.Drawing.Size(952, 725)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radGridView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGridView1.MasterTemplate, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGridView1, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnMoveUp, Global.System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnMoveDown, Global.System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGridView1 As Global.Telerik.WinControls.UI.RadGridView
		Private WithEvents btnMoveUp As Global.Telerik.WinControls.UI.RadButton
		Private WithEvents btnMoveDown As Global.Telerik.WinControls.UI.RadButton
		Private imageList1 As Global.System.Windows.Forms.ImageList
	End Class
End Namespace
