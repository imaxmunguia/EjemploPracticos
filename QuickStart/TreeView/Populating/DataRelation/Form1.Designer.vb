Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.TreeView.Populating.DataRelation
	Public Partial Class Form1
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.artistsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.musicCollectionDataSet = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet()
		Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.songsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.artistsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter()
		Me.albumsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter()
		Me.songsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter()
		Me.radListLevelOne = New Telerik.WinControls.UI.RadListControl()
		Me.radListLevelTwo = New Telerik.WinControls.UI.RadListControl()
		Me.radListLevelThree = New Telerik.WinControls.UI.RadListControl()
		Me.radGroupLevelThree = New Telerik.WinControls.UI.RadGroupBox()
		Me.radGroupLevelTwo = New Telerik.WinControls.UI.RadGroupBox()
		Me.radGroupLevelOne = New Telerik.WinControls.UI.RadGroupBox()
		Me.radTreeView1 = New Telerik.WinControls.UI.RadTreeView()
		Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
		Me.radLabel3 = New Telerik.WinControls.UI.RadLabel()
		CType(Me.settingsPanel,System.ComponentModel.ISupportInitialize).BeginInit
		Me.settingsPanel.SuspendLayout
		CType(Me.artistsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.musicCollectionDataSet,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.albumsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.songsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radListLevelOne,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radListLevelTwo,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radListLevelThree,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radGroupLevelThree,System.ComponentModel.ISupportInitialize).BeginInit
		Me.radGroupLevelThree.SuspendLayout
		CType(Me.radGroupLevelTwo,System.ComponentModel.ISupportInitialize).BeginInit
		Me.radGroupLevelTwo.SuspendLayout
		CType(Me.radGroupLevelOne,System.ComponentModel.ISupportInitialize).BeginInit
		Me.radGroupLevelOne.SuspendLayout
		CType(Me.radTreeView1,System.ComponentModel.ISupportInitialize).BeginInit
		CType(Me.radPanel1,System.ComponentModel.ISupportInitialize).BeginInit
		Me.radPanel1.SuspendLayout
		CType(Me.radLabel3,System.ComponentModel.ISupportInitialize).BeginInit
		Me.SuspendLayout
		'
		'settingsPanel
		'
		Me.settingsPanel.Controls.Add(Me.radGroupLevelOne)
		Me.settingsPanel.Controls.Add(Me.radGroupLevelTwo)
		Me.settingsPanel.Controls.Add(Me.radGroupLevelThree)
		Me.settingsPanel.ForeColor = System.Drawing.Color.Black
		Me.settingsPanel.Location = New System.Drawing.Point(1111, 1)
		Me.settingsPanel.Size = New System.Drawing.Size(0, 443)
		Me.settingsPanel.ThemeName = "ControlDefault"
		Me.settingsPanel.Controls.SetChildIndex(Me.radGroupLevelThree, 0)
		Me.settingsPanel.Controls.SetChildIndex(Me.radGroupLevelTwo, 0)
		Me.settingsPanel.Controls.SetChildIndex(Me.radGroupLevelOne, 0)
		'
		'artistsBindingSource
		'
		Me.artistsBindingSource.DataMember = "Artists"
		Me.artistsBindingSource.DataSource = Me.musicCollectionDataSet
		'
		'musicCollectionDataSet
		'
		Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
		Me.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'albumsBindingSource
		'
		Me.albumsBindingSource.DataMember = "Albums"
		Me.albumsBindingSource.DataSource = Me.musicCollectionDataSet
		'
		'songsBindingSource
		'
		Me.songsBindingSource.DataMember = "Songs"
		Me.songsBindingSource.DataSource = Me.musicCollectionDataSet
		'
		'artistsTableAdapter
		'
		Me.artistsTableAdapter.ClearBeforeFill = true
		'
		'albumsTableAdapter
		'
		Me.albumsTableAdapter.ClearBeforeFill = true
		'
		'songsTableAdapter
		'
		Me.songsTableAdapter.ClearBeforeFill = true
		'
		'radListLevelOne
		'
		Me.radListLevelOne.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.radListLevelOne.CaseSensitiveSort = true
		Me.radListLevelOne.DataSource = Me.artistsBindingSource
		Me.radListLevelOne.DescriptionTextMember = Nothing
		Me.radListLevelOne.DisplayMember = "ArtistName"
		Me.radListLevelOne.ForeColor = System.Drawing.Color.Black
		Me.radListLevelOne.ItemHeight = 18
		Me.radListLevelOne.Location = New System.Drawing.Point(6, 20)
		Me.radListLevelOne.Name = "radListLevelOne"
		Me.radListLevelOne.Size = New System.Drawing.Size(168, 85)
		Me.radListLevelOne.TabIndex = 7
		'
		'radListLevelTwo
		'
		Me.radListLevelTwo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.radListLevelTwo.CaseSensitiveSort = true
		Me.radListLevelTwo.DataSource = Me.albumsBindingSource
		Me.radListLevelTwo.DescriptionTextMember = Nothing
		Me.radListLevelTwo.DisplayMember = "AlbumName"
		Me.radListLevelTwo.ForeColor = System.Drawing.Color.Black
		Me.radListLevelTwo.ItemHeight = 18
		Me.radListLevelTwo.Location = New System.Drawing.Point(6, 20)
		Me.radListLevelTwo.Name = "radListLevelTwo"
		Me.radListLevelTwo.Size = New System.Drawing.Size(168, 85)
		Me.radListLevelTwo.TabIndex = 7
		'
		'radListLevelThree
		'
		Me.radListLevelThree.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.radListLevelThree.CaseSensitiveSort = true
		Me.radListLevelThree.DataSource = Me.songsBindingSource
		Me.radListLevelThree.DescriptionTextMember = Nothing
		Me.radListLevelThree.DisplayMember = "SongName"
		Me.radListLevelThree.ForeColor = System.Drawing.Color.Black
		Me.radListLevelThree.ItemHeight = 18
		Me.radListLevelThree.Location = New System.Drawing.Point(6, 22)
		Me.radListLevelThree.Name = "radListLevelThree"
		Me.radListLevelThree.Size = New System.Drawing.Size(168, 187)
		Me.radListLevelThree.TabIndex = 7
		'
		'radGroupLevelThree
		'
		Me.radGroupLevelThree.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
		Me.radGroupLevelThree.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.radGroupLevelThree.Controls.Add(Me.radListLevelThree)
		Me.radGroupLevelThree.FooterImageIndex = -1
		Me.radGroupLevelThree.FooterImageKey = ""
		Me.radGroupLevelThree.ForeColor = System.Drawing.Color.Black
		Me.radGroupLevelThree.HeaderImageIndex = -1
		Me.radGroupLevelThree.HeaderImageKey = ""
		Me.radGroupLevelThree.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.radGroupLevelThree.HeaderText = " Third Level Items "
		Me.radGroupLevelThree.Location = New System.Drawing.Point(-81, 265)
		Me.radGroupLevelThree.Name = "radGroupLevelThree"
		Me.radGroupLevelThree.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
		'
		'
		'
		Me.radGroupLevelThree.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
		Me.radGroupLevelThree.Size = New System.Drawing.Size(180, 218)
		Me.radGroupLevelThree.TabIndex = 8
		Me.radGroupLevelThree.Text = " Third Level Items "
		'
		'radGroupLevelTwo
		'
		Me.radGroupLevelTwo.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
		Me.radGroupLevelTwo.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.radGroupLevelTwo.Controls.Add(Me.radListLevelTwo)
		Me.radGroupLevelTwo.FooterImageIndex = -1
		Me.radGroupLevelTwo.FooterImageKey = ""
		Me.radGroupLevelTwo.ForeColor = System.Drawing.Color.Black
		Me.radGroupLevelTwo.HeaderImageIndex = -1
		Me.radGroupLevelTwo.HeaderImageKey = ""
		Me.radGroupLevelTwo.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.radGroupLevelTwo.HeaderText = " Second Level Items "
		Me.radGroupLevelTwo.Location = New System.Drawing.Point(-81, 138)
		Me.radGroupLevelTwo.Name = "radGroupLevelTwo"
		Me.radGroupLevelTwo.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
		'
		'
		'
		Me.radGroupLevelTwo.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
		Me.radGroupLevelTwo.Size = New System.Drawing.Size(180, 116)
		Me.radGroupLevelTwo.TabIndex = 8
		Me.radGroupLevelTwo.Text = " Second Level Items "
		'
		'radGroupLevelOne
		'
		Me.radGroupLevelOne.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
		Me.radGroupLevelOne.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.radGroupLevelOne.Controls.Add(Me.radListLevelOne)
		Me.radGroupLevelOne.FooterImageIndex = -1
		Me.radGroupLevelOne.FooterImageKey = ""
		Me.radGroupLevelOne.ForeColor = System.Drawing.Color.Black
		Me.radGroupLevelOne.HeaderImageIndex = -1
		Me.radGroupLevelOne.HeaderImageKey = ""
		Me.radGroupLevelOne.HeaderMargin = New System.Windows.Forms.Padding(10, 0, 0, 0)
		Me.radGroupLevelOne.HeaderText = " First Level Items "
		Me.radGroupLevelOne.Location = New System.Drawing.Point(-81, 6)
		Me.radGroupLevelOne.Name = "radGroupLevelOne"
		Me.radGroupLevelOne.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
		'
		'
		'
		Me.radGroupLevelOne.RootElement.Padding = New System.Windows.Forms.Padding(10, 20, 10, 10)
		Me.radGroupLevelOne.Size = New System.Drawing.Size(180, 116)
		Me.radGroupLevelOne.TabIndex = 8
		Me.radGroupLevelOne.Text = " First Level Items "
		'
		'radTreeView1
		'
		Me.radTreeView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.radTreeView1.ImageIndex = 0
		Me.radTreeView1.ImageList = Me.imageList1
		Me.radTreeView1.Location = New System.Drawing.Point(6, 38)
		Me.radTreeView1.Name = "radTreeView1"
		Me.radTreeView1.Size = New System.Drawing.Size(64, 336)
		Me.radTreeView1.SpacingBetweenNodes = -1
		Me.radTreeView1.TabIndex = 1
		Me.radTreeView1.Text = "radTreeView1"
		'
		'imageList1
		'
		Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"),System.Windows.Forms.ImageListStreamer)
		Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
		Me.imageList1.Images.SetKeyName(0, "user_orange.png")
		Me.imageList1.Images.SetKeyName(1, "cd_16.png")
		Me.imageList1.Images.SetKeyName(2, "music_16.png")
		'
		'radPanel1
		'
		Me.radPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
		Me.radPanel1.BackColor = System.Drawing.Color.Transparent
		Me.radPanel1.Controls.Add(Me.radLabel3)
		Me.radPanel1.Location = New System.Drawing.Point(6, 8)
		Me.radPanel1.Name = "radPanel1"
		Me.radPanel1.Size = New System.Drawing.Size(368, 30)
		Me.radPanel1.TabIndex = 1
		CType(Me.radPanel1.GetChildAt(0).GetChildAt(0),Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154,Byte),Integer), CType(CType(195,Byte),Integer), CType(CType(255,Byte),Integer))
		CType(Me.radPanel1.GetChildAt(0).GetChildAt(0),Telerik.WinControls.Primitives.FillPrimitive).NumberOfColors = 2
		CType(Me.radPanel1.GetChildAt(0).GetChildAt(0),Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.FromArgb(CType(CType(200,Byte),Integer), CType(CType(224,Byte),Integer), CType(CType(255,Byte),Integer))
		CType(Me.radPanel1.GetChildAt(0).GetChildAt(1),Telerik.WinControls.Primitives.BorderPrimitive).ForeColor = System.Drawing.Color.FromArgb(CType(CType(138,Byte),Integer), CType(CType(176,Byte),Integer), CType(CType(233,Byte),Integer))
		'
		'radLabel3
		'
		Me.radLabel3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204,Byte))
		Me.radLabel3.Location = New System.Drawing.Point(8, 2)
		Me.radLabel3.Name = "radLabel3"
		Me.radLabel3.Size = New System.Drawing.Size(120, 24)
		Me.radLabel3.TabIndex = 0
		Me.radLabel3.Text = "Music Collection"
		'
		'Form1
		'
		Me.Controls.Add(Me.radTreeView1)
		Me.Name = "Form1"
		Me.Size = New System.Drawing.Size(1008, 445)
		Me.Controls.SetChildIndex(Me.radTreeView1, 0)
		Me.Controls.SetChildIndex(Me.settingsPanel, 0)
		CType(Me.settingsPanel,System.ComponentModel.ISupportInitialize).EndInit
		Me.settingsPanel.ResumeLayout(false)
		CType(Me.artistsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.musicCollectionDataSet,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.albumsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.songsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radListLevelOne,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radListLevelTwo,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radListLevelThree,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radGroupLevelThree,System.ComponentModel.ISupportInitialize).EndInit
		Me.radGroupLevelThree.ResumeLayout(false)
		CType(Me.radGroupLevelTwo,System.ComponentModel.ISupportInitialize).EndInit
		Me.radGroupLevelTwo.ResumeLayout(false)
		CType(Me.radGroupLevelOne,System.ComponentModel.ISupportInitialize).EndInit
		Me.radGroupLevelOne.ResumeLayout(false)
		CType(Me.radTreeView1,System.ComponentModel.ISupportInitialize).EndInit
		CType(Me.radPanel1,System.ComponentModel.ISupportInitialize).EndInit
		Me.radPanel1.ResumeLayout(false)
		Me.radPanel1.PerformLayout
		CType(Me.radLabel3,System.ComponentModel.ISupportInitialize).EndInit
		Me.ResumeLayout(false)

End Sub

		#End Region

		Private artistsBindingSource As System.Windows.Forms.BindingSource
		Private musicCollectionDataSet As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet
		Private artistsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter
		Private albumsBindingSource As System.Windows.Forms.BindingSource
		Private songsBindingSource As System.Windows.Forms.BindingSource
		Private albumsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
		Private songsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter
		Private radListLevelOne As Telerik.WinControls.UI.RadListControl
		Private radListLevelTwo As Telerik.WinControls.UI.RadListControl
		Private radListLevelThree As Telerik.WinControls.UI.RadListControl
		Private radGroupLevelThree As Telerik.WinControls.UI.RadGroupBox
		Private radGroupLevelTwo As Telerik.WinControls.UI.RadGroupBox
		Private radGroupLevelOne As Telerik.WinControls.UI.RadGroupBox
		Private WithEvents radTreeView1 As Telerik.WinControls.UI.RadTreeView
		Private imageList1 As System.Windows.Forms.ImageList
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private radLabel3 As Telerik.WinControls.UI.RadLabel
	End Class
End Namespace
