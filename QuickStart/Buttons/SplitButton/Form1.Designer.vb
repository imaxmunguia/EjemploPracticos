Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Buttons.SplitButton
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radSplitButton3 = New Telerik.WinControls.UI.RadSplitButton()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSplitButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radSplitButton3)
			Me.radPanelDemoHolder.Controls.Add(Me.radButton1)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(348, 110)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(527, 316)
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
			' radButton1
			' 
			Me.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton1.ForeColor = System.Drawing.Color.Black
			Me.radButton1.Image = My.Resources.telerikLogo
			Me.radButton1.Location = New System.Drawing.Point(277, 127)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton1.RootElement.StretchHorizontally = False
			Me.radButton1.RootElement.StretchVertically = False
			Me.radButton1.Size = New System.Drawing.Size(171, 62)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "radButton2"
			' 
			' radSplitButton3
			' 
			Me.radSplitButton3.BackColor = System.Drawing.Color.White
			Me.radSplitButton3.DefaultItem = Nothing
			Me.radSplitButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F)
			Me.radSplitButton3.ForeColor = System.Drawing.Color.Black
			Me.radSplitButton3.ImageList = Me.imageList1
			Me.radSplitButton3.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2})
			Me.radSplitButton3.Location = New System.Drawing.Point(78, 134)
			Me.radSplitButton3.Name = "radSplitButton3"
			' 
			' 
			' 
			Me.radSplitButton3.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSplitButton3.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSplitButton3.RootElement.ToolTipText = Nothing
			Me.radSplitButton3.Size = New System.Drawing.Size(161, 48)
			Me.radSplitButton3.TabIndex = 6
			Me.radSplitButton3.Text = "Split Button"
			Me.radSplitButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Lime
			Me.imageList1.Images.SetKeyName(0, "2_redo.gif")
			Me.imageList1.Images.SetKeyName(1, "1_undo.gif")
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.ImageIndex = 0
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "Rotate" & Constants.vbCrLf & "Clockwise"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem1.ToolTipText = Nothing
'			Me.radMenuItem1.Click += New System.EventHandler(Me.radMenuItem1_Click);
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.ImageIndex = 1
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Rotate" & Constants.vbCrLf & "Counter-clockwise"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radMenuItem2.ToolTipText = Nothing
'			Me.radMenuItem2.Click += New System.EventHandler(Me.radMenuItem2_Click);
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1224, 536)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSplitButton3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radSplitButton3 As Telerik.WinControls.UI.RadSplitButton
		Private WithEvents radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private WithEvents radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private imageList1 As System.Windows.Forms.ImageList
		Private radButton1 As Telerik.WinControls.UI.RadButton
	End Class
End Namespace