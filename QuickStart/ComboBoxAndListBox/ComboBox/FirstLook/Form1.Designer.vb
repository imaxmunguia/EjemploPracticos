Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.ComboBoxAndListBox.ComboBox.FirstLook
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Dim themeSource2 As New Telerik.WinControls.ThemeSource()
			Me.cmbArtist = New Telerik.WinControls.UI.RadDropDownList()
			Me.artistsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.musicCollectionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.musicCollectionDataSet = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet()
			Me.ArtistsImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.cmbAlbum = New Telerik.WinControls.UI.RadDropDownList()
			Me.artistsAlbumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.cmbSong = New Telerik.WinControls.UI.RadDropDownList()
			Me.albumsSongsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.lblSelectedSong = New Telerik.WinControls.UI.RadLabel()
			Me.artistsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter()
			Me.albumsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter()
			Me.songsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter()
			Me.pictureBox = New System.Windows.Forms.PictureBox()
			Me.ArtistsLargeImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.buttonSortAscending = New Telerik.WinControls.UI.RadButton()
			Me.buttonSortDescending = New Telerik.WinControls.UI.RadButton()
			Me.radOffice2007ScreenTip1 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			Me.radPanelDemoHolder = New Telerik.WinControls.UI.RadPanel()
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbArtist, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.musicCollectionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbAlbum, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.artistsAlbumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbSong, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.albumsSongsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblSelectedSong, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonSortAscending, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.buttonSortDescending, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.radPanelDemoHolder.SuspendLayout()
			Me.SuspendLayout()
			' 
			' settingsPanel
			' 
			Me.settingsPanel.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Location = New System.Drawing.Point(646, 1)
			' 
			' 
			' 
			Me.settingsPanel.RootElement.ForeColor = System.Drawing.Color.Black
			Me.settingsPanel.Size = New System.Drawing.Size(200, 723)
			Me.settingsPanel.ThemeName = "ControlDefault"
			' 
			' cmbArtist
			' 
			Me.cmbArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbArtist.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.cmbArtist.DataSource = Me.artistsBindingSource
			Me.cmbArtist.DisplayMember = "ArtistName"
			Me.cmbArtist.DropDownAnimationEnabled = True
			Me.cmbArtist.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.cmbArtist.ForeColor = System.Drawing.Color.Black
			Me.cmbArtist.ImageList = Me.ArtistsImageList
			Me.cmbArtist.Location = New System.Drawing.Point(18, 103)
			Me.cmbArtist.Name = "cmbArtist"
			Me.cmbArtist.NullText = "Select Artist"
			' 
			' 
			' 
			Me.cmbArtist.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbArtist.RootElement.ForeColor = System.Drawing.Color.Black
			Me.cmbArtist.RootElement.ToolTipText = Nothing
			Me.cmbArtist.Size = New System.Drawing.Size(170, 19)
			Me.cmbArtist.TabIndex = 1
			Me.cmbArtist.TabStop = False
