Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Buttons.RadioButtons
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
			Me.radTextBoxEvents = New Telerik.WinControls.UI.RadTextBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radRadioDonut = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioSquare = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioOffice = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioRound = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioRegular = New Telerik.WinControls.UI.RadRadioButton()
			Me.radRadioCustShape = New Telerik.WinControls.UI.RadRadioButton()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radRadioDonut, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioSquare, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioOffice, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioRound, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioRegular, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRadioCustShape, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radRadioDonut)
			Me.radPanelDemoHolder.Controls.Add(Me.radRadioRegular)
			Me.radPanelDemoHolder.Controls.Add(Me.radRadioSquare)
			Me.radPanelDemoHolder.Controls.Add(Me.radRadioCustShape)
			Me.radPanelDemoHolder.Controls.Add(Me.radRadioRound)
			Me.radPanelDemoHolder.Controls.Add(Me.radRadioOffice)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(384, 219)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(175, 182)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(250, 534)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radTextBoxEvents
			' 
			Me.radTextBoxEvents.ForeColor = System.Drawing.Color.Black
			Me.radTextBoxEvents.Location = New System.Drawing.Point(12, 21)
			Me.radTextBoxEvents.Multiline = True
			Me.radTextBoxEvents.Name = "radTextBoxEvents"
			' 
			' 
			' 
			Me.radTextBoxEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTextBoxEvents.RootElement.StretchVertically = True
			Me.radTextBoxEvents.Size = New System.Drawing.Size(139, 170)
			Me.radTextBoxEvents.TabIndex = 0
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radTextBoxEvents)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.FooterText = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = " Events "
			Me.radGroupBox1.Location = New System.Drawing.Point(15, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.Size = New System.Drawing.Size(162, 203)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = " Events "
			' 
			' radRadioDonut
			' 
			Me.radRadioDonut.ForeColor = System.Drawing.Color.Black
			Me.radRadioDonut.Location = New System.Drawing.Point(33, 115)
			Me.radRadioDonut.Name = "radRadioDonut"
			Me.radRadioDonut.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioDonut.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioDonut.Size = New System.Drawing.Size(50, 16)
			Me.radRadioDonut.TabIndex = 0
			Me.radRadioDonut.Text = "Donut"
'			Me.radRadioDonut.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioCustShape_ToggleStateChanged);
			' 
			' radRadioSquare
			' 
			Me.radRadioSquare.ForeColor = System.Drawing.Color.Black
			Me.radRadioSquare.Location = New System.Drawing.Point(33, 95)
			Me.radRadioSquare.Name = "radRadioSquare"
			Me.radRadioSquare.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioSquare.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioSquare.Size = New System.Drawing.Size(57, 16)
			Me.radRadioSquare.TabIndex = 0
			Me.radRadioSquare.Text = "Square"
'			Me.radRadioSquare.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioCustShape_ToggleStateChanged);
			' 
			' radRadioOffice
			' 
			Me.radRadioOffice.ForeColor = System.Drawing.Color.Black
			Me.radRadioOffice.Location = New System.Drawing.Point(33, 135)
			Me.radRadioOffice.Name = "radRadioOffice"
			Me.radRadioOffice.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioOffice.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioOffice.Size = New System.Drawing.Size(72, 16)
			Me.radRadioOffice.TabIndex = 0
			Me.radRadioOffice.Text = "Office Tab"
'			Me.radRadioOffice.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioCustShape_ToggleStateChanged);
			' 
			' radRadioRound
			' 
			Me.radRadioRound.ForeColor = System.Drawing.Color.Black
			Me.radRadioRound.Location = New System.Drawing.Point(33, 74)
			Me.radRadioRound.Name = "radRadioRound"
			Me.radRadioRound.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioRound.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioRound.Size = New System.Drawing.Size(108, 16)
			Me.radRadioRound.TabIndex = 0
			Me.radRadioRound.Text = "Round Rectangle"
'			Me.radRadioRound.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioCustShape_ToggleStateChanged);
			' 
			' radRadioRegular
			' 
			Me.radRadioRegular.ForeColor = System.Drawing.Color.Black
			Me.radRadioRegular.Location = New System.Drawing.Point(33, 32)
			Me.radRadioRegular.Name = "radRadioRegular"
			Me.radRadioRegular.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioRegular.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioRegular.Size = New System.Drawing.Size(60, 16)
			Me.radRadioRegular.TabIndex = 0
			Me.radRadioRegular.Text = "Regular"
'			Me.radRadioRegular.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioCustShape_ToggleStateChanged);
			' 
			' radRadioCustShape
			' 
			Me.radRadioCustShape.ForeColor = System.Drawing.Color.Black
			Me.radRadioCustShape.Location = New System.Drawing.Point(33, 54)
			Me.radRadioCustShape.Name = "radRadioCustShape"
			Me.radRadioCustShape.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleLeft
			' 
			' 
			' 
			Me.radRadioCustShape.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radRadioCustShape.Size = New System.Drawing.Size(95, 16)
			Me.radRadioCustShape.TabIndex = 0
			Me.radRadioCustShape.Text = "Custom Shape"
'			Me.radRadioCustShape.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radRadioCustShape_ToggleStateChanged);
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 536)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radRadioDonut, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioSquare, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioOffice, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioRound, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioRegular, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRadioCustShape, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radTextBoxEvents As Telerik.WinControls.UI.RadTextBox
		Private WithEvents radRadioDonut As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioSquare As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioOffice As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioRound As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioCustShape As Telerik.WinControls.UI.RadRadioButton
		Private WithEvents radRadioRegular As Telerik.WinControls.UI.RadRadioButton
	End Class
End Namespace
