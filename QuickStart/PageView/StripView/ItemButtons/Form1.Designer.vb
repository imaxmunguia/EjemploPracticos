Imports Microsoft.VisualBasic
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports System.Drawing
Imports Telerik.Examples.WinControls

Namespace Telerik.Examples.WinControls.PageView.StripView.ItemButtons
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
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			Me.closeButtonCheck = New Telerik.WinControls.UI.RadCheckBox()
			Me.addButton = New Telerik.WinControls.UI.RadButton()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.closeButtonCheck, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.addButton, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.addButton)
			Me.settingsPanel.Controls.Add(Me.closeButtonCheck)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1068, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 587)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.closeButtonCheck, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.addButton, 0)
			' 
			' radPageView1
			' 
			Me.radPageView1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPageView1.Location = New System.Drawing.Point(398, 102)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.Size = New System.Drawing.Size(472, 385)
			Me.radPageView1.TabIndex = 1
			Me.radPageView1.Text = "radPageView1"
			' 
			' closeButtonCheck
			' 
			Me.closeButtonCheck.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.closeButtonCheck.Location = New System.Drawing.Point(10, 37)
			Me.closeButtonCheck.Name = "closeButtonCheck"
			Me.closeButtonCheck.Size = New System.Drawing.Size(114, 18)
			Me.closeButtonCheck.TabIndex = 1
			Me.closeButtonCheck.Text = "Show Close Button"
'			Me.closeButtonCheck.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.closeButtonCheck_ToggleStateChanged);
			' 
			' addButton
			' 
			Me.addButton.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.addButton.Location = New System.Drawing.Point(10, 71)
			Me.addButton.Name = "addButton"
			Me.addButton.Size = New System.Drawing.Size(180, 24)
			Me.addButton.TabIndex = 2
			Me.addButton.Text = "Add Page"
'			Me.addButton.Click += New System.EventHandler(Me.addButton_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1269, 589)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.closeButtonCheck, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.addButton, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radPageView1 As Telerik.WinControls.UI.RadPageView
		Private WithEvents closeButtonCheck As RadCheckBox
		Private WithEvents addButton As RadButton
	End Class
End Namespace
