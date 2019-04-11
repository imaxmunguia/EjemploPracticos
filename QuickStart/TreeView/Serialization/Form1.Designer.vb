Namespace Telerik.Examples.WinControls.TreeView.Serialization
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
			Dim radTreeNode12 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode13 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode14 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode15 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode16 As New Telerik.WinControls.UI.RadTreeNode()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.btnAddRoot = New Telerik.WinControls.UI.RadButton()
			Me.btnAddChild = New Telerik.WinControls.UI.RadButton()
			Me.btnLoadFile = New Telerik.WinControls.UI.RadButton()
			Me.btnSaveFile = New Telerik.WinControls.UI.RadButton()
			Me.btnRemove = New Telerik.WinControls.UI.RadButton()
			Me.radGroupNodeOpts = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGroupXml = New Telerik.WinControls.UI.RadGroupBox()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnAddRoot, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnAddChild, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnLoadFile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnSaveFile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radGroupNodeOpts, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupNodeOpts.SuspendLayout()
			CType(Me.radGroupXml, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupXml.SuspendLayout()
			Me.SuspendLayout()

			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupXml)
			Me.settingsPanel.Controls.Add(Me.radGroupNodeOpts)
			Me.settingsPanel.Location = New System.Drawing.Point(1023, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 735)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupNodeOpts, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupXml, 0)
			' 
			' radTreeView1
			' 
			Me.radTreeView1.AllowDragDrop = True
			Me.radTreeView1.AllowEdit = True
			Me.radTreeView1.Name = "radTreeView1"
			radTreeNode1.Expanded = True
			radTreeNode2.Expanded = True
			radTreeNode3.Text = "Node15"
			radTreeNode4.Text = "Node16"
			radTreeNode2.Nodes.Add(radTreeNode3)
			radTreeNode2.Nodes.Add(radTreeNode4)
			radTreeNode2.Text = "Node7"
			radTreeNode5.Expanded = True
			radTreeNode6.Text = "Node14"
			radTreeNode5.Nodes.Add(radTreeNode6)
			radTreeNode5.Text = "Node8"
			radTreeNode7.Text = "Node9"
			radTreeNode1.Nodes.Add(radTreeNode2)
			radTreeNode1.Nodes.Add(radTreeNode5)
			radTreeNode1.Nodes.Add(radTreeNode7)
			radTreeNode1.Text = "Node1"
			radTreeNode8.Expanded = True
			radTreeNode9.Text = "Node10"
			radTreeNode10.Text = "Node11"
			radTreeNode8.Nodes.Add(radTreeNode9)
			radTreeNode8.Nodes.Add(radTreeNode10)
			radTreeNode8.Text = "Node2"
			radTreeNode11.Text = "Node3"
			radTreeNode12.Expanded = True
			radTreeNode13.Text = "Node12"
			radTreeNode14.Text = "Node13"
			radTreeNode12.Nodes.Add(radTreeNode13)
			radTreeNode12.Nodes.Add(radTreeNode14)
			radTreeNode12.Text = "Node4"
			radTreeNode15.Text = "Node5"
			radTreeNode16.Text = "Node6"
			Me.radTreeView1.Nodes.Add(radTreeNode1)
			Me.radTreeView1.Nodes.Add(radTreeNode8)
			Me.radTreeView1.Nodes.Add(radTreeNode11)
			Me.radTreeView1.Nodes.Add(radTreeNode12)
			Me.radTreeView1.Nodes.Add(radTreeNode15)
			Me.radTreeView1.Nodes.Add(radTreeNode16)
			Me.radTreeView1.Size = New System.Drawing.Size(290, 400)
			Me.radTreeView1.Location = New System.Drawing.Point(10, 20)
			Me.radTreeView1.TabIndex = 0
			Me.radTreeView1.Text = "radTreeView1"
			' 
			' btnAddRoot
			' 
			Me.btnAddRoot.Location = New System.Drawing.Point(14, 31)
			Me.btnAddRoot.Name = "btnAddRoot"
			Me.btnAddRoot.Size = New System.Drawing.Size(133, 23)
			Me.btnAddRoot.TabIndex = 1
			Me.btnAddRoot.Text = "Add Root Node"
'			Me.btnAddRoot.Click += New System.EventHandler(Me.btnAddRoot_Click);
			' 
			' btnAddChild
			' 
			Me.btnAddChild.Location = New System.Drawing.Point(14, 60)
			Me.btnAddChild.Name = "btnAddChild"
			Me.btnAddChild.Size = New System.Drawing.Size(133, 23)
			Me.btnAddChild.TabIndex = 2
			Me.btnAddChild.Text = "Add Child Node"
