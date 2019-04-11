Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Forms.RadAboutBox
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
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radRadioButton1 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton2 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton3 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton4 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioButton5 = New Telerik.WinControls.UI.RadRadioButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(250, 617)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radButton1.Location = New System.Drawing.Point(498, 294)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.Size = New System.Drawing.Size(229, 30)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "Show RadAboutBox"
			' 
			' radRadioButton1
			' 
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			Me.radRadioButton1.Location = New System.Drawing.Point(28, 21)
			Me.radRadioButton1.Name = "radRadioButton1"
			Me.radRadioButton1.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButton1.Size = New System.Drawing.Size(101, 16)
			Me.radRadioButton1.TabIndex = 12
            Me.radRadioButton1.Text = "ControlDefault"
			Me.radRadioButton1.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On
			' 
			' radRadioButton2
			' 
			Me.radRadioButton2.Location = New System.Drawing.Point(28, 43)
			Me.radRadioButton2.Name = "radRadioButton2"
			Me.radRadioButton2.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButton2.Size = New System.Drawing.Size(106, 16)
			Me.radRadioButton2.TabIndex = 13
            Me.radRadioButton2.Text = "Office2010 Silver"
			' 
			' radRadioButton3
			' 
			Me.radRadioButton3.Location = New System.Drawing.Point(28, 65)
			Me.radRadioButton3.Name = "radRadioButton3"
			Me.radRadioButton3.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButton3.Size = New System.Drawing.Size(106, 16)
			Me.radRadioButton3.TabIndex = 14
            Me.radRadioButton3.Text = "Office2010 Black"
			' 
			' radRadioButton4
			' 
			Me.radRadioButton4.Location = New System.Drawing.Point(28, 87)
			Me.radRadioButton4.Name = "radRadioButton4"
			Me.radRadioButton4.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButton4.Size = New System.Drawing.Size(47, 16)
			Me.radRadioButton4.TabIndex = 15
            Me.radRadioButton4.Text = "Office 2010 Blue"
			' 
			' radRadioButton5
			' 
			Me.radRadioButton5.Location = New System.Drawing.Point(28, 109)
			Me.radRadioButton5.Name = "radRadioButton5"
			Me.radRadioButton5.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioButton5.Size = New System.Drawing.Size(54, 16)
			Me.radRadioButton5.TabIndex = 16
			Me.radRadioButton5.Text = "Desert"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radRadioButton1)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton5)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton2)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton4)
			Me.radGroupBox1.Controls.Add(Me.radRadioButton3)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Select Theme"
			Me.radGroupBox1.Location = New System.Drawing.Point(15, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.Size = New System.Drawing.Size(162, 139)
			Me.radGroupBox1.TabIndex = 17
			Me.radGroupBox1.Text = "Select Theme"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radButton1)
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(20)
			Me.Size = New System.Drawing.Size(1224, 619)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radButton1, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioButton5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radButton1 As Telerik.WinControls.UI.RadButton
		Private radRadioButton5 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton4 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton3 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton2 As Telerik.WinControls.UI.RadRadioButton
		Private radRadioButton1 As Telerik.WinControls.UI.RadRadioButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace