Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.PageView.StripView.NewItem
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
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.stripAlignCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.newItemVisibilityCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.shrinkItemsCheck = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.stripAlignCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.newItemVisibilityCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.shrinkItemsCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.shrinkItemsCheck)
			Me.settingsPanel.Controls.Add(Me.newItemVisibilityCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel2)
			Me.settingsPanel.Controls.Add(Me.stripAlignCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Location = New System.Drawing.Point(1068, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 443)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.stripAlignCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.newItemVisibilityCombo, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.shrinkItemsCheck, 0)
			' 
			' radPageView1
			' 
			Me.radPageView1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPageView1.Location = New System.Drawing.Point(263, 58)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.Size = New System.Drawing.Size(742, 328)
			Me.radPageView1.TabIndex = 1
			Me.radPageView1.Text = "radPageView1"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(10, 85)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(61, 16)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "Strip Align:"
			' 
			' stripAlignCombo
			' 
			Me.stripAlignCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.stripAlignCombo.AutoCompleteDataSource = Nothing
			Me.stripAlignCombo.AutoSize = True
			Me.stripAlignCombo.DropDownAnimationEnabled = False
			Me.stripAlignCombo.DropDownAnimationFrames = 1
			Me.stripAlignCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.stripAlignCombo.Location = New System.Drawing.Point(10, 107)
			Me.stripAlignCombo.Name = "stripAlignCombo"
			Me.stripAlignCombo.Size = New System.Drawing.Size(180, 20)
			Me.stripAlignCombo.TabIndex = 3
			Me.stripAlignCombo.TabStop = True
'			Me.stripAlignCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.stripAlignCombo_SelectedIndexChanged);
			' 
			' newItemVisibilityCombo
			' 
			Me.newItemVisibilityCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.newItemVisibilityCombo.AutoCompleteDataSource = Nothing
			Me.newItemVisibilityCombo.AutoSize = True
			Me.newItemVisibilityCombo.DropDownAnimationEnabled = False
			Me.newItemVisibilityCombo.DropDownAnimationFrames = 1
			Me.newItemVisibilityCombo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.newItemVisibilityCombo.Location = New System.Drawing.Point(10, 59)
			Me.newItemVisibilityCombo.Name = "newItemVisibilityCombo"
			Me.newItemVisibilityCombo.Size = New System.Drawing.Size(180, 20)
			Me.newItemVisibilityCombo.TabIndex = 5
			Me.newItemVisibilityCombo.TabStop = True
'			Me.newItemVisibilityCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.newItemVisibilityCombo_SelectedIndexChanged);
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel2.Location = New System.Drawing.Point(10, 37)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(101, 16)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "New Item Visibility:"
			' 
			' shrinkItemsCheck
			' 
			Me.shrinkItemsCheck.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.shrinkItemsCheck.Location = New System.Drawing.Point(10, 142)
			Me.shrinkItemsCheck.Name = "shrinkItemsCheck"
			Me.shrinkItemsCheck.Size = New System.Drawing.Size(82, 18)
			Me.shrinkItemsCheck.TabIndex = 6
			Me.shrinkItemsCheck.Text = "Shrink Items"
'			Me.shrinkItemsCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.shrinkItemsCheck_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1269, 445)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.stripAlignCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.newItemVisibilityCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.shrinkItemsCheck, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private WithEvents stripAlignCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents newItemVisibilityCombo As Telerik.WinControls.UI.RadDropDownList
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private WithEvents shrinkItemsCheck As Telerik.WinControls.UI.RadCheckBox
	End Class
End Namespace