'			Me.cmbArtist.SelectedIndexChanged += New Telerik.WinControls.UI.Data.PositionChangedEventHandler(cmbArtist_SelectedIndexChanged);
			' 
			' artistsBindingSource
			' 
			Me.artistsBindingSource.DataMember = "Artists"
			Me.artistsBindingSource.DataSource = Me.musicCollectionDataSetBindingSource
			' 
			' musicCollectionDataSetBindingSource
			' 
			Me.musicCollectionDataSetBindingSource.DataSource = Me.musicCollectionDataSet
			Me.musicCollectionDataSetBindingSource.Position = 0
			' 
			' musicCollectionDataSet
			' 
			Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
			Me.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' ArtistsImageList
			' 
			Me.ArtistsImageList.ImageStream = (CType(resources.GetObject("ArtistsImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ArtistsImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.ArtistsImageList.Images.SetKeyName(0, "smallSting.jpg")
			Me.ArtistsImageList.Images.SetKeyName(1, "smallDepeche.jpg")
			Me.ArtistsImageList.Images.SetKeyName(2, "smallSheryl.jpg")
			Me.ArtistsImageList.Images.SetKeyName(3, "smallClapton.jpg")
			Me.ArtistsImageList.Images.SetKeyName(4, "smallFloyd.jpg")
			Me.ArtistsImageList.Images.SetKeyName(5, "smallPurple.jpg")
			Me.ArtistsImageList.Images.SetKeyName(6, "smallINXS.jpg")
			Me.ArtistsImageList.Images.SetKeyName(7, "smallBadu.jpg")
			Me.ArtistsImageList.Images.SetKeyName(8, "smallNada.jpg")
			Me.ArtistsImageList.Images.SetKeyName(9, "smallBreeders.jpg")
			Me.ArtistsImageList.Images.SetKeyName(10, "smallConchords.jpg")
			Me.ArtistsImageList.Images.SetKeyName(11, "smallLeona.jpg")
			' 
			' cmbAlbum
			' 
			Me.cmbAlbum.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.cmbAlbum.DataSource = Me.artistsAlbumsBindingSource
			Me.cmbAlbum.DisplayMember = "AlbumName"
			Me.cmbAlbum.DropDownAnimationEnabled = True
			Me.cmbAlbum.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.cmbAlbum.ForeColor = System.Drawing.Color.Black
			Me.cmbAlbum.Location = New System.Drawing.Point(239, 103)
			Me.cmbAlbum.Name = "cmbAlbum"
			Me.cmbAlbum.NullText = "Select Album"
			' 
			' 
			' 
			Me.cmbAlbum.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbAlbum.RootElement.ForeColor = System.Drawing.Color.Black
			Me.cmbAlbum.RootElement.ToolTipText = Nothing
			Me.cmbAlbum.Size = New System.Drawing.Size(149, 19)
			Me.cmbAlbum.TabIndex = 2
			Me.cmbAlbum.TabStop = False
'			Me.cmbAlbum.SelectedIndexChanged += cmbArtist_SelectedIndexChanged;
			' 
			' artistsAlbumsBindingSource
			' 
			Me.artistsAlbumsBindingSource.DataMember = "ArtistsAlbums"
			Me.artistsAlbumsBindingSource.DataSource = Me.artistsBindingSource
			' 
			' cmbSong
			' 
			Me.cmbSong.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.cmbSong.DataSource = Me.albumsSongsBindingSource
			Me.cmbSong.DisplayMember = "SongName"
			Me.cmbSong.DropDownAnimationEnabled = True
			Me.cmbSong.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.cmbSong.ForeColor = System.Drawing.Color.Black
			Me.cmbSong.Location = New System.Drawing.Point(394, 103)
			Me.cmbSong.Name = "cmbSong"
            Me.cmbSong.NullText = "Select Song"
			' 
			' 
			' 
			Me.cmbSong.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbSong.RootElement.ForeColor = System.Drawing.Color.Black
			Me.cmbSong.RootElement.ToolTipText = Nothing
			Me.cmbSong.Size = New System.Drawing.Size(160, 19)
			Me.cmbSong.TabIndex = 3
			Me.cmbSong.TabStop = False
			'this.cmbSong.TextChanged += new System.EventHandler(this.cmbSong_TextChanged);
'			Me.cmbSong.SelectedIndexChanged += cmbArtist_SelectedIndexChanged;
			' 
			' albumsSongsBindingSource
			' 
			Me.albumsSongsBindingSource.DataMember = "AlbumsSongs"
			Me.albumsSongsBindingSource.DataSource = Me.artistsAlbumsBindingSource
			' 
			' lblSelectedSong
			' 
			Me.lblSelectedSong.BackColor = System.Drawing.Color.Transparent
			Me.lblSelectedSong.Font = New System.Drawing.Font("Arial", 10F)
			Me.lblSelectedSong.ForeColor = System.Drawing.Color.SteelBlue
			Me.lblSelectedSong.Location = New System.Drawing.Point(128, 213)
			Me.lblSelectedSong.Name = "lblSelectedSong"
			' 
			' 
			' 
			Me.lblSelectedSong.RootElement.ForeColor = System.Drawing.Color.SteelBlue
			Me.lblSelectedSong.RootElement.ToolTipText = Nothing
			Me.lblSelectedSong.Size = New System.Drawing.Size(2, 2)
			Me.lblSelectedSong.TabIndex = 5
			Me.lblSelectedSong.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.lblSelectedSong.TextWrap = True
			' 
			' artistsTableAdapter
			' 
			Me.artistsTableAdapter.ClearBeforeFill = True
			' 
			' albumsTableAdapter
			' 
			Me.albumsTableAdapter.ClearBeforeFill = True
			' 
			' songsTableAdapter
			' 
			Me.songsTableAdapter.ClearBeforeFill = True
			' 
			' pictureBox
			' 
			Me.pictureBox.BackColor = System.Drawing.Color.Transparent
			Me.pictureBox.Location = New System.Drawing.Point(31, 183)
			Me.pictureBox.Name = "pictureBox"
			Me.pictureBox.Size = New System.Drawing.Size(82, 83)
			Me.pictureBox.TabIndex = 6
			Me.pictureBox.TabStop = False
			' 
			' ArtistsLargeImageList
			' 
			Me.ArtistsLargeImageList.ImageStream = (CType(resources.GetObject("ArtistsLargeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ArtistsLargeImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.ArtistsLargeImageList.Images.SetKeyName(0, "sting.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(1, "depeche.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(2, "sheryl.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(3, "clapton.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(4, "pink_floyd.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(5, "deepurple.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(6, "inxs.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(7, "badu.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(8, "nada_surf.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(9, "breeders.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(10, "concords.jpg")
			Me.ArtistsLargeImageList.Images.SetKeyName(11, "leona_lewis.jpg")
			' 
			' radThemeManager1
			' 
			themeSource2.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource2.ThemeLocation = "Telerik.Examples.WinControls.Resources.MusicCollection.xml"
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource2})
			' 
			' radPanel1
			' 
			Me.radPanel1.BackColor = System.Drawing.Color.Transparent
			Me.radPanel1.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Location = New System.Drawing.Point(472, 92)
			Me.radPanel1.Margin = New System.Windows.Forms.Padding(0)
			Me.radPanel1.Name = "radPanel1"
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Size = New System.Drawing.Size(22, 18)
			Me.radPanel1.TabIndex = 7
			Me.radPanel1.Visible = False
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButton1
			' 
			Me.buttonSortAscending.BackColor = System.Drawing.Color.Transparent
			Me.buttonSortAscending.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.buttonSortAscending.ForeColor = System.Drawing.Color.Black
			Me.buttonSortAscending.Image = (CType(resources.GetObject("radButton1.Image"), System.Drawing.Image))
			Me.buttonSortAscending.Location = New System.Drawing.Point(188, 98)
			Me.buttonSortAscending.Name = "radButton1"
			' 
			' 
			' 
			Me.buttonSortAscending.RootElement.AutoToolTip = True
			Me.buttonSortAscending.RootElement.ForeColor = System.Drawing.Color.Black
			Me.buttonSortAscending.RootElement.ToolTipText = "Sort Ascending"
			Me.buttonSortAscending.Size = New System.Drawing.Size(26, 29)
			Me.buttonSortAscending.TabIndex = 8
			Me.buttonSortAscending.Text = "radButton1"
			CType(Me.buttonSortAscending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image"), System.Drawing.Image))
			CType(Me.buttonSortAscending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			CType(Me.buttonSortAscending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "radButton1"
			CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
			CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.Transparent
			CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.buttonSortAscending.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButton2
			' 
			Me.buttonSortDescending.BackColor = System.Drawing.Color.Transparent
			Me.buttonSortDescending.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.buttonSortDescending.ForeColor = System.Drawing.Color.Black
			Me.buttonSortDescending.Image = (CType(resources.GetObject("radButton2.Image"), System.Drawing.Image))
			Me.buttonSortDescending.Location = New System.Drawing.Point(208, 98)
			Me.buttonSortDescending.Name = "radButton2"
			' 
			' 
			' 
			Me.buttonSortDescending.RootElement.AutoToolTip = True
			Me.buttonSortDescending.RootElement.ForeColor = System.Drawing.Color.Black
			Me.buttonSortDescending.RootElement.ScreenTip = Me.radOffice2007ScreenTip1.ScreenTipElement
			Me.buttonSortDescending.RootElement.ShouldPaint = True
			Me.buttonSortDescending.RootElement.ToolTipText = "Sort Descending"
			Me.buttonSortDescending.Size = New System.Drawing.Size(25, 30)
			Me.buttonSortDescending.TabIndex = 9
			Me.buttonSortDescending.Text = "radButton2"
			CType(Me.buttonSortDescending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Image = (CType(resources.GetObject("resource.Image1"), System.Drawing.Image))
			CType(Me.buttonSortDescending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			CType(Me.buttonSortDescending.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "radButton2"
			CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
			CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.Transparent
			CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.buttonSortDescending.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radOffice2007ScreenTip1
			' 
			Me.radOffice2007ScreenTip1.CaptionVisible = True
			Me.radOffice2007ScreenTip1.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip1.FooterVisible = False
			Me.radOffice2007ScreenTip1.Location = New System.Drawing.Point(0, 0)
			Me.radOffice2007ScreenTip1.Name = "radOffice2007ScreenTip1"
			' 
			' 
			' 
			Me.radOffice2007ScreenTip1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			' 
			' 
			' 
			Me.radOffice2007ScreenTip1.ScreenTipElement.Description = "Override this property and provide custom screentip template description in Desig" & "nTime."
			Me.radOffice2007ScreenTip1.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			Me.radOffice2007ScreenTip1.Size = New System.Drawing.Size(107, 43)
			Me.radOffice2007ScreenTip1.TabIndex = 0
			Me.radOffice2007ScreenTip1.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTipElement)
			CType(Me.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Sort Descending"
			' 
			' radPanelDemoHolder
			' 
			Me.radPanelDemoHolder.Anchor = System.Windows.Forms.AnchorStyles.None
			Me.radPanelDemoHolder.BackColor = System.Drawing.Color.Transparent
			Me.radPanelDemoHolder.BackgroundImage = My.Resources.ComboFirstLookBG
			Me.radPanelDemoHolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.radPanelDemoHolder.Controls.Add(Me.cmbArtist)
			Me.radPanelDemoHolder.Controls.Add(Me.buttonSortDescending)
			Me.radPanelDemoHolder.Controls.Add(Me.cmbAlbum)
			Me.radPanelDemoHolder.Controls.Add(Me.cmbSong)
			Me.radPanelDemoHolder.Controls.Add(Me.buttonSortAscending)
			Me.radPanelDemoHolder.Controls.Add(Me.radPanel1)
			Me.radPanelDemoHolder.Controls.Add(Me.lblSelectedSong)
			Me.radPanelDemoHolder.Controls.Add(Me.pictureBox)
			Me.radPanelDemoHolder.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Location = New System.Drawing.Point(136, 172)
			Me.radPanelDemoHolder.Name = "radPanelDemoHolder"
			' 
			' 
			' 
			Me.radPanelDemoHolder.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanelDemoHolder.Size = New System.Drawing.Size(575, 381)
			Me.radPanelDemoHolder.TabIndex = 10
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			CType(Me.radPanelDemoHolder.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
			' 
			' Form1
			' 
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.Controls.Add(Me.radPanelDemoHolder)
			Me.Location = New System.Drawing.Point(15, 15)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(847, 725)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			Me.Controls.SetChildIndex(Me.radPanelDemoHolder, 0)
			Me.Controls.SetChildIndex(Me.settingsPanel, 0)
			CType(Me.settingsPanel, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbArtist, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.musicCollectionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbAlbum, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.artistsAlbumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbSong, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.albumsSongsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblSelectedSong, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonSortAscending, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.buttonSortDescending, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanelDemoHolder, System.ComponentModel.ISupportInitialize).EndInit()
			Me.radPanelDemoHolder.ResumeLayout(False)
			Me.radPanelDemoHolder.PerformLayout()
			Me.ResumeLayout(False)

		End Sub



		#End Region

		Private WithEvents cmbArtist As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents cmbAlbum As Telerik.WinControls.UI.RadDropDownList
		Private WithEvents cmbSong As Telerik.WinControls.UI.RadDropDownList
		Private lblSelectedSong As Telerik.WinControls.UI.RadLabel
		Private artistsBindingSource As System.Windows.Forms.BindingSource
		Private musicCollectionDataSetBindingSource As System.Windows.Forms.BindingSource
		Private musicCollectionDataSet As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet
		Private artistsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter
		Private artistsAlbumsBindingSource As System.Windows.Forms.BindingSource
		Private albumsSongsBindingSource As System.Windows.Forms.BindingSource
		Private albumsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
		Private songsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter
		Private ArtistsImageList As System.Windows.Forms.ImageList
		Private pictureBox As System.Windows.Forms.PictureBox
		Private ArtistsLargeImageList As System.Windows.Forms.ImageList
		Private radThemeManager1 As Telerik.WinControls.RadThemeManager
		Private radPanel1 As Telerik.WinControls.UI.RadPanel
		Private buttonSortAscending As Telerik.WinControls.UI.RadButton
		Private buttonSortDescending As Telerik.WinControls.UI.RadButton
		Private radOffice2007ScreenTip1 As Telerik.WinControls.UI.RadOffice2007ScreenTip
		Private radPanelDemoHolder As Telerik.WinControls.UI.RadPanel
	End Class
End Namespace
