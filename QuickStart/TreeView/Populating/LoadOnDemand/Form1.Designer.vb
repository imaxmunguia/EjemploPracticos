Namespace Telerik.Examples.WinControls.TreeView.Populating.LoadOnDemand
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(1111, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 802)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' radTreeView1
			' 
			Me.radTreeView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radTreeView1.ImageIndex = 2
			Me.radTreeView1.ImageList = Me.imageList1
			Me.radTreeView1.Location = New System.Drawing.Point(6, 38)
			Me.radTreeView1.Name = "radTreeView1"
			Me.radTreeView1.Size = New System.Drawing.Size(368, 718)
			Me.radTreeView1.TabIndex = 1
			Me.radTreeView1.Text = "radTreeView1"
'			Me.radTreeView1.NodesNeeded += New Telerik.WinControls.UI.NodesNeededEventHandler(Me.radTreeView1_NodesNeeded);
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.White
			Me.imageList1.Images.SetKeyName(0, "computer")
			Me.imageList1.Images.SetKeyName(1, "desktop")
			Me.imageList1.Images.SetKeyName(2, "documents")
			Me.imageList1.Images.SetKeyName(3, "downloads")
			Me.imageList1.Images.SetKeyName(4, "folder")
			Me.imageList1.Images.SetKeyName(5, "hdd")
			Me.imageList1.Images.SetKeyName(6, "libraries")
			Me.imageList1.Images.SetKeyName(7, "music")
			Me.imageList1.Images.SetKeyName(8, "network drive")
			Me.imageList1.Images.SetKeyName(9, "network")
			Me.imageList1.Images.SetKeyName(10, "pictures")
			Me.imageList1.Images.SetKeyName(11, "video")
			Me.imageList1.Images.SetKeyName(12, "virtual machines")
			Me.imageList1.Images.SetKeyName(13, "favorites")
			Me.imageList1.Images.SetKeyName(14, "work")
			' 
			' radLabel3
			' 
			Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.radLabel3.Location = New System.Drawing.Point(8, 2)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(89, 24)
			Me.radLabel3.TabIndex = 0
			Me.radLabel3.Text = "File Browser"
			' 
			' Form1
			' 
			Me.Controls.Add(Me.radTreeView1)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1312, 804)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private imageList1 As System.Windows.Forms.ImageList
	End Class
End Namespace