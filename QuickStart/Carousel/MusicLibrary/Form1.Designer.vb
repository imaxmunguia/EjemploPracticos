Imports Telerik.WinControls

Namespace Telerik.Examples.WinControls.Carousel.MusicLibrary
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim carouselBezierPath1 As New Telerik.WinControls.UI.CarouselBezierPath()
            Dim themeSource1 As New Telerik.WinControls.ThemeSource()
            Me.radCarouselAlbums = New Telerik.WinControls.UI.RadCarousel()
            Me.albumsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.musicCollectionDataSet = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet()
            Me.roundRectShape1 = New Telerik.WinControls.RoundRectShape(Me.components)
            Me.radThemeManager1 = New Telerik.WinControls.RadThemeManager()
            Me.albumsTableAdapter = New Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter()
            Me.radTitleBar1 = New Telerik.WinControls.UI.RadTitleBar()
            Me.radBtnDownloads = New Telerik.WinControls.UI.RadButton()
            Me.radBtnArtists = New Telerik.WinControls.UI.RadButton()
            Me.radBtnAlbums = New Telerik.WinControls.UI.RadButton()
            Me.radBtnSongs = New Telerik.WinControls.UI.RadButton()
            Me.radComboSearch = New Telerik.WinControls.UI.RadDropDownList()
            DirectCast(Me.radCarouselAlbums, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radBtnDownloads, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radBtnArtists, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radBtnAlbums, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radBtnSongs, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.radComboSearch, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radCarouselAlbums
            ' 
            Me.radCarouselAlbums.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.radCarouselAlbums.BackColor = System.Drawing.Color.Transparent
            Me.radCarouselAlbums.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            carouselBezierPath1.CtrlPoint1 = New Telerik.WinControls.UI.Point3D(12.2786304604486, 48.1662591687042, 300)
            carouselBezierPath1.CtrlPoint2 = New Telerik.WinControls.UI.Point3D(87.8394332939787, 47.6772616136919, 300)
            carouselBezierPath1.FirstPoint = New Telerik.WinControls.UI.Point3D(6.3754427390791, 50.8557457212714, -400)
            carouselBezierPath1.LastPoint = New Telerik.WinControls.UI.Point3D(93.8606847697757, 51.1002444987775, -400)
            carouselBezierPath1.ZScale = 200
            Me.radCarouselAlbums.CarouselPath = carouselBezierPath1
            Me.radCarouselAlbums.DataSource = Me.albumsBindingSource
            Me.radCarouselAlbums.ForeColor = System.Drawing.Color.White
            Me.radCarouselAlbums.Location = New System.Drawing.Point(2, 161)
            Me.radCarouselAlbums.Name = "radCarouselAlbums"
            Me.radCarouselAlbums.NavigationButtonsOffset = New System.Drawing.Size(80, 20)
            ' 
            ' 
            ' 
            Me.radCarouselAlbums.RootElement.ForeColor = System.Drawing.Color.White
            Me.radCarouselAlbums.SelectedIndex = -1
            Me.radCarouselAlbums.Size = New System.Drawing.Size(845, 404)
            Me.radCarouselAlbums.TabIndex = 0
            Me.radCarouselAlbums.ThemeName = "ControlDefault"
            Me.radCarouselAlbums.VisibleItemCount = 7
            DirectCast(Me.radCarouselAlbums.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            DirectCast(Me.radCarouselAlbums.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            DirectCast(Me.radCarouselAlbums.GetChildAt(0).GetChildAt(3), Telerik.WinControls.UI.RadRepeatButtonElement).Image = My.Resources.carousel_leftArrow
            DirectCast(Me.radCarouselAlbums.GetChildAt(0).GetChildAt(4), Telerik.WinControls.UI.RadRepeatButtonElement).Image = My.Resources.carousel_rightArrow
            ' 
            ' albumsBindingSource
            ' 
            Me.albumsBindingSource.DataMember = "Albums"
            Me.albumsBindingSource.DataSource = Me.musicCollectionDataSet
            ' 
            ' musicCollectionDataSet
            ' 
            Me.musicCollectionDataSet.DataSetName = "MusicCollectionDataSet"
            Me.musicCollectionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' radThemeManager1
            ' 

            themeSource1.StorageType = Telerik.WinControls.ThemeStorageType.Resource
            themeSource1.ThemeLocation = "ButtonMusicLibrary.xml"
            Me.radThemeManager1.LoadedThemes.AddRange(New Telerik.WinControls.ThemeSource() {themeSource1})
            ' 
            ' albumsTableAdapter
            ' 
            Me.albumsTableAdapter.ClearBeforeFill = True
            ' 
            ' radTitleBar1
            ' 
            Me.radTitleBar1.BackColor = System.Drawing.Color.Transparent
            Me.radTitleBar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
            Me.radTitleBar1.Text = "Music Library Demo"
            Me.radTitleBar1.Dock = System.Windows.Forms.DockStyle.Top
            Me.radTitleBar1.Location = New System.Drawing.Point(2, 2)
            Me.radTitleBar1.Name = "radTitleBar1"
            Me.radTitleBar1.Size = New System.Drawing.Size(846, 27)
            Me.radTitleBar1.TabIndex = 2
            Me.radTitleBar1.TabStop = False
            Me.radTitleBar1.Text = "radTitleBar1"
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(1), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Margin = New System.Windows.Forms.Padding(7, 0, 7, 0)
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.ImagePrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Text = "Music Library Demo"
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).ForeColor = System.Drawing.Color.White
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Font = New System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(178))
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(1), Telerik.WinControls.Primitives.TextPrimitive).Margin = New System.Windows.Forms.Padding(10, 0, 0, 0)
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadImageButtonElement).Image = My.Resources.FL_min
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadImageButtonElement).Margin = New System.Windows.Forms.Padding(0, 0, -2, 0)
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.UI.RadImageButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Name = "MinimizeButtonFill"
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(0).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadImageButtonElement).Image = My.Resources.FL_Max
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadImageButtonElement).Margin = New System.Windows.Forms.Padding(0, 0, -2, 0)
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1), Telerik.WinControls.UI.RadImageButtonElement).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Name = "MaximizeButtonFill"
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(1).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2), Telerik.WinControls.UI.RadImageButtonElement).Image = My.Resources.FL_Close
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Name = "CloseButtonFill"
            DirectCast(Me.radTitleBar1.GetChildAt(0).GetChildAt(2).GetChildAt(2).GetChildAt(2).GetChildAt(2), Telerik.WinControls.Primitives.BorderPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Collapsed
            ' 
            ' radBtnDownloads
            ' 
            Me.radBtnDownloads.AllowShowFocusCues = True
            Me.radBtnDownloads.BackColor = System.Drawing.Color.Transparent
            Me.radBtnDownloads.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radBtnDownloads.ForeColor = System.Drawing.Color.Black
            Me.radBtnDownloads.Location = New System.Drawing.Point(489, 47)
            Me.radBtnDownloads.Name = "radBtnDownloads"
            ' 
            ' 
            ' 
            Me.radBtnDownloads.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radBtnDownloads.Size = New System.Drawing.Size(119, 34)
            Me.radBtnDownloads.TabIndex = 3
            Me.radBtnDownloads.Text = "Downloads"
            Me.radBtnDownloads.ThemeName = "MusicLibrary"
            DirectCast(Me.radBtnDownloads.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Downloads"
            DirectCast(Me.radBtnDownloads.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).BackColor = System.Drawing.Color.Transparent
            DirectCast(Me.radBtnDownloads.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            DirectCast(Me.radBtnDownloads.GetChildAt(0).GetChildAt(3), Telerik.WinControls.Primitives.FocusPrimitive).BackColor = System.Drawing.Color.Transparent
            ' 
            ' radBtnArtists
            ' 
            Me.radBtnArtists.AllowShowFocusCues = True
            Me.radBtnArtists.BackColor = System.Drawing.Color.Transparent
            Me.radBtnArtists.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radBtnArtists.ForeColor = System.Drawing.Color.Black
            Me.radBtnArtists.Location = New System.Drawing.Point(619, 47)
            Me.radBtnArtists.Name = "radBtnArtists"
            ' 
            ' 
            ' 
            Me.radBtnArtists.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radBtnArtists.Size = New System.Drawing.Size(77, 34)
            Me.radBtnArtists.TabIndex = 3
            Me.radBtnArtists.Text = "Artists"
            Me.radBtnArtists.ThemeName = "MusicLibrary"
            DirectCast(Me.radBtnArtists.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Artists"
            DirectCast(Me.radBtnArtists.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' radBtnAlbums
            ' 
            Me.radBtnAlbums.AllowShowFocusCues = True
            Me.radBtnAlbums.BackColor = System.Drawing.Color.Transparent
            Me.radBtnAlbums.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radBtnAlbums.ForeColor = System.Drawing.Color.Black
            Me.radBtnAlbums.Location = New System.Drawing.Point(705, 47)
            Me.radBtnAlbums.Name = "radBtnAlbums"
            ' 
            ' 
            ' 
            Me.radBtnAlbums.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radBtnAlbums.Size = New System.Drawing.Size(77, 34)
            Me.radBtnAlbums.TabIndex = 3
            Me.radBtnAlbums.Text = "Albums"
            Me.radBtnAlbums.ThemeName = "MusicLibrary"
            DirectCast(Me.radBtnAlbums.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Albums"
            DirectCast(Me.radBtnAlbums.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' radBtnSongs
            ' 
            Me.radBtnSongs.AllowShowFocusCues = True
            Me.radBtnSongs.BackColor = System.Drawing.Color.Transparent
            Me.radBtnSongs.Font = New System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
            Me.radBtnSongs.ForeColor = System.Drawing.Color.Black
            Me.radBtnSongs.Location = New System.Drawing.Point(786, 47)
            Me.radBtnSongs.Name = "radBtnSongs"
            ' 
            ' 
            ' 
            Me.radBtnSongs.RootElement.ForeColor = System.Drawing.Color.Black
            Me.radBtnSongs.Size = New System.Drawing.Size(67, 34)
            Me.radBtnSongs.TabIndex = 3
            Me.radBtnSongs.Text = "Songs"
            Me.radBtnSongs.ThemeName = "MusicLibrary"
            DirectCast(Me.radBtnSongs.GetChildAt(0), Telerik.WinControls.UI.RadButtonElement).Text = "Songs"
            DirectCast(Me.radBtnSongs.GetChildAt(0).GetChildAt(0), Telerik.WinControls.Primitives.FillPrimitive).Visibility = Telerik.WinControls.ElementVisibility.Hidden
            ' 
            ' radComboSearch
            ' 
            Me.radComboSearch.Location = New System.Drawing.Point(642, 113)
            Me.radComboSearch.Name = "radComboSearch"
            Me.radComboSearch.NullText = "Search..."
            ' 
            ' 
            ' 
            Me.radComboSearch.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
            Me.radComboSearch.Size = New System.Drawing.Size(180, 20)
            Me.radComboSearch.TabIndex = 4

            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.BackgroundImage = My.Resources.carousel_first_look_bg
            Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center
            Me.BorderColor = System.Drawing.SystemColors.WindowFrame
            Me.ClientSize = New System.Drawing.Size(850, 620)
            Me.Controls.Add(Me.radComboSearch)
            Me.Controls.Add(Me.radBtnSongs)
            Me.Controls.Add(Me.radBtnAlbums)
            Me.Controls.Add(Me.radBtnArtists)
            Me.Controls.Add(Me.radBtnDownloads)
            Me.Controls.Add(Me.radTitleBar1)
            Me.Controls.Add(Me.radCarouselAlbums)
            Me.MaximizeBox = False
            Me.MaximumSize = New System.Drawing.Size(850, 620)
            Me.MinimumSize = New System.Drawing.Size(850, 620)
            Me.Name = "Form1"
            Me.Padding = New System.Windows.Forms.Padding(2, 2, 2, 5)
            Me.Shape = Me.roundRectShape1
            Me.Text = "Music Library Demo"
            DirectCast(Me.radCarouselAlbums, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.albumsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.musicCollectionDataSet, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radTitleBar1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radBtnDownloads, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radBtnArtists, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radBtnAlbums, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radBtnSongs, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.radComboSearch, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private WithEvents radCarouselAlbums As Telerik.WinControls.UI.RadCarousel
        Private musicCollectionDataSet As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSet
        Private radThemeManager1 As Telerik.WinControls.RadThemeManager
        Private roundRectShape1 As Telerik.WinControls.RoundRectShape
        Private albumsBindingSource As System.Windows.Forms.BindingSource
        Private albumsTableAdapter As Telerik.Examples.WinControls.DataSources.MusicCollectionDataSetTableAdapters.AlbumsTableAdapter
        Private radTitleBar1 As Telerik.WinControls.UI.RadTitleBar
        Private radBtnDownloads As Telerik.WinControls.UI.RadButton
        Private radBtnArtists As Telerik.WinControls.UI.RadButton
        Private radBtnAlbums As Telerik.WinControls.UI.RadButton
        Private radBtnSongs As Telerik.WinControls.UI.RadButton
        Private WithEvents radComboSearch As Telerik.WinControls.UI.RadDropDownList
    End Class
End Namespace
