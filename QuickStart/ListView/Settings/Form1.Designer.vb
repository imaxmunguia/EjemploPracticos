Namespace Telerik.Examples.WinControls.ListView.Settings
	Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
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
			Dim listViewDetailColumn1 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 0", "File Name")
			Dim listViewDetailColumn2 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 1", "Total Size")
			Dim listViewDetailColumn3 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 2", "Type")
			Dim listViewDetailColumn4 As New Telerik.WinControls.UI.ListViewDetailColumn("Column 3", "Free Space")
			Dim listViewDataItemGroup1 As New Telerik.WinControls.UI.ListViewDataItemGroup("Files Stored on This Computer")
			Dim listViewDataItemGroup2 As New Telerik.WinControls.UI.ListViewDataItemGroup("Hard Disk Drives")
			Dim listViewDataItemGroup3 As New Telerik.WinControls.UI.ListViewDataItemGroup("Devices with Removable Storage")
			Dim listViewDataItem1 As New Telerik.WinControls.UI.ListViewDataItem("Shared Documents", New String() {"Shared Documents", "", "File Folder"})
			Dim listViewDataItem2 As New Telerik.WinControls.UI.ListViewDataItem("Administrator's Documents", New String() {"Administrator's Documents", "", "File Folder"})
			Dim listViewDataItem3 As New Telerik.WinControls.UI.ListViewDataItem("3.5 Floppy (A:)", New String() {"3.5 Floppy (A:)", "1.44 MB", "Floppy Drive", "203 KB"})
			Dim listViewDataItem4 As New Telerik.WinControls.UI.ListViewDataItem("Local Disk (C:)", New String() {"Local Disk (C:)", "160.4 GB", "Local Disk", "31.02 GB"})
			Dim listViewDataItem5 As New Telerik.WinControls.UI.ListViewDataItem("Local Disk (D:)", New String() {"Local Disk (D:)", "136.2 GB", "Local Disk", "57.52 GB"})
			Dim listViewDataItem6 As New Telerik.WinControls.UI.ListViewDataItem("Local Disk (E:)", New String() {"Local Disk (E:)", "40.00 GB", "Local Disk", "13.37 GB"})
			Dim listViewDataItem7 As New Telerik.WinControls.UI.ListViewDataItem("Local Disk (F:)", New String() {"Local Disk (F:)", "0.99 TB", "Local Disk", "357.37 GB"})
			Dim listViewDataItem8 As New Telerik.WinControls.UI.ListViewDataItem("DVD/CD-RW Drive (G:)", New String() {"DVD/CD-RW (G:)", "4.7 GB", "DVD Drive", "0 KB"})
			Dim listViewDataItem9 As New Telerik.WinControls.UI.ListViewDataItem("CD-RW Drive (H:)", New String() {"CD-RW (G:)", "", "CD Drive"})
			Dim radListDataItem4 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem5 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem1 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem2 As New Telerik.WinControls.UI.RadListDataItem()
			Dim radListDataItem3 As New Telerik.WinControls.UI.RadListDataItem()
			Me.radListView1 = New Telerik.WinControls.UI.RadListView()
			Me.radCheckBoxShowCheckboxes = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxGroups = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radCheckBoxFullRowSelect = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel4 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel5 = New Telerik.WinControls.UI.RadLabel()
			Me.radCheckBox4 = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxArbWidth = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxArbHeight = New Telerik.WinControls.UI.RadCheckBox()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSpinEditorGroupHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorItemHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorItemWidth = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorGroupIndent = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radSpinEditorItemSpacing = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radGroupBoxDetailView = New Telerik.WinControls.UI.RadGroupBox()
			Me.radSpinEditorHeaderHeight = New Telerik.WinControls.UI.RadSpinEditor()
			Me.radCheckBoxColHeaders = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxColSort = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxColReorder = New Telerik.WinControls.UI.RadCheckBox()
			Me.radCheckBoxColResize = New Telerik.WinControls.UI.RadCheckBox()
			Me.radLabel6 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBoxIconView = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownList2 = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel7 = New Telerik.WinControls.UI.RadLabel()
			Me.radGroupBox5 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radDropDownListViewType = New Telerik.WinControls.UI.RadDropDownList()
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.radLabel8 = New Telerik.WinControls.UI.RadLabel()
			Me.radPanel1 = New Telerik.Examples.TreeExampleHeaderPanel()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.settingsPanel.SuspendLayout()
			DirectCast(Me.radListView1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxShowCheckboxes, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxGroups, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			DirectCast(Me.radCheckBoxFullRowSelect, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radLabel5.SuspendLayout()
			DirectCast(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxArbWidth, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxArbHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			DirectCast(Me.radSpinEditorGroupHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radSpinEditorItemHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radSpinEditorItemWidth, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radSpinEditorGroupIndent, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radSpinEditorItemSpacing, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGroupBoxDetailView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxDetailView.SuspendLayout()
			DirectCast(Me.radSpinEditorHeaderHeight, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxColHeaders, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxColSort, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxColReorder, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radCheckBoxColResize, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGroupBoxIconView, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBoxIconView.SuspendLayout()
			DirectCast(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox5.SuspendLayout()
			DirectCast(Me.radDropDownListViewType, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.Controls.Add(Me.radGroupBox5)
			Me.settingsPanel.Controls.Add(Me.radGroupBox2)
			Me.settingsPanel.Controls.Add(Me.radGroupBox1)
			Me.settingsPanel.Controls.Add(Me.radGroupBoxIconView)
			Me.settingsPanel.Controls.Add(Me.radGroupBoxDetailView)
			Me.settingsPanel.Location = New System.Drawing.Point(1032, 1)
			Me.settingsPanel.Size = New System.Drawing.Size(200, 830)
			Me.settingsPanel.ThemeName = "ControlDefault"
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxDetailView, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBoxIconView, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox1, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox2, 0)
			Me.settingsPanel.Controls.SetChildIndex(Me.radGroupBox5, 0)
			' 
			' radListView1
			' 
			listViewDetailColumn1.HeaderText = "File Name"
			listViewDetailColumn2.HeaderText = "Total Size"
			listViewDetailColumn3.HeaderText = "Type"
			listViewDetailColumn4.HeaderText = "Free Space"
			Me.radListView1.Columns.AddRange(New Telerik.WinControls.UI.ListViewDetailColumn() {listViewDetailColumn1, listViewDetailColumn2, listViewDetailColumn3, listViewDetailColumn4})
			Me.radListView1.CurrentColumn = Nothing
			Me.radListView1.CurrentItem = Nothing
			Me.radListView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radListView1.EnableCustomGrouping = True
            Me.radListView1.EnableSorting = True
			Me.radListView1.GroupItemSize = New System.Drawing.Size(200, 20)
			listViewDataItemGroup1.Text = "Files Stored on This Computer"
			listViewDataItemGroup1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItemGroup2.Text = "Hard Disk Drives"
			listViewDataItemGroup2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItemGroup3.Text = "Devices with Removable Storage"
			listViewDataItemGroup3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radListView1.Groups.AddRange(New Telerik.WinControls.UI.ListViewDataItemGroup() {listViewDataItemGroup1, listViewDataItemGroup2, listViewDataItemGroup3})
			listViewDataItem1.Group = listViewDataItemGroup1
			listViewDataItem1.Image = My.Resources.Resources.folder_xp
			listViewDataItem1.Text = "Shared Documents"
			listViewDataItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItem2.Group = listViewDataItemGroup1
			listViewDataItem2.Image = My.Resources.Resources.folder_xp
			listViewDataItem2.Text = "Administrator's Documents"
			listViewDataItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItem3.Group = listViewDataItemGroup3
			listViewDataItem3.Image = My.Resources.Resources.floppy_drive
			listViewDataItem3.Text = "3.5 Floppy (A:)"
			listViewDataItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItem4.Group = listViewDataItemGroup2
			listViewDataItem4.Image = My.Resources.Resources.hard_drive
			listViewDataItem4.Text = "Local Disk (C:)"
			listViewDataItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItem5.Group = listViewDataItemGroup2
			listViewDataItem5.Image = My.Resources.Resources.hard_drive
			listViewDataItem5.Text = "Local Disk (D:)"
			listViewDataItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItem6.Group = listViewDataItemGroup2
			listViewDataItem6.Image = My.Resources.Resources.hard_drive
			listViewDataItem6.Text = "Local Disk (E:)"
			listViewDataItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItem7.Group = listViewDataItemGroup2
			listViewDataItem7.Image = My.Resources.Resources.hard_drive
			listViewDataItem7.Text = "Local Disk (F:)"
			listViewDataItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItem8.Group = listViewDataItemGroup3
			listViewDataItem8.Image = My.Resources.Resources.cd_drive
			listViewDataItem8.Text = "DVD/CD-RW Drive (G:)"
			listViewDataItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			listViewDataItem9.Group = listViewDataItemGroup3
			listViewDataItem9.Image = My.Resources.Resources.cd_drive
			listViewDataItem9.Text = "CD-RW Drive (H:)"
			listViewDataItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radListView1.Items.AddRange(New Telerik.WinControls.UI.ListViewDataItem() {listViewDataItem1, listViewDataItem2, listViewDataItem3, listViewDataItem4, listViewDataItem5, listViewDataItem6, _
				listViewDataItem7, listViewDataItem8, listViewDataItem9})
			Me.radListView1.ItemSize = New System.Drawing.Size(200, 32)
			Me.radListView1.Location = New System.Drawing.Point(0, 30)
			Me.radListView1.Name = "radListView1"
			Me.radListView1.SelectedIndex = -1
			Me.radListView1.SelectedItem = Nothing
			Me.radListView1.Size = New System.Drawing.Size(561, 380)
			Me.radListView1.TabIndex = 1
			Me.radListView1.Text = "radListView1"
			' 
			' radCheckBoxShowCheckboxes
			' 
			Me.radCheckBoxShowCheckboxes.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxShowCheckboxes.Location = New System.Drawing.Point(5, 19)
			Me.radCheckBoxShowCheckboxes.Name = "radCheckBoxShowCheckboxes"
			Me.radCheckBoxShowCheckboxes.Size = New System.Drawing.Size(113, 18)
			Me.radCheckBoxShowCheckboxes.TabIndex = 2
			Me.radCheckBoxShowCheckboxes.Text = "Show Check Boxes"
			' 
			' radCheckBoxGroups
			' 
			Me.radCheckBoxGroups.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxGroups.Location = New System.Drawing.Point(5, 57)
			Me.radCheckBoxGroups.Name = "radCheckBoxGroups"
			Me.radCheckBoxGroups.Size = New System.Drawing.Size(87, 18)
			Me.radCheckBoxGroups.TabIndex = 4
			Me.radCheckBoxGroups.Text = "Show Groups"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxShowCheckboxes)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxGroups)
			Me.radGroupBox1.Controls.Add(Me.radCheckBoxFullRowSelect)
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "General Settings"
			Me.radGroupBox1.Location = New System.Drawing.Point(10, 85)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			Me.radGroupBox1.Size = New System.Drawing.Size(180, 78)
			Me.radGroupBox1.TabIndex = 7
			Me.radGroupBox1.Text = "General Settings"
			' 
			' radCheckBoxFullRowSelect
			' 
			Me.radCheckBoxFullRowSelect.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxFullRowSelect.Location = New System.Drawing.Point(5, 38)
			Me.radCheckBoxFullRowSelect.Name = "radCheckBoxFullRowSelect"
			Me.radCheckBoxFullRowSelect.Size = New System.Drawing.Size(125, 18)
			Me.radCheckBoxFullRowSelect.TabIndex = 14
			Me.radCheckBoxFullRowSelect.Text = "Enable FullRowSelect"
			' 
			' radLabel2
			' 
			Me.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel2.Location = New System.Drawing.Point(5, 21)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(62, 18)
			Me.radLabel2.TabIndex = 8
			Me.radLabel2.Text = "Item Width"
			' 
			' radLabel3
			' 
			Me.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel3.Location = New System.Drawing.Point(5, 65)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(71, 18)
			Me.radLabel3.TabIndex = 9
			Me.radLabel3.Text = "Item Spacing"
			' 
			' radLabel4
			' 
			Me.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel4.Location = New System.Drawing.Point(5, 87)
			Me.radLabel4.Name = "radLabel4"
			Me.radLabel4.Size = New System.Drawing.Size(74, 18)
			Me.radLabel4.TabIndex = 10
			Me.radLabel4.Text = "Group Height"
			' 
			' radLabel5
			' 
			Me.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel5.Controls.Add(Me.radCheckBox4)
			Me.radLabel5.Location = New System.Drawing.Point(5, 109)
			Me.radLabel5.Name = "radLabel5"
			Me.radLabel5.Size = New System.Drawing.Size(73, 18)
			Me.radLabel5.TabIndex = 11
			Me.radLabel5.Text = "Group Indent"
			' 
			' radCheckBox4
			' 
			Me.radCheckBox4.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBox4.Location = New System.Drawing.Point(0, 22)
			Me.radCheckBox4.Name = "radCheckBox4"
			Me.radCheckBox4.Size = New System.Drawing.Size(154, 18)
			Me.radCheckBox4.TabIndex = 12
			Me.radCheckBox4.Text = "Allow Arbitrary Item Width"
			' 
			' radCheckBoxArbWidth
			' 
			Me.radCheckBoxArbWidth.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxArbWidth.Location = New System.Drawing.Point(5, 131)
			Me.radCheckBoxArbWidth.Name = "radCheckBoxArbWidth"
			Me.radCheckBoxArbWidth.Size = New System.Drawing.Size(154, 18)
			Me.radCheckBoxArbWidth.TabIndex = 12
			Me.radCheckBoxArbWidth.Text = "Allow Arbitrary Item Width"
			' 
			' radCheckBoxArbHeight
			' 
			Me.radCheckBoxArbHeight.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxArbHeight.Location = New System.Drawing.Point(5, 149)
			Me.radCheckBoxArbHeight.Name = "radCheckBoxArbHeight"
			Me.radCheckBoxArbHeight.Size = New System.Drawing.Size(157, 18)
			Me.radCheckBoxArbHeight.TabIndex = 13
			Me.radCheckBoxArbHeight.Text = "Allow Arbitrary Item Height"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox2.Controls.Add(Me.radLabel8)
			Me.radGroupBox2.Controls.Add(Me.radSpinEditorGroupHeight)
			Me.radGroupBox2.Controls.Add(Me.radSpinEditorItemHeight)
			Me.radGroupBox2.Controls.Add(Me.radSpinEditorItemWidth)
			Me.radGroupBox2.Controls.Add(Me.radSpinEditorGroupIndent)
			Me.radGroupBox2.Controls.Add(Me.radSpinEditorItemSpacing)
			Me.radGroupBox2.Controls.Add(Me.radLabel2)
			Me.radGroupBox2.Controls.Add(Me.radLabel3)
			Me.radGroupBox2.Controls.Add(Me.radCheckBoxArbHeight)
			Me.radGroupBox2.Controls.Add(Me.radLabel4)
			Me.radGroupBox2.Controls.Add(Me.radCheckBoxArbWidth)
			Me.radGroupBox2.Controls.Add(Me.radLabel5)
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Sizing Settings"
			Me.radGroupBox2.Location = New System.Drawing.Point(10, 166)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			Me.radGroupBox2.Size = New System.Drawing.Size(180, 169)
			Me.radGroupBox2.TabIndex = 15
			Me.radGroupBox2.Text = "Sizing Settings"
			' 
			' radSpinEditorGroupHeight
			' 
			Me.radSpinEditorGroupHeight.Location = New System.Drawing.Point(90, 85)
			Me.radSpinEditorGroupHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
			Me.radSpinEditorGroupHeight.Name = "radSpinEditorGroupHeight"
			' 
			' 
			' 
			Me.radSpinEditorGroupHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorGroupHeight.ShowBorder = True
			Me.radSpinEditorGroupHeight.Size = New System.Drawing.Size(85, 20)
			Me.radSpinEditorGroupHeight.TabIndex = 23
			Me.radSpinEditorGroupHeight.TabStop = False
			' 
			' radSpinEditorItemHeight
			' 
			Me.radSpinEditorItemHeight.Location = New System.Drawing.Point(90, 41)
			Me.radSpinEditorItemHeight.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
			Me.radSpinEditorItemHeight.Name = "radSpinEditorItemHeight"
			' 
			' 
			' 
			Me.radSpinEditorItemHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorItemHeight.ShowBorder = True
			Me.radSpinEditorItemHeight.Size = New System.Drawing.Size(85, 20)
			Me.radSpinEditorItemHeight.TabIndex = 21
			Me.radSpinEditorItemHeight.TabStop = False
			' 
			' radSpinEditorItemWidth
			' 
			Me.radSpinEditorItemWidth.Location = New System.Drawing.Point(90, 19)
			Me.radSpinEditorItemWidth.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
			Me.radSpinEditorItemWidth.Name = "radSpinEditorItemWidth"
			' 
			' 
			' 
			Me.radSpinEditorItemWidth.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorItemWidth.ShowBorder = True
			Me.radSpinEditorItemWidth.Size = New System.Drawing.Size(85, 20)
			Me.radSpinEditorItemWidth.TabIndex = 20
			Me.radSpinEditorItemWidth.TabStop = False
			' 
			' radSpinEditorGroupIndent
			' 
			Me.radSpinEditorGroupIndent.Location = New System.Drawing.Point(90, 108)
			Me.radSpinEditorGroupIndent.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
			Me.radSpinEditorGroupIndent.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
			Me.radSpinEditorGroupIndent.Name = "radSpinEditorGroupIndent"
			' 
			' 
			' 
			Me.radSpinEditorGroupIndent.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorGroupIndent.ShowBorder = True
			Me.radSpinEditorGroupIndent.Size = New System.Drawing.Size(85, 20)
			Me.radSpinEditorGroupIndent.TabIndex = 19
			Me.radSpinEditorGroupIndent.TabStop = False
			' 
			' radSpinEditorItemSpacing
			' 
			Me.radSpinEditorItemSpacing.Location = New System.Drawing.Point(90, 63)
			Me.radSpinEditorItemSpacing.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
			Me.radSpinEditorItemSpacing.Minimum = New Decimal(New Integer() {1000, 0, 0, -2147483648})
			Me.radSpinEditorItemSpacing.Name = "radSpinEditorItemSpacing"
			' 
			' 
			' 
			Me.radSpinEditorItemSpacing.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorItemSpacing.ShowBorder = True
			Me.radSpinEditorItemSpacing.Size = New System.Drawing.Size(85, 20)
			Me.radSpinEditorItemSpacing.TabIndex = 18
			Me.radSpinEditorItemSpacing.TabStop = False
			' 
			' radGroupBoxDetailView
			' 
			Me.radGroupBoxDetailView.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBoxDetailView.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBoxDetailView.Controls.Add(Me.radSpinEditorHeaderHeight)
			Me.radGroupBoxDetailView.Controls.Add(Me.radCheckBoxColHeaders)
			Me.radGroupBoxDetailView.Controls.Add(Me.radCheckBoxColSort)
			Me.radGroupBoxDetailView.Controls.Add(Me.radCheckBoxColReorder)
			Me.radGroupBoxDetailView.Controls.Add(Me.radCheckBoxColResize)
			Me.radGroupBoxDetailView.Controls.Add(Me.radLabel6)
			Me.radGroupBoxDetailView.FooterImageIndex = -1
			Me.radGroupBoxDetailView.FooterImageKey = ""
			Me.radGroupBoxDetailView.HeaderImageIndex = -1
			Me.radGroupBoxDetailView.HeaderImageKey = ""
			Me.radGroupBoxDetailView.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBoxDetailView.HeaderText = "Detail View Settings"
			Me.radGroupBoxDetailView.Location = New System.Drawing.Point(10, 338)
			Me.radGroupBoxDetailView.Name = "radGroupBoxDetailView"
			Me.radGroupBoxDetailView.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			' 
			' 
			' 
			Me.radGroupBoxDetailView.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			Me.radGroupBoxDetailView.Size = New System.Drawing.Size(180, 131)
			Me.radGroupBoxDetailView.TabIndex = 16
			Me.radGroupBoxDetailView.Text = "Detail View Settings"
			' 
			' radSpinEditorHeaderHeight
			' 
			Me.radSpinEditorHeaderHeight.Location = New System.Drawing.Point(90, 21)
			Me.radSpinEditorHeaderHeight.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
			Me.radSpinEditorHeaderHeight.Name = "radSpinEditorHeaderHeight"
			' 
			' 
			' 
			Me.radSpinEditorHeaderHeight.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.radSpinEditorHeaderHeight.ShowBorder = True
			Me.radSpinEditorHeaderHeight.Size = New System.Drawing.Size(85, 20)
			Me.radSpinEditorHeaderHeight.TabIndex = 19
			Me.radSpinEditorHeaderHeight.TabStop = False
			Me.radSpinEditorHeaderHeight.Value = New Decimal(New Integer() {35, 0, 0, 0})
			' 
			' radCheckBoxColHeaders
			' 
			Me.radCheckBoxColHeaders.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxColHeaders.Location = New System.Drawing.Point(5, 45)
			Me.radCheckBoxColHeaders.Name = "radCheckBoxColHeaders"
			Me.radCheckBoxColHeaders.Size = New System.Drawing.Size(134, 18)
			Me.radCheckBoxColHeaders.TabIndex = 16
			Me.radCheckBoxColHeaders.Text = "Show Column Headers"
			Me.radCheckBoxColHeaders.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxColSort
			' 
			Me.radCheckBoxColSort.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxColSort.Location = New System.Drawing.Point(5, 108)
			Me.radCheckBoxColSort.Name = "radCheckBoxColSort"
			Me.radCheckBoxColSort.Size = New System.Drawing.Size(119, 18)
			Me.radCheckBoxColSort.TabIndex = 15
			Me.radCheckBoxColSort.Text = "Enable Column Sort"
			' 
			' radCheckBoxColReorder
			' 
			Me.radCheckBoxColReorder.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxColReorder.Location = New System.Drawing.Point(5, 87)
			Me.radCheckBoxColReorder.Name = "radCheckBoxColReorder"
			Me.radCheckBoxColReorder.Size = New System.Drawing.Size(138, 18)
			Me.radCheckBoxColReorder.TabIndex = 14
			Me.radCheckBoxColReorder.Text = "Enable Column Reorder"
			Me.radCheckBoxColReorder.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radCheckBoxColResize
			' 
			Me.radCheckBoxColResize.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radCheckBoxColResize.Location = New System.Drawing.Point(5, 66)
			Me.radCheckBoxColResize.Name = "radCheckBoxColResize"
			Me.radCheckBoxColResize.Size = New System.Drawing.Size(130, 18)
			Me.radCheckBoxColResize.TabIndex = 13
			Me.radCheckBoxColResize.Text = "Enable Column Resize"
			Me.radCheckBoxColResize.ToggleState = Telerik.WinControls.Enumerations.ToggleState.[On]
			' 
			' radLabel6
			' 
			Me.radLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel6.Location = New System.Drawing.Point(5, 21)
			Me.radLabel6.Name = "radLabel6"
			Me.radLabel6.Size = New System.Drawing.Size(79, 18)
			Me.radLabel6.TabIndex = 9
			Me.radLabel6.Text = "Header Height"
			' 
			' radGroupBoxIconView
			' 
			Me.radGroupBoxIconView.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBoxIconView.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBoxIconView.Controls.Add(Me.radDropDownList2)
			Me.radGroupBoxIconView.Controls.Add(Me.radLabel7)
			Me.radGroupBoxIconView.FooterImageIndex = -1
			Me.radGroupBoxIconView.FooterImageKey = ""
			Me.radGroupBoxIconView.HeaderImageIndex = -1
			Me.radGroupBoxIconView.HeaderImageKey = ""
			Me.radGroupBoxIconView.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBoxIconView.HeaderText = "Icon View Settings"
			Me.radGroupBoxIconView.Location = New System.Drawing.Point(10, 472)
			Me.radGroupBoxIconView.Name = "radGroupBoxIconView"
			Me.radGroupBoxIconView.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			' 
			' 
			' 
			Me.radGroupBoxIconView.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			Me.radGroupBoxIconView.Size = New System.Drawing.Size(180, 48)
			Me.radGroupBoxIconView.TabIndex = 17
			Me.radGroupBoxIconView.Text = "Icon View Settings"
			' 
			' radDropDownList2
			' 
			Me.radDropDownList2.DropDownAnimationEnabled = True
			radListDataItem4.Text = "Vertical"
			radListDataItem4.TextWrap = True
			radListDataItem5.Text = "Horizontal"
			radListDataItem5.TextWrap = True
			Me.radDropDownList2.Items.Add(radListDataItem4)
			Me.radDropDownList2.Items.Add(radListDataItem5)
			Me.radDropDownList2.Location = New System.Drawing.Point(69, 21)
			Me.radDropDownList2.Name = "radDropDownList2"
			Me.radDropDownList2.ShowImageInEditorArea = True
			Me.radDropDownList2.Size = New System.Drawing.Size(106, 20)
			Me.radDropDownList2.TabIndex = 11
			Me.radDropDownList2.Text = "Vertical"
			' 
			' radLabel7
			' 
			Me.radLabel7.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel7.Location = New System.Drawing.Point(5, 22)
			Me.radLabel7.Name = "radLabel7"
			Me.radLabel7.Size = New System.Drawing.Size(63, 18)
			Me.radLabel7.TabIndex = 10
			Me.radLabel7.Text = "Orientation"
			' 
			' radGroupBox5
			' 
			Me.radGroupBox5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
			Me.radGroupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radGroupBox5.Controls.Add(Me.radDropDownListViewType)
			Me.radGroupBox5.Controls.Add(Me.radLabel1)
			Me.radGroupBox5.FooterImageIndex = -1
			Me.radGroupBox5.FooterImageKey = ""
			Me.radGroupBox5.HeaderImageIndex = -1
			Me.radGroupBox5.HeaderImageKey = ""
			Me.radGroupBox5.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox5.HeaderText = "View Type"
			Me.radGroupBox5.Location = New System.Drawing.Point(10, 35)
			Me.radGroupBox5.Name = "radGroupBox5"
			Me.radGroupBox5.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			' 
			' 
			' 
			Me.radGroupBox5.RootElement.Padding = New System.Windows.Forms.Padding(2, 18, 2, 2)
			Me.radGroupBox5.Size = New System.Drawing.Size(180, 47)
			Me.radGroupBox5.TabIndex = 18
			Me.radGroupBox5.Text = "View Type"
			' 
			' radDropDownListViewType
			' 
			Me.radDropDownListViewType.DropDownAnimationEnabled = True
			Me.radDropDownListViewType.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			radListDataItem1.Text = "List View"
			radListDataItem1.TextWrap = True
			radListDataItem2.Text = "Icon View"
			radListDataItem2.TextWrap = True
			radListDataItem3.Text = "Detail View"
			radListDataItem3.TextWrap = True
			Me.radDropDownListViewType.Items.Add(radListDataItem1)
			Me.radDropDownListViewType.Items.Add(radListDataItem2)
			Me.radDropDownListViewType.Items.Add(radListDataItem3)
			Me.radDropDownListViewType.Location = New System.Drawing.Point(69, 19)
			Me.radDropDownListViewType.Name = "radDropDownListViewType"
			Me.radDropDownListViewType.ShowImageInEditorArea = True
			Me.radDropDownListViewType.Size = New System.Drawing.Size(106, 20)
			Me.radDropDownListViewType.TabIndex = 3
			Me.radDropDownListViewType.Text = "List View"
			' 
			' radLabel1
			' 
			Me.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel1.Location = New System.Drawing.Point(5, 21)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(33, 18)
			Me.radLabel1.TabIndex = 2
			Me.radLabel1.Text = "View:"
			' 
			' radLabel8
			' 
			Me.radLabel8.Anchor = System.Windows.Forms.AnchorStyles.Top
			Me.radLabel8.Location = New System.Drawing.Point(5, 43)
			Me.radLabel8.Name = "radLabel8"
			Me.radLabel8.Size = New System.Drawing.Size(65, 18)
			Me.radLabel8.TabIndex = 24
			Me.radLabel8.Text = "Item Height"
			' 
			' radPanel1
			' 
			Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radPanel1.Location = New System.Drawing.Point(0, 0)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Size = New System.Drawing.Size(561, 30)
			Me.radPanel1.TabIndex = 2
			Me.radPanel1.Text = "My Computer"
			' 
			' radPanel2
			' 
			Me.radPanel2.Controls.Add(Me.radListView1)
			Me.radPanel2.Controls.Add(Me.radPanel1)
			Me.radPanel2.Location = New System.Drawing.Point(3, 72)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Size = New System.Drawing.Size(561, 372)
			Me.radPanel2.TabIndex = 3
			Me.radPanel2.Text = "radPanel2"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.radPanel2)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(1233, 832)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			Me.Controls.SetChildIndex(Me.radPanel2, 0)
			DirectCast(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			Me.settingsPanel.ResumeLayout(False)
			DirectCast(Me.radListView1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxShowCheckboxes, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxGroups, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			DirectCast(Me.radCheckBoxFullRowSelect, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radLabel5.ResumeLayout(False)
			Me.radLabel5.PerformLayout()
			DirectCast(Me.radCheckBox4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxArbWidth, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxArbHeight, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			Me.radGroupBox2.PerformLayout()
			DirectCast(Me.radSpinEditorGroupHeight, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radSpinEditorItemHeight, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radSpinEditorItemWidth, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radSpinEditorGroupIndent, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radSpinEditorItemSpacing, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGroupBoxDetailView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxDetailView.ResumeLayout(False)
			Me.radGroupBoxDetailView.PerformLayout()
			DirectCast(Me.radSpinEditorHeaderHeight, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxColHeaders, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxColSort, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxColReorder, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radCheckBoxColResize, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel6, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGroupBoxIconView, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBoxIconView.ResumeLayout(False)
			Me.radGroupBoxIconView.PerformLayout()
			DirectCast(Me.radDropDownList2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel7, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radGroupBox5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox5.ResumeLayout(False)
			Me.radGroupBox5.PerformLayout()
			DirectCast(Me.radDropDownListViewType, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radLabel8, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Friend WithEvents radListView1 As Telerik.WinControls.UI.RadListView
		Friend WithEvents radCheckBoxShowCheckboxes As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radCheckBoxGroups As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Friend WithEvents radLabel2 As Telerik.WinControls.UI.RadLabel
		Friend WithEvents radLabel3 As Telerik.WinControls.UI.RadLabel
		Friend WithEvents radLabel4 As Telerik.WinControls.UI.RadLabel
		Friend WithEvents radLabel5 As Telerik.WinControls.UI.RadLabel
		Friend WithEvents radCheckBox4 As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radCheckBoxArbWidth As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radCheckBoxArbHeight As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radCheckBoxFullRowSelect As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Friend WithEvents radGroupBoxDetailView As Telerik.WinControls.UI.RadGroupBox
		Friend WithEvents radLabel6 As Telerik.WinControls.UI.RadLabel
		Friend WithEvents radCheckBoxColResize As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radCheckBoxColReorder As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radCheckBoxColSort As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radCheckBoxColHeaders As Telerik.WinControls.UI.RadCheckBox
		Friend WithEvents radGroupBoxIconView As Telerik.WinControls.UI.RadGroupBox
		Friend WithEvents radLabel7 As Telerik.WinControls.UI.RadLabel
		Friend WithEvents radGroupBox5 As Telerik.WinControls.UI.RadGroupBox
		Friend WithEvents radLabel1 As Telerik.WinControls.UI.RadLabel
		Friend WithEvents radDropDownListViewType As Telerik.WinControls.UI.RadDropDownList
		Friend WithEvents radSpinEditorItemSpacing As Telerik.WinControls.UI.RadSpinEditor
		Friend WithEvents radSpinEditorGroupIndent As Telerik.WinControls.UI.RadSpinEditor
		Friend WithEvents radDropDownList2 As Telerik.WinControls.UI.RadDropDownList
		Friend WithEvents radSpinEditorHeaderHeight As Telerik.WinControls.UI.RadSpinEditor
		Friend WithEvents radSpinEditorItemWidth As Telerik.WinControls.UI.RadSpinEditor
		Friend WithEvents radSpinEditorItemHeight As Telerik.WinControls.UI.RadSpinEditor
		Friend WithEvents radSpinEditorGroupHeight As Telerik.WinControls.UI.RadSpinEditor
		Friend WithEvents radLabel8 As Telerik.WinControls.UI.RadLabel
		Friend WithEvents radPanel1 As TreeExampleHeaderPanel
		Friend WithEvents radPanel2 As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace
