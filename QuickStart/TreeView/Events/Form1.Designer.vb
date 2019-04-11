Namespace Telerik.Examples.WinControls.TreeView.Events
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
			Me.components = New System.ComponentModel.Container()
			Me.radListBox1 = New Telerik.WinControls.UI.RadListControl()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.clearEventsBtn = New Telerik.WinControls.UI.RadButton()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.clearEventsBtn, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			' 
			' radListBox1
			' 
			Me.radListBox1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(248)))), (CInt((CByte(248)))), (CInt((CByte(248)))))
			Me.radListBox1.ForeColor = System.Drawing.Color.Black
			Me.radListBox1.Location = New System.Drawing.Point(10, 25)
			Me.radListBox1.Name = "radListBox1"
			' 
			' 
			' 
			Me.radListBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radListBox1.Size = New System.Drawing.Size(163, 291)
			Me.radListBox1.TabIndex = 1
			' 
			' radTreeView1
			' 
			Me.radTreeView1.AllowEdit = True
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.TabIndex = 0
			Me.radTreeView1.Text = "radTreeView1"
			Me.radTreeView1.Location = New System.Drawing.Point(20, 17)
			Me.radTreeView1.Size = New System.Drawing.Size(246, 441)
			Me.radTreeView1.ItemHeight = 27
			' 
			' clearEventsBtn
			' 
			Me.clearEventsBtn.Location = New System.Drawing.Point(23, 322)
			Me.clearEventsBtn.Name = "clearEventsBtn"
			Me.clearEventsBtn.Size = New System.Drawing.Size(120, 23)
			Me.clearEventsBtn.TabIndex = 2
			Me.clearEventsBtn.Text = "Clear"
'			Me.clearEventsBtn.Click += New System.EventHandler(Me.clearEventsBtn_Click);
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.clearEventsBtn)
			Me.radGroupBox1.Controls.Add(Me.radListBox1)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = " Events "
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 6)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 357)
			Me.radGroupBox1.TabIndex = 3
			Me.radGroupBox1.Text = " Events "
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 737)
			Me.Controls.Add(Me.radTreeView1)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radListBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.clearEventsBtn, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radListBox1 As Telerik.WinControls.UI.RadListControl
		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private WithEvents clearEventsBtn As Telerik.WinControls.UI.RadButton
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox

	End Class
End Namespace