Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.SplitContainer.FirstLook
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
			Me.components = New System.ComponentModel.Container()
			Dim radTreeNode1 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode2 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode3 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode4 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode5 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode6 As New Telerik.WinControls.UI.RadTreeNode()
			Dim radTreeNode7 As New Telerik.WinControls.UI.RadTreeNode()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridViewDateTimeColumn1 = New Telerik.WinControls.UI.GridViewDateTimeColumn()
			Me.gridViewTextBoxColumn1 = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.gridViewTextBoxColumn2 = New Telerik.WinControls.UI.GridViewTextBoxColumn()
			Me.radSplitContainer1_Renamed = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel1_Renamed = New Telerik.WinControls.UI.SplitPanel()
			Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.radLabel1 = New Telerik.WinControls.UI.RadLabel()
			Me.splitPanel2_Renamed = New Telerik.WinControls.UI.SplitPanel()
			Me.radGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGridView1 = New Telerik.WinControls.UI.RadGridView()
			Me.carsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.northwindDataSet = New Telerik.Examples.WinControls.DataSources.NorthwindDataSet()
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.splitPanel3_Renamed = New Telerik.WinControls.UI.SplitPanel()
			Me.radPanel2 = New Telerik.WinControls.UI.RadPanel()
			Me.radSplitContainer2_Renamed = New Telerik.WinControls.UI.RadSplitContainer()
			Me.splitPanel4_Renamed = New Telerik.WinControls.UI.SplitPanel()
			Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
			Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
			Me.splitPanel5_Renamed = New Telerik.WinControls.UI.SplitPanel()
			Me.radGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
			Me.radGridView2 = New Telerik.WinControls.UI.RadGridView()
			Me.radCalendar1 = New Telerik.WinControls.UI.RadCalendar()
			Me.radRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
			Me.ribbonTab2 = New Telerik.WinControls.UI.RibbonTab()
			Me.radRibbonBarGroup8 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.btnOpenDesigner = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup7 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radGalleryElement1 = New Telerik.WinControls.UI.RadGalleryElement()
			Me.radGalleryItem1 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem2 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem3 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem4 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem5 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem6 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem7 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem8 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radGalleryItem9 = New Telerik.WinControls.UI.RadGalleryItem()
			Me.radRibbonBarGroup4 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement1 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radDropDownButtonElement1 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radRibbonBarGroup6 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radRibbonBarButtonGroup5 = New Telerik.WinControls.UI.RadRibbonBarButtonGroup()
			Me.radDropDownButtonElement2 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radButtonElement5 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radDropDownButtonElement4 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radButtonElement2 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup5 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement7 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement8 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement9 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonBarGroup12 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radComboBoxElement1 = New Telerik.WinControls.UI.RadDropDownListElement()
			Me.radButtonElement4 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radDropDownButtonElement9 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.ribbonTab1 = New Telerik.WinControls.UI.RibbonTab()
			Me.radRibbonBarGroup10 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radDropDownButtonElement3 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radDropDownButtonElement5 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radDropDownButtonElement6 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radRibbonBarGroup11 = New Telerik.WinControls.UI.RadRibbonBarGroup()
			Me.radButtonElement3 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radDropDownButtonElement7 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radDropDownButtonElement8 = New Telerik.WinControls.UI.RadDropDownButtonElement()
			Me.radButtonElement6 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement11 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radButtonElement12 = New Telerik.WinControls.UI.RadButtonElement()
			Me.radRibbonFormBehavior1 = New Telerik.WinControls.UI.RadRibbonFormBehavior()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.carsTableAdapter = New Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter()
			Me.errorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
			Me.radPanelBar1 = New Telerik.WinControls.UI.RadPageView()
			Me.radPageViewPage1 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage2 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage3 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage4 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage5 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage6 = New Telerik.WinControls.UI.RadPageViewPage()
			Me.radPageViewPage7 = New Telerik.WinControls.UI.RadPageViewPage()
			CType(Me.radSplitContainer1_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer1_Renamed.SuspendLayout()
			CType(Me.splitPanel1_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel1_Renamed.SuspendLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitPanel2_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel2_Renamed.SuspendLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox2.SuspendLayout()
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitPanel3_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel3_Renamed.SuspendLayout()
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel2.SuspendLayout()
			CType(Me.radSplitContainer2_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radSplitContainer2_Renamed.SuspendLayout()
			CType(Me.splitPanel4_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel4_Renamed.SuspendLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.splitPanel5_Renamed, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitPanel5_Renamed.SuspendLayout()
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radGroupBox1.SuspendLayout()
			CType(Me.radGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radComboBoxElement1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanel1.SuspendLayout()
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelBar1.SuspendLayout()
			Me.radPageViewPage1.SuspendLayout()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridViewDateTimeColumn1
			' 
			Me.gridViewDateTimeColumn1.FieldName = "Date"
			Me.gridViewDateTimeColumn1.HeaderText = "Date"
			Me.gridViewDateTimeColumn1.IsAutoGenerated = True
			Me.gridViewDateTimeColumn1.Name = "Date"
			' 
			' gridViewTextBoxColumn1
			' 
			Me.gridViewTextBoxColumn1.HeaderText = "Newest on top"
			Me.gridViewTextBoxColumn1.Name = "column1"
			Me.gridViewTextBoxColumn1.Width = 90
			' 
			' gridViewTextBoxColumn2
			' 
			Me.gridViewTextBoxColumn2.HeaderText = "Tasks"
			Me.gridViewTextBoxColumn2.Name = "column1"
			Me.gridViewTextBoxColumn2.Width = 150
			' 
			' radSplitContainer1
			' 
			Me.radSplitContainer1_Renamed.Controls.Add(Me.splitPanel1_Renamed)
			Me.radSplitContainer1_Renamed.Controls.Add(Me.splitPanel2_Renamed)
			Me.radSplitContainer1_Renamed.Controls.Add(Me.splitPanel3_Renamed)
			Me.radSplitContainer1_Renamed.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radSplitContainer1_Renamed.Location = New System.Drawing.Point(1, 1)
			Me.radSplitContainer1_Renamed.Name = "radSplitContainer1"
			' 
			' 
			' 
			Me.radSplitContainer1_Renamed.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radSplitContainer1_Renamed.Size = New System.Drawing.Size(1290, 778)
			Me.radSplitContainer1_Renamed.TabIndex = 0
			Me.radSplitContainer1_Renamed.TabStop = False
			Me.radSplitContainer1_Renamed.Text = "radSplitContainer1"
			' 
			' splitPanel1
			' 
			Me.splitPanel1_Renamed.Controls.Add(Me.radLabel1)
			Me.splitPanel1_Renamed.Controls.Add(Me.radPanelBar1)
			Me.splitPanel1_Renamed.Location = New System.Drawing.Point(0, 0)
			Me.splitPanel1_Renamed.Name = "splitPanel1"
			Me.splitPanel1_Renamed.Padding = New System.Windows.Forms.Padding(1)
			' 
			' 
			' 
			Me.splitPanel1_Renamed.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.splitPanel1_Renamed.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.splitPanel1_Renamed.Size = New System.Drawing.Size(200, 778)
			Me.splitPanel1_Renamed.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1412151F, 0F)
			Me.splitPanel1_Renamed.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Absolute
			Me.splitPanel1_Renamed.SizeInfo.SplitterCorrection = New System.Drawing.Size(-144, 0)
			Me.splitPanel1_Renamed.TabIndex = 0
			Me.splitPanel1_Renamed.TabStop = False
			Me.splitPanel1_Renamed.Text = "splitPanel1"
			' 
			' radTreeView1
			' 
			Me.radTreeView1.BackColor = System.Drawing.Color.White
			Me.radTreeView1.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radTreeView1.Font = New System.Drawing.Font("Tahoma", 8.6F)
			Me.radTreeView1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.radTreeView1.ImageList = Me.imageList1
			Me.radTreeView1.Location = New System.Drawing.Point(0, 0)
			Me.radTreeView1.Name = "radTreeView1"
			radTreeNode1.Expanded = True
			radTreeNode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			radTreeNode1.Image = (CType(resources.GetObject("radTreeNode1.Image"), System.Drawing.Image))
			radTreeNode1.ImageKey = "splitcon_firstlook_folder_star.png"
			radTreeNode2.Image = (CType(resources.GetObject("radTreeNode2.Image"), System.Drawing.Image))
			radTreeNode2.ImageIndex = 4
			radTreeNode2.Text = "Sent Items"
			radTreeNode3.Image = (CType(resources.GetObject("radTreeNode3.Image"), System.Drawing.Image))
			radTreeNode3.ImageKey = "splitcon_firstlook_bin_closed.png"
			radTreeNode3.Text = "Delete Items"
			radTreeNode1.Nodes.Add(radTreeNode2)
			radTreeNode1.Nodes.Add(radTreeNode3)
			radTreeNode1.Text = "Favorites"
			radTreeNode4.Expanded = True
			radTreeNode4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			radTreeNode4.Image = (CType(resources.GetObject("radTreeNode4.Image"), System.Drawing.Image))
			radTreeNode4.ImageIndex = 3
			radTreeNode5.Image = (CType(resources.GetObject("radTreeNode5.Image"), System.Drawing.Image))
			radTreeNode5.ImageIndex = 5
			radTreeNode5.Text = "Inbox"
			radTreeNode6.Image = (CType(resources.GetObject("radTreeNode6.Image"), System.Drawing.Image))
			radTreeNode6.ImageKey = "splitcon_firstlook_folder_draft.gif"
			radTreeNode6.Text = "Drafts"
			radTreeNode7.Image = (CType(resources.GetObject("radTreeNode7.Image"), System.Drawing.Image))
			radTreeNode7.ImageIndex = 4
			radTreeNode7.Text = "Sent Items"
			radTreeNode4.Nodes.Add(radTreeNode5)
			radTreeNode4.Nodes.Add(radTreeNode6)
			radTreeNode4.Nodes.Add(radTreeNode7)
			radTreeNode4.Text = "MailBox"
			Me.radTreeView1.Nodes.Add(radTreeNode1)
			Me.radTreeView1.Nodes.Add(radTreeNode4)
			Me.radTreeView1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.radTreeView1.ShowLines = True
			Me.radTreeView1.Size = New System.Drawing.Size(188, 479)
			Me.radTreeView1.TabIndex = 1
			Me.radTreeView1.Text = "radTreeView1"
			Me.radTreeView1.ThemeName = "ControlDefault"
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "splitcon_firstlook_folder_star.png")
			Me.imageList1.Images.SetKeyName(1, "splitcon_firstlook_bin_closed.png")
			Me.imageList1.Images.SetKeyName(2, "splitcon_firstlook_folder_draft.gif")
			Me.imageList1.Images.SetKeyName(3, "splitcon_firstlook_mailbox.png")
			Me.imageList1.Images.SetKeyName(4, "splitcon_firstlook_sentitems.png")
			Me.imageList1.Images.SetKeyName(5, "splitcon_firstlook_inbox.png")
			' 
			' radLabel1
			' 
			Me.radLabel1.Location = New System.Drawing.Point(7, 8)
			Me.radLabel1.Name = "radLabel1"
			Me.radLabel1.Size = New System.Drawing.Size(68, 18)
			Me.radLabel1.TabIndex = 0
			Me.radLabel1.Text = "Split Panel 1"
			' 
			' splitPanel2
			' 
			Me.splitPanel2_Renamed.Controls.Add(Me.radGroupBox2)
			Me.splitPanel2_Renamed.Controls.Add(Me.radLabel2)
			Me.splitPanel2_Renamed.Location = New System.Drawing.Point(203, 0)
			Me.splitPanel2_Renamed.Name = "splitPanel2"
			Me.splitPanel2_Renamed.Padding = New System.Windows.Forms.Padding(1)
			' 
			' 
			' 
			Me.splitPanel2_Renamed.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.splitPanel2_Renamed.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.splitPanel2_Renamed.Size = New System.Drawing.Size(397, 778)
			Me.splitPanel2_Renamed.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.1343186F, 0F)
			Me.splitPanel2_Renamed.SizeInfo.SplitterCorrection = New System.Drawing.Size(-125, 0)
			Me.splitPanel2_Renamed.TabIndex = 1
			Me.splitPanel2_Renamed.TabStop = False
			Me.splitPanel2_Renamed.Text = "splitPanel2"
			' 
			' radGroupBox2
			' 
			Me.radGroupBox2.Controls.Add(Me.radGridView1)
			Me.radGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGroupBox2.FooterImageIndex = -1
			Me.radGroupBox2.FooterImageKey = ""
			Me.radGroupBox2.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
			Me.radGroupBox2.HeaderImageIndex = -1
			Me.radGroupBox2.HeaderImageKey = ""
			Me.radGroupBox2.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox2.HeaderText = "Inbox"
			Me.radGroupBox2.Location = New System.Drawing.Point(1, 1)
			Me.radGroupBox2.Name = "radGroupBox2"
			Me.radGroupBox2.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox2.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox2.Size = New System.Drawing.Size(395, 776)
			Me.radGroupBox2.TabIndex = 1
			Me.radGroupBox2.Text = "Inbox"
			CType(Me.radGroupBox2.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			CType(Me.radGroupBox2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
			CType(Me.radGroupBox2.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).MinSize = New System.Drawing.Size(0, 20)
			' 
			' radGridView1
			' 
			Me.radGridView1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGridView1.Location = New System.Drawing.Point(1, 21)
			' 
			' radGridView1
			' 
			Me.radGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { Me.gridViewDateTimeColumn1, Me.gridViewTextBoxColumn1})
			Me.radGridView1.MasterTemplate.DataSource = Me.carsBindingSource
			Me.radGridView1.Name = "radGridView1"
			Me.radGridView1.Size = New System.Drawing.Size(394, 755)
			Me.radGridView1.TabIndex = 1
			' 
			' carsBindingSource
			' 
			Me.carsBindingSource.DataMember = "Cars"
			Me.carsBindingSource.DataSource = Me.northwindDataSet
			' 
			' northwindDataSet
			' 
			Me.northwindDataSet.DataSetName = "NorthwindDataSet"
			Me.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' radLabel2
			' 
			Me.radLabel2.Location = New System.Drawing.Point(13, 8)
			Me.radLabel2.Name = "radLabel2"
			Me.radLabel2.Size = New System.Drawing.Size(68, 18)
			Me.radLabel2.TabIndex = 0
			Me.radLabel2.Text = "Split Panel 2"
			' 
			' splitPanel3
			' 
			Me.splitPanel3_Renamed.Controls.Add(Me.radPanel2)
			Me.splitPanel3_Renamed.Location = New System.Drawing.Point(603, 0)
			Me.splitPanel3_Renamed.Name = "splitPanel3"
			Me.splitPanel3_Renamed.Padding = New System.Windows.Forms.Padding(1)
			' 
			' 
			' 
			Me.splitPanel3_Renamed.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.splitPanel3_Renamed.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.splitPanel3_Renamed.Size = New System.Drawing.Size(687, 778)
			Me.splitPanel3_Renamed.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2755336F, 0F)
			Me.splitPanel3_Renamed.SizeInfo.SplitterCorrection = New System.Drawing.Size(269, 0)
			Me.splitPanel3_Renamed.TabIndex = 2
			Me.splitPanel3_Renamed.TabStop = False
			Me.splitPanel3_Renamed.Text = "splitPanel3"
			' 
			' radPanel2
			' 
			Me.radPanel2.Controls.Add(Me.radSplitContainer2_Renamed)
			Me.radPanel2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPanel2.Location = New System.Drawing.Point(1, 1)
			Me.radPanel2.Name = "radPanel2"
			Me.radPanel2.Padding = New System.Windows.Forms.Padding(1)
			' 
			' 
			' 
			Me.radPanel2.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.radPanel2.Size = New System.Drawing.Size(685, 776)
			Me.radPanel2.TabIndex = 0
			Me.radPanel2.Text = "radPanel2"
			' 
			' radSplitContainer2
			' 
			Me.radSplitContainer2_Renamed.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(191))))), (CInt(Fix((CByte(219))))), (CInt(Fix((CByte(254))))))
			Me.radSplitContainer2_Renamed.Controls.Add(Me.splitPanel4_Renamed)
			Me.radSplitContainer2_Renamed.Controls.Add(Me.splitPanel5_Renamed)
			Me.radSplitContainer2_Renamed.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.radSplitContainer2_Renamed.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radSplitContainer2_Renamed.Location = New System.Drawing.Point(1, 1)
			Me.radSplitContainer2_Renamed.Name = "radSplitContainer2"
			' 
			' 
			' 
			Me.radSplitContainer2_Renamed.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.radSplitContainer2_Renamed.Size = New System.Drawing.Size(683, 774)
			Me.radSplitContainer2_Renamed.TabIndex = 0
			Me.radSplitContainer2_Renamed.TabStop = False
			Me.radSplitContainer2_Renamed.Text = "BrowserToDoBarSplitContainer"
			' 
			' splitPanel4
			' 
			Me.splitPanel4_Renamed.Controls.Add(Me.webBrowser1)
			Me.splitPanel4_Renamed.Controls.Add(Me.radLabel3)
			Me.splitPanel4_Renamed.Location = New System.Drawing.Point(0, 0)
			Me.splitPanel4_Renamed.Name = "splitPanel4"
			Me.splitPanel4_Renamed.Padding = New System.Windows.Forms.Padding(1)
			' 
			' 
			' 
			Me.splitPanel4_Renamed.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.splitPanel4_Renamed.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.splitPanel4_Renamed.Size = New System.Drawing.Size(489, 774)
			Me.splitPanel4_Renamed.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(0.2186992F, -0.009803922F)
			Me.splitPanel4_Renamed.SizeInfo.SplitterCorrection = New System.Drawing.Size(115, -7)
			Me.splitPanel4_Renamed.TabIndex = 0
			Me.splitPanel4_Renamed.TabStop = False
			Me.splitPanel4_Renamed.Text = "splitPanel4"
			' 
			' webBrowser1
			' 
			Me.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.webBrowser1.Location = New System.Drawing.Point(1, 1)
			Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
			Me.webBrowser1.Name = "webBrowser1"
			Me.webBrowser1.Size = New System.Drawing.Size(487, 772)
			Me.webBrowser1.TabIndex = 1
			Me.webBrowser1.Url = New System.Uri("", System.UriKind.Relative)
			' 
			' radLabel3
			' 
			Me.radLabel3.Location = New System.Drawing.Point(16, 8)
			Me.radLabel3.Name = "radLabel3"
			Me.radLabel3.Size = New System.Drawing.Size(68, 18)
			Me.radLabel3.TabIndex = 0
			Me.radLabel3.Text = "Split Panel 3"
			' 
			' splitPanel5
			' 
			Me.splitPanel5_Renamed.Controls.Add(Me.radGroupBox1)
			Me.splitPanel5_Renamed.Location = New System.Drawing.Point(492, 0)
			Me.splitPanel5_Renamed.Name = "splitPanel5"
			Me.splitPanel5_Renamed.Padding = New System.Windows.Forms.Padding(1)
			' 
			' 
			' 
			Me.splitPanel5_Renamed.RootElement.MinSize = New System.Drawing.Size(25, 25)
			Me.splitPanel5_Renamed.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.splitPanel5_Renamed.Size = New System.Drawing.Size(191, 774)
			Me.splitPanel5_Renamed.SizeInfo.AutoSizeScale = New System.Drawing.SizeF(-0.2186992F, 0.009803922F)
			Me.splitPanel5_Renamed.SizeInfo.SplitterCorrection = New System.Drawing.Size(-115, 7)
			Me.splitPanel5_Renamed.TabIndex = 1
			Me.splitPanel5_Renamed.TabStop = False
			Me.splitPanel5_Renamed.Text = "splitPanel5"
			' 
			' radGroupBox1
			' 
			Me.radGroupBox1.Controls.Add(Me.radGridView2)
			Me.radGroupBox1.Controls.Add(Me.radCalendar1)
			Me.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radGroupBox1.FooterImageIndex = -1
			Me.radGroupBox1.FooterImageKey = ""
			Me.radGroupBox1.GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
			Me.radGroupBox1.HeaderImageIndex = -1
			Me.radGroupBox1.HeaderImageKey = ""
			Me.radGroupBox1.HeaderMargin = New System.Windows.Forms.Padding(0)
			Me.radGroupBox1.HeaderText = "To-Do Bar"
			Me.radGroupBox1.Location = New System.Drawing.Point(1, 1)
			Me.radGroupBox1.Name = "radGroupBox1"
			Me.radGroupBox1.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			' 
			' 
			' 
			Me.radGroupBox1.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			Me.radGroupBox1.Size = New System.Drawing.Size(189, 772)
			Me.radGroupBox1.TabIndex = 0
			Me.radGroupBox1.Text = "To-Do Bar"
			CType(Me.radGroupBox1.GetChildAt(0), Telerik.WinControls.UI.RadGroupBoxElement).Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
			CType(Me.radGroupBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).GroupBoxStyle = Telerik.WinControls.UI.RadGroupBoxStyle.Office
			CType(Me.radGroupBox1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.UI.GroupBoxHeader).MinSize = New System.Drawing.Size(0, 20)
			' 
			' radGridView2
			' 
			Me.radGridView2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radGridView2.Location = New System.Drawing.Point(1, 171)
			' 
			' radGridView2
			' 
			Me.radGridView2.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() { Me.gridViewTextBoxColumn2})
			Me.radGridView2.Name = "radGridView2"
			Me.radGridView2.Size = New System.Drawing.Size(187, 603)
			Me.radGridView2.TabIndex = 2
			' 
			' radCalendar1
			' 
			Me.radCalendar1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.radCalendar1.CellAlign = System.Drawing.ContentAlignment.MiddleCenter
			Me.radCalendar1.FastNavigationNextImage = (CType(resources.GetObject("radCalendar1.FastNavigationNextImage"), System.Drawing.Image))
			Me.radCalendar1.FastNavigationPrevImage = (CType(resources.GetObject("radCalendar1.FastNavigationPrevImage"), System.Drawing.Image))
			Me.radCalendar1.HeaderHeight = 17
			Me.radCalendar1.HeaderWidth = 17
			Me.radCalendar1.Location = New System.Drawing.Point(0, 20)
			Me.radCalendar1.Name = "radCalendar1"
			Me.radCalendar1.NavigationNextImage = (CType(resources.GetObject("radCalendar1.NavigationNextImage"), System.Drawing.Image))
			Me.radCalendar1.NavigationPrevImage = (CType(resources.GetObject("radCalendar1.NavigationPrevImage"), System.Drawing.Image))
			Me.radCalendar1.RangeMaxDate = New System.DateTime(2099, 12, 30, 0, 0, 0, 0)
			Me.radCalendar1.SelectedDate = New System.DateTime(1900, 1, 1, 0, 0, 0, 0)
			Me.radCalendar1.Size = New System.Drawing.Size(192, 151)
			Me.radCalendar1.TabIndex = 1
			Me.radCalendar1.Text = "radCalendar1"
			Me.radCalendar1.TitleAlign = System.Windows.Forms.VisualStyles.ContentAlignment.Center
			Me.radCalendar1.ZoomFactor = 1.2F
			' 
			' radRibbonBar1
			' 
			Me.radRibbonBar1.AutoSize = True
			Me.radRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() { Me.ribbonTab2, Me.ribbonTab1})
			Me.radRibbonBar1.Dock = System.Windows.Forms.DockStyle.Top
			Me.radRibbonBar1.EnableKeyMap = True
			' 
			' 
			' 
			Me.radRibbonBar1.ExitButton.AccessibleDescription = "Exit"
			Me.radRibbonBar1.ExitButton.AccessibleName = "Exit"
			' 
			' 
			' 
			Me.radRibbonBar1.ExitButton.ButtonElement.AccessibleDescription = "Exit"
			Me.radRibbonBar1.ExitButton.ButtonElement.AccessibleName = "Exit"
			Me.radRibbonBar1.ExitButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radRibbonBar1.ExitButton.Text = "Exit"
			Me.radRibbonBar1.Location = New System.Drawing.Point(0, 0)
			Me.radRibbonBar1.Name = "radRibbonBar1"
			' 
			' 
			' 
			Me.radRibbonBar1.OptionsButton.AccessibleDescription = "Options"
			Me.radRibbonBar1.OptionsButton.AccessibleName = "Options"
			' 
			' 
			' 
			Me.radRibbonBar1.OptionsButton.ButtonElement.AccessibleDescription = "Options"
			Me.radRibbonBar1.OptionsButton.ButtonElement.AccessibleName = "Options"
			Me.radRibbonBar1.OptionsButton.ButtonElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radRibbonBar1.OptionsButton.Text = "Options"
			Me.radRibbonBar1.QuickAccessToolBarItems.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement6, Me.radButtonElement11, Me.radButtonElement12})
			Me.radRibbonBar1.Size = New System.Drawing.Size(1292, 160)
			Me.radRibbonBar1.StartButtonImage = (CType(resources.GetObject("radRibbonBar1.StartButtonImage"), System.Drawing.Image))
			Me.radRibbonBar1.TabIndex = 1
			Me.radRibbonBar1.Text = "RadSplitContainer"
			' 
			' ribbonTab2
			' 
			Me.ribbonTab2.AccessibleDescription = "Home"
			Me.ribbonTab2.AccessibleName = "Home"
			Me.ribbonTab2.Alignment = System.Drawing.ContentAlignment.BottomLeft
			' 
			' ribbonTab2.ContentPanel
			' 
			Me.ribbonTab2.ContentPanel.BackColor = System.Drawing.Color.Transparent
			Me.ribbonTab2.ContentPanel.CausesValidation = True
			Me.ribbonTab2.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ribbonTab2.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ribbonTab2.ContentPanel.Location = New System.Drawing.Point(0, 0)
			Me.ribbonTab2.ContentPanel.Size = New System.Drawing.Size(200, 100)
			Me.ribbonTab2.IsSelected = True
			Me.ribbonTab2.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarGroup8, Me.radRibbonBarGroup7, Me.radRibbonBarGroup4, Me.radRibbonBarGroup6, Me.radRibbonBarGroup5, Me.radRibbonBarGroup12})
			Me.ribbonTab2.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
			Me.ribbonTab2.Name = "ribbonTab2"
			Me.ribbonTab2.StretchHorizontally = False
			Me.ribbonTab2.Text = "Home"
			Me.ribbonTab2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup8
			' 
			Me.radRibbonBarGroup8.AccessibleDescription = "Layout"
			Me.radRibbonBarGroup8.AccessibleName = "Layout"
			Me.radRibbonBarGroup8.Items.AddRange(New Telerik.WinControls.RadItem() { Me.btnOpenDesigner})
			Me.radRibbonBarGroup8.Name = "radRibbonBarGroup8"
			Me.radRibbonBarGroup8.Text = "Layout"
			Me.radRibbonBarGroup8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' btnOpenDesigner
			' 
			Me.btnOpenDesigner.AccessibleDescription = "Open Layout Properties Window"
			Me.btnOpenDesigner.AccessibleName = "Open Layout Properties Window"
			Me.btnOpenDesigner.Class = "RibbonBarButtonElement"
			Me.btnOpenDesigner.MaxSize = New System.Drawing.Size(150, 0)
			Me.btnOpenDesigner.Name = "btnOpenDesigner"
			Me.btnOpenDesigner.Text = "Open Layout Properties Window"
			Me.btnOpenDesigner.TextWrap = True
			Me.btnOpenDesigner.Visibility = Telerik.WinControls.ElementVisibility.Visible
