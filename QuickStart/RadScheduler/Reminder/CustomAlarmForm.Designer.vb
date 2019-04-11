Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.RadScheduler.Reminder
	Partial Public Class CustomAlarmForm
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
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radButton3 = New Telerik.WinControls.UI.RadButton()
			Me.radButton4 = New Telerik.WinControls.UI.RadButton()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' radListBox1
			' 
			Me.radListBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radListBox1.Location = New System.Drawing.Point(12, 38)
			Me.radListBox1.Name = "radListBox1"
			Me.radListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
			Me.radListBox1.Size = New System.Drawing.Size(188, 323)
			Me.radListBox1.TabIndex = 0
			Me.radListBox1.Text = "Click to add new item"
'			Me.radListBox1.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(Me.radListBox1_SelectedIndexChanged);
			' 
			' radButton1
			' 
			Me.radButton1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radButton1.Location = New System.Drawing.Point(207, 38)
			Me.radButton1.Name = "radButton1"
			Me.radButton1.Size = New System.Drawing.Size(130, 24)
			Me.radButton1.TabIndex = 1
			Me.radButton1.Text = "Open Item"
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			' 
			' radButton2
			' 
			Me.radButton2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radButton2.Location = New System.Drawing.Point(207, 68)
			Me.radButton2.Name = "radButton2"
			Me.radButton2.Size = New System.Drawing.Size(130, 24)
			Me.radButton2.TabIndex = 2
			Me.radButton2.Text = "Snooze with a minute"
'			Me.radButton2.Click += New System.EventHandler(Me.radButton2_Click);
			' 
			' radButton3
			' 
			Me.radButton3.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radButton3.Location = New System.Drawing.Point(207, 98)
			Me.radButton3.Name = "radButton3"
			Me.radButton3.Size = New System.Drawing.Size(130, 24)
			Me.radButton3.TabIndex = 3
			Me.radButton3.Text = "Dismiss"
'			Me.radButton3.Click += New System.EventHandler(Me.radButton3_Click);
			' 
			' radButton4
			' 
			Me.radButton4.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radButton4.Location = New System.Drawing.Point(207, 128)
			Me.radButton4.Name = "radButton4"
			Me.radButton4.Size = New System.Drawing.Size(130, 24)
			Me.radButton4.TabIndex = 4
			Me.radButton4.Text = "Dismiss All"
'			Me.radButton4.Click += New System.EventHandler(Me.radButton4_Click);
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(13, 13)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(41, 16)
			Me.radLabel1.TabIndex = 5
			Me.radLabel1.Text = "Events"
			' 
			' CustomAlarmForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(349, 387)
			Me.Controls.Add(Me.radLabel1)
			Me.Controls.Add(Me.radButton4)
			Me.Controls.Add(Me.radButton3)
			Me.Controls.Add(Me.radButton2)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radListBox1)
			Me.Name = "CustomAlarmForm"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "CustomAlarmForm"
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.CustomAlarmForm_FormClosing);
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents radListBox1 As Telerik.WinControls.UI.RadListControl
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton2 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton3 As Telerik.WinControls.UI.RadButton
		Private WithEvents radButton4 As Telerik.WinControls.UI.RadButton
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace