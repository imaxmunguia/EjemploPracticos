Imports Microsoft.VisualBasic
Imports System.Drawing
Namespace Telerik.Examples.WinControls.Editors.SpinEdit.FirstLook
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
			Me.radSpinDemo = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radGroupRTL = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBox1 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupEvents = New Telerik.WinControls.UI.RadGroupBox()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radSpinDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupRTL, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupRTL.SuspendLayout()
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupEvents.SuspendLayout()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Controls.Add(Me.radSpinDemo)
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(496, 300)
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(233, 137)
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupRTL)
			Me.settingsPanel.Controls.Add(Me.radGroupEvents)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupEvents, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupRTL, 0)
			' 
			' radSpinDemo
			' 
			Me.radSpinDemo.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radSpinDemo.BackColor = System.Drawing.Color.Transparent
			Me.radSpinDemo.ForeColor = System.Drawing.Color.Black
			Me.radSpinDemo.Location = New System.Drawing.Point(51, 58)
			Me.radSpinDemo.Name = "radSpinDemo"
			' 
			' 
			' 
			Me.radSpinDemo.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSpinDemo.ShowBorder = True
			Me.radSpinDemo.Size = New System.Drawing.Size(131, 20)
			Me.radSpinDemo.TabIndex = 2
			Me.radSpinDemo.TabStop = False
			' 
			' radGroupRTL
			' 
			Me.radGroupRTL.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupRTL.Controls.Add(Me.radCheckBox1)
			Me.radGroupRTL.FooterImageIndex = -1
			Me.radGroupRTL.FooterImageKey = ""
			Me.radGroupRTL.FooterText = ""
			Me.radGroupRTL.ForeColor = System.Drawing.Color.Black
			Me.radGroupRTL.HeaderImageIndex = -1
			Me.radGroupRTL.HeaderImageKey = ""
			Me.radGroupRTL.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupRTL.HeaderText = " RTL Support "
			Me.radGroupRTL.Location = New System.Drawing.Point(10, 6)
			Me.radGroupRTL.Name = "radGroupRTL"
			Me.radGroupRTL.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupRTL.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupRTL.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupRTL.Size = New System.Drawing.Size(180, 58)
			Me.radGroupRTL.TabIndex = 0
			Me.radGroupRTL.Text = " RTL Support "
			' 
			' radCheckBox1
			' 
			Me.radCheckBox1.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox1.Location = New System.Drawing.Point(14, 28)
			Me.radCheckBox1.Name = "radCheckBox1"
			' 
			' 
			' 
			Me.radCheckBox1.RootElement.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))), (CInt(Fix((CByte(5))))))
			Me.radCheckBox1.Size = New System.Drawing.Size(87, 17)
			Me.radCheckBox1.TabIndex = 0
			Me.radCheckBox1.Text = "Right To Left"
'			Me.radCheckBox1.ToggleStateChanged += New Telerik.WinControls.UI.StateChangedEventHandler(Me.OnCheckRightToLeft_StateChanged);
			' 
			' radGroupEvents
			' 
			Me.radGroupEvents.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupEvents.Controls.Add(Me.radButton1)
			Me.radGroupEvents.Controls.Add(Me.radListBox1)
			Me.radGroupEvents.FooterImageIndex = -1
			Me.radGroupEvents.FooterImageKey = ""
			Me.radGroupEvents.FooterText = ""
			Me.radGroupEvents.ForeColor = System.Drawing.Color.Black
			Me.radGroupEvents.HeaderImageIndex = -1
			Me.radGroupEvents.HeaderImageKey = ""
			Me.radGroupEvents.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupEvents.HeaderText = " Events "
			Me.radGroupEvents.Location = New System.Drawing.Point(10, 71)
			Me.radGroupEvents.Name = "radGroupEvents"
			Me.radGroupEvents.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupEvents.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupEvents.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupEvents.Size = New System.Drawing.Size(180, 382)
			Me.radGroupEvents.TabIndex = 0
			Me.radGroupEvents.Text = " Events "
			' 
			' radButton1
			' 
			Me.radButton1.Location = New System.Drawing.Point(14, 314)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(153, 32)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "Clear list"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radListBox1
			' 
			Me.radListBox1.ForeColor = System.Drawing.Color.Black
			Me.radListBox1.Location = New System.Drawing.Point(14, 19)
			Me.radListBox1.Name = "radListBox1"
			' 
			' 
			' 
			Me.radListBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radListBox1.Size = New System.Drawing.Size(153, 276)
			Me.radListBox1.TabIndex = 0
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 737)
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radSpinDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupRTL, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupRTL.ResumeLayout(False)
			CType(Me.radCheckBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupEvents, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupEvents.ResumeLayout(False)
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radSpinDemo As Telerik.WinControls.UI.RadSpinEditor
		Private radGroupEvents As Telerik.WinControls.UI.RadGroupBox
		Private radGroupRTL As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radCheckBox1 As Telerik.WinControls.UI.RadCheckBox
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private radListBox1 As Telerik.WinControls.UI.RadListControl
	End Class
End Namespace