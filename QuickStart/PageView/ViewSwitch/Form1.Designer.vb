Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.PageView.ViewSwitch
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
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.viewModeCombo = New Telerik.WinControls.UI.RadDropDownList()
			Me.radPageView1 = New Telerik.WinControls.UI.RadPageView()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.viewModeCombo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.viewModeCombo)
			Me.settingsPanel.Controls.Add(Me.radLabel1)
			Me.settingsPanel.Location = New System.Drawing.Point(1002, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 536)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radLabel1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.viewModeCombo, 0)
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(10, 37)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(65, 16)
			Me.radLabel1.TabIndex = 1
			Me.radLabel1.Text = "View Mode:"
			' 
			' viewModeCombo
			' 
			Me.viewModeCombo.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.viewModeCombo.Location = New System.Drawing.Point(10, 59)
			Me.viewModeCombo.Name = "viewModeCombo"
			' 
			' 
			' 
			Me.viewModeCombo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.viewModeCombo.Size = New System.Drawing.Size(180, 20)
			Me.viewModeCombo.TabIndex = 2
			Me.viewModeCombo.TabStop = False
'			Me.viewModeCombo.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.viewModeCombo_SelectedIndexChanged);
			' 
			' radPageView1
			' 
			Me.radPageView1.Location = New System.Drawing.Point(265, 60)
			Me.radPageView1.Name = "radPageView1"
			Me.radPageView1.Size = New System.Drawing.Size(519, 419)
			Me.radPageView1.TabIndex = 1
			Me.radPageView1.Text = "radPageView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPageView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1203, 538)
			Me.Controls.SetChildIndex(Me.radPageView1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.viewModeCombo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPageView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private WithEvents viewModeCombo As Telerik.WinControls.UI.RadDropDownList
		Private radPageView1 As Telerik.WinControls.UI.RadPageView
	End Class
End Namespace