'			Me.btnOpenDesigner.Click += New System.EventHandler(Me.btnOpenDesigner_Click);
			' 
			' radRibbonBarGroup7
			' 
			Me.radRibbonBarGroup7.AccessibleDescription = "Quick Steps"
			Me.radRibbonBarGroup7.AccessibleName = "Quick Steps"
			Me.radRibbonBarGroup7.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radGalleryElement1})
			Me.radRibbonBarGroup7.Name = "radRibbonBarGroup7"
			Me.radRibbonBarGroup7.Text = "Quick Steps"
			Me.radRibbonBarGroup7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryElement1
			' 
			Me.radGalleryElement1.AccessibleDescription = "radGalleryElement1"
			Me.radGalleryElement1.AccessibleName = "radGalleryElement1"
			Me.radGalleryElement1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radGalleryItem1, Me.radGalleryItem2, Me.radGalleryItem3, Me.radGalleryItem4, Me.radGalleryItem5, Me.radGalleryItem6, Me.radGalleryItem7, Me.radGalleryItem8, Me.radGalleryItem9})
			Me.radGalleryElement1.MaxColumns = 3
			Me.radGalleryElement1.MaxRows = 3
			Me.radGalleryElement1.Name = "radGalleryElement1"
			Me.radGalleryElement1.Padding = New System.Windows.Forms.Padding(2, 2, 0, 0)
			Me.radGalleryElement1.Text = "radGalleryElement1"
			Me.radGalleryElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem1
			' 
			Me.radGalleryItem1.AccessibleDescription = "Forward to team"
			Me.radGalleryItem1.AccessibleName = "Forward to team"
			Me.radGalleryItem1.DescriptionText = ""
			Me.radGalleryItem1.Image = My.Resources.splitcon_firstlook_forwardTeam
			Me.radGalleryItem1.Name = "radGalleryItem1"
			Me.radGalleryItem1.StretchHorizontally = False
			Me.radGalleryItem1.StretchVertically = False
			Me.radGalleryItem1.Text = "Forward to team"
			Me.radGalleryItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radGalleryItem1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem2
			' 
			Me.radGalleryItem2.AccessibleDescription = "To Manager"
			Me.radGalleryItem2.AccessibleName = "To Manager"
			Me.radGalleryItem2.DescriptionText = ""
			Me.radGalleryItem2.Image = My.Resources.splitcon_firstlook_forwardTeam
			Me.radGalleryItem2.Name = "radGalleryItem2"
			Me.radGalleryItem2.StretchHorizontally = False
			Me.radGalleryItem2.StretchVertically = False
			Me.radGalleryItem2.Text = "To Manager"
			Me.radGalleryItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radGalleryItem2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem3
			' 
			Me.radGalleryItem3.AccessibleDescription = "Team E-Mail"
			Me.radGalleryItem3.AccessibleName = "Team E-Mail"
			Me.radGalleryItem3.DescriptionText = ""
			Me.radGalleryItem3.Image = My.Resources.splitcon_firstlook_teamemail
			Me.radGalleryItem3.Name = "radGalleryItem3"
			Me.radGalleryItem3.StretchHorizontally = False
			Me.radGalleryItem3.StretchVertically = False
			Me.radGalleryItem3.Text = "Team E-Mail"
			Me.radGalleryItem3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radGalleryItem3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem4
			' 
			Me.radGalleryItem4.AccessibleDescription = "Move To ?"
			Me.radGalleryItem4.AccessibleName = "Move To ?"
			Me.radGalleryItem4.DescriptionText = ""
			Me.radGalleryItem4.Image = My.Resources.splitcon_firstlook_moveto
			Me.radGalleryItem4.Name = "radGalleryItem4"
			Me.radGalleryItem4.StretchHorizontally = False
			Me.radGalleryItem4.StretchVertically = False
			Me.radGalleryItem4.Text = "Move To ?"
			Me.radGalleryItem4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radGalleryItem4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem5
			' 
			Me.radGalleryItem5.AccessibleDescription = "Meeting Reply"
			Me.radGalleryItem5.AccessibleName = "Meeting Reply"
			Me.radGalleryItem5.DescriptionText = ""
			Me.radGalleryItem5.Image = My.Resources.splitcon_firstlook_meetingreply
			Me.radGalleryItem5.Name = "radGalleryItem5"
			Me.radGalleryItem5.StretchHorizontally = False
			Me.radGalleryItem5.StretchVertically = False
			Me.radGalleryItem5.Text = "Meeting Reply"
			Me.radGalleryItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radGalleryItem5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem6
			' 
			Me.radGalleryItem6.AccessibleDescription = "Forward: FYI"
			Me.radGalleryItem6.AccessibleName = "Forward: FYI"
			Me.radGalleryItem6.DescriptionText = ""
			Me.radGalleryItem6.Image = My.Resources.splitcon_firstlook_forwardTeam
			Me.radGalleryItem6.Name = "radGalleryItem6"
			Me.radGalleryItem6.StretchHorizontally = False
			Me.radGalleryItem6.StretchVertically = False
			Me.radGalleryItem6.Text = "Forward: FYI"
			Me.radGalleryItem6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radGalleryItem6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem7
			' 
			Me.radGalleryItem7.AccessibleDescription = "Done"
			Me.radGalleryItem7.AccessibleName = "Done"
			Me.radGalleryItem7.DescriptionText = ""
			Me.radGalleryItem7.Image = My.Resources.splitcon_firstlook_done
			Me.radGalleryItem7.Name = "radGalleryItem7"
			Me.radGalleryItem7.StretchHorizontally = False
			Me.radGalleryItem7.StretchVertically = False
			Me.radGalleryItem7.Text = "Done"
			Me.radGalleryItem7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radGalleryItem7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem8
			' 
			Me.radGalleryItem8.AccessibleDescription = "Reply && Delete"
			Me.radGalleryItem8.AccessibleName = "Reply && Delete"
			Me.radGalleryItem8.DescriptionText = ""
			Me.radGalleryItem8.Image = My.Resources.splitcon_firstlook_replydelete
			Me.radGalleryItem8.Name = "radGalleryItem8"
			Me.radGalleryItem8.StretchHorizontally = False
			Me.radGalleryItem8.StretchVertically = False
			Me.radGalleryItem8.Text = "Reply && Delete"
			Me.radGalleryItem8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radGalleryItem8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radGalleryItem9
			' 
			Me.radGalleryItem9.AccessibleDescription = "Team Meeting"
			Me.radGalleryItem9.AccessibleName = "Team Meeting"
			Me.radGalleryItem9.DescriptionText = ""
			Me.radGalleryItem9.Image = My.Resources.splitcon_firstlook_teammeeting
			Me.radGalleryItem9.Name = "radGalleryItem9"
			Me.radGalleryItem9.StretchHorizontally = False
			Me.radGalleryItem9.StretchVertically = False
			Me.radGalleryItem9.Text = "Team Meeting"
			Me.radGalleryItem9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radGalleryItem9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup4
			' 
			Me.radRibbonBarGroup4.AccessibleDescription = "New"
			Me.radRibbonBarGroup4.AccessibleName = "New"
			Me.radRibbonBarGroup4.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement1, Me.radDropDownButtonElement1})
			Me.radRibbonBarGroup4.Name = "radRibbonBarGroup4"
			Me.radRibbonBarGroup4.Text = "New"
			Me.radRibbonBarGroup4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement1
			' 
			Me.radButtonElement1.AccessibleDescription = "<html> New <br>E-mail"
			Me.radButtonElement1.AccessibleName = "<html> New <br>E-mail"
			Me.radButtonElement1.Class = "RibbonBarButtonElement"
			Me.radButtonElement1.Image = My.Resources.splitcon_firstlook_mail_write_48
			Me.radButtonElement1.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement1.Name = "radButtonElement1"
			Me.radButtonElement1.SmallImage = My.Resources.splitcon_firstlook_mail_write_16
			Me.radButtonElement1.Text = "<html> New <br>E-mail"
			Me.radButtonElement1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement1
			' 
			Me.radDropDownButtonElement1.AccessibleDescription = "<html> New <br>Items"
			Me.radDropDownButtonElement1.AccessibleName = "<html> New <br>Items"
			Me.radDropDownButtonElement1.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement1.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			Me.radDropDownButtonElement1.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement1.ExpandArrowButton = False
			Me.radDropDownButtonElement1.Image = My.Resources.splitcon_firstlook_newitems_big
			Me.radDropDownButtonElement1.Name = "radDropDownButtonElement1"
			Me.radDropDownButtonElement1.Text = "<html> New <br>Items"
			Me.radDropDownButtonElement1.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radDropDownButtonElement1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radDropDownButtonElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radDropDownButtonElement1.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ExpandArrow = False
			CType(Me.radDropDownButtonElement1.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			CType(Me.radDropDownButtonElement1.GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadArrowButtonElement).MinSize = New System.Drawing.Size(12, 12)
			CType(Me.radDropDownButtonElement1.GetChildAt(1).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftWidth = 0F
			' 
			' radRibbonBarGroup6
			' 
			Me.radRibbonBarGroup6.AccessibleDescription = "Delete"
			Me.radRibbonBarGroup6.AccessibleName = "Delete"
			Me.radRibbonBarGroup6.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarButtonGroup5, Me.radButtonElement2})
			Me.radRibbonBarGroup6.Name = "radRibbonBarGroup6"
			Me.radRibbonBarGroup6.Text = "Delete"
			Me.radRibbonBarGroup6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarButtonGroup5
			' 
			Me.radRibbonBarButtonGroup5.AccessibleDescription = "radRibbonBarButtonGroup5"
			Me.radRibbonBarButtonGroup5.AccessibleName = "radRibbonBarButtonGroup5"
			Me.radRibbonBarButtonGroup5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radDropDownButtonElement2, Me.radButtonElement5, Me.radDropDownButtonElement4})
			Me.radRibbonBarButtonGroup5.Name = "radRibbonBarButtonGroup5"
			Me.radRibbonBarButtonGroup5.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarButtonGroup5.Padding = New System.Windows.Forms.Padding(1)
			Me.radRibbonBarButtonGroup5.ShowBackColor = False
			Me.radRibbonBarButtonGroup5.ShowBorder = False
			Me.radRibbonBarButtonGroup5.StretchVertically = False
			Me.radRibbonBarButtonGroup5.Text = "radRibbonBarButtonGroup5"
			Me.radRibbonBarButtonGroup5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement2
			' 
			Me.radDropDownButtonElement2.AccessibleDescription = "Junk"
			Me.radDropDownButtonElement2.AccessibleName = "Junk"
			Me.radDropDownButtonElement2.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement2.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement2.ExpandArrowButton = False
			Me.radDropDownButtonElement2.Image = My.Resources.splitcon_firstlook_junk
			Me.radDropDownButtonElement2.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
			Me.radDropDownButtonElement2.Name = "radDropDownButtonElement2"
			Me.radDropDownButtonElement2.Text = "Junk"
			Me.radDropDownButtonElement2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radDropDownButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radDropDownButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement5
			' 
			Me.radButtonElement5.AccessibleDescription = "Ignore"
			Me.radButtonElement5.AccessibleName = "Ignore"
			Me.radButtonElement5.Class = "RibbonBarButtonElement"
			Me.radButtonElement5.Image = My.Resources.splitcon_firstlook_ignore
			Me.radButtonElement5.MinSize = New System.Drawing.Size(0, 20)
			Me.radButtonElement5.Name = "radButtonElement5"
			Me.radButtonElement5.Text = "Ignore"
			Me.radButtonElement5.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement4
			' 
			Me.radDropDownButtonElement4.AccessibleDescription = "Clean Up"
			Me.radDropDownButtonElement4.AccessibleName = "Clean Up"
			Me.radDropDownButtonElement4.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement4.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement4.ExpandArrowButton = False
			Me.radDropDownButtonElement4.Image = My.Resources.splitcon_firstlook_cleanup
			Me.radDropDownButtonElement4.Margin = New System.Windows.Forms.Padding(0, 0, 1, 1)
			Me.radDropDownButtonElement4.Name = "radDropDownButtonElement4"
			Me.radDropDownButtonElement4.Text = "Clean Up"
			Me.radDropDownButtonElement4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radDropDownButtonElement4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radDropDownButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement2
			' 
			Me.radButtonElement2.AccessibleDescription = "Delete "
			Me.radButtonElement2.AccessibleName = "Delete "
			Me.radButtonElement2.Class = "RibbonBarButtonElement"
			Me.radButtonElement2.Image = My.Resources.splitcon_firstlook_Delete
			Me.radButtonElement2.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement2.Name = "radButtonElement2"
			Me.radButtonElement2.SmallImage = My.Resources.splitcon_firstlook_Delete_small
			Me.radButtonElement2.Text = "Delete "
			Me.radButtonElement2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radButtonElement2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup5
			' 
			Me.radRibbonBarGroup5.AccessibleDescription = "Respond"
			Me.radRibbonBarGroup5.AccessibleName = "Respond"
			Me.radRibbonBarGroup5.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement7, Me.radButtonElement8, Me.radButtonElement9})
			Me.radRibbonBarGroup5.Name = "radRibbonBarGroup5"
			Me.radRibbonBarGroup5.Text = "Respond"
			Me.radRibbonBarGroup5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement7
			' 
			Me.radButtonElement7.AccessibleDescription = "<html> Reply<br /></html>"
			Me.radButtonElement7.AccessibleName = "<html> Reply<br /></html>"
			Me.radButtonElement7.Class = "RibbonBarButtonElement"
			Me.radButtonElement7.Image = My.Resources.splitcon_firstlook_mail_reply
			Me.radButtonElement7.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButtonElement7.Name = "radButtonElement7"
			Me.radButtonElement7.Text = "<html> Reply<br /></html>"
			Me.radButtonElement7.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radButtonElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement8
			' 
			Me.radButtonElement8.AccessibleDescription = "<html> Reply <br>All"
			Me.radButtonElement8.AccessibleName = "<html> Reply <br>All"
			Me.radButtonElement8.Class = "RibbonBarButtonElement"
			Me.radButtonElement8.Image = My.Resources.splitcont_firstlook_mail_replayall
			Me.radButtonElement8.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButtonElement8.Name = "radButtonElement8"
			Me.radButtonElement8.Text = "<html> Reply <br>All"
			Me.radButtonElement8.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radButtonElement8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement9
			' 
			Me.radButtonElement9.AccessibleDescription = "<html>Forward<br /></html>"
			Me.radButtonElement9.AccessibleName = "<html>Forward<br /></html>"
			Me.radButtonElement9.Class = "RibbonBarButtonElement"
			Me.radButtonElement9.Image = My.Resources.splitcon_firstlook_mail_replay
			Me.radButtonElement9.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButtonElement9.Name = "radButtonElement9"
			Me.radButtonElement9.Text = "<html>Forward<br /></html>"
			Me.radButtonElement9.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radButtonElement9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup12
			' 
			Me.radRibbonBarGroup12.AccessibleDescription = "Find"
			Me.radRibbonBarGroup12.AccessibleName = "Find"
			Me.radRibbonBarGroup12.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radComboBoxElement1, Me.radButtonElement4, Me.radDropDownButtonElement9})
			Me.radRibbonBarGroup12.Name = "radRibbonBarGroup12"
			Me.radRibbonBarGroup12.Orientation = System.Windows.Forms.Orientation.Vertical
			Me.radRibbonBarGroup12.Text = "Find"
			Me.radRibbonBarGroup12.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radComboBoxElement1
			' 
			Me.radComboBoxElement1.AccessibleDescription = "Find a Contact"
			Me.radComboBoxElement1.AccessibleName = "Find a Contact"
			Me.radComboBoxElement1.ArrowButtonMinWidth = 16
			Me.radComboBoxElement1.DefaultValue = Nothing
			Me.radComboBoxElement1.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.radComboBoxElement1.EditorElement = Me.radComboBoxElement1
			Me.radComboBoxElement1.EditorManager = Nothing
			Me.radComboBoxElement1.Focusable = True
			Me.radComboBoxElement1.FormatString = "{0}"
			Me.radComboBoxElement1.MaxValue = Nothing
			Me.radComboBoxElement1.MinSize = New System.Drawing.Size(140, 0)
			Me.radComboBoxElement1.MinValue = Nothing
			Me.radComboBoxElement1.Name = "radComboBoxElement1"
			Me.radComboBoxElement1.NullText = "Find a contact"
			Me.radComboBoxElement1.NullTextColor = System.Drawing.SystemColors.GrayText
			Me.radComboBoxElement1.NullValue = Nothing
			Me.radComboBoxElement1.OwnerOffset = 0
			Me.radComboBoxElement1.StretchVertically = False
			Me.radComboBoxElement1.Text = "Find a Contact"
			Me.radComboBoxElement1.Value = Nothing
			Me.radComboBoxElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement4
			' 
			Me.radButtonElement4.AccessibleDescription = "Address Book"
			Me.radButtonElement4.AccessibleName = "Address Book"
			Me.radButtonElement4.Class = "RibbonBarButtonElement"
			Me.radButtonElement4.Image = My.Resources.splitcon_firstlook_addressbook
			Me.radButtonElement4.Name = "radButtonElement4"
			Me.radButtonElement4.Text = "Address Book"
			Me.radButtonElement4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButtonElement4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radButtonElement4.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement9
			' 
			Me.radDropDownButtonElement9.AccessibleDescription = "Related"
			Me.radDropDownButtonElement9.AccessibleName = "Related"
			Me.radDropDownButtonElement9.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement9.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement9.ExpandArrowButton = False
			Me.radDropDownButtonElement9.Image = My.Resources.splitcon_firstlook_related
			Me.radDropDownButtonElement9.Name = "radDropDownButtonElement9"
			Me.radDropDownButtonElement9.Text = "Related"
			Me.radDropDownButtonElement9.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radDropDownButtonElement9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
			Me.radDropDownButtonElement9.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' ribbonTab1
			' 
			Me.ribbonTab1.AccessibleDescription = "Advanced"
			Me.ribbonTab1.AccessibleName = "Advanced"
			Me.ribbonTab1.Alignment = System.Drawing.ContentAlignment.BottomLeft
			' 
			' ribbonTab1.ContentPanel
			' 
			Me.ribbonTab1.ContentPanel.BackColor = System.Drawing.Color.Transparent
			Me.ribbonTab1.ContentPanel.CausesValidation = True
			Me.ribbonTab1.ContentPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ribbonTab1.ContentPanel.ForeColor = System.Drawing.SystemColors.ControlText
			Me.ribbonTab1.ContentPanel.Location = New System.Drawing.Point(0, 0)
			Me.ribbonTab1.ContentPanel.Size = New System.Drawing.Size(200, 100)
			Me.ribbonTab1.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radRibbonBarGroup10, Me.radRibbonBarGroup11, Me.radRibbonBarGroup7})
			Me.ribbonTab1.Margin = New System.Windows.Forms.Padding(4, 0, 0, 0)
			Me.ribbonTab1.Name = "ribbonTab1"
			Me.ribbonTab1.StretchHorizontally = False
			Me.ribbonTab1.Text = "Advanced"
			Me.ribbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radRibbonBarGroup10
			' 
			Me.radRibbonBarGroup10.AccessibleDescription = "Actions"
			Me.radRibbonBarGroup10.AccessibleName = "Actions"
			Me.radRibbonBarGroup10.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radDropDownButtonElement3, Me.radDropDownButtonElement5, Me.radDropDownButtonElement6})
			Me.radRibbonBarGroup10.Name = "radRibbonBarGroup10"
			Me.radRibbonBarGroup10.Text = "Actions"
			Me.radRibbonBarGroup10.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement3
			' 
			Me.radDropDownButtonElement3.AccessibleDescription = "Move"
			Me.radDropDownButtonElement3.AccessibleName = "Move"
			Me.radDropDownButtonElement3.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement3.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			Me.radDropDownButtonElement3.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement3.ExpandArrowButton = False
			Me.radDropDownButtonElement3.Image = My.Resources.splitcon_firstlook_move_big
			Me.radDropDownButtonElement3.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radDropDownButtonElement3.Name = "radDropDownButtonElement3"
			Me.radDropDownButtonElement3.Text = "Move"
			Me.radDropDownButtonElement3.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radDropDownButtonElement3.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.radDropDownButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radDropDownButtonElement3.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ExpandArrow = False
			CType(Me.radDropDownButtonElement3.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			CType(Me.radDropDownButtonElement3.GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadArrowButtonElement).MinSize = New System.Drawing.Size(12, 12)
			CType(Me.radDropDownButtonElement3.GetChildAt(1).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftWidth = 0F
			' 
			' radDropDownButtonElement5
			' 
			Me.radDropDownButtonElement5.AccessibleDescription = "Rules"
			Me.radDropDownButtonElement5.AccessibleName = "Rules"
			Me.radDropDownButtonElement5.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement5.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			Me.radDropDownButtonElement5.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement5.ExpandArrowButton = False
			Me.radDropDownButtonElement5.Image = My.Resources.splitcon_firstlook_rules_big
			Me.radDropDownButtonElement5.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radDropDownButtonElement5.Name = "radDropDownButtonElement5"
			Me.radDropDownButtonElement5.Text = "Rules"
			Me.radDropDownButtonElement5.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radDropDownButtonElement5.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.radDropDownButtonElement5.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radDropDownButtonElement5.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ExpandArrow = False
			CType(Me.radDropDownButtonElement5.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			CType(Me.radDropDownButtonElement5.GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadArrowButtonElement).MinSize = New System.Drawing.Size(12, 12)
			CType(Me.radDropDownButtonElement5.GetChildAt(1).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftWidth = 0F
			' 
			' radDropDownButtonElement6
			' 
			Me.radDropDownButtonElement6.AccessibleDescription = "<html>More <br>Actions"
			Me.radDropDownButtonElement6.AccessibleName = "<html>More <br>Actions"
			Me.radDropDownButtonElement6.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement6.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			Me.radDropDownButtonElement6.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement6.ExpandArrowButton = False
			Me.radDropDownButtonElement6.Image = My.Resources.splitcon_firstlook_moreactions_big
			Me.radDropDownButtonElement6.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radDropDownButtonElement6.Name = "radDropDownButtonElement6"
			Me.radDropDownButtonElement6.Text = "<html>More <br>Actions"
			Me.radDropDownButtonElement6.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radDropDownButtonElement6.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.radDropDownButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radDropDownButtonElement6.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ExpandArrow = False
			CType(Me.radDropDownButtonElement6.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			CType(Me.radDropDownButtonElement6.GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadArrowButtonElement).MinSize = New System.Drawing.Size(12, 12)
			CType(Me.radDropDownButtonElement6.GetChildAt(1).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftWidth = 0F
			' 
			' radRibbonBarGroup11
			' 
			Me.radRibbonBarGroup11.AccessibleDescription = "Tags"
			Me.radRibbonBarGroup11.AccessibleName = "Tags"
			Me.radRibbonBarGroup11.Items.AddRange(New Telerik.WinControls.RadItem() { Me.radButtonElement3, Me.radDropDownButtonElement7, Me.radDropDownButtonElement8})
			Me.radRibbonBarGroup11.Name = "radRibbonBarGroup11"
			Me.radRibbonBarGroup11.Text = "Tags"
			Me.radRibbonBarGroup11.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radButtonElement3
			' 
			Me.radButtonElement3.AccessibleDescription = "<html>Unread/<br>Read"
			Me.radButtonElement3.AccessibleName = "<html>Unread/<br>Read"
			Me.radButtonElement3.Class = "RibbonBarButtonElement"
			Me.radButtonElement3.Image = My.Resources.splitcon_firstlook_readunread_big
			Me.radButtonElement3.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radButtonElement3.Name = "radButtonElement3"
			Me.radButtonElement3.Text = "<html>Unread/<br>Read"
			Me.radButtonElement3.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radButtonElement3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radButtonElement3.Visibility = Telerik.WinControls.ElementVisibility.Visible
			' 
			' radDropDownButtonElement7
			' 
			Me.radDropDownButtonElement7.AccessibleDescription = "Categorize"
			Me.radDropDownButtonElement7.AccessibleName = "Categorize"
			Me.radDropDownButtonElement7.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement7.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			Me.radDropDownButtonElement7.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement7.ExpandArrowButton = False
			Me.radDropDownButtonElement7.Image = My.Resources.splitcon_firstlook_categorize_big
			Me.radDropDownButtonElement7.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radDropDownButtonElement7.Name = "radDropDownButtonElement7"
			Me.radDropDownButtonElement7.Text = "Categorize"
			Me.radDropDownButtonElement7.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radDropDownButtonElement7.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			Me.radDropDownButtonElement7.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radDropDownButtonElement7.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ExpandArrow = False
			CType(Me.radDropDownButtonElement7.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			CType(Me.radDropDownButtonElement7.GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadArrowButtonElement).MinSize = New System.Drawing.Size(12, 12)
			CType(Me.radDropDownButtonElement7.GetChildAt(1).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftWidth = 0F
			' 
			' radDropDownButtonElement8
			' 
			Me.radDropDownButtonElement8.AccessibleDescription = "<html> Follow <br>Up"
			Me.radDropDownButtonElement8.AccessibleName = "<html> Follow <br>Up"
			Me.radDropDownButtonElement8.ArrowButtonMinSize = New System.Drawing.Size(12, 12)
			Me.radDropDownButtonElement8.ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			Me.radDropDownButtonElement8.DropDownDirection = Telerik.WinControls.UI.RadDirection.Down
			Me.radDropDownButtonElement8.ExpandArrowButton = False
			Me.radDropDownButtonElement8.Image = My.Resources.splitcon_firstlook_flag
			Me.radDropDownButtonElement8.ImageAlignment = System.Drawing.ContentAlignment.TopCenter
			Me.radDropDownButtonElement8.Name = "radDropDownButtonElement8"
			Me.radDropDownButtonElement8.Text = "<html> Follow <br>Up"
			Me.radDropDownButtonElement8.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
			Me.radDropDownButtonElement8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
			Me.radDropDownButtonElement8.Visibility = Telerik.WinControls.ElementVisibility.Visible
			CType(Me.radDropDownButtonElement8.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ExpandArrow = False
			CType(Me.radDropDownButtonElement8.GetChildAt(1), Telerik.WinControls.UI.DropDownEditorLayoutPanel).ArrowPosition = Telerik.WinControls.UI.DropDownButtonArrowPosition.Bottom
			CType(Me.radDropDownButtonElement8.GetChildAt(1).GetChildAt(0), Telerik.WinControls.UI.RadArrowButtonElement).MinSize = New System.Drawing.Size(12, 12)
			CType(Me.radDropDownButtonElement8.GetChildAt(1).GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).LeftWidth = 0F
			' 
			' radButtonElement6
			' 
			Me.radButtonElement6.AccessibleDescription = "Send / Receive"
			Me.radButtonElement6.AccessibleName = "Send / Receive"
			Me.radButtonElement6.Class = "RibbonBarButtonElement"
			Me.radButtonElement6.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement6.MaxSize = New System.Drawing.Size(0, 18)
			Me.radButtonElement6.MinSize = New System.Drawing.Size(16, 0)
			Me.radButtonElement6.Name = "radButtonElement6"
			Me.radButtonElement6.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
			Me.radButtonElement6.Text = "Send / Receive"
			Me.radButtonElement6.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radButtonElement6.ZIndex = 3
			' 
			' radButtonElement11
			' 
			Me.radButtonElement11.AccessibleDescription = "Undo"
			Me.radButtonElement11.AccessibleName = "Undo"
			Me.radButtonElement11.Class = "RibbonBarButtonElement"
			Me.radButtonElement11.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement11.MaxSize = New System.Drawing.Size(0, 18)
			Me.radButtonElement11.MinSize = New System.Drawing.Size(16, 0)
			Me.radButtonElement11.Name = "radButtonElement11"
			Me.radButtonElement11.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
			Me.radButtonElement11.Text = "Undo"
			Me.radButtonElement11.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radButtonElement11.ZIndex = 2
			' 
			' radButtonElement12
			' 
			Me.radButtonElement12.AccessibleDescription = "Redo"
			Me.radButtonElement12.AccessibleName = "Redo"
			Me.radButtonElement12.Class = "RibbonBarButtonElement"
			Me.radButtonElement12.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButtonElement12.MaxSize = New System.Drawing.Size(0, 18)
			Me.radButtonElement12.MinSize = New System.Drawing.Size(16, 0)
			Me.radButtonElement12.Name = "radButtonElement12"
			Me.radButtonElement12.Padding = New System.Windows.Forms.Padding(2, 1, 2, 2)
			Me.radButtonElement12.Text = "Redo"
			Me.radButtonElement12.Visibility = Telerik.WinControls.ElementVisibility.Visible
			Me.radButtonElement12.ZIndex = 1
			' 
			' radRibbonFormBehavior1
			' 
			Me.radRibbonFormBehavior1.Form = Me
			' 
			' radPanel1
			' 
			Me.radPanel1.Controls.Add(Me.radSplitContainer1_Renamed)
			Me.radPanel1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPanel1.Location = New System.Drawing.Point(0, 160)
			Me.radPanel1.Name = "radPanel1"
			Me.radPanel1.Padding = New System.Windows.Forms.Padding(1)
			' 
			' 
			' 
			Me.radPanel1.RootElement.Padding = New System.Windows.Forms.Padding(1)
			Me.radPanel1.Size = New System.Drawing.Size(1292, 780)
			Me.radPanel1.TabIndex = 2
			Me.radPanel1.Text = "radPanel1"
			' 
			' carsTableAdapter
			' 
			Me.carsTableAdapter.ClearBeforeFill = True
			' 
			' errorProvider1
			' 
			Me.errorProvider1.ContainerControl = Me
			' 
			' radPanelBar1
			' 
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage1)
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage2)
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage3)
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage4)
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage5)
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage6)
			Me.radPanelBar1.Controls.Add(Me.radPageViewPage7)
			Me.radPanelBar1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.radPanelBar1.Location = New System.Drawing.Point(1, 1)
			Me.radPanelBar1.Name = "radPanelBar1"
			Me.radPanelBar1.SelectedPage = Me.radPageViewPage1
			Me.radPanelBar1.Size = New System.Drawing.Size(198, 776)
			Me.radPanelBar1.TabIndex = 2
			Me.radPanelBar1.Text = "radPanelBar1"
			Me.radPanelBar1.ViewMode = Telerik.WinControls.UI.PageViewMode.Outlook
			' 
			' radPageViewPage1
			' 
			Me.radPageViewPage1.Controls.Add(Me.radTreeView1)
			Me.radPageViewPage1.Location = New System.Drawing.Point(5, 31)
			Me.radPageViewPage1.Name = "radPageViewPage1"
			Me.radPageViewPage1.Size = New System.Drawing.Size(188, 479)
			Me.radPageViewPage1.Text = "Mail"
			' 
			' radPageViewPage2
			' 
			Me.radPageViewPage2.Location = New System.Drawing.Point(0, 0)
			Me.radPageViewPage2.Name = "radPageViewPage2"
			Me.radPageViewPage2.Size = New System.Drawing.Size(198, 154)
			Me.radPageViewPage2.Text = "Calendar"
			' 
			' radPageViewPage3
			' 
			Me.radPageViewPage3.Location = New System.Drawing.Point(0, 0)
			Me.radPageViewPage3.Name = "radPageViewPage3"
			Me.radPageViewPage3.Size = New System.Drawing.Size(200, 100)
			Me.radPageViewPage3.Text = "Contacts"
			' 
			' radPageViewPage4
			' 
			Me.radPageViewPage4.Location = New System.Drawing.Point(0, 0)
			Me.radPageViewPage4.Name = "radPageViewPage4"
			Me.radPageViewPage4.Size = New System.Drawing.Size(200, 100)
			Me.radPageViewPage4.Text = "Tasks"
			' 
			' radPageViewPage5
			' 
			Me.radPageViewPage5.Location = New System.Drawing.Point(0, 0)
			Me.radPageViewPage5.Name = "radPageViewPage5"
			Me.radPageViewPage5.Size = New System.Drawing.Size(200, 100)
			Me.radPageViewPage5.Text = "Notes"
			' 
			' radPageViewPage6
			' 
			Me.radPageViewPage6.Location = New System.Drawing.Point(0, 0)
			Me.radPageViewPage6.Name = "radPageViewPage6"
			Me.radPageViewPage6.Size = New System.Drawing.Size(200, 100)
			Me.radPageViewPage6.Text = "Folder List"
			' 
			' radPageViewPage7
			' 
			Me.radPageViewPage7.Location = New System.Drawing.Point(0, 0)
			Me.radPageViewPage7.Name = "radPageViewPage7"
			Me.radPageViewPage7.Size = New System.Drawing.Size(200, 100)
			Me.radPageViewPage7.Text = "Shortcuts"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(190))))), (CInt(Fix((CByte(218))))), (CInt(Fix((CByte(254))))))
			Me.ClientSize = New System.Drawing.Size(1292, 940)
			Me.Controls.Add(Me.radPanel1)
			Me.Controls.Add(Me.radRibbonBar1)
			Me.FormBehavior = Me.radRibbonFormBehavior1
			Me.Icon = (CType(resources.GetObject("$this.Icon"), System.Drawing.Icon))
			Me.Name = "Form1"
			' 
			' 
			' 
			Me.RootElement.ApplyShapeToControl = True
			Me.Text = "RadSplitContainer"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.radSplitContainer1_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer1_Renamed.ResumeLayout(False)
			CType(Me.splitPanel1_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel1_Renamed.ResumeLayout(False)
			Me.splitPanel1_Renamed.PerformLayout()
			CType(Me.radTreeView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitPanel2_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel2_Renamed.ResumeLayout(False)
			Me.splitPanel2_Renamed.PerformLayout()
			CType(Me.radGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox2.ResumeLayout(False)
			CType(Me.radGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.carsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.northwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitPanel3_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel3_Renamed.ResumeLayout(False)
			CType(Me.radPanel2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel2.ResumeLayout(False)
			CType(Me.radSplitContainer2_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radSplitContainer2_Renamed.ResumeLayout(False)
			CType(Me.splitPanel4_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel4_Renamed.ResumeLayout(False)
			Me.splitPanel4_Renamed.PerformLayout()
			CType(Me.radLabel3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.splitPanel5_Renamed, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitPanel5_Renamed.ResumeLayout(False)
			CType(Me.radGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radGroupBox1.ResumeLayout(False)
			Me.radGroupBox1.PerformLayout()
			CType(Me.radGridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radCalendar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radComboBoxElement1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanel1.ResumeLayout(False)
			CType(Me.errorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelBar1.ResumeLayout(False)
			Me.radPageViewPage1.ResumeLayout(False)
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private radSplitContainer1_Renamed As Telerik.WinControls.UI.RadSplitContainer
		Private splitPanel1_Renamed As Telerik.WinControls.UI.SplitPanel
		Private splitPanel2_Renamed As Telerik.WinControls.UI.SplitPanel
		Private splitPanel3_Renamed As Telerik.WinControls.UI.SplitPanel
		Private radSplitContainer2_Renamed As Telerik.WinControls.UI.RadSplitContainer
		Private splitPanel4_Renamed As Telerik.WinControls.UI.SplitPanel
		Private radRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
		Private ribbonTab1 As Telerik.WinControls.UI.RibbonTab
		Private radRibbonFormBehavior1 As Telerik.WinControls.UI.RadRibbonFormBehavior
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radLabel1 As Telerik.WinControls.UI.RadLabel
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
		Private radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private radGridView1 As Telerik.WinControls.UI.RadGridView
		Private radCalendar1 As Telerik.WinControls.UI.RadCalendar
		Private northwindDataSet As Telerik.Examples.WinControls.DataSources.NorthwindDataSet
		Private carsBindingSource As System.Windows.Forms.BindingSource
		Private carsTableAdapter As Telerik.Examples.WinControls.DataSources.NorthwindDataSetTableAdapters.CarsTableAdapter
		Private webBrowser1 As System.Windows.Forms.WebBrowser
		Private ribbonTab2 As Telerik.WinControls.UI.RibbonTab
		Private radRibbonBarGroup4 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private splitPanel5_Renamed As Telerik.WinControls.UI.SplitPanel
		Private radGroupBox1 As Telerik.WinControls.UI.RadGroupBox
		Private radGridView2 As Telerik.WinControls.UI.RadGridView
		Private radGroupBox2 As Telerik.WinControls.UI.RadGroupBox
		Private radRibbonBarGroup6 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radRibbonBarGroup5 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radRibbonBarButtonGroup5 As Telerik.WinControls.UI.RadRibbonBarButtonGroup
		Private radButtonElement5 As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarGroup7 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radButtonElement7 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement8 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement9 As Telerik.WinControls.UI.RadButtonElement
		Private radRibbonBarGroup10 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radRibbonBarGroup11 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radRibbonBarGroup12 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private radButtonElement1 As Telerik.WinControls.UI.RadButtonElement
		Private radDropDownButtonElement1 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radDropDownButtonElement2 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radButtonElement2 As Telerik.WinControls.UI.RadButtonElement
		Private radDropDownButtonElement4 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radDropDownButtonElement3 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radDropDownButtonElement5 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radDropDownButtonElement6 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radButtonElement3 As Telerik.WinControls.UI.RadButtonElement
		Private radDropDownButtonElement7 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radDropDownButtonElement8 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radComboBoxElement1 As Telerik.WinControls.UI.RadDropDownListElement
		Private radButtonElement4 As Telerik.WinControls.UI.RadButtonElement
		Private radDropDownButtonElement9 As Telerik.WinControls.UI.RadDropDownButtonElement
		Private radButtonElement6 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement11 As Telerik.WinControls.UI.RadButtonElement
		Private radButtonElement12 As Telerik.WinControls.UI.RadButtonElement
		Private imageList1 As System.Windows.Forms.ImageList
		Private errorProvider1 As System.Windows.Forms.ErrorProvider
		Private radGalleryElement1 As Telerik.WinControls.UI.RadGalleryElement
		Private radGalleryItem1 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem2 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem3 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem4 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem5 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem6 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem7 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem8 As Telerik.WinControls.UI.RadGalleryItem
		Private radGalleryItem9 As Telerik.WinControls.UI.RadGalleryItem
		Private radRibbonBarGroup8 As Telerik.WinControls.UI.RadRibbonBarGroup
		Private WithEvents btnOpenDesigner As Telerik.WinControls.UI.RadButtonElement
		Private radPanel2 As Telerik.WinControls.UI.RadPanel
		Private gridViewDateTimeColumn1 As Telerik.WinControls.UI.GridViewDateTimeColumn
		Private gridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn
		Private gridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn
		Private radPanelBar1 As Telerik.WinControls.UI.RadPageView
		Private radPageViewPage1 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage2 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage3 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage4 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage5 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage6 As Telerik.WinControls.UI.RadPageViewPage
		Private radPageViewPage7 As Telerik.WinControls.UI.RadPageViewPage


	End Class
End Namespace
