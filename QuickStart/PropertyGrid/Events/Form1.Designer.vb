Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.PropertyGrid.Events
	Public Partial Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radTextBoxEvents = New Telerik.WinControls.UI.RadTextBox()
			Me.radPropertyGrid1 = New Telerik.WinControls.UI.RadPropertyGrid()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(1081, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 788)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radTextBoxEvents)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "Events"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 37)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 467)
			Me.radGroupBox1.TabIndex = 1
			Me.radGroupBox1.Text = "Events"
			' 
			' radTextBoxEvents
			' 
			Me.radTextBoxEvents.AcceptsReturn = True
			Me.radTextBoxEvents.Location = New System.Drawing.Point(14, 23)
			Me.radTextBoxEvents.Multiline = True
			Me.radTextBoxEvents.Name = "radTextBoxEvents"
			' 
			' 
			' 
			Me.radTextBoxEvents.RootElement.StretchVertically = True
			Me.radTextBoxEvents.Size = New System.Drawing.Size(153, 431)
			Me.radTextBoxEvents.TabIndex = 0
			Me.radTextBoxEvents.TabStop = False
			' 
			' radPropertyGrid1
			' 
			Me.radPropertyGrid1.Location = New System.Drawing.Point(350, 25)
			Me.radPropertyGrid1.Name = "radPropertyGrid1"
            Me.radPropertyGrid1.ToolbarVisible = True
			Me.radPropertyGrid1.Size = New System.Drawing.Size(350, 530)
			Me.radPropertyGrid1.TabIndex = 1
			Me.radPropertyGrid1.Text = "radPropertyGrid1"
            ' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPropertyGrid1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1282, 790)
			Me.Controls.SetChildIndex(Me.radPropertyGrid1, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPropertyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radTextBoxEvents As Telerik.WinControls.UI.RadTextBox
		Private WithEvents radPropertyGrid1 As Telerik.WinControls.UI.RadPropertyGrid
	End Class
End Namespace
