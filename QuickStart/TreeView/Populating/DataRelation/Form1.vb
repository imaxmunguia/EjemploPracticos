Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Examples.WinControls.Editors.ComboBox
Imports Telerik.Examples.WinControls.Properties
Imports Telerik.QuickStart.WinControls
Imports Telerik.WinControls.UI

Namespace Telerik.Examples.WinControls.TreeView.Populating.DataRelation
	''' <summary>
	''' RadTreeView example
	''' </summary>
	Public Partial Class Form1
		Inherits TreeExamplesControl
        Private bottomRightBitmap As Bitmap = My.Resources.TV_music
		Private listAlbumsBindingSource As BindingSource = New BindingSource()
		Private listSongsBindingSource As BindingSource = New BindingSource()
		Private internalUpdate As Boolean = False

		Public Sub New()
			InitializeComponent()
			AddHandler listAlbumsBindingSource.CurrentChanged, AddressOf listAlbumsBindingSource_CurrentChanged
			AddHandler listSongsBindingSource.CurrentChanged, AddressOf listSongsBindingSource_CurrentChanged
			AddHandler radTreeView1.SelectedNodeChanging, AddressOf radTreeView1_SelectedNodeChanging
			AddHandler radTreeView1.SelectedNodeChanged, AddressOf radTreeView1_SelectedNodeChanged
			me.radTreeView1.AllowDragDrop = true
			Me.SelectedControl = Me.radTreeView1
		End Sub

		Private Sub radTreeView1_SelectedNodeChanging(ByVal sender As Object, ByVal e As RadTreeViewCancelEventArgs)
			e.Cancel = Me.internalUpdate
		End Sub

		Private Sub radTreeView1_SelectedNodeChanged(ByVal sender As Object, ByVal e As RadTreeViewEventArgs)
			If e.Node.Level = 0 Then
				Return
			End If

			If e.Node.Level = 1 Then
				SyncSecondLevel(e)

				Return
			End If

			SyncThreeLevel(e)
		End Sub

		Private Sub SyncSecondLevel(ByVal e As RadTreeViewEventArgs)
			Me.internalUpdate = True
			Dim artistID As Object = (CType(e.Node.Parent.DataBoundItem, DataRowView))("ArtistID")
			Dim parentIndex As Integer = Me.artistsBindingSource.Find("ArtistID", artistID)
			If parentIndex >= 0 Then
				Me.artistsBindingSource.Position = parentIndex
			End If

			Dim albumID As Object = (CType(e.Node.DataBoundItem, DataRowView))("AlbumID")
			Dim index As Integer = Me.listAlbumsBindingSource.Find("AlbumID", albumID)
			If index >= 0 Then
				Me.listAlbumsBindingSource.Position = index
			End If
			Me.internalUpdate = False
		End Sub

		Private Sub SyncThreeLevel(ByVal e As RadTreeViewEventArgs)
			Me.internalUpdate = True
			Dim artistID As Object = (CType(e.Node.Parent.Parent.DataBoundItem, DataRowView))("ArtistID")
			Dim parentIndex As Integer = Me.artistsBindingSource.Find("ArtistID", artistID)
			If parentIndex >= 0 Then
				Me.artistsBindingSource.Position = parentIndex
			End If

			Dim albumID As Object = (CType(e.Node.Parent.DataBoundItem, DataRowView))("AlbumID")
			Dim index As Integer = Me.listAlbumsBindingSource.Find("AlbumID", albumID)
			If index >= 0 Then
				Me.listAlbumsBindingSource.Position = index
			End If

			Dim songID As Object = (CType(e.Node.DataBoundItem, DataRowView))("SongID")
			Dim songIndex As Integer = Me.listSongsBindingSource.Find("SongID", songID)
			If songIndex >= 0 Then
				Me.listSongsBindingSource.Position = songIndex
			End If
			Me.internalUpdate = False
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.artistsTableAdapter.Fill(musicCollectionDataSet.Artists)
			Me.albumsTableAdapter.Fill(musicCollectionDataSet.Albums)
			Me.songsTableAdapter.Fill(musicCollectionDataSet.Songs)

			Me.radTreeView1.DataSource = artistsBindingSource
			Me.radTreeView1.DisplayMember = "ArtistName"

			Me.radTreeView1.RelationBindings.Add(albumsBindingSource, "AlbumName", "ArtistID")
			Me.radTreeView1.RelationBindings.Add(songsBindingSource, "SongName", "AlbumID")

			Me.listAlbumsBindingSource.DataMember = "ArtistsAlbums"
			Me.listAlbumsBindingSource.DataSource = Me.artistsBindingSource
			Me.radListLevelTwo.DataSource = Me.listAlbumsBindingSource

			Me.listSongsBindingSource.DataMember = "AlbumsSongs"
			Me.listSongsBindingSource.DataSource = Me.listAlbumsBindingSource
			Me.radListLevelThree.DataSource = Me.listSongsBindingSource
		End Sub

		Private Sub listAlbumsBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.listAlbumsBindingSource.Current Is Nothing Then
				Return
			End If

			Dim albumID As Object = (CType(Me.listAlbumsBindingSource.Current, DataRowView))("AlbumID")
			Dim index As Integer = Me.albumsBindingSource.Find("AlbumID", albumID)
			If index >= 0 Then
				Me.albumsBindingSource.Position = index
			End If
		End Sub

		Private Sub listSongsBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As EventArgs)
			If Me.listSongsBindingSource.Current Is Nothing Then
				Return
			End If

			Dim songID As Object = (CType(Me.listSongsBindingSource.Current, DataRowView))("SongID")
			Dim index As Integer = Me.songsBindingSource.Find("SongID", songID)
			If index >= 0 Then
				Me.songsBindingSource.Position = index
			End If
		End Sub


		Public Overrides ReadOnly Property TreeControl() As RadTreeView
			Get
				Return Me.radTreeView1
			End Get
		End Property

		Public Overrides ReadOnly Property BottomRightImage() As Bitmap
			Get
				Return bottomRightBitmap
			End Get
		End Property

		Public Overrides ReadOnly Property HeaderText() As String
			Get
				Return "Music Collection"
			End Get
		End Property

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			Me.radTreeView1.AllowEdit = False
			Me.radTreeView1.AllowAdd = False
			Me.radTreeView1.AllowRemove = False
		End Sub

		Private Sub radTreeView1_NodeExpandedChanging(ByVal sender As Object, ByVal e As Telerik.WinControls.UI.RadTreeViewCancelEventArgs) Handles radTreeView1.NodeExpandedChanging
			Dim nodes As RadTreeNodeCollection = e.Node.Nodes
			For Each node As RadTreeNode In nodes
				node.ImageIndex = node.Level
			Next node
		End Sub
	End Class
End Namespace