'			Me.btnAddChild.Click += New System.EventHandler(Me.btnAddChild_Click);
			' 
			' btnLoadFile
			' 
			Me.btnLoadFile.Location = New System.Drawing.Point(14, 28)
			Me.btnLoadFile.Name = "btnLoadFile"
			Me.btnLoadFile.Size = New System.Drawing.Size(133, 23)
			Me.btnLoadFile.TabIndex = 3
			Me.btnLoadFile.Text = "Load XML File"
'			Me.btnLoadFile.Click += New System.EventHandler(Me.btnLoadFile_Click);
			' 
			' btnSaveFile
			' 
			Me.btnSaveFile.Location = New System.Drawing.Point(14, 57)
			Me.btnSaveFile.Name = "btnSaveFile"
			Me.btnSaveFile.Size = New System.Drawing.Size(133, 23)
			Me.btnSaveFile.TabIndex = 4
			Me.btnSaveFile.Text = "Save XML File"
'			Me.btnSaveFile.Click += New System.EventHandler(Me.btnSaveFile_Click);
			' 
			' btnRemove
			' 
			Me.btnRemove.Location = New System.Drawing.Point(14, 89)
			Me.btnRemove.Name = "btnRemove"
			Me.btnRemove.Size = New System.Drawing.Size(133, 23)
			Me.btnRemove.TabIndex = 5
			Me.btnRemove.Text = "Remove Selected Node"
'			Me.btnRemove.Click += New System.EventHandler(Me.btnRemove_Click);
			' 
			' radGroupNodeOpts
			' 
			Me.radGroupNodeOpts.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupNodeOpts.Controls.Add(Me.btnAddRoot)
			Me.radGroupNodeOpts.Controls.Add(Me.btnRemove)
			Me.radGroupNodeOpts.Controls.Add(Me.btnAddChild)
			Me.radGroupNodeOpts.FooterImageIndex = -1
			Me.radGroupNodeOpts.FooterImageKey = ""
			Me.radGroupNodeOpts.ForeColor = System.Drawing.Color.Black
			Me.radGroupNodeOpts.HeaderImageIndex = -1
			Me.radGroupNodeOpts.HeaderImageKey = ""
			Me.radGroupNodeOpts.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupNodeOpts.HeaderText = "Node Actions"
			Me.radGroupNodeOpts.Location = New System.Drawing.Point(10, 6)
			Me.radGroupNodeOpts.Name = "radGroupNodeOpts"
			Me.radGroupNodeOpts.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupNodeOpts.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupNodeOpts.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupNodeOpts.Size = New System.Drawing.Size(180, 125)
			Me.radGroupNodeOpts.TabIndex = 0
			Me.radGroupNodeOpts.Text = "Node Actions"
			' 
			' radGroupXml
			' 
			Me.radGroupXml.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupXml.Controls.Add(Me.btnLoadFile)
			Me.radGroupXml.Controls.Add(Me.btnSaveFile)
			Me.radGroupXml.FooterImageIndex = -1
			Me.radGroupXml.FooterImageKey = ""
			Me.radGroupXml.ForeColor = System.Drawing.Color.Black
			Me.radGroupXml.HeaderImageIndex = -1
			Me.radGroupXml.HeaderImageKey = ""
			Me.radGroupXml.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
			Me.radGroupXml.HeaderText = "XML Actions"
			Me.radGroupXml.Location = New System.Drawing.Point(10, 151)
			Me.radGroupXml.Name = "radGroupXml"
			Me.radGroupXml.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupXml.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radGroupXml.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupXml.Size = New System.Drawing.Size(180, 95)
			Me.radGroupXml.TabIndex = 1
			Me.radGroupXml.Text = "XML Actions"
			' 
			' Form1
			' 
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1224, 737)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.Controls.Add(Me.radTreeView1)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.settingsPanel.ResumeLayout(False)
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnAddRoot, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnAddChild, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnLoadFile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnSaveFile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radGroupNodeOpts, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupNodeOpts.ResumeLayout(False)
			CType(Me.radGroupXml, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupXml.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private WithEvents btnAddRoot As Telerik.WinControls.UI.RadButton
		Private WithEvents btnAddChild As Telerik.WinControls.UI.RadButton
		Private WithEvents btnLoadFile As Telerik.WinControls.UI.RadButton
		Private WithEvents btnSaveFile As Telerik.WinControls.UI.RadButton
		Private WithEvents btnRemove As Telerik.WinControls.UI.RadButton
		Private radGroupXml As Telerik.WinControls.UI.RadGroupBox
		Private radGroupNodeOpts As Telerik.WinControls.UI.RadGroupBox
	End Class
End Namespace