Imports Microsoft.VisualBasic
Imports System
Namespace Telerik.Examples.WinControls.Editors.ComboBox.MusicCollection
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
			Dim themeSource1 As New Telerik.WinControls.ThemeSource()
			Me.cmbArtist = New Telerik.WinControls.UI.RadComboBox()
			Me.artistsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.musicCollectionDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.musicCollectionDataSet = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet()
			Me.ArtistsImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.cmbAlbum = New Telerik.WinControls.UI.RadComboBox()
			Me.artistsAlbumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.cmbSong = New Telerik.WinControls.UI.RadComboBox()
			Me.albumsSongsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.radLabel2 = New Telerik.WinControls.UI.RadLabel()
			Me.lblSelectedSong = New Telerik.WinControls.UI.RadLabel()
			Me.artistsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.ArtistsTableAdapter()
			Me.albumsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter()
			Me.songsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.SongsTableAdapter()
			Me.pictureBox = New System.Windows.Forms.PictureBox()
			Me.ArtistsLargeImageList = New System.Windows.Forms.ImageList(Me.components)
			Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
			Me.radPanel1 = New Telerik.WinControls.UI.RadPanel()
			Me.radButton1 = New Telerik.WinControls.UI.RadButton()
			Me.radButton2 = New Telerik.WinControls.UI.RadButton()
			Me.radOffice2007ScreenTip1 = New Telerik.WinControls.UI.RadOffice2007ScreenTip()
			CType(Me.cmbArtist, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.musicCollectionDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbAlbum, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.artistsAlbumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cmbSong, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.albumsSongsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.lblSelectedSong, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cmbArtist
			' 
			Me.cmbArtist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
			Me.cmbArtist.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.cmbArtist.DataSource = Me.artistsBindingSource
			Me.cmbArtist.DisplayMember = "ArtistName"
			Me.cmbArtist.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.cmbArtist.ForeColor = System.Drawing.Color.Black
			Me.cmbArtist.ImageList = Me.ArtistsImageList
			Me.cmbArtist.IntegralHeight = True
			Me.cmbArtist.Location = New System.Drawing.Point(25, 140)
			Me.cmbArtist.MaxDropDownItems = 3
			Me.cmbArtist.MaxLength = 32767
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
			Me.cmbArtist.ThemeName = "MusicCollection"
'			Me.cmbArtist.TextChanged += New System.EventHandler(Me.cmbArtist_TextChanged);
			Me.cmbArtist.Virtualized = False
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
			Me.ArtistsImageList.Images.SetKeyName(0, "smallSting.png")
			Me.ArtistsImageList.Images.SetKeyName(1, "smallDepeche.png")
			Me.ArtistsImageList.Images.SetKeyName(2, "smallSheril.png")
			Me.ArtistsImageList.Images.SetKeyName(3, "smallPinkFloyd.png")
			Me.ArtistsImageList.Images.SetKeyName(4, "smallCLapton.png")
			Me.ArtistsImageList.Images.SetKeyName(5, "smallDeepPurple.png")
			Me.ArtistsImageList.Images.SetKeyName(6, "smallINXS.png")
			' 
			' cmbAlbum
			' 
			Me.cmbAlbum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
			Me.cmbAlbum.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.cmbAlbum.DataSource = Me.artistsAlbumsBindingSource
			Me.cmbAlbum.DisplayMember = "AlbumName"
			Me.cmbAlbum.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.cmbAlbum.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.cmbAlbum.ForeColor = System.Drawing.Color.Black
			Me.cmbAlbum.IntegralHeight = True
			Me.cmbAlbum.Location = New System.Drawing.Point(252, 140)
			Me.cmbAlbum.MaxDropDownItems = 6
			Me.cmbAlbum.MaxLength = 32767
			Me.cmbAlbum.Name = "cmbAlbum"
			Me.cmbAlbum.NullText = "Select Album"
			' 
			' 
			' 
			Me.cmbAlbum.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
			Me.cmbAlbum.RootElement.ForeColor = System.Drawing.Color.Black
			Me.cmbAlbum.RootElement.ToolTipText = Nothing
			Me.cmbAlbum.Size = New System.Drawing.Size(160, 19)
			Me.cmbAlbum.TabIndex = 2
			Me.cmbAlbum.TabStop = False
			Me.cmbAlbum.ThemeName = "MusicCollection"
'			Me.cmbAlbum.TextChanged += New System.EventHandler(Me.cmbAlbum_TextChanged);
			Me.cmbAlbum.Virtualized = False
			' 
			' artistsAlbumsBindingSource
			' 
			Me.artistsAlbumsBindingSource.DataMember = "ArtistsAlbums"
			Me.artistsAlbumsBindingSource.DataSource = Me.artistsBindingSource
			' 
			' cmbSong
			' 
			Me.cmbSong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
			Me.cmbSong.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.cmbSong.DataSource = Me.albumsSongsBindingSource
			Me.cmbSong.DisplayMember = "SongName"
			Me.cmbSong.DropDownSizingMode = (CType((Telerik.WinControls.UI.SizingMode.RightBottom Or Telerik.WinControls.UI.SizingMode.UpDown), Telerik.WinControls.UI.SizingMode))
			Me.cmbSong.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
			Me.cmbSong.ForeColor = System.Drawing.Color.Black
			Me.cmbSong.IntegralHeight = True
			Me.cmbSong.Location = New System.Drawing.Point(433, 140)
			Me.cmbSong.MaxDropDownItems = 6
			Me.cmbSong.MaxLength = 32767
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
			Me.cmbSong.ThemeName = "MusicCollection"
'			Me.cmbSong.TextChanged += New System.EventHandler(Me.cmbSong_TextChanged);
			Me.cmbSong.Virtualized = False
			' 
			' albumsSongsBindingSource
			' 
			Me.albumsSongsBindingSource.DataMember = "AlbumsSongs"
			Me.albumsSongsBindingSource.DataSource = Me.artistsAlbumsBindingSource
			' 
			' radLabel2
			' 
			Me.radLabel2.BackColor = System.Drawing.Color.Transparent
			Me.radLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.radLabel2.ForeColor = System.Drawing.Color.SteelBlue
			Me.radLabel2.Location = New System.Drawing.Point(30, 174)
			Me.radLabel2.Name = "radLabel2"
			' 
			' 
			' 
			Me.radLabel2.RootElement.ForeColor = System.Drawing.Color.SteelBlue
			Me.radLabel2.RootElement.ToolTipText = Nothing
			Me.radLabel2.Size = New System.Drawing.Size(175, 26)
			Me.radLabel2.TabIndex = 4
			Me.radLabel2.Text = "You have selected:"
			Me.radLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' lblSelectedSong
			' 
			Me.lblSelectedSong.BackColor = System.Drawing.Color.Transparent
			Me.lblSelectedSong.Font = New System.Drawing.Font("Arial", 10F)
			Me.lblSelectedSong.ForeColor = System.Drawing.Color.SteelBlue
			Me.lblSelectedSong.Location = New System.Drawing.Point(125, 213)
			Me.lblSelectedSong.Name = "lblSelectedSong"
			' 
			' 
			' 
			Me.lblSelectedSong.RootElement.ForeColor = System.Drawing.Color.SteelBlue
			Me.lblSelectedSong.RootElement.ToolTipText = Nothing
			Me.lblSelectedSong.Size = New System.Drawing.Size(2, 2)
			Me.lblSelectedSong.TabIndex = 5
			Me.lblSelectedSong.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
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
			Me.pictureBox.Location = New System.Drawing.Point(28, 200)
			Me.pictureBox.Name = "pictureBox"
			Me.pictureBox.Size = New System.Drawing.Size(82, 83)
			Me.pictureBox.TabIndex = 6
			Me.pictureBox.TabStop = False
			' 
			' ArtistsLargeImageList
			' 
			Me.ArtistsLargeImageList.ImageStream = (CType(resources.GetObject("ArtistsLargeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.ArtistsLargeImageList.TransparentColor = System.Drawing.Color.Transparent
			Me.ArtistsLargeImageList.Images.SetKeyName(0, "bigSting.png")
			Me.ArtistsLargeImageList.Images.SetKeyName(1, "bigDepeche.png")
			Me.ArtistsLargeImageList.Images.SetKeyName(2, "bigSheril.png")
			Me.ArtistsLargeImageList.Images.SetKeyName(3, "bigPinkFloyd.png")
			Me.ArtistsLargeImageList.Images.SetKeyName(4, "bigCLapton.png")
			Me.ArtistsLargeImageList.Images.SetKeyName(5, "bigDeepPurple.png")
			Me.ArtistsLargeImageList.Images.SetKeyName(6, "bigINXS.png")
			' 
			' radThemeManager1
			' 
			themeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
			themeSource1.ThemeLocation = "Telerik.Examples.WinControls.Resources.MusicCollection.xml"
			Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() { themeSource1})
			' 
			' radPanel1
			' 
			Me.radPanel1.BackColor = System.Drawing.Color.Transparent
			Me.radPanel1.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Location = New System.Drawing.Point(469, 92)
			Me.radPanel1.Margin = New System.Windows.Forms.Padding(0)
			Me.radPanel1.Name = "radPanel1"
			' 
			' 
			' 
			Me.radPanel1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radPanel1.Size = New System.Drawing.Size(22, 18)
			Me.radPanel1.TabIndex = 7
			Me.radPanel1.ThemeName = "MusicCollection"
			Me.radPanel1.Visible = False
			CType(Me.radPanel1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButton1
			' 
			Me.radButton1.BackColor = System.Drawing.Color.Transparent
			Me.radButton1.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton1.ForeColor = System.Drawing.Color.Black
			Me.radButton1.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton1.Location = New System.Drawing.Point(195, 139)
			Me.radButton1.Name = "radButton1"
			' 
			' 
			' 
			Me.radButton1.RootElement.AutoToolTip = True
			Me.radButton1.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton1.RootElement.ToolTipText = "Sort Ascending"
			Me.radButton1.Size = New System.Drawing.Size(21, 23)
			Me.radButton1.TabIndex = 8
			Me.radButton1.Text = "radButton1"
			Me.radButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
'			Me.radButton1.Click += New System.EventHandler(Me.radButton1_Click);
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			CType(Me.radButton1.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "radButton1"
			CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
			CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.Transparent
			CType(Me.radButton1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton1.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
			' 
			' radButton2
			' 
			Me.radButton2.BackColor = System.Drawing.Color.Transparent
			Me.radButton2.DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			Me.radButton2.ForeColor = System.Drawing.Color.Black
			Me.radButton2.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			Me.radButton2.Location = New System.Drawing.Point(214, 139)
			Me.radButton2.Name = "radButton2"
			' 
			' 
			' 
			Me.radButton2.RootElement.AutoToolTip = True
			Me.radButton2.RootElement.ForeColor = System.Drawing.Color.Black
			Me.radButton2.RootElement.ScreenTip = Me.radOffice2007ScreenTip1.ScreenTipElement
			Me.radButton2.RootElement.ShouldPaint = True
			Me.radButton2.RootElement.ToolTipText = "Sort Descending"
			Me.radButton2.Size = New System.Drawing.Size(25, 23)
			Me.radButton2.TabIndex = 9
			Me.radButton2.Text = "radButton2"
			Me.radButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			Me.radButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			CType(Me.radButton2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
			CType(Me.radButton2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft
			CType(Me.radButton2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			CType(Me.radButton2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).DisplayStyle = Telerik.WinControls.DisplayStyle.Image
			CType(Me.radButton2.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "radButton2"
			CType(Me.radButton2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor2 = System.Drawing.Color.Transparent
			CType(Me.radButton2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor3 = System.Drawing.Color.Transparent
			CType(Me.radButton2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor4 = System.Drawing.Color.Transparent
			CType(Me.radButton2.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).BackColor = System.Drawing.Color.Transparent
			CType(Me.radButton2.GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
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
			Me.radOffice2007ScreenTip1.ScreenTipElement.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTip)
			Me.radOffice2007ScreenTip1.Size = New System.Drawing.Size(107, 45)
			Me.radOffice2007ScreenTip1.TabIndex = 0
			Me.radOffice2007ScreenTip1.TemplateType = GetType(Telerik.WinControls.UI.RadOffice2007ScreenTip)
			CType(Me.radOffice2007ScreenTip1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadLabelElement).Text = "Sort Descending"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))), (CInt(Fix((CByte(248))))))
			Me.BackgroundImage = (CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image))
			Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
			Me.Controls.Add(Me.radButton2)
			Me.Controls.Add(Me.radButton1)
			Me.Controls.Add(Me.radPanel1)
			Me.Controls.Add(Me.pictureBox)
			Me.Controls.Add(Me.lblSelectedSong)
			Me.Controls.Add(Me.radLabel2)
			Me.Controls.Add(Me.cmbSong)
			Me.Controls.Add(Me.cmbAlbum)
			Me.Controls.Add(Me.cmbArtist)
			Me.Location = New System.Drawing.Point(15, 15)
			Me.Name = "Form1"
			Me.Size = New System.Drawing.Size(990, 753)
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.cmbArtist, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.artistsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.musicCollectionDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbAlbum, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.artistsAlbumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cmbSong, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.albumsSongsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radLabel2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.lblSelectedSong, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radButton2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.radOffice2007ScreenTip1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents cmbArtist As Telerik.WinControls.UI.RadComboBox
		Private WithEvents cmbAlbum As Telerik.WinControls.UI.RadComboBox
		Private WithEvents cmbSong As Telerik.WinControls.UI.RadComboBox
		Private radLabel2 As Telerik.WinControls.UI.RadLabel
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
		Private WithEvents radButton1 As Telerik.WinControls.UI.RadButton
		Private radButton2 As Telerik.WinControls.UI.RadButton
		Private radOffice2007ScreenTip1 As Telerik.WinControls.UI.RadOffice2007ScreenTip
	End Class
End Namespace
