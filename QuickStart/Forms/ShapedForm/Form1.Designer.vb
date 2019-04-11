Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Forms.ShapedForm
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
			Me.radGroupShapeOpts = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioCD = New Telerik.WinControls.UI.RadRadioButton()
			Me.radButtonCreate = New Telerik.WinControls.UI.RadButton()
			Me.radRadioRound = New Telerik.WinControls.UI.RadRadioButton()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radButtonPop = New Telerik.WinControls.UI.RadButton()
			Me.object_6529839b_d73e_4e3a_9de1_163a623271ad = New Telerik.WinControls.RootRadElement()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupShapeOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupShapeOpts.SuspendLayout()
			CType(Me.radRadioCD, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonCreate, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioRound, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButtonPop, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radButtonPop)
			Me.settingsPanel.Controls.Add(Me.radGroupShapeOpts)
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 818)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupShapeOpts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radButtonPop, 0)
			' 
			' radGroupShapeOpts
			' 
			Me.radGroupShapeOpts.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupShapeOpts.Controls.Add(Me.radRadioCD)
			Me.radGroupShapeOpts.Controls.Add(Me.radButtonCreate)
			Me.radGroupShapeOpts.Controls.Add(Me.radRadioRound)
			Me.radGroupShapeOpts.FooterImageIndex = -1
			Me.radGroupShapeOpts.FooterImageKey = ""
			Me.radGroupShapeOpts.FooterText = ""
			Me.radGroupShapeOpts.ForeColor = System.Drawing.Color.Black
			Me.radGroupShapeOpts.HeaderImageIndex = -1
			Me.radGroupShapeOpts.HeaderImageKey = ""
			Me.radGroupShapeOpts.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupShapeOpts.HeaderText = "Shape Options"
			Me.radGroupShapeOpts.Location = New System.Drawing.Point(10, 6)
			Me.radGroupShapeOpts.Name = "radGroupShapeOpts"
			Me.radGroupShapeOpts.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupShapeOpts.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupShapeOpts.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupShapeOpts.Size = New System.Drawing.Size(180, 117)
			Me.radGroupShapeOpts.TabIndex = 0
			Me.radGroupShapeOpts.Text = "Shape Options"
			' 
			' radRadioCD
			' 
			Me.radRadioCD.ForeColor = System.Drawing.Color.Black
			Me.radRadioCD.Location = New System.Drawing.Point(20, 54)
			Me.radRadioCD.Name = "radRadioCD"
			' 
			' 
			' 
			Me.radRadioCD.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioCD.Size = New System.Drawing.Size(37, 16)
			Me.radRadioCD.TabIndex = 0
			Me.radRadioCD.Text = "CD"
'			Me.radRadioCD.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged);
			' 
			' radButtonCreate
			' 
			Me.radButtonCreate.Location = New System.Drawing.Point(20, 76)
			Me.radButtonCreate.Name = "radButtonCreate"
			Me.radButtonCreate.Size = New System.Drawing.Size(108, 23)
			Me.radButtonCreate.TabIndex = 2
			Me.radButtonCreate.Text = "Create New Shape"
'			Me.radButtonCreate.Click += New System.EventHandler(Me.radButtonCreate_Click);
			' 
			' radRadioRound
			' 
			Me.radRadioRound.ForeColor = System.Drawing.Color.Black
			Me.radRadioRound.Location = New System.Drawing.Point(20, 32)
			Me.radRadioRound.Name = "radRadioRound"
			' 
			' 
			' 
			Me.radRadioRound.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioRound.Size = New System.Drawing.Size(108, 16)
			Me.radRadioRound.TabIndex = 0
			Me.radRadioRound.Text = "Round Rectangle"
'			Me.radRadioRound.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioButton1_ToggleStateChanged);
			' 
			' radPanel1
			' 
			Me.radPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanel1.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Location = New System.Drawing.Point(411, 258)
			Me.radPanel1.Name = "radPanel1"
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Size = New System.Drawing.Size(402, 304)
			Me.radPanel1.TabIndex = 1
			' 
			' radButtonPop
			' 
			Me.radButtonPop.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radButtonPop.Location = New System.Drawing.Point(10, 129)
			Me.radButtonPop.Name = "radButtonPop"
			Me.radButtonPop.Size = New System.Drawing.Size(180, 23)
			Me.radButtonPop.TabIndex = 1
			Me.radButtonPop.Text = "Pop Form Out"
'			Me.radButtonPop.Click += New System.EventHandler(Me.radButtonPop_Click);
			' 
			' object_6529839b_d73e_4e3a_9de1_163a623271ad
			' 
			Me.object_6529839b_d73e_4e3a_9de1_163a623271ad.Name = "object_6529839b_d73e_4e3a_9de1_163a623271ad"
			Me.object_6529839b_d73e_4e3a_9de1_163a623271ad.StretchHorizontally = True
			Me.object_6529839b_d73e_4e3a_9de1_163a623271ad.StretchVertically = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 820)
			Me.Controls.SetChildIndex(Me.radPanel1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGroupShapeOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupShapeOpts.ResumeLayout(False)
			CType(Me.radRadioCD, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonCreate, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioRound, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButtonPop, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupShapeOpts As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radRadioCD As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioRound As Telerik.WinControls.UI.RadRadioButton
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private WithEvents radButtonPop As Telerik.WinControls.UI.RadButton
		Private object_6529839b_d73e_4e3a_9de1_163a623271ad As Telerik.WinControls.RootRadElement
		Private WithEvents radButtonCreate As Telerik.WinControls.UI.RadButton
	End Class
End Namespace