Imports Microsoft.VisualBasic
Imports System.ComponentModel
Namespace Telerik.Examples.WinControls.Buttons.CheckBoxes
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
			Me.components = New Container()
			Me.radCheckBox3 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox2 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupEvents = New Telerik.WinControls.UI.RadGroupBox()
			Me.radTextBoxEvents = New Telerik.WinControls.UI.RadTextBox()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupEvents.SuspendLayout()
			CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radCheckBox1)
			Me.radPanelDemoHolder.Controls.Add(Me.radCheckBox3)
			Me.radPanelDemoHolder.Controls.Add(Me.radCheckBox2)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(512, 218)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(255, 173)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupEvents)
			Me.settingsPanel.Location = New System.Drawing.Point(973, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(250, 534)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupEvents, 0)
			' 
			' radCheckBox3
			' 
			Me.radCheckBox3.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox3.Font = New System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radCheckBox3.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox3.Location = New System.Drawing.Point(72, 98)
			Me.radCheckBox3.Name = "radCheckBox3"
			' 
			' 
			' 
			Me.radCheckBox3.RootElement.ToolTipText = Nothing
			Me.radCheckBox3.Size = New System.Drawing.Size(111, 26)
			Me.radCheckBox3.TabIndex = 2
			Me.radCheckBox3.Text = "Arial, 14pt"
			Me.radCheckBox3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
'			Me.radCheckBox3.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox1_ToggleStateChanged);
			' 
			' radCheckBox2
			' 
			Me.radCheckBox2.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox2.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.radCheckBox2.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox2.Location = New System.Drawing.Point(72, 73)
			Me.radCheckBox2.Name = "radCheckBox2"
			' 
			' 
			' 
			Me.radCheckBox2.RootElement.ToolTipText = Nothing
			Me.radCheckBox2.Size = New System.Drawing.Size(98, 22)
			Me.radCheckBox2.TabIndex = 1
			Me.radCheckBox2.Text = "Arial, 12pt"
			Me.radCheckBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
'			Me.radCheckBox2.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox1_ToggleStateChanged);
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.BackColor = System.Drawing.Color.Transparent
			Me.radCheckBox1.Font = New System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.radCheckBox1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox1.Location = New System.Drawing.Point(72, 48)
			Me.radCheckBox1.Name = "radCheckBox1"
			' 
			' 
			' 
			Me.radCheckBox1.RootElement.ToolTipText = Nothing
			Me.radCheckBox1.Size = New System.Drawing.Size(85, 19)
			Me.radCheckBox1.TabIndex = 0
			Me.radCheckBox1.Text = "Arial, 10pt"
			Me.radCheckBox1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
'			Me.radCheckBox1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.radCheckBox1_ToggleStateChanged);
			' 
			' radGroupEvents
			' 
			Me.radGroupEvents.Controls.Add(Me.radTextBoxEvents)
			Me.radGroupEvents.FooterImageIndex = -1
			Me.radGroupEvents.FooterImageKey = ""
			Me.radGroupEvents.FooterText = ""
			Me.radGroupEvents.ForeColor = System.Drawing.Color.Black
			Me.radGroupEvents.HeaderImageIndex = -1
			Me.radGroupEvents.HeaderImageKey = ""
			Me.radGroupEvents.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupEvents.HeaderText = " Events "
			Me.radGroupEvents.Location = New System.Drawing.Point(15, 6)
			Me.radGroupEvents.Name = "radGroupEvents"
			' 
			' 
			' 
			Me.radGroupEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupEvents.Size = New System.Drawing.Size(162, 188)
			Me.radGroupEvents.TabIndex = 0
			Me.radGroupEvents.Text = " Events "
			' 
			' radTextBoxEvents
			' 
			Me.radTextBoxEvents.ForeColor = System.Drawing.Color.Black
			Me.radTextBoxEvents.Location = New System.Drawing.Point(13, 23)
			Me.radTextBoxEvents.Multiline = True
			Me.radTextBoxEvents.Name = "radTextBoxEvents"
			' 
			' 
			' 
			Me.radTextBoxEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radTextBoxEvents.RootElement.StretchVertically = True
			Me.radTextBoxEvents.Size = New System.Drawing.Size(138, 154)
			Me.radTextBoxEvents.TabIndex = 0
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Padding = New System.Windows.Forms.Padding(2, 35, 2, 4)
			Me.Size = New System.Drawing.Size(1224, 536)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radCheckBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupEvents.ResumeLayout(False)
			Me.radGroupEvents.PerformLayout()
			CType(Me.radTextBoxEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox2 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radCheckBox3 As Telerik.WinControls.UI.RadCheckBox
		Private radGroupEvents As Telerik.WinControls.UI.RadGroupBox
		Private radTextBoxEvents As Telerik.WinControls.UI.RadTextBox
	End Class
End Namespace