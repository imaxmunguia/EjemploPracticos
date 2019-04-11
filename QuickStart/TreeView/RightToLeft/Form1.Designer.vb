Namespace Telerik.Examples.WinControls.TreeView.RightToLeft
	Partial Friend Class Form1
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
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.radCheckBoxRightToLeft = New Telerik.WinControls.UI.RadCheckBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBoxRightToLeft, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radCheckBoxRightToLeft)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1040, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 830)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radCheckBoxRightToLeft, 0)
			' 
			' radTreeView1
			' 
			Me.radTreeView1.AccessibleName = "RadTreeView"
			Me.radTreeView1.AccessibleRole = System.Windows.Forms.AccessibleRole.List
			Me.radTreeView1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radTreeView1.BackColor = System.Drawing.Color.Transparent
			Me.radTreeView1.CheckBoxes = True
			Me.radTreeView1.Cursor = System.Windows.Forms.Cursors.Default
			Me.radTreeView1.Font = New System.Drawing.Font("Tahoma", 8.6F)
			Me.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radTreeView1.Location = New System.Drawing.Point(17, 19)
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.Size = New System.Drawing.Size(246, 441)
			Me.radTreeView1.TabIndex = 0
			Me.radTreeView1.Text = "radTreeView1"
			Me.radTreeView1.ItemHeight = 27
			' 
			' radCheckBoxRightToLeft
			' 
			Me.radCheckBoxRightToLeft.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxRightToLeft.Location = New System.Drawing.Point(10, 37)
			Me.radCheckBoxRightToLeft.Name = "radCheckBoxRightToLeft"
			Me.radCheckBoxRightToLeft.Size = New System.Drawing.Size(82, 18)
			Me.radCheckBoxRightToLeft.TabIndex = 1
			Me.radCheckBoxRightToLeft.Text = "Right to Left"
'			Me.radCheckBoxRightToLeft.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBoxRightToLeft_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radTreeView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1241, 832)
			Me.Controls.SetChildIndex(Me.radTreeView1, 1)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBoxRightToLeft, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private WithEvents radCheckBoxRightToLeft As Telerik.WinControls.UI.RadCheckBox


	End Class
End Namespace