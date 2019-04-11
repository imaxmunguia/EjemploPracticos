Namespace Telerik.Examples.WinControls.TreeView.Customize.ContextMenus
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim radTreeNode1 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode2 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode3 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode4 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode5 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode6 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode7 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode8 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode9 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode10 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode11 As New Telerik.WinControls.UI.RadTreeNode()
			Me.radContextMenu1 = New Telerik.WinControls.UI.RadContextMenu()
			Me.radMenuItem1 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem2 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem4 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem5 = New Telerik.WinControls.UI.RadMenuItem()
			Me.radMenuItem3 = New Telerik.WinControls.UI.RadMenuItem()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radTreeViewDemo = New Telerik.WinControls.UI.RadTreeView()
			Me.radGroupInfoPane = New Telerik.WinControls.UI.RadGroupBox()
			Me.radLblSelectedItem = New Telerik.WinControls.UI.RadLabel()
			Me.radLblItem = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLblSelectedNode = New Telerik.WinControls.UI.RadLabel()
			Me.radLblNode = New Telerik.WinControls.UI.RadLabel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTreeViewDemo, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupInfoPane, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupInfoPane.SuspendLayout()
			CType(Me.radLblSelectedItem, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblItem, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblSelectedNode, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLblNode, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupInfoPane)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupInfoPane, 0)
			' 
			' radContextMenu1
			' 
			Me.radContextMenu1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radMenuItem1, Me.radMenuItem2, Me.radMenuItem4, Me.radMenuItem5})
			' 
			' radMenuItem1
			' 
			Me.radMenuItem1.Name = "radMenuItem1"
			Me.radMenuItem1.Text = "Edit"
			Me.radMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem2
			' 
			Me.radMenuItem2.Name = "radMenuItem2"
			Me.radMenuItem2.Text = "Disable"
			Me.radMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem4
			' 
			Me.radMenuItem4.Name = "radMenuItem4"
			Me.radMenuItem4.Text = "Delete Node"
			Me.radMenuItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem5
			' 
			Me.radMenuItem5.Name = "radMenuItem5"
			Me.radMenuItem5.Text = "New Folder"
			Me.radMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' radMenuItem3
			' 
			Me.radMenuItem3.Name = "radMenuItem3"
			Me.radMenuItem3.Text = "Copy node(Clone)"
			Me.radMenuItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Fuchsia
			Me.imageList1.Images.SetKeyName(0, "0_Personal_Folders.gif")
			Me.imageList1.Images.SetKeyName(1, "1_Deleted_Items.gif")
			Me.imageList1.Images.SetKeyName(2, "2_Drafts.gif")
			Me.imageList1.Images.SetKeyName(3, "3_Inbox.gif")
			Me.imageList1.Images.SetKeyName(4, "4_Junk_E-mail.gif")
			Me.imageList1.Images.SetKeyName(5, "5_Outbox.gif")
			Me.imageList1.Images.SetKeyName(6, "6_Rss_Feeds.gif")
			Me.imageList1.Images.SetKeyName(7, "7_Sent_Items.gif")
			Me.imageList1.Images.SetKeyName(8, "8.1_Search.gif")
			Me.imageList1.Images.SetKeyName(9, "8_Search.gif")
			' 
			' radTreeViewDemo
			' 
			Me.radTreeViewDemo.Cursor = System.Windows.Forms.Cursors.Default
			Me.radTreeViewDemo.ImageList = Me.imageList1
			Me.radTreeViewDemo.ItemHeight = 27
			Me.radTreeViewDemo.Name = "radTreeViewDemo"
			Me.radTreeViewDemo.Location = New System.Drawing.Point(20, 17)
			Me.radTreeViewDemo.Size = New System.Drawing.Size(246, 441)
			radTreeNode1.ContextMenu = Me.radContextMenu1
			radTreeNode1.Expanded = True
			radTreeNode1.Image = (CType(resources.GetObject("radTreeNode1.Image"), System.Drawing.Image))
			radTreeNode1.ImageIndex = 0
			radTreeNode2.ContextMenu = Me.radContextMenu1
			radTreeNode2.Image = (CType(resources.GetObject("radTreeNode2.Image"), System.Drawing.Image))
			radTreeNode2.ImageIndex = 1
			radTreeNode2.Text = "Deleted Items(6)"
			radTreeNode3.ContextMenu = Me.radContextMenu1
			radTreeNode3.Image = (CType(resources.GetObject("radTreeNode3.Image"), System.Drawing.Image))
			radTreeNode3.ImageKey = "2_Drafts.gif"
			radTreeNode3.Text = "Drafts"
			radTreeNode4.ContextMenu = Me.radContextMenu1
			radTreeNode4.Image = (CType(resources.GetObject("radTreeNode4.Image"), System.Drawing.Image))
			radTreeNode4.ImageIndex = 3
			radTreeNode4.Text = "Invoices"
			radTreeNode5.ContextMenu = Me.radContextMenu1
			radTreeNode5.Image = (CType(resources.GetObject("radTreeNode5.Image"), System.Drawing.Image))
			radTreeNode5.ImageKey = "5_Outbox.gif"
			radTreeNode5.Text = "Junk e-mail"
			radTreeNode6.ContextMenu = Me.radContextMenu1
			radTreeNode6.Image = (CType(resources.GetObject("radTreeNode6.Image"), System.Drawing.Image))
			radTreeNode6.ImageIndex = 5
			radTreeNode6.Text = "OutBox"
			radTreeNode7.ContextMenu = Me.radContextMenu1
			radTreeNode7.Expanded = True
			radTreeNode7.Image = (CType(resources.GetObject("radTreeNode7.Image"), System.Drawing.Image))
			radTreeNode7.ImageKey = "7_Sent_Items.gif"
			radTreeNode7.Text = "Sent Items"
			radTreeNode8.ContextMenu = Me.radContextMenu1
			radTreeNode8.Expanded = True
			radTreeNode8.Image = (CType(resources.GetObject("radTreeNode8.Image"), System.Drawing.Image))
			radTreeNode8.ImageKey = "8_Search.gif"
			radTreeNode9.ContextMenu = Me.radContextMenu1
			radTreeNode9.Image = (CType(resources.GetObject("radTreeNode9.Image"), System.Drawing.Image))
			radTreeNode9.ImageKey = "8.1_Search.gif"
			radTreeNode9.Text = "Form Follow Up"
			radTreeNode10.ContextMenu = Me.radContextMenu1
			radTreeNode10.Image = (CType(resources.GetObject("radTreeNode10.Image"), System.Drawing.Image))
			radTreeNode10.ImageKey = "8.1_Search.gif"
			radTreeNode10.Text = "Large Mail"
			radTreeNode11.ContextMenu = Me.radContextMenu1
			radTreeNode11.Image = (CType(resources.GetObject("radTreeNode11.Image"), System.Drawing.Image))
			radTreeNode11.ImageKey = "8.1_Search.gif"
			radTreeNode11.Text = "Unread Mail"
			radTreeNode8.Nodes.Add(radTreeNode9)
			radTreeNode8.Nodes.Add(radTreeNode10)
			radTreeNode8.Nodes.Add(radTreeNode11)
			radTreeNode8.Text = "Search Folders"
			radTreeNode1.Nodes.Add(radTreeNode2)
			radTreeNode1.Nodes.Add(radTreeNode3)
			radTreeNode1.Nodes.Add(radTreeNode4)
			radTreeNode1.Nodes.Add(radTreeNode5)
			radTreeNode1.Nodes.Add(radTreeNode6)
			radTreeNode1.Nodes.Add(radTreeNode7)
			radTreeNode1.Nodes.Add(radTreeNode8)
			radTreeNode1.Text = "Personal Folders"
			Me.radTreeViewDemo.Nodes.Add(radTreeNode1)
			Me.radTreeViewDemo.TabIndex = 0
			Me.radTreeViewDemo.Text = "radTreeView1"
			' 
			' radGroupInfoPane
			' 
			Me.radGroupInfoPane.Controls.Add(Me.radLblSelectedItem)
			Me.radGroupInfoPane.Controls.Add(Me.radLblItem)
			Me.radGroupInfoPane.Controls.Add(Me.radLabel2)
			Me.radGroupInfoPane.Controls.Add(Me.radLblSelectedNode)
			Me.radGroupInfoPane.Controls.Add(Me.radLblNode)
			Me.radGroupInfoPane.FooterImageIndex = -1
			Me.radGroupInfoPane.FooterImageKey = ""
			Me.radGroupInfoPane.ForeColor = System.Drawing.Color.Black
			Me.radGroupInfoPane.HeaderImageIndex = -1
			Me.radGroupInfoPane.HeaderImageKey = ""
			Me.radGroupInfoPane.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupInfoPane.HeaderText = " Info Pane "
			Me.radGroupInfoPane.Location = New System.Drawing.Point(15, 6)
			Me.radGroupInfoPane.Name = "radGroupInfoPane"
			' 
			' 
			' 
			Me.radGroupInfoPane.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupInfoPane.Size = New System.Drawing.Size(162, 100)
			Me.radGroupInfoPane.TabIndex = 0
			Me.radGroupInfoPane.Text = " Info Pane "
			' 
			' radLblSelectedItem
			' 
			Me.radLblSelectedItem.ForeColor = System.Drawing.Color.Red
			Me.radLblSelectedItem.Location = New System.Drawing.Point(4, 74)
			Me.radLblSelectedItem.Name = "radLblSelectedItem"
			' 
			' 
			' 
			Me.radLblSelectedItem.RootElement.ForeColor = System.Drawing.Color.Red
			Me.radLblSelectedItem.Size = New System.Drawing.Size(55, 14)
			Me.radLblSelectedItem.TabIndex = 1
			Me.radLblSelectedItem.Text = "radLabel2"
			' 
			' radLblItem
			' 
			Me.radLblItem.ForeColor = System.Drawing.Color.Black
			Me.radLblItem.Location = New System.Drawing.Point(4, 56)
			Me.radLblItem.Name = "radLblItem"
			' 
			' 
			' 
			Me.radLblItem.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblItem.Size = New System.Drawing.Size(119, 14)
			Me.radLblItem.TabIndex = 1
			Me.radLblItem.Text = "Context Item Selected:"
			' 
			' radLabel2
			' 
			Me.radLabel2.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Location = New System.Drawing.Point(3, 58)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLabel2.Size = New System.Drawing.Size(55, 14)
			Me.radLabel2.TabIndex = 1
			Me.radLabel2.Text = "radLabel2"
			' 
			' radLblSelectedNode
			' 
			Me.radLblSelectedNode.ForeColor = System.Drawing.Color.Red
			Me.radLblSelectedNode.Location = New System.Drawing.Point(4, 36)
			Me.radLblSelectedNode.Name = "radLblSelectedNode"
			' 
			' 
			' 
			Me.radLblSelectedNode.RootElement.ForeColor = System.Drawing.Color.Red
			Me.radLblSelectedNode.Size = New System.Drawing.Size(55, 14)
			Me.radLblSelectedNode.TabIndex = 0
			Me.radLblSelectedNode.Text = "radLabel1"
			' 
			' radLblNode
			' 
			Me.radLblNode.ForeColor = System.Drawing.Color.Black
			Me.radLblNode.Location = New System.Drawing.Point(4, 20)
			Me.radLblNode.Name = "radLblNode"
			' 
			' 
			' 
			Me.radLblNode.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radLblNode.Size = New System.Drawing.Size(82, 14)
			Me.radLblNode.TabIndex = 0
			Me.radLblNode.Text = "Node Selected:"
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 600)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.Controls.Add(Me.radTreeViewDemo)
			Me.settingsPanel.ResumeLayout(False)
			Me.settingsPanel.PerformLayout()
			CType(Me.radTreeViewDemo, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupInfoPane, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupInfoPane.ResumeLayout(False)
			Me.radGroupInfoPane.PerformLayout()
			CType(Me.radLblSelectedItem, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblItem, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblSelectedNode, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLblNode, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private imageList1 As System.Windows.Forms.ImageList
		Private radContextMenu1 As Telerik.WinControls.UI.RadContextMenu
		Private radMenuItem1 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem2 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem3 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem4 As Telerik.WinControls.UI.RadMenuItem
		Private radMenuItem5 As Telerik.WinControls.UI.RadMenuItem
		Private radTreeViewDemo As Telerik.WinControls.UI.RadTreeView
		Private radGroupInfoPane As Telerik.WinControls.UI.RadGroupBox
		Private radLblSelectedItem As Telerik.WinControls.UI.RadLabel
		Private radLblItem As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLblSelectedNode As Telerik.WinControls.UI.RadLabel
		Private radLblNode As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace