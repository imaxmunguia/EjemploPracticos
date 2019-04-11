Namespace Telerik.Examples.WinControls.RadScheduler.Grouping
	Partial Class Form1
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
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radSchedulerDemo = New Telerik.WinControls.UI.RadScheduler()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radSchedulerNavigator1 = New Telerik.WinControls.UI.RadSchedulerNavigator()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1042, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 269)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radSchedulerDemo
			' 
			Me.radSchedulerDemo.BackColor = System.Drawing.Color.White
			Me.radSchedulerDemo.DataSource = Nothing
			Me.radSchedulerDemo.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radSchedulerDemo.ForeColor = System.Drawing.Color.Black
			Me.radSchedulerDemo.GroupType = Telerik.WinControls.UI.GroupType.None
			Me.radSchedulerDemo.HeaderFormat = "MMMM dd"
			Me.radSchedulerDemo.Location = New System.Drawing.Point(0, 78)
			Me.radSchedulerDemo.Name = "radSchedulerDemo"
			Me.radSchedulerDemo.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
			' 
			' 
			' 
			Me.radSchedulerDemo.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSchedulerDemo.RootElement.Padding = New System.Windows.Forms.Padding(0, 0, 0, 3)
			Me.radSchedulerDemo.Size = New System.Drawing.Size(1243, 193)
			Me.radSchedulerDemo.TabIndex = 0
			Me.radSchedulerDemo.Text = "radScheduler1"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "1.png")
			Me.imageList1.Images.SetKeyName(1, "2.png")
			Me.imageList1.Images.SetKeyName(2, "3.png")
			Me.imageList1.Images.SetKeyName(3, "4.png")
			Me.imageList1.Images.SetKeyName(4, "5.png")
			' 
			' radSchedulerNavigator1
			' 
			
			Me.radSchedulerNavigator1.DateFormat = "MM/dd/yyyy"
			Me.radSchedulerNavigator1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radSchedulerNavigator1.ForeColor = System.Drawing.Color.Black
			Me.radSchedulerNavigator1.Location = New System.Drawing.Point(0, 0)
			Me.radSchedulerNavigator1.MinimumSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.Name = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.NavigationStepType = Telerik.WinControls.UI.NavigationStepTypes.Day
			' 
			' 
			' 
			Me.radSchedulerNavigator1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radSchedulerNavigator1.RootElement.MinSize = New System.Drawing.Size(400, 74)
			Me.radSchedulerNavigator1.RootElement.StretchVertically = False
			Me.radSchedulerNavigator1.Size = New System.Drawing.Size(1243, 78)
			Me.radSchedulerNavigator1.TabIndex = 0
			Me.radSchedulerNavigator1.Text = "radSchedulerNavigator1"
			Me.radSchedulerNavigator1.ThemeName = "ControlDefault"
			' 
			' Form1
			' 
			Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
			Me.Controls.Add(Me.radSchedulerDemo)
			Me.Controls.Add(Me.radSchedulerNavigator1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1243, 271)
			Me.Controls.SetChildIndex(Me.radSchedulerNavigator1, 0)
			Me.Controls.SetChildIndex(Me.radSchedulerDemo, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radSchedulerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radSchedulerDemo As Telerik.WinControls.UI.RadScheduler
		Private imageList1 As System.Windows.Forms.ImageList
		Private radSchedulerNavigator1 As Telerik.WinControls.UI.RadSchedulerNavigator
	End Class
End Namespace